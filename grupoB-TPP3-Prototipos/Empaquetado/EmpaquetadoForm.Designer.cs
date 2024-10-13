namespace grupoB_TPP3_Prototipos.CrearOrdenEntrega
{
    partial class EmpaquetadoForm
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
            ListarEmpaquetarOrdenList = new ListView();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            VolverButton = new Button();
            GenerarOrdenesPreparacionGroup = new GroupBox();
            labelOP = new Label();
            OP = new Label();
            labelTransportista = new Label();
            Transportista = new Label();
            labelCliente = new Label();
            IdClienteLabel = new Label();
            GenerarOrdenesPreparacionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // EmpaquetarOrdenButton
            // 
            EmpaquetarOrdenButton.Location = new Point(549, 306);
            EmpaquetarOrdenButton.Margin = new Padding(1);
            EmpaquetarOrdenButton.Name = "EmpaquetarOrdenButton";
            EmpaquetarOrdenButton.Size = new Size(168, 42);
            EmpaquetarOrdenButton.TabIndex = 58;
            EmpaquetarOrdenButton.Text = "Empaquetado";
            EmpaquetarOrdenButton.UseVisualStyleBackColor = true;
            EmpaquetarOrdenButton.Click += EmpaquetarOrdenButton_Click;
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
            Producto.Width = 100;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 100;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(738, 305);
            VolverButton.Margin = new Padding(1);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(129, 45);
            VolverButton.TabIndex = 48;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // GenerarOrdenesPreparacionGroup
            // 
            GenerarOrdenesPreparacionGroup.Controls.Add(labelOP);
            GenerarOrdenesPreparacionGroup.Controls.Add(OP);
            GenerarOrdenesPreparacionGroup.Controls.Add(labelTransportista);
            GenerarOrdenesPreparacionGroup.Controls.Add(Transportista);
            GenerarOrdenesPreparacionGroup.Controls.Add(labelCliente);
            GenerarOrdenesPreparacionGroup.Controls.Add(IdClienteLabel);
            GenerarOrdenesPreparacionGroup.Location = new Point(23, 13);
            GenerarOrdenesPreparacionGroup.Margin = new Padding(1);
            GenerarOrdenesPreparacionGroup.Name = "GenerarOrdenesPreparacionGroup";
            GenerarOrdenesPreparacionGroup.Padding = new Padding(1);
            GenerarOrdenesPreparacionGroup.Size = new Size(846, 95);
            GenerarOrdenesPreparacionGroup.TabIndex = 61;
            GenerarOrdenesPreparacionGroup.TabStop = false;
            // 
            // labelOP
            // 
            labelOP.AutoSize = true;
            labelOP.Location = new Point(34, 52);
            labelOP.Name = "labelOP";
            labelOP.Size = new Size(0, 20);
            labelOP.TabIndex = 10;
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
            // labelTransportista
            // 
            labelTransportista.AutoSize = true;
            labelTransportista.Location = new Point(665, 52);
            labelTransportista.Name = "labelTransportista";
            labelTransportista.Size = new Size(0, 20);
            labelTransportista.TabIndex = 8;
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
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(353, 52);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(0, 20);
            labelCliente.TabIndex = 6;
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
            // EmpaquetadoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 368);
            Controls.Add(GenerarOrdenesPreparacionGroup);
            Controls.Add(EmpaquetarOrdenButton);
            Controls.Add(ListarEmpaquetarOrdenList);
            Controls.Add(VolverButton);
            Name = "EmpaquetadoForm";
            Text = "EmpaquetadoForm";
            Load += EmpaquetadoForm_Load;
            GenerarOrdenesPreparacionGroup.ResumeLayout(false);
            GenerarOrdenesPreparacionGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button EmpaquetarOrdenButton;
        private ListView ListarEmpaquetarOrdenList;
        private Button VolverButton;
        private ColumnHeader IdOrdenSeleccionColumna;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private GroupBox GenerarOrdenesPreparacionGroup;
        private Label labelCliente;
        private Label IdClienteLabel;
        private Label labelTransportista;
        private Label Transportista;
        private Label labelOP;
        private Label OP;
    }
}