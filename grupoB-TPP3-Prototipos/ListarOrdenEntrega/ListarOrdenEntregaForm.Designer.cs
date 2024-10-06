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
            IdOrdenEntregaColumna = new ColumnHeader();
            FechaOEColumna = new ColumnHeader();
            DescripcionProducto2Columna = new ColumnHeader();
            Cantidad2Columna = new ColumnHeader();
            Ubicacion2Columna = new ColumnHeader();
            Estado2Columna = new ColumnHeader();
            BuscarButton = new Button();
            VolverButton = new Button();
            FechaDesdeOELabel = new Label();
            label1 = new Label();
            FechaDesdeOEPicker = new DateTimePicker();
            IdOrdenCombo = new ComboBox();
            label6 = new Label();
            UbicacionCombo = new ComboBox();
            FechaHastaOELabel = new Label();
            FechaHastaOEPicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(526, 154);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 32);
            label5.TabIndex = 48;
            label5.Text = "Estado";
            // 
            // EstadoCombo
            // 
            EstadoCombo.FormattingEnabled = true;
            EstadoCombo.Location = new Point(526, 191);
            EstadoCombo.Margin = new Padding(5, 5, 5, 5);
            EstadoCombo.Name = "EstadoCombo";
            EstadoCombo.Size = new Size(496, 40);
            EstadoCombo.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 154);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 32);
            label4.TabIndex = 46;
            label4.Text = "ID Cliente";
            // 
            // IdClienteCombo
            // 
            IdClienteCombo.FormattingEnabled = true;
            IdClienteCombo.Location = new Point(42, 191);
            IdClienteCombo.Margin = new Padding(5, 5, 5, 5);
            IdClienteCombo.Name = "IdClienteCombo";
            IdClienteCombo.Size = new Size(404, 40);
            IdClienteCombo.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1067, 45);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 32);
            label3.TabIndex = 44;
            label3.Text = "Prioridad";
            // 
            // PrioridadCombo
            // 
            PrioridadCombo.FormattingEnabled = true;
            PrioridadCombo.Location = new Point(1067, 84);
            PrioridadCombo.Margin = new Padding(5, 5, 5, 5);
            PrioridadCombo.Name = "PrioridadCombo";
            PrioridadCombo.Size = new Size(348, 40);
            PrioridadCombo.TabIndex = 43;
            // 
            // ListarOrdenEntregaBuscarList
            // 
            ListarOrdenEntregaBuscarList.Columns.AddRange(new ColumnHeader[] { IdOrdenEntregaColumna, FechaOEColumna, DescripcionProducto2Columna, Cantidad2Columna, Ubicacion2Columna, Estado2Columna });
            ListarOrdenEntregaBuscarList.Location = new Point(42, 394);
            ListarOrdenEntregaBuscarList.Margin = new Padding(5, 5, 5, 5);
            ListarOrdenEntregaBuscarList.Name = "ListarOrdenEntregaBuscarList";
            ListarOrdenEntregaBuscarList.Size = new Size(1374, 389);
            ListarOrdenEntregaBuscarList.TabIndex = 41;
            ListarOrdenEntregaBuscarList.UseCompatibleStateImageBehavior = false;
            ListarOrdenEntregaBuscarList.View = View.Details;
            // 
            // IdOrdenEntregaColumna
            // 
            IdOrdenEntregaColumna.Text = "ID Orden Entrega";
            IdOrdenEntregaColumna.Width = 200;
            // 
            // FechaOEColumna
            // 
            FechaOEColumna.Text = "Fecha";
            FechaOEColumna.Width = 100;
            // 
            // DescripcionProducto2Columna
            // 
            DescripcionProducto2Columna.Text = "Descripción Producto";
            DescripcionProducto2Columna.Width = 250;
            // 
            // Cantidad2Columna
            // 
            Cantidad2Columna.Text = "Cantidad";
            Cantidad2Columna.Width = 120;
            // 
            // Ubicacion2Columna
            // 
            Ubicacion2Columna.Text = "Ubicación";
            Ubicacion2Columna.Width = 120;
            // 
            // Estado2Columna
            // 
            Estado2Columna.Text = "Estado";
            Estado2Columna.Width = 100;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(1207, 295);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(208, 49);
            BuscarButton.TabIndex = 39;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(1208, 825);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(208, 49);
            VolverButton.TabIndex = 38;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // FechaDesdeOELabel
            // 
            FechaDesdeOELabel.AutoSize = true;
            FechaDesdeOELabel.Location = new Point(526, 45);
            FechaDesdeOELabel.Margin = new Padding(5, 0, 5, 0);
            FechaDesdeOELabel.Name = "FechaDesdeOELabel";
            FechaDesdeOELabel.Size = new Size(147, 32);
            FechaDesdeOELabel.TabIndex = 37;
            FechaDesdeOELabel.Text = "Fecha desde";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 41);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 36;
            label1.Text = "ID Orden";
            // 
            // FechaDesdeOEPicker
            // 
            FechaDesdeOEPicker.Location = new Point(526, 82);
            FechaDesdeOEPicker.Margin = new Padding(5, 5, 5, 5);
            FechaDesdeOEPicker.Name = "FechaDesdeOEPicker";
            FechaDesdeOEPicker.Size = new Size(223, 39);
            FechaDesdeOEPicker.TabIndex = 35;
            // 
            // IdOrdenCombo
            // 
            IdOrdenCombo.FormattingEnabled = true;
            IdOrdenCombo.Location = new Point(42, 79);
            IdOrdenCombo.Margin = new Padding(5, 5, 5, 5);
            IdOrdenCombo.Name = "IdOrdenCombo";
            IdOrdenCombo.Size = new Size(404, 40);
            IdOrdenCombo.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1067, 154);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 32);
            label6.TabIndex = 50;
            label6.Text = "Ubicación";
            // 
            // UbicacionCombo
            // 
            UbicacionCombo.FormattingEnabled = true;
            UbicacionCombo.Location = new Point(1067, 191);
            UbicacionCombo.Margin = new Padding(5, 5, 5, 5);
            UbicacionCombo.Name = "UbicacionCombo";
            UbicacionCombo.Size = new Size(349, 40);
            UbicacionCombo.TabIndex = 49;
            // 
            // FechaHastaOELabel
            // 
            FechaHastaOELabel.AutoSize = true;
            FechaHastaOELabel.Location = new Point(799, 45);
            FechaHastaOELabel.Margin = new Padding(5, 0, 5, 0);
            FechaHastaOELabel.Name = "FechaHastaOELabel";
            FechaHastaOELabel.Size = new Size(139, 32);
            FechaHastaOELabel.TabIndex = 52;
            FechaHastaOELabel.Text = "Fecha hasta";
            // 
            // FechaHastaOEPicker
            // 
            FechaHastaOEPicker.Location = new Point(799, 82);
            FechaHastaOEPicker.Margin = new Padding(5);
            FechaHastaOEPicker.Name = "FechaHastaOEPicker";
            FechaHastaOEPicker.Size = new Size(223, 39);
            FechaHastaOEPicker.TabIndex = 51;
            // 
            // ListarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 919);
            Controls.Add(FechaHastaOELabel);
            Controls.Add(FechaHastaOEPicker);
            Controls.Add(label6);
            Controls.Add(UbicacionCombo);
            Controls.Add(label5);
            Controls.Add(EstadoCombo);
            Controls.Add(label4);
            Controls.Add(IdClienteCombo);
            Controls.Add(label3);
            Controls.Add(PrioridadCombo);
            Controls.Add(ListarOrdenEntregaBuscarList);
            Controls.Add(BuscarButton);
            Controls.Add(VolverButton);
            Controls.Add(FechaDesdeOELabel);
            Controls.Add(label1);
            Controls.Add(FechaDesdeOEPicker);
            Controls.Add(IdOrdenCombo);
            Margin = new Padding(5, 5, 5, 5);
            Name = "ListarOrdenEntregaForm";
            Text = "Listar Ordenes de Entrega";
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
        private ColumnHeader IdOrdenEntregaColumna;
        private ColumnHeader FechaOEColumna;
        private ColumnHeader DescripcionProducto2Columna;
        private ColumnHeader Cantidad2Columna;
        private ColumnHeader Ubicacion2Columna;
        private ColumnHeader Estado2Columna;
        private Button BuscarButton;
        private Button VolverButton;
        private Label FechaDesdeOELabel;
        private Label label1;
        private DateTimePicker FechaDesdeOEPicker;
        private ComboBox IdOrdenCombo;
        private Label label6;
        private ComboBox UbicacionCombo;
        private Label FechaHastaOELabel;
        private DateTimePicker FechaHastaOEPicker;
    }
}