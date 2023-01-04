using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  
                              
namespace records
{
    
    class DiscosNegocio
    {
        public List<Discos> listar()
        {
            List<Discos> lista = new List<Discos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true"; 
                comando.CommandType = System.Data.CommandType.Text; 
                comando.CommandText = "SELECT D.Titulo,D.CantidadCanciones,D.UrlImagenTapa, E.Descripcion Estilo,TE.Descripcion Edicion FROM DISCOS D, TIPOSEDICION TE, ESTILOS E where D.IdEstilo = E.Id  AND D.IdTipoEdicion = TE.Id"; 
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader(); 

                while (lector.Read()) 
                {
                    Discos aux = new Discos(); 
                    aux.Titulo = lector.GetString(0); 
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"]; 
                    aux.UrlImagen = (string)lector["UrlImagenTapa"];
                    aux.Estilo = new Estilo(); 
                    aux.Estilo.Estilo_disco = (string)lector["Estilo"];
                    aux.Edicion = new Edicion();
                    aux.Edicion.Edicion_disco = (string)lector["Edicion"];
        

                    lista.Add(aux); 
                    
                }
                conexion.Close(); 
                return lista; 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
