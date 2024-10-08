﻿namespace grupoB_TPP3_Prototipos.PrepararOrdenSeleccion
{
    partial class RetirarOrdenSeleccionForm
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
            label1 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            ProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            UbicacionColumna = new ColumnHeader();
            listView2 = new ListView();
            IdOrdenColumna = new ColumnHeader();
            nombreClienteColumna = new ColumnHeader();
            fechaEmisionColumna = new ColumnHeader();
            fechaDespachoColumna = new ColumnHeader();
            SeleccionarButton = new Button();
            ConfirmarButton = new Button();
            CancelarButton = new Button();
            label3 = new Label();
            ProductoCombo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 97);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 0;
            label1.Text = "Ordenes de Preparación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 97);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Productos de orden";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ProductoColumna, CantidadColumna, UbicacionColumna });
            listView1.Location = new Point(459, 129);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(346, 145);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ProductoColumna
            // 
            ProductoColumna.Text = "Producto";
            ProductoColumna.Width = 100;
            // 
            // CantidadColumna
            // 
            CantidadColumna.Text = "Cantidad";
            CantidadColumna.Width = 100;
            // 
            // UbicacionColumna
            // 
            UbicacionColumna.Text = "Ubicación";
            UbicacionColumna.Width = 100;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, nombreClienteColumna, fechaEmisionColumna, fechaDespachoColumna });
            listView2.Location = new Point(8, 129);
            listView2.Margin = new Padding(2);
            listView2.Name = "listView2";
            listView2.Size = new Size(426, 145);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // IdOrdenColumna
            // 
            IdOrdenColumna.Text = "ID Orden";
            IdOrdenColumna.Width = 100;
            // 
            // nombreClienteColumna
            // 
            nombreClienteColumna.Text = "Cliente";
            nombreClienteColumna.Width = 80;
            // 
            // fechaEmisionColumna
            // 
            fechaEmisionColumna.Text = "Fecha Emision";
            fechaEmisionColumna.Width = 140;
            // 
            // fechaDespachoColumna
            // 
            fechaDespachoColumna.Text = "Fecha Despacho";
            fechaDespachoColumna.Width = 140;
            // 
            // SeleccionarButton
            // 
            SeleccionarButton.Location = new Point(344, 298);
            SeleccionarButton.Margin = new Padding(2);
            SeleccionarButton.Name = "SeleccionarButton";
            SeleccionarButton.Size = new Size(90, 22);
            SeleccionarButton.TabIndex = 4;
            SeleccionarButton.Text = "Seleccionar";
            SeleccionarButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmarButton
            // 
            ConfirmarButton.Location = new Point(599, 293);
            ConfirmarButton.Margin = new Padding(2);
            ConfirmarButton.Name = "ConfirmarButton";
            ConfirmarButton.Size = new Size(90, 27);
            ConfirmarButton.TabIndex = 5;
            ConfirmarButton.Text = "Confirmar";
            ConfirmarButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(707, 293);
            CancelarButton.Margin = new Padding(2);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(90, 27);
            CancelarButton.TabIndex = 6;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 25);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 7;
            label3.Text = "Orden de Selección";
            // 
            // ProductoCombo
            // 
            ProductoCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductoCombo.FormattingEnabled = true;
            ProductoCombo.Location = new Point(8, 50);
            ProductoCombo.Margin = new Padding(1);
            ProductoCombo.Name = "ProductoCombo";
            ProductoCombo.Size = new Size(789, 23);
            ProductoCombo.TabIndex = 15;
            // 
            // RetirarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 355);
            Controls.Add(ProductoCombo);
            Controls.Add(label3);
            Controls.Add(CancelarButton);
            Controls.Add(ConfirmarButton);
            Controls.Add(SeleccionarButton);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "RetirarOrdenSeleccionForm";
            Text = "PrepararOrdenSeleccionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView listView1;
        private ListView listView2;
        private ColumnHeader IdOrdenColumna;
        private ColumnHeader nombreClienteColumna;
        private ColumnHeader fechaEmisionColumna;
        private ColumnHeader fechaDespachoColumna;
        private ColumnHeader ProductoColumna;
        private ColumnHeader CantidadColumna;
        private ColumnHeader UbicacionColumna;
        private Button SeleccionarButton;
        private Button ConfirmarButton;
        private Button CancelarButton;
        private Label label3;
        private ComboBox ProductoCombo;
    }
}