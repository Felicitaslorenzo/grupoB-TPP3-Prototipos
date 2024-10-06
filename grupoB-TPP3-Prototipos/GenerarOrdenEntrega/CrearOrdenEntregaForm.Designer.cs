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
            ListarEmpaquetarOrdenList = new ListView();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            VolverButton = new Button();
            GenerarOrdenDeEntregaButton = new Button();
            EliminarOrden = new Button();
            GenerarOrdenesPreparacionGroup = new GroupBox();
            Cliente = new Label();
            IdClienteLabel = new Label();
            Producto1 = new ColumnHeader();
            Cantidad1 = new ColumnHeader();
            Transportista = new Label();
            label1 = new Label();
            OP = new Label();
            label2 = new Label();
            GenerarOrdenesPreparacionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // EmpaquetarOrdenButton
            // 
            EmpaquetarOrdenButton.Location = new Point(592, 217);
            EmpaquetarOrdenButton.Margin = new Padding(1);
            EmpaquetarOrdenButton.Name = "EmpaquetarOrdenButton";
            EmpaquetarOrdenButton.Size = new Size(169, 23);
            EmpaquetarOrdenButton.TabIndex = 58;
            EmpaquetarOrdenButton.Text = "Empaquetar Producto";
            EmpaquetarOrdenButton.UseVisualStyleBackColor = true;
            // 
            // CrearOrdenEntregaList
            // 
            CrearOrdenEntregaList.Columns.AddRange(new ColumnHeader[] { Producto1, Cantidad1 });
            CrearOrdenEntregaList.Location = new Point(19, 266);
            CrearOrdenEntregaList.Margin = new Padding(3, 2, 3, 2);
            CrearOrdenEntregaList.Name = "CrearOrdenEntregaList";
            CrearOrdenEntregaList.Size = new Size(742, 125);
            CrearOrdenEntregaList.TabIndex = 51;
            CrearOrdenEntregaList.UseCompatibleStateImageBehavior = false;
            CrearOrdenEntregaList.View = View.Details;
            // 
            // ListarEmpaquetarOrdenList
            // 
            ListarEmpaquetarOrdenList.Columns.AddRange(new ColumnHeader[] { Producto, Cantidad });
            ListarEmpaquetarOrdenList.Location = new Point(20, 98);
            ListarEmpaquetarOrdenList.Margin = new Padding(3, 2, 3, 2);
            ListarEmpaquetarOrdenList.Name = "ListarEmpaquetarOrdenList";
            ListarEmpaquetarOrdenList.Size = new Size(740, 116);
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
            VolverButton.Location = new Point(649, 479);
            VolverButton.Margin = new Padding(1);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(112, 34);
            VolverButton.TabIndex = 48;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // GenerarOrdenDeEntregaButton
            // 
            GenerarOrdenDeEntregaButton.Location = new Point(465, 479);
            GenerarOrdenDeEntregaButton.Margin = new Padding(1);
            GenerarOrdenDeEntregaButton.Name = "GenerarOrdenDeEntregaButton";
            GenerarOrdenDeEntregaButton.Size = new Size(169, 34);
            GenerarOrdenDeEntregaButton.TabIndex = 59;
            GenerarOrdenDeEntregaButton.Text = "Generar Orden de Entrega";
            GenerarOrdenDeEntregaButton.UseVisualStyleBackColor = true;
            // 
            // EliminarOrden
            // 
            EliminarOrden.Location = new Point(591, 394);
            EliminarOrden.Margin = new Padding(1);
            EliminarOrden.Name = "EliminarOrden";
            EliminarOrden.Size = new Size(169, 23);
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
            GenerarOrdenesPreparacionGroup.Location = new Point(20, 10);
            GenerarOrdenesPreparacionGroup.Margin = new Padding(1);
            GenerarOrdenesPreparacionGroup.Name = "GenerarOrdenesPreparacionGroup";
            GenerarOrdenesPreparacionGroup.Padding = new Padding(1);
            GenerarOrdenesPreparacionGroup.Size = new Size(740, 71);
            GenerarOrdenesPreparacionGroup.TabIndex = 61;
            GenerarOrdenesPreparacionGroup.TabStop = false;
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Location = new Point(309, 39);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(0, 15);
            Cliente.TabIndex = 6;
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(309, 17);
            IdClienteLabel.Margin = new Padding(1, 0, 1, 0);
            IdClienteLabel.Name = "IdClienteLabel";
            IdClienteLabel.Size = new Size(44, 15);
            IdClienteLabel.TabIndex = 5;
            IdClienteLabel.Text = "Cliente";
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
            // Transportista
            // 
            Transportista.AutoSize = true;
            Transportista.Location = new Point(582, 17);
            Transportista.Margin = new Padding(1, 0, 1, 0);
            Transportista.Name = "Transportista";
            Transportista.Size = new Size(74, 15);
            Transportista.TabIndex = 7;
            Transportista.Text = "Transportista";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(582, 39);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 8;
            // 
            // OP
            // 
            OP.AutoSize = true;
            OP.Location = new Point(19, 17);
            OP.Margin = new Padding(1, 0, 1, 0);
            OP.Name = "OP";
            OP.Size = new Size(122, 15);
            OP.TabIndex = 9;
            OP.Text = "Orden de Preparación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 39);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 10;
            // 
            // CrearOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 533);
            Controls.Add(GenerarOrdenesPreparacionGroup);
            Controls.Add(EliminarOrden);
            Controls.Add(GenerarOrdenDeEntregaButton);
            Controls.Add(EmpaquetarOrdenButton);
            Controls.Add(CrearOrdenEntregaList);
            Controls.Add(ListarEmpaquetarOrdenList);
            Controls.Add(VolverButton);
            Margin = new Padding(3, 2, 3, 2);
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