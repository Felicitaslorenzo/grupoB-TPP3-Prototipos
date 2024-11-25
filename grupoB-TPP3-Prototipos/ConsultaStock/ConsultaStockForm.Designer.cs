namespace grupoB_TPP3_Prototipos.ConsultaStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaStockForm));
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
            columnCantComprometida = new ColumnHeader();
            TotalDisponible = new ColumnHeader();
            listDetalle = new ListView();
            columnDeposito = new ColumnHeader();
            columnUbicacion = new ColumnHeader();
            columnCantidad = new ColumnHeader();
            buttonVolver = new Button();
            buttonLimpiar = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 0;
            label1.Text = "SKU Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 29);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 25);
            label2.TabIndex = 1;
            label2.Text = "Descripción Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(761, 29);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 2;
            label3.Text = "ID Cliente";
            // 
            // comboSKUProducto
            // 
            comboSKUProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSKUProducto.FormattingEnabled = true;
            comboSKUProducto.Location = new Point(18, 61);
            comboSKUProducto.Margin = new Padding(4);
            comboSKUProducto.Name = "comboSKUProducto";
            comboSKUProducto.Size = new Size(320, 33);
            comboSKUProducto.TabIndex = 3;
            // 
            // comboDescripcionProducto
            // 
            comboDescripcionProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDescripcionProducto.FormattingEnabled = true;
            comboDescripcionProducto.Location = new Point(388, 61);
            comboDescripcionProducto.Margin = new Padding(4);
            comboDescripcionProducto.Name = "comboDescripcionProducto";
            comboDescripcionProducto.Size = new Size(320, 33);
            comboDescripcionProducto.TabIndex = 4;
            // 
            // comboCliente
            // 
            comboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCliente.FormattingEnabled = true;
            comboCliente.Location = new Point(761, 61);
            comboCliente.Margin = new Padding(4);
            comboCliente.Name = "comboCliente";
            comboCliente.Size = new Size(323, 33);
            comboCliente.TabIndex = 5;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(932, 136);
            buttonBuscar.Margin = new Padding(4);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(152, 50);
            buttonBuscar.TabIndex = 6;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // listProducto
            // 
            listProducto.BackColor = SystemColors.InactiveBorder;
            listProducto.Columns.AddRange(new ColumnHeader[] { columnSKUProducto, columnDescripcionProducto, columnCliente, columnTotal, columnCantComprometida, TotalDisponible });
            listProducto.FullRowSelect = true;
            listProducto.Location = new Point(26, 294);
            listProducto.Margin = new Padding(4);
            listProducto.Name = "listProducto";
            listProducto.Size = new Size(1066, 345);
            listProducto.TabIndex = 7;
            listProducto.UseCompatibleStateImageBehavior = false;
            listProducto.View = View.Details;
            listProducto.SelectedIndexChanged += listProducto_SelectedIndexChanged;
            // 
            // columnSKUProducto
            // 
            columnSKUProducto.Text = "SKU ";
            columnSKUProducto.Width = 100;
            // 
            // columnDescripcionProducto
            // 
            columnDescripcionProducto.Text = "Descripción Producto";
            columnDescripcionProducto.Width = 300;
            // 
            // columnCliente
            // 
            columnCliente.Text = "ID Cliente";
            columnCliente.Width = 120;
            // 
            // columnTotal
            // 
            columnTotal.Text = "Cant. Total";
            columnTotal.Width = 140;
            // 
            // columnCantComprometida
            // 
            columnCantComprometida.Text = "Cant. Comprometida";
            columnCantComprometida.Width = 180;
            // 
            // TotalDisponible
            // 
            TotalDisponible.Text = "Cant. Disponible";
            TotalDisponible.Width = 160;
            // 
            // listDetalle
            // 
            listDetalle.Columns.AddRange(new ColumnHeader[] { columnDeposito, columnUbicacion, columnCantidad });
            listDetalle.FullRowSelect = true;
            listDetalle.Location = new Point(26, 662);
            listDetalle.Margin = new Padding(4);
            listDetalle.Name = "listDetalle";
            listDetalle.Size = new Size(1066, 345);
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
            buttonVolver.Location = new Point(941, 1039);
            buttonVolver.Margin = new Padding(4);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(152, 50);
            buttonVolver.TabIndex = 9;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(701, 136);
            buttonLimpiar.Margin = new Padding(4);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(152, 50);
            buttonLimpiar.TabIndex = 10;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 11);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(267, 39);
            label4.TabIndex = 83;
            label4.Text = "Consultar Stock\r\n";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonLimpiar);
            groupBox1.Controls.Add(buttonBuscar);
            groupBox1.Controls.Add(comboCliente);
            groupBox1.Controls.Add(comboDescripcionProducto);
            groupBox1.Controls.Add(comboSKUProducto);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(9, 58);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1101, 206);
            groupBox1.TabIndex = 84;
            groupBox1.TabStop = false;
            // 
            // ConsultaStockForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 1050);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(buttonVolver);
            Controls.Add(listDetalle);
            Controls.Add(listProducto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ConsultaStockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ConsultaStockForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Label label4;
        private ColumnHeader columnCantComprometida;
        private GroupBox groupBox1;
        private ColumnHeader TotalDisponible;
    }
}