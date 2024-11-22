namespace grupoB_TPP3_Prototipos.PrepararOrdenSeleccion
{
    partial class RetirarOrdenSeleccionForm
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
            label2 = new Label();
            listView1 = new ListView();
            UbicacionColumna = new ColumnHeader();
            SKUColumna = new ColumnHeader();
            ProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            ConfirmarButton = new Button();
            CancelarButton = new Button();
            label3 = new Label();
            OrdenSCombo = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 139);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 1;
            label2.Text = "Productos de orden";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { UbicacionColumna, SKUColumna, ProductoColumna, CantidadColumna });
            listView1.Location = new Point(24, 161);
            listView1.Margin = new Padding(2, 3, 2, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(909, 192);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // UbicacionColumna
            // 
            UbicacionColumna.Text = "Ubicación";
            UbicacionColumna.Width = 140;
            // 
            // SKUColumna
            // 
            SKUColumna.Text = "SKU Producto";
            SKUColumna.Width = 120;
            // 
            // ProductoColumna
            // 
            ProductoColumna.Text = "Descripcion Producto";
            ProductoColumna.Width = 500;
            // 
            // CantidadColumna
            // 
            CantidadColumna.Text = "Cantidad";
            CantidadColumna.Width = 120;
            // 
            // ConfirmarButton
            // 
            ConfirmarButton.Location = new Point(626, 381);
            ConfirmarButton.Margin = new Padding(2, 3, 2, 3);
            ConfirmarButton.Name = "ConfirmarButton";
            ConfirmarButton.Size = new Size(129, 41);
            ConfirmarButton.TabIndex = 5;
            ConfirmarButton.Text = "Confirmar";
            ConfirmarButton.UseVisualStyleBackColor = true;
            ConfirmarButton.Click += ConfirmarButton_Click_1;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(804, 381);
            CancelarButton.Margin = new Padding(2, 3, 2, 3);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(129, 41);
            CancelarButton.TabIndex = 6;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 67);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 7;
            label3.Text = "Orden de Selección";
            // 
            // OrdenSCombo
            // 
            OrdenSCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            OrdenSCombo.FormattingEnabled = true;
            OrdenSCombo.Location = new Point(22, 88);
            OrdenSCombo.Margin = new Padding(1);
            OrdenSCombo.Name = "OrdenSCombo";
            OrdenSCombo.Size = new Size(911, 28);
            OrdenSCombo.TabIndex = 15;
            OrdenSCombo.SelectedIndexChanged += OrdenSCombo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 18);
            label1.Name = "label1";
            label1.Size = new Size(338, 34);
            label1.TabIndex = 23;
            label1.Text = "Retirar Orden Selección\r\n";
            // 
            // RetirarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 447);
            Controls.Add(label1);
            Controls.Add(OrdenSCombo);
            Controls.Add(label3);
            Controls.Add(CancelarButton);
            Controls.Add(ConfirmarButton);
            Controls.Add(listView1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            Name = "RetirarOrdenSeleccionForm";
            Load += RetirarOrdenSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ListView listView1;
        private ColumnHeader ProductoColumna;
        private ColumnHeader CantidadColumna;
        private ColumnHeader UbicacionColumna;
        private Button ConfirmarButton;
        private Button CancelarButton;
        private Label label3;
        private ComboBox OrdenSCombo;
        private ColumnHeader SKUColumna;
        private Label label1;
    }
}