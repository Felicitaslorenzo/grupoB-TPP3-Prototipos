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
            DepositosCombo = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonOrdenesPreparacion
            // 
            buttonOrdenesPreparacion.Location = new Point(241, 85);
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
            buttonOrdenesSeleccion.Location = new Point(241, 167);
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
            buttonOrdenesDeEntrega.Location = new Point(241, 250);
            buttonOrdenesDeEntrega.Margin = new Padding(3, 2, 3, 2);
            buttonOrdenesDeEntrega.Name = "buttonOrdenesDeEntrega";
            buttonOrdenesDeEntrega.Size = new Size(148, 64);
            buttonOrdenesDeEntrega.TabIndex = 2;
            buttonOrdenesDeEntrega.Text = "Ordenes de Entrega";
            buttonOrdenesDeEntrega.UseVisualStyleBackColor = true;
            buttonOrdenesDeEntrega.Click += buttonOrdenesDeEntrega_Click;
            // 
            // DepositosCombo
            // 
            DepositosCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            DepositosCombo.FormattingEnabled = true;
            DepositosCombo.Location = new Point(220, 42);
            DepositosCombo.Name = "DepositosCombo";
            DepositosCombo.Size = new Size(226, 23);
            DepositosCombo.TabIndex = 3;
            DepositosCombo.SelectedIndexChanged += DepositosCombo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 24);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Depósito";
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 328);
            Controls.Add(label1);
            Controls.Add(DepositosCombo);
            Controls.Add(buttonOrdenesDeEntrega);
            Controls.Add(buttonOrdenesSeleccion);
            Controls.Add(buttonOrdenesPreparacion);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipalForm";
            Text = "MenuPrincipalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOrdenesPreparacion;
        private Button buttonOrdenesSeleccion;
        private Button buttonOrdenesDeEntrega;
        private ComboBox DepositosCombo;
        private Label label1;
    }
}