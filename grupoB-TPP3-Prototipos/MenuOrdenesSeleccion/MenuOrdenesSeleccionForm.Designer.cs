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
            buttonListarOrdenesSeleccion = new Button();
            buttonGenerarOrden = new Button();
            buttonRetirarOrden = new Button();
            SuspendLayout();
            // 
            // buttonListarOrdenesSeleccion
            // 
            buttonListarOrdenesSeleccion.Location = new Point(281, 15);
            buttonListarOrdenesSeleccion.Name = "buttonListarOrdenesSeleccion";
            buttonListarOrdenesSeleccion.Size = new Size(194, 121);
            buttonListarOrdenesSeleccion.TabIndex = 0;
            buttonListarOrdenesSeleccion.Text = "Listar Órdenes de Selección";
            buttonListarOrdenesSeleccion.UseVisualStyleBackColor = true;
            buttonListarOrdenesSeleccion.Click += buttonListarOrdenesSeleccion_Click;
            // 
            // buttonGenerarOrden
            // 
            buttonGenerarOrden.Location = new Point(281, 315);
            buttonGenerarOrden.Name = "buttonGenerarOrden";
            buttonGenerarOrden.Size = new Size(194, 121);
            buttonGenerarOrden.TabIndex = 1;
            buttonGenerarOrden.Text = "Generar orden de Selección";
            buttonGenerarOrden.UseVisualStyleBackColor = true;
            buttonGenerarOrden.Click += buttonGenerarOrden_Click;
            // 
            // buttonRetirarOrden
            // 
            buttonRetirarOrden.Location = new Point(281, 165);
            buttonRetirarOrden.Name = "buttonRetirarOrden";
            buttonRetirarOrden.Size = new Size(194, 121);
            buttonRetirarOrden.TabIndex = 2;
            buttonRetirarOrden.Text = "Retirar orden de Selección";
            buttonRetirarOrden.UseVisualStyleBackColor = true;
            buttonRetirarOrden.Click += buttonRetirarOrden_Click;
            // 
            // MenuOrdenesSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 451);
            Controls.Add(buttonRetirarOrden);
            Controls.Add(buttonGenerarOrden);
            Controls.Add(buttonListarOrdenesSeleccion);
            Name = "MenuOrdenesSeleccionForm";
            Text = "MenuOrdenesSeleccionForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonListarOrdenesSeleccion;
        private Button buttonGenerarOrden;
        private Button buttonRetirarOrden;
    }
}