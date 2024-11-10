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
            ListarOrdenEntregaList = new ListView();
            IdOrdenEntregaColumna = new ColumnHeader();
            FechaOEColumna = new ColumnHeader();
            FechaEstadoOEColumna = new ColumnHeader();
            Estado2Columna = new ColumnHeader();
            BuscarButton = new Button();
            VolverButton = new Button();
            FechaDesdeOELabel = new Label();
            label1 = new Label();
            FechaDesdeOEPicker = new DateTimePicker();
            IdOrdenCombo = new ComboBox();
            FechaHastaOELabel = new Label();
            FechaHastaOEPicker = new DateTimePicker();
            DetalleOrdenesPreparacionList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 27);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 48;
            label5.Text = "Estado";
            // 
            // EstadoCombo
            // 
            EstadoCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            EstadoCombo.FormattingEnabled = true;
            EstadoCombo.Location = new Point(309, 51);
            EstadoCombo.Name = "EstadoCombo";
            EstadoCombo.Size = new Size(564, 28);
            EstadoCombo.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 96);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 46;
            label4.Text = "ID Cliente";
            // 
            // IdClienteCombo
            // 
            IdClienteCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdClienteCombo.FormattingEnabled = true;
            IdClienteCombo.Location = new Point(25, 119);
            IdClienteCombo.Name = "IdClienteCombo";
            IdClienteCombo.Size = new Size(251, 28);
            IdClienteCombo.TabIndex = 45;
            // 
            // ListarOrdenEntregaList
            // 
            ListarOrdenEntregaList.Columns.AddRange(new ColumnHeader[] { IdOrdenEntregaColumna, FechaOEColumna, FechaEstadoOEColumna, Estado2Columna });
            ListarOrdenEntregaList.Location = new Point(25, 247);
            ListarOrdenEntregaList.Name = "ListarOrdenEntregaList";
            ListarOrdenEntregaList.Size = new Size(847, 245);
            ListarOrdenEntregaList.TabIndex = 41;
            ListarOrdenEntregaList.UseCompatibleStateImageBehavior = false;
            ListarOrdenEntregaList.View = View.Details;
            ListarOrdenEntregaList.SelectedIndexChanged += ListarOrdenEntregaList_SelectedIndexChanged;
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
            // FechaEstadoOEColumna
            // 
            FechaEstadoOEColumna.Text = "Fecha Estado";
            FechaEstadoOEColumna.Width = 170;
            // 
            // Estado2Columna
            // 
            Estado2Columna.Text = "Estado";
            Estado2Columna.Width = 100;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(743, 184);
            BuscarButton.Margin = new Padding(1);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(128, 31);
            BuscarButton.TabIndex = 39;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click_1;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(743, 796);
            VolverButton.Margin = new Padding(1);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(128, 31);
            VolverButton.TabIndex = 38;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // FechaDesdeOELabel
            // 
            FechaDesdeOELabel.AutoSize = true;
            FechaDesdeOELabel.Location = new Point(309, 95);
            FechaDesdeOELabel.Name = "FechaDesdeOELabel";
            FechaDesdeOELabel.Size = new Size(91, 20);
            FechaDesdeOELabel.TabIndex = 37;
            FechaDesdeOELabel.Text = "Fecha desde";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 36;
            label1.Text = "ID Orden";
            // 
            // FechaDesdeOEPicker
            // 
            FechaDesdeOEPicker.Checked = false;
            FechaDesdeOEPicker.Location = new Point(309, 119);
            FechaDesdeOEPicker.Name = "FechaDesdeOEPicker";
            FechaDesdeOEPicker.ShowCheckBox = true;
            FechaDesdeOEPicker.Size = new Size(268, 27);
            FechaDesdeOEPicker.TabIndex = 35;
            FechaDesdeOEPicker.Value = new DateTime(2024, 10, 12, 13, 39, 11, 0);
            // 
            // IdOrdenCombo
            // 
            IdOrdenCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdOrdenCombo.FormattingEnabled = true;
            IdOrdenCombo.Location = new Point(25, 49);
            IdOrdenCombo.Name = "IdOrdenCombo";
            IdOrdenCombo.Size = new Size(251, 28);
            IdOrdenCombo.TabIndex = 34;
            // 
            // FechaHastaOELabel
            // 
            FechaHastaOELabel.AutoSize = true;
            FechaHastaOELabel.Location = new Point(603, 96);
            FechaHastaOELabel.Name = "FechaHastaOELabel";
            FechaHastaOELabel.Size = new Size(86, 20);
            FechaHastaOELabel.TabIndex = 52;
            FechaHastaOELabel.Text = "Fecha hasta";
            // 
            // FechaHastaOEPicker
            // 
            FechaHastaOEPicker.Checked = false;
            FechaHastaOEPicker.Location = new Point(603, 120);
            FechaHastaOEPicker.Name = "FechaHastaOEPicker";
            FechaHastaOEPicker.ShowCheckBox = true;
            FechaHastaOEPicker.Size = new Size(269, 27);
            FechaHastaOEPicker.TabIndex = 51;
            // 
            // DetalleOrdenesPreparacionList
            // 
            DetalleOrdenesPreparacionList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader4 });
            DetalleOrdenesPreparacionList.Location = new Point(23, 525);
            DetalleOrdenesPreparacionList.Name = "DetalleOrdenesPreparacionList";
            DetalleOrdenesPreparacionList.Size = new Size(847, 245);
            DetalleOrdenesPreparacionList.TabIndex = 53;
            DetalleOrdenesPreparacionList.UseCompatibleStateImageBehavior = false;
            DetalleOrdenesPreparacionList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID Orden Preparacion";
            columnHeader1.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fecha Estado";
            columnHeader4.Width = 170;
            // 
            // ListarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 855);
            Controls.Add(DetalleOrdenesPreparacionList);
            Controls.Add(FechaHastaOELabel);
            Controls.Add(FechaHastaOEPicker);
            Controls.Add(label5);
            Controls.Add(EstadoCombo);
            Controls.Add(label4);
            Controls.Add(IdClienteCombo);
            Controls.Add(ListarOrdenEntregaList);
            Controls.Add(BuscarButton);
            Controls.Add(VolverButton);
            Controls.Add(FechaDesdeOELabel);
            Controls.Add(label1);
            Controls.Add(FechaDesdeOEPicker);
            Controls.Add(IdOrdenCombo);
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
        private ListView DetalleOrdenesPreparacionList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}