namespace grupoB_TPP3_Prototipos.CrearOrdenEntrega
{
    partial class CrearOrdenEntregaForm
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
            EmpaquetarOrdenButton = new Button();
            CrearOrdenEntregaList = new ListView();
            Producto1 = new ColumnHeader();
            Cantidad1 = new ColumnHeader();
            ListarEmpaquetarOrdenList = new ListView();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            VolverButton = new Button();
            GenerarOrdenDeEntregaButton = new Button();
            EliminarOrden = new Button();
            GenerarOrdenesPreparacionGroup = new GroupBox();
            label2 = new Label();
            OP = new Label();
            label1 = new Label();
            Transportista = new Label();
            Cliente = new Label();
            IdClienteLabel = new Label();
            GenerarOrdenesPreparacionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // EmpaquetarOrdenButton
            // 
            EmpaquetarOrdenButton.Location = new Point(677, 289);
            EmpaquetarOrdenButton.Margin = new Padding(1);
            EmpaquetarOrdenButton.Name = "EmpaquetarOrdenButton";
            EmpaquetarOrdenButton.Size = new Size(193, 31);
            EmpaquetarOrdenButton.TabIndex = 58;
            EmpaquetarOrdenButton.Text = "Empaquetar Producto";
            EmpaquetarOrdenButton.UseVisualStyleBackColor = true;
            EmpaquetarOrdenButton.Click += EmpaquetarOrdenButton_Click;
            // 
            // CrearOrdenEntregaList
            // 
            CrearOrdenEntregaList.Columns.AddRange(new ColumnHeader[] { Producto1, Cantidad1 });
            CrearOrdenEntregaList.Location = new Point(22, 355);
            CrearOrdenEntregaList.Name = "CrearOrdenEntregaList";
            CrearOrdenEntregaList.Size = new Size(847, 165);
            CrearOrdenEntregaList.TabIndex = 51;
            CrearOrdenEntregaList.UseCompatibleStateImageBehavior = false;
            CrearOrdenEntregaList.View = View.Details;
            // 
            // Producto1
            // 
            Producto1.Text = "Producto";
            Producto1.Width = 80;
            // 
            // Cantidad1
            // 
            Cantidad1.Text = "Cantidad";
            // 
            // ListarEmpaquetarOrdenList
            // 
            ListarEmpaquetarOrdenList.Columns.AddRange(new ColumnHeader[] { Producto, Cantidad });
            ListarEmpaquetarOrdenList.Location = new Point(23, 131);
            ListarEmpaquetarOrdenList.Name = "ListarEmpaquetarOrdenList";
            ListarEmpaquetarOrdenList.Size = new Size(845, 153);
            ListarEmpaquetarOrdenList.TabIndex = 50;
            ListarEmpaquetarOrdenList.UseCompatibleStateImageBehavior = false;
            ListarEmpaquetarOrdenList.View = View.Details;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 80;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(742, 639);
            VolverButton.Margin = new Padding(1);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(128, 45);
            VolverButton.TabIndex = 48;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // GenerarOrdenDeEntregaButton
            // 
            GenerarOrdenDeEntregaButton.Location = new Point(531, 639);
            GenerarOrdenDeEntregaButton.Margin = new Padding(1);
            GenerarOrdenDeEntregaButton.Name = "GenerarOrdenDeEntregaButton";
            GenerarOrdenDeEntregaButton.Size = new Size(193, 45);
            GenerarOrdenDeEntregaButton.TabIndex = 59;
            GenerarOrdenDeEntregaButton.Text = "Generar Orden de Entrega";
            GenerarOrdenDeEntregaButton.UseVisualStyleBackColor = true;
            // 
            // EliminarOrden
            // 
            EliminarOrden.Location = new Point(675, 525);
            EliminarOrden.Margin = new Padding(1);
            EliminarOrden.Name = "EliminarOrden";
            EliminarOrden.Size = new Size(193, 31);
            EliminarOrden.TabIndex = 60;
            EliminarOrden.Text = "Eliminar Producto";
            EliminarOrden.UseVisualStyleBackColor = true;
            // 
            // GenerarOrdenesPreparacionGroup
            // 
            GenerarOrdenesPreparacionGroup.Controls.Add(label2);
            GenerarOrdenesPreparacionGroup.Controls.Add(OP);
            GenerarOrdenesPreparacionGroup.Controls.Add(label1);
            GenerarOrdenesPreparacionGroup.Controls.Add(Transportista);
            GenerarOrdenesPreparacionGroup.Controls.Add(Cliente);
            GenerarOrdenesPreparacionGroup.Controls.Add(IdClienteLabel);
            GenerarOrdenesPreparacionGroup.Location = new Point(23, 13);
            GenerarOrdenesPreparacionGroup.Margin = new Padding(1);
            GenerarOrdenesPreparacionGroup.Name = "GenerarOrdenesPreparacionGroup";
            GenerarOrdenesPreparacionGroup.Padding = new Padding(1);
            GenerarOrdenesPreparacionGroup.Size = new Size(846, 95);
            GenerarOrdenesPreparacionGroup.TabIndex = 61;
            GenerarOrdenesPreparacionGroup.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 52);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 10;
            // 
            // OP
            // 
            OP.AutoSize = true;
            OP.Location = new Point(22, 23);
            OP.Margin = new Padding(1, 0, 1, 0);
            OP.Name = "OP";
            OP.Size = new Size(154, 20);
            OP.TabIndex = 9;
            OP.Text = "Orden de Preparación";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(665, 52);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 8;
            // 
            // Transportista
            // 
            Transportista.AutoSize = true;
            Transportista.Location = new Point(665, 23);
            Transportista.Margin = new Padding(1, 0, 1, 0);
            Transportista.Name = "Transportista";
            Transportista.Size = new Size(94, 20);
            Transportista.TabIndex = 7;
            Transportista.Text = "Transportista";
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Location = new Point(353, 52);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(0, 20);
            Cliente.TabIndex = 6;
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(353, 23);
            IdClienteLabel.Margin = new Padding(1, 0, 1, 0);
            IdClienteLabel.Name = "IdClienteLabel";
            IdClienteLabel.Size = new Size(55, 20);
            IdClienteLabel.TabIndex = 5;
            IdClienteLabel.Text = "Cliente";
            // 
            // CrearOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 711);
            Controls.Add(GenerarOrdenesPreparacionGroup);
            Controls.Add(EliminarOrden);
            Controls.Add(GenerarOrdenDeEntregaButton);
            Controls.Add(EmpaquetarOrdenButton);
            Controls.Add(CrearOrdenEntregaList);
            Controls.Add(ListarEmpaquetarOrdenList);
            Controls.Add(VolverButton);
            Name = "CrearOrdenEntregaForm";
            Text = "CrearOrdenEntregaForm";
            GenerarOrdenesPreparacionGroup.ResumeLayout(false);
            GenerarOrdenesPreparacionGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button EmpaquetarOrdenButton;
        private ListView CrearOrdenEntregaList;
        private ListView ListarEmpaquetarOrdenList;
        private Button VolverButton;
        private ColumnHeader IdOrdenSeleccionColumna;
        private Button GenerarOrdenDeEntregaButton;
        private Button EliminarOrden;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private GroupBox GenerarOrdenesPreparacionGroup;
        private Label Cliente;
        private Label IdClienteLabel;
        private ColumnHeader Producto1;
        private ColumnHeader Cantidad1;
        private Label label1;
        private Label Transportista;
        private Label label2;
        private Label OP;
    }
}