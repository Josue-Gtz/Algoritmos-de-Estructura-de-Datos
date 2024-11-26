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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Define el arreglo
            int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Es el valor que buscas
            int valorBus = 8;
            //Convierte en una variable la funcion
            int resultado = BusquedaBinaria(arreglo, valorBus, 0, arreglo.Length - 1);
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
        static int BusquedaBinaria(int[] arreglo, int valorBuscado, int inicio, int fin)
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
