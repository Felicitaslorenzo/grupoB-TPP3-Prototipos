namespace grupoB_TPP3_Prototipos.DespacharOrdenEntrega
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
            ListarOrdenDespacharBuscarList = new ListView();
            IdOrdenColumna = new ColumnHeader();
            IdClienteColumna = new ColumnHeader();
            FechaColumna = new ColumnHeader();
            EstadoColumna = new ColumnHeader();
            BuscarButton = new Button();
            VolverButton = new Button();
            TransportistaLabel = new Label();
            IdOrdenEntregaCombo = new ComboBox();
            SuspendLayout();
            // 
            // GenerarOrdenDeDespachoButton
            // 
            GenerarOrdenDeDespachoButton.Location = new Point(798, 390);
            GenerarOrdenDeDespachoButton.Margin = new Padding(2);
            GenerarOrdenDeDespachoButton.Name = "GenerarOrdenDeDespachoButton";
            GenerarOrdenDeDespachoButton.Size = new Size(275, 52);
            GenerarOrdenDeDespachoButton.TabIndex = 81;
            GenerarOrdenDeDespachoButton.Text = "Generar Orden de Despacho";
            GenerarOrdenDeDespachoButton.UseVisualStyleBackColor = true;
            // 
            // ListarOrdenDespacharBuscarList
            // 
            ListarOrdenDespacharBuscarList.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, IdClienteColumna, FechaColumna, EstadoColumna });
            ListarOrdenDespacharBuscarList.Location = new Point(15, 116);
            ListarOrdenDespacharBuscarList.Margin = new Padding(4);
            ListarOrdenDespacharBuscarList.Name = "ListarOrdenDespacharBuscarList";
            ListarOrdenDespacharBuscarList.Size = new Size(1058, 243);
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
            BuscarButton.Location = new Point(401, 45);
            BuscarButton.Margin = new Padding(2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(160, 38);
            BuscarButton.TabIndex = 77;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(610, 390);
            VolverButton.Margin = new Padding(2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(160, 52);
            VolverButton.TabIndex = 76;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // TransportistaLabel
            // 
            TransportistaLabel.AutoSize = true;
            TransportistaLabel.Location = new Point(15, 16);
            TransportistaLabel.Margin = new Padding(4, 0, 4, 0);
            TransportistaLabel.Name = "TransportistaLabel";
            TransportistaLabel.Size = new Size(113, 25);
            TransportistaLabel.TabIndex = 74;
            TransportistaLabel.Text = "Transportista";
            // 
            // IdOrdenEntregaCombo
            // 
            IdOrdenEntregaCombo.FormattingEnabled = true;
            IdOrdenEntregaCombo.Location = new Point(15, 45);
            IdOrdenEntregaCombo.Margin = new Padding(4);
            IdOrdenEntregaCombo.Name = "IdOrdenEntregaCombo";
            IdOrdenEntregaCombo.Size = new Size(312, 33);
            IdOrdenEntregaCombo.TabIndex = 72;
            // 
            // DespacharOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 481);
            Controls.Add(GenerarOrdenDeDespachoButton);
            Controls.Add(ListarOrdenDespacharBuscarList);
            Controls.Add(BuscarButton);
            Controls.Add(VolverButton);
            Controls.Add(TransportistaLabel);
            Controls.Add(IdOrdenEntregaCombo);
            Margin = new Padding(4);
            Name = "DespacharOrdenEntregaForm";
            Text = "DespacharOrdenEntregaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenerarOrdenDeDespachoButton;
        private ListView ListarOrdenDespacharBuscarList;
        private ColumnHeader IdOrdenColumna;
        private ColumnHeader IdClienteColumna;
        private ColumnHeader FechaColumna;
        private ColumnHeader EstadoColumna;
        private Button BuscarButton;
        private Button VolverButton;
        private Label TransportistaLabel;
        private ComboBox IdOrdenEntregaCombo;
    }
}