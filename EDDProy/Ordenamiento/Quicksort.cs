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
using EDDemo.Ordenamiento.Clases;

namespace EDDemo.Ordenamiento
{
    public partial class Quicksort : Form
    {
        QuickSort quik = new QuickSort();

        public Quicksort()
        {
            InitializeComponent();
        }
        public int[] num;

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            num = Enumerable.Range(1, 30).Select(_ => rnd.Next(1, 101)).ToArray();

            label2.Text = string.Join(", ", num);
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            quik.Quick_Sort(num, 0, num.Length - 1);
            stopwatch.Stop();

            label2.Text = string.Join(", ", num);

            label3.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
