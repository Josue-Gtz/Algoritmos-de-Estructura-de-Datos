using System;
using System.Collections;
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
using EDDemo.Estructuras_Lineales.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Algoritmos
{
    public partial class Form11 : Form
    {

        Colas cola = new Colas();
        public Form11()
        {
            InitializeComponent();
        }
        private void ActualizarListBox()
        {
            var recorrido = cola.Recorrer();
            label2.Text = recorrido;
        }
        private void Form11_Load(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (cola.EstaVacia())
            {
                MessageBox.Show("La lista está vacía.");
            }
            else
            {
                MessageBox.Show("La lista NO está vacía.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string dato = textBox1.Text;  // Obtener el dato del TextBox
            if (!string.IsNullOrEmpty(dato))
            {
                cola.Queue(dato);  // Encolar el dato

                ActualizarListBox();  // Mostrar la cola actualizada
                textBox1.Clear();  // Limpiar el TextBox
            }
            else
            {
                MessageBox.Show("Ingrese un valor.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var eliminado = cola.Dequeue();

            MessageBox.Show("Elemento desencolado: " + eliminado);
            ActualizarListBox();  // Mostrar la cola actualizada
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cola.Limpiar();  // Limpia la pila
            ActualizarListBox();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string dato = textBox1.Text; 
            if (!string.IsNullOrEmpty(dato))
            {
                var posicion = cola.Buscar(dato);

                if (posicion >= 0)
                {
                    MessageBox.Show("El dato " + dato + " está en la posición " + posicion);
                }
                else
                {
                    MessageBox.Show("El dato " + dato + " no se encontró en la cola.");
                }

            }
            else
            {
                MessageBox.Show("Ingrese un valor para buscar.");
            }
            ActualizarListBox();  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
