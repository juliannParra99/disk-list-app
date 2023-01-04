using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Estilo 
    {
        public string Estilo_disco { get; set; }

        
        public override string ToString()
        {
            return Estilo_disco;
        }

    }
}
