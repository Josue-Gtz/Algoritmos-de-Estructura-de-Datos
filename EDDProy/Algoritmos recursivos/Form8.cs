using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //lee el numero del textbox y lo convierte a una variable
            int numDis = int.Parse(textBox1.Text); // Número de discos 
           //Plantea las torres
            TorreDeHanoi(numDis, 'A', 'C', 'B'); // A: origen, C: destino, B: auxiliar
            stopwatch.Stop();
            MessageBox.Show("\n Tiempo de ejecucion" + stopwatch.ElapsedMilliseconds + "ms");
        }
        static void TorreDeHanoi(int numDis, char origen, char destino, char auxiliar)
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
