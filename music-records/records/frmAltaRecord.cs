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

        //para que traiga, al momentod de cargar el form, en el desplegable los datos que el usuario quiera elegir
        private void frmAltaRecord_Load(object sender, EventArgs e)
        {
            EdicionNegocio edicionNegocio = new EdicionNegocio();
            EstiloNegocio estiloNegocio = new EstiloNegocio();

            try
            {
                cboEstilo.DataSource = estiloNegocio.listar();
                cboEdicion.DataSource = edicionNegocio.listar();
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
            Discos discoNuevo = new Discos();
            DiscosNegocio negocio = new DiscosNegocio();

            try
            {
                discoNuevo.Titulo = textTitulo.Text;
                discoNuevo.CantidadCanciones = int.Parse(txtCanciones.Text);
                discoNuevo.UrlImagen = txtUrlImagen.Text;
                discoNuevo.Estilo = (Estilo)cboEstilo.SelectedItem;
                discoNuevo.Edicion = (Edicion)cboEdicion.SelectedItem;


                // ahora hay que agregar esto a la base de datos; usamos negocio y su metodo agregar disco para insertarlo
                negocio.AgregarDisco(discoNuevo);
                MessageBox.Show("Agregado exitosamente");
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
