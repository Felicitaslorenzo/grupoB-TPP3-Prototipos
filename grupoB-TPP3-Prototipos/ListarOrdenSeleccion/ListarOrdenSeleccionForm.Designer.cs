namespace grupoB_TPP3_Prototipos.ListarOrdenSeleccion
{
    partial class ListarOrdenSeleccionForm
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
            IdOrdenSeleccionCombo = new ComboBox();
            FechaDesdeOSPicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            BuscarButton = new Button();
            ListarOrdenSeleccionList = new ListView();
            IdOrdenSeleccionColumna = new ColumnHeader();
            FechaEmisionOSColumna = new ColumnHeader();
            EstadoColumna = new ColumnHeader();
            FechaEstadoColumna = new ColumnHeader();
            VolverListaButton = new Button();
            FechaHastaOSPicker = new DateTimePicker();
            label4 = new Label();
            listView1 = new ListView();
            IdOrdenPreparacionColumna = new ColumnHeader();
            ClienteColumna = new ColumnHeader();
            TransportistaColumna = new ColumnHeader();
            listView2 = new ListView();
            cantidadColumna = new ColumnHeader();
            DescripcionColumna = new ColumnHeader();
            SuspendLayout();
            // 
            // IdOrdenSeleccionCombo
            // 
            IdOrdenSeleccionCombo.FormattingEnabled = true;
            IdOrdenSeleccionCombo.Location = new Point(23, 46);
            IdOrdenSeleccionCombo.Name = "IdOrdenSeleccionCombo";
            IdOrdenSeleccionCombo.Size = new Size(250, 28);
            IdOrdenSeleccionCombo.TabIndex = 0;
            // 
            // FechaDesdeOSPicker
            // 
            FechaDesdeOSPicker.Location = new Point(331, 47);
            FechaDesdeOSPicker.Name = "FechaDesdeOSPicker";
            FechaDesdeOSPicker.Size = new Size(185, 27);
            FechaDesdeOSPicker.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 2;
            label1.Text = "ID Orden Selección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 24);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 3;
            label2.Text = "Fecha desde";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(588, 85);
            BuscarButton.Margin = new Padding(2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(132, 30);
            BuscarButton.TabIndex = 15;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // ListarOrdenSeleccionList
            // 
            ListarOrdenSeleccionList.Columns.AddRange(new ColumnHeader[] { IdOrdenSeleccionColumna, FechaEmisionOSColumna, EstadoColumna, FechaEstadoColumna });
            ListarOrdenSeleccionList.Location = new Point(14, 129);
            ListarOrdenSeleccionList.Name = "ListarOrdenSeleccionList";
            ListarOrdenSeleccionList.Size = new Size(735, 195);
            ListarOrdenSeleccionList.TabIndex = 16;
            ListarOrdenSeleccionList.UseCompatibleStateImageBehavior = false;
            ListarOrdenSeleccionList.View = View.Details;
            // 
            // IdOrdenSeleccionColumna
            // 
            IdOrdenSeleccionColumna.Text = "ID Orden Seleccion";
            IdOrdenSeleccionColumna.Width = 180;
            // 
            // FechaEmisionOSColumna
            // 
            FechaEmisionOSColumna.Text = "Fecha de Emision";
            FechaEmisionOSColumna.Width = 160;
            // 
            // EstadoColumna
            // 
            EstadoColumna.Text = "Estado";
            EstadoColumna.Width = 100;
            // 
            // FechaEstadoColumna
            // 
            FechaEstadoColumna.Text = "Fecha Estado";
            FechaEstadoColumna.Width = 150;
            // 
            // VolverListaButton
            // 
            VolverListaButton.Location = new Point(621, 767);
            VolverListaButton.Margin = new Padding(2);
            VolverListaButton.Name = "VolverListaButton";
            VolverListaButton.Size = new Size(128, 30);
            VolverListaButton.TabIndex = 18;
            VolverListaButton.Text = "Volver";
            VolverListaButton.UseVisualStyleBackColor = true;
            // 
            // FechaHastaOSPicker
            // 
            FechaHastaOSPicker.Location = new Point(544, 48);
            FechaHastaOSPicker.Name = "FechaHastaOSPicker";
            FechaHastaOSPicker.Size = new Size(177, 27);
            FechaHastaOSPicker.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 25);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 21;
            label4.Text = "Fecha hasta";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionColumna, ClienteColumna, TransportistaColumna });
            listView1.Location = new Point(14, 340);
            listView1.Name = "listView1";
            listView1.Size = new Size(735, 195);
            listView1.TabIndex = 22;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // IdOrdenPreparacionColumna
            // 
            IdOrdenPreparacionColumna.Text = "ID Orden Preparacion";
            IdOrdenPreparacionColumna.Width = 200;
            // 
            // ClienteColumna
            // 
            ClienteColumna.Text = "Ciente";
            ClienteColumna.Width = 100;
            // 
            // TransportistaColumna
            // 
            TransportistaColumna.Text = "Transportista";
            TransportistaColumna.Width = 120;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { cantidadColumna, DescripcionColumna });
            listView2.Location = new Point(14, 552);
            listView2.Name = "listView2";
            listView2.Size = new Size(735, 195);
            listView2.TabIndex = 23;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // cantidadColumna
            // 
            cantidadColumna.Text = "Cantidad";
            cantidadColumna.Width = 100;
            // 
            // DescripcionColumna
            // 
            DescripcionColumna.Text = "Descripción Producto";
            DescripcionColumna.Width = 200;
            // 
            // ListarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 805);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(label4);
            Controls.Add(FechaHastaOSPicker);
            Controls.Add(VolverListaButton);
            Controls.Add(ListarOrdenSeleccionList);
            Controls.Add(BuscarButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FechaDesdeOSPicker);
            Controls.Add(IdOrdenSeleccionCombo);
            Name = "ListarOrdenSeleccionForm";
            Text = "ListarOrdenSeleccionForm";
            Load += ListarOrdenSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox IdOrdenSeleccionCombo;
        private DateTimePicker FechaDesdeOSPicker;
        private Label label1;
        private Label label2;
        private Button BuscarButton;
        private ListView ListarOrdenSeleccionList;
        private ColumnHeader IdOrdenSeleccionColumna;
        private ColumnHeader FechaEmisionOSColumna;
        private Button VolverListaButton;
        private ColumnHeader EstadoColumna;
        private DateTimePicker FechaHastaOSPicker;
        private Label label4;
        private ColumnHeader FechaEstadoColumna;
        private ListView listView1;
        private ColumnHeader IdOrdenPreparacionColumna;
        private ColumnHeader ClienteColumna;
        private ColumnHeader TransportistaColumna;
        private ListView listView2;
        private ColumnHeader cantidadColumna;
        private ColumnHeader DescripcionColumna;
    }
}