namespace grupoB_TPP3_Prototipos.GenerarOrdenSelección
{
    partial class GenerarOrdenPreparacionForm
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
            GenerarOrdenSeleccionList = new ListView();
            IdOrdenSeleccionColumna = new ColumnHeader();
            FechaOE2Columna = new ColumnHeader();
            DescripcionProducto2Columna = new ColumnHeader();
            Cantidad2Columna = new ColumnHeader();
            Ubicacion2Columna = new ColumnHeader();
            Estado2Columna = new ColumnHeader();
            GenerarOrdenSeleccionBuscarList = new ListView();
            IdOrdenPreparacionColumna = new ColumnHeader();
            FechaOEColumna = new ColumnHeader();
            DescripcionProductoColumna = new ColumnHeader();
            EstadoColumna = new ColumnHeader();
            PrioridadColumna = new ColumnHeader();
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
            GenerarOrdenButton = new Button();
            SuspendLayout();
            // 
            // GenerarOrdenSeleccionList
            // 
            GenerarOrdenSeleccionList.Columns.AddRange(new ColumnHeader[] { IdOrdenSeleccionColumna, FechaOE2Columna, DescripcionProducto2Columna, Cantidad2Columna, Ubicacion2Columna, Estado2Columna });
            GenerarOrdenSeleccionList.Location = new Point(36, 541);
            GenerarOrdenSeleccionList.Margin = new Padding(4, 4, 4, 4);
            GenerarOrdenSeleccionList.Name = "GenerarOrdenSeleccionList";
            GenerarOrdenSeleccionList.Size = new Size(1058, 243);
            GenerarOrdenSeleccionList.TabIndex = 26;
            GenerarOrdenSeleccionList.UseCompatibleStateImageBehavior = false;
            GenerarOrdenSeleccionList.View = View.Details;
            // 
            // IdOrdenSeleccionColumna
            // 
            IdOrdenSeleccionColumna.Text = "ID Orden Seleccion";
            IdOrdenSeleccionColumna.Width = 150;
            // 
            // FechaOE2Columna
            // 
            FechaOE2Columna.Text = "Fecha";
            FechaOE2Columna.Width = 100;
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
            // GenerarOrdenSeleccionBuscarList
            // 
            GenerarOrdenSeleccionBuscarList.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionColumna, FechaOEColumna, DescripcionProductoColumna, EstadoColumna, PrioridadColumna });
            GenerarOrdenSeleccionBuscarList.Location = new Point(36, 246);
            GenerarOrdenSeleccionBuscarList.Margin = new Padding(4, 4, 4, 4);
            GenerarOrdenSeleccionBuscarList.Name = "GenerarOrdenSeleccionBuscarList";
            GenerarOrdenSeleccionBuscarList.Size = new Size(1058, 243);
            GenerarOrdenSeleccionBuscarList.TabIndex = 25;
            GenerarOrdenSeleccionBuscarList.UseCompatibleStateImageBehavior = false;
            GenerarOrdenSeleccionBuscarList.View = View.Details;
            // 
            // IdOrdenPreparacionColumna
            // 
            IdOrdenPreparacionColumna.Text = "ID Orden Preparación";
            IdOrdenPreparacionColumna.Width = 170;
            // 
            // FechaOEColumna
            // 
            FechaOEColumna.Text = "Fecha";
            FechaOEColumna.Width = 100;
            // 
            // DescripcionProductoColumna
            // 
            DescripcionProductoColumna.Text = "Descripción Producto";
            DescripcionProductoColumna.Width = 180;
            // 
            // EstadoColumna
            // 
            EstadoColumna.Text = "Estado";
            EstadoColumna.Width = 100;
            // 
            // PrioridadColumna
            // 
            PrioridadColumna.Text = "Prioridad";
            PrioridadColumna.Width = 100;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(730, 181);
            BuscarButton.Margin = new Padding(2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(160, 38);
            BuscarButton.TabIndex = 24;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(912, 181);
            VolverButton.Margin = new Padding(2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(160, 38);
            VolverButton.TabIndex = 23;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 22;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 21;
            label1.Text = "ID Orden Preparación";
            // 
            // FechaOSPicker
            // 
            FechaOSPicker.Location = new Point(409, 46);
            FechaOSPicker.Margin = new Padding(4, 4, 4, 4);
            FechaOSPicker.Name = "FechaOSPicker";
            FechaOSPicker.Size = new Size(374, 31);
            FechaOSPicker.TabIndex = 20;
            // 
            // IdOrdenSeleccionCombo
            // 
            IdOrdenSeleccionCombo.FormattingEnabled = true;
            IdOrdenSeleccionCombo.Location = new Point(36, 45);
            IdOrdenSeleccionCombo.Margin = new Padding(4, 4, 4, 4);
            IdOrdenSeleccionCombo.Name = "IdOrdenSeleccionCombo";
            IdOrdenSeleccionCombo.Size = new Size(312, 33);
            IdOrdenSeleccionCombo.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(841, 20);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 29;
            label3.Text = "Prioridad";
            // 
            // PrioridadCombo
            // 
            PrioridadCombo.FormattingEnabled = true;
            PrioridadCombo.Location = new Point(841, 49);
            PrioridadCombo.Margin = new Padding(4, 4, 4, 4);
            PrioridadCombo.Name = "PrioridadCombo";
            PrioridadCombo.Size = new Size(253, 33);
            PrioridadCombo.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 105);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(162, 25);
            label4.TabIndex = 31;
            label4.Text = "Descripción Cliente";
            // 
            // DescripcionClienteCombo
            // 
            DescripcionClienteCombo.FormattingEnabled = true;
            DescripcionClienteCombo.Location = new Point(36, 135);
            DescripcionClienteCombo.Margin = new Padding(4, 4, 4, 4);
            DescripcionClienteCombo.Name = "DescripcionClienteCombo";
            DescripcionClienteCombo.Size = new Size(312, 33);
            DescripcionClienteCombo.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(409, 105);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 33;
            label5.Text = "Estado";
            // 
            // EstadoCombo
            // 
            EstadoCombo.FormattingEnabled = true;
            EstadoCombo.Location = new Point(409, 134);
            EstadoCombo.Margin = new Padding(4, 4, 4, 4);
            EstadoCombo.Name = "EstadoCombo";
            EstadoCombo.Size = new Size(253, 33);
            EstadoCombo.TabIndex = 32;
            // 
            // GenerarOrdenButton
            // 
            GenerarOrdenButton.Location = new Point(852, 804);
            GenerarOrdenButton.Margin = new Padding(2);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(242, 38);
            GenerarOrdenButton.TabIndex = 43;
            GenerarOrdenButton.Text = "Generar Orden";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            // 
            // GenerarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 866);
            Controls.Add(GenerarOrdenButton);
            Controls.Add(label5);
            Controls.Add(EstadoCombo);
            Controls.Add(label4);
            Controls.Add(DescripcionClienteCombo);
            Controls.Add(label3);
            Controls.Add(PrioridadCombo);
            Controls.Add(GenerarOrdenSeleccionList);
            Controls.Add(GenerarOrdenSeleccionBuscarList);
            Controls.Add(BuscarButton);
            Controls.Add(VolverButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FechaOSPicker);
            Controls.Add(IdOrdenSeleccionCombo);
            Margin = new Padding(4, 4, 4, 4);
            Name = "GenerarOrdenSeleccionForm";
            Text = "GenerarOrdenSeleccionForm";
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
        private ColumnHeader FechaOEColumna;
        private ColumnHeader DescripcionProductoColumna;
        private ColumnHeader EstadoColumna;
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
        private ColumnHeader PrioridadColumna;
        private Button GenerarOrdenButton;
    }
}