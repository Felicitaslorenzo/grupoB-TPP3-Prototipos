namespace grupoB_TPP3_Prototipos.ListarOrdenSeleccion
{
    partial class ListarOrdenSeleccionForm
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
            IdOrdenSeleccionCombo = new ComboBox();
            FechaOSPicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            BuscarButton = new Button();
            ListarOrdenSeleccionList = new ListView();
            IdOrdenSeleccionColumna = new ColumnHeader();
            FechaOSColumna = new ColumnHeader();
            DescripcionProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            UbicacionColumna = new ColumnHeader();
            EstadoColumna = new ColumnHeader();
            VolverListaButton = new Button();
            SuspendLayout();
            // 
            // IdOrdenSeleccionCombo
            // 
            IdOrdenSeleccionCombo.FormattingEnabled = true;
            IdOrdenSeleccionCombo.Location = new Point(29, 58);
            IdOrdenSeleccionCombo.Margin = new Padding(4, 4, 4, 4);
            IdOrdenSeleccionCombo.Name = "IdOrdenSeleccionCombo";
            IdOrdenSeleccionCombo.Size = new Size(312, 33);
            IdOrdenSeleccionCombo.TabIndex = 0;
            // 
            // FechaOSPicker
            // 
            FechaOSPicker.Location = new Point(414, 59);
            FechaOSPicker.Margin = new Padding(4, 4, 4, 4);
            FechaOSPicker.Name = "FechaOSPicker";
            FechaOSPicker.Size = new Size(363, 31);
            FechaOSPicker.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 2;
            label1.Text = "ID Orden Selección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 30);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 3;
            label2.Text = "Fecha";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(763, 131);
            BuscarButton.Margin = new Padding(2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(160, 38);
            BuscarButton.TabIndex = 15;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // ListarOrdenSeleccionList
            // 
            ListarOrdenSeleccionList.Columns.AddRange(new ColumnHeader[] { IdOrdenSeleccionColumna, FechaOSColumna, DescripcionProductoColumna, CantidadColumna, UbicacionColumna, EstadoColumna });
            ListarOrdenSeleccionList.Location = new Point(29, 205);
            ListarOrdenSeleccionList.Margin = new Padding(4, 4, 4, 4);
            ListarOrdenSeleccionList.Name = "ListarOrdenSeleccionList";
            ListarOrdenSeleccionList.Size = new Size(918, 243);
            ListarOrdenSeleccionList.TabIndex = 16;
            ListarOrdenSeleccionList.UseCompatibleStateImageBehavior = false;
            ListarOrdenSeleccionList.View = View.Details;
            // 
            // IdOrdenSeleccionColumna
            // 
            IdOrdenSeleccionColumna.Text = "ID Orden Seleccion";
            IdOrdenSeleccionColumna.Width = 150;
            // 
            // FechaOSColumna
            // 
            FechaOSColumna.Text = "Fecha";
            FechaOSColumna.Width = 100;
            // 
            // DescripcionProductoColumna
            // 
            DescripcionProductoColumna.Text = "Descripción Producto";
            DescripcionProductoColumna.Width = 180;
            // 
            // CantidadColumna
            // 
            CantidadColumna.Text = "Cantidad";
            CantidadColumna.Width = 100;
            // 
            // UbicacionColumna
            // 
            UbicacionColumna.Text = "Ubicación";
            UbicacionColumna.Width = 100;
            // 
            // EstadoColumna
            // 
            EstadoColumna.Text = "Estado";
            EstadoColumna.Width = 100;
            // 
            // VolverListaButton
            // 
            VolverListaButton.Location = new Point(776, 466);
            VolverListaButton.Margin = new Padding(2);
            VolverListaButton.Name = "VolverListaButton";
            VolverListaButton.Size = new Size(160, 38);
            VolverListaButton.TabIndex = 18;
            VolverListaButton.Text = "Volver";
            VolverListaButton.UseVisualStyleBackColor = true;
            // 
            // ListarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 532);
            Controls.Add(VolverListaButton);
            Controls.Add(ListarOrdenSeleccionList);
            Controls.Add(BuscarButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FechaOSPicker);
            Controls.Add(IdOrdenSeleccionCombo);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ListarOrdenSeleccionForm";
            Text = "ListarOrdenSeleccionForm";
            Load += ListarOrdenSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox IdOrdenSeleccionCombo;
        private DateTimePicker FechaOSPicker;
        private Label label1;
        private Label label2;
        private Button BuscarButton;
        private ListView ListarOrdenSeleccionList;
        private ColumnHeader IdOrdenSeleccionColumna;
        private ColumnHeader FechaOSColumna;
        private ColumnHeader DescripcionProductoColumna;
        private ColumnHeader CantidadColumna;
        private ColumnHeader UbicacionColumna;
        private Button VolverListaButton;
        private ColumnHeader EstadoColumna;
    }
}