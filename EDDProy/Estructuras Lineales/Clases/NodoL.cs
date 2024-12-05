using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
     public class NodoL
    {
        
            public string Dato;
            public NodoL Sig;

            public NodoL(string dato)
            {
                Dato = dato;
                Sig = null;
            }
        
    }
    public class NodoC<T>
    {
        public T Dato;
        public NodoC<T> Sig;

        public NodoC(T dato)
        {
            Dato = dato;
            Sig = null;
        }
    }
    public class NodoDoble
    {
        public string Dato;
        public NodoDoble Sig;
        public NodoDoble Ant;
        public NodoDoble(string dato)
        {
            Dato = dato;
            Sig = null;
            Ant = null;
        }
    }
}
