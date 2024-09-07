namespace WinFormsApp1
{
    partial class wf_Detalles
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
            input_CodigoArticuloDetalles = new TextBox();
            lbl_NroArticuloDetalles = new Label();
            lbl_PrecioDetalles = new Label();
            lbl_ImagenDetalles = new Label();
            lbl_CategoriaDetalles = new Label();
            lbl_MarcaDetalles = new Label();
            lbl_DescripcionDetalles = new Label();
            lbl_NombreDetalles = new Label();
            pb_ImagenesDA = new PictureBox();
            lbl_PrecioDA = new Label();
            lbl_NombreDA = new Label();
            lbl_DescripcionDA = new Label();
            lbl_MarcasDA = new Label();
            lbl_CategoriaDA = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_ImagenesDA).BeginInit();
            SuspendLayout();
            // 
            // input_CodigoArticuloDetalles
            // 
            input_CodigoArticuloDetalles.BackColor = SystemColors.ScrollBar;
            input_CodigoArticuloDetalles.BorderStyle = BorderStyle.FixedSingle;
            input_CodigoArticuloDetalles.ForeColor = SystemColors.Control;
            input_CodigoArticuloDetalles.Location = new Point(174, 78);
            input_CodigoArticuloDetalles.Name = "input_CodigoArticuloDetalles";
            input_CodigoArticuloDetalles.Size = new Size(125, 23);
            input_CodigoArticuloDetalles.TabIndex = 7;
            input_CodigoArticuloDetalles.TextChanged += input_CodigoArticuloMA_TextChanged;
            // 
            // lbl_NroArticuloDetalles
            // 
            lbl_NroArticuloDetalles.AutoSize = true;
            lbl_NroArticuloDetalles.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NroArticuloDetalles.Location = new Point(89, 43);
            lbl_NroArticuloDetalles.Name = "lbl_NroArticuloDetalles";
            lbl_NroArticuloDetalles.Size = new Size(277, 19);
            lbl_NroArticuloDetalles.TabIndex = 6;
            lbl_NroArticuloDetalles.Text = "INGRESE EL CODIGO DE ARTICULO:";
            // 
            // lbl_PrecioDetalles
            // 
            lbl_PrecioDetalles.AutoSize = true;
            lbl_PrecioDetalles.Location = new Point(89, 382);
            lbl_PrecioDetalles.Name = "lbl_PrecioDetalles";
            lbl_PrecioDetalles.Size = new Size(43, 15);
            lbl_PrecioDetalles.TabIndex = 17;
            lbl_PrecioDetalles.Text = "Precio:";
            // 
            // lbl_ImagenDetalles
            // 
            lbl_ImagenDetalles.AutoSize = true;
            lbl_ImagenDetalles.Location = new Point(82, 264);
            lbl_ImagenDetalles.Name = "lbl_ImagenDetalles";
            lbl_ImagenDetalles.Size = new Size(50, 15);
            lbl_ImagenDetalles.TabIndex = 16;
            lbl_ImagenDetalles.Text = "Imagen:";
            // 
            // lbl_CategoriaDetalles
            // 
            lbl_CategoriaDetalles.AutoSize = true;
            lbl_CategoriaDetalles.Location = new Point(71, 235);
            lbl_CategoriaDetalles.Name = "lbl_CategoriaDetalles";
            lbl_CategoriaDetalles.Size = new Size(61, 15);
            lbl_CategoriaDetalles.TabIndex = 15;
            lbl_CategoriaDetalles.Text = "Categoria:";
            // 
            // lbl_MarcaDetalles
            // 
            lbl_MarcaDetalles.AutoSize = true;
            lbl_MarcaDetalles.Location = new Point(89, 203);
            lbl_MarcaDetalles.Name = "lbl_MarcaDetalles";
            lbl_MarcaDetalles.Size = new Size(43, 15);
            lbl_MarcaDetalles.TabIndex = 14;
            lbl_MarcaDetalles.Text = "Marca:";
            // 
            // lbl_DescripcionDetalles
            // 
            lbl_DescripcionDetalles.AutoSize = true;
            lbl_DescripcionDetalles.Location = new Point(60, 171);
            lbl_DescripcionDetalles.Name = "lbl_DescripcionDetalles";
            lbl_DescripcionDetalles.Size = new Size(72, 15);
            lbl_DescripcionDetalles.TabIndex = 13;
            lbl_DescripcionDetalles.Text = "Descripcion:";
            // 
            // lbl_NombreDetalles
            // 
            lbl_NombreDetalles.AutoSize = true;
            lbl_NombreDetalles.Location = new Point(78, 139);
            lbl_NombreDetalles.Name = "lbl_NombreDetalles";
            lbl_NombreDetalles.Size = new Size(54, 15);
            lbl_NombreDetalles.TabIndex = 12;
            lbl_NombreDetalles.Text = "Nombre:";
            // 
            // pb_ImagenesDA
            // 
            pb_ImagenesDA.Location = new Point(150, 264);
            pb_ImagenesDA.Name = "pb_ImagenesDA";
            pb_ImagenesDA.Size = new Size(219, 102);
            pb_ImagenesDA.TabIndex = 22;
            pb_ImagenesDA.TabStop = false;
            // 
            // lbl_PrecioDA
            // 
            lbl_PrecioDA.AutoSize = true;
            lbl_PrecioDA.Location = new Point(150, 382);
            lbl_PrecioDA.Name = "lbl_PrecioDA";
            lbl_PrecioDA.Size = new Size(0, 15);
            lbl_PrecioDA.TabIndex = 23;
            // 
            // lbl_NombreDA
            // 
            lbl_NombreDA.AutoSize = true;
            lbl_NombreDA.Location = new Point(150, 139);
            lbl_NombreDA.Name = "lbl_NombreDA";
            lbl_NombreDA.Size = new Size(0, 15);
            lbl_NombreDA.TabIndex = 24;
            // 
            // lbl_DescripcionDA
            // 
            lbl_DescripcionDA.AutoSize = true;
            lbl_DescripcionDA.Location = new Point(150, 171);
            lbl_DescripcionDA.Name = "lbl_DescripcionDA";
            lbl_DescripcionDA.Size = new Size(0, 15);
            lbl_DescripcionDA.TabIndex = 25;
            // 
            // lbl_MarcasDA
            // 
            lbl_MarcasDA.AutoSize = true;
            lbl_MarcasDA.Location = new Point(150, 203);
            lbl_MarcasDA.Name = "lbl_MarcasDA";
            lbl_MarcasDA.Size = new Size(0, 15);
            lbl_MarcasDA.TabIndex = 26;
            // 
            // lbl_CategoriaDA
            // 
            lbl_CategoriaDA.AutoSize = true;
            lbl_CategoriaDA.Location = new Point(150, 235);
            lbl_CategoriaDA.Name = "lbl_CategoriaDA";
            lbl_CategoriaDA.Size = new Size(0, 15);
            lbl_CategoriaDA.TabIndex = 27;
            // 
            // wf_Detalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 450);
            Controls.Add(lbl_CategoriaDA);
            Controls.Add(lbl_MarcasDA);
            Controls.Add(lbl_DescripcionDA);
            Controls.Add(lbl_NombreDA);
            Controls.Add(lbl_PrecioDA);
            Controls.Add(pb_ImagenesDA);
            Controls.Add(lbl_PrecioDetalles);
            Controls.Add(lbl_ImagenDetalles);
            Controls.Add(lbl_CategoriaDetalles);
            Controls.Add(lbl_MarcaDetalles);
            Controls.Add(lbl_DescripcionDetalles);
            Controls.Add(lbl_NombreDetalles);
            Controls.Add(input_CodigoArticuloDetalles);
            Controls.Add(lbl_NroArticuloDetalles);
            MaximizeBox = false;
            MaximumSize = new Size(489, 489);
            Name = "wf_Detalles";
            StartPosition = FormStartPosition.CenterParent;
            Text = "wf_Detalles";
            ((System.ComponentModel.ISupportInitialize)pb_ImagenesDA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input_CodigoArticuloDetalles;
        private Label lbl_NroArticuloDetalles;
        private Label lbl_PrecioDetalles;
        private Label lbl_ImagenDetalles;
        private Label lbl_CategoriaDetalles;
        private Label lbl_MarcaDetalles;
        private Label lbl_DescripcionDetalles;
        private Label lbl_NombreDetalles;
        private PictureBox pb_ImagenesDA;
        private Label lbl_PrecioDA;
        private Label lbl_NombreDA;
        private Label lbl_DescripcionDA;
        private Label lbl_MarcasDA;
        private Label lbl_CategoriaDA;
    }
}