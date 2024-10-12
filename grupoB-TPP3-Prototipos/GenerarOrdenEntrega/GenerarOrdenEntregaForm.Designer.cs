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
            IdOrdenPreparacionColumna = new ColumnHeader();
            ClienteColumna = new ColumnHeader();
            FechaEntregaColumna = new ColumnHeader();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            FechaDesdedateTimePicker = new DateTimePicker();
            FechaHastadateTimePicker = new DateTimePicker();
            BuscarButton = new Button();
            VolverButton = new Button();
            GenerarOEbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 1;
            label1.Text = "ID Orden Preparacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 12);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 2;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(801, 195);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 3;
            // 
            // ClienteComboBox
            // 
            ClienteComboBox.FormattingEnabled = true;
            ClienteComboBox.Location = new Point(480, 47);
            ClienteComboBox.Margin = new Padding(4);
            ClienteComboBox.Name = "ClienteComboBox";
            ClienteComboBox.Size = new Size(433, 40);
            ClienteComboBox.TabIndex = 5;
            // 
            // IdOrdenPreparacioncomboBox3
            // 
            IdOrdenPreparacioncomboBox3.FormattingEnabled = true;
            IdOrdenPreparacioncomboBox3.Location = new Point(40, 47);
            IdOrdenPreparacioncomboBox3.Margin = new Padding(4);
            IdOrdenPreparacioncomboBox3.Name = "IdOrdenPreparacioncomboBox3";
            IdOrdenPreparacioncomboBox3.Size = new Size(343, 40);
            IdOrdenPreparacioncomboBox3.TabIndex = 6;
            // 
            // OrdenesEntregalistView
            // 
            OrdenesEntregalistView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionColumna, ClienteColumna, FechaEntregaColumna });
            OrdenesEntregalistView.Location = new Point(40, 307);
            OrdenesEntregalistView.Margin = new Padding(4);
            OrdenesEntregalistView.Name = "OrdenesEntregalistView";
            OrdenesEntregalistView.Size = new Size(940, 389);
            OrdenesEntregalistView.TabIndex = 7;
            OrdenesEntregalistView.UseCompatibleStateImageBehavior = false;
            OrdenesEntregalistView.View = View.Details;
            // 
            // IdOrdenPreparacionColumna
            // 
            IdOrdenPreparacionColumna.Text = "Id Orden";
            IdOrdenPreparacionColumna.Width = 120;
            // 
            // ClienteColumna
            // 
            ClienteColumna.Text = "Cliente";
            ClienteColumna.Width = 120;
            // 
            // FechaEntregaColumna
            // 
            FechaEntregaColumna.Text = "Fecha Entrega";
            FechaEntregaColumna.Width = 180;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 111);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(199, 32);
            label4.TabIndex = 8;
            label4.Text = "Fecha de entrega";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 159);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 32);
            label5.TabIndex = 10;
            label5.Text = "Desde";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(514, 159);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 32);
            label6.TabIndex = 11;
            label6.Text = "Hasta";
            // 
            // FechaDesdedateTimePicker
            // 
            FechaDesdedateTimePicker.Location = new Point(159, 159);
            FechaDesdedateTimePicker.Margin = new Padding(4);
            FechaDesdedateTimePicker.Name = "FechaDesdedateTimePicker";
            FechaDesdedateTimePicker.Size = new Size(317, 39);
            FechaDesdedateTimePicker.TabIndex = 12;
            FechaDesdedateTimePicker.ValueChanged += FechaDesdedateTimePicker_ValueChanged;
            // 
            // FechaHastadateTimePicker
            // 
            FechaHastadateTimePicker.Location = new Point(595, 159);
            FechaHastadateTimePicker.Margin = new Padding(4);
            FechaHastadateTimePicker.Name = "FechaHastadateTimePicker";
            FechaHastadateTimePicker.Size = new Size(317, 39);
            FechaHastadateTimePicker.TabIndex = 13;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(757, 230);
            BuscarButton.Margin = new Padding(4);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(225, 51);
            BuscarButton.TabIndex = 14;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(757, 739);
            VolverButton.Margin = new Padding(4);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(225, 69);
            VolverButton.TabIndex = 15;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // GenerarOEbutton
            // 
            GenerarOEbutton.Location = new Point(421, 739);
            GenerarOEbutton.Margin = new Padding(4);
            GenerarOEbutton.Name = "GenerarOEbutton";
            GenerarOEbutton.Size = new Size(317, 69);
            GenerarOEbutton.TabIndex = 16;
            GenerarOEbutton.Text = "Generar Orden de Entrega";
            GenerarOEbutton.UseVisualStyleBackColor = true;
            // 
            // GenerarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 836);
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
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "GenerarOrdenEntregaForm";
            Text = "Generar Orden de Entrega";
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