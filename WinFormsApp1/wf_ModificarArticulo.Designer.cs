namespace WinFormsApp1
{
    partial class wf_ModificarArticulo
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
            input_CodigoArticuloMA = new TextBox();
            lbl_NroArticuloMA = new Label();
            lbl_NombreMA = new Label();
            lbl_DescripcionMA = new Label();
            lbl_MarcaMA = new Label();
            lbl_CategoriaMA = new Label();
            lbl_ImagenMA = new Label();
            lbl_PrecioMA = new Label();
            input_NombreModificarMA = new TextBox();
            input_NombreDescripcionMA = new TextBox();
            btn_PrecioMA = new TextBox();
            btn_BuscarImagenMA = new Button();
            lb_MarcaMA = new ListBox();
            lb_CategoriaMA = new ListBox();
            btn_ModificarMA = new Button();
            SuspendLayout();
            // 
            // input_CodigoArticuloMA
            // 
            input_CodigoArticuloMA.BackColor = SystemColors.ScrollBar;
            input_CodigoArticuloMA.BorderStyle = BorderStyle.FixedSingle;
            input_CodigoArticuloMA.ForeColor = SystemColors.Control;
            input_CodigoArticuloMA.Location = new Point(157, 64);
            input_CodigoArticuloMA.Name = "input_CodigoArticuloMA";
            input_CodigoArticuloMA.Size = new Size(121, 23);
            input_CodigoArticuloMA.TabIndex = 5;
            // 
            // lbl_NroArticuloMA
            // 
            lbl_NroArticuloMA.AutoSize = true;
            lbl_NroArticuloMA.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NroArticuloMA.Location = new Point(78, 31);
            lbl_NroArticuloMA.Name = "lbl_NroArticuloMA";
            lbl_NroArticuloMA.Size = new Size(274, 19);
            lbl_NroArticuloMA.TabIndex = 4;
            lbl_NroArticuloMA.Text = "INGRESE EL NUMERO DE ARTICULO";
            // 
            // lbl_NombreMA
            // 
            lbl_NombreMA.AutoSize = true;
            lbl_NombreMA.Location = new Point(70, 127);
            lbl_NombreMA.Name = "lbl_NombreMA";
            lbl_NombreMA.Size = new Size(54, 15);
            lbl_NombreMA.TabIndex = 6;
            lbl_NombreMA.Text = "Nombre:";
            // 
            // lbl_DescripcionMA
            // 
            lbl_DescripcionMA.AutoSize = true;
            lbl_DescripcionMA.Location = new Point(52, 159);
            lbl_DescripcionMA.Name = "lbl_DescripcionMA";
            lbl_DescripcionMA.Size = new Size(72, 15);
            lbl_DescripcionMA.TabIndex = 7;
            lbl_DescripcionMA.Text = "Descripcion:";
            // 
            // lbl_MarcaMA
            // 
            lbl_MarcaMA.AutoSize = true;
            lbl_MarcaMA.Location = new Point(81, 191);
            lbl_MarcaMA.Name = "lbl_MarcaMA";
            lbl_MarcaMA.Size = new Size(43, 15);
            lbl_MarcaMA.TabIndex = 8;
            lbl_MarcaMA.Text = "Marca:";
            // 
            // lbl_CategoriaMA
            // 
            lbl_CategoriaMA.AutoSize = true;
            lbl_CategoriaMA.Location = new Point(63, 223);
            lbl_CategoriaMA.Name = "lbl_CategoriaMA";
            lbl_CategoriaMA.Size = new Size(61, 15);
            lbl_CategoriaMA.TabIndex = 9;
            lbl_CategoriaMA.Text = "Categoria:";
            // 
            // lbl_ImagenMA
            // 
            lbl_ImagenMA.AutoSize = true;
            lbl_ImagenMA.Location = new Point(74, 252);
            lbl_ImagenMA.Name = "lbl_ImagenMA";
            lbl_ImagenMA.Size = new Size(50, 15);
            lbl_ImagenMA.TabIndex = 10;
            lbl_ImagenMA.Text = "Imagen:";
            // 
            // lbl_PrecioMA
            // 
            lbl_PrecioMA.AutoSize = true;
            lbl_PrecioMA.Location = new Point(81, 285);
            lbl_PrecioMA.Name = "lbl_PrecioMA";
            lbl_PrecioMA.Size = new Size(43, 15);
            lbl_PrecioMA.TabIndex = 11;
            lbl_PrecioMA.Text = "Precio:";
            // 
            // input_NombreModificarMA
            // 
            input_NombreModificarMA.Location = new Point(130, 124);
            input_NombreModificarMA.Name = "input_NombreModificarMA";
            input_NombreModificarMA.Size = new Size(209, 23);
            input_NombreModificarMA.TabIndex = 12;
            // 
            // input_NombreDescripcionMA
            // 
            input_NombreDescripcionMA.Location = new Point(130, 156);
            input_NombreDescripcionMA.Name = "input_NombreDescripcionMA";
            input_NombreDescripcionMA.Size = new Size(209, 23);
            input_NombreDescripcionMA.TabIndex = 13;
            // 
            // btn_PrecioMA
            // 
            btn_PrecioMA.Location = new Point(130, 282);
            btn_PrecioMA.Name = "btn_PrecioMA";
            btn_PrecioMA.Size = new Size(209, 23);
            btn_PrecioMA.TabIndex = 14;
            // 
            // btn_BuscarImagenMA
            // 
            btn_BuscarImagenMA.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_BuscarImagenMA.Location = new Point(130, 251);
            btn_BuscarImagenMA.Name = "btn_BuscarImagenMA";
            btn_BuscarImagenMA.Size = new Size(75, 23);
            btn_BuscarImagenMA.TabIndex = 15;
            btn_BuscarImagenMA.Text = "Buscar...";
            btn_BuscarImagenMA.UseVisualStyleBackColor = true;
            // 
            // lb_MarcaMA
            // 
            lb_MarcaMA.FormattingEnabled = true;
            lb_MarcaMA.ItemHeight = 15;
            lb_MarcaMA.Location = new Point(130, 191);
            lb_MarcaMA.Name = "lb_MarcaMA";
            lb_MarcaMA.Size = new Size(209, 19);
            lb_MarcaMA.TabIndex = 16;
            // 
            // lb_CategoriaMA
            // 
            lb_CategoriaMA.FormattingEnabled = true;
            lb_CategoriaMA.ItemHeight = 15;
            lb_CategoriaMA.Location = new Point(130, 223);
            lb_CategoriaMA.Name = "lb_CategoriaMA";
            lb_CategoriaMA.Size = new Size(209, 19);
            lb_CategoriaMA.TabIndex = 17;
            // 
            // btn_ModificarMA
            // 
            btn_ModificarMA.BackColor = Color.DeepSkyBlue;
            btn_ModificarMA.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ModificarMA.ForeColor = Color.Black;
            btn_ModificarMA.Location = new Point(171, 348);
            btn_ModificarMA.Name = "btn_ModificarMA";
            btn_ModificarMA.Size = new Size(107, 36);
            btn_ModificarMA.TabIndex = 19;
            btn_ModificarMA.Text = "MODIFICAR";
            btn_ModificarMA.UseVisualStyleBackColor = false;
            // 
            // wf_ModificarArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 408);
            Controls.Add(btn_ModificarMA);
            Controls.Add(lb_CategoriaMA);
            Controls.Add(lb_MarcaMA);
            Controls.Add(btn_BuscarImagenMA);
            Controls.Add(btn_PrecioMA);
            Controls.Add(input_NombreDescripcionMA);
            Controls.Add(input_NombreModificarMA);
            Controls.Add(lbl_PrecioMA);
            Controls.Add(lbl_ImagenMA);
            Controls.Add(lbl_CategoriaMA);
            Controls.Add(lbl_MarcaMA);
            Controls.Add(lbl_DescripcionMA);
            Controls.Add(lbl_NombreMA);
            Controls.Add(input_CodigoArticuloMA);
            Controls.Add(lbl_NroArticuloMA);
            Name = "wf_ModificarArticulo";
            Text = "wf_ModificarArticulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input_CodigoArticuloMA;
        private Label lbl_NroArticuloMA;
        private Label lbl_NombreMA;
        private Label lbl_DescripcionMA;
        private Label lbl_MarcaMA;
        private Label lbl_CategoriaMA;
        private Label lbl_ImagenMA;
        private Label lbl_PrecioMA;
        private TextBox input_NombreModificarMA;
        private TextBox input_NombreDescripcionMA;
        private TextBox btn_PrecioMA;
        private Button btn_BuscarImagenMA;
        private ListBox lb_MarcaMA;
        private ListBox lb_CategoriaMA;
        private Button btn_ModificarMA;
    }
}