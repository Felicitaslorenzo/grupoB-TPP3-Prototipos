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
            label2 = new Label();
            label1 = new Label();
            FechaOEPicker = new DateTimePicker();
            IdOrdenCombo = new ComboBox();
            label6 = new Label();
            UbicacionCombo = new ComboBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 120);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 48;
            label5.Text = "Estado";
            // 
            // EstadoCombo
            // 
            EstadoCombo.FormattingEnabled = true;
            EstadoCombo.Location = new Point(405, 149);
            EstadoCombo.Margin = new Padding(4, 4, 4, 4);
            EstadoCombo.Name = "EstadoCombo";
            EstadoCombo.Size = new Size(269, 33);
            EstadoCombo.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 120);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 46;
            label4.Text = "ID Cliente";
            // 
            // IdClienteCombo
            // 
            IdClienteCombo.FormattingEnabled = true;
            IdClienteCombo.Location = new Point(32, 149);
            IdClienteCombo.Margin = new Padding(4, 4, 4, 4);
            IdClienteCombo.Name = "IdClienteCombo";
            IdClienteCombo.Size = new Size(312, 33);
            IdClienteCombo.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(821, 35);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 44;
            label3.Text = "Prioridad";
            // 
            // PrioridadCombo
            // 
            PrioridadCombo.FormattingEnabled = true;
            PrioridadCombo.Location = new Point(821, 66);
            PrioridadCombo.Margin = new Padding(4, 4, 4, 4);
            PrioridadCombo.Name = "PrioridadCombo";
            PrioridadCombo.Size = new Size(269, 33);
            PrioridadCombo.TabIndex = 43;
            // 
            // ListarOrdenEntregaBuscarList
            // 
            ListarOrdenEntregaBuscarList.Columns.AddRange(new ColumnHeader[] { IdOrdenEntregaColumna, FechaOEColumna, DescripcionProducto2Columna, Cantidad2Columna, Ubicacion2Columna, Estado2Columna });
            ListarOrdenEntregaBuscarList.Location = new Point(32, 308);
            ListarOrdenEntregaBuscarList.Margin = new Padding(4, 4, 4, 4);
            ListarOrdenEntregaBuscarList.Name = "ListarOrdenEntregaBuscarList";
            ListarOrdenEntregaBuscarList.Size = new Size(1058, 305);
            ListarOrdenEntregaBuscarList.TabIndex = 41;
            ListarOrdenEntregaBuscarList.UseCompatibleStateImageBehavior = false;
            ListarOrdenEntregaBuscarList.View = View.Details;
            // 
            // IdOrdenEntregaColumna
            // 
            IdOrdenEntregaColumna.Text = "ID Orden Entrega";
            IdOrdenEntregaColumna.Width = 150;
            // 
            // FechaOEColumna
            // 
            FechaOEColumna.Text = "Fecha";
            FechaOEColumna.Width = 100;
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
            // BuscarButton
            // 
            BuscarButton.Location = new Point(884, 237);
            BuscarButton.Margin = new Padding(2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(160, 38);
            BuscarButton.TabIndex = 39;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(884, 643);
            VolverButton.Margin = new Padding(2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(160, 38);
            VolverButton.TabIndex = 38;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 35);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 37;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 36;
            label1.Text = "ID Orden";
            // 
            // FechaOEPicker
            // 
            FechaOEPicker.Location = new Point(405, 64);
            FechaOEPicker.Margin = new Padding(4, 4, 4, 4);
            FechaOEPicker.Name = "FechaOEPicker";
            FechaOEPicker.Size = new Size(365, 31);
            FechaOEPicker.TabIndex = 35;
            // 
            // IdOrdenCombo
            // 
            IdOrdenCombo.FormattingEnabled = true;
            IdOrdenCombo.Location = new Point(32, 62);
            IdOrdenCombo.Margin = new Padding(4, 4, 4, 4);
            IdOrdenCombo.Name = "IdOrdenCombo";
            IdOrdenCombo.Size = new Size(312, 33);
            IdOrdenCombo.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(730, 118);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 50;
            label6.Text = "Ubicación";
            // 
            // UbicacionCombo
            // 
            UbicacionCombo.FormattingEnabled = true;
            UbicacionCombo.Location = new Point(730, 149);
            UbicacionCombo.Margin = new Padding(4, 4, 4, 4);
            UbicacionCombo.Name = "UbicacionCombo";
            UbicacionCombo.Size = new Size(269, 33);
            UbicacionCombo.TabIndex = 49;
            // 
            // ListarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 718);
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
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FechaOEPicker);
            Controls.Add(IdOrdenCombo);
            Margin = new Padding(4, 4, 4, 4);
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
        private ColumnHeader IdOrdenEntregaColumna;
        private ColumnHeader FechaOEColumna;
        private ColumnHeader DescripcionProducto2Columna;
        private ColumnHeader Cantidad2Columna;
        private ColumnHeader Ubicacion2Columna;
        private ColumnHeader Estado2Columna;
        private Button BuscarButton;
        private Button VolverButton;
        private Label label2;
        private Label label1;
        private DateTimePicker FechaOEPicker;
        private ComboBox IdOrdenCombo;
        private Label label6;
        private ComboBox UbicacionCombo;
    }
}