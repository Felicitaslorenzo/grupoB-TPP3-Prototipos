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
            GenerarOrdenSeleccionBuscarList = new ListView();
            IdOrdenPreparacionColumna = new ColumnHeader();
            ClienteOSColumna = new ColumnHeader();
            FechaOPColumna = new ColumnHeader();
            BuscarButton = new Button();
            VolverButton = new Button();
            FechaDesdeLabel = new Label();
            label1 = new Label();
            FechaOSDesdePicker = new DateTimePicker();
            IdOrdenPreparacionCombo = new ComboBox();
            label3 = new Label();
            PrioridadCombo = new ComboBox();
            label4 = new Label();
            DescripcionClienteCombo = new ComboBox();
            GenerarOrdenButton = new Button();
            FechaHastaLabel = new Label();
            FechaOSHastaPicker = new DateTimePicker();
            AgregarSeleccionadaOSButton = new Button();
            DetalleOSList = new ListView();
            ProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            UbicacionOSColumna = new ColumnHeader();
            DetalleOSLabel = new Label();
            QuitarSeleccionadasOSButton = new Button();
            TotalesOSSeleccionadasLabel = new Label();
            TotalesOSSeleccionadasList = new ListView();
            ProductoOrdenSeleccionadaColumna = new ColumnHeader();
            CantidadOrdenSeleccionadaColumna = new ColumnHeader();
            UbicacionOrdenSeleccionadaColumna = new ColumnHeader();
            GenerarOSSeleccionadasList = new ListView();
            IdOPSeleccionadaColumna = new ColumnHeader();
            ClienteSeleccionadoColumna = new ColumnHeader();
            FechaOPSeleccionadaColumna = new ColumnHeader();
            SuspendLayout();
            // 
            // GenerarOrdenSeleccionBuscarList
            // 
            GenerarOrdenSeleccionBuscarList.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionColumna, ClienteOSColumna, FechaOPColumna });
            GenerarOrdenSeleccionBuscarList.Location = new Point(25, 148);
            GenerarOrdenSeleccionBuscarList.Margin = new Padding(3, 2, 3, 2);
            GenerarOrdenSeleccionBuscarList.Name = "GenerarOrdenSeleccionBuscarList";
            GenerarOrdenSeleccionBuscarList.Size = new Size(409, 147);
            GenerarOrdenSeleccionBuscarList.TabIndex = 25;
            GenerarOrdenSeleccionBuscarList.UseCompatibleStateImageBehavior = false;
            GenerarOrdenSeleccionBuscarList.View = View.Details;
            // 
            // IdOrdenPreparacionColumna
            // 
            IdOrdenPreparacionColumna.Text = "ID Orden Preparación";
            IdOrdenPreparacionColumna.Width = 200;
            // 
            // ClienteOSColumna
            // 
            ClienteOSColumna.Text = "Descripcion Cliente";
            ClienteOSColumna.Width = 180;
            // 
            // FechaOPColumna
            // 
            FechaOPColumna.Text = "Fecha";
            FechaOPColumna.Width = 100;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(286, 76);
            BuscarButton.Margin = new Padding(1);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(480, 23);
            BuscarButton.TabIndex = 24;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(652, 556);
            VolverButton.Margin = new Padding(1);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(112, 23);
            VolverButton.TabIndex = 23;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // FechaDesdeLabel
            // 
            FechaDesdeLabel.AutoSize = true;
            FechaDesdeLabel.Location = new Point(286, 10);
            FechaDesdeLabel.Name = "FechaDesdeLabel";
            FechaDesdeLabel.Size = new Size(73, 15);
            FechaDesdeLabel.TabIndex = 22;
            FechaDesdeLabel.Text = "Fecha Desde";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 21;
            label1.Text = "ID Orden Preparación";
            // 
            // FechaOSDesdePicker
            // 
            FechaOSDesdePicker.Location = new Point(286, 27);
            FechaOSDesdePicker.Margin = new Padding(3, 2, 3, 2);
            FechaOSDesdePicker.Name = "FechaOSDesdePicker";
            FechaOSDesdePicker.Size = new Size(126, 23);
            FechaOSDesdePicker.TabIndex = 20;
            // 
            // IdOrdenPreparacionCombo
            // 
            IdOrdenPreparacionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdOrdenPreparacionCombo.FormattingEnabled = true;
            IdOrdenPreparacionCombo.Location = new Point(25, 27);
            IdOrdenPreparacionCombo.Margin = new Padding(3, 2, 3, 2);
            IdOrdenPreparacionCombo.Name = "IdOrdenPreparacionCombo";
            IdOrdenPreparacionCombo.Size = new Size(220, 23);
            IdOrdenPreparacionCombo.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(589, 12);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 29;
            label3.Text = "Prioridad";
            // 
            // PrioridadCombo
            // 
            PrioridadCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            PrioridadCombo.FormattingEnabled = true;
            PrioridadCombo.Items.AddRange(new object[] { "Con prioridad de entrega", "Sin prioridad" });
            PrioridadCombo.Location = new Point(589, 29);
            PrioridadCombo.Margin = new Padding(3, 2, 3, 2);
            PrioridadCombo.Name = "PrioridadCombo";
            PrioridadCombo.Size = new Size(178, 23);
            PrioridadCombo.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 63);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 31;
            label4.Text = "Cliente";
            // 
            // DescripcionClienteCombo
            // 
            DescripcionClienteCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            DescripcionClienteCombo.FormattingEnabled = true;
            DescripcionClienteCombo.Location = new Point(25, 81);
            DescripcionClienteCombo.Margin = new Padding(3, 2, 3, 2);
            DescripcionClienteCombo.Name = "DescripcionClienteCombo";
            DescripcionClienteCombo.Size = new Size(220, 23);
            DescripcionClienteCombo.TabIndex = 30;
            // 
            // GenerarOrdenButton
            // 
            GenerarOrdenButton.Location = new Point(470, 556);
            GenerarOrdenButton.Margin = new Padding(1);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(169, 23);
            GenerarOrdenButton.TabIndex = 43;
            GenerarOrdenButton.Text = "Generar Orden";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            // 
            // FechaHastaLabel
            // 
            FechaHastaLabel.AutoSize = true;
            FechaHastaLabel.Location = new Point(433, 10);
            FechaHastaLabel.Name = "FechaHastaLabel";
            FechaHastaLabel.Size = new Size(71, 15);
            FechaHastaLabel.TabIndex = 45;
            FechaHastaLabel.Text = "Fecha Hasta";
            // 
            // FechaOSHastaPicker
            // 
            FechaOSHastaPicker.Location = new Point(433, 28);
            FechaOSHastaPicker.Margin = new Padding(3, 2, 3, 2);
            FechaOSHastaPicker.Name = "FechaOSHastaPicker";
            FechaOSHastaPicker.Size = new Size(126, 23);
            FechaOSHastaPicker.TabIndex = 44;
            // 
            // AgregarSeleccionadaOSButton
            // 
            AgregarSeleccionadaOSButton.Location = new Point(603, 297);
            AgregarSeleccionadaOSButton.Margin = new Padding(1);
            AgregarSeleccionadaOSButton.Name = "AgregarSeleccionadaOSButton";
            AgregarSeleccionadaOSButton.Size = new Size(161, 23);
            AgregarSeleccionadaOSButton.TabIndex = 46;
            AgregarSeleccionadaOSButton.Text = "Agregar Seleccionadas";
            AgregarSeleccionadaOSButton.UseVisualStyleBackColor = true;
            // 
            // DetalleOSList
            // 
            DetalleOSList.Columns.AddRange(new ColumnHeader[] { ProductoColumna, CantidadColumna, UbicacionOSColumna });
            DetalleOSList.Location = new Point(454, 170);
            DetalleOSList.Margin = new Padding(3, 2, 3, 2);
            DetalleOSList.Name = "DetalleOSList";
            DetalleOSList.Size = new Size(313, 125);
            DetalleOSList.TabIndex = 47;
            DetalleOSList.UseCompatibleStateImageBehavior = false;
            DetalleOSList.View = View.Details;
            // 
            // ProductoColumna
            // 
            ProductoColumna.Text = "Producto";
            ProductoColumna.Width = 120;
            // 
            // CantidadColumna
            // 
            CantidadColumna.Text = "Cantidad";
            CantidadColumna.Width = 120;
            // 
            // UbicacionOSColumna
            // 
            UbicacionOSColumna.Text = "Ubicacion";
            UbicacionOSColumna.Width = 120;
            // 
            // DetalleOSLabel
            // 
            DetalleOSLabel.AutoSize = true;
            DetalleOSLabel.Location = new Point(454, 148);
            DetalleOSLabel.Name = "DetalleOSLabel";
            DetalleOSLabel.Size = new Size(107, 15);
            DetalleOSLabel.TabIndex = 48;
            DetalleOSLabel.Text = "Detalle de la Orden";
            // 
            // QuitarSeleccionadasOSButton
            // 
            QuitarSeleccionadasOSButton.Location = new Point(603, 515);
            QuitarSeleccionadasOSButton.Margin = new Padding(1);
            QuitarSeleccionadasOSButton.Name = "QuitarSeleccionadasOSButton";
            QuitarSeleccionadasOSButton.Size = new Size(161, 23);
            QuitarSeleccionadasOSButton.TabIndex = 49;
            QuitarSeleccionadasOSButton.Text = "Quitar Seleccionadas";
            QuitarSeleccionadasOSButton.UseVisualStyleBackColor = true;
            // 
            // TotalesOSSeleccionadasLabel
            // 
            TotalesOSSeleccionadasLabel.AutoSize = true;
            TotalesOSSeleccionadasLabel.Location = new Point(454, 365);
            TotalesOSSeleccionadasLabel.Name = "TotalesOSSeleccionadasLabel";
            TotalesOSSeleccionadasLabel.Size = new Size(43, 15);
            TotalesOSSeleccionadasLabel.TabIndex = 52;
            TotalesOSSeleccionadasLabel.Text = "Totales";
            // 
            // TotalesOSSeleccionadasList
            // 
            TotalesOSSeleccionadasList.Columns.AddRange(new ColumnHeader[] { ProductoOrdenSeleccionadaColumna, CantidadOrdenSeleccionadaColumna, UbicacionOrdenSeleccionadaColumna });
            TotalesOSSeleccionadasList.Location = new Point(454, 389);
            TotalesOSSeleccionadasList.Margin = new Padding(3, 2, 3, 2);
            TotalesOSSeleccionadasList.Name = "TotalesOSSeleccionadasList";
            TotalesOSSeleccionadasList.Size = new Size(313, 125);
            TotalesOSSeleccionadasList.TabIndex = 51;
            TotalesOSSeleccionadasList.UseCompatibleStateImageBehavior = false;
            TotalesOSSeleccionadasList.View = View.Details;
            // 
            // ProductoOrdenSeleccionadaColumna
            // 
            ProductoOrdenSeleccionadaColumna.Text = "Producto";
            ProductoOrdenSeleccionadaColumna.Width = 120;
            // 
            // CantidadOrdenSeleccionadaColumna
            // 
            CantidadOrdenSeleccionadaColumna.Text = "Cantidad";
            CantidadOrdenSeleccionadaColumna.Width = 120;
            // 
            // UbicacionOrdenSeleccionadaColumna
            // 
            UbicacionOrdenSeleccionadaColumna.Text = "Ubicacion";
            UbicacionOrdenSeleccionadaColumna.Width = 120;
            // 
            // GenerarOSSeleccionadasList
            // 
            GenerarOSSeleccionadasList.Columns.AddRange(new ColumnHeader[] { IdOPSeleccionadaColumna, ClienteSeleccionadoColumna, FechaOPSeleccionadaColumna });
            GenerarOSSeleccionadasList.Location = new Point(25, 365);
            GenerarOSSeleccionadasList.Margin = new Padding(3, 2, 3, 2);
            GenerarOSSeleccionadasList.Name = "GenerarOSSeleccionadasList";
            GenerarOSSeleccionadasList.Size = new Size(409, 147);
            GenerarOSSeleccionadasList.TabIndex = 50;
            GenerarOSSeleccionadasList.UseCompatibleStateImageBehavior = false;
            GenerarOSSeleccionadasList.View = View.Details;
            // 
            // IdOPSeleccionadaColumna
            // 
            IdOPSeleccionadaColumna.Text = "ID Orden Preparación";
            IdOPSeleccionadaColumna.Width = 200;
            // 
            // ClienteSeleccionadoColumna
            // 
            ClienteSeleccionadoColumna.Text = "Descripcion Cliente";
            ClienteSeleccionadoColumna.Width = 180;
            // 
            // FechaOPSeleccionadaColumna
            // 
            FechaOPSeleccionadaColumna.Text = "Fecha";
            FechaOPSeleccionadaColumna.Width = 100;
            // 
            // GenerarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 548);
            Controls.Add(TotalesOSSeleccionadasLabel);
            Controls.Add(TotalesOSSeleccionadasList);
            Controls.Add(GenerarOSSeleccionadasList);
            Controls.Add(QuitarSeleccionadasOSButton);
            Controls.Add(DetalleOSLabel);
            Controls.Add(DetalleOSList);
            Controls.Add(AgregarSeleccionadaOSButton);
            Controls.Add(FechaHastaLabel);
            Controls.Add(FechaOSHastaPicker);
            Controls.Add(GenerarOrdenButton);
            Controls.Add(label4);
            Controls.Add(DescripcionClienteCombo);
            Controls.Add(label3);
            Controls.Add(PrioridadCombo);
            Controls.Add(GenerarOrdenSeleccionBuscarList);
            Controls.Add(BuscarButton);
            Controls.Add(VolverButton);
            Controls.Add(FechaDesdeLabel);
            Controls.Add(label1);
            Controls.Add(FechaOSDesdePicker);
            Controls.Add(IdOrdenPreparacionCombo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GenerarOrdenSeleccionForm";
            Text = "Generar Orden de Selección";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView GenerarOrdenSeleccionList;
        private ColumnHeader IdOrdenSeleccionColumna;
        private ColumnHeader FechaOE2Columna;
        private ColumnHeader DescripcionProducto2Columna;
        private ColumnHeader Cantidad2Columna;
        private ColumnHeader Ubicacion2Columna;
        private ColumnHeader Estado2Columna;
        private ListView GenerarOrdenSeleccionBuscarList;
        private ColumnHeader IdOrdenPreparacionColumna;
        private ColumnHeader FechaOPColumna;
        private Button BuscarButton;
        private Button VolverButton;
        private Label FechaDesdeLabel;
        private Label label1;
        private DateTimePicker FechaOSDesdePicker;
        private ComboBox IdOrdenPreparacionCombo;
        private Label label3;
        private ComboBox PrioridadCombo;
        private Label label4;
        private ComboBox DescripcionClienteCombo;
        private Button GenerarOrdenButton;
        private Label FechaHastaLabel;
        private DateTimePicker FechaOSHastaPicker;
        private Button AgregarSeleccionadaOSButton;
        private ListView DetalleOSList;
        private ColumnHeader ProductoColumna;
        private ColumnHeader CantidadColumna;
        private Label DetalleOSLabel;
        private Button QuitarSeleccionadasOSButton;
        private Label TotalesOSSeleccionadasLabel;
        private ListView TotalesOSSeleccionadasList;
        private ColumnHeader ProductoOrdenSeleccionadaColumna;
        private ColumnHeader CantidadOrdenSeleccionadaColumna;
        private ListView GenerarOSSeleccionadasList;
        private ColumnHeader IdOPSeleccionadaColumna;
        private ColumnHeader FechaOPSeleccionadaColumna;
        private ColumnHeader ClienteOSColumna;
        private ColumnHeader ClienteSeleccionadoColumna;
        private ColumnHeader UbicacionOrdenSeleccionadaColumna;
        private ColumnHeader UbicacionOSColumna;
    }
}