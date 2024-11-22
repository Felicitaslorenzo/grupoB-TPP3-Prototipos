namespace grupoB_TPP3_Prototipos.MenuOrdenesEntrega
{
    partial class MenuOrdenesEntregaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuOrdenesEntregaForm));
            buttonListarOrdenesEntrega = new Button();
            buttonDespacharOrdenEntrega = new Button();
            buttonGenerarOrdenEntrega = new Button();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonListarOrdenesEntrega
            // 
            buttonListarOrdenesEntrega.Location = new Point(259, 215);
            buttonListarOrdenesEntrega.Name = "buttonListarOrdenesEntrega";
            buttonListarOrdenesEntrega.Size = new Size(173, 97);
            buttonListarOrdenesEntrega.TabIndex = 0;
            buttonListarOrdenesEntrega.Text = "Listar Ordenes de Entrega";
            buttonListarOrdenesEntrega.UseVisualStyleBackColor = true;
            buttonListarOrdenesEntrega.Click += buttonListarOrdenesEntrega_Click;
            // 
            // buttonDespacharOrdenEntrega
            // 
            buttonDespacharOrdenEntrega.Location = new Point(259, 460);
            buttonDespacharOrdenEntrega.Name = "buttonDespacharOrdenEntrega";
            buttonDespacharOrdenEntrega.Size = new Size(173, 97);
            buttonDespacharOrdenEntrega.TabIndex = 1;
            buttonDespacharOrdenEntrega.Text = "Despachar Ordenes";
            buttonDespacharOrdenEntrega.UseVisualStyleBackColor = true;
            buttonDespacharOrdenEntrega.Click += buttonDespacharOrdenEntrega_Click;
            // 
            // buttonGenerarOrdenEntrega
            // 
            buttonGenerarOrdenEntrega.Location = new Point(259, 335);
            buttonGenerarOrdenEntrega.Name = "buttonGenerarOrdenEntrega";
            buttonGenerarOrdenEntrega.Size = new Size(173, 97);
            buttonGenerarOrdenEntrega.TabIndex = 2;
            buttonGenerarOrdenEntrega.Text = "Emitir Orden de Entrega ";
            buttonGenerarOrdenEntrega.UseVisualStyleBackColor = true;
            buttonGenerarOrdenEntrega.Click += buttonGenerarOrdenEntrega_Click;
            // 
            // button1
            // 
            button1.Location = new Point(259, 93);
            button1.Name = "button1";
            button1.Size = new Size(173, 97);
            button1.TabIndex = 3;
            button1.Text = "Empaquetado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(371, 34);
            label2.TabIndex = 61;
            label2.Text = "Menú Ordenes de Entrega";
            // 
            // MenuOrdenesEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 600);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(buttonGenerarOrdenEntrega);
            Controls.Add(buttonDespacharOrdenEntrega);
            Controls.Add(buttonListarOrdenesEntrega);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuOrdenesEntregaForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonListarOrdenesEntrega;
        private Button buttonDespacharOrdenEntrega;
        private Button buttonGenerarOrdenEntrega;
        private Button button1;
        private Label label2;
    }
}