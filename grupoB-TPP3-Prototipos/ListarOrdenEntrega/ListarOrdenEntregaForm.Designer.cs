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
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 33);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 48;
            label5.Text = "Estado";
            // 
            // EstadoCombo
            // 
            EstadoCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            EstadoCombo.FormattingEnabled = true;
            EstadoCombo.Location = new Point(295, 57);
            EstadoCombo.Name = "EstadoCombo";
            EstadoCombo.Size = new Size(545, 28);
            EstadoCombo.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 102);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 46;
            label4.Text = "ID Cliente";
            // 
            // IdClienteCombo
            // 
            IdClienteCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdClienteCombo.FormattingEnabled = true;
            IdClienteCombo.Location = new Point(11, 128);
            IdClienteCombo.Name = "IdClienteCombo";
            IdClienteCombo.Size = new Size(251, 28);
            IdClienteCombo.TabIndex = 45;
            // 
            // ListarOrdenEntregaList
            // 
            ListarOrdenEntregaList.Columns.AddRange(new ColumnHeader[] { IdOrdenEntregaColumna, FechaOEColumna, FechaEstadoOEColumna, Estado2Columna });
            ListarOrdenEntregaList.Location = new Point(12, 300);
            ListarOrdenEntregaList.Name = "ListarOrdenEntregaList";
            ListarOrdenEntregaList.Size = new Size(853, 245);
            ListarOrdenEntregaList.TabIndex = 41;
            ListarOrdenEntregaList.UseCompatibleStateImageBehavior = false;
            ListarOrdenEntregaList.View = View.Details;
            ListarOrdenEntregaList.SelectedIndexChanged += ListarOrdenEntregaList_SelectedIndexChanged;
            // 
            // IdOrdenEntregaColumna
            // 
            IdOrdenEntregaColumna.Text = "ID Orden Entrega";
            IdOrdenEntregaColumna.Width = 180;
            // 
            // FechaOEColumna
            // 
            FechaOEColumna.Text = "Fecha Emision";
            FechaOEColumna.Width = 180;
            // 
            // FechaEstadoOEColumna
            // 
            FechaEstadoOEColumna.Text = "Fecha Estado";
            FechaEstadoOEColumna.Width = 180;
            // 
            // Estado2Columna
            // 
            Estado2Columna.Text = "Estado";
            Estado2Columna.Width = 250;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(711, 180);
            BuscarButton.Margin = new Padding(1);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(129, 41);
            BuscarButton.TabIndex = 39;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click_1;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(730, 836);
            VolverButton.Margin = new Padding(1);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(129, 41);
            VolverButton.TabIndex = 38;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // FechaDesdeOELabel
            // 
            FechaDesdeOELabel.AutoSize = true;
            FechaDesdeOELabel.Location = new Point(295, 101);
            FechaDesdeOELabel.Name = "FechaDesdeOELabel";
            FechaDesdeOELabel.Size = new Size(91, 20);
            FechaDesdeOELabel.TabIndex = 37;
            FechaDesdeOELabel.Text = "Fecha desde";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 31);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 36;
            label1.Text = "ID Orden";
            // 
            // FechaDesdeOEPicker
            // 
            FechaDesdeOEPicker.Checked = false;
            FechaDesdeOEPicker.Location = new Point(295, 129);
            FechaDesdeOEPicker.Name = "FechaDesdeOEPicker";
            FechaDesdeOEPicker.ShowCheckBox = true;
            FechaDesdeOEPicker.Size = new Size(251, 27);
            FechaDesdeOEPicker.TabIndex = 35;
            FechaDesdeOEPicker.Value = new DateTime(2024, 10, 12, 13, 39, 11, 0);
            // 
            // IdOrdenCombo
            // 
            IdOrdenCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdOrdenCombo.FormattingEnabled = true;
            IdOrdenCombo.Location = new Point(11, 55);
            IdOrdenCombo.Name = "IdOrdenCombo";
            IdOrdenCombo.Size = new Size(251, 28);
            IdOrdenCombo.TabIndex = 34;
            // 
            // FechaHastaOELabel
            // 
            FechaHastaOELabel.AutoSize = true;
            FechaHastaOELabel.Location = new Point(589, 102);
            FechaHastaOELabel.Name = "FechaHastaOELabel";
            FechaHastaOELabel.Size = new Size(86, 20);
            FechaHastaOELabel.TabIndex = 52;
            FechaHastaOELabel.Text = "Fecha hasta";
            // 
            // FechaHastaOEPicker
            // 
            FechaHastaOEPicker.Checked = false;
            FechaHastaOEPicker.Location = new Point(589, 126);
            FechaHastaOEPicker.Name = "FechaHastaOEPicker";
            FechaHastaOEPicker.ShowCheckBox = true;
            FechaHastaOEPicker.Size = new Size(251, 27);
            FechaHastaOEPicker.TabIndex = 51;
            // 
            // DetalleOrdenesPreparacionList
            // 
            DetalleOrdenesPreparacionList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader4 });
            DetalleOrdenesPreparacionList.Location = new Point(12, 562);
            DetalleOrdenesPreparacionList.Name = "DetalleOrdenesPreparacionList";
            DetalleOrdenesPreparacionList.Size = new Size(853, 245);
            DetalleOrdenesPreparacionList.TabIndex = 53;
            DetalleOrdenesPreparacionList.UseCompatibleStateImageBehavior = false;
            DetalleOrdenesPreparacionList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID Orden Preparacion";
            columnHeader1.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado";
            columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fecha Estado";
            columnHeader4.Width = 180;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(307, 34);
            label2.TabIndex = 54;
            label2.Text = "Lista Ordenes Entrega";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FechaHastaOELabel);
            groupBox1.Controls.Add(FechaHastaOEPicker);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(EstadoCombo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(IdClienteCombo);
            groupBox1.Controls.Add(BuscarButton);
            groupBox1.Controls.Add(FechaDesdeOELabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FechaDesdeOEPicker);
            groupBox1.Controls.Add(IdOrdenCombo);
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(853, 238);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            // 
            // ListarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 897);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(DetalleOrdenesPreparacionList);
            Controls.Add(ListarOrdenEntregaList);
            Controls.Add(VolverButton);
            Name = "ListarOrdenEntregaForm";
            Text = "Listar Ordenes de Entrega";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Label label2;
        private GroupBox groupBox1;
    }
}