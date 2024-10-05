namespace grupoB_TPP3_Prototipos.GenerarOrdenSelección
{
    partial class GenerarOrdenSeleccionForm
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
            GenerarOrdenButton = new Button();
            OrdenSeleccionList = new ListView();
            IdOrdenSeleccion2Columna = new ColumnHeader();
            FechaOS2Columna = new ColumnHeader();
            DescripcionProducto2Columna = new ColumnHeader();
            Cantidad2Columna = new ColumnHeader();
            Ubicacion2Columna = new ColumnHeader();
            Estado2Columna = new ColumnHeader();
            OrdenSeleccionBuscarList = new ListView();
            IdOrdenSeleccionColumna = new ColumnHeader();
            FechaOSColumna = new ColumnHeader();
            DescripcionProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            UbicacionColumna = new ColumnHeader();
            BuscarButton = new Button();
            VolverButton = new Button();
            label2 = new Label();
            label1 = new Label();
            FechaOSPicker = new DateTimePicker();
            IdOrdenSeleccionCombo = new ComboBox();
            label3 = new Label();
            PrioridadCombo = new ComboBox();
            label4 = new Label();
            DescripcionClienteCombo = new ComboBox();
            label5 = new Label();
            EstadoCombo = new ComboBox();
            EstadoColumna = new ColumnHeader();
            SuspendLayout();
            // 
            // GenerarOrdenButton
            // 
            GenerarOrdenButton.Location = new Point(682, 657);
            GenerarOrdenButton.Margin = new Padding(2);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(194, 30);
            GenerarOrdenButton.TabIndex = 27;
            GenerarOrdenButton.Text = "Generar Orden";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            // 
            // OrdenSeleccionList
            // 
            OrdenSeleccionList.Columns.AddRange(new ColumnHeader[] { IdOrdenSeleccion2Columna, FechaOS2Columna, DescripcionProducto2Columna, Cantidad2Columna, Ubicacion2Columna, Estado2Columna });
            OrdenSeleccionList.Location = new Point(29, 446);
            OrdenSeleccionList.Name = "OrdenSeleccionList";
            OrdenSeleccionList.Size = new Size(847, 195);
            OrdenSeleccionList.TabIndex = 26;
            OrdenSeleccionList.UseCompatibleStateImageBehavior = false;
            OrdenSeleccionList.View = View.Details;
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
            // OrdenSeleccionBuscarList
            // 
            OrdenSeleccionBuscarList.Columns.AddRange(new ColumnHeader[] { IdOrdenSeleccionColumna, FechaOSColumna, DescripcionProductoColumna, CantidadColumna, UbicacionColumna, EstadoColumna });
            OrdenSeleccionBuscarList.Location = new Point(29, 222);
            OrdenSeleccionBuscarList.Name = "OrdenSeleccionBuscarList";
            OrdenSeleccionBuscarList.Size = new Size(847, 195);
            OrdenSeleccionBuscarList.TabIndex = 25;
            OrdenSeleccionBuscarList.UseCompatibleStateImageBehavior = false;
            OrdenSeleccionBuscarList.View = View.Details;
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
            // BuscarButton
            // 
            BuscarButton.Location = new Point(558, 163);
            BuscarButton.Margin = new Padding(2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(128, 30);
            BuscarButton.TabIndex = 24;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(748, 163);
            VolverButton.Margin = new Padding(2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(128, 30);
            VolverButton.TabIndex = 23;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 14);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 22;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 12);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 21;
            label1.Text = "ID Orden Preparación";
            // 
            // FechaOSPicker
            // 
            FechaOSPicker.Location = new Point(327, 37);
            FechaOSPicker.Name = "FechaOSPicker";
            FechaOSPicker.Size = new Size(250, 27);
            FechaOSPicker.TabIndex = 20;
            // 
            // IdOrdenSeleccionCombo
            // 
            IdOrdenSeleccionCombo.FormattingEnabled = true;
            IdOrdenSeleccionCombo.Location = new Point(29, 36);
            IdOrdenSeleccionCombo.Name = "IdOrdenSeleccionCombo";
            IdOrdenSeleccionCombo.Size = new Size(250, 28);
            IdOrdenSeleccionCombo.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(626, 15);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 29;
            label3.Text = "Prioridad";
            // 
            // PrioridadCombo
            // 
            PrioridadCombo.FormattingEnabled = true;
            PrioridadCombo.Location = new Point(626, 39);
            PrioridadCombo.Name = "PrioridadCombo";
            PrioridadCombo.Size = new Size(250, 28);
            PrioridadCombo.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 81);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 31;
            label4.Text = "Descripción Cliente";
            // 
            // DescripcionClienteCombo
            // 
            DescripcionClienteCombo.FormattingEnabled = true;
            DescripcionClienteCombo.Location = new Point(327, 105);
            DescripcionClienteCombo.Name = "DescripcionClienteCombo";
            DescripcionClienteCombo.Size = new Size(250, 28);
            DescripcionClienteCombo.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 81);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 33;
            label5.Text = "Estado";
            // 
            // EstadoCombo
            // 
            EstadoCombo.FormattingEnabled = true;
            EstadoCombo.Location = new Point(29, 105);
            EstadoCombo.Name = "EstadoCombo";
            EstadoCombo.Size = new Size(250, 28);
            EstadoCombo.TabIndex = 32;
            // 
            // EstadoColumna
            // 
            EstadoColumna.Text = "Estado";
            EstadoColumna.Width = 100;
            // 
            // GenerarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 698);
            Controls.Add(label5);
            Controls.Add(EstadoCombo);
            Controls.Add(label4);
            Controls.Add(DescripcionClienteCombo);
            Controls.Add(label3);
            Controls.Add(PrioridadCombo);
            Controls.Add(GenerarOrdenButton);
            Controls.Add(OrdenSeleccionList);
            Controls.Add(OrdenSeleccionBuscarList);
            Controls.Add(BuscarButton);
            Controls.Add(VolverButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FechaOSPicker);
            Controls.Add(IdOrdenSeleccionCombo);
            Name = "GenerarOrdenSeleccionForm";
            Text = "GenerarOrdenSeleccionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenerarOrdenButton;
        private ListView OrdenSeleccionList;
        private ColumnHeader IdOrdenSeleccion2Columna;
        private ColumnHeader FechaOS2Columna;
        private ColumnHeader DescripcionProducto2Columna;
        private ColumnHeader Cantidad2Columna;
        private ColumnHeader Ubicacion2Columna;
        private ColumnHeader Estado2Columna;
        private ListView OrdenSeleccionBuscarList;
        private ColumnHeader IdOrdenSeleccionColumna;
        private ColumnHeader FechaOSColumna;
        private ColumnHeader DescripcionProductoColumna;
        private ColumnHeader CantidadColumna;
        private ColumnHeader UbicacionColumna;
        private Button BuscarButton;
        private Button VolverButton;
        private Label label2;
        private Label label1;
        private DateTimePicker FechaOSPicker;
        private ComboBox IdOrdenSeleccionCombo;
        private Label label3;
        private ComboBox PrioridadCombo;
        private Label label4;
        private ComboBox DescripcionClienteCombo;
        private Label label5;
        private ComboBox EstadoCombo;
        private ColumnHeader EstadoColumna;
    }
}