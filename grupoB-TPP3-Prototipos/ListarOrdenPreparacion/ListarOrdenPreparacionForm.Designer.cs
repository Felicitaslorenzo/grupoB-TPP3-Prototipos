﻿namespace grupoB_TPP3_Prototipos.ListarOrdenPreparacion
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
            Ubicacion = new ColumnHeader();
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
            ListarOrdenesPreparacionGroup.Location = new Point(15, 20);
            ListarOrdenesPreparacionGroup.Margin = new Padding(2, 3, 2, 3);
            ListarOrdenesPreparacionGroup.Name = "ListarOrdenesPreparacionGroup";
            ListarOrdenesPreparacionGroup.Padding = new Padding(2, 3, 2, 3);
            ListarOrdenesPreparacionGroup.Size = new Size(750, 259);
            ListarOrdenesPreparacionGroup.TabIndex = 0;
            ListarOrdenesPreparacionGroup.TabStop = false;
            ListarOrdenesPreparacionGroup.Enter += ListarOrdenesPreparacionGroup_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 155);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 15;
            label1.Text = "Fecha hasta";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(226, 175);
            dateTimePicker1.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(204, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(596, 215);
            BuscarButton.Margin = new Padding(2, 3, 2, 3);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(128, 29);
            BuscarButton.TabIndex = 13;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click_1;
            // 
            // FechaOrdenPreparacionLabel
            // 
            FechaOrdenPreparacionLabel.AutoSize = true;
            FechaOrdenPreparacionLabel.Location = new Point(14, 155);
            FechaOrdenPreparacionLabel.Margin = new Padding(2, 0, 2, 0);
            FechaOrdenPreparacionLabel.Name = "FechaOrdenPreparacionLabel";
            FechaOrdenPreparacionLabel.Size = new Size(91, 20);
            FechaOrdenPreparacionLabel.TabIndex = 11;
            FechaOrdenPreparacionLabel.Text = "Fecha desde";
            // 
            // FechaOrdenPreparacionPicker
            // 
            FechaOrdenPreparacionPicker.Location = new Point(14, 176);
            FechaOrdenPreparacionPicker.Margin = new Padding(2, 3, 2, 3);
            FechaOrdenPreparacionPicker.Name = "FechaOrdenPreparacionPicker";
            FechaOrdenPreparacionPicker.Size = new Size(191, 27);
            FechaOrdenPreparacionPicker.TabIndex = 10;
            // 
            // PrioridadOrdenPreparacionLabel
            // 
            PrioridadOrdenPreparacionLabel.AutoSize = true;
            PrioridadOrdenPreparacionLabel.Location = new Point(174, 91);
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
            PrioridadOrdenPreparacionCombo.Location = new Point(174, 111);
            PrioridadOrdenPreparacionCombo.Margin = new Padding(2, 3, 2, 3);
            PrioridadOrdenPreparacionCombo.Name = "PrioridadOrdenPreparacionCombo";
            PrioridadOrdenPreparacionCombo.Size = new Size(137, 28);
            PrioridadOrdenPreparacionCombo.TabIndex = 8;
            // 
            // EstadoOrdenPreparacionLabel
            // 
            EstadoOrdenPreparacionLabel.AutoSize = true;
            EstadoOrdenPreparacionLabel.Location = new Point(14, 91);
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
            EstadoOrdenPreparacionCombo.Location = new Point(14, 111);
            EstadoOrdenPreparacionCombo.Margin = new Padding(2, 3, 2, 3);
            EstadoOrdenPreparacionCombo.Name = "EstadoOrdenPreparacionCombo";
            EstadoOrdenPreparacionCombo.Size = new Size(137, 28);
            EstadoOrdenPreparacionCombo.TabIndex = 6;
            // 
            // NombreClienteLabel
            // 
            NombreClienteLabel.AutoSize = true;
            NombreClienteLabel.Location = new Point(427, 91);
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
            NombreClienteCombo.Location = new Point(427, 111);
            NombreClienteCombo.Margin = new Padding(2, 3, 2, 3);
            NombreClienteCombo.Name = "NombreClienteCombo";
            NombreClienteCombo.Size = new Size(297, 28);
            NombreClienteCombo.TabIndex = 4;
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(427, 21);
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
            IdClienteCombo.Location = new Point(427, 44);
            IdClienteCombo.Margin = new Padding(2, 3, 2, 3);
            IdClienteCombo.Name = "IdClienteCombo";
            IdClienteCombo.Size = new Size(297, 28);
            IdClienteCombo.TabIndex = 2;
            // 
            // IdOrdenPreparacionLabel
            // 
            IdOrdenPreparacionLabel.AutoSize = true;
            IdOrdenPreparacionLabel.Location = new Point(14, 21);
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
            IdOrdenPreparacionCombo.Margin = new Padding(2, 3, 2, 3);
            IdOrdenPreparacionCombo.Name = "IdOrdenPreparacionCombo";
            IdOrdenPreparacionCombo.Size = new Size(297, 28);
            IdOrdenPreparacionCombo.TabIndex = 0;
            // 
            // ListaOrdenesPreparacionGroup
            // 
            ListaOrdenesPreparacionGroup.Controls.Add(OrdenesPreparacionList);
            ListaOrdenesPreparacionGroup.Location = new Point(14, 270);
            ListaOrdenesPreparacionGroup.Margin = new Padding(2, 3, 2, 3);
            ListaOrdenesPreparacionGroup.Name = "ListaOrdenesPreparacionGroup";
            ListaOrdenesPreparacionGroup.Padding = new Padding(2, 3, 2, 3);
            ListaOrdenesPreparacionGroup.Size = new Size(750, 248);
            ListaOrdenesPreparacionGroup.TabIndex = 1;
            ListaOrdenesPreparacionGroup.TabStop = false;
            // 
            // OrdenesPreparacionList
            // 
            OrdenesPreparacionList.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, idClienteColumna, nombreClienteColumna, estadoOrdenColumna, fechaOrdenColumna, FechaEmisionColumna });
            OrdenesPreparacionList.Location = new Point(17, 26);
            OrdenesPreparacionList.Margin = new Padding(2, 3, 2, 3);
            OrdenesPreparacionList.Name = "OrdenesPreparacionList";
            OrdenesPreparacionList.Size = new Size(729, 207);
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
            VolverListaButton.Location = new Point(636, 763);
            VolverListaButton.Margin = new Padding(2, 3, 2, 3);
            VolverListaButton.Name = "VolverListaButton";
            VolverListaButton.Size = new Size(128, 29);
            VolverListaButton.TabIndex = 14;
            VolverListaButton.Text = "Volver";
            VolverListaButton.UseVisualStyleBackColor = true;
            VolverListaButton.Click += VolverListaButton_Click;
            // 
            // ProductosList
            // 
            ProductosList.Columns.AddRange(new ColumnHeader[] { SKU, Producto, Cantidad, Ubicacion });
            ProductosList.Location = new Point(16, 27);
            ProductosList.Margin = new Padding(2, 3, 2, 3);
            ProductosList.Name = "ProductosList";
            ProductosList.Size = new Size(729, 207);
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
            // Ubicacion
            // 
            Ubicacion.Text = "Ubicación";
            Ubicacion.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ProductosList);
            groupBox1.Location = new Point(15, 509);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(750, 248);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // ListarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 799);
            Controls.Add(VolverListaButton);
            Controls.Add(ListaOrdenesPreparacionGroup);
            Controls.Add(ListarOrdenesPreparacionGroup);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 3, 2, 3);
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
        private ColumnHeader Ubicacion;
        private GroupBox groupBox1;
    }
}