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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fibonacci fibo = new Fibonacci();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //lee el numero del textbox y lo convierte a una variable
            int num = int.Parse(textBox1.Text);
            //lee el numero resultante de la funcion y lo convierte a una variable
            int fibonacci = fibo.Fibonachi(num);
            stopwatch.Stop();
            //Escribe la variable de la funcion
            MessageBox.Show("Fibonacci: " + fibonacci+" Tiempo de ejecucion" + stopwatch.ElapsedMilliseconds + "ms");
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
