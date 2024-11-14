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
            OrdenesEntregalistView.FullRowSelect = true;
            OrdenesEntregalistView.Location = new Point(13, 14);
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
            VolverButton.Location = new Point(466, 462);
            VolverButton.Margin = new Padding(2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(138, 42);
            VolverButton.TabIndex = 15;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // GenerarOEbutton
            // 
            GenerarOEbutton.Location = new Point(259, 462);
            GenerarOEbutton.Margin = new Padding(2);
            GenerarOEbutton.Name = "GenerarOEbutton";
            GenerarOEbutton.Size = new Size(195, 42);
            GenerarOEbutton.TabIndex = 16;
            GenerarOEbutton.Text = "Emitir Orden de Entrega";
            GenerarOEbutton.UseVisualStyleBackColor = true;
            GenerarOEbutton.Click += GenerarOEbutton_Click;
            // 
            // EmitirOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 522);
            Controls.Add(GenerarOEbutton);
            Controls.Add(VolverButton);
            Controls.Add(OrdenesEntregalistView);
            Margin = new Padding(2);
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