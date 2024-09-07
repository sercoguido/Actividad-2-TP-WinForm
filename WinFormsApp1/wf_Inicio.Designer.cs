namespace GestionCatalogo
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
            btn_Ayuda = new ToolStripMenuItem();
            lbl_Titulo = new Label();
            btn_Busqueda = new Button();
            btn_AgregarArticulo = new Button();
            statusStrip1 = new StatusStrip();
            lbl_Creditos = new ToolStripStatusLabel();
            btn_EliminarArticulo = new Button();
            btn_ModificarArticulo = new Button();
            btn_MarcasCategorias = new Button();
            label2 = new Label();
            gb_AdmArticulos = new GroupBox();
            btn_DetallesArticulos = new Button();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            gb_AdmArticulos.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { btn_Ayuda });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(756, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // btn_Ayuda
            // 
            btn_Ayuda.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Ayuda.Margin = new Padding(0, 0, 10, 0);
            btn_Ayuda.Name = "btn_Ayuda";
            btn_Ayuda.Size = new Size(58, 20);
            btn_Ayuda.Text = "Ayuda";
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Tahoma", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_Titulo.Location = new Point(21, 48);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(149, 29);
            lbl_Titulo.TabIndex = 1;
            lbl_Titulo.Text = "Bienvenido/a";
            // 
            // btn_Busqueda
            // 
            btn_Busqueda.BackColor = Color.DarkGray;
            btn_Busqueda.FlatAppearance.BorderColor = Color.White;
            btn_Busqueda.FlatAppearance.BorderSize = 2;
            btn_Busqueda.FlatStyle = FlatStyle.Flat;
            btn_Busqueda.Location = new Point(21, 109);
            btn_Busqueda.Name = "btn_Busqueda";
            btn_Busqueda.Size = new Size(332, 147);
            btn_Busqueda.TabIndex = 2;
            btn_Busqueda.Text = "Busqueda";
            btn_Busqueda.UseVisualStyleBackColor = false;
            btn_Busqueda.Click += btn_Busqueda_Click;
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
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl_Creditos });
            statusStrip1.Location = new Point(0, 459);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(756, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Creditos
            // 
            lbl_Creditos.Name = "lbl_Creditos";
            lbl_Creditos.Size = new Size(57, 17);
            lbl_Creditos.Text = "Grupo 2A";
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
            // btn_MarcasCategorias
            // 
            btn_MarcasCategorias.BackColor = Color.FromArgb(255, 255, 192);
            btn_MarcasCategorias.Location = new Point(540, 301);
            btn_MarcasCategorias.Name = "btn_MarcasCategorias";
            btn_MarcasCategorias.Size = new Size(191, 110);
            btn_MarcasCategorias.TabIndex = 9;
            btn_MarcasCategorias.Text = "Marcas / Categorias";
            btn_MarcasCategorias.UseVisualStyleBackColor = false;
            btn_MarcasCategorias.Click += btn_MarcasCategorias_Click;
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
            // gb_AdmArticulos
            // 
            gb_AdmArticulos.Controls.Add(label2);
            gb_AdmArticulos.Controls.Add(btn_ModificarArticulo);
            gb_AdmArticulos.Controls.Add(btn_EliminarArticulo);
            gb_AdmArticulos.Controls.Add(btn_AgregarArticulo);
            gb_AdmArticulos.Location = new Point(368, 104);
            gb_AdmArticulos.Name = "gb_AdmArticulos";
            gb_AdmArticulos.Size = new Size(373, 155);
            gb_AdmArticulos.TabIndex = 11;
            gb_AdmArticulos.TabStop = false;
            // 
            // btn_DetallesArticulos
            // 
            btn_DetallesArticulos.Location = new Point(21, 301);
            btn_DetallesArticulos.Name = "btn_DetallesArticulos";
            btn_DetallesArticulos.Size = new Size(468, 110);
            btn_DetallesArticulos.TabIndex = 12;
            btn_DetallesArticulos.Text = "Detalles";
            btn_DetallesArticulos.UseVisualStyleBackColor = true;
            btn_DetallesArticulos.Click += btn_DetallesArticulos_Click;
            // 
            // wf_Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(756, 481);
            Controls.Add(btn_DetallesArticulos);
            Controls.Add(gb_AdmArticulos);
            Controls.Add(btn_MarcasCategorias);
            Controls.Add(statusStrip1);
            Controls.Add(btn_Busqueda);
            Controls.Add(lbl_Titulo);
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
            Text = " ";
            Load += wf_Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            gb_AdmArticulos.ResumeLayout(false);
            gb_AdmArticulos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem btn_Ayuda;
        private Label lbl_Titulo;
        private Button btn_Busqueda;
        private Button btn_AgregarArticulo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbl_Creditos;
        private Button btn_EliminarArticulo;
        private Button btn_ModificarArticulo;
        private Button btn_MarcasCategorias;
        private Label label2;
        private GroupBox gb_AdmArticulos;
        private Button btn_DetallesArticulos;
    }
}
