namespace WinFormsApp1
{
    partial class wf_EliminarArticulo
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
            lbl_NroArticuloEA = new Label();
            label2 = new Label();
            btn_EliminarEA = new Button();
            input_NroArticuloEA = new TextBox();
            SuspendLayout();
            // 
            // lbl_NroArticuloEA
            // 
            lbl_NroArticuloEA.AutoSize = true;
            lbl_NroArticuloEA.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NroArticuloEA.Location = new Point(47, 59);
            lbl_NroArticuloEA.Name = "lbl_NroArticuloEA";
            lbl_NroArticuloEA.Size = new Size(274, 19);
            lbl_NroArticuloEA.TabIndex = 0;
            lbl_NroArticuloEA.Text = "INGRESE EL NUMERO DE ARTICULO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 315);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // btn_EliminarEA
            // 
            btn_EliminarEA.BackColor = Color.Tomato;
            btn_EliminarEA.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_EliminarEA.ForeColor = Color.Black;
            btn_EliminarEA.Location = new Point(140, 221);
            btn_EliminarEA.Name = "btn_EliminarEA";
            btn_EliminarEA.Size = new Size(107, 36);
            btn_EliminarEA.TabIndex = 2;
            btn_EliminarEA.Text = "ELIMINAR";
            btn_EliminarEA.UseVisualStyleBackColor = false;
            // 
            // input_NroArticuloEA
            // 
            input_NroArticuloEA.Location = new Point(82, 92);
            input_NroArticuloEA.Name = "input_NroArticuloEA";
            input_NroArticuloEA.Size = new Size(209, 23);
            input_NroArticuloEA.TabIndex = 3;
            // 
            // wf_EliminarArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 312);
            Controls.Add(input_NroArticuloEA);
            Controls.Add(btn_EliminarEA);
            Controls.Add(label2);
            Controls.Add(lbl_NroArticuloEA);
            MaximizeBox = false;
            MaximumSize = new Size(390, 351);
            Name = "wf_EliminarArticulo";
            Text = "wf_EliminarArticulo";
            Load += wf_EliminarArticulo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_NroArticuloEA;
        private Label label2;
        private Button btn_EliminarEA;
        private TextBox input_NroArticuloEA;
    }
}