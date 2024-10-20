namespace grupoB_TPP3_Prototipos.ListarOrdenPreparacion
{
    partial class ListarOrdenPreparacionForm
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
            ListarOrdenesPreparacionGroup = new GroupBox();
            label1 = new Label();
            FechaHastaOPPicker = new DateTimePicker();
            BuscarButton = new Button();
            FechaOrdenPreparacionLabel = new Label();
            FechaDesdeOPPicker = new DateTimePicker();
            PrioridadOrdenPreparacionLabel = new Label();
            PrioridadOrdenPreparacionCombo = new ComboBox();
            EstadoOrdenPreparacionLabel = new Label();
            EstadoOrdenPreparacionCombo = new ComboBox();
            NombreClienteLabel = new Label();
            NombreClienteCombo = new ComboBox();
            IdClienteLabel = new Label();
            IdClienteCombo = new ComboBox();
            IdOrdenPreparacionLabel = new Label();
            IdOrdenPreparacionCombo = new ComboBox();
            ListaOrdenesPreparacionGroup = new GroupBox();
            OrdenesPreparacionList = new ListView();
            IdOrdenColumna = new ColumnHeader();
            idClienteColumna = new ColumnHeader();
            nombreClienteColumna = new ColumnHeader();
            estadoOrdenColumna = new ColumnHeader();
            fechaOrdenColumna = new ColumnHeader();
            FechaEmisionColumna = new ColumnHeader();
            VolverListaButton = new Button();
            ProductosList = new ListView();
            SKU = new ColumnHeader();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            groupBox1 = new GroupBox();
            ListarOrdenesPreparacionGroup.SuspendLayout();
            ListaOrdenesPreparacionGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ListarOrdenesPreparacionGroup
            // 
            ListarOrdenesPreparacionGroup.Controls.Add(label1);
            ListarOrdenesPreparacionGroup.Controls.Add(FechaHastaOPPicker);
            ListarOrdenesPreparacionGroup.Controls.Add(BuscarButton);
            ListarOrdenesPreparacionGroup.Controls.Add(FechaOrdenPreparacionLabel);
            ListarOrdenesPreparacionGroup.Controls.Add(FechaDesdeOPPicker);
            ListarOrdenesPreparacionGroup.Controls.Add(PrioridadOrdenPreparacionLabel);
            ListarOrdenesPreparacionGroup.Controls.Add(PrioridadOrdenPreparacionCombo);
            ListarOrdenesPreparacionGroup.Controls.Add(EstadoOrdenPreparacionLabel);
            ListarOrdenesPreparacionGroup.Controls.Add(EstadoOrdenPreparacionCombo);
            ListarOrdenesPreparacionGroup.Controls.Add(NombreClienteLabel);
            ListarOrdenesPreparacionGroup.Controls.Add(NombreClienteCombo);
            ListarOrdenesPreparacionGroup.Controls.Add(IdClienteLabel);
            ListarOrdenesPreparacionGroup.Controls.Add(IdClienteCombo);
            ListarOrdenesPreparacionGroup.Controls.Add(IdOrdenPreparacionLabel);
            ListarOrdenesPreparacionGroup.Controls.Add(IdOrdenPreparacionCombo);
            ListarOrdenesPreparacionGroup.Location = new Point(19, 25);
            ListarOrdenesPreparacionGroup.Name = "ListarOrdenesPreparacionGroup";
            ListarOrdenesPreparacionGroup.Size = new Size(937, 323);
            ListarOrdenesPreparacionGroup.TabIndex = 0;
            ListarOrdenesPreparacionGroup.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 193);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 15;
            label1.Text = "Fecha hasta";
            // 
            // FechaHastaOPPicker
            // 
            FechaHastaOPPicker.Checked = false;
            FechaHastaOPPicker.Location = new Point(283, 218);
            FechaHastaOPPicker.Name = "FechaHastaOPPicker";
            FechaHastaOPPicker.ShowCheckBox = true;
            FechaHastaOPPicker.Size = new Size(254, 31);
            FechaHastaOPPicker.TabIndex = 14;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(746, 268);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(160, 37);
            BuscarButton.TabIndex = 13;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click_1;
            // 
            // FechaOrdenPreparacionLabel
            // 
            FechaOrdenPreparacionLabel.AutoSize = true;
            FechaOrdenPreparacionLabel.Location = new Point(17, 193);
            FechaOrdenPreparacionLabel.Name = "FechaOrdenPreparacionLabel";
            FechaOrdenPreparacionLabel.Size = new Size(110, 25);
            FechaOrdenPreparacionLabel.TabIndex = 11;
            FechaOrdenPreparacionLabel.Text = "Fecha desde";
            // 
            // FechaDesdeOPPicker
            // 
            FechaDesdeOPPicker.Checked = false;
            FechaDesdeOPPicker.Location = new Point(17, 220);
            FechaDesdeOPPicker.Name = "FechaDesdeOPPicker";
            FechaDesdeOPPicker.ShowCheckBox = true;
            FechaDesdeOPPicker.Size = new Size(238, 31);
            FechaDesdeOPPicker.TabIndex = 10;
            // 
            // PrioridadOrdenPreparacionLabel
            // 
            PrioridadOrdenPreparacionLabel.AutoSize = true;
            PrioridadOrdenPreparacionLabel.Location = new Point(217, 113);
            PrioridadOrdenPreparacionLabel.Name = "PrioridadOrdenPreparacionLabel";
            PrioridadOrdenPreparacionLabel.Size = new Size(84, 25);
            PrioridadOrdenPreparacionLabel.TabIndex = 9;
            PrioridadOrdenPreparacionLabel.Text = "Prioridad";
            // 
            // PrioridadOrdenPreparacionCombo
            // 
            PrioridadOrdenPreparacionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            PrioridadOrdenPreparacionCombo.FormattingEnabled = true;
            PrioridadOrdenPreparacionCombo.Location = new Point(217, 138);
            PrioridadOrdenPreparacionCombo.Name = "PrioridadOrdenPreparacionCombo";
            PrioridadOrdenPreparacionCombo.Size = new Size(170, 33);
            PrioridadOrdenPreparacionCombo.TabIndex = 8;
            // 
            // EstadoOrdenPreparacionLabel
            // 
            EstadoOrdenPreparacionLabel.AutoSize = true;
            EstadoOrdenPreparacionLabel.Location = new Point(17, 113);
            EstadoOrdenPreparacionLabel.Name = "EstadoOrdenPreparacionLabel";
            EstadoOrdenPreparacionLabel.Size = new Size(66, 25);
            EstadoOrdenPreparacionLabel.TabIndex = 7;
            EstadoOrdenPreparacionLabel.Text = "Estado";
            // 
            // EstadoOrdenPreparacionCombo
            // 
            EstadoOrdenPreparacionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            EstadoOrdenPreparacionCombo.FormattingEnabled = true;
            EstadoOrdenPreparacionCombo.Location = new Point(17, 138);
            EstadoOrdenPreparacionCombo.Name = "EstadoOrdenPreparacionCombo";
            EstadoOrdenPreparacionCombo.Size = new Size(170, 33);
            EstadoOrdenPreparacionCombo.TabIndex = 6;
            // 
            // NombreClienteLabel
            // 
            NombreClienteLabel.AutoSize = true;
            NombreClienteLabel.Location = new Point(534, 113);
            NombreClienteLabel.Name = "NombreClienteLabel";
            NombreClienteLabel.Size = new Size(136, 25);
            NombreClienteLabel.TabIndex = 5;
            NombreClienteLabel.Text = "Nombre Cliente";
            // 
            // NombreClienteCombo
            // 
            NombreClienteCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            NombreClienteCombo.FormattingEnabled = true;
            NombreClienteCombo.Location = new Point(534, 138);
            NombreClienteCombo.Name = "NombreClienteCombo";
            NombreClienteCombo.Size = new Size(370, 33);
            NombreClienteCombo.TabIndex = 4;
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(534, 27);
            IdClienteLabel.Name = "IdClienteLabel";
            IdClienteLabel.Size = new Size(88, 25);
            IdClienteLabel.TabIndex = 3;
            IdClienteLabel.Text = "ID Cliente";
            // 
            // IdClienteCombo
            // 
            IdClienteCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdClienteCombo.FormattingEnabled = true;
            IdClienteCombo.Location = new Point(534, 55);
            IdClienteCombo.Name = "IdClienteCombo";
            IdClienteCombo.Size = new Size(370, 33);
            IdClienteCombo.TabIndex = 2;
            // 
            // IdOrdenPreparacionLabel
            // 
            IdOrdenPreparacionLabel.AutoSize = true;
            IdOrdenPreparacionLabel.Location = new Point(17, 27);
            IdOrdenPreparacionLabel.Name = "IdOrdenPreparacionLabel";
            IdOrdenPreparacionLabel.Size = new Size(85, 25);
            IdOrdenPreparacionLabel.TabIndex = 1;
            IdOrdenPreparacionLabel.Text = "ID Orden";
            // 
            // IdOrdenPreparacionCombo
            // 
            IdOrdenPreparacionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdOrdenPreparacionCombo.FormattingEnabled = true;
            IdOrdenPreparacionCombo.Location = new Point(17, 55);
            IdOrdenPreparacionCombo.Name = "IdOrdenPreparacionCombo";
            IdOrdenPreparacionCombo.Size = new Size(370, 33);
            IdOrdenPreparacionCombo.TabIndex = 0;
            // 
            // ListaOrdenesPreparacionGroup
            // 
            ListaOrdenesPreparacionGroup.Controls.Add(OrdenesPreparacionList);
            ListaOrdenesPreparacionGroup.Location = new Point(17, 337);
            ListaOrdenesPreparacionGroup.Name = "ListaOrdenesPreparacionGroup";
            ListaOrdenesPreparacionGroup.Size = new Size(937, 310);
            ListaOrdenesPreparacionGroup.TabIndex = 1;
            ListaOrdenesPreparacionGroup.TabStop = false;
            // 
            // OrdenesPreparacionList
            // 
            OrdenesPreparacionList.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, idClienteColumna, nombreClienteColumna, estadoOrdenColumna, fechaOrdenColumna, FechaEmisionColumna });
            OrdenesPreparacionList.Location = new Point(21, 33);
            OrdenesPreparacionList.Name = "OrdenesPreparacionList";
            OrdenesPreparacionList.Size = new Size(910, 257);
            OrdenesPreparacionList.TabIndex = 0;
            OrdenesPreparacionList.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionList.View = View.Details;
            OrdenesPreparacionList.SelectedIndexChanged += OrdenesPreparacionList_SelectedIndexChanged;
            // 
            // IdOrdenColumna
            // 
            IdOrdenColumna.Text = "ID Orden";
            IdOrdenColumna.Width = 120;
            // 
            // idClienteColumna
            // 
            idClienteColumna.Text = "ID Cliente";
            idClienteColumna.Width = 100;
            // 
            // nombreClienteColumna
            // 
            nombreClienteColumna.Text = "Nombre Cliente";
            nombreClienteColumna.Width = 150;
            // 
            // estadoOrdenColumna
            // 
            estadoOrdenColumna.Text = "Estado";
            estadoOrdenColumna.Width = 80;
            // 
            // fechaOrdenColumna
            // 
            fechaOrdenColumna.Text = "Fecha de Estado";
            fechaOrdenColumna.Width = 150;
            // 
            // FechaEmisionColumna
            // 
            FechaEmisionColumna.Text = "Fecha de emision";
            FechaEmisionColumna.Width = 150;
            // 
            // VolverListaButton
            // 
            VolverListaButton.Location = new Point(794, 953);
            VolverListaButton.Name = "VolverListaButton";
            VolverListaButton.Size = new Size(160, 37);
            VolverListaButton.TabIndex = 14;
            VolverListaButton.Text = "Volver";
            VolverListaButton.UseVisualStyleBackColor = true;
            VolverListaButton.Click += VolverListaButton_Click;
            // 
            // ProductosList
            // 
            ProductosList.Columns.AddRange(new ColumnHeader[] { SKU, Producto, Cantidad });
            ProductosList.Location = new Point(20, 33);
            ProductosList.Name = "ProductosList";
            ProductosList.Size = new Size(910, 257);
            ProductosList.TabIndex = 15;
            ProductosList.UseCompatibleStateImageBehavior = false;
            ProductosList.View = View.Details;
            // 
            // SKU
            // 
            SKU.Text = "SKU";
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 100;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 80;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ProductosList);
            groupBox1.Location = new Point(19, 637);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(937, 310);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // ListarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 998);
            Controls.Add(VolverListaButton);
            Controls.Add(ListaOrdenesPreparacionGroup);
            Controls.Add(ListarOrdenesPreparacionGroup);
            Controls.Add(groupBox1);
            Name = "ListarOrdenPreparacionForm";
            Text = "Listar Órdenes de Preparación";
            Load += ListarOrdenPreparacionForm_Load_1;
            ListarOrdenesPreparacionGroup.ResumeLayout(false);
            ListarOrdenesPreparacionGroup.PerformLayout();
            ListaOrdenesPreparacionGroup.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ListarOrdenesPreparacionGroup;
        private Label NombreClienteLabel;
        private ComboBox NombreClienteCombo;
        private Label IdClienteLabel;
        private ComboBox IdClienteCombo;
        private Label IdOrdenPreparacionLabel;
        private ComboBox IdOrdenPreparacionCombo;
        private Label PrioridadOrdenPreparacionLabel;
        private ComboBox PrioridadOrdenPreparacionCombo;
        private Label EstadoOrdenPreparacionLabel;
        private ComboBox EstadoOrdenPreparacionCombo;
        private Button BuscarButton;
        private Label FechaOrdenPreparacionLabel;
        private DateTimePicker FechaDesdeOPPicker;
        private GroupBox ListaOrdenesPreparacionGroup;
        private Button VolverListaButton;
        private ListView OrdenesPreparacionList;
        private ColumnHeader IdOrdenColumna;
        private ColumnHeader idClienteColumna;
        private ColumnHeader nombreClienteColumna;
        private ColumnHeader estadoOrdenColumna;
        private ColumnHeader fechaOrdenColumna;
        private Label label1;
        private DateTimePicker FechaHastaOPPicker;
        private ColumnHeader FechaEmisionColumna;
        private ListView ProductosList;
        private ColumnHeader SKU;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private GroupBox groupBox1;
    }
}