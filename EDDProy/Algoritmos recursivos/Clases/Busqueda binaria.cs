using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_recursivos.Clases
{
    class Busqueda_binaria
    {
        public int BusquedaBinaria(int[] arreglo, int valorBuscado, int inicio, int fin)
        {
            // Si el rango de búsqueda ya no es válido
            if (inicio > fin)
                return -1;

            // Encunetrael punto medio
            int medio = inicio + (fin - inicio) / 2;

            // Si el valor está en el medio regresa la funcion
            if (arreglo[medio] == valorBuscado)
                return medio;

            // Si el valor buscado es menor, buscar en la mitad izquierda
            if (valorBuscado < arreglo[medio])
                return BusquedaBinaria(arreglo, valorBuscado, inicio, medio - 1);

            // Si el valor buscado es mayor, buscar en la mitad derecha
            return BusquedaBinaria(arreglo, valorBuscado, medio + 1, fin);
        }
    }
}
