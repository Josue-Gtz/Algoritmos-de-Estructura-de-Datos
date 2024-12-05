using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Estructuras_Lineales.Clases;
using EDDemo.Estructuras_Lineales;
using EDDemo.Algoritmos_recursivos;
using Algoritmos;
using EDDemo.Ordenamiento.Clases;
using System.Security.Policy;
using EDDemo.Ordenamiento;
using EDDemo.Busqueda;

//C: \Users\jgcbe\OneDrive\Documentos\EDDProy-master\EDDProy\Algoritmos recursivos\
//C:\Users\jgcbe\OneDrive\Documentos\EDDProy-master\EDDProy\Estructuras Lineales\
//using ED

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 mPilas = new Form10();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 mFak = new Form3();
            mFak.MdiParent = this;
            mFak.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 mColas = new Form11();
            mColas.MdiParent = this;
            mColas.Show();
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 mListas = new Form12();
            mListas.MdiParent = this;
            mListas.Show();
        }

        private void listasDoblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 mLisdo = new Form13();
            mLisdo.MdiParent = this;
            mLisdo.Show();
        }

        private void listasCircularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 mLiscir = new Form14();
            mLiscir.MdiParent = this;
            mLiscir.Show();
        }

        private void listasDoblesCircularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 mLiscirdo = new Form15();
            mLiscirdo.MdiParent = this;
            mLiscirdo.Show();
        }

        private void estructurasNoLibealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 mExpo = new Form4();
            mExpo.MdiParent = this;
            mExpo.Show();
        }

        private void sumaArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 msum = new Form5();
            msum.MdiParent = this;
            msum.Show();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 mFibo = new Form6();
            mFibo.MdiParent = this;
            mFibo.Show();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 mBus = new Form7();
            mBus.MdiParent = this;
            mBus.Show();
        }

        private void torresDeHanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 mHanoi = new Form8();
            mHanoi.MdiParent = this;
            mHanoi.Show();
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quicksort mquic = new Quicksort();
            mquic.MdiParent = this;
            mquic.Show();
        }

        private void binariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Binaria mbin = new Binaria();
            mbin.MdiParent = this;
            mbin.Show();
        }

        private void hashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Haash mash = new Haash();
            mash.MdiParent = this;
            mash.Show();
        }
    }
}
