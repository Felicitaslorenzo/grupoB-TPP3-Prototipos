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
            buttonListarOrdenesPreparacion.Location = new Point(340, 81);
            buttonListarOrdenesPreparacion.Margin = new Padding(4, 4, 4, 4);
            buttonListarOrdenesPreparacion.Name = "buttonListarOrdenesPreparacion";
            buttonListarOrdenesPreparacion.Size = new Size(250, 154);
            buttonListarOrdenesPreparacion.TabIndex = 0;
            buttonListarOrdenesPreparacion.Text = "Listar Ordenes de Preparación";
            buttonListarOrdenesPreparacion.UseVisualStyleBackColor = true;
            buttonListarOrdenesPreparacion.Click += buttonListarOrdenesPreparacion_Click;
            // 
            // buttonGenerarOrden
            // 
            buttonGenerarOrden.Location = new Point(340, 300);
            buttonGenerarOrden.Margin = new Padding(4, 4, 4, 4);
            buttonGenerarOrden.Name = "buttonGenerarOrden";
            buttonGenerarOrden.Size = new Size(250, 154);
            buttonGenerarOrden.TabIndex = 1;
            buttonGenerarOrden.Text = "Emitir Orden de Preparación";
            buttonGenerarOrden.UseVisualStyleBackColor = true;
            buttonGenerarOrden.Click += buttonGenerarOrden_Click;
            // 
            // MenuOrdenesPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 554);
            Controls.Add(buttonGenerarOrden);
            Controls.Add(buttonListarOrdenesPreparacion);
            Margin = new Padding(4, 4, 4, 4);
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