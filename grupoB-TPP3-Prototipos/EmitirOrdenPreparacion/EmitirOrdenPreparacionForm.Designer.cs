namespace grupoB_TPP3_Prototipos.GenerarOrdenPreparacion
{
    partial class EmitirOrdenPreparacionForm
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
            ProductoCombo = new ComboBox();
            ProductoLabel = new Label();
            FechaOPPicker = new DateTimePicker();
            label2 = new Label();
            AgregarProductoButton = new Button();
            IdClienteLabel = new Label();
            IdClienteCombo = new ComboBox();
            EliminarProductoButton = new Button();
            TransportistaCombo = new ComboBox();
            PrioridadComboBox = new ComboBox();
            TransportistaLabel = new Label();
            PrioridadLabel = new Label();
            GenerarOrdenButton = new Button();
            VolverButton = new Button();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            GenerarOrdenesPreparacionGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ProductosListView
            // 
            ProductosListView.Columns.AddRange(new ColumnHeader[] { IdProductoColumna, DescripcionColumna, CantidadColumna });
            ProductosListView.FullRowSelect = true;
            ProductosListView.Location = new Point(22, 337);
            ProductosListView.Margin = new Padding(1, 2, 1, 2);
            ProductosListView.Name = "ProductosListView";
            ProductosListView.Size = new Size(939, 246);
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
            // GenerarOrdenesPreparacionGroup
            // 
            GenerarOrdenesPreparacionGroup.Controls.Add(label1);
            GenerarOrdenesPreparacionGroup.Controls.Add(CantidadTextBox);
            GenerarOrdenesPreparacionGroup.Controls.Add(ProductoCombo);
            GenerarOrdenesPreparacionGroup.Controls.Add(ProductoLabel);
            GenerarOrdenesPreparacionGroup.Location = new Point(22, 229);
            GenerarOrdenesPreparacionGroup.Margin = new Padding(1, 2, 1, 2);
            GenerarOrdenesPreparacionGroup.Name = "GenerarOrdenesPreparacionGroup";
            GenerarOrdenesPreparacionGroup.Padding = new Padding(1, 2, 1, 2);
            GenerarOrdenesPreparacionGroup.Size = new Size(439, 94);
            GenerarOrdenesPreparacionGroup.TabIndex = 1;
            GenerarOrdenesPreparacionGroup.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 26);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 17;
            label1.Text = "Cantidad";
            // 
            // CantidadTextBox
            // 
            CantidadTextBox.Location = new Point(237, 48);
            CantidadTextBox.Margin = new Padding(1, 2, 1, 2);
            CantidadTextBox.Name = "CantidadTextBox";
            CantidadTextBox.Size = new Size(184, 27);
            CantidadTextBox.TabIndex = 16;
            // 
            // ProductoCombo
            // 
            ProductoCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductoCombo.FormattingEnabled = true;
            ProductoCombo.Location = new Point(11, 46);
            ProductoCombo.Margin = new Padding(1, 2, 1, 2);
            ProductoCombo.Name = "ProductoCombo";
            ProductoCombo.Size = new Size(186, 28);
            ProductoCombo.TabIndex = 14;
            // 
            // ProductoLabel
            // 
            ProductoLabel.AutoSize = true;
            ProductoLabel.Location = new Point(11, 26);
            ProductoLabel.Margin = new Padding(1, 0, 1, 0);
            ProductoLabel.Name = "ProductoLabel";
            ProductoLabel.Size = new Size(69, 20);
            ProductoLabel.TabIndex = 15;
            ProductoLabel.Text = "Producto";
            // 
            // FechaOPPicker
            // 
            FechaOPPicker.Checked = false;
            FechaOPPicker.Location = new Point(680, 55);
            FechaOPPicker.Margin = new Padding(3, 2, 3, 2);
            FechaOPPicker.Name = "FechaOPPicker";
            FechaOPPicker.ShowCheckBox = true;
            FechaOPPicker.Size = new Size(235, 27);
            FechaOPPicker.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(680, 32);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 19;
            label2.Text = "Fecha de entrega";
            // 
            // AgregarProductoButton
            // 
            AgregarProductoButton.Location = new Point(806, 277);
            AgregarProductoButton.Margin = new Padding(1, 2, 1, 2);
            AgregarProductoButton.Name = "AgregarProductoButton";
            AgregarProductoButton.Size = new Size(155, 41);
            AgregarProductoButton.TabIndex = 12;
            AgregarProductoButton.Text = "Agregar Producto";
            AgregarProductoButton.UseVisualStyleBackColor = true;
            AgregarProductoButton.Click += AgregarProductoButton_Click;
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(11, 32);
            IdClienteLabel.Margin = new Padding(1, 0, 1, 0);
            IdClienteLabel.Name = "IdClienteLabel";
            IdClienteLabel.Size = new Size(74, 20);
            IdClienteLabel.TabIndex = 3;
            IdClienteLabel.Text = "ID Cliente";
            // 
            // IdClienteCombo
            // 
            IdClienteCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdClienteCombo.FormattingEnabled = true;
            IdClienteCombo.Location = new Point(11, 57);
            IdClienteCombo.Margin = new Padding(1, 2, 1, 2);
            IdClienteCombo.Name = "IdClienteCombo";
            IdClienteCombo.Size = new Size(186, 28);
            IdClienteCombo.TabIndex = 2;
            IdClienteCombo.SelectedIndexChanged += IdClienteCombo_SelectedIndexChanged;
            // 
            // EliminarProductoButton
            // 
            EliminarProductoButton.Location = new Point(806, 599);
            EliminarProductoButton.Margin = new Padding(1, 2, 1, 2);
            EliminarProductoButton.Name = "EliminarProductoButton";
            EliminarProductoButton.Size = new Size(156, 40);
            EliminarProductoButton.TabIndex = 13;
            EliminarProductoButton.Text = "Eliminar Producto";
            EliminarProductoButton.UseVisualStyleBackColor = true;
            EliminarProductoButton.Click += EliminarProductoButton_Click;
            // 
            // TransportistaCombo
            // 
            TransportistaCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            TransportistaCombo.FormattingEnabled = true;
            TransportistaCombo.Location = new Point(458, 57);
            TransportistaCombo.Margin = new Padding(1, 2, 1, 2);
            TransportistaCombo.Name = "TransportistaCombo";
            TransportistaCombo.Size = new Size(186, 28);
            TransportistaCombo.TabIndex = 7;
            // 
            // PrioridadComboBox
            // 
            PrioridadComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PrioridadComboBox.FormattingEnabled = true;
            PrioridadComboBox.Location = new Point(236, 57);
            PrioridadComboBox.Margin = new Padding(1, 2, 1, 2);
            PrioridadComboBox.Name = "PrioridadComboBox";
            PrioridadComboBox.Size = new Size(185, 28);
            PrioridadComboBox.TabIndex = 9;
            // 
            // TransportistaLabel
            // 
            TransportistaLabel.AutoSize = true;
            TransportistaLabel.Location = new Point(458, 32);
            TransportistaLabel.Margin = new Padding(1, 0, 1, 0);
            TransportistaLabel.Name = "TransportistaLabel";
            TransportistaLabel.Size = new Size(94, 20);
            TransportistaLabel.TabIndex = 10;
            TransportistaLabel.Text = "Transportista";
            // 
            // PrioridadLabel
            // 
            PrioridadLabel.AutoSize = true;
            PrioridadLabel.Location = new Point(236, 32);
            PrioridadLabel.Margin = new Padding(1, 0, 1, 0);
            PrioridadLabel.Name = "PrioridadLabel";
            PrioridadLabel.Size = new Size(70, 20);
            PrioridadLabel.TabIndex = 11;
            PrioridadLabel.Text = "Prioridad";
            // 
            // GenerarOrdenButton
            // 
            GenerarOrdenButton.Location = new Point(655, 683);
            GenerarOrdenButton.Margin = new Padding(1, 2, 1, 2);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(145, 50);
            GenerarOrdenButton.TabIndex = 13;
            GenerarOrdenButton.Text = "Emitir Orden";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            GenerarOrdenButton.Click += GenerarOrdenButton_Click;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(817, 683);
            VolverButton.Margin = new Padding(1, 2, 1, 2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(145, 50);
            VolverButton.TabIndex = 14;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 20);
            label3.Name = "label3";
            label3.Size = new Size(355, 34);
            label3.TabIndex = 22;
            label3.Text = "Emitir Orden Preparación";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FechaOPPicker);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(IdClienteCombo);
            groupBox1.Controls.Add(PrioridadLabel);
            groupBox1.Controls.Add(TransportistaLabel);
            groupBox1.Controls.Add(IdClienteLabel);
            groupBox1.Controls.Add(PrioridadComboBox);
            groupBox1.Controls.Add(TransportistaCombo);
            groupBox1.Location = new Point(22, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(939, 112);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 78);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 24;
            label4.Text = "label4";
            // 
            // EmitirOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 753);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(VolverButton);
            Controls.Add(AgregarProductoButton);
            Controls.Add(GenerarOrdenButton);
            Controls.Add(EliminarProductoButton);
            Controls.Add(GenerarOrdenesPreparacionGroup);
            Controls.Add(ProductosListView);
            Margin = new Padding(1, 2, 1, 2);
            Name = "EmitirOrdenPreparacionForm";
            Text = "EmitirOrdenPreparacionForm";
            Load += EmitirOrdenPreparacionForm_Load;
            GenerarOrdenesPreparacionGroup.ResumeLayout(false);
            GenerarOrdenesPreparacionGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private ComboBox TransportistaCombo;
        private ComboBox PrioridadComboBox;
        private Label TransportistaLabel;
        private Label PrioridadLabel;
        private Button GenerarOrdenButton;
        private Button VolverButton;
        private Label label2;
        private DateTimePicker FechaOPPicker;
        private Label label3;
        private GroupBox groupBox1;
        private Label label4;
    }
}