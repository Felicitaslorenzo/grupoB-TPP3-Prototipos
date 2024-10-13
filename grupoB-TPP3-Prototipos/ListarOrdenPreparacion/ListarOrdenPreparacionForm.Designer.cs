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
            dateTimePicker1 = new DateTimePicker();
            BuscarButton = new Button();
            FechaOrdenPreparacionLabel = new Label();
            FechaOrdenPreparacionPicker = new DateTimePicker();
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
            ListarOrdenesPreparacionGroup.Controls.Add(dateTimePicker1);
            ListarOrdenesPreparacionGroup.Controls.Add(BuscarButton);
            ListarOrdenesPreparacionGroup.Controls.Add(FechaOrdenPreparacionLabel);
            ListarOrdenesPreparacionGroup.Controls.Add(FechaOrdenPreparacionPicker);
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
            ListarOrdenesPreparacionGroup.Location = new Point(13, 15);
            ListarOrdenesPreparacionGroup.Margin = new Padding(2, 2, 2, 2);
            ListarOrdenesPreparacionGroup.Name = "ListarOrdenesPreparacionGroup";
            ListarOrdenesPreparacionGroup.Padding = new Padding(2, 2, 2, 2);
            ListarOrdenesPreparacionGroup.Size = new Size(656, 194);
            ListarOrdenesPreparacionGroup.TabIndex = 0;
            ListarOrdenesPreparacionGroup.TabStop = false;
            ListarOrdenesPreparacionGroup.Enter += ListarOrdenesPreparacionGroup_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 116);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 15;
            label1.Text = "Fecha hasta";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(198, 131);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(179, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(522, 161);
            BuscarButton.Margin = new Padding(2, 2, 2, 2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(112, 22);
            BuscarButton.TabIndex = 13;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click_1;
            // 
            // FechaOrdenPreparacionLabel
            // 
            FechaOrdenPreparacionLabel.AutoSize = true;
            FechaOrdenPreparacionLabel.Location = new Point(12, 116);
            FechaOrdenPreparacionLabel.Margin = new Padding(2, 0, 2, 0);
            FechaOrdenPreparacionLabel.Name = "FechaOrdenPreparacionLabel";
            FechaOrdenPreparacionLabel.Size = new Size(72, 15);
            FechaOrdenPreparacionLabel.TabIndex = 11;
            FechaOrdenPreparacionLabel.Text = "Fecha desde";
            // 
            // FechaOrdenPreparacionPicker
            // 
            FechaOrdenPreparacionPicker.Location = new Point(12, 132);
            FechaOrdenPreparacionPicker.Margin = new Padding(2, 2, 2, 2);
            FechaOrdenPreparacionPicker.Name = "FechaOrdenPreparacionPicker";
            FechaOrdenPreparacionPicker.Size = new Size(168, 23);
            FechaOrdenPreparacionPicker.TabIndex = 10;
            // 
            // PrioridadOrdenPreparacionLabel
            // 
            PrioridadOrdenPreparacionLabel.AutoSize = true;
            PrioridadOrdenPreparacionLabel.Location = new Point(152, 68);
            PrioridadOrdenPreparacionLabel.Margin = new Padding(2, 0, 2, 0);
            PrioridadOrdenPreparacionLabel.Name = "PrioridadOrdenPreparacionLabel";
            PrioridadOrdenPreparacionLabel.Size = new Size(55, 15);
            PrioridadOrdenPreparacionLabel.TabIndex = 9;
            PrioridadOrdenPreparacionLabel.Text = "Prioridad";
            // 
            // PrioridadOrdenPreparacionCombo
            // 
            PrioridadOrdenPreparacionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            PrioridadOrdenPreparacionCombo.FormattingEnabled = true;
            PrioridadOrdenPreparacionCombo.Location = new Point(152, 83);
            PrioridadOrdenPreparacionCombo.Margin = new Padding(2, 2, 2, 2);
            PrioridadOrdenPreparacionCombo.Name = "PrioridadOrdenPreparacionCombo";
            PrioridadOrdenPreparacionCombo.Size = new Size(120, 23);
            PrioridadOrdenPreparacionCombo.TabIndex = 8;
            // 
            // EstadoOrdenPreparacionLabel
            // 
            EstadoOrdenPreparacionLabel.AutoSize = true;
            EstadoOrdenPreparacionLabel.Location = new Point(12, 68);
            EstadoOrdenPreparacionLabel.Margin = new Padding(2, 0, 2, 0);
            EstadoOrdenPreparacionLabel.Name = "EstadoOrdenPreparacionLabel";
            EstadoOrdenPreparacionLabel.Size = new Size(42, 15);
            EstadoOrdenPreparacionLabel.TabIndex = 7;
            EstadoOrdenPreparacionLabel.Text = "Estado";
            // 
            // EstadoOrdenPreparacionCombo
            // 
            EstadoOrdenPreparacionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            EstadoOrdenPreparacionCombo.FormattingEnabled = true;
            EstadoOrdenPreparacionCombo.Location = new Point(12, 83);
            EstadoOrdenPreparacionCombo.Margin = new Padding(2, 2, 2, 2);
            EstadoOrdenPreparacionCombo.Name = "EstadoOrdenPreparacionCombo";
            EstadoOrdenPreparacionCombo.Size = new Size(120, 23);
            EstadoOrdenPreparacionCombo.TabIndex = 6;
            // 
            // NombreClienteLabel
            // 
            NombreClienteLabel.AutoSize = true;
            NombreClienteLabel.Location = new Point(374, 68);
            NombreClienteLabel.Margin = new Padding(2, 0, 2, 0);
            NombreClienteLabel.Name = "NombreClienteLabel";
            NombreClienteLabel.Size = new Size(91, 15);
            NombreClienteLabel.TabIndex = 5;
            NombreClienteLabel.Text = "Nombre Cliente";
            // 
            // NombreClienteCombo
            // 
            NombreClienteCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            NombreClienteCombo.FormattingEnabled = true;
            NombreClienteCombo.Location = new Point(374, 83);
            NombreClienteCombo.Margin = new Padding(2, 2, 2, 2);
            NombreClienteCombo.Name = "NombreClienteCombo";
            NombreClienteCombo.Size = new Size(260, 23);
            NombreClienteCombo.TabIndex = 4;
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(374, 16);
            IdClienteLabel.Margin = new Padding(2, 0, 2, 0);
            IdClienteLabel.Name = "IdClienteLabel";
            IdClienteLabel.Size = new Size(58, 15);
            IdClienteLabel.TabIndex = 3;
            IdClienteLabel.Text = "ID Cliente";
            // 
            // IdClienteCombo
            // 
            IdClienteCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdClienteCombo.FormattingEnabled = true;
            IdClienteCombo.Location = new Point(374, 33);
            IdClienteCombo.Margin = new Padding(2, 2, 2, 2);
            IdClienteCombo.Name = "IdClienteCombo";
            IdClienteCombo.Size = new Size(260, 23);
            IdClienteCombo.TabIndex = 2;
            // 
            // IdOrdenPreparacionLabel
            // 
            IdOrdenPreparacionLabel.AutoSize = true;
            IdOrdenPreparacionLabel.Location = new Point(12, 16);
            IdOrdenPreparacionLabel.Margin = new Padding(2, 0, 2, 0);
            IdOrdenPreparacionLabel.Name = "IdOrdenPreparacionLabel";
            IdOrdenPreparacionLabel.Size = new Size(54, 15);
            IdOrdenPreparacionLabel.TabIndex = 1;
            IdOrdenPreparacionLabel.Text = "ID Orden";
            // 
            // IdOrdenPreparacionCombo
            // 
            IdOrdenPreparacionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdOrdenPreparacionCombo.FormattingEnabled = true;
            IdOrdenPreparacionCombo.Location = new Point(12, 33);
            IdOrdenPreparacionCombo.Margin = new Padding(2, 2, 2, 2);
            IdOrdenPreparacionCombo.Name = "IdOrdenPreparacionCombo";
            IdOrdenPreparacionCombo.Size = new Size(260, 23);
            IdOrdenPreparacionCombo.TabIndex = 0;
            // 
            // ListaOrdenesPreparacionGroup
            // 
            ListaOrdenesPreparacionGroup.Controls.Add(OrdenesPreparacionList);
            ListaOrdenesPreparacionGroup.Location = new Point(12, 202);
            ListaOrdenesPreparacionGroup.Margin = new Padding(2, 2, 2, 2);
            ListaOrdenesPreparacionGroup.Name = "ListaOrdenesPreparacionGroup";
            ListaOrdenesPreparacionGroup.Padding = new Padding(2, 2, 2, 2);
            ListaOrdenesPreparacionGroup.Size = new Size(656, 186);
            ListaOrdenesPreparacionGroup.TabIndex = 1;
            ListaOrdenesPreparacionGroup.TabStop = false;
            // 
            // OrdenesPreparacionList
            // 
            OrdenesPreparacionList.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, idClienteColumna, nombreClienteColumna, estadoOrdenColumna, fechaOrdenColumna, FechaEmisionColumna });
            OrdenesPreparacionList.Location = new Point(15, 20);
            OrdenesPreparacionList.Margin = new Padding(2, 2, 2, 2);
            OrdenesPreparacionList.Name = "OrdenesPreparacionList";
            OrdenesPreparacionList.Size = new Size(638, 156);
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
            VolverListaButton.Location = new Point(556, 572);
            VolverListaButton.Margin = new Padding(2, 2, 2, 2);
            VolverListaButton.Name = "VolverListaButton";
            VolverListaButton.Size = new Size(112, 22);
            VolverListaButton.TabIndex = 14;
            VolverListaButton.Text = "Volver";
            VolverListaButton.UseVisualStyleBackColor = true;
            VolverListaButton.Click += VolverListaButton_Click;
            // 
            // ProductosList
            // 
            ProductosList.Columns.AddRange(new ColumnHeader[] { SKU, Producto, Cantidad });
            ProductosList.Location = new Point(14, 20);
            ProductosList.Margin = new Padding(2, 2, 2, 2);
            ProductosList.Name = "ProductosList";
            ProductosList.Size = new Size(638, 156);
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
            groupBox1.Location = new Point(13, 382);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(656, 186);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // ListarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 599);
            Controls.Add(VolverListaButton);
            Controls.Add(ListaOrdenesPreparacionGroup);
            Controls.Add(ListarOrdenesPreparacionGroup);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
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
        private DateTimePicker FechaOrdenPreparacionPicker;
        private GroupBox ListaOrdenesPreparacionGroup;
        private Button VolverListaButton;
        private ListView OrdenesPreparacionList;
        private ColumnHeader IdOrdenColumna;
        private ColumnHeader idClienteColumna;
        private ColumnHeader nombreClienteColumna;
        private ColumnHeader estadoOrdenColumna;
        private ColumnHeader fechaOrdenColumna;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ColumnHeader FechaEmisionColumna;
        private ListView ProductosList;
        private ColumnHeader SKU;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private GroupBox groupBox1;
    }
}