using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo
{
    public class Listas
    {
        public NodoL Cabeza;
        public int tamaño;
        public Listas()
        {
            Cabeza = null;
        }
        public bool EstaVacia()
        {
            return Cabeza == null;
        }
        

        // Método para insertar en una posición específica
        public void Insertar(string valor, int pos)
        {
            pos -= 1;

            if (pos < 0 || pos > tamaño)
            {
                MessageBox.Show("Posición inválida");
                return;
            }

            NodoL nuevoNodo = new NodoL(valor);

            if (pos == 0)
            {
                nuevoNodo.Sig = Cabeza;
                Cabeza = nuevoNodo;
            }
            else
            {
                NodoL actual = Cabeza;
                for (int i = 0; i < pos - 1; i++)
                {
                    actual = actual.Sig;
                }
                nuevoNodo.Sig = actual.Sig;
                actual.Sig = nuevoNodo;
            }
            tamaño++;
        }

        // Método para eliminar el primer nodo
        public void EliminarTop()
        {
            if (Cabeza != null)
            {
                Cabeza = Cabeza.Sig;
            }
            else
            {
                MessageBox.Show("La lista está vacía.");
            }
            return ;
        }

        // Método para eliminar un valor específico
        public void Eliminar(string valor)
        {

            if (Cabeza == null) return ;

            if (Cabeza.Dato == valor)
            {
               EliminarTop();
                return ;
            }

            NodoL Actual = Cabeza;
            while (Actual.Sig != null && Actual.Sig.Dato != valor)
            {
                Actual = Actual.Sig;
            }

            if (Actual.Sig != null)
            {
                Actual.Sig = Actual.Sig.Sig;
            }
            else
            {
                MessageBox.Show("Valor no encontrado.");
            }
            return;
        }

        // Método para buscar un valor específico
        public int Buscar(string valor)
        {
            NodoL Actual = Cabeza;
            int Pos = 1;

            while (Actual != null)
            {
                if (Actual.Dato == valor) return Pos ;
                Actual = Actual.Sig;
                Pos++;
            }

            MessageBox.Show("Valor no encontrado en la lista.");
            return -1 ;
        }

        // Método para recorrer la lista
        public string Recorrer()
        {
            if (Cabeza == null)
            {
                return ("La lista está vacía.");
            }

            NodoL Actual = Cabeza;
            string resultado = "";

            while (Actual != null)
            {
                resultado += Actual.Dato + " -> ";
                Actual = Actual.Sig;
            }
            return resultado ;
        }
        public void Limpiar()
        {
            if (EstaVacia())
            {
                MessageBox.Show("La lista ya está vacía");
                return;
            }
            NodoL actual = Cabeza;
            while (!EstaVacia())
            {
                NodoL sig = actual.Sig;
                actual.Sig = null;
                actual.Dato = null;
                actual = sig;
            }
            Cabeza = null;
            MessageBox.Show("La lista ha sido vaciada");
        }
    }
}
