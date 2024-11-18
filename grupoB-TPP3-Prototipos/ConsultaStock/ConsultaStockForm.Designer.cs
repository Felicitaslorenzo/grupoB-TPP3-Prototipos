﻿namespace grupoB_TPP3_Prototipos.ConsultaStock
{
    partial class ConsultaStockForm
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
            label3 = new Label();
            comboSKUProducto = new ComboBox();
            comboDescripcionProducto = new ComboBox();
            comboCliente = new ComboBox();
            buttonBuscar = new Button();
            listProducto = new ListView();
            columnSKUProducto = new ColumnHeader();
            columnDescripcionProducto = new ColumnHeader();
            columnCliente = new ColumnHeader();
            columnTotal = new ColumnHeader();
            listDetalle = new ListView();
            columnDeposito = new ColumnHeader();
            columnUbicacion = new ColumnHeader();
            columnCantidad = new ColumnHeader();
            buttonVolver = new Button();
            buttonLimpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 29);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "SKU Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 29);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripción Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(629, 29);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "ID Cliente";
            // 
            // comboSKUProducto
            // 
            comboSKUProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSKUProducto.FormattingEnabled = true;
            comboSKUProducto.Location = new Point(34, 52);
            comboSKUProducto.Name = "comboSKUProducto";
            comboSKUProducto.Size = new Size(257, 28);
            comboSKUProducto.TabIndex = 3;
            // 
            // comboDescripcionProducto
            // 
            comboDescripcionProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDescripcionProducto.FormattingEnabled = true;
            comboDescripcionProducto.Location = new Point(330, 52);
            comboDescripcionProducto.Name = "comboDescripcionProducto";
            comboDescripcionProducto.Size = new Size(257, 28);
            comboDescripcionProducto.TabIndex = 4;
            // 
            // comboCliente
            // 
            comboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCliente.FormattingEnabled = true;
            comboCliente.Location = new Point(629, 52);
            comboCliente.Name = "comboCliente";
            comboCliente.Size = new Size(259, 28);
            comboCliente.TabIndex = 5;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(766, 113);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(122, 40);
            buttonBuscar.TabIndex = 6;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // listProducto
            // 
            listProducto.Columns.AddRange(new ColumnHeader[] { columnSKUProducto, columnDescripcionProducto, columnCliente, columnTotal });
            listProducto.Location = new Point(34, 186);
            listProducto.Name = "listProducto";
            listProducto.Size = new Size(854, 277);
            listProducto.TabIndex = 7;
            listProducto.UseCompatibleStateImageBehavior = false;
            listProducto.View = View.Details;
            listProducto.SelectedIndexChanged += listProducto_SelectedIndexChanged;
            // 
            // columnSKUProducto
            // 
            columnSKUProducto.Text = "SKU Producto";
            columnSKUProducto.Width = 120;
            // 
            // columnDescripcionProducto
            // 
            columnDescripcionProducto.Text = "Descripción Producto";
            columnDescripcionProducto.Width = 350;
            // 
            // columnCliente
            // 
            columnCliente.Text = "ID Cliente";
            columnCliente.Width = 120;
            // 
            // columnTotal
            // 
            columnTotal.Text = "Cantidad total";
            columnTotal.Width = 120;
            // 
            // listDetalle
            // 
            listDetalle.Columns.AddRange(new ColumnHeader[] { columnDeposito, columnUbicacion, columnCantidad });
            listDetalle.Location = new Point(34, 481);
            listDetalle.Name = "listDetalle";
            listDetalle.Size = new Size(854, 277);
            listDetalle.TabIndex = 8;
            listDetalle.UseCompatibleStateImageBehavior = false;
            listDetalle.View = View.Details;
            // 
            // columnDeposito
            // 
            columnDeposito.Text = "ID Deposito";
            columnDeposito.Width = 120;
            // 
            // columnUbicacion
            // 
            columnUbicacion.Text = "Ubicación";
            columnUbicacion.Width = 120;
            // 
            // columnCantidad
            // 
            columnCantidad.Text = "Cantidad";
            columnCantidad.Width = 120;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(766, 776);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(122, 40);
            buttonVolver.TabIndex = 9;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(581, 113);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(122, 40);
            buttonLimpiar.TabIndex = 10;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // ConsultaStockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 832);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonVolver);
            Controls.Add(listDetalle);
            Controls.Add(listProducto);
            Controls.Add(buttonBuscar);
            Controls.Add(comboCliente);
            Controls.Add(comboDescripcionProducto);
            Controls.Add(comboSKUProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultaStockForm";
            Text = "ConsultaStockForm";
            Load += ConsultaStockForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboSKUProducto;
        private ComboBox comboDescripcionProducto;
        private ComboBox comboCliente;
        private Button buttonBuscar;
        private ListView listProducto;
        private ColumnHeader columnSKUProducto;
        private ColumnHeader columnDescripcionProducto;
        private ColumnHeader columnCliente;
        private ColumnHeader columnTotal;
        private ListView listDetalle;
        private ColumnHeader columnDeposito;
        private ColumnHeader columnUbicacion;
        private ColumnHeader columnCantidad;
        private Button buttonVolver;
        private Button buttonLimpiar;
    }
}