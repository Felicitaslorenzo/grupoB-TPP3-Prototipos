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
            FechaOPColumna = new ColumnHeader();
            PrioridadColumna = new ColumnHeader();
            BuscarButton = new Button();
            VolverButton = new Button();
            FechaDesdeLabel = new Label();
            label1 = new Label();
            FechaOSDesdePicker = new DateTimePicker();
            IdOrdenSeleccionCombo = new ComboBox();
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
            DetalleOSLabel = new Label();
            QuitarSeleccionadasOSButton = new Button();
            TotalesOSSeleccionadasLabel = new Label();
            TotalesOSSeleccionadasList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            GenerarOSSeleccionadasList = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            SuspendLayout();
            // 
            // GenerarOrdenSeleccionBuscarList
            // 
            GenerarOrdenSeleccionBuscarList.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionColumna, FechaOPColumna, PrioridadColumna });
            GenerarOrdenSeleccionBuscarList.Location = new Point(29, 197);
            GenerarOrdenSeleccionBuscarList.Name = "GenerarOrdenSeleccionBuscarList";
            GenerarOrdenSeleccionBuscarList.Size = new Size(466, 195);
            GenerarOrdenSeleccionBuscarList.TabIndex = 25;
            GenerarOrdenSeleccionBuscarList.UseCompatibleStateImageBehavior = false;
            GenerarOrdenSeleccionBuscarList.View = View.Details;
            // 
            // IdOrdenPreparacionColumna
            // 
            IdOrdenPreparacionColumna.Text = "ID Orden Preparación";
            IdOrdenPreparacionColumna.Width = 170;
            // 
            // FechaOPColumna
            // 
            FechaOPColumna.Text = "Fecha";
            FechaOPColumna.Width = 100;
            // 
            // PrioridadColumna
            // 
            PrioridadColumna.Text = "Prioridad";
            PrioridadColumna.Width = 100;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(327, 102);
            BuscarButton.Margin = new Padding(2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(548, 30);
            BuscarButton.TabIndex = 24;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(746, 742);
            VolverButton.Margin = new Padding(2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(128, 30);
            VolverButton.TabIndex = 23;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // FechaDesdeLabel
            // 
            FechaDesdeLabel.AutoSize = true;
            FechaDesdeLabel.Location = new Point(327, 13);
            FechaDesdeLabel.Name = "FechaDesdeLabel";
            FechaDesdeLabel.Size = new Size(93, 20);
            FechaDesdeLabel.TabIndex = 22;
            FechaDesdeLabel.Text = "Fecha Desde";
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
            // FechaOSDesdePicker
            // 
            FechaOSDesdePicker.Location = new Point(327, 36);
            FechaOSDesdePicker.Name = "FechaOSDesdePicker";
            FechaOSDesdePicker.Size = new Size(144, 27);
            FechaOSDesdePicker.TabIndex = 20;
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
            label3.Location = new Point(673, 16);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 29;
            label3.Text = "Prioridad";
            // 
            // PrioridadCombo
            // 
            PrioridadCombo.FormattingEnabled = true;
            PrioridadCombo.Location = new Point(673, 39);
            PrioridadCombo.Name = "PrioridadCombo";
            PrioridadCombo.Size = new Size(203, 28);
            PrioridadCombo.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 84);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 31;
            label4.Text = "Descripción Cliente";
            // 
            // DescripcionClienteCombo
            // 
            DescripcionClienteCombo.FormattingEnabled = true;
            DescripcionClienteCombo.Location = new Point(29, 108);
            DescripcionClienteCombo.Name = "DescripcionClienteCombo";
            DescripcionClienteCombo.Size = new Size(250, 28);
            DescripcionClienteCombo.TabIndex = 30;
            // 
            // GenerarOrdenButton
            // 
            GenerarOrdenButton.Location = new Point(538, 742);
            GenerarOrdenButton.Margin = new Padding(2);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(194, 30);
            GenerarOrdenButton.TabIndex = 43;
            GenerarOrdenButton.Text = "Generar Orden";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            // 
            // FechaHastaLabel
            // 
            FechaHastaLabel.AutoSize = true;
            FechaHastaLabel.Location = new Point(495, 14);
            FechaHastaLabel.Name = "FechaHastaLabel";
            FechaHastaLabel.Size = new Size(89, 20);
            FechaHastaLabel.TabIndex = 45;
            FechaHastaLabel.Text = "Fecha Hasta";
            // 
            // FechaOSHastaPicker
            // 
            FechaOSHastaPicker.Location = new Point(495, 37);
            FechaOSHastaPicker.Name = "FechaOSHastaPicker";
            FechaOSHastaPicker.Size = new Size(144, 27);
            FechaOSHastaPicker.TabIndex = 44;
            // 
            // AgregarSeleccionadaOSButton
            // 
            AgregarSeleccionadaOSButton.Location = new Point(690, 396);
            AgregarSeleccionadaOSButton.Margin = new Padding(2);
            AgregarSeleccionadaOSButton.Name = "AgregarSeleccionadaOSButton";
            AgregarSeleccionadaOSButton.Size = new Size(184, 30);
            AgregarSeleccionadaOSButton.TabIndex = 46;
            AgregarSeleccionadaOSButton.Text = "Agregar Seleccionadas";
            AgregarSeleccionadaOSButton.UseVisualStyleBackColor = true;
            // 
            // DetalleOSList
            // 
            DetalleOSList.Columns.AddRange(new ColumnHeader[] { ProductoColumna, CantidadColumna });
            DetalleOSList.Location = new Point(518, 227);
            DetalleOSList.Name = "DetalleOSList";
            DetalleOSList.Size = new Size(358, 165);
            DetalleOSList.TabIndex = 47;
            DetalleOSList.UseCompatibleStateImageBehavior = false;
            DetalleOSList.View = View.Details;
            // 
            // ProductoColumna
            // 
            ProductoColumna.Text = "Producto";
            ProductoColumna.Width = 100;
            // 
            // CantidadColumna
            // 
            CantidadColumna.Text = "Cantidad";
            // 
            // DetalleOSLabel
            // 
            DetalleOSLabel.AutoSize = true;
            DetalleOSLabel.Location = new Point(518, 197);
            DetalleOSLabel.Name = "DetalleOSLabel";
            DetalleOSLabel.Size = new Size(139, 20);
            DetalleOSLabel.TabIndex = 48;
            DetalleOSLabel.Text = "Detalle de la Orden";
            // 
            // QuitarSeleccionadasOSButton
            // 
            QuitarSeleccionadasOSButton.Location = new Point(690, 686);
            QuitarSeleccionadasOSButton.Margin = new Padding(2);
            QuitarSeleccionadasOSButton.Name = "QuitarSeleccionadasOSButton";
            QuitarSeleccionadasOSButton.Size = new Size(184, 30);
            QuitarSeleccionadasOSButton.TabIndex = 49;
            QuitarSeleccionadasOSButton.Text = "Quitar Seleccionadas";
            QuitarSeleccionadasOSButton.UseVisualStyleBackColor = true;
            // 
            // TotalesOSSeleccionadasLabel
            // 
            TotalesOSSeleccionadasLabel.AutoSize = true;
            TotalesOSSeleccionadasLabel.Location = new Point(518, 487);
            TotalesOSSeleccionadasLabel.Name = "TotalesOSSeleccionadasLabel";
            TotalesOSSeleccionadasLabel.Size = new Size(56, 20);
            TotalesOSSeleccionadasLabel.TabIndex = 52;
            TotalesOSSeleccionadasLabel.Text = "Totales";
            // 
            // TotalesOSSeleccionadasList
            // 
            TotalesOSSeleccionadasList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            TotalesOSSeleccionadasList.Location = new Point(518, 518);
            TotalesOSSeleccionadasList.Name = "TotalesOSSeleccionadasList";
            TotalesOSSeleccionadasList.Size = new Size(358, 165);
            TotalesOSSeleccionadasList.TabIndex = 51;
            TotalesOSSeleccionadasList.UseCompatibleStateImageBehavior = false;
            TotalesOSSeleccionadasList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Producto";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cantidad";
            // 
            // GenerarOSSeleccionadasList
            // 
            GenerarOSSeleccionadasList.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5 });
            GenerarOSSeleccionadasList.Location = new Point(29, 487);
            GenerarOSSeleccionadasList.Name = "GenerarOSSeleccionadasList";
            GenerarOSSeleccionadasList.Size = new Size(466, 195);
            GenerarOSSeleccionadasList.TabIndex = 50;
            GenerarOSSeleccionadasList.UseCompatibleStateImageBehavior = false;
            GenerarOSSeleccionadasList.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ID Orden Preparación";
            columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fecha";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Prioridad";
            columnHeader5.Width = 100;
            // 
            // GenerarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 788);
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
            Controls.Add(IdOrdenSeleccionCombo);
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
        private ComboBox IdOrdenSeleccionCombo;
        private Label label3;
        private ComboBox PrioridadCombo;
        private Label label4;
        private ComboBox DescripcionClienteCombo;
        private ColumnHeader PrioridadColumna;
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
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView GenerarOSSeleccionadasList;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}