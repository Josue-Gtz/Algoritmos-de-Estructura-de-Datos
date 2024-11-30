using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Algoritmos_recursivos.Clases
{
     class Hanoi
    {
        public void TorreDeHanoi(int numDis, char origen, char destino, char auxiliar)
        {
            // Si solo hay un disco, simplemente moverlo de origen a destino
            if (numDis == 1)
            {
                //Escribe cada paso
                MessageBox.Show("Mover disco 1 de " + origen + " a " + destino);
                return;
            }

            // Mueve numero-1 discos desde el origen hasta el auxiliar, usando el destino como auxiliar
            TorreDeHanoi(numDis - 1, origen, auxiliar, destino);
            // Mueve el disco restante desde el origen hasta el destino
            MessageBox.Show("Mover disco " + numDis + " de " + origen + " a " + destino);
            // Mueve los numero-1 discos desde el auxiliar hasta el destino, usando el origen como auxiliar
            TorreDeHanoi(numDis - 1, auxiliar, destino, origen);
        }
    }
}
