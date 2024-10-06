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
            buttonListarOrdenesSeleccion.Location = new Point(246, 11);
            buttonListarOrdenesSeleccion.Margin = new Padding(3, 2, 3, 2);
            buttonListarOrdenesSeleccion.Name = "buttonListarOrdenesSeleccion";
            buttonListarOrdenesSeleccion.Size = new Size(170, 91);
            buttonListarOrdenesSeleccion.TabIndex = 0;
            buttonListarOrdenesSeleccion.Text = "Listar Órdenes de Selección";
            buttonListarOrdenesSeleccion.UseVisualStyleBackColor = true;
            buttonListarOrdenesSeleccion.Click += buttonListarOrdenesSeleccion_Click;
            // 
            // buttonGenerarOrden
            // 
            buttonGenerarOrden.Location = new Point(246, 236);
            buttonGenerarOrden.Margin = new Padding(3, 2, 3, 2);
            buttonGenerarOrden.Name = "buttonGenerarOrden";
            buttonGenerarOrden.Size = new Size(170, 91);
            buttonGenerarOrden.TabIndex = 1;
            buttonGenerarOrden.Text = "Generar orden de Selección";
            buttonGenerarOrden.UseVisualStyleBackColor = true;
            // 
            // buttonRetirarOrden
            // 
            buttonRetirarOrden.Location = new Point(246, 124);
            buttonRetirarOrden.Margin = new Padding(3, 2, 3, 2);
            buttonRetirarOrden.Name = "buttonRetirarOrden";
            buttonRetirarOrden.Size = new Size(170, 91);
            buttonRetirarOrden.TabIndex = 2;
            buttonRetirarOrden.Text = "Retirar orden de Selección";
            buttonRetirarOrden.UseVisualStyleBackColor = true;
            // 
            // MenuOrdenesSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 338);
            Controls.Add(buttonRetirarOrden);
            Controls.Add(buttonGenerarOrden);
            Controls.Add(buttonListarOrdenesSeleccion);
            Margin = new Padding(3, 2, 3, 2);
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