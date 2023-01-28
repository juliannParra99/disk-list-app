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
    public partial class frmRecords : Form
    {

        private List<Discos> ListaDiscos; 
        public frmRecords()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            cargar();

        }

        private void cargar()
        {
            DiscosNegocio negocio = new DiscosNegocio();

            // se agrega try catch para validar en caso de dbNull en columnas
            try
            {
                ListaDiscos = negocio.listar();
                dgvDiscos.DataSource = ListaDiscos;
                dgvDiscos.Columns["Id"].Visible = false;
                dgvDiscos.Columns["urlIMagen"].Visible = false;

                cargarImagen(ListaDiscos[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        
        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Discos seleccionado= (Discos)dgvDiscos.CurrentRow.DataBoundItem;
            
            cargarImagen(seleccionado.UrlImagen); 

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaRecord alta = new frmAltaRecord();
            alta.ShowDialog();
            //cuando se cierre el otro form,traigo los datos actualizados
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Discos seleccionado;
            seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;

            frmAltaRecord modificar = new frmAltaRecord(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            Discos seleccionado;
            try
            {   //esto para que no se borre directamente al apretar el boton, y te pida confirmarlo
                DialogResult respuesta = MessageBox.Show("¿Estas seguro que queres eliminar este registro?","Eliminar",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
