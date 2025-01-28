using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaCircular
{
    public class No
    {
        public int Valor { get; set; }
        public No Proximo { get; set; }
        public No Anterior { get; set; }
    }
}