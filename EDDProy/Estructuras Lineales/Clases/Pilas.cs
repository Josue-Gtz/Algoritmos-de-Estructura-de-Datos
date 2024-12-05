using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo
{
    public class Pilas
    {
        public NodoL top;

        public Pilas()
        {
            top = null;
        }

        public bool EstaVacia()
        {
            return top == null;
        }

        public void Push(string dato)
        {
            NodoL nuevo = new NodoL(dato);
            if (top==null)
            {
                top = nuevo;

            }
            else
            {
                NodoL Temp = top;
                top = nuevo;
                top.Sig = Temp;

            }
            return ;
        }
        
        public string Pop()
        {
            if (EstaVacia())
            {
                return ("Vacio");
            }
            else
            {
                NodoL temp = top;
                top = top.Sig;
                string Dato = temp.Dato;
                temp = null;
                return (Dato);
            }
        }

        public bool Buscar(string dato)
        {
            
            NodoL aux = top;
            while (aux != null)
            {
                if (aux.Dato == dato)
                {
                    return true;
                }
                aux = aux.Sig;
            }
            return false;
        }
        public string Recorrer()
            
        {
            if (top == null) return ("Pila vacía");

            NodoL actual = top;
            string resultado = "";

            while (actual != null)
            {
                resultado += actual.Dato + " -> ";
                actual = actual.Sig;
            }
            resultado += "null";
            return resultado;
        }
        public void Limpiar()
        {
            if (EstaVacia())
            {
                top = null;
                MessageBox.Show("Pila limpiada");

            }
            while (!EstaVacia())
            {
                Pop();
            }
            MessageBox.Show("La pila ha sido vaciada");
        }
    }
}

