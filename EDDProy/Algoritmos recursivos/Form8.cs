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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hanoi hanoi = new Hanoi();  
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //lee el numero del textbox y lo convierte a una variable
            int numDis = int.Parse(textBox1.Text); // Número de discos 
                                                   //Plantea las torres
            hanoi.TorreDeHanoi(numDis, 'A', 'C', 'B'); // A: origen, C: destino, B: auxiliar
            stopwatch.Stop();
            MessageBox.Show("\n Tiempo de ejecucion" + stopwatch.Elapsed.TotalMilliseconds + "ms");
        }
        

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
    
}
