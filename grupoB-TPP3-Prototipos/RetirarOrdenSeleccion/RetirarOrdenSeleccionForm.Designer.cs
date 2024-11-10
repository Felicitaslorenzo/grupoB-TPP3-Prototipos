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
            label2.Location = new Point(11, 65);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Productos de orden";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { UbicacionColumna, ProductoColumna, CantidadColumna });
            listView1.Location = new Point(11, 82);
            listView1.Margin = new Padding(2, 2, 2, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(796, 145);
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
            ConfirmarButton.Location = new Point(609, 231);
            ConfirmarButton.Margin = new Padding(2, 2, 2, 2);
            ConfirmarButton.Name = "ConfirmarButton";
            ConfirmarButton.Size = new Size(90, 27);
            ConfirmarButton.TabIndex = 5;
            ConfirmarButton.Text = "Confirmar";
            ConfirmarButton.UseVisualStyleBackColor = true;
            ConfirmarButton.Click += ConfirmarButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(717, 231);
            CancelarButton.Margin = new Padding(2, 2, 2, 2);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(90, 27);
            CancelarButton.TabIndex = 6;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 11);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 7;
            label3.Text = "Orden de Selección";
            // 
            // OrdenSCombo
            // 
            OrdenSCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            OrdenSCombo.FormattingEnabled = true;
            OrdenSCombo.Location = new Point(10, 27);
            OrdenSCombo.Margin = new Padding(1);
            OrdenSCombo.Name = "OrdenSCombo";
            OrdenSCombo.Size = new Size(798, 23);
            OrdenSCombo.TabIndex = 15;
            OrdenSCombo.SelectedIndexChanged += OrdenSCombo_SelectedIndexChanged;
            // 
            // RetirarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 279);
            Controls.Add(OrdenSCombo);
            Controls.Add(label3);
            Controls.Add(CancelarButton);
            Controls.Add(ConfirmarButton);
            Controls.Add(listView1);
            Controls.Add(label2);
            Margin = new Padding(2, 2, 2, 2);
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