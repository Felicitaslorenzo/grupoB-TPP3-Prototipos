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
            BuscarButton = new Button();
            VolverButton = new Button();
            FechaOrdenPreparacionLabel = new Label();
            FechaOrdenPreparacionPicker = new DateTimePicker();
            PrioridadOrdenPreparacionLabel = new Label();
            PrioridadOrdenPreparacionCombo = new ComboBox();
            EstadoOrdenPreparacionLabel = new Label();
            EstadoOrdenPreparacionCombo = new ComboBox();
            NombreClienteLabel = new Label();
            NombreClienteCombo = new ComboBox();
            IdClienteLabel = new Label();
            IdClienteCombo = new ComboBox();
            IdOrdenPreparacionLabel = new Label();
            IdOrdenPreparacionCombo = new ComboBox();
            ListaOrdenesPreparacionGroup = new GroupBox();
            VolverListaButton = new Button();
            OrdenesPreparacionList = new ListView();
            IdOrdenColumna = new ColumnHeader();
            idClienteColumna = new ColumnHeader();
            nombreClienteColumna = new ColumnHeader();
            estadoOrdenColumna = new ColumnHeader();
            fechaOrdenColumna = new ColumnHeader();
            ListarOrdenesPreparacionGroup.SuspendLayout();
            ListaOrdenesPreparacionGroup.SuspendLayout();
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
            ListarOrdenesPreparacionGroup.Location = new Point(19, 25);
            ListarOrdenesPreparacionGroup.Margin = new Padding(2);
            ListarOrdenesPreparacionGroup.Name = "ListarOrdenesPreparacionGroup";
            ListarOrdenesPreparacionGroup.Padding = new Padding(2);
            ListarOrdenesPreparacionGroup.Size = new Size(937, 348);
            ListarOrdenesPreparacionGroup.TabIndex = 0;
            ListarOrdenesPreparacionGroup.TabStop = false;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(742, 302);
            BuscarButton.Margin = new Padding(2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(160, 37);
            BuscarButton.TabIndex = 13;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(534, 302);
            VolverButton.Margin = new Padding(2);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(160, 37);
            VolverButton.TabIndex = 12;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // FechaOrdenPreparacionLabel
            // 
            FechaOrdenPreparacionLabel.AutoSize = true;
            FechaOrdenPreparacionLabel.Location = new Point(18, 192);
            FechaOrdenPreparacionLabel.Margin = new Padding(2, 0, 2, 0);
            FechaOrdenPreparacionLabel.Name = "FechaOrdenPreparacionLabel";
            FechaOrdenPreparacionLabel.Size = new Size(57, 25);
            FechaOrdenPreparacionLabel.TabIndex = 11;
            FechaOrdenPreparacionLabel.Text = "Fecha";
            // 
            // FechaOrdenPreparacionPicker
            // 
            FechaOrdenPreparacionPicker.Location = new Point(18, 220);
            FechaOrdenPreparacionPicker.Margin = new Padding(2);
            FechaOrdenPreparacionPicker.Name = "FechaOrdenPreparacionPicker";
            FechaOrdenPreparacionPicker.Size = new Size(369, 31);
            FechaOrdenPreparacionPicker.TabIndex = 10;
            // 
            // PrioridadOrdenPreparacionLabel
            // 
            PrioridadOrdenPreparacionLabel.AutoSize = true;
            PrioridadOrdenPreparacionLabel.Location = new Point(218, 112);
            PrioridadOrdenPreparacionLabel.Margin = new Padding(2, 0, 2, 0);
            PrioridadOrdenPreparacionLabel.Name = "PrioridadOrdenPreparacionLabel";
            PrioridadOrdenPreparacionLabel.Size = new Size(84, 25);
            PrioridadOrdenPreparacionLabel.TabIndex = 9;
            PrioridadOrdenPreparacionLabel.Text = "Prioridad";
            // 
            // PrioridadOrdenPreparacionCombo
            // 
            PrioridadOrdenPreparacionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            PrioridadOrdenPreparacionCombo.FormattingEnabled = true;
            PrioridadOrdenPreparacionCombo.Location = new Point(218, 139);
            PrioridadOrdenPreparacionCombo.Margin = new Padding(2);
            PrioridadOrdenPreparacionCombo.Name = "PrioridadOrdenPreparacionCombo";
            PrioridadOrdenPreparacionCombo.Size = new Size(169, 33);
            PrioridadOrdenPreparacionCombo.TabIndex = 8;
            // 
            // EstadoOrdenPreparacionLabel
            // 
            EstadoOrdenPreparacionLabel.AutoSize = true;
            EstadoOrdenPreparacionLabel.Location = new Point(18, 112);
            EstadoOrdenPreparacionLabel.Margin = new Padding(2, 0, 2, 0);
            EstadoOrdenPreparacionLabel.Name = "EstadoOrdenPreparacionLabel";
            EstadoOrdenPreparacionLabel.Size = new Size(66, 25);
            EstadoOrdenPreparacionLabel.TabIndex = 7;
            EstadoOrdenPreparacionLabel.Text = "Estado";
            // 
            // EstadoOrdenPreparacionCombo
            // 
            EstadoOrdenPreparacionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            EstadoOrdenPreparacionCombo.FormattingEnabled = true;
            EstadoOrdenPreparacionCombo.Location = new Point(18, 139);
            EstadoOrdenPreparacionCombo.Margin = new Padding(2);
            EstadoOrdenPreparacionCombo.Name = "EstadoOrdenPreparacionCombo";
            EstadoOrdenPreparacionCombo.Size = new Size(169, 33);
            EstadoOrdenPreparacionCombo.TabIndex = 6;
            // 
            // NombreClienteLabel
            // 
            NombreClienteLabel.AutoSize = true;
            NombreClienteLabel.Location = new Point(534, 112);
            NombreClienteLabel.Margin = new Padding(2, 0, 2, 0);
            NombreClienteLabel.Name = "NombreClienteLabel";
            NombreClienteLabel.Size = new Size(136, 25);
            NombreClienteLabel.TabIndex = 5;
            NombreClienteLabel.Text = "Nombre Cliente";
            // 
            // NombreClienteCombo
            // 
            NombreClienteCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            NombreClienteCombo.FormattingEnabled = true;
            NombreClienteCombo.Location = new Point(534, 139);
            NombreClienteCombo.Margin = new Padding(2);
            NombreClienteCombo.Name = "NombreClienteCombo";
            NombreClienteCombo.Size = new Size(369, 33);
            NombreClienteCombo.TabIndex = 4;
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(534, 28);
            IdClienteLabel.Margin = new Padding(2, 0, 2, 0);
            IdClienteLabel.Name = "IdClienteLabel";
            IdClienteLabel.Size = new Size(88, 25);
            IdClienteLabel.TabIndex = 3;
            IdClienteLabel.Text = "ID Cliente";
            // 
            // IdClienteCombo
            // 
            IdClienteCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdClienteCombo.FormattingEnabled = true;
            IdClienteCombo.Location = new Point(534, 55);
            IdClienteCombo.Margin = new Padding(2);
            IdClienteCombo.Name = "IdClienteCombo";
            IdClienteCombo.Size = new Size(369, 33);
            IdClienteCombo.TabIndex = 2;
            // 
            // IdOrdenPreparacionLabel
            // 
            IdOrdenPreparacionLabel.AutoSize = true;
            IdOrdenPreparacionLabel.Location = new Point(18, 28);
            IdOrdenPreparacionLabel.Margin = new Padding(2, 0, 2, 0);
            IdOrdenPreparacionLabel.Name = "IdOrdenPreparacionLabel";
            IdOrdenPreparacionLabel.Size = new Size(85, 25);
            IdOrdenPreparacionLabel.TabIndex = 1;
            IdOrdenPreparacionLabel.Text = "ID Orden";
            // 
            // IdOrdenPreparacionCombo
            // 
            IdOrdenPreparacionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdOrdenPreparacionCombo.FormattingEnabled = true;
            IdOrdenPreparacionCombo.Location = new Point(18, 55);
            IdOrdenPreparacionCombo.Margin = new Padding(2);
            IdOrdenPreparacionCombo.Name = "IdOrdenPreparacionCombo";
            IdOrdenPreparacionCombo.Size = new Size(369, 33);
            IdOrdenPreparacionCombo.TabIndex = 0;
            // 
            // ListaOrdenesPreparacionGroup
            // 
            ListaOrdenesPreparacionGroup.Controls.Add(VolverListaButton);
            ListaOrdenesPreparacionGroup.Controls.Add(OrdenesPreparacionList);
            ListaOrdenesPreparacionGroup.Location = new Point(18, 401);
            ListaOrdenesPreparacionGroup.Margin = new Padding(2);
            ListaOrdenesPreparacionGroup.Name = "ListaOrdenesPreparacionGroup";
            ListaOrdenesPreparacionGroup.Padding = new Padding(2);
            ListaOrdenesPreparacionGroup.Size = new Size(938, 347);
            ListaOrdenesPreparacionGroup.TabIndex = 1;
            ListaOrdenesPreparacionGroup.TabStop = false;
            // 
            // VolverListaButton
            // 
            VolverListaButton.Location = new Point(768, 299);
            VolverListaButton.Margin = new Padding(2);
            VolverListaButton.Name = "VolverListaButton";
            VolverListaButton.Size = new Size(160, 37);
            VolverListaButton.TabIndex = 14;
            VolverListaButton.Text = "Volver";
            VolverListaButton.UseVisualStyleBackColor = true;
            // 
            // OrdenesPreparacionList
            // 
            OrdenesPreparacionList.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, idClienteColumna, nombreClienteColumna, estadoOrdenColumna, fechaOrdenColumna });
            OrdenesPreparacionList.Location = new Point(21, 38);
            OrdenesPreparacionList.Margin = new Padding(2);
            OrdenesPreparacionList.Name = "OrdenesPreparacionList";
            OrdenesPreparacionList.Size = new Size(909, 257);
            OrdenesPreparacionList.TabIndex = 0;
            OrdenesPreparacionList.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionList.View = View.Details;
            // 
            // IdOrdenColumna
            // 
            IdOrdenColumna.Text = "ID Orden";
            IdOrdenColumna.Width = 100;
            // 
            // idClienteColumna
            // 
            idClienteColumna.Text = "ID Cliente";
            idClienteColumna.Width = 100;
            // 
            // nombreClienteColumna
            // 
            nombreClienteColumna.Text = "Nombre Cliente";
            nombreClienteColumna.Width = 150;
            // 
            // estadoOrdenColumna
            // 
            estadoOrdenColumna.Text = "Estado";
            estadoOrdenColumna.Width = 80;
            // 
            // fechaOrdenColumna
            // 
            fechaOrdenColumna.Text = "Fecha";
            fechaOrdenColumna.Width = 80;
            // 
            // ListarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 767);
            Controls.Add(ListaOrdenesPreparacionGroup);
            Controls.Add(ListarOrdenesPreparacionGroup);
            Margin = new Padding(2);
            Name = "ListarOrdenPreparacionForm";
            Text = "Listar Órdenes de Preparación";
            ListarOrdenesPreparacionGroup.ResumeLayout(false);
            ListarOrdenesPreparacionGroup.PerformLayout();
            ListaOrdenesPreparacionGroup.ResumeLayout(false);
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
        private GroupBox ListaOrdenesPreparacionGroup;
        private Button VolverListaButton;
        private ListView OrdenesPreparacionList;
        private ColumnHeader IdOrdenColumna;
        private ColumnHeader idClienteColumna;
        private ColumnHeader nombreClienteColumna;
        private ColumnHeader estadoOrdenColumna;
        private ColumnHeader fechaOrdenColumna;
    }
}