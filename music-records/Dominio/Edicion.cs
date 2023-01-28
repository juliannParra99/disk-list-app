using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Edicion
    {
        //lo ideal hubiese sido que en los dos atributos de la clase se correspondan con el nombre de las columnas en la tabla Edicion: 'Id' esta bien,
        //pero 'Edicion_disco' deberia haber sido 'Descripcion' que es el nombre de la columna. Para que fuera mas intuitivo
        //el id es fundamental por que es lo que vamos a utilizar para joinear ambas tablas; Comprender la relacion que ocupa en la app es fundamental
        public int Id { get; set; }
        public string Edicion_disco { get; set; }

        public override string ToString()
        {
            return Edicion_disco; 
        }
    }
}
