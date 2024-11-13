namespace grupoB_TPP3_Prototipos.MenuPrincipal
{
    partial class MenuPrincipalForm
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
            buttonOrdenesPreparacion = new Button();
            buttonOrdenesSeleccion = new Button();
            buttonOrdenesDeEntrega = new Button();
            SuspendLayout();
            // 
            // buttonOrdenesPreparacion
            // 
            buttonOrdenesPreparacion.Location = new Point(238, 45);
            buttonOrdenesPreparacion.Margin = new Padding(3, 2, 3, 2);
            buttonOrdenesPreparacion.Name = "buttonOrdenesPreparacion";
            buttonOrdenesPreparacion.Size = new Size(148, 64);
            buttonOrdenesPreparacion.TabIndex = 0;
            buttonOrdenesPreparacion.Text = "Ordenes de Preparación";
            buttonOrdenesPreparacion.UseVisualStyleBackColor = true;
            buttonOrdenesPreparacion.Click += buttonOrdenesPreparacion_Click;
            // 
            // buttonOrdenesSeleccion
            // 
            buttonOrdenesSeleccion.Location = new Point(238, 127);
            buttonOrdenesSeleccion.Margin = new Padding(3, 2, 3, 2);
            buttonOrdenesSeleccion.Name = "buttonOrdenesSeleccion";
            buttonOrdenesSeleccion.Size = new Size(148, 64);
            buttonOrdenesSeleccion.TabIndex = 1;
            buttonOrdenesSeleccion.Text = "Ordenes de Seleccion";
            buttonOrdenesSeleccion.UseVisualStyleBackColor = true;
            buttonOrdenesSeleccion.Click += buttonOrdenesSeleccion_Click;
            // 
            // buttonOrdenesDeEntrega
            // 
            buttonOrdenesDeEntrega.Location = new Point(238, 210);
            buttonOrdenesDeEntrega.Margin = new Padding(3, 2, 3, 2);
            buttonOrdenesDeEntrega.Name = "buttonOrdenesDeEntrega";
            buttonOrdenesDeEntrega.Size = new Size(148, 64);
            buttonOrdenesDeEntrega.TabIndex = 2;
            buttonOrdenesDeEntrega.Text = "Ordenes de Entrega";
            buttonOrdenesDeEntrega.UseVisualStyleBackColor = true;
            buttonOrdenesDeEntrega.Click += buttonOrdenesDeEntrega_Click;
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 328);
            Controls.Add(buttonOrdenesDeEntrega);
            Controls.Add(buttonOrdenesSeleccion);
            Controls.Add(buttonOrdenesPreparacion);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipalForm";
            Text = "MenuPrincipalForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOrdenesPreparacion;
        private Button buttonOrdenesSeleccion;
        private Button buttonOrdenesDeEntrega;
    }
}