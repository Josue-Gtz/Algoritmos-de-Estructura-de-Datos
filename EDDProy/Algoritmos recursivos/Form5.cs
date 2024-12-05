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
using EDDemo.Algoritmos_recursivos.Clases;

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
            Suma_arreglo sumaR = new Suma_arreglo();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Define el arreglo
            int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            //Convierte en una variable la funcion
            int suma = sumaR.SumarN(arreglo, arreglo.Length - 1);
            stopwatch.Stop();
            //Escribe la variable de la funcion
            MessageBox.Show("La suma de los numeros del arreglo es: " + suma + "\n Tiempo de ejecucion" + stopwatch.Elapsed.TotalMilliseconds + "ms");
        }
        

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
//prueba push
