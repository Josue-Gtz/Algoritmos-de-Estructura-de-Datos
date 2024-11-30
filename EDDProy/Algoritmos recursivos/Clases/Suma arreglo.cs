using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_recursivos.Clases
{
    class Suma_arreglo
    {
        public int SumarN(int[] arreglo, int index)
        {
            //Si el índice es menor a 0 regresa la funcion
            if (index < 0)
                return 0;

            // Suma el elemento actual con la suma de los elementos restantes y le resta 1 al indice
            return arreglo[index] + SumarN(arreglo, index - 1);
        }
    }
}
