namespace grupoB_TPP3_Prototipos.CrearOrdenEntrega
{
    partial class CrearOrdenEntregaForm
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
            EmpaquetarOrdenButton = new Button();
            label3 = new Label();
            PrioridadCombo = new ComboBox();
            GenerarOrdenEntregaList = new ListView();
            IdOrden2Columna = new ColumnHeader();
            IdCliente2Columna = new ColumnHeader();
            DescripcionProducto2Columna = new ColumnHeader();
            Cantidad2Columna = new ColumnHeader();
            Estado2Columna = new ColumnHeader();
            ListarOrdenEntregaBuscarList = new ListView();
            IdOrdenColumna = new ColumnHeader();
            IdClienteColumna = new ColumnHeader();
            DescripcionProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            EstadoColumna = new ColumnHeader();
            BuscarButton = new Button();
            VolverButton = new Button();
            label2 = new Label();
            label1 = new Label();
            FechaOSPicker = new DateTimePicker();
            IdOrdenSeleccionCombo = new ComboBox();
            GenerarOrdenDeEntregaButton = new Button();
            SuspendLayout();
            // 
            // EmpaquetarOrdenButton
            // 
            EmpaquetarOrdenButton.Location = new Point(676, 370);
            EmpaquetarOrdenButton.Margin = new Padding(2);
            EmpaquetarOrdenButton.Name = "EmpaquetarOrdenButton";
            EmpaquetarOrdenButton.Size = new Size(194, 30);
            EmpaquetarOrdenButton.TabIndex = 58;
            EmpaquetarOrdenButton.Text = "Empaquetar Orden";
            EmpaquetarOrdenButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(667, 28);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 53;
            label3.Text = "Prioridad";
            // 
            // PrioridadCombo
            // 
            PrioridadCombo.FormattingEnabled = true;
            PrioridadCombo.Location = new Point(667, 51);
            PrioridadCombo.Name = "PrioridadCombo";
            PrioridadCombo.Size = new Size(203, 28);
            PrioridadCombo.TabIndex = 52;
            // 
            // GenerarOrdenEntregaList
            // 
            GenerarOrdenEntregaList.Columns.AddRange(new ColumnHeader[] { IdOrden2Columna, IdCliente2Columna, DescripcionProducto2Columna, Cantidad2Columna, Estado2Columna });
            GenerarOrdenEntregaList.Location = new Point(23, 420);
            GenerarOrdenEntregaList.Name = "GenerarOrdenEntregaList";
            GenerarOrdenEntregaList.Size = new Size(847, 195);
            GenerarOrdenEntregaList.TabIndex = 51;
            GenerarOrdenEntregaList.UseCompatibleStateImageBehavior = false;
            GenerarOrdenEntregaList.View = View.Details;
            // 
            // IdOrden2Columna
            // 
            IdOrden2Columna.Text = "ID Orden";
            IdOrden2Columna.Width = 150;
            // 
            // IdCliente2Columna
            // 
            IdCliente2Columna.Text = "IdCliente";
            IdCliente2Columna.Width = 100;
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
            // Estado2Columna
            // 
            Estado2Columna.Text = "Estado";
            Estado2Columna.Width = 100;
            // 
            // ListarOrdenEntregaBuscarList
            // 
            ListarOrdenEntregaBuscarList.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, IdClienteColumna, DescripcionProductoColumna, CantidadColumna, EstadoColumna });
            ListarOrdenEntregaBuscarList.Location = new Point(23, 155);
            ListarOrdenEntregaBuscarList.Name = "ListarOrdenEntregaBuscarList";
            ListarOrdenEntregaBuscarList.Size = new Size(847, 195);
            ListarOrdenEntregaBuscarList.TabIndex = 50;
            ListarOrdenEntregaBuscarList.UseCompatibleStateImageBehavior = false;
            ListarOrdenEntregaBuscarList.View = View.Details;
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
            // DescripcionProductoColumna
            // 
            DescripcionProductoColumna.Text = "Descripción Producto";
            DescripcionProductoColumna.Width = 180;
            // 
            // CantidadColumna
            // 
            CantidadColumna.Text = "Cantidad";
            CantidadColumna.Width = 100;
            // 
            // EstadoColumna
            // 
            EstadoColumna.Text = "Estado";
            EstadoColumna.Width = 100;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(568, 104);
            BuscarButton.Margin = new Padding(2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(128, 30);
            BuscarButton.TabIndex = 49;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(742, 104);
            VolverButton.Margin = new Padding(2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(128, 30);
            VolverButton.TabIndex = 48;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 26);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 47;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 46;
            label1.Text = "ID Orden Preparación";
            // 
            // FechaOSPicker
            // 
            FechaOSPicker.Location = new Point(321, 49);
            FechaOSPicker.Name = "FechaOSPicker";
            FechaOSPicker.Size = new Size(300, 27);
            FechaOSPicker.TabIndex = 45;
            // 
            // IdOrdenSeleccionCombo
            // 
            IdOrdenSeleccionCombo.FormattingEnabled = true;
            IdOrdenSeleccionCombo.Location = new Point(23, 48);
            IdOrdenSeleccionCombo.Name = "IdOrdenSeleccionCombo";
            IdOrdenSeleccionCombo.Size = new Size(250, 28);
            IdOrdenSeleccionCombo.TabIndex = 44;
            // 
            // GenerarOrdenDeEntregaButton
            // 
            GenerarOrdenDeEntregaButton.Location = new Point(676, 638);
            GenerarOrdenDeEntregaButton.Margin = new Padding(2);
            GenerarOrdenDeEntregaButton.Name = "GenerarOrdenDeEntregaButton";
            GenerarOrdenDeEntregaButton.Size = new Size(194, 30);
            GenerarOrdenDeEntregaButton.TabIndex = 59;
            GenerarOrdenDeEntregaButton.Text = "Generar Orden de Entrega";
            GenerarOrdenDeEntregaButton.UseVisualStyleBackColor = true;
            // 
            // CrearOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 680);
            Controls.Add(GenerarOrdenDeEntregaButton);
            Controls.Add(EmpaquetarOrdenButton);
            Controls.Add(label3);
            Controls.Add(PrioridadCombo);
            Controls.Add(GenerarOrdenEntregaList);
            Controls.Add(ListarOrdenEntregaBuscarList);
            Controls.Add(BuscarButton);
            Controls.Add(VolverButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FechaOSPicker);
            Controls.Add(IdOrdenSeleccionCombo);
            Name = "CrearOrdenEntregaForm";
            Text = "CrearOrdenEntregaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EmpaquetarOrdenButton;
        private Label label3;
        private ComboBox PrioridadCombo;
        private ListView GenerarOrdenEntregaList;
        private ColumnHeader IdOrden2Columna;
        private ColumnHeader IdCliente2Columna;
        private ColumnHeader DescripcionProducto2Columna;
        private ColumnHeader Cantidad2Columna;
        private ColumnHeader Estado2Columna;
        private ListView ListarOrdenEntregaBuscarList;
        private ColumnHeader IdOrdenColumna;
        private ColumnHeader IdClienteColumna;
        private ColumnHeader DescripcionProductoColumna;
        private ColumnHeader EstadoColumna;
        private ColumnHeader CantidadColumna;
        private Button BuscarButton;
        private Button VolverButton;
        private Label label2;
        private Label label1;
        private DateTimePicker FechaOSPicker;
        private ComboBox IdOrdenSeleccionCombo;
        private ColumnHeader IdOrdenSeleccionColumna;
        private Button GenerarOrdenDeEntregaButton;
    }
}