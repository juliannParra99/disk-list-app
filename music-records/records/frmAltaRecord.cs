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
using System.Configuration; //agrega la referencia en ensamblados, para poder usar la configuracion de app.config para guardar la imagen en la carpeta elegida

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

        // atributos privados
        private  Discos disco = null;
        private OpenFileDialog archivo = null;

        //trae datos del desplegable
        private void frmAltaRecord_Load(object sender, EventArgs e)
        {
            EdicionNegocio edicionNegocio = new EdicionNegocio();
            EstiloNegocio estiloNegocio = new EstiloNegocio();

            try
            {
                //aca se va a configurar el valor preseleccionado del objeto a modificar en el comboBox: se hace  estableciendo una relacion clave-valor
                //utilizo los nombres de las propiedades de las clases Estilo y edicion
                cboEstilo.DataSource = estiloNegocio.listar();
                cboEstilo.ValueMember = "Id"; //clave
                cboEstilo.DisplayMember = "Estilo_disco"; //valor
                cboEdicion.DataSource = edicionNegocio.listar();
                cboEdicion.ValueMember = "Id"; 
                cboEdicion.DisplayMember = "Edicion_disco"; 

                //si el discos es distinto de nulo es modificar; por lo que tengo que precargar los datos del pokemon a modificar
                if (disco != null)
                {
                    txtTitulo.Text = disco.Titulo;
                    txtCanciones.Text = disco.CantidadCanciones.ToString();
                    txtUrlImagen.Text = disco.UrlImagen;
                    cargarImagen(disco.UrlImagen);
                    //una ves cargados los desplegas estan cargados arriba del if, quiero preseleccionar un valor
                    cboEstilo.SelectedValue = disco.Estilo.Id; //y con esto obtengo el Estilo_disco; hay que acomodar la consulta para que traiga la consulta sino no funciona
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
                if (validarCamposObligatorios())//si  da verdadero se ejecuta el return
                    return;

                //si no esta nulo no se crea un nuevo disco, va a remplazar los valores existentes
                disco.Titulo = txtTitulo.Text;
                disco.CantidadCanciones = int.Parse(txtCanciones.Text);
                disco.UrlImagen = txtUrlImagen.Text;
                disco.Estilo = (Estilo)cboEstilo.SelectedItem;
                disco.Edicion = (Edicion)cboEdicion.SelectedItem;


                // para agregar esto a la base de datos; 
                //si es distinto de 0 estoy modificando por que el id ya existe
                if (disco.Id !=0)
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
                if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["disks-app"] + archivo.SafeFileName);
                }

                Close();
                                               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        //cuando salgo del txtUrlImagen se muestre la imagen en el pictureBox
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

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

                
            }
        }

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
                MessageBox.Show("Please enter the name of the disk.");
                return true; 
            }
            if (string.IsNullOrEmpty(txtCanciones.Text))
            {
                MessageBox.Show("Please enter the number of songs.");
                return true;
            }
            if (!(soloNumeros(txtCanciones.Text)))
            {
                MessageBox.Show("Please enter only numbers");
                return true;
            }
            return false;
        }
    }
}

