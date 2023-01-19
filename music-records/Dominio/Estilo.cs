using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Estilo 
    {
        //el id para que pueda posteriormente hacer la lectura combinada apartir de identificar el id y devolver en un string el Estilo_Disco
        public int Id { get; set; }
        public string Estilo_disco { get; set; }

        
        public override string ToString()
        {
            return Estilo_disco;
        }

    }
}
