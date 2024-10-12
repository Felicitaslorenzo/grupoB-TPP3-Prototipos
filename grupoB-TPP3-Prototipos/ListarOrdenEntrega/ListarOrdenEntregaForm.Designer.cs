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
            ListarOrdenEntregaList = new ListView();
            IdOrdenEntregaColumna = new ColumnHeader();
            FechaOEColumna = new ColumnHeader();
            Estado2Columna = new ColumnHeader();
            FechaEstadoOEColumna = new ColumnHeader();
            BuscarButton = new Button();
            VolverButton = new Button();
            FechaDesdeOELabel = new Label();
            label1 = new Label();
            FechaDesdeOEPicker = new DateTimePicker();
            IdOrdenCombo = new ComboBox();
            FechaHastaOELabel = new Label();
            FechaHastaOEPicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(385, 34);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 48;
            label5.Text = "Estado";
            // 
            // EstadoCombo
            // 
            EstadoCombo.FormattingEnabled = true;
            EstadoCombo.Location = new Point(385, 63);
            EstadoCombo.Margin = new Padding(4);
            EstadoCombo.Name = "EstadoCombo";
            EstadoCombo.Size = new Size(334, 33);
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
            IdClienteCombo.Margin = new Padding(4);
            IdClienteCombo.Name = "IdClienteCombo";
            IdClienteCombo.Size = new Size(312, 33);
            IdClienteCombo.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(755, 35);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 44;
            label3.Text = "Prioridad";
            // 
            // PrioridadCombo
            // 
            PrioridadCombo.FormattingEnabled = true;
            PrioridadCombo.Location = new Point(755, 66);
            PrioridadCombo.Margin = new Padding(4);
            PrioridadCombo.Name = "PrioridadCombo";
            PrioridadCombo.Size = new Size(335, 33);
            PrioridadCombo.TabIndex = 43;
            // 
            // ListarOrdenEntregaList
            // 
            ListarOrdenEntregaList.Columns.AddRange(new ColumnHeader[] { IdOrdenEntregaColumna, FechaOEColumna, Estado2Columna, FechaEstadoOEColumna });
            ListarOrdenEntregaList.Location = new Point(32, 308);
            ListarOrdenEntregaList.Margin = new Padding(4);
            ListarOrdenEntregaList.Name = "ListarOrdenEntregaList";
            ListarOrdenEntregaList.Size = new Size(1058, 305);
            ListarOrdenEntregaList.TabIndex = 41;
            ListarOrdenEntregaList.UseCompatibleStateImageBehavior = false;
            ListarOrdenEntregaList.View = View.Details;
            // 
            // IdOrdenEntregaColumna
            // 
            IdOrdenEntregaColumna.Text = "ID Orden Entrega";
            IdOrdenEntregaColumna.Width = 200;
            // 
            // FechaOEColumna
            // 
            FechaOEColumna.Text = "Fecha Emision";
            FechaOEColumna.Width = 170;
            // 
            // Estado2Columna
            // 
            Estado2Columna.Text = "Estado";
            Estado2Columna.Width = 100;
            // 
            // FechaEstadoOEColumna
            // 
            FechaEstadoOEColumna.Text = "Fecha Estado";
            FechaEstadoOEColumna.Width = 170;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(928, 230);
            BuscarButton.Margin = new Padding(2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(160, 38);
            BuscarButton.TabIndex = 39;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(929, 645);
            VolverButton.Margin = new Padding(2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(160, 38);
            VolverButton.TabIndex = 38;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // FechaDesdeOELabel
            // 
            FechaDesdeOELabel.AutoSize = true;
            FechaDesdeOELabel.Location = new Point(385, 119);
            FechaDesdeOELabel.Margin = new Padding(4, 0, 4, 0);
            FechaDesdeOELabel.Name = "FechaDesdeOELabel";
            FechaDesdeOELabel.Size = new Size(110, 25);
            FechaDesdeOELabel.TabIndex = 37;
            FechaDesdeOELabel.Text = "Fecha desde";
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
            // FechaDesdeOEPicker
            // 
            FechaDesdeOEPicker.Checked = false;
            FechaDesdeOEPicker.Location = new Point(385, 148);
            FechaDesdeOEPicker.Margin = new Padding(4);
            FechaDesdeOEPicker.Name = "FechaDesdeOEPicker";
            FechaDesdeOEPicker.ShowCheckBox = true;
            FechaDesdeOEPicker.Size = new Size(334, 31);
            FechaDesdeOEPicker.TabIndex = 35;
            FechaDesdeOEPicker.Value = new DateTime(2024, 10, 12, 13, 39, 11, 0);
            // 
            // IdOrdenCombo
            // 
            IdOrdenCombo.FormattingEnabled = true;
            IdOrdenCombo.Location = new Point(32, 62);
            IdOrdenCombo.Margin = new Padding(4);
            IdOrdenCombo.Name = "IdOrdenCombo";
            IdOrdenCombo.Size = new Size(312, 33);
            IdOrdenCombo.TabIndex = 34;
            // 
            // FechaHastaOELabel
            // 
            FechaHastaOELabel.AutoSize = true;
            FechaHastaOELabel.Location = new Point(755, 120);
            FechaHastaOELabel.Margin = new Padding(4, 0, 4, 0);
            FechaHastaOELabel.Name = "FechaHastaOELabel";
            FechaHastaOELabel.Size = new Size(104, 25);
            FechaHastaOELabel.TabIndex = 52;
            FechaHastaOELabel.Text = "Fecha hasta";
            // 
            // FechaHastaOEPicker
            // 
            FechaHastaOEPicker.Checked = false;
            FechaHastaOEPicker.Location = new Point(755, 150);
            FechaHastaOEPicker.Margin = new Padding(4);
            FechaHastaOEPicker.Name = "FechaHastaOEPicker";
            FechaHastaOEPicker.ShowCheckBox = true;
            FechaHastaOEPicker.Size = new Size(335, 31);
            FechaHastaOEPicker.TabIndex = 51;
            // 
            // ListarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 718);
            Controls.Add(FechaHastaOELabel);
            Controls.Add(FechaHastaOEPicker);
            Controls.Add(label5);
            Controls.Add(EstadoCombo);
            Controls.Add(label4);
            Controls.Add(IdClienteCombo);
            Controls.Add(label3);
            Controls.Add(PrioridadCombo);
            Controls.Add(ListarOrdenEntregaList);
            Controls.Add(BuscarButton);
            Controls.Add(VolverButton);
            Controls.Add(FechaDesdeOELabel);
            Controls.Add(label1);
            Controls.Add(FechaDesdeOEPicker);
            Controls.Add(IdOrdenCombo);
            Margin = new Padding(4);
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
        private ListView ListarOrdenEntregaList;
        private ColumnHeader IdOrdenEntregaColumna;
        private ColumnHeader FechaOEColumna;
        private ColumnHeader Estado2Columna;
        private Button BuscarButton;
        private Button VolverButton;
        private Label FechaDesdeOELabel;
        private Label label1;
        private DateTimePicker FechaDesdeOEPicker;
        private ComboBox IdOrdenCombo;
        private Label FechaHastaOELabel;
        private DateTimePicker FechaHastaOEPicker;
        private ColumnHeader FechaEstadoOEColumna;
    }
}