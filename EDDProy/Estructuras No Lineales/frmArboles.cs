using EDDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;


//using GraphVizWrapper;
//using GraphVizWrapper.Queries;
//using GraphVizWrapper.Commands;

//using csdot;
//using csdot.Attributes.DataTypes;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                String Datio = txtDato.Text;
                if (miArbol.BoleanoBusqueda(int.Parse(txtDato.Text), miRaiz))
                    labelBuscar.Text = "El " + Datio + " SI se encuentra en el árbol";
                else
                    //Obtenemos el nodo Raiz del arbol
                    miRaiz = miArbol.RegresaRaiz();

                //Limpiamos la cadena donde se concatenan los nodos del arbol 
                miArbol.strArbol = "";

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(int.Parse(txtDato.Text),
                                    ref miRaiz);

                //Leer arbol completo y mostrarlo en caja de texto
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;

                txtDato.Text = "";
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(txtDato.Text))
                    MessageBox.Show("Solo números");

            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString =  b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);

            
            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }


        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null) {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = ""; 
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;

            lblNibel.Text = "";
            miArbol.recorridoNiveles();
            lblNibel.Text = miArbol.strRecorrido;

        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
             
            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos =1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                    //Se inserta el nodo con el dato capturado
                    miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String Datio = txtDato.Text;
                if (miArbol.EstaVacio())
                    labelBuscar.Text = "Esta vacio";
                else if (miArbol.BoleanoBusqueda(int.Parse(txtDato.Text), miRaiz))
                    labelBuscar.Text = "El " + Datio + " SI se encuentra en el árbol";
                else
                    labelBuscar.Text = "El " + Datio + " NO se encuentra en el árbol"; 
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(txtDato.Text))
                    MessageBox.Show("Solo números");

            }

        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDatos_Click(object sender, EventArgs e)
        {

        }

        private void frmArboles_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            miArbol.podaArrrrrr(ref miRaiz );
            txtArbol.Text = "";
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            String Datio = txtDato.Text;
            if (miArbol.BoleanoBusqueda(int.Parse(txtDato.Text), miRaiz))
            {
                miArbol.EliminarPredecesor(int.Parse(txtDato.Text),ref miRaiz);
                lbLInfo.Text = "El dato ha sido eliminado ";
                txtArbol.Text = "";
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = "";
                txtArbol.Text = miArbol.strArbol;
                txtDato.Text = "";


            }
            else
                labelBuscar.Text = "El " + Datio + " NO se encuentra en el árbol";
            
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            String Datio = txtDato.Text;
            if (miArbol.BoleanoBusqueda(int.Parse(txtDato.Text), miRaiz))
            {
                miArbol.EliminarSucesor(int.Parse(txtDato.Text),ref miRaiz);
                lbLInfo.Text = "El dato ha sido eliminado ";
                txtArbol.Text = "";
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = "";
                txtArbol.Text = miArbol.strArbol;
                txtDato.Text = "";

            }
            else
                labelBuscar.Text = "El " + Datio + " NO se encuentra en el árbol";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            int alto = miArbol.Altura(miRaiz);
            lbLInfo.Text = "La altura del arbol es de: " + alto;
        } 
        

        private void txtArbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            int hoja = miArbol.ContarHojas(miRaiz);
            lbLInfo.Text = "El numero de hojas es de: " + hoja;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            bool resultado = miArbol.EsLleno(miRaiz);
            lbLInfo.Text = resultado ? "El árbol está lleno" : "El árbol no está lleno";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            bool resultado = miArbol.EsCompleto(miRaiz);
            lbLInfo.Text = resultado ? "El árbol está completo" : "El árbol no está completo";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            int hoja = miArbol.ContarNodos(miRaiz);
            lbLInfo.Text = "El numero de nodps es de: " + hoja;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            miArbol.podaArbol();
            txtArbol.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void lblPreOrden_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNodos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
