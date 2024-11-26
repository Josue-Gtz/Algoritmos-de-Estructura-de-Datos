
namespace EDDemo
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estructurasLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasNoLibealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmosRecursivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exponenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaArregloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaBinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torresDeHanoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmosOrdenamientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estructurasLinealesToolStripMenuItem,
            this.estructurasNoLibealesToolStripMenuItem,
            this.algoritmosRecursivosToolStripMenuItem,
            this.algoritmosOrdenamientosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1902, 26);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estructurasLinealesToolStripMenuItem
            // 
            this.estructurasLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilasToolStripMenuItem,
            this.colasToolStripMenuItem,
            this.listasToolStripMenuItem});
            this.estructurasLinealesToolStripMenuItem.Name = "estructurasLinealesToolStripMenuItem";
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.estructurasLinealesToolStripMenuItem.Text = "Estructuras lineales";
            this.estructurasLinealesToolStripMenuItem.Click += new System.EventHandler(this.estructurasLinealesToolStripMenuItem_Click);
            // 
            // pilasToolStripMenuItem
            // 
            this.pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            this.pilasToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.pilasToolStripMenuItem.Text = "Pilas";
            this.pilasToolStripMenuItem.Click += new System.EventHandler(this.pilasToolStripMenuItem_Click);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.colasToolStripMenuItem.Text = "Colas";
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.listasToolStripMenuItem.Text = "Listas";
            // 
            // estructurasNoLibealesToolStripMenuItem
            // 
            this.estructurasNoLibealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolesToolStripMenuItem});
            this.estructurasNoLibealesToolStripMenuItem.Name = "estructurasNoLibealesToolStripMenuItem";
            this.estructurasNoLibealesToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.estructurasNoLibealesToolStripMenuItem.Text = "Estructuras no libeales";
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            this.arbolesToolStripMenuItem.Click += new System.EventHandler(this.arbolesToolStripMenuItem_Click);
            // 
            // algoritmosRecursivosToolStripMenuItem
            // 
            this.algoritmosRecursivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.factorialToolStripMenuItem,
            this.exponenteToolStripMenuItem,
            this.sumaArregloToolStripMenuItem,
            this.fibonacciToolStripMenuItem,
            this.busquedaBinariaToolStripMenuItem,
            this.torresDeHanoiToolStripMenuItem});
            this.algoritmosRecursivosToolStripMenuItem.Name = "algoritmosRecursivosToolStripMenuItem";
            this.algoritmosRecursivosToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.algoritmosRecursivosToolStripMenuItem.Text = "Algoritmos Recursivos";
            // 
            // factorialToolStripMenuItem
            // 
            this.factorialToolStripMenuItem.Name = "factorialToolStripMenuItem";
            this.factorialToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.factorialToolStripMenuItem.Text = "Factorial";
            this.factorialToolStripMenuItem.Click += new System.EventHandler(this.factorialToolStripMenuItem_Click);
            // 
            // exponenteToolStripMenuItem
            // 
            this.exponenteToolStripMenuItem.Name = "exponenteToolStripMenuItem";
            this.exponenteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exponenteToolStripMenuItem.Text = "Exponente";
            // 
            // sumaArregloToolStripMenuItem
            // 
            this.sumaArregloToolStripMenuItem.Name = "sumaArregloToolStripMenuItem";
            this.sumaArregloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sumaArregloToolStripMenuItem.Text = "Suma Arreglo";
            // 
            // fibonacciToolStripMenuItem
            // 
            this.fibonacciToolStripMenuItem.Name = "fibonacciToolStripMenuItem";
            this.fibonacciToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fibonacciToolStripMenuItem.Text = "Fibonacci";
            // 
            // busquedaBinariaToolStripMenuItem
            // 
            this.busquedaBinariaToolStripMenuItem.Name = "busquedaBinariaToolStripMenuItem";
            this.busquedaBinariaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.busquedaBinariaToolStripMenuItem.Text = "Busqueda Binaria";
            // 
            // torresDeHanoiToolStripMenuItem
            // 
            this.torresDeHanoiToolStripMenuItem.Name = "torresDeHanoiToolStripMenuItem";
            this.torresDeHanoiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.torresDeHanoiToolStripMenuItem.Text = "Torres de Hanoi";
            // 
            // algoritmosOrdenamientosToolStripMenuItem
            // 
            this.algoritmosOrdenamientosToolStripMenuItem.Name = "algoritmosOrdenamientosToolStripMenuItem";
            this.algoritmosOrdenamientosToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.algoritmosOrdenamientosToolStripMenuItem.Text = "Algoritmos Ordenamientos";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estructurasLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasNoLibealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmosRecursivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exponenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaArregloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaBinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torresDeHanoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmosOrdenamientosToolStripMenuItem;
    }
}

