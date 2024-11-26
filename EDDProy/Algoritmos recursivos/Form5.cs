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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Define el arreglo
            int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            //Convierte en una variable la funcion
            int suma = SumarN(arreglo, arreglo.Length - 1);
            stopwatch.Stop();
            //Escribe la variable de la funcion
            MessageBox.Show("La suma de los numeros del arreglo es: " + suma + "\n Tiempo de ejecucion" + stopwatch.ElapsedMilliseconds + "ms");
        }
        static int SumarN(int[] arreglo, int index)
        {
            //Si el índice es menor a 0 regresa la funcion
            if (index < 0)
                return 0;

            // Suma el elemento actual con la suma de los elementos restantes y le resta 1 al indice
            return arreglo[index] + SumarN(arreglo, index - 1);
        }
    }
}
