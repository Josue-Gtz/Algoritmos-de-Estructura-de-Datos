using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class ListasDobles
    {
        public NodoDoble Inicio;
        public NodoDoble Fin;

        public ListasDobles()
        {
            Inicio = null;
            Fin = null;
        }
        public bool estaVacio()
        {
            return Inicio == null;
        }
        // Método para insertar en una posición específica
        public void Insertar(string valor, int pos)
        {
            NodoDoble nuevo = new NodoDoble(valor);

            if (Inicio == null)
            {
                Inicio = nuevo;
                Fin = nuevo;
            }
            else
            {
                if (pos == 0)
                {
                    nuevo.Sig = Inicio;
                    Inicio.Ant = nuevo;
                    Inicio = nuevo;
                }
                else
                {
                    NodoDoble temp = Inicio;
                    int indicador = 0;
                    while (temp != null && indicador < pos)
                    {
                        temp = temp.Sig;
                        indicador++;
                    }

                    if (temp != null)
                    {
                        nuevo.Sig = temp;
                        nuevo.Ant = temp.Ant;
                        if (temp.Ant != null) temp.Ant.Sig = nuevo;
                        temp.Ant = nuevo;
                    }
                    else
                    {
                        Fin.Sig = nuevo;
                        nuevo.Ant = Fin;
                        Fin = nuevo;
                    }
                }
            }
            return ;
        }

        // Método para recorrer la lista hacia adelante
        public string RecorrerAdelante()
        {
            if (Inicio == null)
            {
                return ("Lista vacía");
            }

            NodoDoble temp = Inicio;
            string resultado = "";

            while (temp != null)
            {
                resultado += temp.Dato + " -> ";
                temp = temp.Sig;
            }
            resultado += "null";
            return (resultado);
        }

        // Método para recorrer la lista hacia atrás
        public string RecorrerAtras()
        {
            if (Fin == null)
            {
                return ("Lista vacía");
            }

            NodoDoble temp = Fin;
            string resultado = "";
            while (temp != null)
            {
                resultado += temp.Dato + " -> ";
                temp = temp.Ant;
            }
            resultado += "null";
            return (resultado);
        }

        // Método para eliminar en una posición específica
        public void Eliminar(int pos)
        {
            if (Inicio == null) return;

            NodoDoble temp = Inicio;
            int contador = 0;

            while (temp != null && contador < pos)
            {
                temp = temp.Sig;
                contador++;
            }

            if (temp != null)
            {
                if (temp == Inicio) Inicio = temp.Sig;
                if (temp == Fin) Fin = temp.Ant;
                if (temp.Sig != null) temp.Sig.Ant = temp.Ant;
                if (temp.Ant != null) temp.Ant.Sig = temp.Sig;
            }
            return ;
        }

        // Método para buscar un valor en la lista
        public int Buscar(string valor)
        {
            NodoDoble temp = Inicio;
            int posicion = 1;

            while (temp != null)
            {
                if (temp.Dato == valor) return (posicion);
                temp = temp.Sig;
                posicion++;
            }
            return (-1);
        }
    }
}
