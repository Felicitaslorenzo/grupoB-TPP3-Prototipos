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
            buttonListarOrdenesEntrega = new Button();
            buttonDespacharOrdenEntrega = new Button();
            buttonGenerarOrdenEntrega = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonListarOrdenesEntrega
            // 
            buttonListarOrdenesEntrega.Location = new Point(278, 182);
            buttonListarOrdenesEntrega.Margin = new Padding(4, 4, 4, 4);
            buttonListarOrdenesEntrega.Name = "buttonListarOrdenesEntrega";
            buttonListarOrdenesEntrega.Size = new Size(216, 121);
            buttonListarOrdenesEntrega.TabIndex = 0;
            buttonListarOrdenesEntrega.Text = "Listar Ordenes de Entrega";
            buttonListarOrdenesEntrega.UseVisualStyleBackColor = true;
            buttonListarOrdenesEntrega.Click += buttonListarOrdenesEntrega_Click;
            // 
            // buttonDespacharOrdenEntrega
            // 
            buttonDespacharOrdenEntrega.Location = new Point(278, 489);
            buttonDespacharOrdenEntrega.Margin = new Padding(4, 4, 4, 4);
            buttonDespacharOrdenEntrega.Name = "buttonDespacharOrdenEntrega";
            buttonDespacharOrdenEntrega.Size = new Size(216, 121);
            buttonDespacharOrdenEntrega.TabIndex = 1;
            buttonDespacharOrdenEntrega.Text = "Despachar Orden de Entrega";
            buttonDespacharOrdenEntrega.UseVisualStyleBackColor = true;
            buttonDespacharOrdenEntrega.Click += buttonDespacharOrdenEntrega_Click;
            // 
            // buttonGenerarOrdenEntrega
            // 
            buttonGenerarOrdenEntrega.Location = new Point(278, 332);
            buttonGenerarOrdenEntrega.Margin = new Padding(4, 4, 4, 4);
            buttonGenerarOrdenEntrega.Name = "buttonGenerarOrdenEntrega";
            buttonGenerarOrdenEntrega.Size = new Size(216, 121);
            buttonGenerarOrdenEntrega.TabIndex = 2;
            buttonGenerarOrdenEntrega.Text = "Emitir Orden de Entrega ";
            buttonGenerarOrdenEntrega.UseVisualStyleBackColor = true;
            buttonGenerarOrdenEntrega.Click += buttonGenerarOrdenEntrega_Click;
            // 
            // button1
            // 
            button1.Location = new Point(278, 30);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(216, 121);
            button1.TabIndex = 3;
            button1.Text = "Empaquetado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MenuOrdenesEntregaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 644);
            Controls.Add(button1);
            Controls.Add(buttonGenerarOrdenEntrega);
            Controls.Add(buttonDespacharOrdenEntrega);
            Controls.Add(buttonListarOrdenesEntrega);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MenuOrdenesEntregaForm";
            Text = "MenuOrdenesEntregaForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonListarOrdenesEntrega;
        private Button buttonDespacharOrdenEntrega;
        private Button buttonGenerarOrdenEntrega;
        private Button button1;
    }
}