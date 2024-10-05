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
            label5 = new Label();
            EstadoCombo = new ComboBox();
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
            GenerarOrdenSeleccionBuscarList.Location = new Point(47, 315);
            GenerarOrdenSeleccionBuscarList.Margin = new Padding(5);
            GenerarOrdenSeleccionBuscarList.Name = "GenerarOrdenSeleccionBuscarList";
            GenerarOrdenSeleccionBuscarList.Size = new Size(755, 310);
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
            BuscarButton.Location = new Point(925, 163);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(496, 49);
            BuscarButton.TabIndex = 24;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(1213, 1187);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(208, 49);
            VolverButton.TabIndex = 23;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // FechaDesdeLabel
            // 
            FechaDesdeLabel.AutoSize = true;
            FechaDesdeLabel.Location = new Point(532, 21);
            FechaDesdeLabel.Margin = new Padding(5, 0, 5, 0);
            FechaDesdeLabel.Name = "FechaDesdeLabel";
            FechaDesdeLabel.Size = new Size(150, 32);
            FechaDesdeLabel.TabIndex = 22;
            FechaDesdeLabel.Text = "Fecha Desde";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 19);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 21;
            label1.Text = "ID Orden Preparación";
            // 
            // FechaOSDesdePicker
            // 
            FechaOSDesdePicker.Location = new Point(532, 58);
            FechaOSDesdePicker.Margin = new Padding(5);
            FechaOSDesdePicker.Name = "FechaOSDesdePicker";
            FechaOSDesdePicker.Size = new Size(232, 39);
            FechaOSDesdePicker.TabIndex = 20;
            // 
            // IdOrdenSeleccionCombo
            // 
            IdOrdenSeleccionCombo.FormattingEnabled = true;
            IdOrdenSeleccionCombo.Location = new Point(47, 58);
            IdOrdenSeleccionCombo.Margin = new Padding(5);
            IdOrdenSeleccionCombo.Name = "IdOrdenSeleccionCombo";
            IdOrdenSeleccionCombo.Size = new Size(404, 40);
            IdOrdenSeleccionCombo.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1093, 26);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 32);
            label3.TabIndex = 29;
            label3.Text = "Prioridad";
            // 
            // PrioridadCombo
            // 
            PrioridadCombo.FormattingEnabled = true;
            PrioridadCombo.Location = new Point(1093, 63);
            PrioridadCombo.Margin = new Padding(5);
            PrioridadCombo.Name = "PrioridadCombo";
            PrioridadCombo.Size = new Size(328, 40);
            PrioridadCombo.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 134);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(220, 32);
            label4.TabIndex = 31;
            label4.Text = "Descripción Cliente";
            // 
            // DescripcionClienteCombo
            // 
            DescripcionClienteCombo.FormattingEnabled = true;
            DescripcionClienteCombo.Location = new Point(47, 173);
            DescripcionClienteCombo.Margin = new Padding(5);
            DescripcionClienteCombo.Name = "DescripcionClienteCombo";
            DescripcionClienteCombo.Size = new Size(404, 40);
            DescripcionClienteCombo.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(532, 134);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 32);
            label5.TabIndex = 33;
            label5.Text = "Estado";
            // 
            // EstadoCombo
            // 
            EstadoCombo.FormattingEnabled = true;
            EstadoCombo.Location = new Point(532, 172);
            EstadoCombo.Margin = new Padding(5);
            EstadoCombo.Name = "EstadoCombo";
            EstadoCombo.Size = new Size(328, 40);
            EstadoCombo.TabIndex = 32;
            // 
            // GenerarOrdenButton
            // 
            GenerarOrdenButton.Location = new Point(873, 1187);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(315, 49);
            GenerarOrdenButton.TabIndex = 43;
            GenerarOrdenButton.Text = "Generar Orden";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            // 
            // FechaHastaLabel
            // 
            FechaHastaLabel.AutoSize = true;
            FechaHastaLabel.Location = new Point(805, 22);
            FechaHastaLabel.Margin = new Padding(5, 0, 5, 0);
            FechaHastaLabel.Name = "FechaHastaLabel";
            FechaHastaLabel.Size = new Size(142, 32);
            FechaHastaLabel.TabIndex = 45;
            FechaHastaLabel.Text = "Fecha Hasta";
            // 
            // FechaOSHastaPicker
            // 
            FechaOSHastaPicker.Location = new Point(805, 59);
            FechaOSHastaPicker.Margin = new Padding(5);
            FechaOSHastaPicker.Name = "FechaOSHastaPicker";
            FechaOSHastaPicker.Size = new Size(232, 39);
            FechaOSHastaPicker.TabIndex = 44;
            // 
            // AgregarSeleccionadaOSButton
            // 
            AgregarSeleccionadaOSButton.Location = new Point(1122, 633);
            AgregarSeleccionadaOSButton.Name = "AgregarSeleccionadaOSButton";
            AgregarSeleccionadaOSButton.Size = new Size(299, 49);
            AgregarSeleccionadaOSButton.TabIndex = 46;
            AgregarSeleccionadaOSButton.Text = "Agregar Seleccionadas";
            AgregarSeleccionadaOSButton.UseVisualStyleBackColor = true;
            // 
            // DetalleOSList
            // 
            DetalleOSList.Columns.AddRange(new ColumnHeader[] { ProductoColumna, CantidadColumna });
            DetalleOSList.Location = new Point(843, 364);
            DetalleOSList.Margin = new Padding(5);
            DetalleOSList.Name = "DetalleOSList";
            DetalleOSList.Size = new Size(578, 261);
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
            DetalleOSLabel.Location = new Point(843, 315);
            DetalleOSLabel.Margin = new Padding(5, 0, 5, 0);
            DetalleOSLabel.Name = "DetalleOSLabel";
            DetalleOSLabel.Size = new Size(222, 32);
            DetalleOSLabel.TabIndex = 48;
            DetalleOSLabel.Text = "Detalle de la Orden";
            // 
            // QuitarSeleccionadasOSButton
            // 
            QuitarSeleccionadasOSButton.Location = new Point(1122, 1097);
            QuitarSeleccionadasOSButton.Name = "QuitarSeleccionadasOSButton";
            QuitarSeleccionadasOSButton.Size = new Size(299, 49);
            QuitarSeleccionadasOSButton.TabIndex = 49;
            QuitarSeleccionadasOSButton.Text = "Quitar Seleccionadas";
            QuitarSeleccionadasOSButton.UseVisualStyleBackColor = true;
            // 
            // TotalesOSSeleccionadasLabel
            // 
            TotalesOSSeleccionadasLabel.AutoSize = true;
            TotalesOSSeleccionadasLabel.Location = new Point(843, 779);
            TotalesOSSeleccionadasLabel.Margin = new Padding(5, 0, 5, 0);
            TotalesOSSeleccionadasLabel.Name = "TotalesOSSeleccionadasLabel";
            TotalesOSSeleccionadasLabel.Size = new Size(88, 32);
            TotalesOSSeleccionadasLabel.TabIndex = 52;
            TotalesOSSeleccionadasLabel.Text = "Totales";
            // 
            // TotalesOSSeleccionadasList
            // 
            TotalesOSSeleccionadasList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            TotalesOSSeleccionadasList.Location = new Point(843, 828);
            TotalesOSSeleccionadasList.Margin = new Padding(5);
            TotalesOSSeleccionadasList.Name = "TotalesOSSeleccionadasList";
            TotalesOSSeleccionadasList.Size = new Size(578, 261);
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
            GenerarOSSeleccionadasList.Location = new Point(47, 779);
            GenerarOSSeleccionadasList.Margin = new Padding(5);
            GenerarOSSeleccionadasList.Name = "GenerarOSSeleccionadasList";
            GenerarOSSeleccionadasList.Size = new Size(755, 310);
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
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 1248);
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
            Controls.Add(label5);
            Controls.Add(EstadoCombo);
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
            Margin = new Padding(5);
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
        private Label label5;
        private ComboBox EstadoCombo;
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