using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace records
{
    public partial class frmAltaRecord : Form
    {
        public frmAltaRecord()
        {
            InitializeComponent();
        }

        public  frmAltaRecord(Discos disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar Disco";

        }

        private  Discos disco = null;

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
                    MessageBox.Show("Modificado exitosamente.");

                }
                else
                {
                    negocio.AgregarDisco(disco);
                    MessageBox.Show("Agregado exitosamente.");
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
    }
}

