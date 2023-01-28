using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Estilo 
    {
        //lo ideal hubiese sido que en los dos atributos de la clase se correspondan con el nombre de las columnas en la tabla estilo: 'Id' esta bien,
        //pero 'Estilo_disco' deberia haber sido 'Descripcion' que es el nombre de la columna.
        //el id para que pueda posteriormente hacer la lectura combinada apartir de identificar el id y devolver en un string el Estilo_Disco
        public int Id { get; set; }
        public string Estilo_disco { get; set; }

        
        public override string ToString()
        {
            return Estilo_disco;
        }

    }
}
