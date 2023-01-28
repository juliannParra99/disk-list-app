using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using Dominio;
                              
namespace Negocio
{
    
    public class DiscosNegocio
    {
        public List<Discos> listar()
        {
            List<Discos> lista = new List<Discos>();
            AccesoDatos datos = new AccesoDatos();
            

            try
            {
                //traigo el idTipo y el IdTipoEdicion de discos.Para que lo traiga el lector y pueda usarlo para traer el valor predeterminado de un desplegable
                datos.setearConsulta("SELECT D.Titulo,D.CantidadCanciones,D.UrlImagenTapa, E.Descripcion Estilo,TE.Descripcion Edicion, D.IdEstilo, D.IdTipoEdicion, D.Id FROM DISCOS D, TIPOSEDICION TE, ESTILOS E where D.IdEstilo = E.Id  AND D.IdTipoEdicion = TE.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read()) 
                {
                    Discos aux = new Discos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = datos.Lector.GetString(0); 
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    //
                    //urlImagen suele dar nulo y no muestra la grilla.Lo valido, es recomendable hacerlo. Si es nulo no lo lee
                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["UrlImagenTapa"];

                    aux.Estilo = new Estilo();
                    aux.Estilo.Id = (int)datos.Lector["IdEstilo"]; //hay que tenes muy en claro la relacion entre las tablas
                    aux.Estilo.Estilo_disco = (string)datos.Lector["Estilo"];
                    aux.Edicion = new Edicion();
                    aux.Edicion.Id = (int)datos.Lector["IdTipoEdicion"];
                    aux.Edicion.Edicion_disco = (string)datos.Lector["Edicion"];
        

                    lista.Add(aux); 
                    
                }
                return lista; 
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        //aca va a ir la logica para conectarme a  la base de datos e insertar los datos
        public void AgregarDisco(Discos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //inyecto los valores del nuevo disco que le pase al metodo agregarDisco
                datos.setearConsulta("insert into DISCOS (Titulo, CantidadCanciones, IdEstilo, IdTipoEdicion, UrlImagenTapa)values('" + nuevo.Titulo+"', "+nuevo.CantidadCanciones+", @IdEstilo, @IdTipoEdicion, @UrlImagenTapa)");
                datos.setearParametro("@IdEstilo", nuevo.Estilo.Id);
                datos.setearParametro("@IdTipoEdicion", nuevo.Edicion.Id);
                datos.setearParametro("@UrlImagenTapa", nuevo.UrlImagen);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Discos disco)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update DISCOS set Titulo = @Titulo , CantidadCanciones = @Canciones, UrlImagenTapa = @UrlImagen, IdEstilo = @IdEstilo, IdTipoEdicion = @IdEdicion where id = @Id");
                datos.setearParametro("@Titulo",disco.Titulo);
                datos.setearParametro("@Canciones", disco.CantidadCanciones);
                datos.setearParametro("@UrlImagen",disco.UrlImagen);
                datos.setearParametro("@IdEstilo", disco.Estilo.Id);
                datos.setearParametro("@IdEdicion", disco.Edicion.Id);
                datos.setearParametro("@Id", disco.Id);

                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        //eliminacion fisica(borra registro de db)
        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from DISCOS where id = @Id");
                datos.setearParametro("@Id", id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
