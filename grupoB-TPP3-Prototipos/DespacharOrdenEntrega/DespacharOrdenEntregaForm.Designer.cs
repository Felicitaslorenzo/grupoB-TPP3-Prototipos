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
            EmitirOrdenDeDespachoButton = new Button();
            ListarOrdenDespacharBuscarList = new ListView();
            IdOrdenColumna = new ColumnHeader();
            IdClienteColumna = new ColumnHeader();
            BuscarButton = new Button();
            VolverButton = new Button();
            TransportistaLabel = new Label();
            IdOrdenEntregaCombo = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // EmitirOrdenDeDespachoButton
            // 
            EmitirOrdenDeDespachoButton.Location = new Point(439, 390);
            EmitirOrdenDeDespachoButton.Margin = new Padding(1);
            EmitirOrdenDeDespachoButton.Name = "EmitirOrdenDeDespachoButton";
            EmitirOrdenDeDespachoButton.Size = new Size(219, 41);
            EmitirOrdenDeDespachoButton.TabIndex = 81;
            EmitirOrdenDeDespachoButton.Text = "Emitir Remito";
            EmitirOrdenDeDespachoButton.UseVisualStyleBackColor = true;
            EmitirOrdenDeDespachoButton.Click += EmitirOrdenDeDespachoButton_Click_1;
            // 
            // ListarOrdenDespacharBuscarList
            // 
            ListarOrdenDespacharBuscarList.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, IdClienteColumna });
            ListarOrdenDespacharBuscarList.Location = new Point(31, 158);
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
            IdClienteColumna.Width = 150;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(361, 87);
            BuscarButton.Margin = new Padding(1);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(145, 42);
            BuscarButton.TabIndex = 77;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click_1;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(750, 390);
            VolverButton.Margin = new Padding(1);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(128, 41);
            VolverButton.TabIndex = 76;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // TransportistaLabel
            // 
            TransportistaLabel.AutoSize = true;
            TransportistaLabel.Location = new Point(28, 77);
            TransportistaLabel.Name = "TransportistaLabel";
            TransportistaLabel.Size = new Size(94, 20);
            TransportistaLabel.TabIndex = 74;
            TransportistaLabel.Text = "Transportista";
            // 
            // IdOrdenEntregaCombo
            // 
            IdOrdenEntregaCombo.FormattingEnabled = true;
            IdOrdenEntregaCombo.Location = new Point(31, 101);
            IdOrdenEntregaCombo.Name = "IdOrdenEntregaCombo";
            IdOrdenEntregaCombo.Size = new Size(251, 28);
            IdOrdenEntregaCombo.TabIndex = 72;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 21);
            label2.Name = "label2";
            label2.Size = new Size(461, 34);
            label2.TabIndex = 82;
            label2.Text = "Despachar Ordenes Preparación\r\n";
            // 
            // DespacharOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 462);
            Controls.Add(label2);
            Controls.Add(EmitirOrdenDeDespachoButton);
            Controls.Add(ListarOrdenDespacharBuscarList);
            Controls.Add(BuscarButton);
            Controls.Add(VolverButton);
            Controls.Add(TransportistaLabel);
            Controls.Add(IdOrdenEntregaCombo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DespacharOrdenEntregaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EmitirOrdenDeDespachoButton;
        private ListView ListarOrdenDespacharBuscarList;
        private ColumnHeader IdOrdenColumna;
        private ColumnHeader IdClienteColumna;
        private Button BuscarButton;
        private Button VolverButton;
        private Label TransportistaLabel;
        private ComboBox IdOrdenEntregaCombo;
        private Label label2;
    }
}