using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                // CAMBIO 2

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);
        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [label=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [label=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
        }

        public bool BoleanoBusqueda(int Dato, NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                return false;
            }
            if (Dato== Nodo.Dato)
                return true;

            if (Dato < Nodo.Dato)
               return BoleanoBusqueda(Dato,  Nodo.Izq);

            else return BoleanoBusqueda(Dato, Nodo.Der);

        }

        public void podaArbol()
        {
            if (Raiz == null)
            {
                MessageBox.Show("El arbol está vacio");
                return;
            }
            NodoBinario miRaiz = RegresaRaiz();
            podaArrrrrr(ref miRaiz);
            Raiz = null;
        }

        public void podaArrrrrr( ref NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                return;
            }
                podaArrrrrr( ref Nodo.Izq);
                podaArrrrrr( ref Nodo.Der);
                Nodo= null;
        }

        public void EliminarPredecesor(int x, ref NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return;
            else if (x < nodoPtr.Dato)
                EliminarPredecesor(x, ref nodoPtr.Izq);
            else if (x > nodoPtr.Dato)
                EliminarPredecesor(x, ref nodoPtr.Der);
            else if (nodoPtr.Izq != null && nodoPtr.Der != null)
            {
                NodoBinario mayor = BuscaMayor(nodoPtr.Izq);
                nodoPtr.Dato = mayor.Dato;
                EliminarPredecesor(mayor.Dato, ref nodoPtr.Izq);
            }
            else
            {
                NodoBinario temp = nodoPtr;
                if (nodoPtr.Izq == null)
                    nodoPtr = nodoPtr.Der;
                else if (nodoPtr.Der == null)
                    nodoPtr = nodoPtr.Izq;

                temp = null;
            }
        }

        NodoBinario BuscaMayor(NodoBinario Nodo)
        {
            if (Nodo == null)
                return null;
            else if (Nodo.Der == null)
                return Nodo;
            else
                return BuscaMayor(Nodo.Der);
        }
        NodoBinario BuscaMenor(NodoBinario Nodo)
        {
            if (Nodo == null)
                return null;
            else if (Nodo.Izq == null)
                return Nodo;
            else
                return BuscaMenor(Nodo.Izq);
        }

        public void EliminarSucesor(int x, ref NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return;
            else if (x < nodoPtr.Dato)
                EliminarSucesor(x, ref nodoPtr.Izq);
            else if (x > nodoPtr.Dato)
                EliminarSucesor(x, ref nodoPtr.Der);
            else if (nodoPtr.Izq != null && nodoPtr.Der != null)
            {
                NodoBinario menor = BuscaMenor(nodoPtr.Der);
                nodoPtr.Dato = menor.Dato;
                EliminarSucesor(menor.Dato, ref nodoPtr.Der);
            }
            else
            {
                NodoBinario temp = nodoPtr;
                if (nodoPtr.Izq == null)
                    nodoPtr = nodoPtr.Der;
                else if (nodoPtr.Der == null)
                    nodoPtr = nodoPtr.Izq;

                temp = null;
            }
        }

        public void recorridoNiveles()
        {
            if (Raiz == null)
            {
                MessageBox.Show("El arbol está vacío");
                return;
            }
            Queue<NodoBinario> colaAuxiliar = new Queue<NodoBinario>();
            colaAuxiliar.Enqueue(Raiz);

            while (colaAuxiliar.Count > 0)
            {
                NodoBinario nodoAuxiliar = colaAuxiliar.Dequeue();
                strRecorrido += nodoAuxiliar.Dato + ", ";

                if (nodoAuxiliar.Izq != null)
                {
                    colaAuxiliar.Enqueue(nodoAuxiliar.Izq);
                }

                if (nodoAuxiliar.Der != null)
                {
                    colaAuxiliar.Enqueue(nodoAuxiliar.Der);
                }
            }
        }
            public int Altura(NodoBinario Nodo)
        {
            if (Nodo == null)
                return 0;

            return 1 + Math.Max(Altura(Nodo.Izq), Altura(Nodo.Der));
        }


        public int ContarHojas(NodoBinario Nodo)
        {
            if (Nodo == null)
                return 0;

            if (Nodo.Der == null && Nodo.Izq == null)
                return 1;
            else
                return ContarHojas(Nodo.Izq) + ContarHojas(Nodo.Der);
        }

        public int ContarNodos(NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                return 0;
            }

            return 1 + ContarNodos(Nodo.Izq) + ContarNodos(Nodo.Der);
        }

        public bool EsLleno(NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                return true;
            }
            if (Nodo.Der == null && Nodo.Izq == null)
            {
                return true;
            }
            if (Nodo.Der != null && Nodo.Izq != null)
            {
                return EsLleno(Nodo.Izq) && EsLleno(Nodo.Der);
            }
            return false;
        }

            
        
            public bool EsCompleto(NodoBinario Nodo)
            {
                if (Nodo == null)
                {
                    return true;
                }

                Queue<NodoBinario> colaAuxiliar = new Queue<NodoBinario>();
                colaAuxiliar.Enqueue(Nodo);
                bool nodoNoLleno = false;

                while (colaAuxiliar.Count > 0)
                {
                    NodoBinario nodoAuxiliar = colaAuxiliar.Dequeue();

                    if (nodoAuxiliar.Izq != null)
                    {
                        if (nodoNoLleno)
                        {
                            return false;
                        }
                        colaAuxiliar.Enqueue(nodoAuxiliar.Izq);
                    }
                    else
                    {
                        nodoNoLleno = true;
                    }

                    if (nodoAuxiliar.Der != null)
                    {
                        if (nodoNoLleno)
                        {
                            return false;
                        }
                        colaAuxiliar.Enqueue(nodoAuxiliar.Der);
                    }
                    else
                    {
                        nodoNoLleno = true;
                    }
                }

                return true;
            }
        }


    }
