using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaSimples
{
    internal class ListaItem
    {
        public Item Begin { get; set; }
        public Item End { get; set; }

        public ListaItem()
        {
            Begin = null;
            End = null;
        }
        public void Insert(Item i)
        {
            if(IsEmpty())
            {
                Begin = i;
                End = i;
            }
            else
            {
                if(i.Valor <= Begin.Valor)
                {
                    InsertFirst(i);
                }
                else
                {
                    if(i.Valor >= End.Valor)
                    {
                        InsertLast(i);
                    }
                    else
                    {
                        InsertMiddle(i);
                    }
                }
            }
        }
        public void InsertFirst(Item i)
        {
            i.Next = Begin;
            Begin = i;
        }
        public void InsertLast(Item i)
        {
            End.Next = i;
            End = i;
        }
        public void InsertMiddle(Item i)
        {
            Item aux;
            aux = Begin;

            while(aux.Next != null)
            {
                if(i.Valor <= aux.Next.Valor) 
                {
                    i.Next = aux.Next;
                    aux.Next = i;
                }

                aux = aux.Next;
            }
        }
        public Item Find(Item f)
        {
            bool found = false;

            Item aux = Begin;
            Item aux2 = null;

            while((aux.Next != null) && (found == false))
            {
                if(aux.Valor == f.Valor)
                {

                    found = true;
                }
                else
                {
                    aux = aux.Next;
                }
            }

            if(found)
            {
                aux2 = aux;
            }

            return aux2;
        }
        public bool IsEmpty()
        {
            bool checks = false;

            if(Begin == null)
            {
                checks = true;
            }
            
            return checks;
        }
        public void Print()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Lista vazia !");
            }
            else
            {
                Item aux = Begin;
                while(aux.Next != null)
                {
                    Console.Write(aux.Valor + " ");
                    aux = aux.Next;
                }
                Console.WriteLine();
            }
        }


    }
}
