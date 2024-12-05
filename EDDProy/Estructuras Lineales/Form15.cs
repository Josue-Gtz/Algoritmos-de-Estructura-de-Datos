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
using EDDemo.Estructuras_Lineales.Clases;
using static Algoritmos.Form15;

namespace Algoritmos
{
    public partial class Form15 : Form
    {
        
        ListasCirDob lisCIDO= new ListasCirDob();


        public Form15()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor = textBox1.Text;
            if (int.TryParse(textBox2.Text, out int posicion) && !string.IsNullOrEmpty(valor))
            {
                lisCIDO.Insertar(valor, posicion);

                ActualizarListbox();
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un valor y una posición válida.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int posicion))
            {
                lisCIDO.Eliminar(posicion);
                ActualizarListbox();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese una posición válida.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string valor = textBox1.Text;
            if (!string.IsNullOrEmpty(valor))
            {
                var posicion = lisCIDO.Buscar(valor);

                if (posicion >= 0)
                {
                    MessageBox.Show($"El valor {valor} se encuentra en la posición {posicion}.");
                }
                else
                {
                    MessageBox.Show($"El valor {valor} no se encontró en la lista.");
                }

                ActualizarListbox();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un valor para buscar.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            while (!lisCIDO.estaVacio())
            {
                lisCIDO.Eliminar(1);
            }
            ActualizarListbox();
            MessageBox.Show("Lista eliminada");

        }
        private void ActualizarListbox()
        {
            var resultado = lisCIDO.Recorrer();
            label4.Text = resultado;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
