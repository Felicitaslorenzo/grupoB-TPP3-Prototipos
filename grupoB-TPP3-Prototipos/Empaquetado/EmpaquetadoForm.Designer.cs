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
            label1 = new Label();
            SuspendLayout();
            // 
            // EmpaquetarOrdenButton
            // 
            EmpaquetarOrdenButton.Location = new Point(549, 307);
            EmpaquetarOrdenButton.Margin = new Padding(1);
            EmpaquetarOrdenButton.Name = "EmpaquetarOrdenButton";
            EmpaquetarOrdenButton.Size = new Size(168, 43);
            EmpaquetarOrdenButton.TabIndex = 58;
            EmpaquetarOrdenButton.Text = "Empaquetado";
            EmpaquetarOrdenButton.UseVisualStyleBackColor = true;
            EmpaquetarOrdenButton.Click += EmpaquetarOrdenButton_Click;
            // 
            // ListarEmpaquetarOrdenList
            // 
            ListarEmpaquetarOrdenList.Columns.AddRange(new ColumnHeader[] { Producto, Cantidad });
            ListarEmpaquetarOrdenList.Location = new Point(23, 15);
            ListarEmpaquetarOrdenList.Name = "ListarEmpaquetarOrdenList";
            ListarEmpaquetarOrdenList.Size = new Size(845, 269);
            ListarEmpaquetarOrdenList.TabIndex = 50;
            ListarEmpaquetarOrdenList.UseCompatibleStateImageBehavior = false;
            ListarEmpaquetarOrdenList.View = View.Details;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 300;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 318);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 59;
            label1.Text = "label1";
            // 
            // EmpaquetadoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 368);
            Controls.Add(label1);
            Controls.Add(EmpaquetarOrdenButton);
            Controls.Add(ListarEmpaquetarOrdenList);
            Controls.Add(VolverButton);
            Name = "EmpaquetadoForm";
            Text = "EmpaquetadoForm";
            Load += EmpaquetadoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EmpaquetarOrdenButton;
        private ListView ListarEmpaquetarOrdenList;
        private Button VolverButton;
        private ColumnHeader IdOrdenSeleccionColumna;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private Label label1;
    }
}