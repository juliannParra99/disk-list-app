using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; //se agrega para guardar el archivo local en una carpeta
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Configuration; //agre la referencia en ensamblados, para poder usar la configuracion de app.config para guardar la imagen en la carpeta elegida

namespace records
{
    public partial class frmAltaRecord : Form
    {
        public frmAltaRecord()
        {
            InitializeComponent();
        }

        //sobrecarga de constructor
        public  frmAltaRecord(Discos disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Update Disk";

        }

        private  Discos disco = null;
        //agrego el atributo privado
        private OpenFileDialog archivo = null;

        //para que traiga, al momentod de cargar el form, en el desplegable los datos que el usuario quiera elegir
        private void frmAltaRecord_Load(object sender, EventArgs e)
        {
            EdicionNegocio edicionNegocio = new EdicionNegocio();
            EstiloNegocio estiloNegocio = new EstiloNegocio();

            try
            {
                //aca se va a configurar el valor preseleccionado del objeto a modificar en el comboBox: lo hacemos estableciendo una relacion clave-valor
                //utilizo los nombres de las propiedades de las clases Estilo y edicion
                cboEstilo.DataSource = estiloNegocio.listar();
                cboEstilo.ValueMember = "Id"; //clave
                cboEstilo.DisplayMember = "Estilo_disco"; //valor
                cboEdicion.DataSource = edicionNegocio.listar();
                cboEdicion.ValueMember = "Id"; //clave
                cboEdicion.DisplayMember = "Edicion_disco"; //valor

                //si el discos es distinto de nulo es modificar; por lo que tengo que precargar los datos del pokemon a modificar
                if (disco != null)
                {
                    txtTitulo.Text = disco.Titulo;
                    txtCanciones.Text = disco.CantidadCanciones.ToString();
                    txtUrlImagen.Text = disco.UrlImagen;
                    cargarImagen(disco.UrlImagen);
                    //una ves cargados los desplegas estan cargados arriba del if, quiero preseleccionar un valor
                    cboEstilo.SelectedValue = disco.Estilo.Id; //y con esto obtengo el Estilo_disco; tengoq que acomodar la consulta para que traiga la consulta sino no funciona
                    cboEdicion.SelectedValue = disco.Edicion.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_click_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_click_Click(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();

            try
            {
                //si esta en nulo queres agregar un nuevo disco
                if (disco== null)
                {
                    disco = new Discos();
                }

                //si hay algun valor de la validacion que de true, entonces corto la ejecucion del resto
                if (validarCamposObligatorios())//si esto da verdadero se ejecuta el return
                    return;

                //si no esta nulo no se crea un nuevo disco, va a remplazar los valores existentes
                disco.Titulo = txtTitulo.Text;
                disco.CantidadCanciones = int.Parse(txtCanciones.Text);
                disco.UrlImagen = txtUrlImagen.Text;
                disco.Estilo = (Estilo)cboEstilo.SelectedItem;
                disco.Edicion = (Edicion)cboEdicion.SelectedItem;


                // ahora hay que agregar esto a la base de datos; usamos negocio y su metodo agregar disco para insertarlo
                //si es distinto de 0 estoy modificando por que el id ya existe
                if (disco.Id !=0)//agrego la property Id en discos
                {
                    negocio.modificar(disco);
                    MessageBox.Show("Modified successfully.");

                }
                else
                {
                    negocio.AgregarDisco(disco);
                    MessageBox.Show("Added successfully.");
                }

                //guardo la imagen si la levanto localmnte, cuando toco el boton aceptar
                //si es distinto de null, por que paso port btnAgregarImagen_click, y la text box no contiene HTTP, osea si no es una imagen de internet, guardo la imagen en la carpeta
                if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                {
                    // la clase file tiene metodos utiles de tipo crud que son utiles y tienen muchas utilidades que vale la pena implementar o explorar
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["disks-app"] + archivo.SafeFileName);
                }

                Close();
                                               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        //para que cuando salgo del txtUrlImagen se muestre la imagen en el pictureBox
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
        //metodo copiado de frmRecords: lo puedo usar por que ambos picture box tienen el mismo nombre
        //lo ideal seria tenerlo en una clase helper por ejemplo
        private void cargarImagen(string imagen)
        {
            try
            {
                pbDiscos.Load(imagen);
            }
            catch (Exception ex)
            {
                pbDiscos.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //guardo la imagen en una carpeta
                //tras la configuracion de referencia system.configuration
                //copia el archivo en la carpeta seleccionada: aplicable para varias funcionalidades
                //lo voy a poner en el btnAgregar, por que quiero que solo se guarde la imagen cuando toque el boton 'aceptar', no cuando  levante la imagen

                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["disks-app"] + archivo.SafeFileName);
            }
        }

        //metodo para validar que las  cajas de texto solo contengan numeros: lo ideal es colocarlo en una clase para no tener que copiarla
        //cada vez que lo use
        private bool soloNumeros(string cadena)
        {
            foreach (char character in cadena)
            {
                if (!(char.IsNumber(character)))
                {
                    return false;
                }
            }
            return true;
        }
        //para que no se corte la ejecion de todo esto tiene que ser verdadero. 
        private bool validarCamposObligatorios()
        {
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("Ingrese el nombre del disco.");
                return true; 
            }
            if (string.IsNullOrEmpty(txtCanciones.Text))
            {
                MessageBox.Show("Ingrese la cantidad de canciones.");
                return true;
            }
            if (!(soloNumeros(txtCanciones.Text)))
            {
                MessageBox.Show("Por favor ingrese solo numeros");
                return true;
            }
            return false;
        }
    }
}

