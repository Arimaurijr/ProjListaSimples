using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaSimples
{
    internal class Item
    {
        public int Valor { get; set; }
        public Item Next { get; set; }

        public Item(int x)
        {
            Valor = x;
            Next = null;
        }
    }
    
}
