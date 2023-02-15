using System;
using System.Collections.Generic;
using System.ComponentModel; //necesario para este caso de annotation
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    
    public class Discos 
    {//uso annotation para  modificar el nombre de la prop que se muestra en la columna
        //traigo el Id en la consulta sql
        public int Id { get; set; }
        [DisplayName("Title")]
        public string Titulo { get; set; }
        [DisplayName("Number of songs")]
        public int CantidadCanciones { get; set; }
        public string UrlImagen { get; set; }
        //asociacion : composicion
        [DisplayName("Style")]
        public Estilo Estilo { get; set; }
        //asociacion: agregacion
        [DisplayName("Edition")]
        public Edicion Edicion { get; set; }

    }
}
