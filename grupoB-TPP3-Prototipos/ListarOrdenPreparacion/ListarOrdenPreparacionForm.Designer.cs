namespace grupoB_TPP3_Prototipos.ListarOrdenPreparacion
{
    partial class ListarOrdenPreparacionForm
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
            ListarOrdenesPreparacionGroup = new GroupBox();
            IdOrdenPreparacionCombo = new ComboBox();
            IdOrdenPreparacionLabel = new Label();
            IdClienteLabel = new Label();
            IdClienteCombo = new ComboBox();
            NombreClienteLabel = new Label();
            NombreClienteCombo = new ComboBox();
            EstadoOrdenPreparacionLabel = new Label();
            EstadoOrdenPreparacionCombo = new ComboBox();
            PrioridadOrdenPreparacionLabel = new Label();
            PrioridadOrdenPreparacionCombo = new ComboBox();
            FechaOrdenPreparacionPicker = new DateTimePicker();
            FechaOrdenPreparacionLabel = new Label();
            VolverButton = new Button();
            BuscarButton = new Button();
            ListarOrdenesPreparacionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // ListarOrdenesPreparacionGroup
            // 
            ListarOrdenesPreparacionGroup.Controls.Add(BuscarButton);
            ListarOrdenesPreparacionGroup.Controls.Add(VolverButton);
            ListarOrdenesPreparacionGroup.Controls.Add(FechaOrdenPreparacionLabel);
            ListarOrdenesPreparacionGroup.Controls.Add(FechaOrdenPreparacionPicker);
            ListarOrdenesPreparacionGroup.Controls.Add(PrioridadOrdenPreparacionLabel);
            ListarOrdenesPreparacionGroup.Controls.Add(PrioridadOrdenPreparacionCombo);
            ListarOrdenesPreparacionGroup.Controls.Add(EstadoOrdenPreparacionLabel);
            ListarOrdenesPreparacionGroup.Controls.Add(EstadoOrdenPreparacionCombo);
            ListarOrdenesPreparacionGroup.Controls.Add(NombreClienteLabel);
            ListarOrdenesPreparacionGroup.Controls.Add(NombreClienteCombo);
            ListarOrdenesPreparacionGroup.Controls.Add(IdClienteLabel);
            ListarOrdenesPreparacionGroup.Controls.Add(IdClienteCombo);
            ListarOrdenesPreparacionGroup.Controls.Add(IdOrdenPreparacionLabel);
            ListarOrdenesPreparacionGroup.Controls.Add(IdOrdenPreparacionCombo);
            ListarOrdenesPreparacionGroup.Location = new Point(25, 32);
            ListarOrdenesPreparacionGroup.Name = "ListarOrdenesPreparacionGroup";
            ListarOrdenesPreparacionGroup.Size = new Size(1218, 446);
            ListarOrdenesPreparacionGroup.TabIndex = 0;
            ListarOrdenesPreparacionGroup.TabStop = false;
            // 
            // IdOrdenPreparacionCombo
            // 
            IdOrdenPreparacionCombo.FormattingEnabled = true;
            IdOrdenPreparacionCombo.Location = new Point(23, 71);
            IdOrdenPreparacionCombo.Name = "IdOrdenPreparacionCombo";
            IdOrdenPreparacionCombo.Size = new Size(478, 40);
            IdOrdenPreparacionCombo.TabIndex = 0;
            // 
            // IdOrdenPreparacionLabel
            // 
            IdOrdenPreparacionLabel.AutoSize = true;
            IdOrdenPreparacionLabel.Location = new Point(23, 36);
            IdOrdenPreparacionLabel.Name = "IdOrdenPreparacionLabel";
            IdOrdenPreparacionLabel.Size = new Size(111, 32);
            IdOrdenPreparacionLabel.TabIndex = 1;
            IdOrdenPreparacionLabel.Text = "ID Orden";
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(694, 36);
            IdClienteLabel.Name = "IdClienteLabel";
            IdClienteLabel.Size = new Size(119, 32);
            IdClienteLabel.TabIndex = 3;
            IdClienteLabel.Text = "ID Cliente";
            // 
            // IdClienteCombo
            // 
            IdClienteCombo.FormattingEnabled = true;
            IdClienteCombo.Location = new Point(694, 71);
            IdClienteCombo.Name = "IdClienteCombo";
            IdClienteCombo.Size = new Size(478, 40);
            IdClienteCombo.TabIndex = 2;
            // 
            // NombreClienteLabel
            // 
            NombreClienteLabel.AutoSize = true;
            NombreClienteLabel.Location = new Point(694, 143);
            NombreClienteLabel.Name = "NombreClienteLabel";
            NombreClienteLabel.Size = new Size(184, 32);
            NombreClienteLabel.TabIndex = 5;
            NombreClienteLabel.Text = "Nombre Cliente";
            // 
            // NombreClienteCombo
            // 
            NombreClienteCombo.FormattingEnabled = true;
            NombreClienteCombo.Location = new Point(694, 178);
            NombreClienteCombo.Name = "NombreClienteCombo";
            NombreClienteCombo.Size = new Size(478, 40);
            NombreClienteCombo.TabIndex = 4;
            // 
            // EstadoOrdenPreparacionLabel
            // 
            EstadoOrdenPreparacionLabel.AutoSize = true;
            EstadoOrdenPreparacionLabel.Location = new Point(23, 143);
            EstadoOrdenPreparacionLabel.Name = "EstadoOrdenPreparacionLabel";
            EstadoOrdenPreparacionLabel.Size = new Size(84, 32);
            EstadoOrdenPreparacionLabel.TabIndex = 7;
            EstadoOrdenPreparacionLabel.Text = "Estado";
            // 
            // EstadoOrdenPreparacionCombo
            // 
            EstadoOrdenPreparacionCombo.FormattingEnabled = true;
            EstadoOrdenPreparacionCombo.Location = new Point(23, 178);
            EstadoOrdenPreparacionCombo.Name = "EstadoOrdenPreparacionCombo";
            EstadoOrdenPreparacionCombo.Size = new Size(218, 40);
            EstadoOrdenPreparacionCombo.TabIndex = 6;
            // 
            // PrioridadOrdenPreparacionLabel
            // 
            PrioridadOrdenPreparacionLabel.AutoSize = true;
            PrioridadOrdenPreparacionLabel.Location = new Point(283, 143);
            PrioridadOrdenPreparacionLabel.Name = "PrioridadOrdenPreparacionLabel";
            PrioridadOrdenPreparacionLabel.Size = new Size(109, 32);
            PrioridadOrdenPreparacionLabel.TabIndex = 9;
            PrioridadOrdenPreparacionLabel.Text = "Prioridad";
            // 
            // PrioridadOrdenPreparacionCombo
            // 
            PrioridadOrdenPreparacionCombo.FormattingEnabled = true;
            PrioridadOrdenPreparacionCombo.Location = new Point(283, 178);
            PrioridadOrdenPreparacionCombo.Name = "PrioridadOrdenPreparacionCombo";
            PrioridadOrdenPreparacionCombo.Size = new Size(218, 40);
            PrioridadOrdenPreparacionCombo.TabIndex = 8;
            // 
            // FechaOrdenPreparacionPicker
            // 
            FechaOrdenPreparacionPicker.Location = new Point(23, 281);
            FechaOrdenPreparacionPicker.Name = "FechaOrdenPreparacionPicker";
            FechaOrdenPreparacionPicker.Size = new Size(478, 39);
            FechaOrdenPreparacionPicker.TabIndex = 10;
            // 
            // FechaOrdenPreparacionLabel
            // 
            FechaOrdenPreparacionLabel.AutoSize = true;
            FechaOrdenPreparacionLabel.Location = new Point(23, 246);
            FechaOrdenPreparacionLabel.Name = "FechaOrdenPreparacionLabel";
            FechaOrdenPreparacionLabel.Size = new Size(76, 32);
            FechaOrdenPreparacionLabel.TabIndex = 11;
            FechaOrdenPreparacionLabel.Text = "Fecha";
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(694, 386);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(208, 47);
            VolverButton.TabIndex = 12;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(964, 386);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(208, 47);
            BuscarButton.TabIndex = 13;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // ListarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 982);
            Controls.Add(ListarOrdenesPreparacionGroup);
            Name = "ListarOrdenPreparacionForm";
            Text = "Listar Órdenes de Preparación";
            ListarOrdenesPreparacionGroup.ResumeLayout(false);
            ListarOrdenesPreparacionGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ListarOrdenesPreparacionGroup;
        private Label NombreClienteLabel;
        private ComboBox NombreClienteCombo;
        private Label IdClienteLabel;
        private ComboBox IdClienteCombo;
        private Label IdOrdenPreparacionLabel;
        private ComboBox IdOrdenPreparacionCombo;
        private Label PrioridadOrdenPreparacionLabel;
        private ComboBox PrioridadOrdenPreparacionCombo;
        private Label EstadoOrdenPreparacionLabel;
        private ComboBox EstadoOrdenPreparacionCombo;
        private Button BuscarButton;
        private Button VolverButton;
        private Label FechaOrdenPreparacionLabel;
        private DateTimePicker FechaOrdenPreparacionPicker;
    }
}