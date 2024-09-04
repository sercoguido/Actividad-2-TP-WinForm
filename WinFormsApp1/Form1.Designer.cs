namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            abrirFormulariosToolStripMenuItem = new ToolStripMenuItem();
            entradaToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            articuloToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { abrirFormulariosToolStripMenuItem, buscarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // abrirFormulariosToolStripMenuItem
            // 
            abrirFormulariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { entradaToolStripMenuItem });
            abrirFormulariosToolStripMenuItem.Name = "abrirFormulariosToolStripMenuItem";
            abrirFormulariosToolStripMenuItem.Size = new Size(54, 20);
            abrirFormulariosToolStripMenuItem.Text = "Nuevo";
            // 
            // entradaToolStripMenuItem
            // 
            entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            entradaToolStripMenuItem.Size = new Size(180, 22);
            entradaToolStripMenuItem.Text = "Articulo";
            entradaToolStripMenuItem.Click += entradaToolStripMenuItem_Click;
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { articuloToolStripMenuItem });
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(54, 20);
            buscarToolStripMenuItem.Text = "Buscar";
            // 
            // articuloToolStripMenuItem
            // 
            articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            articuloToolStripMenuItem.Size = new Size(180, 22);
            articuloToolStripMenuItem.Text = "Articulo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem abrirFormulariosToolStripMenuItem;
        private ToolStripMenuItem entradaToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem articuloToolStripMenuItem;
    }
}
