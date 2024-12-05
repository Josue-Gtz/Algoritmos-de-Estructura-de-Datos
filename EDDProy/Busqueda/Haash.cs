﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Busqueda.Clases;

namespace EDDemo.Busqueda
{
    public partial class Haash : Form
    {
        Hash ash = new Hash();

        public Haash()
        {
            InitializeComponent();

        }

        private void Haash_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Se obtiene el input
            string input = textBox1.Text;
            
            // Se genera un hash mediante la funcion hash polinomial
            int claveHash = ash.FuncionHashPolinomial(input, 100);  // Usamos el tamaño de tabla 100

            // Se inserta el valor en la tabla hash
            ash.Insertar(input);

            richTextBox1.AppendText($"Clave: {claveHash}\r\nElemento: {input}\r\n\r\n");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // Se verifica si el valor de la búsqueda (clave) es numérico
            if (int.TryParse(textBox1.Text, out int claveBuscada))
            {
                // Se busca el valor asociado a la clave en la tabla hash
                string resultado = ash.Buscar(claveBuscada);

                // Se muestra el resultado de la búsqueda en txtEncontrado
                if (resultado != null)
                {
                    textBox3.Text = $"Elemento: {resultado}";
                }
                else
                {
                    textBox3.Text = $"Elemento: {claveBuscada} no encontrado";
                }
                stopwatch.Stop();

                textBox4.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
            }
            else
            {
                MessageBox.Show("Ingresa un número a buscar");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ash.LimpiarTabla();
            richTextBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
