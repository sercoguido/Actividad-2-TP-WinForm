﻿namespace WinFormsApp1
{
    partial class wf_MarcasCategorias
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
            btn_AgregarMarcasMC = new Button();
            btn_EliminarMarcasMC = new Button();
            gb_MarcasMC = new GroupBox();
            dgvMarcas = new DataGridView();
            gb_CategoriasMC = new GroupBox();
            btn_EliminarCategoriasMC = new Button();
            btn_AgregarCategoriasMC = new Button();
            dgvCategorias = new DataGridView();
            gb_MarcasMC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).BeginInit();
            gb_CategoriasMC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // btn_AgregarMarcasMC
            // 
            btn_AgregarMarcasMC.BackColor = Color.FromArgb(128, 255, 128);
            btn_AgregarMarcasMC.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btn_AgregarMarcasMC.Location = new Point(13, 28);
            btn_AgregarMarcasMC.Name = "btn_AgregarMarcasMC";
            btn_AgregarMarcasMC.Size = new Size(98, 36);
            btn_AgregarMarcasMC.TabIndex = 0;
            btn_AgregarMarcasMC.Text = "Agregar";
            btn_AgregarMarcasMC.UseVisualStyleBackColor = false;
            btn_AgregarMarcasMC.Click += btn_AgregarMarcasMC_Click;
            // 
            // btn_EliminarMarcasMC
            // 
            btn_EliminarMarcasMC.BackColor = Color.FromArgb(255, 128, 128);
            btn_EliminarMarcasMC.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btn_EliminarMarcasMC.Location = new Point(128, 28);
            btn_EliminarMarcasMC.Name = "btn_EliminarMarcasMC";
            btn_EliminarMarcasMC.Size = new Size(98, 36);
            btn_EliminarMarcasMC.TabIndex = 1;
            btn_EliminarMarcasMC.Text = "Eliminar";
            btn_EliminarMarcasMC.UseVisualStyleBackColor = false;
            // 
            // gb_MarcasMC
            // 
            gb_MarcasMC.Controls.Add(dgvMarcas);
            gb_MarcasMC.Controls.Add(btn_EliminarMarcasMC);
            gb_MarcasMC.Controls.Add(btn_AgregarMarcasMC);
            gb_MarcasMC.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gb_MarcasMC.Location = new Point(7, 21);
            gb_MarcasMC.Name = "gb_MarcasMC";
            gb_MarcasMC.Size = new Size(241, 414);
            gb_MarcasMC.TabIndex = 6;
            gb_MarcasMC.TabStop = false;
            gb_MarcasMC.Text = "Marcas";
            // 
            // dgvMarcas
            // 
            dgvMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarcas.Location = new Point(13, 73);
            dgvMarcas.Name = "dgvMarcas";
            dgvMarcas.Size = new Size(213, 329);
            dgvMarcas.TabIndex = 5;
            // 
            // gb_CategoriasMC
            // 
            gb_CategoriasMC.Controls.Add(dgvCategorias);
            gb_CategoriasMC.Controls.Add(btn_EliminarCategoriasMC);
            gb_CategoriasMC.Controls.Add(btn_AgregarCategoriasMC);
            gb_CategoriasMC.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gb_CategoriasMC.Location = new Point(280, 24);
            gb_CategoriasMC.Name = "gb_CategoriasMC";
            gb_CategoriasMC.Size = new Size(241, 414);
            gb_CategoriasMC.TabIndex = 7;
            gb_CategoriasMC.TabStop = false;
            gb_CategoriasMC.Text = "Categorias";
            // 
            // btn_EliminarCategoriasMC
            // 
            btn_EliminarCategoriasMC.BackColor = Color.FromArgb(255, 128, 128);
            btn_EliminarCategoriasMC.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btn_EliminarCategoriasMC.Location = new Point(128, 28);
            btn_EliminarCategoriasMC.Name = "btn_EliminarCategoriasMC";
            btn_EliminarCategoriasMC.Size = new Size(98, 36);
            btn_EliminarCategoriasMC.TabIndex = 1;
            btn_EliminarCategoriasMC.Text = "Eliminar";
            btn_EliminarCategoriasMC.UseVisualStyleBackColor = false;
            // 
            // btn_AgregarCategoriasMC
            // 
            btn_AgregarCategoriasMC.BackColor = Color.FromArgb(128, 255, 128);
            btn_AgregarCategoriasMC.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btn_AgregarCategoriasMC.Location = new Point(13, 28);
            btn_AgregarCategoriasMC.Name = "btn_AgregarCategoriasMC";
            btn_AgregarCategoriasMC.Size = new Size(98, 36);
            btn_AgregarCategoriasMC.TabIndex = 0;
            btn_AgregarCategoriasMC.Text = "Agregar";
            btn_AgregarCategoriasMC.UseVisualStyleBackColor = false;
            btn_AgregarCategoriasMC.Click += btn_AgregarCategoriasMC_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(13, 70);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(213, 329);
            dgvCategorias.TabIndex = 6;
            // 
            // wf_MarcasCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 450);
            Controls.Add(gb_CategoriasMC);
            Controls.Add(gb_MarcasMC);
            MaximizeBox = false;
            Name = "wf_MarcasCategorias";
            StartPosition = FormStartPosition.CenterParent;
            Text = "wf_MarcasCategorias";
            Load += wf_MarcasCategorias_Load;
            gb_MarcasMC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).EndInit();
            gb_CategoriasMC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_AgregarMarcasMC;
        private Button btn_EliminarMarcasMC;
        private GroupBox gb_MarcasMC;
        private GroupBox gb_CategoriasMC;
        private Button btn_EliminarCategoriasMC;
        private Button btn_AgregarCategoriasMC;
        private DataGridView dgvMarcas;
        private DataGridView dgvCategorias;
    }
}