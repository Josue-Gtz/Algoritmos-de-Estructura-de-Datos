using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using EDDemo.Algoritmos_recursivos.Clases;

namespace Algoritmos
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Exponente exponente1 = new Exponente();
            //lee el numero del textbox y lo convierte a una variable
            long baseN = long.Parse(textBox1.Text);
            long exponente = long.Parse(textBox2.Text);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //lee el numero resultante de la funcion y lo convierte a una variable
            long potencia = exponente1.Potencia(baseN,exponente);
            stopwatch.Stop();
            //Escribe la variable de la funcion
            MessageBox.Show("Potencia: " + potencia + "\n Tiempo de ejecucion" + stopwatch.Elapsed.TotalMilliseconds + "ms");
        }
        
    }
}
