using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_recursivos.Clases
{
    class Exponente
    {
        public long Potencia(long baseN, long exponente)
        {
            //Si el exponente es igual a 0 regreasa 1
            if (exponente == 0)
                return 1;
            // Sino se multiplica la base por la funcion y se le resta 1 al exponente //Cambios
            else
                return baseN * Potencia(baseN, exponente - 1);
        }
    }
}
