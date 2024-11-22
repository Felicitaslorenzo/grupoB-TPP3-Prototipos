namespace grupoB_TPP3_Prototipos.GenerarOrdenEntrega
{
    partial class EmitirOrdenEntregaForm
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
            OrdenesEntregalistView = new ListView();
            IdOrdenPreparacionColumna = new ColumnHeader();
            ClienteColumna = new ColumnHeader();
            FechaEntregaColumna = new ColumnHeader();
            VolverButton = new Button();
            GenerarOEbutton = new Button();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // OrdenesEntregalistView
            // 
            OrdenesEntregalistView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionColumna, ClienteColumna, FechaEntregaColumna });
            OrdenesEntregalistView.FullRowSelect = true;
            OrdenesEntregalistView.Location = new Point(22, 89);
            OrdenesEntregalistView.Margin = new Padding(2);
            OrdenesEntregalistView.Name = "OrdenesEntregalistView";
            OrdenesEntregalistView.Size = new Size(593, 422);
            OrdenesEntregalistView.TabIndex = 7;
            OrdenesEntregalistView.UseCompatibleStateImageBehavior = false;
            OrdenesEntregalistView.View = View.Details;
            OrdenesEntregalistView.SelectedIndexChanged += OrdenesEntregalistView_SelectedIndexChanged;
            // 
            // IdOrdenPreparacionColumna
            // 
            IdOrdenPreparacionColumna.Text = "Id Orden";
            IdOrdenPreparacionColumna.Width = 120;
            // 
            // ClienteColumna
            // 
            ClienteColumna.Text = "Cliente";
            ClienteColumna.Width = 120;
            // 
            // FechaEntregaColumna
            // 
            FechaEntregaColumna.Text = "Fecha Entrega";
            FechaEntregaColumna.Width = 180;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(474, 535);
            VolverButton.Margin = new Padding(2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(141, 54);
            VolverButton.TabIndex = 15;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // GenerarOEbutton
            // 
            GenerarOEbutton.Location = new Point(224, 535);
            GenerarOEbutton.Margin = new Padding(2);
            GenerarOEbutton.Name = "GenerarOEbutton";
            GenerarOEbutton.Size = new Size(213, 54);
            GenerarOEbutton.TabIndex = 16;
            GenerarOEbutton.Text = "Emitir Orden de Entrega";
            GenerarOEbutton.UseVisualStyleBackColor = true;
            GenerarOEbutton.Click += GenerarOEbutton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(322, 34);
            label2.TabIndex = 55;
            label2.Text = "Emitir Ordenes Entrega";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 52);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 56;
            label4.Text = "label4";
            // 
            // EmitirOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 611);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(GenerarOEbutton);
            Controls.Add(VolverButton);
            Controls.Add(OrdenesEntregalistView);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "EmitirOrdenEntregaForm";
            Text = "Emitir Orden de Entrega";
            Load += EmitirOrdenEntregaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView OrdenesEntregalistView;
        private Button VolverButton;
        private Button GenerarOEbutton;
        private ColumnHeader ClienteColumna;
        private ColumnHeader FechaEntregaColumna;
        private ColumnHeader IdOrdenPreparacionColumna;
        private Label label2;
        private Label label4;
    }
}