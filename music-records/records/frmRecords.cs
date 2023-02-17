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

            // se valida en caso de dbNull en columnas
            try
            {
                ListaDiscos = negocio.listar();
                dgvDiscos.DataSource = ListaDiscos;
                ocultarColumnas();
                cargarImagen(ListaDiscos[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        // metodo ocultar columnas
        private void ocultarColumnas()
        {
            dgvDiscos.Columns["Id"].Visible = false;
            dgvDiscos.Columns["urlIMagen"].Visible = false;

        }

        //para el buscador rapido: validacion
        //si hay una grilla actual seleccionada y es ditinto de nulo, entonces trata de transformarlo y cargar la iamgen sino no
        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiscos.CurrentCell != null) 
                
            {
                Discos seleccionado= (Discos)dgvDiscos.CurrentRow.DataBoundItem;
            
                cargarImagen(seleccionado.UrlImagen); 

            }

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
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Discos seleccionado;
            try
            {
                seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;

                frmAltaRecord modificar = new frmAltaRecord(seleccionado);
                modificar.ShowDialog();
                cargar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Choose the disk you want to modify.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            Discos seleccionado;
            try
            {   //confirmacion del delete
                DialogResult respuesta = MessageBox.Show("Are you sure you want to delete this record?", "Delete",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            //creo una lista que va a contener mi filtro
            List<Discos> discosFiltrados;

            string filtro = txtFiltroRapido.Text;

            if (filtro != "")
            {
                //el valor del filtro va a ser a partir de la lista de lectura que creamos como atributo llamada: listaDiscos, a partir de esa lista
                //vamos a generar una lista filtrada . 
                //el findAll requiere una expresion lambda
                discosFiltrados = ListaDiscos.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) || x.Estilo.Estilo_disco.ToUpper().Contains(filtro.ToUpper())); //esto filtra sobre la lista original que es atributo, filtro lo que quiero

            }
            else
            {
                discosFiltrados = ListaDiscos;
               
            }

            //limpiamos la lista anterior que se muestra
            dgvDiscos.DataSource = null;

            //como resetie la grilla tengo que volver a configurarle las columnas ocultas
            //agregamos la lista filtrada

            dgvDiscos.DataSource = discosFiltrados;
            ocultarColumnas();
        }
    }
}
