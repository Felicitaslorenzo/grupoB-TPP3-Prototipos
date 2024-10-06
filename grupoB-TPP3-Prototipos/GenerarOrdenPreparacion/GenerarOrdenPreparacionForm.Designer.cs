namespace grupoB_TPP3_Prototipos.GenerarOrdenPreparacion
{
    partial class GenerarOrdenPreparacionForm
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
            ProductosListView = new ListView();
            IdProductoColumna = new ColumnHeader();
            DescripcionColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            GenerarOrdenesPreparacionGroup = new GroupBox();
            label1 = new Label();
            CantidadTextBox = new TextBox();
            AgregarProductoButton = new Button();
            ProductoCombo = new ComboBox();
            ProductoLabel = new Label();
            IdClienteLabel = new Label();
            IdClienteCombo = new ComboBox();
            EliminarProductoButton = new Button();
            EstadoComboBox = new ComboBox();
            PrioridadComoBox = new ComboBox();
            TransportistaLabel = new Label();
            PrioridadLabel = new Label();
            GenerarOrdenButton = new Button();
            VolverButton = new Button();
            UbicacionColumna = new ColumnHeader();
            GenerarOrdenesPreparacionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // ProductosListView
            // 
            ProductosListView.Columns.AddRange(new ColumnHeader[] { IdProductoColumna, DescripcionColumna, CantidadColumna, UbicacionColumna });
            ProductosListView.Location = new Point(36, 246);
            ProductosListView.Name = "ProductosListView";
            ProductosListView.Size = new Size(901, 306);
            ProductosListView.TabIndex = 0;
            ProductosListView.UseCompatibleStateImageBehavior = false;
            ProductosListView.View = View.Details;
            // 
            // IdProductoColumna
            // 
            IdProductoColumna.Text = "ID Producto";
            IdProductoColumna.Width = 120;
            // 
            // DescripcionColumna
            // 
            DescripcionColumna.Text = "Descripcion Productos";
            DescripcionColumna.Width = 200;
            // 
            // CantidadColumna
            // 
            CantidadColumna.Text = "Cantidad";
            CantidadColumna.Width = 100;
            // 
            // GenerarOrdenesPreparacionGroup
            // 
            GenerarOrdenesPreparacionGroup.Controls.Add(label1);
            GenerarOrdenesPreparacionGroup.Controls.Add(CantidadTextBox);
            GenerarOrdenesPreparacionGroup.Controls.Add(AgregarProductoButton);
            GenerarOrdenesPreparacionGroup.Controls.Add(ProductoCombo);
            GenerarOrdenesPreparacionGroup.Controls.Add(ProductoLabel);
            GenerarOrdenesPreparacionGroup.Location = new Point(36, 110);
            GenerarOrdenesPreparacionGroup.Margin = new Padding(2);
            GenerarOrdenesPreparacionGroup.Name = "GenerarOrdenesPreparacionGroup";
            GenerarOrdenesPreparacionGroup.Padding = new Padding(2);
            GenerarOrdenesPreparacionGroup.Size = new Size(901, 119);
            GenerarOrdenesPreparacionGroup.TabIndex = 1;
            GenerarOrdenesPreparacionGroup.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 17;
            label1.Text = "Cantidad";
            // 
            // CantidadTextBox
            // 
            CantidadTextBox.Location = new Point(321, 61);
            CantidadTextBox.Name = "CantidadTextBox";
            CantidadTextBox.Size = new Size(219, 31);
            CantidadTextBox.TabIndex = 16;
            // 
            // AgregarProductoButton
            // 
            AgregarProductoButton.Location = new Point(585, 58);
            AgregarProductoButton.Margin = new Padding(2);
            AgregarProductoButton.Name = "AgregarProductoButton";
            AgregarProductoButton.Size = new Size(194, 37);
            AgregarProductoButton.TabIndex = 12;
            AgregarProductoButton.Text = "Agregar Producto";
            AgregarProductoButton.UseVisualStyleBackColor = true;
            // 
            // ProductoCombo
            // 
            ProductoCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductoCombo.FormattingEnabled = true;
            ProductoCombo.Location = new Point(15, 59);
            ProductoCombo.Margin = new Padding(2);
            ProductoCombo.Name = "ProductoCombo";
            ProductoCombo.Size = new Size(271, 33);
            ProductoCombo.TabIndex = 14;
            // 
            // ProductoLabel
            // 
            ProductoLabel.AutoSize = true;
            ProductoLabel.Location = new Point(15, 32);
            ProductoLabel.Margin = new Padding(2, 0, 2, 0);
            ProductoLabel.Name = "ProductoLabel";
            ProductoLabel.Size = new Size(85, 25);
            ProductoLabel.TabIndex = 15;
            ProductoLabel.Text = "Producto";
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(51, 34);
            IdClienteLabel.Margin = new Padding(2, 0, 2, 0);
            IdClienteLabel.Name = "IdClienteLabel";
            IdClienteLabel.Size = new Size(88, 25);
            IdClienteLabel.TabIndex = 3;
            IdClienteLabel.Text = "ID Cliente";
            // 
            // IdClienteCombo
            // 
            IdClienteCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdClienteCombo.FormattingEnabled = true;
            IdClienteCombo.Location = new Point(51, 61);
            IdClienteCombo.Margin = new Padding(2);
            IdClienteCombo.Name = "IdClienteCombo";
            IdClienteCombo.Size = new Size(271, 33);
            IdClienteCombo.TabIndex = 2;
            // 
            // EliminarProductoButton
            // 
            EliminarProductoButton.Location = new Point(760, 572);
            EliminarProductoButton.Margin = new Padding(2);
            EliminarProductoButton.Name = "EliminarProductoButton";
            EliminarProductoButton.Size = new Size(177, 37);
            EliminarProductoButton.TabIndex = 13;
            EliminarProductoButton.Text = "Eliminar Producto";
            EliminarProductoButton.UseVisualStyleBackColor = true;
            // 
            // EstadoComboBox
            // 
            EstadoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EstadoComboBox.FormattingEnabled = true;
            EstadoComboBox.Location = new Point(621, 61);
            EstadoComboBox.Margin = new Padding(2);
            EstadoComboBox.Name = "EstadoComboBox";
            EstadoComboBox.Size = new Size(232, 33);
            EstadoComboBox.TabIndex = 7;
            // 
            // PrioridadComoBox
            // 
            PrioridadComoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PrioridadComoBox.FormattingEnabled = true;
            PrioridadComoBox.Location = new Point(357, 61);
            PrioridadComoBox.Margin = new Padding(2);
            PrioridadComoBox.Name = "PrioridadComoBox";
            PrioridadComoBox.Size = new Size(219, 33);
            PrioridadComoBox.TabIndex = 9;
            // 
            // TransportistaLabel
            // 
            TransportistaLabel.AutoSize = true;
            TransportistaLabel.Location = new Point(621, 34);
            TransportistaLabel.Margin = new Padding(2, 0, 2, 0);
            TransportistaLabel.Name = "TransportistaLabel";
            TransportistaLabel.Size = new Size(113, 25);
            TransportistaLabel.TabIndex = 10;
            TransportistaLabel.Text = "Transportista";
            // 
            // PrioridadLabel
            // 
            PrioridadLabel.AutoSize = true;
            PrioridadLabel.Location = new Point(357, 34);
            PrioridadLabel.Margin = new Padding(2, 0, 2, 0);
            PrioridadLabel.Name = "PrioridadLabel";
            PrioridadLabel.Size = new Size(84, 25);
            PrioridadLabel.TabIndex = 11;
            PrioridadLabel.Text = "Prioridad";
            // 
            // GenerarOrdenButton
            // 
            GenerarOrdenButton.Location = new Point(552, 664);
            GenerarOrdenButton.Margin = new Padding(2);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(182, 61);
            GenerarOrdenButton.TabIndex = 13;
            GenerarOrdenButton.Text = "Generar Orden";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(755, 664);
            VolverButton.Margin = new Padding(2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(182, 61);
            VolverButton.TabIndex = 14;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // UbicacionColumna
            // 
            UbicacionColumna.Text = "Ubicacion";
            UbicacionColumna.Width = 100;
            // 
            // GenerarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 749);
            Controls.Add(VolverButton);
            Controls.Add(IdClienteCombo);
            Controls.Add(GenerarOrdenButton);
            Controls.Add(PrioridadLabel);
            Controls.Add(TransportistaLabel);
            Controls.Add(EliminarProductoButton);
            Controls.Add(IdClienteLabel);
            Controls.Add(PrioridadComoBox);
            Controls.Add(EstadoComboBox);
            Controls.Add(GenerarOrdenesPreparacionGroup);
            Controls.Add(ProductosListView);
            Name = "GenerarOrdenPreparacionForm";
            Text = "GenerarOrdenPreparacionForm";
            GenerarOrdenesPreparacionGroup.ResumeLayout(false);
            GenerarOrdenesPreparacionGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ProductosListView;
        private ColumnHeader IdProductoColumna;
        private ColumnHeader DescripcionColumna;
        private ColumnHeader CantidadColumna;
        private GroupBox GenerarOrdenesPreparacionGroup;
        private Button EliminarProductoButton;
        private Button AgregarProductoButton;
        private Label IdClienteLabel;
        private ComboBox IdClienteCombo;
        private ComboBox ProductoCombo;
        private Label ProductoLabel;
        private TextBox CantidadTextBox;
        private Label label1;
        private ComboBox EstadoComboBox;
        private ComboBox PrioridadComoBox;
        private Label TransportistaLabel;
        private Label PrioridadLabel;
        private Button GenerarOrdenButton;
        private Button VolverButton;
        private ColumnHeader UbicacionColumna;
    }
}