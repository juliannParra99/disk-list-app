using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    
    public class Discos 
    {
        public string Titulo { get; set; }
        public int CantidadCanciones { get; set; }
        public string UrlImagen { get; set; }
        //asociacion : composicion
        public Estilo Estilo { get; set; } 
        //asociacion: agregacion
        public Edicion Edicion { get; set; }

    }
}
