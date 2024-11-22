namespace grupoB_TPP3_Prototipos.MenuOrdenesSeleccion
{
    partial class MenuOrdenesSeleccionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuOrdenesSeleccionForm));
            buttonListarOrdenesSeleccion = new Button();
            buttonGenerarOrden = new Button();
            buttonRetirarOrden = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonListarOrdenesSeleccion
            // 
            buttonListarOrdenesSeleccion.Location = new Point(40, 24);
            buttonListarOrdenesSeleccion.Name = "buttonListarOrdenesSeleccion";
            buttonListarOrdenesSeleccion.Size = new Size(194, 121);
            buttonListarOrdenesSeleccion.TabIndex = 0;
            buttonListarOrdenesSeleccion.Text = "Listar Órdenes de Selección";
            buttonListarOrdenesSeleccion.UseVisualStyleBackColor = true;
            buttonListarOrdenesSeleccion.Click += buttonListarOrdenesSeleccion_Click;
            // 
            // buttonGenerarOrden
            // 
            buttonGenerarOrden.Location = new Point(40, 170);
            buttonGenerarOrden.Name = "buttonGenerarOrden";
            buttonGenerarOrden.Size = new Size(194, 121);
            buttonGenerarOrden.TabIndex = 1;
            buttonGenerarOrden.Text = "Emitir orden de Selección";
            buttonGenerarOrden.UseVisualStyleBackColor = true;
            buttonGenerarOrden.Click += buttonGenerarOrden_Click;
            // 
            // buttonRetirarOrden
            // 
            buttonRetirarOrden.Location = new Point(40, 315);
            buttonRetirarOrden.Name = "buttonRetirarOrden";
            buttonRetirarOrden.Size = new Size(194, 121);
            buttonRetirarOrden.TabIndex = 2;
            buttonRetirarOrden.Text = "Retirar orden de Selección";
            buttonRetirarOrden.UseVisualStyleBackColor = true;
            buttonRetirarOrden.Click += buttonRetirarOrden_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 19);
            label2.Name = "label2";
            label2.Size = new Size(404, 34);
            label2.TabIndex = 62;
            label2.Text = "Menú Ordenes de Selección";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonRetirarOrden);
            groupBox1.Controls.Add(buttonGenerarOrden);
            groupBox1.Controls.Add(buttonListarOrdenesSeleccion);
            groupBox1.Location = new Point(193, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 453);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            // 
            // MenuOrdenesSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 575);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuOrdenesSeleccionForm";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonListarOrdenesSeleccion;
        private Button buttonGenerarOrden;
        private Button buttonRetirarOrden;
        private Label label2;
        private GroupBox groupBox1;
    }
}