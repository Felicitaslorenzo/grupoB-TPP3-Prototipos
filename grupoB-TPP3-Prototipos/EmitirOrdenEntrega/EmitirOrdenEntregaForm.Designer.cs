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
            SuspendLayout();
            // 
            // OrdenesEntregalistView
            // 
            OrdenesEntregalistView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionColumna, ClienteColumna, FechaEntregaColumna });
            OrdenesEntregalistView.Location = new Point(16, 18);
            OrdenesEntregalistView.Name = "OrdenesEntregalistView";
            OrdenesEntregalistView.Size = new Size(740, 526);
            OrdenesEntregalistView.TabIndex = 7;
            OrdenesEntregalistView.UseCompatibleStateImageBehavior = false;
            OrdenesEntregalistView.View = View.Details;
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
            VolverButton.Location = new Point(583, 577);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(173, 53);
            VolverButton.TabIndex = 15;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // GenerarOEbutton
            // 
            GenerarOEbutton.Location = new Point(324, 577);
            GenerarOEbutton.Name = "GenerarOEbutton";
            GenerarOEbutton.Size = new Size(244, 53);
            GenerarOEbutton.TabIndex = 16;
            GenerarOEbutton.Text = "Emitir Orden de Entrega";
            GenerarOEbutton.UseVisualStyleBackColor = true;
            // 
            // EmitirOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 653);
            Controls.Add(GenerarOEbutton);
            Controls.Add(VolverButton);
            Controls.Add(OrdenesEntregalistView);
            MaximizeBox = false;
            Name = "EmitirOrdenEntregaForm";
            Text = "Emitir Orden de Entrega";
            ResumeLayout(false);
        }

        #endregion
        private ListView OrdenesEntregalistView;
        private Button VolverButton;
        private Button GenerarOEbutton;
        private ColumnHeader ClienteColumna;
        private ColumnHeader FechaEntregaColumna;
        private ColumnHeader IdOrdenPreparacionColumna;
    }
}