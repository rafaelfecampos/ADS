using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revisao
{
    public class No
    {
        public int Valor { get; set; }
        private No? proximo = null;
        public No Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }
        private No? anterior = null;
        public No Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
        
        
    }
}