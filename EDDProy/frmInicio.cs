﻿using System;
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
using EDDemo.Algoritmos_recursivos;

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
            frmPilas mPilas = new frmPilas();
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
            //Form
        }
    }
}
