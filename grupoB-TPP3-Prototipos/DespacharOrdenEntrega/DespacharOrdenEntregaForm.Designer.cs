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
            BuscarButton = new Button();
            VolverButton = new Button();
            TransportistaLabel = new Label();
            IdOrdenEntregaCombo = new ComboBox();
            SuspendLayout();
            // 
            // GenerarOrdenDeDespachoButton
            // 
            GenerarOrdenDeDespachoButton.Location = new Point(431, 234);
            GenerarOrdenDeDespachoButton.Margin = new Padding(1, 1, 1, 1);
            GenerarOrdenDeDespachoButton.Name = "GenerarOrdenDeDespachoButton";
            GenerarOrdenDeDespachoButton.Size = new Size(192, 31);
            GenerarOrdenDeDespachoButton.TabIndex = 81;
            GenerarOrdenDeDespachoButton.Text = "Generar Orden de Despacho";
            GenerarOrdenDeDespachoButton.UseVisualStyleBackColor = true;
            // 
            // ListarOrdenDespacharBuscarList
            // 
            ListarOrdenDespacharBuscarList.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, IdClienteColumna });
            ListarOrdenDespacharBuscarList.Location = new Point(10, 70);
            ListarOrdenDespacharBuscarList.Margin = new Padding(3, 2, 3, 2);
            ListarOrdenDespacharBuscarList.Name = "ListarOrdenDespacharBuscarList";
            ListarOrdenDespacharBuscarList.Size = new Size(742, 147);
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
            // BuscarButton
            // 
            BuscarButton.Location = new Point(281, 27);
            BuscarButton.Margin = new Padding(1, 1, 1, 1);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(112, 23);
            BuscarButton.TabIndex = 77;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(639, 234);
            VolverButton.Margin = new Padding(1, 1, 1, 1);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(112, 31);
            VolverButton.TabIndex = 76;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // TransportistaLabel
            // 
            TransportistaLabel.AutoSize = true;
            TransportistaLabel.Location = new Point(10, 10);
            TransportistaLabel.Name = "TransportistaLabel";
            TransportistaLabel.Size = new Size(74, 15);
            TransportistaLabel.TabIndex = 74;
            TransportistaLabel.Text = "Transportista";
            // 
            // IdOrdenEntregaCombo
            // 
            IdOrdenEntregaCombo.FormattingEnabled = true;
            IdOrdenEntregaCombo.Location = new Point(12, 28);
            IdOrdenEntregaCombo.Margin = new Padding(3, 2, 3, 2);
            IdOrdenEntregaCombo.Name = "IdOrdenEntregaCombo";
            IdOrdenEntregaCombo.Size = new Size(220, 23);
            IdOrdenEntregaCombo.TabIndex = 72;
            // 
            // DespacharOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 289);
            Controls.Add(GenerarOrdenDeDespachoButton);
            Controls.Add(ListarOrdenDespacharBuscarList);
            Controls.Add(BuscarButton);
            Controls.Add(VolverButton);
            Controls.Add(TransportistaLabel);
            Controls.Add(IdOrdenEntregaCombo);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button BuscarButton;
        private Button VolverButton;
        private Label TransportistaLabel;
        private ComboBox IdOrdenEntregaCombo;
    }
}