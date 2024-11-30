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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factorial factorial1 = new Factorial();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //lee el numero del textbox y lo convierte a una variable
            int numero = int.Parse(textBox1.Text);
            //lee el numero resultante de la funcion y lo convierte a una variable
            int factorial = factorial1.Calcularactorial(numero);
            //int operacion =Calcularactorial(operaciones);
            stopwatch.Stop();
            //Escribe la variable de la funcion
            MessageBox.Show("Factorial: " + factorial + "\n Tiempo de ejecucion" + stopwatch.ElapsedMilliseconds + "ms"+" Operaciones:");
        }      
        
    }
}