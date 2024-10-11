namespace grupoB_TPP3_Prototipos.MenuOrdenesPreparacion
{
    partial class MenuOrdenesPreparacionForm
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
            buttonListarOrdenesPreparacion = new Button();
            buttonGenerarOrden = new Button();
            SuspendLayout();
            // 
            // buttonListarOrdenesPreparacion
            // 
            buttonListarOrdenesPreparacion.Location = new Point(272, 65);
            buttonListarOrdenesPreparacion.Name = "buttonListarOrdenesPreparacion";
            buttonListarOrdenesPreparacion.Size = new Size(200, 123);
            buttonListarOrdenesPreparacion.TabIndex = 0;
            buttonListarOrdenesPreparacion.Text = "Listar Ordenes de Preparación";
            buttonListarOrdenesPreparacion.UseVisualStyleBackColor = true;
            buttonListarOrdenesPreparacion.Click += buttonListarOrdenesPreparacion_Click;
            // 
            // buttonGenerarOrden
            // 
            buttonGenerarOrden.Location = new Point(272, 240);
            buttonGenerarOrden.Name = "buttonGenerarOrden";
            buttonGenerarOrden.Size = new Size(200, 123);
            buttonGenerarOrden.TabIndex = 1;
            buttonGenerarOrden.Text = "Generar Orden de Preparación";
            buttonGenerarOrden.UseVisualStyleBackColor = true;
            buttonGenerarOrden.Click += buttonGenerarOrden_Click;
            // 
            // MenuOrdenesPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 443);
            Controls.Add(buttonGenerarOrden);
            Controls.Add(buttonListarOrdenesPreparacion);
            Name = "MenuOrdenesPreparacionForm";
            Text = "MenuOrdenesPreparacionForm";
            Load += MenuOrdenesPreparacionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonListarOrdenesPreparacion;
        private Button buttonGenerarOrden;
    }
}