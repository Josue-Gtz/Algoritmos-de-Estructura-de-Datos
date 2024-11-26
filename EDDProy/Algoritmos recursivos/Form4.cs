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
            

            //lee el numero del textbox y lo convierte a una variable
            int baseN = int.Parse(textBox1.Text);
            int exponente = int.Parse(textBox2.Text);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //lee el numero resultante de la funcion y lo convierte a una variable
            int potencia = Potencia(baseN,exponente);
            stopwatch.Stop();
            //Escribe la variable de la funcion
            MessageBox.Show("Potencia: " + potencia + "\n Tiempo de ejecucion" + stopwatch.ElapsedMilliseconds + "ms");
        }
        static int Potencia(int baseN, int exponente)
        {
            //Si el exponente es igual a 0 regreasa 1
            if (exponente == 0)
                return 1;
            // Sino se multiplica la base por la funcion y se le resta 1 al exponente
            else
                return baseN * Potencia(baseN, exponente - 1);
        }
    }
}
