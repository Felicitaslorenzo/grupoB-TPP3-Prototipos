namespace grupoB_TPP3_Prototipos.GenerarOrdenEntrega
{
    partial class GenerarOrdenEntregaForm
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
            OrdenesEntregalistView.Location = new Point(11, 11);
            OrdenesEntregalistView.Margin = new Padding(2, 2, 2, 2);
            OrdenesEntregalistView.Name = "OrdenesEntregalistView";
            OrdenesEntregalistView.Size = new Size(519, 317);
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
            VolverButton.Location = new Point(408, 346);
            VolverButton.Margin = new Padding(2, 2, 2, 2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(121, 32);
            VolverButton.TabIndex = 15;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // GenerarOEbutton
            // 
            GenerarOEbutton.Location = new Point(227, 346);
            GenerarOEbutton.Margin = new Padding(2, 2, 2, 2);
            GenerarOEbutton.Name = "GenerarOEbutton";
            GenerarOEbutton.Size = new Size(171, 32);
            GenerarOEbutton.TabIndex = 16;
            GenerarOEbutton.Text = "Generar Orden de Entrega";
            GenerarOEbutton.UseVisualStyleBackColor = true;
            // 
            // GenerarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 392);
            Controls.Add(GenerarOEbutton);
            Controls.Add(VolverButton);
            Controls.Add(OrdenesEntregalistView);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "GenerarOrdenEntregaForm";
            Text = "Generar Orden de Entrega";
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