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
            CrearOrdenEntregaList = new ListView();
            IdOrden2Columna = new ColumnHeader();
            IdCliente2Columna = new ColumnHeader();
            DescripcionProducto2Columna = new ColumnHeader();
            Cantidad2Columna = new ColumnHeader();
            Estado2Columna = new ColumnHeader();
            ListarEmpaquetarOrdenList = new ListView();
            IdOrdenColumna = new ColumnHeader();
            IdClienteColumna = new ColumnHeader();
            DescripcionProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            EstadoColumna = new ColumnHeader();
            BuscarButton = new Button();
            VolverButton = new Button();
            label2 = new Label();
            IdOrdenlabel = new Label();
            FechaOEPicker = new DateTimePicker();
            IdOrdenSeleccionCombo = new ComboBox();
            GenerarOrdenDeEntregaButton = new Button();
            SuspendLayout();
            // 
            // EmpaquetarOrdenButton
            // 
            EmpaquetarOrdenButton.Location = new Point(845, 462);
            EmpaquetarOrdenButton.Margin = new Padding(2);
            EmpaquetarOrdenButton.Name = "EmpaquetarOrdenButton";
            EmpaquetarOrdenButton.Size = new Size(242, 38);
            EmpaquetarOrdenButton.TabIndex = 58;
            EmpaquetarOrdenButton.Text = "Empaquetar Orden";
            EmpaquetarOrdenButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(834, 35);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 53;
            label3.Text = "Prioridad";
            // 
            // PrioridadCombo
            // 
            PrioridadCombo.FormattingEnabled = true;
            PrioridadCombo.Location = new Point(834, 64);
            PrioridadCombo.Margin = new Padding(4, 4, 4, 4);
            PrioridadCombo.Name = "PrioridadCombo";
            PrioridadCombo.Size = new Size(253, 33);
            PrioridadCombo.TabIndex = 52;
            // 
            // CrearOrdenEntregaList
            // 
            CrearOrdenEntregaList.Columns.AddRange(new ColumnHeader[] { IdOrden2Columna, IdCliente2Columna, DescripcionProducto2Columna, Cantidad2Columna, Estado2Columna });
            CrearOrdenEntregaList.Location = new Point(29, 525);
            CrearOrdenEntregaList.Margin = new Padding(4, 4, 4, 4);
            CrearOrdenEntregaList.Name = "CrearOrdenEntregaList";
            CrearOrdenEntregaList.Size = new Size(1058, 243);
            CrearOrdenEntregaList.TabIndex = 51;
            CrearOrdenEntregaList.UseCompatibleStateImageBehavior = false;
            CrearOrdenEntregaList.View = View.Details;
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
            // ListarEmpaquetarOrdenList
            // 
            ListarEmpaquetarOrdenList.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, IdClienteColumna, DescripcionProductoColumna, CantidadColumna, EstadoColumna });
            ListarEmpaquetarOrdenList.Location = new Point(29, 194);
            ListarEmpaquetarOrdenList.Margin = new Padding(4, 4, 4, 4);
            ListarEmpaquetarOrdenList.Name = "ListarEmpaquetarOrdenList";
            ListarEmpaquetarOrdenList.Size = new Size(1058, 243);
            ListarEmpaquetarOrdenList.TabIndex = 50;
            ListarEmpaquetarOrdenList.UseCompatibleStateImageBehavior = false;
            ListarEmpaquetarOrdenList.View = View.Details;
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
            BuscarButton.Location = new Point(916, 130);
            BuscarButton.Margin = new Padding(2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(160, 38);
            BuscarButton.TabIndex = 49;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(662, 798);
            VolverButton.Margin = new Padding(2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(160, 38);
            VolverButton.TabIndex = 48;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 47;
            label2.Text = "Fecha";
            // 
            // IdOrdenlabel
            // 
            IdOrdenlabel.AutoSize = true;
            IdOrdenlabel.Location = new Point(29, 30);
            IdOrdenlabel.Margin = new Padding(4, 0, 4, 0);
            IdOrdenlabel.Name = "IdOrdenlabel";
            IdOrdenlabel.Size = new Size(85, 25);
            IdOrdenlabel.TabIndex = 46;
            IdOrdenlabel.Text = "ID Orden";
            // 
            // FechaOEPicker
            // 
            FechaOEPicker.Location = new Point(401, 61);
            FechaOEPicker.Margin = new Padding(4, 4, 4, 4);
            FechaOEPicker.Name = "FechaOEPicker";
            FechaOEPicker.Size = new Size(374, 31);
            FechaOEPicker.TabIndex = 45;
            // 
            // IdOrdenSeleccionCombo
            // 
            IdOrdenSeleccionCombo.FormattingEnabled = true;
            IdOrdenSeleccionCombo.Location = new Point(29, 60);
            IdOrdenSeleccionCombo.Margin = new Padding(4, 4, 4, 4);
            IdOrdenSeleccionCombo.Name = "IdOrdenSeleccionCombo";
            IdOrdenSeleccionCombo.Size = new Size(312, 33);
            IdOrdenSeleccionCombo.TabIndex = 44;
            // 
            // GenerarOrdenDeEntregaButton
            // 
            GenerarOrdenDeEntregaButton.Location = new Point(845, 798);
            GenerarOrdenDeEntregaButton.Margin = new Padding(2);
            GenerarOrdenDeEntregaButton.Name = "GenerarOrdenDeEntregaButton";
            GenerarOrdenDeEntregaButton.Size = new Size(242, 38);
            GenerarOrdenDeEntregaButton.TabIndex = 59;
            GenerarOrdenDeEntregaButton.Text = "Generar Orden de Entrega";
            GenerarOrdenDeEntregaButton.UseVisualStyleBackColor = true;
            // 
            // CrearOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 850);
            Controls.Add(GenerarOrdenDeEntregaButton);
            Controls.Add(EmpaquetarOrdenButton);
            Controls.Add(label3);
            Controls.Add(PrioridadCombo);
            Controls.Add(CrearOrdenEntregaList);
            Controls.Add(ListarEmpaquetarOrdenList);
            Controls.Add(BuscarButton);
            Controls.Add(VolverButton);
            Controls.Add(label2);
            Controls.Add(IdOrdenlabel);
            Controls.Add(FechaOEPicker);
            Controls.Add(IdOrdenSeleccionCombo);
            Margin = new Padding(4, 4, 4, 4);
            Name = "CrearOrdenEntregaForm";
            Text = "CrearOrdenEntregaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EmpaquetarOrdenButton;
        private Label label3;
        private ComboBox PrioridadCombo;
        private ListView CrearOrdenEntregaList;
        private ColumnHeader IdOrden2Columna;
        private ColumnHeader IdCliente2Columna;
        private ColumnHeader DescripcionProducto2Columna;
        private ColumnHeader Cantidad2Columna;
        private ColumnHeader Estado2Columna;
        private ListView ListarEmpaquetarOrdenList;
        private ColumnHeader IdOrdenColumna;
        private ColumnHeader IdClienteColumna;
        private ColumnHeader DescripcionProductoColumna;
        private ColumnHeader EstadoColumna;
        private ColumnHeader CantidadColumna;
        private Button BuscarButton;
        private Button VolverButton;
        private Label label2;
        private Label IdOrdenlabel;
        private DateTimePicker FechaOEPicker;
        private ComboBox IdOrdenSeleccionCombo;
        private ColumnHeader IdOrdenSeleccionColumna;
        private Button GenerarOrdenDeEntregaButton;
    }
}