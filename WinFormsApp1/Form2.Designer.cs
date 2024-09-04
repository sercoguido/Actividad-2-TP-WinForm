namespace WinFormsApp1
{
    partial class Nuevo_Articulo
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
            textBox3 = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 80);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre :";
            label1.Click += label1_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(616, 416);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(141, 76);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(550, 23);
            txt_Nombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(22, 24);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 7;
            label2.Text = "NUEVO ARTICULO :";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 108);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 8;
            label3.Text = "Descripción :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 105);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(550, 86);
            textBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 202);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 10;
            label4.Text = "Marca :";
            label4.Click += label4_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(141, 200);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(550, 19);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(141, 229);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(550, 19);
            listBox2.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 231);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 12;
            label5.Text = "Categoria :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 258);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 14;
            label6.Text = "Precio :";
            label6.Click += label6_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 255);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(550, 23);
            textBox2.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(128, 258);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 16;
            label7.Text = "$";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(141, 284);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(550, 23);
            textBox3.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(79, 287);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 17;
            label9.Text = "Imagen :";
            // 
            // Nuevo_Articulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 451);
            Controls.Add(textBox3);
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
            MinimumSize = new Size(820, 490);
            Name = "Nuevo_Articulo";
            Text = "Nuevo Articulo";
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
        private TextBox textBox3;
        private Label label9;
    }
}