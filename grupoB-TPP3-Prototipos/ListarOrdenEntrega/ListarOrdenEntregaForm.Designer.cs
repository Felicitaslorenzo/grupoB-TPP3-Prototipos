namespace grupoB_TPP3_Prototipos.ListarOrdenEntrega
{
    partial class ListarOrdenEntregaForm
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
            label5 = new Label();
            EstadoCombo = new ComboBox();
            label4 = new Label();
            IdClienteCombo = new ComboBox();
            label3 = new Label();
            PrioridadCombo = new ComboBox();
            ListarOrdenEntregaBuscarList = new ListView();
            IdOrdenSeleccion2Columna = new ColumnHeader();
            FechaOS2Columna = new ColumnHeader();
            DescripcionProducto2Columna = new ColumnHeader();
            Cantidad2Columna = new ColumnHeader();
            Ubicacion2Columna = new ColumnHeader();
            Estado2Columna = new ColumnHeader();
            ListarOrdenEntregaList = new ListView();
            IdOrdenSeleccionColumna = new ColumnHeader();
            FechaOSColumna = new ColumnHeader();
            DescripcionProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            UbicacionColumna = new ColumnHeader();
            EstadoColumna = new ColumnHeader();
            BuscarButton = new Button();
            VolverButton = new Button();
            label2 = new Label();
            label1 = new Label();
            FechaOSPicker = new DateTimePicker();
            IdOrdenCombo = new ComboBox();
            label6 = new Label();
            UbicacionCombo = new ComboBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 96);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 48;
            label5.Text = "Estado";
            // 
            // EstadoCombo
            // 
            EstadoCombo.FormattingEnabled = true;
            EstadoCombo.Location = new Point(324, 119);
            EstadoCombo.Name = "EstadoCombo";
            EstadoCombo.Size = new Size(216, 28);
            EstadoCombo.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 96);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 46;
            label4.Text = "ID Cliente";
            // 
            // IdClienteCombo
            // 
            IdClienteCombo.FormattingEnabled = true;
            IdClienteCombo.Location = new Point(26, 119);
            IdClienteCombo.Name = "IdClienteCombo";
            IdClienteCombo.Size = new Size(250, 28);
            IdClienteCombo.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(657, 28);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 44;
            label3.Text = "Prioridad";
            // 
            // PrioridadCombo
            // 
            PrioridadCombo.FormattingEnabled = true;
            PrioridadCombo.Location = new Point(657, 53);
            PrioridadCombo.Name = "PrioridadCombo";
            PrioridadCombo.Size = new Size(216, 28);
            PrioridadCombo.TabIndex = 43;
            // 
            // ListarOrdenEntregaBuscarList
            // 
            ListarOrdenEntregaBuscarList.Columns.AddRange(new ColumnHeader[] { IdOrdenSeleccion2Columna, FechaOS2Columna, DescripcionProducto2Columna, Cantidad2Columna, Ubicacion2Columna, Estado2Columna });
            ListarOrdenEntregaBuscarList.Location = new Point(26, 171);
            ListarOrdenEntregaBuscarList.Name = "ListarOrdenEntregaBuscarList";
            ListarOrdenEntregaBuscarList.Size = new Size(847, 195);
            ListarOrdenEntregaBuscarList.TabIndex = 41;
            ListarOrdenEntregaBuscarList.UseCompatibleStateImageBehavior = false;
            ListarOrdenEntregaBuscarList.View = View.Details;
            // 
            // IdOrdenSeleccion2Columna
            // 
            IdOrdenSeleccion2Columna.Text = "ID Orden Seleccion";
            IdOrdenSeleccion2Columna.Width = 150;
            // 
            // FechaOS2Columna
            // 
            FechaOS2Columna.Text = "Fecha";
            FechaOS2Columna.Width = 100;
            // 
            // DescripcionProducto2Columna
            // 
            DescripcionProducto2Columna.Text = "Descripción Producto";
            DescripcionProducto2Columna.Width = 180;
            // 
            // Cantidad2Columna
            // 
            Cantidad2Columna.Text = "Cantidad";
            Cantidad2Columna.Width = 100;
            // 
            // Ubicacion2Columna
            // 
            Ubicacion2Columna.Text = "Ubicación";
            Ubicacion2Columna.Width = 100;
            // 
            // Estado2Columna
            // 
            Estado2Columna.Text = "Estado";
            Estado2Columna.Width = 100;
            // 
            // ListarOrdenEntregaList
            // 
            ListarOrdenEntregaList.Columns.AddRange(new ColumnHeader[] { IdOrdenSeleccionColumna, FechaOSColumna, DescripcionProductoColumna, CantidadColumna, UbicacionColumna, EstadoColumna });
            ListarOrdenEntregaList.Location = new Point(26, 442);
            ListarOrdenEntregaList.Name = "ListarOrdenEntregaList";
            ListarOrdenEntregaList.Size = new Size(847, 195);
            ListarOrdenEntregaList.TabIndex = 40;
            ListarOrdenEntregaList.UseCompatibleStateImageBehavior = false;
            ListarOrdenEntregaList.View = View.Details;
            ListarOrdenEntregaList.SelectedIndexChanged += GenerarOrdenSeleccionBuscarList_SelectedIndexChanged;
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
            // BuscarButton
            // 
            BuscarButton.Location = new Point(555, 388);
            BuscarButton.Margin = new Padding(2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(128, 30);
            BuscarButton.TabIndex = 39;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(745, 388);
            VolverButton.Margin = new Padding(2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(128, 30);
            VolverButton.TabIndex = 38;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 28);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 37;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 36;
            label1.Text = "ID Orden";
            // 
            // FechaOSPicker
            // 
            FechaOSPicker.Location = new Point(324, 51);
            FechaOSPicker.Name = "FechaOSPicker";
            FechaOSPicker.Size = new Size(293, 27);
            FechaOSPicker.TabIndex = 35;
            // 
            // IdOrdenCombo
            // 
            IdOrdenCombo.FormattingEnabled = true;
            IdOrdenCombo.Location = new Point(26, 50);
            IdOrdenCombo.Name = "IdOrdenCombo";
            IdOrdenCombo.Size = new Size(250, 28);
            IdOrdenCombo.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(584, 94);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 50;
            label6.Text = "Ubicación";
            // 
            // UbicacionCombo
            // 
            UbicacionCombo.FormattingEnabled = true;
            UbicacionCombo.Location = new Point(584, 119);
            UbicacionCombo.Name = "UbicacionCombo";
            UbicacionCombo.Size = new Size(216, 28);
            UbicacionCombo.TabIndex = 49;
            // 
            // ListarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 655);
            Controls.Add(label6);
            Controls.Add(UbicacionCombo);
            Controls.Add(label5);
            Controls.Add(EstadoCombo);
            Controls.Add(label4);
            Controls.Add(IdClienteCombo);
            Controls.Add(label3);
            Controls.Add(PrioridadCombo);
            Controls.Add(ListarOrdenEntregaBuscarList);
            Controls.Add(ListarOrdenEntregaList);
            Controls.Add(BuscarButton);
            Controls.Add(VolverButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FechaOSPicker);
            Controls.Add(IdOrdenCombo);
            Name = "ListarOrdenEntregaForm";
            Text = "ListarOrdenEntregaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private ComboBox EstadoCombo;
        private Label label4;
        private ComboBox IdClienteCombo;
        private Label label3;
        private ComboBox PrioridadCombo;
        private ListView ListarOrdenEntregaBuscarList;
        private ColumnHeader IdOrdenSeleccion2Columna;
        private ColumnHeader FechaOS2Columna;
        private ColumnHeader DescripcionProducto2Columna;
        private ColumnHeader Cantidad2Columna;
        private ColumnHeader Ubicacion2Columna;
        private ColumnHeader Estado2Columna;
        private ListView ListarOrdenEntregaList;
        private ColumnHeader IdOrdenSeleccionColumna;
        private ColumnHeader FechaOSColumna;
        private ColumnHeader DescripcionProductoColumna;
        private ColumnHeader CantidadColumna;
        private ColumnHeader UbicacionColumna;
        private ColumnHeader EstadoColumna;
        private Button BuscarButton;
        private Button VolverButton;
        private Label label2;
        private Label label1;
        private DateTimePicker FechaOSPicker;
        private ComboBox IdOrdenCombo;
        private Label label6;
        private ComboBox UbicacionCombo;
    }
}