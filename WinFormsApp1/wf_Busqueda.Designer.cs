namespace WinFormsApp1
{
    partial class wf_Busqueda
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
            lv_Busqueda = new ListView();
            lb_BusquedaMarca = new ListBox();
            lb_BusquedaCategoria = new ListBox();
            lb_RangoPrecio1 = new ListBox();
            lb_RangoPrecio2 = new ListBox();
            lb_BusquedaNombre = new ListBox();
            lbl_MarcaBusqueda = new Label();
            lbl_CategoriaBusqueda = new Label();
            lbl_RangoPrecioBusqueda = new Label();
            lbl_NombreBusqueda = new Label();
            lbl_TituloBusqueda = new Label();
            SuspendLayout();
            // 
            // lv_Busqueda
            // 
            lv_Busqueda.Location = new Point(12, 135);
            lv_Busqueda.Name = "lv_Busqueda";
            lv_Busqueda.Size = new Size(498, 351);
            lv_Busqueda.TabIndex = 0;
            lv_Busqueda.UseCompatibleStateImageBehavior = false;
            // 
            // lb_BusquedaMarca
            // 
            lb_BusquedaMarca.BackColor = Color.White;
            lb_BusquedaMarca.FormattingEnabled = true;
            lb_BusquedaMarca.ItemHeight = 15;
            lb_BusquedaMarca.Location = new Point(14, 96);
            lb_BusquedaMarca.Name = "lb_BusquedaMarca";
            lb_BusquedaMarca.Size = new Size(106, 19);
            lb_BusquedaMarca.TabIndex = 1;
            // 
            // lb_BusquedaCategoria
            // 
            lb_BusquedaCategoria.BackColor = Color.White;
            lb_BusquedaCategoria.FormattingEnabled = true;
            lb_BusquedaCategoria.ItemHeight = 15;
            lb_BusquedaCategoria.Location = new Point(126, 96);
            lb_BusquedaCategoria.Name = "lb_BusquedaCategoria";
            lb_BusquedaCategoria.Size = new Size(113, 19);
            lb_BusquedaCategoria.TabIndex = 2;
            // 
            // lb_RangoPrecio1
            // 
            lb_RangoPrecio1.BackColor = Color.White;
            lb_RangoPrecio1.FormattingEnabled = true;
            lb_RangoPrecio1.ItemHeight = 15;
            lb_RangoPrecio1.Location = new Point(245, 96);
            lb_RangoPrecio1.Name = "lb_RangoPrecio1";
            lb_RangoPrecio1.Size = new Size(70, 19);
            lb_RangoPrecio1.TabIndex = 3;
            // 
            // lb_RangoPrecio2
            // 
            lb_RangoPrecio2.BackColor = Color.White;
            lb_RangoPrecio2.FormattingEnabled = true;
            lb_RangoPrecio2.ItemHeight = 15;
            lb_RangoPrecio2.Location = new Point(321, 96);
            lb_RangoPrecio2.Name = "lb_RangoPrecio2";
            lb_RangoPrecio2.Size = new Size(70, 19);
            lb_RangoPrecio2.TabIndex = 4;
            // 
            // lb_BusquedaNombre
            // 
            lb_BusquedaNombre.BackColor = Color.White;
            lb_BusquedaNombre.FormattingEnabled = true;
            lb_BusquedaNombre.ItemHeight = 15;
            lb_BusquedaNombre.Location = new Point(397, 96);
            lb_BusquedaNombre.Name = "lb_BusquedaNombre";
            lb_BusquedaNombre.Size = new Size(113, 19);
            lb_BusquedaNombre.TabIndex = 6;
            // 
            // lbl_MarcaBusqueda
            // 
            lbl_MarcaBusqueda.AutoSize = true;
            lbl_MarcaBusqueda.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            lbl_MarcaBusqueda.Location = new Point(14, 75);
            lbl_MarcaBusqueda.Name = "lbl_MarcaBusqueda";
            lbl_MarcaBusqueda.Size = new Size(60, 16);
            lbl_MarcaBusqueda.TabIndex = 7;
            lbl_MarcaBusqueda.Text = "MARCA:";
            // 
            // lbl_CategoriaBusqueda
            // 
            lbl_CategoriaBusqueda.AutoSize = true;
            lbl_CategoriaBusqueda.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            lbl_CategoriaBusqueda.Location = new Point(126, 75);
            lbl_CategoriaBusqueda.Name = "lbl_CategoriaBusqueda";
            lbl_CategoriaBusqueda.Size = new Size(85, 16);
            lbl_CategoriaBusqueda.TabIndex = 8;
            lbl_CategoriaBusqueda.Text = "CATEGORIA:";
            // 
            // lbl_RangoPrecioBusqueda
            // 
            lbl_RangoPrecioBusqueda.AutoSize = true;
            lbl_RangoPrecioBusqueda.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            lbl_RangoPrecioBusqueda.Location = new Point(259, 75);
            lbl_RangoPrecioBusqueda.Name = "lbl_RangoPrecioBusqueda";
            lbl_RangoPrecioBusqueda.Size = new Size(126, 16);
            lbl_RangoPrecioBusqueda.TabIndex = 10;
            lbl_RangoPrecioBusqueda.Text = "RANGO DE PRECIO:";
            // 
            // lbl_NombreBusqueda
            // 
            lbl_NombreBusqueda.AutoSize = true;
            lbl_NombreBusqueda.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            lbl_NombreBusqueda.Location = new Point(397, 75);
            lbl_NombreBusqueda.Name = "lbl_NombreBusqueda";
            lbl_NombreBusqueda.Size = new Size(64, 16);
            lbl_NombreBusqueda.TabIndex = 11;
            lbl_NombreBusqueda.Text = "NOMBRE:";
            // 
            // lbl_TituloBusqueda
            // 
            lbl_TituloBusqueda.AutoSize = true;
            lbl_TituloBusqueda.BackColor = Color.White;
            lbl_TituloBusqueda.BorderStyle = BorderStyle.Fixed3D;
            lbl_TituloBusqueda.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_TituloBusqueda.Location = new Point(12, 23);
            lbl_TituloBusqueda.Name = "lbl_TituloBusqueda";
            lbl_TituloBusqueda.Size = new Size(233, 31);
            lbl_TituloBusqueda.TabIndex = 12;
            lbl_TituloBusqueda.Text = "Busqueda por Filtros";
            // 
            // wf_Busqueda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(526, 498);
            Controls.Add(lbl_TituloBusqueda);
            Controls.Add(lbl_NombreBusqueda);
            Controls.Add(lbl_RangoPrecioBusqueda);
            Controls.Add(lbl_CategoriaBusqueda);
            Controls.Add(lbl_MarcaBusqueda);
            Controls.Add(lb_BusquedaNombre);
            Controls.Add(lb_RangoPrecio2);
            Controls.Add(lb_RangoPrecio1);
            Controls.Add(lb_BusquedaCategoria);
            Controls.Add(lb_BusquedaMarca);
            Controls.Add(lv_Busqueda);
            MaximizeBox = false;
            MaximumSize = new Size(542, 537);
            Name = "wf_Busqueda";
            StartPosition = FormStartPosition.CenterParent;
            Text = "wf_Busqueda";
            Load += wf_Busqueda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv_Busqueda;
        private ListBox lb_BusquedaMarca;
        private ListBox lb_BusquedaCategoria;
        private ListBox lb_RangoPrecio1;
        private ListBox lb_RangoPrecio2;
        private ListBox lb_BusquedaNombre;
        private Label lbl_MarcaBusqueda;
        private Label lbl_CategoriaBusqueda;
        private Label lbl_RangoPrecioBusqueda;
        private Label lbl_NombreBusqueda;
        private Label lbl_TituloBusqueda;
    }
}