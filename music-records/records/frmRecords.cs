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
                ocultarColumnas();
                cargarImagen(ListaDiscos[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        //creo metodo ocultar columnas
        private void ocultarColumnas()
        {
            dgvDiscos.Columns["Id"].Visible = false;
            dgvDiscos.Columns["urlIMagen"].Visible = false;

        }

        //para el buscador rapido: por que cuando el filtra se pone el DGV null, y despues trata de convertir el null en objetos trayendo la lista orignal y no puede y se rompe, 
        //por lo que tenemos que validarla para que no se rompa en la lectura de esos registros que van desde filtrar a traer los datos
        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiscos.CurrentCell != null) //si no, no lo lee y no se rompe
                //si hay una grilla actual seleccionada y es ditinto de nulo, entonces trata de transformarlo y cargar la iamgen sino no
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
                //vamos a generar una lista filtrada . el tipo list es una clase que contiene metodos y eventos
                //el findAll requiere una expresion lambda
                discosFiltrados = ListaDiscos.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) || x.Estilo.Estilo_disco.ToUpper().Contains(filtro.ToUpper())); //esto filtra sobre la lista original que es atributo, filtro lo que quiero
                //y lo muestro en otra lista

            }
            else
            {
                discosFiltrados = ListaDiscos;
               
            }

            //limpiamos la lista anterior que se muestra
            dgvDiscos.DataSource = null; //como reseteo la grilla tengo que volver a configurarle las columnas ocultas

            //agregamos la lista filtrada

            dgvDiscos.DataSource = discosFiltrados;
            ocultarColumnas();
        }
    }
}
