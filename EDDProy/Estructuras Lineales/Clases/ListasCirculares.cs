using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class ListasCirculares
    {
        public NodoL Inicio;
        public NodoL Fin;

        public ListasCirculares()
        {
            Inicio = null;
            Fin = null;
        }
        public bool estaVacia()
        {
            return Inicio == null && Fin == null;
        }
        public void Insertar(string dato, int posicion)
        {
            NodoL nuevo = new NodoL(dato);

            // Caso 1: Lista vacía
            if (Inicio == null && Fin == null)
            {
                Inicio = nuevo;
                Fin = nuevo;
                Fin.Sig = Inicio; // Mantener la circularidad
                return;
            }

            // Caso 2: Insertar en la primera posición
            if (posicion == 0 || posicion == 1)
            {
                nuevo.Sig = Inicio;
                Inicio = nuevo;
                Fin.Sig = Inicio; // Mantener la circularidad
                return ;
            }

            // Caso 3: Insertar en una posición mayor
            int pos = 1;
            NodoL aux = Inicio;
            NodoL previo = null;

            while (pos < posicion && aux.Sig != Inicio)
            {
                previo = aux;
                aux = aux.Sig;
                pos++;
            }

            // Si la posición es válida
            if (pos == posicion)
            {
                nuevo.Sig = aux;
                if (previo != null)
                {
                    previo.Sig = nuevo;
                }

                if (aux == Inicio) // Si es el último nodo
                {
                    Fin = nuevo;
                }
            }
            else if (aux.Sig == Inicio) // Insertar al final
            {
                Fin.Sig = nuevo;
                nuevo.Sig = Inicio;
                Fin = nuevo;
            }
            else
            {
                MessageBox.Show("Posición fuera de rango");
            }

        }

        // Método para recorrer e imprimir la lista
        public string Recorrer()
        {
            string resultado = "";

            if (Inicio == null)
            {
                return ("La lista está vacía");
            }

            NodoL temp = Inicio;
            do
            {
                resultado += temp.Dato + " -> ";
                temp = temp.Sig;
            }
            while (temp != Inicio);

            resultado += "Circular";
            return (resultado);
        }

        public void Eliminar(int posicion)
        {

            if (Inicio == null)
            {
                MessageBox.Show("Lista vacía");
                return;
            }

            NodoL aux = Inicio;
            NodoL previo = null;
            int pos = 1;

            while (pos < posicion && aux.Sig != Inicio)
            {
                previo = aux;
                aux = aux.Sig;
                pos++;
            }

            if (pos == posicion)
            {
                if (aux == Inicio && aux == Fin) // Lista con un solo nodo
                {
                    Inicio = null;
                    Fin = null;
                }
                else if (aux == Inicio) // Eliminar el primer nodo
                {
                    Inicio = aux.Sig;
                    Fin.Sig = Inicio;
                }
                else if (aux == Fin) // Eliminar el último nodo
                {
                    Fin = previo;
                    Fin.Sig = Inicio;
                }
                else // Eliminar un nodo intermedio
                {
                    previo.Sig = aux.Sig;
                }
            }
            else
            {
                MessageBox.Show("Posición fuera de rango");
            }

            return ;
        }

        // Método para buscar un valor y devolver su posición
        public int Buscar(string valor)
        {
            if (Inicio == null)
            {
                Console.WriteLine("La lista está vacía");
                return -1;
            }

            NodoL temp = Inicio;
            int pos = 1;

            do
            {
                if (temp.Dato == valor)
                {
                    return (pos);
                }
                temp = temp.Sig;
                pos++;
            }
            while (temp != Inicio);

            Console.WriteLine("Valor no encontrado");
            return -1;
        }
    }

}
