namespace GestionCatalogo
{
    partial class wf_NuevoArticulo
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
            lbl_NombreNA = new Label();
            btnAgregarNA = new Button();
            input_NombreNA = new TextBox();
            lbl_NuevoArticulo = new Label();
            lbl_DescripcionNA = new Label();
            input_DescripcionNA = new TextBox();
            lbl_MarcaNA = new Label();
            label5 = new Label();
            lbl_PrecioNA = new Label();
            input_PrecioNA = new TextBox();
            label7 = new Label();
            lbl_ImagenNA = new Label();
            input_CodigoNA = new TextBox();
            lbl_CodigoNA = new Label();
            btn_BuscarNA = new Button();
            listBoxMarca = new ListBox();
            listBoxCategoria = new ListBox();
            SuspendLayout();
            // 
            // lbl_NombreNA
            // 
            lbl_NombreNA.AutoSize = true;
            lbl_NombreNA.Font = new Font("Tahoma", 9.75F);
            lbl_NombreNA.Location = new Point(56, 114);
            lbl_NombreNA.Name = "lbl_NombreNA";
            lbl_NombreNA.Size = new Size(57, 16);
            lbl_NombreNA.TabIndex = 0;
            lbl_NombreNA.Text = "Nombre:";
            lbl_NombreNA.Click += label1_Click;
            // 
            // btnAgregarNA
            // 
            btnAgregarNA.BackColor = Color.MediumSeaGreen;
            btnAgregarNA.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarNA.Location = new Point(419, 393);
            btnAgregarNA.Name = "btnAgregarNA";
            btnAgregarNA.Size = new Size(123, 46);
            btnAgregarNA.TabIndex = 2;
            btnAgregarNA.Text = "Agregar";
            btnAgregarNA.UseVisualStyleBackColor = false;
            btnAgregarNA.Click += btnAgregar_Click;
            // 
            // input_NombreNA
            // 
            input_NombreNA.BackColor = Color.White;
            input_NombreNA.BorderStyle = BorderStyle.FixedSingle;
            input_NombreNA.Location = new Point(119, 112);
            input_NombreNA.Name = "input_NombreNA";
            input_NombreNA.Size = new Size(423, 23);
            input_NombreNA.TabIndex = 4;
            // 
            // lbl_NuevoArticulo
            // 
            lbl_NuevoArticulo.AutoSize = true;
            lbl_NuevoArticulo.Font = new Font("Segoe UI", 13F);
            lbl_NuevoArticulo.Location = new Point(21, 24);
            lbl_NuevoArticulo.Name = "lbl_NuevoArticulo";
            lbl_NuevoArticulo.Size = new Size(165, 25);
            lbl_NuevoArticulo.TabIndex = 7;
            lbl_NuevoArticulo.Text = "NUEVO ARTICULO :";
            lbl_NuevoArticulo.Click += label2_Click_1;
            // 
            // lbl_DescripcionNA
            // 
            lbl_DescripcionNA.AutoSize = true;
            lbl_DescripcionNA.Font = new Font("Tahoma", 9.75F);
            lbl_DescripcionNA.Location = new Point(36, 143);
            lbl_DescripcionNA.Name = "lbl_DescripcionNA";
            lbl_DescripcionNA.Size = new Size(77, 16);
            lbl_DescripcionNA.TabIndex = 8;
            lbl_DescripcionNA.Text = "Descripción:";
            // 
            // input_DescripcionNA
            // 
            input_DescripcionNA.BackColor = Color.White;
            input_DescripcionNA.BorderStyle = BorderStyle.FixedSingle;
            input_DescripcionNA.Location = new Point(119, 141);
            input_DescripcionNA.Multiline = true;
            input_DescripcionNA.Name = "input_DescripcionNA";
            input_DescripcionNA.Size = new Size(423, 86);
            input_DescripcionNA.TabIndex = 9;
            // 
            // lbl_MarcaNA
            // 
            lbl_MarcaNA.AutoSize = true;
            lbl_MarcaNA.Font = new Font("Tahoma", 9.75F);
            lbl_MarcaNA.Location = new Point(66, 246);
            lbl_MarcaNA.Name = "lbl_MarcaNA";
            lbl_MarcaNA.Size = new Size(47, 16);
            lbl_MarcaNA.TabIndex = 10;
            lbl_MarcaNA.Text = "Marca:";
            lbl_MarcaNA.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F);
            label5.Location = new Point(293, 246);
            label5.Name = "label5";
            label5.Size = new Size(67, 16);
            label5.TabIndex = 12;
            label5.Text = "Categoria:";
            // 
            // lbl_PrecioNA
            // 
            lbl_PrecioNA.AutoSize = true;
            lbl_PrecioNA.Font = new Font("Tahoma", 9.75F);
            lbl_PrecioNA.Location = new Point(66, 333);
            lbl_PrecioNA.Name = "lbl_PrecioNA";
            lbl_PrecioNA.Size = new Size(47, 16);
            lbl_PrecioNA.TabIndex = 14;
            lbl_PrecioNA.Text = "Precio:";
            lbl_PrecioNA.Click += label6_Click;
            // 
            // input_PrecioNA
            // 
            input_PrecioNA.BackColor = SystemColors.Control;
            input_PrecioNA.BorderStyle = BorderStyle.FixedSingle;
            input_PrecioNA.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            input_PrecioNA.Location = new Point(119, 330);
            input_PrecioNA.Name = "input_PrecioNA";
            input_PrecioNA.Size = new Size(166, 22);
            input_PrecioNA.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(119, 295);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 16;
            // 
            // lbl_ImagenNA
            // 
            lbl_ImagenNA.AutoSize = true;
            lbl_ImagenNA.Font = new Font("Tahoma", 9.75F);
            lbl_ImagenNA.Location = new Point(62, 285);
            lbl_ImagenNA.Name = "lbl_ImagenNA";
            lbl_ImagenNA.Size = new Size(55, 16);
            lbl_ImagenNA.TabIndex = 17;
            lbl_ImagenNA.Text = "Imagen:";
            // 
            // input_CodigoNA
            // 
            input_CodigoNA.BackColor = Color.White;
            input_CodigoNA.BorderStyle = BorderStyle.FixedSingle;
            input_CodigoNA.Location = new Point(119, 83);
            input_CodigoNA.Name = "input_CodigoNA";
            input_CodigoNA.Size = new Size(423, 23);
            input_CodigoNA.TabIndex = 20;
            // 
            // lbl_CodigoNA
            // 
            lbl_CodigoNA.AutoSize = true;
            lbl_CodigoNA.Font = new Font("Tahoma", 9.75F);
            lbl_CodigoNA.Location = new Point(62, 84);
            lbl_CodigoNA.Name = "lbl_CodigoNA";
            lbl_CodigoNA.Size = new Size(51, 16);
            lbl_CodigoNA.TabIndex = 19;
            lbl_CodigoNA.Text = "Codigo:";
            // 
            // btn_BuscarNA
            // 
            btn_BuscarNA.BackColor = Color.White;
            btn_BuscarNA.FlatAppearance.BorderColor = Color.Black;
            btn_BuscarNA.FlatStyle = FlatStyle.Flat;
            btn_BuscarNA.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_BuscarNA.Location = new Point(119, 282);
            btn_BuscarNA.Name = "btn_BuscarNA";
            btn_BuscarNA.Size = new Size(75, 23);
            btn_BuscarNA.TabIndex = 21;
            btn_BuscarNA.Text = "Buscar";
            btn_BuscarNA.UseVisualStyleBackColor = false;
            // 
            // listBoxMarca
            // 
            listBoxMarca.FormattingEnabled = true;
            listBoxMarca.ItemHeight = 15;
            listBoxMarca.Location = new Point(119, 246);
            listBoxMarca.Name = "listBoxMarca";
            listBoxMarca.Size = new Size(166, 19);
            listBoxMarca.TabIndex = 22;
            listBoxMarca.SelectedIndexChanged += listBoxMarca_SelectedIndexChanged;
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 15;
            listBoxCategoria.Location = new Point(366, 246);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(166, 19);
            listBoxCategoria.TabIndex = 23;
            // 
            // wf_NuevoArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 466);
            Controls.Add(listBoxCategoria);
            Controls.Add(listBoxMarca);
            Controls.Add(btn_BuscarNA);
            Controls.Add(input_CodigoNA);
            Controls.Add(lbl_CodigoNA);
            Controls.Add(lbl_ImagenNA);
            Controls.Add(label7);
            Controls.Add(input_PrecioNA);
            Controls.Add(lbl_PrecioNA);
            Controls.Add(label5);
            Controls.Add(lbl_MarcaNA);
            Controls.Add(input_DescripcionNA);
            Controls.Add(lbl_DescripcionNA);
            Controls.Add(lbl_NuevoArticulo);
            Controls.Add(input_NombreNA);
            Controls.Add(btnAgregarNA);
            Controls.Add(lbl_NombreNA);
            MaximizeBox = false;
            MaximumSize = new Size(620, 505);
            Name = "wf_NuevoArticulo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestion Catalogo [Nuevo Articulo]";
            Load += Form2_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_NombreNA;
        private Button btnAgregarNA;
        private TextBox input_NombreNA;
        private Label lbl_NuevoArticulo;
        private Label lbl_DescripcionNA;
        private TextBox input_DescripcionNA;
        private Label lbl_MarcaNA;
        private Label label5;
        private Label lbl_PrecioNA;
        private TextBox input_PrecioNA;
        private Label label7;
        private Label lbl_ImagenNA;
        private TextBox input_CodigoNA;
        private Label lbl_CodigoNA;
        private Button btn_BuscarNA;
        private ListBox listBoxMarca;
        private ListBox listBoxCategoria;
    }
}