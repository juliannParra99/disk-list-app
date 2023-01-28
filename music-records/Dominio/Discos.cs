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
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [DisplayName("Canciones")]
        public int CantidadCanciones { get; set; }
        public string UrlImagen { get; set; }
        //asociacion : composicion
        public Estilo Estilo { get; set; }
        //asociacion: agregacion
        [DisplayName("Edición")]
        public Edicion Edicion { get; set; }

    }
}
