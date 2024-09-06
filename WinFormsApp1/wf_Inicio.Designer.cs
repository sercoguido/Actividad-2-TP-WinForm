﻿namespace GestionCatalogo
{
    partial class wf_Inicio
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
            helpToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            button1 = new Button();
            btn_AgregarArticulo = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btn_EliminarArticulo = new Button();
            btn_ModificarArticulo = new Button();
            button4 = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btn_DetallesArticulos = new Button();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(756, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            helpToolStripMenuItem.Margin = new Padding(0, 0, 10, 0);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(58, 20);
            helpToolStripMenuItem.Text = "Ayuda";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 48);
            label1.Name = "label1";
            label1.Size = new Size(149, 29);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido/a";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(21, 109);
            button1.Name = "button1";
            button1.Size = new Size(332, 147);
            button1.TabIndex = 2;
            button1.Text = "Busqueda";
            button1.UseVisualStyleBackColor = false;
            // 
            // btn_AgregarArticulo
            // 
            btn_AgregarArticulo.BackColor = Color.MediumSeaGreen;
            btn_AgregarArticulo.Location = new Point(5, 34);
            btn_AgregarArticulo.Name = "btn_AgregarArticulo";
            btn_AgregarArticulo.Size = new Size(116, 110);
            btn_AgregarArticulo.TabIndex = 4;
            btn_AgregarArticulo.Text = "Agregar";
            btn_AgregarArticulo.UseVisualStyleBackColor = false;
            btn_AgregarArticulo.Click += btn_AgregarArticulo_Click_1;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 483);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(756, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btn_EliminarArticulo
            // 
            btn_EliminarArticulo.BackColor = Color.Tomato;
            btn_EliminarArticulo.Location = new Point(127, 34);
            btn_EliminarArticulo.Name = "btn_EliminarArticulo";
            btn_EliminarArticulo.Size = new Size(116, 110);
            btn_EliminarArticulo.TabIndex = 7;
            btn_EliminarArticulo.Text = "Eliminar";
            btn_EliminarArticulo.UseVisualStyleBackColor = false;
            btn_EliminarArticulo.Click += btn_EliminarArticulo_Click_1;
            // 
            // btn_ModificarArticulo
            // 
            btn_ModificarArticulo.BackColor = Color.DeepSkyBlue;
            btn_ModificarArticulo.Location = new Point(249, 34);
            btn_ModificarArticulo.Name = "btn_ModificarArticulo";
            btn_ModificarArticulo.Size = new Size(116, 110);
            btn_ModificarArticulo.TabIndex = 8;
            btn_ModificarArticulo.Text = "Modificar";
            btn_ModificarArticulo.UseVisualStyleBackColor = false;
            btn_ModificarArticulo.Click += btn_ModificarArticulo_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 255, 192);
            button4.Location = new Point(541, 301);
            button4.Name = "button4";
            button4.Size = new Size(191, 110);
            button4.TabIndex = 9;
            button4.Text = "Marcas / Categorias";
            button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 3);
            label2.Name = "label2";
            label2.Size = new Size(204, 19);
            label2.TabIndex = 10;
            label2.Text = "Administracion de Articulos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btn_ModificarArticulo);
            groupBox1.Controls.Add(btn_EliminarArticulo);
            groupBox1.Controls.Add(btn_AgregarArticulo);
            groupBox1.Location = new Point(368, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 155);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // btn_DetallesArticulos
            // 
            btn_DetallesArticulos.Location = new Point(21, 301);
            btn_DetallesArticulos.Name = "btn_DetallesArticulos";
            btn_DetallesArticulos.Size = new Size(468, 110);
            btn_DetallesArticulos.TabIndex = 12;
            btn_DetallesArticulos.Text = "Detalles";
            btn_DetallesArticulos.UseVisualStyleBackColor = true;
            // 
            // wf_Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(756, 505);
            Controls.Add(btn_DetallesArticulos);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(statusStrip1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(772, 544);
            Name = "wf_Inicio";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Catalogo [Inicio]";
            Load += wf_Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Label label1;
        private Button button1;
        private Button btn_AgregarArticulo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button btn_EliminarArticulo;
        private Button btn_ModificarArticulo;
        private Button button4;
        private Label label2;
        private GroupBox groupBox1;
        private Button btn_DetallesArticulos;
    }
}
