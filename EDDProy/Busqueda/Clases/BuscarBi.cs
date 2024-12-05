using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Busqueda.Clases
{
     public class BuscarBinario

    {
        public int FuncionBinar(int[] arreglo, int elemento)
        {
            int izq = 0;
            int der = arreglo.Length - 1;
            while (izq <= der)
            {
                int medio = (izq + der) / 2;

                if (arreglo[medio] == elemento)
                {
                    return medio; 
                }
                else if (arreglo[medio] < elemento)
                {
                    izq = medio + 1;
                }
                else
                {
                    der = medio - 1;
                }
            }
            return -1;
        }
    }
}
