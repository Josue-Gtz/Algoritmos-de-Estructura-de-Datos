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
using EDDemo.Estructuras_Lineales.Clases;

namespace Algoritmos
{
    public partial class Form13 : Form
    {
        ListasDobles lista = new ListasDobles();


        public Form13()
        {
            InitializeComponent();
        }

        private void ActualizarLista()
        {
            var resultado = lista.RecorrerAdelante();
            label4.Text = resultado;  // Mostrar la lista en el TextBox
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valor = textBox1.Text;
            if (int.TryParse(textBox2.Text, out int posicion) && !string.IsNullOrEmpty(valor))
            {
                lista.Insertar(valor, posicion);
                ActualizarLista();  // Recorrer hacia adelante
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un valor y una posición válida.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dato = textBox1.Text;  
            int posicion = lista.Buscar(dato);

            if (posicion != -1)
            {
                MessageBox.Show($"El dato '{dato}' se encuentra en la posición: {posicion}");
            }
            else
            {
                MessageBox.Show($"El dato '{dato}' no se encontró en la lista");
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int posicion))
            {
                lista.Eliminar(posicion);
                ActualizarLista();  // Recorrer hacia adelante
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese una posición válida.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            while (!lista.estaVacio())
            {
                lista.Eliminar(0);
            }
            ActualizarLista();
            MessageBox.Show("Lista limpiada");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}