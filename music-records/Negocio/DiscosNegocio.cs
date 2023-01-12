﻿using System;
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
                datos.setearConsulta("SELECT D.Titulo,D.CantidadCanciones,D.UrlImagenTapa, E.Descripcion Estilo,TE.Descripcion Edicion FROM DISCOS D, TIPOSEDICION TE, ESTILOS E where D.IdEstilo = E.Id  AND D.IdTipoEdicion = TE.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read()) 
                {
                    Discos aux = new Discos(); 
                    aux.Titulo = datos.Lector.GetString(0); 
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"]; 
                    aux.UrlImagen = (string)datos.Lector["UrlImagenTapa"];
                    aux.Estilo = new Estilo(); 
                    aux.Estilo.Estilo_disco = (string)datos.Lector["Estilo"];
                    aux.Edicion = new Edicion();
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
                datos.setearConsulta("insert into DISCOS (Titulo, CantidadCanciones)values('"+nuevo.Titulo+"', "+nuevo.CantidadCanciones+")");
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


    }
}
