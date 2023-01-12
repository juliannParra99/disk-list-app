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

        private void frmAltaRecord_Load(object sender, EventArgs e)
        {

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
                discoNuevo.Titulo = txtTitulo.Text;
                discoNuevo.CantidadCanciones = int.Parse(txtCanciones.Text);

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
