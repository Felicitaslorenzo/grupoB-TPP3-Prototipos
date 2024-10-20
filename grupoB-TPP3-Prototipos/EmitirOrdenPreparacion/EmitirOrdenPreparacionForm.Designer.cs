﻿namespace grupoB_TPP3_Prototipos.GenerarOrdenPreparacion
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
            GenerarOrdenesPreparacionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // ProductosListView
            // 
            ProductosListView.Columns.AddRange(new ColumnHeader[] { IdProductoColumna, DescripcionColumna, CantidadColumna });
            ProductosListView.FullRowSelect = true;
            ProductosListView.Location = new Point(26, 345);
            ProductosListView.Margin = new Padding(1, 2, 1, 2);
            ProductosListView.Name = "ProductosListView";
            ProductosListView.Size = new Size(903, 306);
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
            GenerarOrdenesPreparacionGroup.Location = new Point(26, 206);
            GenerarOrdenesPreparacionGroup.Margin = new Padding(1, 2, 1, 2);
            GenerarOrdenesPreparacionGroup.Name = "GenerarOrdenesPreparacionGroup";
            GenerarOrdenesPreparacionGroup.Padding = new Padding(1, 2, 1, 2);
            GenerarOrdenesPreparacionGroup.Size = new Size(571, 118);
            GenerarOrdenesPreparacionGroup.TabIndex = 1;
            GenerarOrdenesPreparacionGroup.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 32);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 17;
            label1.Text = "Cantidad";
            // 
            // CantidadTextBox
            // 
            CantidadTextBox.Location = new Point(321, 62);
            CantidadTextBox.Margin = new Padding(1, 2, 1, 2);
            CantidadTextBox.Name = "CantidadTextBox";
            CantidadTextBox.Size = new Size(218, 31);
            CantidadTextBox.TabIndex = 16;
            // 
            // ProductoCombo
            // 
            ProductoCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductoCombo.FormattingEnabled = true;
            ProductoCombo.Location = new Point(14, 58);
            ProductoCombo.Margin = new Padding(1, 2, 1, 2);
            ProductoCombo.Name = "ProductoCombo";
            ProductoCombo.Size = new Size(273, 33);
            ProductoCombo.TabIndex = 14;
            // 
            // ProductoLabel
            // 
            ProductoLabel.AutoSize = true;
            ProductoLabel.Location = new Point(14, 32);
            ProductoLabel.Margin = new Padding(1, 0, 1, 0);
            ProductoLabel.Name = "ProductoLabel";
            ProductoLabel.Size = new Size(85, 25);
            ProductoLabel.TabIndex = 15;
            ProductoLabel.Text = "Producto";
            // 
            // FechaOPPicker
            // 
            FechaOPPicker.Checked = false;
            FechaOPPicker.Location = new Point(26, 148);
            FechaOPPicker.Margin = new Padding(4, 2, 4, 2);
            FechaOPPicker.Name = "FechaOPPicker";
            FechaOPPicker.ShowCheckBox = true;
            FechaOPPicker.Size = new Size(233, 31);
            FechaOPPicker.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 112);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 19;
            label2.Text = "Fecha de entrega";
            // 
            // AgregarProductoButton
            // 
            AgregarProductoButton.Location = new Point(736, 286);
            AgregarProductoButton.Margin = new Padding(1, 2, 1, 2);
            AgregarProductoButton.Name = "AgregarProductoButton";
            AgregarProductoButton.Size = new Size(194, 38);
            AgregarProductoButton.TabIndex = 12;
            AgregarProductoButton.Text = "Agregar Producto";
            AgregarProductoButton.UseVisualStyleBackColor = true;
            AgregarProductoButton.Click += AgregarProductoButton_Click;
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(19, 24);
            IdClienteLabel.Margin = new Padding(1, 0, 1, 0);
            IdClienteLabel.Name = "IdClienteLabel";
            IdClienteLabel.Size = new Size(88, 25);
            IdClienteLabel.TabIndex = 3;
            IdClienteLabel.Text = "ID Cliente";
            // 
            // IdClienteCombo
            // 
            IdClienteCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdClienteCombo.FormattingEnabled = true;
            IdClienteCombo.Location = new Point(19, 54);
            IdClienteCombo.Margin = new Padding(1, 2, 1, 2);
            IdClienteCombo.Name = "IdClienteCombo";
            IdClienteCombo.Size = new Size(218, 33);
            IdClienteCombo.TabIndex = 2;
            IdClienteCombo.SelectedIndexChanged += IdClienteCombo_SelectedIndexChanged;
            // 
            // EliminarProductoButton
            // 
            EliminarProductoButton.Location = new Point(751, 676);
            EliminarProductoButton.Margin = new Padding(1, 2, 1, 2);
            EliminarProductoButton.Name = "EliminarProductoButton";
            EliminarProductoButton.Size = new Size(179, 38);
            EliminarProductoButton.TabIndex = 13;
            EliminarProductoButton.Text = "Eliminar Producto";
            EliminarProductoButton.UseVisualStyleBackColor = true;
            EliminarProductoButton.Click += EliminarProductoButton_Click;
            // 
            // TransportistaCombo
            // 
            TransportistaCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            TransportistaCombo.FormattingEnabled = true;
            TransportistaCombo.Location = new Point(520, 54);
            TransportistaCombo.Margin = new Padding(1, 2, 1, 2);
            TransportistaCombo.Name = "TransportistaCombo";
            TransportistaCombo.Size = new Size(233, 33);
            TransportistaCombo.TabIndex = 7;
            // 
            // PrioridadComboBox
            // 
            PrioridadComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PrioridadComboBox.FormattingEnabled = true;
            PrioridadComboBox.Items.AddRange(new object[] { "Con prioridad de entrega", "Sin prioridad" });
            PrioridadComboBox.Location = new Point(268, 54);
            PrioridadComboBox.Margin = new Padding(1, 2, 1, 2);
            PrioridadComboBox.Name = "PrioridadComboBox";
            PrioridadComboBox.Size = new Size(218, 33);
            PrioridadComboBox.TabIndex = 9;
            // 
            // TransportistaLabel
            // 
            TransportistaLabel.AutoSize = true;
            TransportistaLabel.Location = new Point(520, 24);
            TransportistaLabel.Margin = new Padding(1, 0, 1, 0);
            TransportistaLabel.Name = "TransportistaLabel";
            TransportistaLabel.Size = new Size(113, 25);
            TransportistaLabel.TabIndex = 10;
            TransportistaLabel.Text = "Transportista";
            // 
            // PrioridadLabel
            // 
            PrioridadLabel.AutoSize = true;
            PrioridadLabel.Location = new Point(268, 24);
            PrioridadLabel.Margin = new Padding(1, 0, 1, 0);
            PrioridadLabel.Name = "PrioridadLabel";
            PrioridadLabel.Size = new Size(84, 25);
            PrioridadLabel.TabIndex = 11;
            PrioridadLabel.Text = "Prioridad";
            // 
            // GenerarOrdenButton
            // 
            GenerarOrdenButton.Location = new Point(562, 752);
            GenerarOrdenButton.Margin = new Padding(1, 2, 1, 2);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(181, 62);
            GenerarOrdenButton.TabIndex = 13;
            GenerarOrdenButton.Text = "Emitir Orden";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            GenerarOrdenButton.Click += GenerarOrdenButton_Click;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(765, 752);
            VolverButton.Margin = new Padding(1, 2, 1, 2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(181, 62);
            VolverButton.TabIndex = 14;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // EmitirOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 832);
            Controls.Add(FechaOPPicker);
            Controls.Add(label2);
            Controls.Add(VolverButton);
            Controls.Add(IdClienteCombo);
            Controls.Add(AgregarProductoButton);
            Controls.Add(GenerarOrdenButton);
            Controls.Add(PrioridadLabel);
            Controls.Add(TransportistaLabel);
            Controls.Add(EliminarProductoButton);
            Controls.Add(IdClienteLabel);
            Controls.Add(PrioridadComboBox);
            Controls.Add(TransportistaCombo);
            Controls.Add(GenerarOrdenesPreparacionGroup);
            Controls.Add(ProductosListView);
            Margin = new Padding(1, 2, 1, 2);
            Name = "EmitirOrdenPreparacionForm";
            Text = "EmitirOrdenPreparacionForm";
            Load += EmitirOrdenPreparacionForm_Load;
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
        private ComboBox TransportistaCombo;
        private ComboBox PrioridadComboBox;
        private Label TransportistaLabel;
        private Label PrioridadLabel;
        private Button GenerarOrdenButton;
        private Button VolverButton;
        private Label label2;
        private DateTimePicker FechaOPPicker;
    }
}