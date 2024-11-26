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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //lee el numero del textbox y lo convierte a una variable
            int num = int.Parse(textBox1.Text);
            //lee el numero resultante de la funcion y lo convierte a una variable
            int fibonacci = Fibonacci(num);
            stopwatch.Stop();
            //Escribe la variable de la funcion
            MessageBox.Show("Fibonacci: " + fibonacci+" Tiempo de ejecucion" + stopwatch.ElapsedMilliseconds + "ms");
        }
        static int Fibonacci(int num)
        {
            // Si n es 0 o 1 regresa 0,Sino regresa 1
            if (num == 0)
                return 0;
            else if (num == 1)
                return 1;
            //En cualquier otro caso, devuelve la suma de Fibonacci(num-1) y Fibonacci(num-2)
            else
                return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }
}
