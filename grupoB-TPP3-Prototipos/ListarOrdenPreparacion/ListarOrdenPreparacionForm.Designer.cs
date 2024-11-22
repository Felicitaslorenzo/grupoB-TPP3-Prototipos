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
            buttonLimpiar = new Button();
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
            FechaEmisionColumna = new ColumnHeader();
            fechaOrdenColumna = new ColumnHeader();
            VolverListaButton = new Button();
            ProductosList = new ListView();
            SKU = new ColumnHeader();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            groupBox1 = new GroupBox();
            label2 = new Label();
            ListarOrdenesPreparacionGroup.SuspendLayout();
            ListaOrdenesPreparacionGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ListarOrdenesPreparacionGroup
            // 
            ListarOrdenesPreparacionGroup.Controls.Add(buttonLimpiar);
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
            ListarOrdenesPreparacionGroup.Location = new Point(22, 59);
            ListarOrdenesPreparacionGroup.Margin = new Padding(2);
            ListarOrdenesPreparacionGroup.Name = "ListarOrdenesPreparacionGroup";
            ListarOrdenesPreparacionGroup.Padding = new Padding(2);
            ListarOrdenesPreparacionGroup.Size = new Size(949, 233);
            ListarOrdenesPreparacionGroup.TabIndex = 0;
            ListarOrdenesPreparacionGroup.TabStop = false;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(626, 177);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(136, 40);
            buttonLimpiar.TabIndex = 54;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(730, 86);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 15;
            label1.Text = "Fecha hasta";
            // 
            // FechaHastaOPPicker
            // 
            FechaHastaOPPicker.Checked = false;
            FechaHastaOPPicker.Location = new Point(730, 108);
            FechaHastaOPPicker.Margin = new Padding(2);
            FechaHastaOPPicker.Name = "FechaHastaOPPicker";
            FechaHastaOPPicker.ShowCheckBox = true;
            FechaHastaOPPicker.Size = new Size(204, 27);
            FechaHastaOPPicker.TabIndex = 14;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(798, 177);
            BuscarButton.Margin = new Padding(2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(136, 40);
            BuscarButton.TabIndex = 13;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click_1;
            // 
            // FechaOrdenPreparacionLabel
            // 
            FechaOrdenPreparacionLabel.AutoSize = true;
            FechaOrdenPreparacionLabel.Location = new Point(492, 86);
            FechaOrdenPreparacionLabel.Margin = new Padding(2, 0, 2, 0);
            FechaOrdenPreparacionLabel.Name = "FechaOrdenPreparacionLabel";
            FechaOrdenPreparacionLabel.Size = new Size(91, 20);
            FechaOrdenPreparacionLabel.TabIndex = 11;
            FechaOrdenPreparacionLabel.Text = "Fecha desde";
            // 
            // FechaDesdeOPPicker
            // 
            FechaDesdeOPPicker.Checked = false;
            FechaDesdeOPPicker.Location = new Point(492, 108);
            FechaDesdeOPPicker.Margin = new Padding(2);
            FechaDesdeOPPicker.Name = "FechaDesdeOPPicker";
            FechaDesdeOPPicker.ShowCheckBox = true;
            FechaDesdeOPPicker.Size = new Size(204, 27);
            FechaDesdeOPPicker.TabIndex = 10;
            // 
            // PrioridadOrdenPreparacionLabel
            // 
            PrioridadOrdenPreparacionLabel.AutoSize = true;
            PrioridadOrdenPreparacionLabel.Location = new Point(251, 88);
            PrioridadOrdenPreparacionLabel.Margin = new Padding(2, 0, 2, 0);
            PrioridadOrdenPreparacionLabel.Name = "PrioridadOrdenPreparacionLabel";
            PrioridadOrdenPreparacionLabel.Size = new Size(70, 20);
            PrioridadOrdenPreparacionLabel.TabIndex = 9;
            PrioridadOrdenPreparacionLabel.Text = "Prioridad";
            // 
            // PrioridadOrdenPreparacionCombo
            // 
            PrioridadOrdenPreparacionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            PrioridadOrdenPreparacionCombo.FormattingEnabled = true;
            PrioridadOrdenPreparacionCombo.Location = new Point(251, 110);
            PrioridadOrdenPreparacionCombo.Margin = new Padding(2);
            PrioridadOrdenPreparacionCombo.Name = "PrioridadOrdenPreparacionCombo";
            PrioridadOrdenPreparacionCombo.Size = new Size(204, 28);
            PrioridadOrdenPreparacionCombo.TabIndex = 8;
            // 
            // EstadoOrdenPreparacionLabel
            // 
            EstadoOrdenPreparacionLabel.AutoSize = true;
            EstadoOrdenPreparacionLabel.Location = new Point(14, 90);
            EstadoOrdenPreparacionLabel.Margin = new Padding(2, 0, 2, 0);
            EstadoOrdenPreparacionLabel.Name = "EstadoOrdenPreparacionLabel";
            EstadoOrdenPreparacionLabel.Size = new Size(54, 20);
            EstadoOrdenPreparacionLabel.TabIndex = 7;
            EstadoOrdenPreparacionLabel.Text = "Estado";
            // 
            // EstadoOrdenPreparacionCombo
            // 
            EstadoOrdenPreparacionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            EstadoOrdenPreparacionCombo.FormattingEnabled = true;
            EstadoOrdenPreparacionCombo.Location = new Point(14, 110);
            EstadoOrdenPreparacionCombo.Margin = new Padding(2);
            EstadoOrdenPreparacionCombo.Name = "EstadoOrdenPreparacionCombo";
            EstadoOrdenPreparacionCombo.Size = new Size(204, 28);
            EstadoOrdenPreparacionCombo.TabIndex = 6;
            // 
            // NombreClienteLabel
            // 
            NombreClienteLabel.AutoSize = true;
            NombreClienteLabel.Location = new Point(492, 22);
            NombreClienteLabel.Margin = new Padding(2, 0, 2, 0);
            NombreClienteLabel.Name = "NombreClienteLabel";
            NombreClienteLabel.Size = new Size(114, 20);
            NombreClienteLabel.TabIndex = 5;
            NombreClienteLabel.Text = "Nombre Cliente";
            // 
            // NombreClienteCombo
            // 
            NombreClienteCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            NombreClienteCombo.FormattingEnabled = true;
            NombreClienteCombo.Location = new Point(492, 44);
            NombreClienteCombo.Margin = new Padding(2);
            NombreClienteCombo.Name = "NombreClienteCombo";
            NombreClienteCombo.Size = new Size(442, 28);
            NombreClienteCombo.TabIndex = 4;
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(251, 22);
            IdClienteLabel.Margin = new Padding(2, 0, 2, 0);
            IdClienteLabel.Name = "IdClienteLabel";
            IdClienteLabel.Size = new Size(74, 20);
            IdClienteLabel.TabIndex = 3;
            IdClienteLabel.Text = "ID Cliente";
            // 
            // IdClienteCombo
            // 
            IdClienteCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdClienteCombo.FormattingEnabled = true;
            IdClienteCombo.Location = new Point(251, 44);
            IdClienteCombo.Margin = new Padding(2);
            IdClienteCombo.Name = "IdClienteCombo";
            IdClienteCombo.Size = new Size(204, 28);
            IdClienteCombo.TabIndex = 2;
            // 
            // IdOrdenPreparacionLabel
            // 
            IdOrdenPreparacionLabel.AutoSize = true;
            IdOrdenPreparacionLabel.Location = new Point(14, 22);
            IdOrdenPreparacionLabel.Margin = new Padding(2, 0, 2, 0);
            IdOrdenPreparacionLabel.Name = "IdOrdenPreparacionLabel";
            IdOrdenPreparacionLabel.Size = new Size(69, 20);
            IdOrdenPreparacionLabel.TabIndex = 1;
            IdOrdenPreparacionLabel.Text = "ID Orden";
            // 
            // IdOrdenPreparacionCombo
            // 
            IdOrdenPreparacionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdOrdenPreparacionCombo.FormattingEnabled = true;
            IdOrdenPreparacionCombo.Location = new Point(14, 44);
            IdOrdenPreparacionCombo.Margin = new Padding(2);
            IdOrdenPreparacionCombo.Name = "IdOrdenPreparacionCombo";
            IdOrdenPreparacionCombo.Size = new Size(204, 28);
            IdOrdenPreparacionCombo.TabIndex = 0;
            // 
            // ListaOrdenesPreparacionGroup
            // 
            ListaOrdenesPreparacionGroup.Controls.Add(OrdenesPreparacionList);
            ListaOrdenesPreparacionGroup.Location = new Point(22, 293);
            ListaOrdenesPreparacionGroup.Margin = new Padding(2);
            ListaOrdenesPreparacionGroup.Name = "ListaOrdenesPreparacionGroup";
            ListaOrdenesPreparacionGroup.Padding = new Padding(2);
            ListaOrdenesPreparacionGroup.Size = new Size(949, 248);
            ListaOrdenesPreparacionGroup.TabIndex = 1;
            ListaOrdenesPreparacionGroup.TabStop = false;
            // 
            // OrdenesPreparacionList
            // 
            OrdenesPreparacionList.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, idClienteColumna, nombreClienteColumna, estadoOrdenColumna, FechaEmisionColumna, fechaOrdenColumna });
            OrdenesPreparacionList.Location = new Point(14, 24);
            OrdenesPreparacionList.Margin = new Padding(2);
            OrdenesPreparacionList.Name = "OrdenesPreparacionList";
            OrdenesPreparacionList.Size = new Size(920, 206);
            OrdenesPreparacionList.TabIndex = 0;
            OrdenesPreparacionList.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionList.View = View.Details;
            OrdenesPreparacionList.SelectedIndexChanged += OrdenesPreparacionList_SelectedIndexChanged;
            // 
            // IdOrdenColumna
            // 
            IdOrdenColumna.Text = "ID Orden";
            IdOrdenColumna.Width = 100;
            // 
            // idClienteColumna
            // 
            idClienteColumna.Text = "ID Cliente";
            idClienteColumna.Width = 100;
            // 
            // nombreClienteColumna
            // 
            nombreClienteColumna.Text = "Nombre Cliente";
            nombreClienteColumna.Width = 200;
            // 
            // estadoOrdenColumna
            // 
            estadoOrdenColumna.Text = "Estado";
            estadoOrdenColumna.Width = 150;
            // 
            // FechaEmisionColumna
            // 
            FechaEmisionColumna.Text = "Fecha de Emision";
            FechaEmisionColumna.Width = 160;
            // 
            // fechaOrdenColumna
            // 
            fechaOrdenColumna.Text = "Fecha de Estado";
            fechaOrdenColumna.Width = 160;
            // 
            // VolverListaButton
            // 
            VolverListaButton.Location = new Point(848, 818);
            VolverListaButton.Margin = new Padding(2);
            VolverListaButton.Name = "VolverListaButton";
            VolverListaButton.Size = new Size(122, 40);
            VolverListaButton.TabIndex = 14;
            VolverListaButton.Text = "Volver";
            VolverListaButton.UseVisualStyleBackColor = true;
            VolverListaButton.Click += VolverListaButton_Click;
            // 
            // ProductosList
            // 
            ProductosList.Columns.AddRange(new ColumnHeader[] { SKU, Producto, Cantidad });
            ProductosList.Location = new Point(16, 26);
            ProductosList.Margin = new Padding(2);
            ProductosList.Name = "ProductosList";
            ProductosList.Size = new Size(918, 206);
            ProductosList.TabIndex = 15;
            ProductosList.UseCompatibleStateImageBehavior = false;
            ProductosList.View = View.Details;
            // 
            // SKU
            // 
            SKU.Text = "SKU";
            SKU.Width = 100;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 300;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ProductosList);
            groupBox1.Location = new Point(22, 545);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(948, 248);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 9);
            label2.Name = "label2";
            label2.Size = new Size(414, 34);
            label2.TabIndex = 17;
            label2.Text = "Lista Ordenes de Preparación";
            // 
            // ListarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 874);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(VolverListaButton);
            Controls.Add(ListaOrdenesPreparacionGroup);
            Controls.Add(ListarOrdenesPreparacionGroup);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "ListarOrdenPreparacionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ListarOrdenPreparacionForm_Load_1;
            ListarOrdenesPreparacionGroup.ResumeLayout(false);
            ListarOrdenesPreparacionGroup.PerformLayout();
            ListaOrdenesPreparacionGroup.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Label label2;
        private Button buttonLimpiar;
    }
}