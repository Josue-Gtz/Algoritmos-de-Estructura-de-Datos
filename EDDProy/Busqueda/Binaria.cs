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
using EDDemo.Busqueda.Clases;


namespace EDDemo.Ordenamiento
{
    public partial class Binaria : Form
    {
        BuscarBinario bibus = new BuscarBinario();    
  
        public Binaria()
        {
            InitializeComponent();
        }
        public int[] num;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            num = Enumerable.Range(1, 20).Select(_ => rnd.Next(1, 101)).ToArray();

            label1.Text = string.Join(", ", num);
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(textBox1.Text, out int dato))
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                int resultado = bibus.FuncionBinar(num, dato);
                stopwatch.Stop();
                label5.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
                if (resultado != -1)
                {
                    label3.Text = $"Valor encontrado en la posición: {resultado}";
                }
                else
                {
                    label3.Text = "Valor no encontrado.";
                }
            }
            else
            {
                label3.Text = "Ingrese un número válido.";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
