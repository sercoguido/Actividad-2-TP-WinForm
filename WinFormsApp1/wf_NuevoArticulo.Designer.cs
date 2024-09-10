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
            txtNombre = new TextBox();
            lbl_NuevoArticulo = new Label();
            lbl_DescripcionNA = new Label();
            inpDescripcion = new TextBox();
            lbl_MarcaNA = new Label();
            label5 = new Label();
            lbl_PrecioNA = new Label();
            inpPrecio = new TextBox();
            label7 = new Label();
            lbl_ImagenNA = new Label();
            txtCodigo = new TextBox();
            lbl_CodigoNA = new Label();
            btn_BuscarNA = new Button();
            CbMarcas = new ComboBox();
            CbCategoria = new ComboBox();
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
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(119, 112);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(423, 23);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += input_NombreNA_TextChanged;
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
            // inpDescripcion
            // 
            inpDescripcion.BackColor = Color.White;
            inpDescripcion.BorderStyle = BorderStyle.FixedSingle;
            inpDescripcion.Location = new Point(119, 141);
            inpDescripcion.Multiline = true;
            inpDescripcion.Name = "inpDescripcion";
            inpDescripcion.Size = new Size(423, 86);
            inpDescripcion.TabIndex = 9;
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
            // inpPrecio
            // 
            inpPrecio.BackColor = SystemColors.Control;
            inpPrecio.BorderStyle = BorderStyle.FixedSingle;
            inpPrecio.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inpPrecio.Location = new Point(119, 330);
            inpPrecio.Name = "inpPrecio";
            inpPrecio.Size = new Size(166, 22);
            inpPrecio.TabIndex = 15;
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
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.White;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Location = new Point(119, 83);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(423, 23);
            txtCodigo.TabIndex = 20;
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
            // CbMarcas
            // 
            CbMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
            CbMarcas.FormattingEnabled = true;
            CbMarcas.Location = new Point(119, 244);
            CbMarcas.Name = "CbMarcas";
            CbMarcas.Size = new Size(166, 23);
            CbMarcas.TabIndex = 24;
            // 
            // CbCategoria
            // 
            CbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CbCategoria.FormattingEnabled = true;
            CbCategoria.Location = new Point(366, 244);
            CbCategoria.Name = "CbCategoria";
            CbCategoria.Size = new Size(166, 23);
            CbCategoria.TabIndex = 25;
            // 
            // wf_NuevoArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 466);
            Controls.Add(CbCategoria);
            Controls.Add(CbMarcas);
            Controls.Add(btn_BuscarNA);
            Controls.Add(txtCodigo);
            Controls.Add(lbl_CodigoNA);
            Controls.Add(lbl_ImagenNA);
            Controls.Add(label7);
            Controls.Add(inpPrecio);
            Controls.Add(lbl_PrecioNA);
            Controls.Add(label5);
            Controls.Add(lbl_MarcaNA);
            Controls.Add(inpDescripcion);
            Controls.Add(lbl_DescripcionNA);
            Controls.Add(lbl_NuevoArticulo);
            Controls.Add(txtNombre);
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
        private TextBox txtNombre;
        private Label lbl_NuevoArticulo;
        private Label lbl_DescripcionNA;
        private TextBox inpDescripcion;
        private Label lbl_MarcaNA;
        private Label label5;
        private Label lbl_PrecioNA;
        private TextBox inpPrecio;
        private Label label7;
        private Label lbl_ImagenNA;
        private TextBox txtCodigo;
        private Label lbl_CodigoNA;
        private Button btn_BuscarNA;
        private ComboBox CbMarcas;
        private ComboBox CbCategoria;
    }
}