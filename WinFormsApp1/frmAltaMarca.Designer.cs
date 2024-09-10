namespace WinFormsApp1
{
    partial class frmAltaMarca
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
            btnAgregarMarca = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            lbl_Marca = new Label();
            SuspendLayout();
            // 
            // btnAgregarMarca
            // 
            btnAgregarMarca.Location = new Point(199, 151);
            btnAgregarMarca.Name = "btnAgregarMarca";
            btnAgregarMarca.Size = new Size(75, 23);
            btnAgregarMarca.TabIndex = 7;
            btnAgregarMarca.Text = "Agregar";
            btnAgregarMarca.UseVisualStyleBackColor = true;
            btnAgregarMarca.Click += btnAgregarMarca_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 94);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(308, 23);
            txtNombre.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 74);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre :";
            // 
            // lbl_Marca
            // 
            lbl_Marca.AutoSize = true;
            lbl_Marca.Font = new Font("Segoe UI", 15F);
            lbl_Marca.Location = new Point(173, 20);
            lbl_Marca.Name = "lbl_Marca";
            lbl_Marca.Size = new Size(128, 28);
            lbl_Marca.TabIndex = 4;
            lbl_Marca.Text = "ALTA MARCA";
            // 
            // frmAltaMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(478, 194);
            Controls.Add(btnAgregarMarca);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(lbl_Marca);
            Name = "frmAltaMarca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAltaMarca";
            Load += frmAltaMarca_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarMarca;
        private TextBox txtNombre;
        private Label label2;
        private Label lbl_Marca;
    }
}