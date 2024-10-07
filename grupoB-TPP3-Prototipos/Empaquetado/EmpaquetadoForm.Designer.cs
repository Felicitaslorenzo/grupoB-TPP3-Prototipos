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
            EmpaquetarOrdenButton.Location = new Point(686, 383);
            EmpaquetarOrdenButton.Margin = new Padding(1);
            EmpaquetarOrdenButton.Name = "EmpaquetarOrdenButton";
            EmpaquetarOrdenButton.Size = new Size(210, 53);
            EmpaquetarOrdenButton.TabIndex = 58;
            EmpaquetarOrdenButton.Text = "Empaquetado";
            EmpaquetarOrdenButton.UseVisualStyleBackColor = true;
            EmpaquetarOrdenButton.Click += EmpaquetarOrdenButton_Click;
            // 
            // ListarEmpaquetarOrdenList
            // 
            ListarEmpaquetarOrdenList.Columns.AddRange(new ColumnHeader[] { Producto, Cantidad });
            ListarEmpaquetarOrdenList.Location = new Point(29, 164);
            ListarEmpaquetarOrdenList.Margin = new Padding(4, 4, 4, 4);
            ListarEmpaquetarOrdenList.Name = "ListarEmpaquetarOrdenList";
            ListarEmpaquetarOrdenList.Size = new Size(1055, 190);
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
            VolverButton.Location = new Point(923, 381);
            VolverButton.Margin = new Padding(1);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(161, 56);
            VolverButton.TabIndex = 48;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // GenerarOrdenesPreparacionGroup
            // 
            GenerarOrdenesPreparacionGroup.Controls.Add(label2);
            GenerarOrdenesPreparacionGroup.Controls.Add(OP);
            GenerarOrdenesPreparacionGroup.Controls.Add(label1);
            GenerarOrdenesPreparacionGroup.Controls.Add(Transportista);
            GenerarOrdenesPreparacionGroup.Controls.Add(Cliente);
            GenerarOrdenesPreparacionGroup.Controls.Add(IdClienteLabel);
            GenerarOrdenesPreparacionGroup.Location = new Point(29, 16);
            GenerarOrdenesPreparacionGroup.Margin = new Padding(1);
            GenerarOrdenesPreparacionGroup.Name = "GenerarOrdenesPreparacionGroup";
            GenerarOrdenesPreparacionGroup.Padding = new Padding(1);
            GenerarOrdenesPreparacionGroup.Size = new Size(1058, 119);
            GenerarOrdenesPreparacionGroup.TabIndex = 61;
            GenerarOrdenesPreparacionGroup.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 10;
            // 
            // OP
            // 
            OP.AutoSize = true;
            OP.Location = new Point(28, 29);
            OP.Margin = new Padding(1, 0, 1, 0);
            OP.Name = "OP";
            OP.Size = new Size(185, 25);
            OP.TabIndex = 9;
            OP.Text = "Orden de Preparación";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(831, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 8;
            // 
            // Transportista
            // 
            Transportista.AutoSize = true;
            Transportista.Location = new Point(831, 29);
            Transportista.Margin = new Padding(1, 0, 1, 0);
            Transportista.Name = "Transportista";
            Transportista.Size = new Size(113, 25);
            Transportista.TabIndex = 7;
            Transportista.Text = "Transportista";
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Location = new Point(441, 65);
            Cliente.Margin = new Padding(4, 0, 4, 0);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(0, 25);
            Cliente.TabIndex = 6;
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(441, 29);
            IdClienteLabel.Margin = new Padding(1, 0, 1, 0);
            IdClienteLabel.Name = "IdClienteLabel";
            IdClienteLabel.Size = new Size(65, 25);
            IdClienteLabel.TabIndex = 5;
            IdClienteLabel.Text = "Cliente";
            // 
            // EmpaquetadoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 460);
            Controls.Add(GenerarOrdenesPreparacionGroup);
            Controls.Add(EmpaquetarOrdenButton);
            Controls.Add(ListarEmpaquetarOrdenList);
            Controls.Add(VolverButton);
            Margin = new Padding(4, 4, 4, 4);
            Name = "EmpaquetadoForm";
            Text = "EmpaquetadoForm";
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
        private Label Cliente;
        private Label IdClienteLabel;
        private Label label1;
        private Label Transportista;
        private Label label2;
        private Label OP;
    }
}