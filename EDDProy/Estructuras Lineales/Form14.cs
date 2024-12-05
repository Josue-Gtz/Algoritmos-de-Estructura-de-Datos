using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo;
using EDDemo.Estructuras_Lineales.Clases;
using static Algoritmos.Form14;

namespace Algoritmos
{
    public partial class Form14 : Form
    {
        ListasCirculares listaCIR = new ListasCirculares();

        public Form14()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string valor = textBox1.Text;
            if (!string.IsNullOrEmpty(valor))
            {
                var posicion = listaCIR.Buscar(valor);
                if (posicion >= 0)
                {
                    MessageBox.Show($"El valor {valor} se encuentra en la posición {posicion}.");
                }
                else
                {
                    MessageBox.Show($"El valor {valor} no se encontró en la lista.");
                }

                ActualizarLista();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un valor para buscar.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor = textBox1.Text;
            if (int.TryParse(textBox2.Text, out int posicion) && !string.IsNullOrEmpty(valor))
            {
                listaCIR.Insertar(valor, posicion);
                ActualizarLista();
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
                listaCIR.Eliminar(posicion);
                ActualizarLista();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese una posición válida.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
            {
            while (!listaCIR.estaVacia())
            {
                listaCIR.Eliminar(1);
            }
            ActualizarLista();
            MessageBox.Show("Lista limpiada");
        }

        private void label1_Click(object sender, EventArgs e)
            {

            }
        private void ActualizarLista()
        {
            var resultado = listaCIR.Recorrer();
            label4.Text = resultado;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
