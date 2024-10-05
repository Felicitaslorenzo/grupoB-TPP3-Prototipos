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
            idClienteColumna = new ColumnHeader();
            NombreClienteColumna = new ColumnHeader();
            DescripcionColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            UbicacionColumna = new ColumnHeader();
            GenerarOrdenesPreparacionGroup = new GroupBox();
            label1 = new Label();
            CantidadTextBox = new TextBox();
            DescripcionProductoLabel = new Label();
            ProductoCombo = new ComboBox();
            EliminarProductoButton = new Button();
            AgregarProductoButton = new Button();
            IdClienteLabel = new Label();
            IdClienteCombo = new ComboBox();
            EstadoComboBox = new ComboBox();
            PrioridadComoBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            GenerarOrdenButton = new Button();
            VolverButton = new Button();
            GenerarOrdenesPreparacionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // ProductosListView
            // 
            ProductosListView.Columns.AddRange(new ColumnHeader[] { IdProductoColumna, idClienteColumna, NombreClienteColumna, DescripcionColumna, CantidadColumna, UbicacionColumna });
            ProductosListView.Location = new Point(21, 286);
            ProductosListView.Name = "ProductosListView";
            ProductosListView.Size = new Size(935, 306);
            ProductosListView.TabIndex = 0;
            ProductosListView.UseCompatibleStateImageBehavior = false;
            ProductosListView.View = View.Details;
            // 
            // IdProductoColumna
            // 
            IdProductoColumna.Text = "ID Producto";
            IdProductoColumna.Width = 120;
            // 
            // idClienteColumna
            // 
            idClienteColumna.Text = "ID Cliente";
            idClienteColumna.Width = 100;
            // 
            // NombreClienteColumna
            // 
            NombreClienteColumna.Text = "Nombre Cliente";
            NombreClienteColumna.Width = 140;
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
            GenerarOrdenesPreparacionGroup.Controls.Add(DescripcionProductoLabel);
            GenerarOrdenesPreparacionGroup.Controls.Add(ProductoCombo);
            GenerarOrdenesPreparacionGroup.Controls.Add(EliminarProductoButton);
            GenerarOrdenesPreparacionGroup.Controls.Add(AgregarProductoButton);
            GenerarOrdenesPreparacionGroup.Controls.Add(IdClienteLabel);
            GenerarOrdenesPreparacionGroup.Controls.Add(IdClienteCombo);
            GenerarOrdenesPreparacionGroup.Location = new Point(39, 26);
            GenerarOrdenesPreparacionGroup.Margin = new Padding(2);
            GenerarOrdenesPreparacionGroup.Name = "GenerarOrdenesPreparacionGroup";
            GenerarOrdenesPreparacionGroup.Padding = new Padding(2);
            GenerarOrdenesPreparacionGroup.Size = new Size(917, 203);
            GenerarOrdenesPreparacionGroup.TabIndex = 1;
            GenerarOrdenesPreparacionGroup.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(663, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 17;
            label1.Text = "Cantidad";
            // 
            // CantidadTextBox
            // 
            CantidadTextBox.Location = new Point(663, 53);
            CantidadTextBox.Name = "CantidadTextBox";
            CantidadTextBox.Size = new Size(184, 31);
            CantidadTextBox.TabIndex = 16;
            // 
            // DescripcionProductoLabel
            // 
            DescripcionProductoLabel.AutoSize = true;
            DescripcionProductoLabel.Location = new Point(317, 26);
            DescripcionProductoLabel.Margin = new Padding(2, 0, 2, 0);
            DescripcionProductoLabel.Name = "DescripcionProductoLabel";
            DescripcionProductoLabel.Size = new Size(85, 25);
            DescripcionProductoLabel.TabIndex = 15;
            DescripcionProductoLabel.Text = "Producto";
            // 
            // ProductoCombo
            // 
            ProductoCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductoCombo.FormattingEnabled = true;
            ProductoCombo.Location = new Point(326, 53);
            ProductoCombo.Margin = new Padding(2);
            ProductoCombo.Name = "ProductoCombo";
            ProductoCombo.Size = new Size(271, 33);
            ProductoCombo.TabIndex = 14;
            // 
            // EliminarProductoButton
            // 
            EliminarProductoButton.Location = new Point(482, 133);
            EliminarProductoButton.Margin = new Padding(2);
            EliminarProductoButton.Name = "EliminarProductoButton";
            EliminarProductoButton.Size = new Size(177, 37);
            EliminarProductoButton.TabIndex = 13;
            EliminarProductoButton.Text = "Eliminar Producto";
            EliminarProductoButton.UseVisualStyleBackColor = true;
            // 
            // AgregarProductoButton
            // 
            AgregarProductoButton.Location = new Point(256, 133);
            AgregarProductoButton.Margin = new Padding(2);
            AgregarProductoButton.Name = "AgregarProductoButton";
            AgregarProductoButton.Size = new Size(182, 37);
            AgregarProductoButton.TabIndex = 12;
            AgregarProductoButton.Text = "Agregar Producto";
            AgregarProductoButton.UseVisualStyleBackColor = true;
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(30, 26);
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
            IdClienteCombo.Location = new Point(30, 53);
            IdClienteCombo.Margin = new Padding(2);
            IdClienteCombo.Name = "IdClienteCombo";
            IdClienteCombo.Size = new Size(243, 33);
            IdClienteCombo.TabIndex = 2;
            // 
            // EstadoComboBox
            // 
            EstadoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EstadoComboBox.FormattingEnabled = true;
            EstadoComboBox.Location = new Point(39, 645);
            EstadoComboBox.Margin = new Padding(2);
            EstadoComboBox.Name = "EstadoComboBox";
            EstadoComboBox.Size = new Size(232, 33);
            EstadoComboBox.TabIndex = 7;
            // 
            // PrioridadComoBox
            // 
            PrioridadComoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PrioridadComoBox.FormattingEnabled = true;
            PrioridadComoBox.Location = new Point(342, 645);
            PrioridadComoBox.Margin = new Padding(2);
            PrioridadComoBox.Name = "PrioridadComoBox";
            PrioridadComoBox.Size = new Size(219, 33);
            PrioridadComoBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 618);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 10;
            label2.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 618);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 11;
            label3.Text = "Prioridad";
            // 
            // GenerarOrdenButton
            // 
            GenerarOrdenButton.Location = new Point(591, 706);
            GenerarOrdenButton.Margin = new Padding(2);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(182, 37);
            GenerarOrdenButton.TabIndex = 13;
            GenerarOrdenButton.Text = "Generar Orden";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(789, 706);
            VolverButton.Margin = new Padding(2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(182, 37);
            VolverButton.TabIndex = 14;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // GenerarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 775);
            Controls.Add(VolverButton);
            Controls.Add(GenerarOrdenButton);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private ColumnHeader idClienteColumna;
        private ColumnHeader NombreClienteColumna;
        private ColumnHeader DescripcionColumna;
        private ColumnHeader CantidadColumna;
        private ColumnHeader UbicacionColumna;
        private GroupBox GenerarOrdenesPreparacionGroup;
        private Button EliminarProductoButton;
        private Button AgregarProductoButton;
        private Label IdClienteLabel;
        private ComboBox IdClienteCombo;
        private ComboBox ProductoCombo;
        private Label DescripcionProductoLabel;
        private TextBox CantidadTextBox;
        private Label label1;
        private ComboBox EstadoComboBox;
        private ComboBox PrioridadComoBox;
        private Label label2;
        private Label label3;
        private Button GenerarOrdenButton;
        private Button VolverButton;
    }
}