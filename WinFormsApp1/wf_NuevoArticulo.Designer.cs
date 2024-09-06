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
            label1 = new Label();
            btnAgregar = new Button();
            txt_Nombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            label9 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F);
            label1.Location = new Point(56, 114);
            label1.Name = "label1";
            label1.Size = new Size(57, 16);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(419, 393);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 46);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.White;
            txt_Nombre.BorderStyle = BorderStyle.FixedSingle;
            txt_Nombre.Location = new Point(119, 112);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(423, 23);
            txt_Nombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(21, 24);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 7;
            label2.Text = "NUEVO ARTICULO :";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F);
            label3.Location = new Point(36, 143);
            label3.Name = "label3";
            label3.Size = new Size(77, 16);
            label3.TabIndex = 8;
            label3.Text = "Descripción:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(119, 141);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(423, 86);
            textBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F);
            label4.Location = new Point(66, 246);
            label4.Name = "label4";
            label4.Size = new Size(47, 16);
            label4.TabIndex = 10;
            label4.Text = "Marca:";
            label4.Click += label4_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(119, 245);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(166, 17);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.White;
            listBox2.BorderStyle = BorderStyle.FixedSingle;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(366, 246);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(176, 17);
            listBox2.TabIndex = 13;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F);
            label6.Location = new Point(66, 333);
            label6.Name = "label6";
            label6.Size = new Size(47, 16);
            label6.TabIndex = 14;
            label6.Text = "Precio:";
            label6.Click += label6_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(119, 330);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 22);
            textBox2.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(119, 295);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F);
            label9.Location = new Point(62, 285);
            label9.Name = "label9";
            label9.Size = new Size(55, 16);
            label9.TabIndex = 17;
            label9.Text = "Imagen:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(119, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(423, 23);
            textBox3.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F);
            label8.Location = new Point(62, 84);
            label8.Name = "label8";
            label8.Size = new Size(51, 16);
            label8.TabIndex = 19;
            label8.Text = "Codigo:";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(119, 282);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // wf_NuevoArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 466);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(listBox2);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Nombre);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(620, 505);
            Name = "wf_NuevoArticulo";
            Text = "Gestion Catalogo [Nuevo Articulo]";
            Load += Form2_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAgregar;
        private TextBox txt_Nombre;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private Label label9;
        private TextBox textBox3;
        private Label label8;
        private Button button1;
    }
}