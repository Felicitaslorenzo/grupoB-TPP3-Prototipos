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
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonListarOrdenesPreparacion
            // 
            buttonListarOrdenesPreparacion.Location = new Point(48, 22);
            buttonListarOrdenesPreparacion.Name = "buttonListarOrdenesPreparacion";
            buttonListarOrdenesPreparacion.Size = new Size(200, 123);
            buttonListarOrdenesPreparacion.TabIndex = 0;
            buttonListarOrdenesPreparacion.Text = "Listar Ordenes de Preparación";
            buttonListarOrdenesPreparacion.UseVisualStyleBackColor = true;
            buttonListarOrdenesPreparacion.Click += buttonListarOrdenesPreparacion_Click;
            // 
            // buttonGenerarOrden
            // 
            buttonGenerarOrden.Location = new Point(48, 161);
            buttonGenerarOrden.Name = "buttonGenerarOrden";
            buttonGenerarOrden.Size = new Size(200, 123);
            buttonGenerarOrden.TabIndex = 1;
            buttonGenerarOrden.Text = "Emitir Orden de Preparación";
            buttonGenerarOrden.UseVisualStyleBackColor = true;
            buttonGenerarOrden.Click += buttonGenerarOrden_Click;
            // 
            // buttonConsultarStock
            // 
            buttonConsultarStock.Location = new Point(48, 299);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonConsultarStock);
            groupBox1.Controls.Add(buttonGenerarOrden);
            groupBox1.Controls.Add(buttonListarOrdenesPreparacion);
            groupBox1.Location = new Point(198, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 442);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            // 
            // MenuOrdenesPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 551);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuOrdenesPreparacionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MenuOrdenesPreparacionForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonListarOrdenesPreparacion;
        private Button buttonGenerarOrden;
        private Button buttonConsultarStock;
        private Label label2;
        private GroupBox groupBox1;
    }
}