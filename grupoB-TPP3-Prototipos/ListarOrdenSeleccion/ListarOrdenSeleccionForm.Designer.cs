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
            FechaEstadoColumna = new ColumnHeader();
            EstadoColumna = new ColumnHeader();
            VolverListaButton = new Button();
            FechaHastaOSPicker = new DateTimePicker();
            label4 = new Label();
            listOrdenPreparacion = new ListView();
            IdOrdenPreparacionColumna = new ColumnHeader();
            ClienteColumna = new ColumnHeader();
            TransportistaColumna = new ColumnHeader();
            ProductosList = new ListView();
            cantidadColumna = new ColumnHeader();
            DescripcionColumna = new ColumnHeader();
            SuspendLayout();
            // 
            // IdOrdenSeleccionCombo
            // 
            IdOrdenSeleccionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdOrdenSeleccionCombo.FormattingEnabled = true;
            IdOrdenSeleccionCombo.Location = new Point(23, 46);
            IdOrdenSeleccionCombo.Name = "IdOrdenSeleccionCombo";
            IdOrdenSeleccionCombo.Size = new Size(250, 28);
            IdOrdenSeleccionCombo.TabIndex = 0;
            IdOrdenSeleccionCombo.SelectedIndexChanged += IdOrdenSeleccionCombo_SelectedIndexChanged;
            // 
            // FechaDesdeOSPicker
            // 
            FechaDesdeOSPicker.Checked = false;
            FechaDesdeOSPicker.Location = new Point(331, 47);
            FechaDesdeOSPicker.Name = "FechaDesdeOSPicker";
            FechaDesdeOSPicker.ShowCheckBox = true;
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
            ListarOrdenSeleccionList.Columns.AddRange(new ColumnHeader[] { IdOrdenSeleccionColumna, FechaEmisionOSColumna, FechaEstadoColumna, EstadoColumna });
            ListarOrdenSeleccionList.Location = new Point(14, 129);
            ListarOrdenSeleccionList.Name = "ListarOrdenSeleccionList";
            ListarOrdenSeleccionList.Size = new Size(735, 195);
            ListarOrdenSeleccionList.TabIndex = 16;
            ListarOrdenSeleccionList.UseCompatibleStateImageBehavior = false;
            ListarOrdenSeleccionList.View = View.Details;
            ListarOrdenSeleccionList.SelectedIndexChanged += ListarOrdenSeleccionList_SelectedIndexChanged;
            // 
            // IdOrdenSeleccionColumna
            // 
            IdOrdenSeleccionColumna.Text = "ID Orden Seleccion";
            IdOrdenSeleccionColumna.Width = 180;
            // 
            // FechaEmisionOSColumna
            // 
            FechaEmisionOSColumna.Text = "Fecha Emision";
            FechaEmisionOSColumna.Width = 160;
            // 
            // FechaEstadoColumna
            // 
            FechaEstadoColumna.Text = "Fecha Estado";
            FechaEstadoColumna.Width = 150;
            // 
            // EstadoColumna
            // 
            EstadoColumna.Text = "Estado";
            EstadoColumna.Width = 140;
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
            VolverListaButton.Click += VolverListaButton_Click;
            // 
            // FechaHastaOSPicker
            // 
            FechaHastaOSPicker.Checked = false;
            FechaHastaOSPicker.Location = new Point(544, 48);
            FechaHastaOSPicker.Name = "FechaHastaOSPicker";
            FechaHastaOSPicker.ShowCheckBox = true;
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
            // listOrdenPreparacion
            // 
            listOrdenPreparacion.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionColumna, ClienteColumna, TransportistaColumna });
            listOrdenPreparacion.Location = new Point(14, 340);
            listOrdenPreparacion.Name = "listOrdenPreparacion";
            listOrdenPreparacion.Size = new Size(735, 195);
            listOrdenPreparacion.TabIndex = 22;
            listOrdenPreparacion.UseCompatibleStateImageBehavior = false;
            listOrdenPreparacion.View = View.Details;
            listOrdenPreparacion.SelectedIndexChanged += listOrdenPreparacion_SelectedIndexChanged;
            // 
            // IdOrdenPreparacionColumna
            // 
            IdOrdenPreparacionColumna.Text = "ID Orden Preparacion";
            IdOrdenPreparacionColumna.Width = 180;
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
            // ProductosList
            // 
            ProductosList.Columns.AddRange(new ColumnHeader[] { cantidadColumna, DescripcionColumna });
            ProductosList.Location = new Point(14, 552);
            ProductosList.Name = "ProductosList";
            ProductosList.Size = new Size(735, 195);
            ProductosList.TabIndex = 23;
            ProductosList.UseCompatibleStateImageBehavior = false;
            ProductosList.View = View.Details;
            ProductosList.SelectedIndexChanged += ProductosList_SelectedIndexChanged;
            // 
            // cantidadColumna
            // 
            cantidadColumna.Text = "Cantidad";
            cantidadColumna.Width = 100;
            // 
            // DescripcionColumna
            // 
            DescripcionColumna.Text = "Descripción Producto";
            DescripcionColumna.Width = 300;
            // 
            // ListarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 805);
            Controls.Add(ProductosList);
            Controls.Add(listOrdenPreparacion);
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
        private ListView listOrdenPreparacion;
        private ColumnHeader IdOrdenPreparacionColumna;
        private ColumnHeader ClienteColumna;
        private ColumnHeader TransportistaColumna;
        private ListView ProductosList;
        private ColumnHeader cantidadColumna;
        private ColumnHeader DescripcionColumna;
    }
}