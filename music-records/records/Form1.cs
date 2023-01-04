using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace records
{
    public partial class Form1 : Form
    {
            private List<Discos> ListaDiscos; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            
            DiscosNegocio negocio = new DiscosNegocio(); 
            ListaDiscos  = negocio.listar();
            dgvDiscos.DataSource = ListaDiscos;
            
            dgvDiscos.Columns["urlIMagen"].Visible = false; 

            cargarImagen(ListaDiscos[0].UrlImagen); 

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
    }
}
