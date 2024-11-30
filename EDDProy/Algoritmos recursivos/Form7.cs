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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Busqueda_binaria busq = new Busqueda_binaria(); 
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Define el arreglo
            int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Es el valor que buscas
            int valorBus = 8;
            //Convierte en una variable la funcion
            int resultado = busq.BusquedaBinaria(arreglo, valorBus, 0, arreglo.Length - 1);
            //Si el resultado es diferente a uno lo escribe, Sino escribe que no se encontro
            if (resultado != -1)
            {
                stopwatch.Stop();
                MessageBox.Show("Elemento encontrado en el índice: " + resultado + "\n Tiempo de ejecucion" + stopwatch.ElapsedMilliseconds + "ms");
            }
            else
            {
                stopwatch.Stop();
                MessageBox.Show("Elemento no encontrado en el arreglo." + "\n Tiempo de ejecucion" + stopwatch.ElapsedMilliseconds + "ms");
            }
        }
        

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
