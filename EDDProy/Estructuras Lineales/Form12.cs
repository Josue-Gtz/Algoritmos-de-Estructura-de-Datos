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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using EDDemo.Estructuras_Lineales.Clases;
using EDDemo;
using System.Globalization;

namespace Algoritmos
{
    public partial class Form12 : Form
    {
        Listas lista = new Listas();
        public Form12()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string dato = textBox1.Text;
            if (int.TryParse(textBox2.Text, out int posicion) && !string.IsNullOrEmpty(dato))
            {
                lista.Insertar(dato, posicion);  // Insertar en posición
                ActualizarListBox();
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor y una posición válida.");
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dato = textBox1.Text;
            if (!string.IsNullOrEmpty(dato))
            {
                int posicion = lista.Buscar(dato); 

                if (posicion >= 0)
                {
                    MessageBox.Show($"El valor {dato} se encuentra en la posición {posicion}.");
                }
                else
                {
                    MessageBox.Show($"El valor {dato} no se encontró en la lista.");
                }
                ActualizarListBox();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dato = textBox1.Text;
            if (!string.IsNullOrEmpty(dato))
            {
                lista.Eliminar(dato);  // Eliminar el valor

                ActualizarListBox();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor para eliminar.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            while (!lista.EstaVacia())
            {
                lista.Limpiar();
            }
            ActualizarListBox();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActualizarListBox()
        {
            listBox1.Items.Clear();
            var recorrido = lista.Recorrer();
            listBox1.Text = recorrido;
        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

