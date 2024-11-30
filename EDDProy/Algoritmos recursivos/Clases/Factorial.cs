using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_recursivos.Clases
{
    class Factorial
    {
        public int Calcularactorial(int n)
        {
            int operaciones = 0;
            //Si n es 0 o 1, devuelve 1
            if (n == 0 || n == 1)
            {
                return 1;
            }
            //Para el valor de n mayor que 1, la función devuelve n * CalcularFactorial(n - 1)
            return n * Calcularactorial(n - 1);
            operaciones++;
        }
    }
}
