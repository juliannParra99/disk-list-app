﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Edicion
    {
        public int Id { get; set; }
        public string Edicion_disco { get; set; }

        public override string ToString()
        {
            return Edicion_disco; 
        }
    }
}
