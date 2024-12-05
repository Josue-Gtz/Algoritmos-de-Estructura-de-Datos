using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo;
using EDDemo.Estructuras_Lineales.Clases;

namespace Algoritmos
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        Pilas pila = new Pilas();
        
        private void button4_Click(object sender, EventArgs e)
        {
            ActualizarListBox();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pila.Limpiar();  // Limpia la pila
            ActualizarListBox();  // Limpiamos el ListBox
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            string dato = textBox1.Text;

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (pila.Buscar(dato))
                {
                    MessageBox.Show($"El dato {dato} está en la pila.");
                }
                else
                {
                    MessageBox.Show($"El dato {dato} NO está en la pila.");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                pila.Push((textBox1.Text));
                ActualizarListBox();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un Dato");
            }
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            var eliminado = pila.Pop();

            MessageBox.Show("Dato eliminado: " + eliminado);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ActualizarListBox()
        {
            var recorrido = pila.Recorrer();
            label2.Text = recorrido;  
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}






