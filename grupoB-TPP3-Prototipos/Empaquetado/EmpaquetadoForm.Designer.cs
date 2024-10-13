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
            SuspendLayout();
            // 
            // EmpaquetarOrdenButton
            // 
            EmpaquetarOrdenButton.Location = new Point(480, 230);
            EmpaquetarOrdenButton.Margin = new Padding(1);
            EmpaquetarOrdenButton.Name = "EmpaquetarOrdenButton";
            EmpaquetarOrdenButton.Size = new Size(147, 32);
            EmpaquetarOrdenButton.TabIndex = 58;
            EmpaquetarOrdenButton.Text = "Empaquetado";
            EmpaquetarOrdenButton.UseVisualStyleBackColor = true;
            EmpaquetarOrdenButton.Click += EmpaquetarOrdenButton_Click;
            // 
            // ListarEmpaquetarOrdenList
            // 
            ListarEmpaquetarOrdenList.Columns.AddRange(new ColumnHeader[] { Producto, Cantidad });
            ListarEmpaquetarOrdenList.Location = new Point(20, 11);
            ListarEmpaquetarOrdenList.Margin = new Padding(3, 2, 3, 2);
            ListarEmpaquetarOrdenList.Name = "ListarEmpaquetarOrdenList";
            ListarEmpaquetarOrdenList.Size = new Size(740, 203);
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
            VolverButton.Location = new Point(646, 229);
            VolverButton.Margin = new Padding(1);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(113, 34);
            VolverButton.TabIndex = 48;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // EmpaquetadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 276);
            Controls.Add(EmpaquetarOrdenButton);
            Controls.Add(ListarEmpaquetarOrdenList);
            Controls.Add(VolverButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmpaquetadoForm";
            Text = "EmpaquetadoForm";
            Load += EmpaquetadoForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button EmpaquetarOrdenButton;
        private ListView ListarEmpaquetarOrdenList;
        private Button VolverButton;
        private ColumnHeader IdOrdenSeleccionColumna;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
    }
}