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
            UbicacionColumna = new ColumnHeader();
            GenerarOrdenesPreparacionGroup = new GroupBox();
            label1 = new Label();
            CantidadTextBox = new TextBox();
            AgregarProductoButton = new Button();
            ProductoCombo = new ComboBox();
            ProductoLabel = new Label();
            IdClienteLabel = new Label();
            IdClienteCombo = new ComboBox();
            EliminarProductoButton = new Button();
            TransportistaComboBox = new ComboBox();
            PrioridadComboBox = new ComboBox();
            TransportistaLabel = new Label();
            PrioridadLabel = new Label();
            GenerarOrdenButton = new Button();
            VolverButton = new Button();
            GenerarOrdenesPreparacionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // ProductosListView
            // 
            ProductosListView.Columns.AddRange(new ColumnHeader[] { IdProductoColumna, DescripcionColumna, CantidadColumna, UbicacionColumna });
            ProductosListView.FullRowSelect = true;
            ProductosListView.Location = new Point(29, 197);
            ProductosListView.Margin = new Padding(2);
            ProductosListView.Name = "ProductosListView";
            ProductosListView.Size = new Size(722, 246);
            ProductosListView.TabIndex = 0;
            ProductosListView.UseCompatibleStateImageBehavior = false;
            ProductosListView.View = View.Details;
            ProductosListView.SelectedIndexChanged += ProductosListView_SelectedIndexChanged;
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
            // UbicacionColumna
            // 
            UbicacionColumna.Text = "Ubicacion";
            UbicacionColumna.Width = 100;
            // 
            // GenerarOrdenesPreparacionGroup
            // 
            GenerarOrdenesPreparacionGroup.Controls.Add(label1);
            GenerarOrdenesPreparacionGroup.Controls.Add(CantidadTextBox);
            GenerarOrdenesPreparacionGroup.Controls.Add(AgregarProductoButton);
            GenerarOrdenesPreparacionGroup.Controls.Add(ProductoCombo);
            GenerarOrdenesPreparacionGroup.Controls.Add(ProductoLabel);
            GenerarOrdenesPreparacionGroup.Location = new Point(29, 88);
            GenerarOrdenesPreparacionGroup.Margin = new Padding(2);
            GenerarOrdenesPreparacionGroup.Name = "GenerarOrdenesPreparacionGroup";
            GenerarOrdenesPreparacionGroup.Padding = new Padding(2);
            GenerarOrdenesPreparacionGroup.Size = new Size(721, 95);
            GenerarOrdenesPreparacionGroup.TabIndex = 1;
            GenerarOrdenesPreparacionGroup.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 17;
            label1.Text = "Cantidad";
            // 
            // CantidadTextBox
            // 
            CantidadTextBox.Location = new Point(257, 49);
            CantidadTextBox.Margin = new Padding(2);
            CantidadTextBox.Name = "CantidadTextBox";
            CantidadTextBox.Size = new Size(176, 27);
            CantidadTextBox.TabIndex = 16;
            // 
            // AgregarProductoButton
            // 
            AgregarProductoButton.Location = new Point(468, 46);
            AgregarProductoButton.Margin = new Padding(2);
            AgregarProductoButton.Name = "AgregarProductoButton";
            AgregarProductoButton.Size = new Size(155, 30);
            AgregarProductoButton.TabIndex = 12;
            AgregarProductoButton.Text = "Agregar Producto";
            AgregarProductoButton.UseVisualStyleBackColor = true;
            AgregarProductoButton.Click += AgregarProductoButton_Click;
            // 
            // ProductoCombo
            // 
            ProductoCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductoCombo.FormattingEnabled = true;
            ProductoCombo.Items.AddRange(new object[] { "SKU001", "SKU002", "SKU003", "SKU004", "SKU005", "SKU006", "SKU007", "SKU008", "SKU009", "SKU010", "SKU011", "SKU012", "SKU013", "SKU014", "SKU015", "SKU016", "SKU017", "SKU018", "SKU019", "SKU020", "SKU021", "SKU022", "SKU023", "SKU024", "SKU025", "SKU026", "SKU027", "SKU028", "SKU029", "SKU030", "SKU031", "SKU032" });
            ProductoCombo.Location = new Point(12, 47);
            ProductoCombo.Margin = new Padding(2);
            ProductoCombo.Name = "ProductoCombo";
            ProductoCombo.Size = new Size(218, 28);
            ProductoCombo.TabIndex = 14;
            // 
            // ProductoLabel
            // 
            ProductoLabel.AutoSize = true;
            ProductoLabel.Location = new Point(12, 26);
            ProductoLabel.Margin = new Padding(2, 0, 2, 0);
            ProductoLabel.Name = "ProductoLabel";
            ProductoLabel.Size = new Size(69, 20);
            ProductoLabel.TabIndex = 15;
            ProductoLabel.Text = "Producto";
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(41, 27);
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
            IdClienteCombo.Items.AddRange(new object[] { "CLIENTE001", "CLIENTE002", "CLIENTE003", "CLIENTE004", "CLIENTE005", "CLIENTE006", "CLIENTE007", "CLIENTE008", "CLIENTE009", "CLIENTE010" });
            IdClienteCombo.Location = new Point(41, 49);
            IdClienteCombo.Margin = new Padding(2);
            IdClienteCombo.Name = "IdClienteCombo";
            IdClienteCombo.Size = new Size(218, 28);
            IdClienteCombo.TabIndex = 2;
            // 
            // EliminarProductoButton
            // 
            EliminarProductoButton.Location = new Point(608, 458);
            EliminarProductoButton.Margin = new Padding(2);
            EliminarProductoButton.Name = "EliminarProductoButton";
            EliminarProductoButton.Size = new Size(142, 30);
            EliminarProductoButton.TabIndex = 13;
            EliminarProductoButton.Text = "Eliminar Producto";
            EliminarProductoButton.UseVisualStyleBackColor = true;
            EliminarProductoButton.Click += EliminarProductoButton_Click;
            // 
            // TransportistaComboBox
            // 
            TransportistaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TransportistaComboBox.FormattingEnabled = true;
            TransportistaComboBox.Items.AddRange(new object[] { "Transportista A", "Transportista B", "Transportista C", "Transportista D", "Transportista E", "Transportista F", "Transportista G", "Transportista H", "Transportista I", "Transportista J" });
            TransportistaComboBox.Location = new Point(497, 49);
            TransportistaComboBox.Margin = new Padding(2);
            TransportistaComboBox.Name = "TransportistaComboBox";
            TransportistaComboBox.Size = new Size(186, 28);
            TransportistaComboBox.TabIndex = 7;
            // 
            // PrioridadComboBox
            // 
            PrioridadComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PrioridadComboBox.FormattingEnabled = true;
            PrioridadComboBox.Items.AddRange(new object[] { "Con prioridad de entrega", "Sin prioridad" });
            PrioridadComboBox.Location = new Point(286, 49);
            PrioridadComboBox.Margin = new Padding(2);
            PrioridadComboBox.Name = "PrioridadComboBox";
            PrioridadComboBox.Size = new Size(176, 28);
            PrioridadComboBox.TabIndex = 9;
            // 
            // TransportistaLabel
            // 
            TransportistaLabel.AutoSize = true;
            TransportistaLabel.Location = new Point(497, 27);
            TransportistaLabel.Margin = new Padding(2, 0, 2, 0);
            TransportistaLabel.Name = "TransportistaLabel";
            TransportistaLabel.Size = new Size(94, 20);
            TransportistaLabel.TabIndex = 10;
            TransportistaLabel.Text = "Transportista";
            // 
            // PrioridadLabel
            // 
            PrioridadLabel.AutoSize = true;
            PrioridadLabel.Location = new Point(286, 27);
            PrioridadLabel.Margin = new Padding(2, 0, 2, 0);
            PrioridadLabel.Name = "PrioridadLabel";
            PrioridadLabel.Size = new Size(70, 20);
            PrioridadLabel.TabIndex = 11;
            PrioridadLabel.Text = "Prioridad";
            // 
            // GenerarOrdenButton
            // 
            GenerarOrdenButton.Location = new Point(442, 531);
            GenerarOrdenButton.Margin = new Padding(2);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(146, 49);
            GenerarOrdenButton.TabIndex = 13;
            GenerarOrdenButton.Text = "Generar Orden";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            GenerarOrdenButton.Click += GenerarOrdenButton_Click;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(604, 531);
            VolverButton.Margin = new Padding(2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(146, 49);
            VolverButton.TabIndex = 14;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // GenerarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 599);
            Controls.Add(VolverButton);
            Controls.Add(IdClienteCombo);
            Controls.Add(GenerarOrdenButton);
            Controls.Add(PrioridadLabel);
            Controls.Add(TransportistaLabel);
            Controls.Add(EliminarProductoButton);
            Controls.Add(IdClienteLabel);
            Controls.Add(PrioridadComboBox);
            Controls.Add(TransportistaComboBox);
            Controls.Add(GenerarOrdenesPreparacionGroup);
            Controls.Add(ProductosListView);
            Margin = new Padding(2);
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
        private ComboBox TransportistaComboBox;
        private ComboBox PrioridadComboBox;
        private Label TransportistaLabel;
        private Label PrioridadLabel;
        private Button GenerarOrdenButton;
        private Button VolverButton;
        private ColumnHeader UbicacionColumna;
    }
}