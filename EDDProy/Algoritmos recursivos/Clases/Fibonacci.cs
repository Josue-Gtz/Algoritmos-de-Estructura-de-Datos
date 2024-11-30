using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_recursivos.Clases
{
    class Fibonacci
    {
        public int Fibonachi(int num)
        {
            // Si n es 0 o 1 regresa 0,Sino regresa 1
            if (num == 0)
                return 0;
            else if (num == 1)
                return 1;
            //En cualquier otro caso, devuelve la suma de Fibonacci(num-1) y Fibonacci(num-2)
            else
                return Fibonachi(num - 1) + Fibonachi(num - 2);
        }
    }
}
