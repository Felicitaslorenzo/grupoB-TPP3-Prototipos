﻿namespace grupoB_TPP3_Prototipos.DespacharOrdenEntrega
{
    partial class DespacharOrdenEntregaForm
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
            GenerarOrdenDeDespachoButton = new Button();
            label3 = new Label();
            PrioridadCombo = new ComboBox();
            ListarOrdenDespacharBuscarList = new ListView();
            IdOrdenColumna = new ColumnHeader();
            IdClienteColumna = new ColumnHeader();
            FechaColumna = new ColumnHeader();
            EstadoColumna = new ColumnHeader();
            BuscarButton = new Button();
            VolverButton = new Button();
            label2 = new Label();
            label1 = new Label();
            FechaOSPicker = new DateTimePicker();
            IdOrdenEntregaCombo = new ComboBox();
            GenerarOrdenDespacharList = new ListView();
            IdOrden2Columna = new ColumnHeader();
            IdCliente2olumna = new ColumnHeader();
            Fecha2Columna = new ColumnHeader();
            Estado2Columna = new ColumnHeader();
            SuspendLayout();
            // 
            // GenerarOrdenDeDespachoButton
            // 
            GenerarOrdenDeDespachoButton.Location = new Point(564, 359);
            GenerarOrdenDeDespachoButton.Margin = new Padding(2);
            GenerarOrdenDeDespachoButton.Name = "GenerarOrdenDeDespachoButton";
            GenerarOrdenDeDespachoButton.Size = new Size(295, 30);
            GenerarOrdenDeDespachoButton.TabIndex = 81;
            GenerarOrdenDeDespachoButton.Text = "Generar Orden de Despacho";
            GenerarOrdenDeDespachoButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(656, 17);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 80;
            label3.Text = "Prioridad";
            // 
            // PrioridadCombo
            // 
            PrioridadCombo.FormattingEnabled = true;
            PrioridadCombo.Location = new Point(656, 40);
            PrioridadCombo.Name = "PrioridadCombo";
            PrioridadCombo.Size = new Size(203, 28);
            PrioridadCombo.TabIndex = 79;
            // 
            // ListarOrdenDespacharBuscarList
            // 
            ListarOrdenDespacharBuscarList.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, IdClienteColumna, FechaColumna, EstadoColumna });
            ListarOrdenDespacharBuscarList.Location = new Point(12, 144);
            ListarOrdenDespacharBuscarList.Name = "ListarOrdenDespacharBuscarList";
            ListarOrdenDespacharBuscarList.Size = new Size(847, 195);
            ListarOrdenDespacharBuscarList.TabIndex = 78;
            ListarOrdenDespacharBuscarList.UseCompatibleStateImageBehavior = false;
            ListarOrdenDespacharBuscarList.View = View.Details;
            // 
            // IdOrdenColumna
            // 
            IdOrdenColumna.Text = "ID Orden";
            IdOrdenColumna.Width = 150;
            // 
            // IdClienteColumna
            // 
            IdClienteColumna.Text = "ID Cliente";
            IdClienteColumna.Width = 100;
            // 
            // FechaColumna
            // 
            FechaColumna.Text = "Fecha";
            FechaColumna.Width = 100;
            // 
            // EstadoColumna
            // 
            EstadoColumna.Text = "Estado";
            EstadoColumna.Width = 100;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(557, 93);
            BuscarButton.Margin = new Padding(2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(128, 30);
            BuscarButton.TabIndex = 77;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(731, 93);
            VolverButton.Margin = new Padding(2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(128, 30);
            VolverButton.TabIndex = 76;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 15);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 75;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 74;
            label1.Text = "ID Orden Entrega";
            // 
            // FechaOSPicker
            // 
            FechaOSPicker.Location = new Point(310, 38);
            FechaOSPicker.Name = "FechaOSPicker";
            FechaOSPicker.Size = new Size(300, 27);
            FechaOSPicker.TabIndex = 73;
            // 
            // IdOrdenEntregaCombo
            // 
            IdOrdenEntregaCombo.FormattingEnabled = true;
            IdOrdenEntregaCombo.Location = new Point(12, 37);
            IdOrdenEntregaCombo.Name = "IdOrdenEntregaCombo";
            IdOrdenEntregaCombo.Size = new Size(250, 28);
            IdOrdenEntregaCombo.TabIndex = 72;
            // 
            // GenerarOrdenDespacharList
            // 
            GenerarOrdenDespacharList.Columns.AddRange(new ColumnHeader[] { IdOrden2Columna, IdCliente2olumna, Fecha2Columna, Estado2Columna });
            GenerarOrdenDespacharList.Location = new Point(12, 417);
            GenerarOrdenDespacharList.Name = "GenerarOrdenDespacharList";
            GenerarOrdenDespacharList.Size = new Size(847, 195);
            GenerarOrdenDespacharList.TabIndex = 82;
            GenerarOrdenDespacharList.UseCompatibleStateImageBehavior = false;
            GenerarOrdenDespacharList.View = View.Details;
            // 
            // IdOrden2Columna
            // 
            IdOrden2Columna.Text = "ID Orden";
            IdOrden2Columna.Width = 150;
            // 
            // IdCliente2olumna
            // 
            IdCliente2olumna.Text = "ID Cliente";
            IdCliente2olumna.Width = 100;
            // 
            // Fecha2Columna
            // 
            Fecha2Columna.Text = "Fecha";
            Fecha2Columna.Width = 100;
            // 
            // Estado2Columna
            // 
            Estado2Columna.Text = "Estado";
            Estado2Columna.Width = 100;
            // 
            // DespacharOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 638);
            Controls.Add(GenerarOrdenDespacharList);
            Controls.Add(GenerarOrdenDeDespachoButton);
            Controls.Add(label3);
            Controls.Add(PrioridadCombo);
            Controls.Add(ListarOrdenDespacharBuscarList);
            Controls.Add(BuscarButton);
            Controls.Add(VolverButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FechaOSPicker);
            Controls.Add(IdOrdenEntregaCombo);
            Name = "DespacharOrdenEntregaForm";
            Text = "DespacharOrdenEntregaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenerarOrdenDeDespachoButton;
        private Label label3;
        private ComboBox PrioridadCombo;
        private ListView ListarOrdenDespacharBuscarList;
        private ColumnHeader IdOrdenColumna;
        private ColumnHeader IdClienteColumna;
        private ColumnHeader FechaColumna;
        private ColumnHeader EstadoColumna;
        private Button BuscarButton;
        private Button VolverButton;
        private Label label2;
        private Label label1;
        private DateTimePicker FechaOSPicker;
        private ComboBox IdOrdenEntregaCombo;
        private ListView GenerarOrdenDespacharList;
        private ColumnHeader IdOrden2Columna;
        private ColumnHeader IdCliente2olumna;
        private ColumnHeader Fecha2Columna;
        private ColumnHeader Estado2Columna;
    }
}