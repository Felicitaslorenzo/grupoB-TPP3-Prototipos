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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuOrdenesPreparacionForm));
            buttonListarOrdenesPreparacion = new Button();
            buttonGenerarOrden = new Button();
            buttonConsultarStock = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonListarOrdenesPreparacion
            // 
            buttonListarOrdenesPreparacion.Location = new Point(246, 92);
            buttonListarOrdenesPreparacion.Name = "buttonListarOrdenesPreparacion";
            buttonListarOrdenesPreparacion.Size = new Size(200, 123);
            buttonListarOrdenesPreparacion.TabIndex = 0;
            buttonListarOrdenesPreparacion.Text = "Listar Ordenes de Preparación";
            buttonListarOrdenesPreparacion.UseVisualStyleBackColor = true;
            buttonListarOrdenesPreparacion.Click += buttonListarOrdenesPreparacion_Click;
            // 
            // buttonGenerarOrden
            // 
            buttonGenerarOrden.Location = new Point(246, 231);
            buttonGenerarOrden.Name = "buttonGenerarOrden";
            buttonGenerarOrden.Size = new Size(200, 123);
            buttonGenerarOrden.TabIndex = 1;
            buttonGenerarOrden.Text = "Emitir Orden de Preparación";
            buttonGenerarOrden.UseVisualStyleBackColor = true;
            buttonGenerarOrden.Click += buttonGenerarOrden_Click;
            // 
            // buttonConsultarStock
            // 
            buttonConsultarStock.Location = new Point(246, 369);
            buttonConsultarStock.Name = "buttonConsultarStock";
            buttonConsultarStock.Size = new Size(200, 123);
            buttonConsultarStock.TabIndex = 2;
            buttonConsultarStock.Text = "Consultar Stock";
            buttonConsultarStock.UseVisualStyleBackColor = true;
            buttonConsultarStock.Click += buttonConsultarStock_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(434, 34);
            label2.TabIndex = 62;
            label2.Text = "Menú Ordenes de Preparación";
            // 
            // MenuOrdenesPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 551);
            Controls.Add(label2);
            Controls.Add(buttonConsultarStock);
            Controls.Add(buttonGenerarOrden);
            Controls.Add(buttonListarOrdenesPreparacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuOrdenesPreparacionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MenuOrdenesPreparacionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonListarOrdenesPreparacion;
        private Button buttonGenerarOrden;
        private Button buttonConsultarStock;
        private Label label2;
    }
}