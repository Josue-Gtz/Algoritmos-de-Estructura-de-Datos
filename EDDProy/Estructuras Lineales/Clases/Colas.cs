using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class Colas
    {
        public NodoL prim;
        public NodoL ulti;

        public Colas()
        {
            prim = null;
            ulti = null;
        }
        public bool EstaVacia()
        {
            return prim == null;
        }
        // Método para encolar (Queue)
        public void Queue(string dato)
        {
            NodoL nuevo = new NodoL(dato);

            if (ulti == null)
            {
                ulti = nuevo;
                prim = nuevo;
            }
            else
            {
                ulti.Sig = nuevo;
                ulti = nuevo;
            }
            return ;
        }

        // Método para desencolar (Dequeue)
        public string Dequeue()
        {
            if (prim == null)
            {
                return ("Cola vacía");
            }
            else
            {
                NodoL temp = prim;
                prim = prim.Sig;
                string dato = temp.Dato;

                if (prim == null)
                {
                    ulti = null;
                }
                return dato;
            }
        }

        // Método para buscar un elemento en la cola
        public int Buscar(string valor)
        {
            if (prim == null) return -1;

            NodoL actual = prim;
            int pos = 1;

            while (actual != null)
            {
                if (actual.Dato == valor)
                {
                    return pos;
                }
                actual = actual.Sig;
                pos++;
            }
            return -1 ; // No encontrado
        }

        // Método para recorrer la cola
        public string Recorrer()
        {
            if (prim == null) return ("Cola vacía");

            NodoL actual = prim;
            string resultado = "";

            while (actual != null)
            {
                resultado += actual.Dato + " -> ";
                actual = actual.Sig;
            }
            resultado += "Null";
            return resultado ;
        }
        public void Limpiar()
        {
            if (EstaVacia())
            {
                MessageBox.Show("La cola ya está vacía");
                return;
            }

            // Mientras haya nodos, dequeue a cada uno
            while (!EstaVacia())
            {
                Dequeue();
            }

            MessageBox.Show("La cola ha sido vaciada");
        }
    }
}
