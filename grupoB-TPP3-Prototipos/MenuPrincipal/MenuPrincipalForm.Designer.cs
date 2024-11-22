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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOrdenesPreparacion
            // 
            buttonOrdenesPreparacion.Location = new Point(83, 24);
            buttonOrdenesPreparacion.Name = "buttonOrdenesPreparacion";
            buttonOrdenesPreparacion.Size = new Size(169, 85);
            buttonOrdenesPreparacion.TabIndex = 0;
            buttonOrdenesPreparacion.Text = "Ordenes de Preparación";
            buttonOrdenesPreparacion.UseVisualStyleBackColor = true;
            buttonOrdenesPreparacion.Click += buttonOrdenesPreparacion_Click;
            // 
            // buttonOrdenesSeleccion
            // 
            buttonOrdenesSeleccion.Location = new Point(83, 134);
            buttonOrdenesSeleccion.Name = "buttonOrdenesSeleccion";
            buttonOrdenesSeleccion.Size = new Size(169, 85);
            buttonOrdenesSeleccion.TabIndex = 1;
            buttonOrdenesSeleccion.Text = "Ordenes de Seleccion";
            buttonOrdenesSeleccion.UseVisualStyleBackColor = true;
            buttonOrdenesSeleccion.Click += buttonOrdenesSeleccion_Click;
            // 
            // buttonOrdenesDeEntrega
            // 
            buttonOrdenesDeEntrega.Location = new Point(83, 244);
            buttonOrdenesDeEntrega.Name = "buttonOrdenesDeEntrega";
            buttonOrdenesDeEntrega.Size = new Size(169, 85);
            buttonOrdenesDeEntrega.TabIndex = 2;
            buttonOrdenesDeEntrega.Text = "Ordenes de Entrega";
            buttonOrdenesDeEntrega.UseVisualStyleBackColor = true;
            buttonOrdenesDeEntrega.Click += buttonOrdenesDeEntrega_Click;
            // 
            // DepositosCombo
            // 
            DepositosCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            DepositosCombo.FormattingEnabled = true;
            DepositosCombo.Location = new Point(41, 49);
            DepositosCombo.Margin = new Padding(3, 4, 3, 4);
            DepositosCombo.Name = "DepositosCombo";
            DepositosCombo.Size = new Size(258, 28);
            DepositosCombo.TabIndex = 3;
            DepositosCombo.SelectedIndexChanged += DepositosCombo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 25);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 4;
            label1.Text = "Depósito";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(DepositosCombo);
            groupBox1.Location = new Point(191, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 109);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonOrdenesDeEntrega);
            groupBox2.Controls.Add(buttonOrdenesSeleccion);
            groupBox2.Controls.Add(buttonOrdenesPreparacion);
            groupBox2.Location = new Point(191, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(336, 347);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(217, 34);
            label2.TabIndex = 62;
            label2.Text = "Menú Principal";
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 578);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MenuPrincipalForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOrdenesPreparacion;
        private Button buttonOrdenesSeleccion;
        private Button buttonOrdenesDeEntrega;
        private ComboBox DepositosCombo;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
    }
}