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
                discoNuevo.Estilo = (Estilo)cboEstilo.SelectedItem;
                discoNuevo.Edicion = (Edicion)cboEdicion.SelectedItem;


                // ahora hay que agregar esto a la base de datos usamos negocio
                negocio.AgregarDisco(discoNuevo);
                MessageBox.Show("Agregado exitosamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

    }
}
