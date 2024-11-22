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
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // IdOrdenSeleccionCombo
            // 
            IdOrdenSeleccionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdOrdenSeleccionCombo.FormattingEnabled = true;
            IdOrdenSeleccionCombo.Location = new Point(14, 59);
            IdOrdenSeleccionCombo.Name = "IdOrdenSeleccionCombo";
            IdOrdenSeleccionCombo.Size = new Size(185, 28);
            IdOrdenSeleccionCombo.TabIndex = 0;
            IdOrdenSeleccionCombo.SelectedIndexChanged += IdOrdenSeleccionCombo_SelectedIndexChanged;
            // 
            // FechaDesdeOSPicker
            // 
            FechaDesdeOSPicker.Checked = false;
            FechaDesdeOSPicker.Location = new Point(236, 57);
            FechaDesdeOSPicker.Name = "FechaDesdeOSPicker";
            FechaDesdeOSPicker.ShowCheckBox = true;
            FechaDesdeOSPicker.Size = new Size(185, 27);
            FechaDesdeOSPicker.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 35);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 2;
            label1.Text = "ID Orden Selección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 34);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 3;
            label2.Text = "Fecha desde";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(614, 116);
            BuscarButton.Margin = new Padding(2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(135, 40);
            BuscarButton.TabIndex = 15;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // ListarOrdenSeleccionList
            // 
            ListarOrdenSeleccionList.Columns.AddRange(new ColumnHeader[] { IdOrdenSeleccionColumna, FechaEmisionOSColumna, FechaEstadoColumna, EstadoColumna });
            ListarOrdenSeleccionList.Location = new Point(26, 236);
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
            FechaEmisionOSColumna.Width = 180;
            // 
            // FechaEstadoColumna
            // 
            FechaEstadoColumna.Text = "Fecha Estado";
            FechaEstadoColumna.Width = 180;
            // 
            // EstadoColumna
            // 
            EstadoColumna.Text = "Estado";
            EstadoColumna.Width = 180;
            // 
            // VolverListaButton
            // 
            VolverListaButton.Location = new Point(626, 871);
            VolverListaButton.Margin = new Padding(2);
            VolverListaButton.Name = "VolverListaButton";
            VolverListaButton.Size = new Size(135, 40);
            VolverListaButton.TabIndex = 18;
            VolverListaButton.Text = "Volver";
            VolverListaButton.UseVisualStyleBackColor = true;
            VolverListaButton.Click += VolverListaButton_Click;
            // 
            // FechaHastaOSPicker
            // 
            FechaHastaOSPicker.Checked = false;
            FechaHastaOSPicker.Location = new Point(458, 57);
            FechaHastaOSPicker.Name = "FechaHastaOSPicker";
            FechaHastaOSPicker.ShowCheckBox = true;
            FechaHastaOSPicker.Size = new Size(185, 27);
            FechaHastaOSPicker.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 33);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 21;
            label4.Text = "Fecha hasta";
            // 
            // listOrdenPreparacion
            // 
            listOrdenPreparacion.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionColumna, ClienteColumna, TransportistaColumna });
            listOrdenPreparacion.Location = new Point(26, 446);
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
            ClienteColumna.Width = 150;
            // 
            // TransportistaColumna
            // 
            TransportistaColumna.Text = "Transportista";
            TransportistaColumna.Width = 150;
            // 
            // ProductosList
            // 
            ProductosList.Columns.AddRange(new ColumnHeader[] { cantidadColumna, DescripcionColumna });
            ProductosList.Location = new Point(26, 647);
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
            cantidadColumna.Width = 140;
            // 
            // DescripcionColumna
            // 
            DescripcionColumna.Text = "Descripción Producto";
            DescripcionColumna.Width = 300;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(340, 34);
            label3.TabIndex = 24;
            label3.Text = "Lista Ordenes Selección";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(FechaHastaOSPicker);
            groupBox1.Controls.Add(BuscarButton);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FechaDesdeOSPicker);
            groupBox1.Controls.Add(IdOrdenSeleccionCombo);
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 174);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // ListarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 930);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(VolverListaButton);
            Controls.Add(ProductosList);
            Controls.Add(listOrdenPreparacion);
            Controls.Add(ListarOrdenSeleccionList);
            Name = "ListarOrdenSeleccionForm";
            Load += ListarOrdenSeleccionForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Label label3;
        private GroupBox groupBox1;
    }
}