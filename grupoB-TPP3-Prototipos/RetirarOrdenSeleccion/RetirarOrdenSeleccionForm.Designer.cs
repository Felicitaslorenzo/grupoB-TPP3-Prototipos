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
            ProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            ConfirmarButton = new Button();
            CancelarButton = new Button();
            label3 = new Label();
            OrdenSCombo = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 87);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 1;
            label2.Text = "Productos de orden";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { UbicacionColumna, ProductoColumna, CantidadColumna });
            listView1.Location = new Point(13, 109);
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
            UbicacionColumna.Width = 100;
            // 
            // ProductoColumna
            // 
            ProductoColumna.Text = "Producto";
            ProductoColumna.Width = 100;
            // 
            // CantidadColumna
            // 
            CantidadColumna.Text = "Cantidad";
            CantidadColumna.Width = 100;
            // 
            // ConfirmarButton
            // 
            ConfirmarButton.Location = new Point(696, 308);
            ConfirmarButton.Margin = new Padding(2, 3, 2, 3);
            ConfirmarButton.Name = "ConfirmarButton";
            ConfirmarButton.Size = new Size(103, 36);
            ConfirmarButton.TabIndex = 5;
            ConfirmarButton.Text = "Confirmar";
            ConfirmarButton.UseVisualStyleBackColor = true;
            ConfirmarButton.Click += ConfirmarButton_Click_1;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(819, 308);
            CancelarButton.Margin = new Padding(2, 3, 2, 3);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(103, 36);
            CancelarButton.TabIndex = 6;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 15);
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
            OrdenSCombo.Location = new Point(11, 36);
            OrdenSCombo.Margin = new Padding(1);
            OrdenSCombo.Name = "OrdenSCombo";
            OrdenSCombo.Size = new Size(911, 28);
            OrdenSCombo.TabIndex = 15;
            OrdenSCombo.SelectedIndexChanged += OrdenSCombo_SelectedIndexChanged;
            // 
            // RetirarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 372);
            Controls.Add(OrdenSCombo);
            Controls.Add(label3);
            Controls.Add(CancelarButton);
            Controls.Add(ConfirmarButton);
            Controls.Add(listView1);
            Controls.Add(label2);
            Margin = new Padding(2, 3, 2, 3);
            Name = "RetirarOrdenSeleccionForm";
            Text = "PrepararOrdenSeleccionForm";
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
    }
}