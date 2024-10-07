namespace grupoB_TPP3_Prototipos.GenerarOrdenEntrega
{
    partial class GenerarOrdenEntregaForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ClienteComboBox = new ComboBox();
            IdOrdenPreparacioncomboBox3 = new ComboBox();
            OrdenesEntregalistView = new ListView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            FechaDesdedateTimePicker = new DateTimePicker();
            FechaHastadateTimePicker = new DateTimePicker();
            BuscarButton = new Button();
            VolverButton = new Button();
            GenerarOEbutton = new Button();
            ClienteColumna = new ColumnHeader();
            FechaEntregaColumna = new ColumnHeader();
            IdOrdenPreparacionColumna = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 1;
            label1.Text = "ID Orden Preparacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 9);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 2;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(616, 152);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 3;
            // 
            // ClienteComboBox
            // 
            ClienteComboBox.FormattingEnabled = true;
            ClienteComboBox.Location = new Point(369, 37);
            ClienteComboBox.Name = "ClienteComboBox";
            ClienteComboBox.Size = new Size(334, 33);
            ClienteComboBox.TabIndex = 5;
            // 
            // IdOrdenPreparacioncomboBox3
            // 
            IdOrdenPreparacioncomboBox3.FormattingEnabled = true;
            IdOrdenPreparacioncomboBox3.Location = new Point(31, 37);
            IdOrdenPreparacioncomboBox3.Name = "IdOrdenPreparacioncomboBox3";
            IdOrdenPreparacioncomboBox3.Size = new Size(265, 33);
            IdOrdenPreparacioncomboBox3.TabIndex = 6;
            // 
            // OrdenesEntregalistView
            // 
            OrdenesEntregalistView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionColumna, ClienteColumna, FechaEntregaColumna });
            OrdenesEntregalistView.Location = new Point(31, 240);
            OrdenesEntregalistView.Name = "OrdenesEntregalistView";
            OrdenesEntregalistView.Size = new Size(724, 305);
            OrdenesEntregalistView.TabIndex = 7;
            OrdenesEntregalistView.UseCompatibleStateImageBehavior = false;
            OrdenesEntregalistView.View = View.Details;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 87);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 8;
            label4.Text = "Fecha de entrega";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 124);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 10;
            label5.Text = "Desde";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(395, 124);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 11;
            label6.Text = "Hasta";
            // 
            // FechaDesdedateTimePicker
            // 
            FechaDesdedateTimePicker.Location = new Point(122, 124);
            FechaDesdedateTimePicker.Name = "FechaDesdedateTimePicker";
            FechaDesdedateTimePicker.Size = new Size(245, 31);
            FechaDesdedateTimePicker.TabIndex = 12;
            // 
            // FechaHastadateTimePicker
            // 
            FechaHastadateTimePicker.Location = new Point(458, 124);
            FechaHastadateTimePicker.Name = "FechaHastadateTimePicker";
            FechaHastadateTimePicker.Size = new Size(245, 31);
            FechaHastadateTimePicker.TabIndex = 13;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(582, 180);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(173, 40);
            BuscarButton.TabIndex = 14;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(582, 577);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(173, 54);
            VolverButton.TabIndex = 15;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // GenerarOEbutton
            // 
            GenerarOEbutton.Location = new Point(324, 577);
            GenerarOEbutton.Name = "GenerarOEbutton";
            GenerarOEbutton.Size = new Size(244, 54);
            GenerarOEbutton.TabIndex = 16;
            GenerarOEbutton.Text = "Generar Orden de Entrega";
            GenerarOEbutton.UseVisualStyleBackColor = true;
            // 
            // ClienteColumna
            // 
            ClienteColumna.Text = "Cliente";
            ClienteColumna.Width = 100;
            // 
            // FechaEntregaColumna
            // 
            FechaEntregaColumna.Text = "Fecha Entrega";
            FechaEntregaColumna.Width = 160;
            // 
            // IdOrdenPreparacionColumna
            // 
            IdOrdenPreparacionColumna.Text = "Id Orden";
            IdOrdenPreparacionColumna.Width = 100;
            // 
            // GenerarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 653);
            Controls.Add(GenerarOEbutton);
            Controls.Add(VolverButton);
            Controls.Add(BuscarButton);
            Controls.Add(FechaHastadateTimePicker);
            Controls.Add(FechaDesdedateTimePicker);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(OrdenesEntregalistView);
            Controls.Add(IdOrdenPreparacioncomboBox3);
            Controls.Add(ClienteComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GenerarOrdenEntregaForm";
            Text = "GenerarOrdenEntregaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox ClienteComboBox;
        private ComboBox IdOrdenPreparacioncomboBox3;
        private ListView OrdenesEntregalistView;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker FechaDesdedateTimePicker;
        private DateTimePicker FechaHastadateTimePicker;
        private Button BuscarButton;
        private Button VolverButton;
        private Button GenerarOEbutton;
        private ColumnHeader ClienteColumna;
        private ColumnHeader FechaEntregaColumna;
        private ColumnHeader IdOrdenPreparacionColumna;
    }
}