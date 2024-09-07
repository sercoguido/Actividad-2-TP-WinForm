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
            lbl_CategoriaDetallesMA = new Label();
            lbl_MarcasDetallesMA = new Label();
            lbl_DescripcionDetallesMA = new Label();
            lbl_NombreDetallesMA = new Label();
            lbl_PrecioDetallesMA = new Label();
            pb_ImagenesDetallesMA = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_ImagenesDetallesMA).BeginInit();
            SuspendLayout();
            // 
            // input_CodigoArticuloMA
            // 
            input_CodigoArticuloMA.BackColor = SystemColors.ScrollBar;
            input_CodigoArticuloMA.BorderStyle = BorderStyle.FixedSingle;
            input_CodigoArticuloMA.ForeColor = SystemColors.Control;
            input_CodigoArticuloMA.Location = new Point(275, 53);
            input_CodigoArticuloMA.Name = "input_CodigoArticuloMA";
            input_CodigoArticuloMA.Size = new Size(121, 23);
            input_CodigoArticuloMA.TabIndex = 5;
            // 
            // lbl_NroArticuloMA
            // 
            lbl_NroArticuloMA.AutoSize = true;
            lbl_NroArticuloMA.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NroArticuloMA.Location = new Point(204, 31);
            lbl_NroArticuloMA.Name = "lbl_NroArticuloMA";
            lbl_NroArticuloMA.Size = new Size(277, 19);
            lbl_NroArticuloMA.TabIndex = 4;
            lbl_NroArticuloMA.Text = "INGRESE EL CODIGO DE ARTICULO:";
            // 
            // lbl_NombreMA
            // 
            lbl_NombreMA.AutoSize = true;
            lbl_NombreMA.Location = new Point(378, 122);
            lbl_NombreMA.Name = "lbl_NombreMA";
            lbl_NombreMA.Size = new Size(54, 15);
            lbl_NombreMA.TabIndex = 6;
            lbl_NombreMA.Text = "Nombre:";
            // 
            // lbl_DescripcionMA
            // 
            lbl_DescripcionMA.AutoSize = true;
            lbl_DescripcionMA.Location = new Point(360, 154);
            lbl_DescripcionMA.Name = "lbl_DescripcionMA";
            lbl_DescripcionMA.Size = new Size(72, 15);
            lbl_DescripcionMA.TabIndex = 7;
            lbl_DescripcionMA.Text = "Descripcion:";
            // 
            // lbl_MarcaMA
            // 
            lbl_MarcaMA.AutoSize = true;
            lbl_MarcaMA.Location = new Point(389, 186);
            lbl_MarcaMA.Name = "lbl_MarcaMA";
            lbl_MarcaMA.Size = new Size(43, 15);
            lbl_MarcaMA.TabIndex = 8;
            lbl_MarcaMA.Text = "Marca:";
            // 
            // lbl_CategoriaMA
            // 
            lbl_CategoriaMA.AutoSize = true;
            lbl_CategoriaMA.Location = new Point(371, 218);
            lbl_CategoriaMA.Name = "lbl_CategoriaMA";
            lbl_CategoriaMA.Size = new Size(61, 15);
            lbl_CategoriaMA.TabIndex = 9;
            lbl_CategoriaMA.Text = "Categoria:";
            // 
            // lbl_ImagenMA
            // 
            lbl_ImagenMA.AutoSize = true;
            lbl_ImagenMA.Location = new Point(382, 247);
            lbl_ImagenMA.Name = "lbl_ImagenMA";
            lbl_ImagenMA.Size = new Size(50, 15);
            lbl_ImagenMA.TabIndex = 10;
            lbl_ImagenMA.Text = "Imagen:";
            // 
            // lbl_PrecioMA
            // 
            lbl_PrecioMA.AutoSize = true;
            lbl_PrecioMA.Location = new Point(389, 280);
            lbl_PrecioMA.Name = "lbl_PrecioMA";
            lbl_PrecioMA.Size = new Size(43, 15);
            lbl_PrecioMA.TabIndex = 11;
            lbl_PrecioMA.Text = "Precio:";
            // 
            // input_NombreModificarMA
            // 
            input_NombreModificarMA.Location = new Point(438, 119);
            input_NombreModificarMA.Name = "input_NombreModificarMA";
            input_NombreModificarMA.Size = new Size(209, 23);
            input_NombreModificarMA.TabIndex = 12;
            // 
            // input_NombreDescripcionMA
            // 
            input_NombreDescripcionMA.Location = new Point(438, 151);
            input_NombreDescripcionMA.Name = "input_NombreDescripcionMA";
            input_NombreDescripcionMA.Size = new Size(209, 23);
            input_NombreDescripcionMA.TabIndex = 13;
            // 
            // btn_PrecioMA
            // 
            btn_PrecioMA.Location = new Point(438, 277);
            btn_PrecioMA.Name = "btn_PrecioMA";
            btn_PrecioMA.Size = new Size(209, 23);
            btn_PrecioMA.TabIndex = 14;
            // 
            // btn_BuscarImagenMA
            // 
            btn_BuscarImagenMA.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_BuscarImagenMA.Location = new Point(438, 246);
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
            lb_MarcaMA.Location = new Point(438, 186);
            lb_MarcaMA.Name = "lb_MarcaMA";
            lb_MarcaMA.Size = new Size(209, 19);
            lb_MarcaMA.TabIndex = 16;
            // 
            // lb_CategoriaMA
            // 
            lb_CategoriaMA.FormattingEnabled = true;
            lb_CategoriaMA.ItemHeight = 15;
            lb_CategoriaMA.Location = new Point(438, 218);
            lb_CategoriaMA.Name = "lb_CategoriaMA";
            lb_CategoriaMA.Size = new Size(209, 19);
            lb_CategoriaMA.TabIndex = 17;
            // 
            // btn_ModificarMA
            // 
            btn_ModificarMA.BackColor = Color.DeepSkyBlue;
            btn_ModificarMA.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ModificarMA.ForeColor = Color.Black;
            btn_ModificarMA.Location = new Point(485, 344);
            btn_ModificarMA.Name = "btn_ModificarMA";
            btn_ModificarMA.Size = new Size(107, 36);
            btn_ModificarMA.TabIndex = 19;
            btn_ModificarMA.Text = "MODIFICAR";
            btn_ModificarMA.UseVisualStyleBackColor = false;
            // 
            // lbl_CategoriaDetallesMA
            // 
            lbl_CategoriaDetallesMA.AutoSize = true;
            lbl_CategoriaDetallesMA.Location = new Point(94, 218);
            lbl_CategoriaDetallesMA.Name = "lbl_CategoriaDetallesMA";
            lbl_CategoriaDetallesMA.Size = new Size(0, 15);
            lbl_CategoriaDetallesMA.TabIndex = 39;
            // 
            // lbl_MarcasDetallesMA
            // 
            lbl_MarcasDetallesMA.AutoSize = true;
            lbl_MarcasDetallesMA.Location = new Point(94, 186);
            lbl_MarcasDetallesMA.Name = "lbl_MarcasDetallesMA";
            lbl_MarcasDetallesMA.Size = new Size(0, 15);
            lbl_MarcasDetallesMA.TabIndex = 38;
            // 
            // lbl_DescripcionDetallesMA
            // 
            lbl_DescripcionDetallesMA.AutoSize = true;
            lbl_DescripcionDetallesMA.Location = new Point(94, 154);
            lbl_DescripcionDetallesMA.Name = "lbl_DescripcionDetallesMA";
            lbl_DescripcionDetallesMA.Size = new Size(0, 15);
            lbl_DescripcionDetallesMA.TabIndex = 37;
            // 
            // lbl_NombreDetallesMA
            // 
            lbl_NombreDetallesMA.AutoSize = true;
            lbl_NombreDetallesMA.Location = new Point(94, 122);
            lbl_NombreDetallesMA.Name = "lbl_NombreDetallesMA";
            lbl_NombreDetallesMA.Size = new Size(0, 15);
            lbl_NombreDetallesMA.TabIndex = 36;
            // 
            // lbl_PrecioDetallesMA
            // 
            lbl_PrecioDetallesMA.AutoSize = true;
            lbl_PrecioDetallesMA.Location = new Point(91, 365);
            lbl_PrecioDetallesMA.Name = "lbl_PrecioDetallesMA";
            lbl_PrecioDetallesMA.Size = new Size(0, 15);
            lbl_PrecioDetallesMA.TabIndex = 35;
            // 
            // pb_ImagenesDetallesMA
            // 
            pb_ImagenesDetallesMA.Location = new Point(90, 247);
            pb_ImagenesDetallesMA.Name = "pb_ImagenesDetallesMA";
            pb_ImagenesDetallesMA.Size = new Size(219, 102);
            pb_ImagenesDetallesMA.TabIndex = 34;
            pb_ImagenesDetallesMA.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 363);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 45;
            label1.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 244);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 44;
            label2.Text = "Imagen:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 215);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 43;
            label3.Text = "Categoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 183);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 42;
            label4.Text = "Marca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 151);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 41;
            label5.Text = "Descripcion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 119);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 40;
            label6.Text = "Nombre:";
            // 
            // wf_ModificarArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 479);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(lbl_CategoriaDetallesMA);
            Controls.Add(lbl_MarcasDetallesMA);
            Controls.Add(lbl_DescripcionDetallesMA);
            Controls.Add(lbl_NombreDetallesMA);
            Controls.Add(lbl_PrecioDetallesMA);
            Controls.Add(pb_ImagenesDetallesMA);
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
            MaximizeBox = false;
            MaximumSize = new Size(697, 518);
            Name = "wf_ModificarArticulo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "wf_ModificarArticulo";
            ((System.ComponentModel.ISupportInitialize)pb_ImagenesDetallesMA).EndInit();
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
        private Label lbl_CategoriaDetallesMA;
        private Label lbl_MarcasDetallesMA;
        private Label lbl_DescripcionDetallesMA;
        private Label lbl_NombreDetallesMA;
        private Label lbl_PrecioDetallesMA;
        private PictureBox pb_ImagenesDetallesMA;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}