namespace grupoB_TPP3_Prototipos.GenerarOrdenSelección
{
    partial class EmitirOrdenSeleccionForm
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
            GenerarOrdenSeleccionBuscarList = new ListView();
            IdOrdenPreparacionColumna = new ColumnHeader();
            ClienteOSColumna = new ColumnHeader();
            FechaOPColumna = new ColumnHeader();
            BuscarButton = new Button();
            VolverButton = new Button();
            FechaDesdeLabel = new Label();
            label1 = new Label();
            FechaOSDesdePicker = new DateTimePicker();
            IdOrdenPreparacionCombo = new ComboBox();
            label3 = new Label();
            PrioridadCombo = new ComboBox();
            label4 = new Label();
            DescripcionClienteCombo = new ComboBox();
            GenerarOrdenButton = new Button();
            FechaHastaLabel = new Label();
            FechaOSHastaPicker = new DateTimePicker();
            AgregarSeleccionadaOSButton = new Button();
            DetalleOSList = new ListView();
            ProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            DetalleOSLabel = new Label();
            QuitarSeleccionadasOSButton = new Button();
            GenerarOSSeleccionadasList = new ListView();
            IdOPSeleccionadaColumna = new ColumnHeader();
            ClienteSeleccionadoColumna = new ColumnHeader();
            FechaOPSeleccionadaColumna = new ColumnHeader();
            label2 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            buttonLimpiar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GenerarOrdenSeleccionBuscarList
            // 
            GenerarOrdenSeleccionBuscarList.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionColumna, ClienteOSColumna, FechaOPColumna });
            GenerarOrdenSeleccionBuscarList.Location = new Point(22, 365);
            GenerarOrdenSeleccionBuscarList.Name = "GenerarOrdenSeleccionBuscarList";
            GenerarOrdenSeleccionBuscarList.Size = new Size(468, 195);
            GenerarOrdenSeleccionBuscarList.TabIndex = 25;
            GenerarOrdenSeleccionBuscarList.UseCompatibleStateImageBehavior = false;
            GenerarOrdenSeleccionBuscarList.View = View.Details;
            GenerarOrdenSeleccionBuscarList.SelectedIndexChanged += GenerarOrdenSeleccionBuscarList_SelectedIndexChanged;
            // 
            // IdOrdenPreparacionColumna
            // 
            IdOrdenPreparacionColumna.Text = "ID Orden Preparación";
            IdOrdenPreparacionColumna.Width = 160;
            // 
            // ClienteOSColumna
            // 
            ClienteOSColumna.Text = "Descripcion Cliente";
            ClienteOSColumna.Width = 200;
            // 
            // FechaOPColumna
            // 
            FechaOPColumna.Text = "Fecha";
            FechaOPColumna.Width = 100;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(740, 184);
            BuscarButton.Margin = new Padding(1);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(129, 37);
            BuscarButton.TabIndex = 24;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(787, 930);
            VolverButton.Margin = new Padding(1);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(128, 52);
            VolverButton.TabIndex = 23;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // FechaDesdeLabel
            // 
            FechaDesdeLabel.AutoSize = true;
            FechaDesdeLabel.Location = new Point(320, 38);
            FechaDesdeLabel.Name = "FechaDesdeLabel";
            FechaDesdeLabel.Size = new Size(93, 20);
            FechaDesdeLabel.TabIndex = 22;
            FechaDesdeLabel.Text = "Fecha Desde";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 37);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 21;
            label1.Text = "ID Orden Preparación";
            // 
            // FechaOSDesdePicker
            // 
            FechaOSDesdePicker.Checked = false;
            FechaOSDesdePicker.Location = new Point(320, 61);
            FechaOSDesdePicker.Name = "FechaOSDesdePicker";
            FechaOSDesdePicker.ShowCheckBox = true;
            FechaOSDesdePicker.Size = new Size(248, 27);
            FechaOSDesdePicker.TabIndex = 20;
            // 
            // IdOrdenPreparacionCombo
            // 
            IdOrdenPreparacionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IdOrdenPreparacionCombo.FormattingEnabled = true;
            IdOrdenPreparacionCombo.Location = new Point(22, 61);
            IdOrdenPreparacionCombo.Name = "IdOrdenPreparacionCombo";
            IdOrdenPreparacionCombo.Size = new Size(251, 28);
            IdOrdenPreparacionCombo.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 110);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 29;
            label3.Text = "Prioridad";
            // 
            // PrioridadCombo
            // 
            PrioridadCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            PrioridadCombo.FormattingEnabled = true;
            PrioridadCombo.Location = new Point(320, 133);
            PrioridadCombo.Name = "PrioridadCombo";
            PrioridadCombo.Size = new Size(248, 28);
            PrioridadCombo.TabIndex = 28;
            PrioridadCombo.SelectedIndexChanged += PrioridadCombo_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 109);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 31;
            label4.Text = "Cliente";
            // 
            // DescripcionClienteCombo
            // 
            DescripcionClienteCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            DescripcionClienteCombo.FormattingEnabled = true;
            DescripcionClienteCombo.Location = new Point(22, 133);
            DescripcionClienteCombo.Name = "DescripcionClienteCombo";
            DescripcionClienteCombo.Size = new Size(251, 28);
            DescripcionClienteCombo.TabIndex = 30;
            // 
            // GenerarOrdenButton
            // 
            GenerarOrdenButton.Location = new Point(581, 930);
            GenerarOrdenButton.Margin = new Padding(1);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(193, 52);
            GenerarOrdenButton.TabIndex = 43;
            GenerarOrdenButton.Text = "Emitir Orden";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            GenerarOrdenButton.Click += GenerarOrdenButton_Click;
            // 
            // FechaHastaLabel
            // 
            FechaHastaLabel.AutoSize = true;
            FechaHastaLabel.Location = new Point(621, 37);
            FechaHastaLabel.Name = "FechaHastaLabel";
            FechaHastaLabel.Size = new Size(89, 20);
            FechaHastaLabel.TabIndex = 45;
            FechaHastaLabel.Text = "Fecha Hasta";
            // 
            // FechaOSHastaPicker
            // 
            FechaOSHastaPicker.Checked = false;
            FechaOSHastaPicker.Location = new Point(621, 62);
            FechaOSHastaPicker.Name = "FechaOSHastaPicker";
            FechaOSHastaPicker.ShowCheckBox = true;
            FechaOSHastaPicker.Size = new Size(248, 27);
            FechaOSHastaPicker.TabIndex = 44;
            // 
            // AgregarSeleccionadaOSButton
            // 
            AgregarSeleccionadaOSButton.Location = new Point(728, 581);
            AgregarSeleccionadaOSButton.Margin = new Padding(1);
            AgregarSeleccionadaOSButton.Name = "AgregarSeleccionadaOSButton";
            AgregarSeleccionadaOSButton.Size = new Size(187, 47);
            AgregarSeleccionadaOSButton.TabIndex = 46;
            AgregarSeleccionadaOSButton.Text = "Agregar Seleccionadas";
            AgregarSeleccionadaOSButton.UseVisualStyleBackColor = true;
            AgregarSeleccionadaOSButton.Click += AgregarSeleccionadaOSButton_Click;
            // 
            // DetalleOSList
            // 
            DetalleOSList.Columns.AddRange(new ColumnHeader[] { ProductoColumna, CantidadColumna });
            DetalleOSList.Location = new Point(505, 395);
            DetalleOSList.Name = "DetalleOSList";
            DetalleOSList.Size = new Size(410, 165);
            DetalleOSList.TabIndex = 47;
            DetalleOSList.UseCompatibleStateImageBehavior = false;
            DetalleOSList.View = View.Details;
            // 
            // ProductoColumna
            // 
            ProductoColumna.Text = "Producto";
            ProductoColumna.Width = 300;
            // 
            // CantidadColumna
            // 
            CantidadColumna.Text = "Cantidad";
            CantidadColumna.Width = 100;
            // 
            // DetalleOSLabel
            // 
            DetalleOSLabel.AutoSize = true;
            DetalleOSLabel.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DetalleOSLabel.Location = new Point(505, 365);
            DetalleOSLabel.Name = "DetalleOSLabel";
            DetalleOSLabel.Size = new Size(165, 21);
            DetalleOSLabel.TabIndex = 48;
            DetalleOSLabel.Text = "Detalle de la Orden";
            // 
            // QuitarSeleccionadasOSButton
            // 
            QuitarSeleccionadasOSButton.Location = new Point(728, 854);
            QuitarSeleccionadasOSButton.Margin = new Padding(1);
            QuitarSeleccionadasOSButton.Name = "QuitarSeleccionadasOSButton";
            QuitarSeleccionadasOSButton.Size = new Size(187, 47);
            QuitarSeleccionadasOSButton.TabIndex = 49;
            QuitarSeleccionadasOSButton.Text = "Quitar Seleccionadas";
            QuitarSeleccionadasOSButton.UseVisualStyleBackColor = true;
            QuitarSeleccionadasOSButton.Click += QuitarSeleccionadasOSButton_Click;
            // 
            // GenerarOSSeleccionadasList
            // 
            GenerarOSSeleccionadasList.Columns.AddRange(new ColumnHeader[] { IdOPSeleccionadaColumna, ClienteSeleccionadoColumna, FechaOPSeleccionadaColumna });
            GenerarOSSeleccionadasList.Location = new Point(22, 642);
            GenerarOSSeleccionadasList.Name = "GenerarOSSeleccionadasList";
            GenerarOSSeleccionadasList.Size = new Size(893, 195);
            GenerarOSSeleccionadasList.TabIndex = 50;
            GenerarOSSeleccionadasList.UseCompatibleStateImageBehavior = false;
            GenerarOSSeleccionadasList.View = View.Details;
            // 
            // IdOPSeleccionadaColumna
            // 
            IdOPSeleccionadaColumna.Text = "ID Orden Preparación";
            IdOPSeleccionadaColumna.Width = 180;
            // 
            // ClienteSeleccionadoColumna
            // 
            ClienteSeleccionadoColumna.Text = "Descripcion Cliente";
            ClienteSeleccionadoColumna.Width = 250;
            // 
            // FechaOPSeleccionadaColumna
            // 
            FechaOPSeleccionadaColumna.Text = "Fecha";
            FechaOPSeleccionadaColumna.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 19);
            label2.Name = "label2";
            label2.Size = new Size(355, 34);
            label2.TabIndex = 51;
            label2.Text = "Emitir Ordenes Selección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 71);
            label5.Name = "label5";
            label5.Size = new Size(65, 23);
            label5.TabIndex = 52;
            label5.Text = "label5";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonLimpiar);
            groupBox1.Controls.Add(FechaHastaLabel);
            groupBox1.Controls.Add(FechaOSHastaPicker);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(DescripcionClienteCombo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(PrioridadCombo);
            groupBox1.Controls.Add(BuscarButton);
            groupBox1.Controls.Add(FechaDesdeLabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FechaOSDesdePicker);
            groupBox1.Controls.Add(IdOrdenPreparacionCombo);
            groupBox1.Location = new Point(22, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(893, 235);
            groupBox1.TabIndex = 53;
            groupBox1.TabStop = false;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(581, 183);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(129, 37);
            buttonLimpiar.TabIndex = 46;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // EmitirOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 1000);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(GenerarOSSeleccionadasList);
            Controls.Add(QuitarSeleccionadasOSButton);
            Controls.Add(DetalleOSLabel);
            Controls.Add(DetalleOSList);
            Controls.Add(AgregarSeleccionadaOSButton);
            Controls.Add(GenerarOrdenButton);
            Controls.Add(GenerarOrdenSeleccionBuscarList);
            Controls.Add(VolverButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EmitirOrdenSeleccionForm";
            Load += EmitirOrdenSeleccionForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView GenerarOrdenSeleccionList;
        private ColumnHeader IdOrdenSeleccionColumna;
        private ColumnHeader FechaOE2Columna;
        private ColumnHeader DescripcionProducto2Columna;
        private ColumnHeader Cantidad2Columna;
        private ColumnHeader Ubicacion2Columna;
        private ColumnHeader Estado2Columna;
        private ListView GenerarOrdenSeleccionBuscarList;
        private ColumnHeader IdOrdenPreparacionColumna;
        private ColumnHeader FechaOPColumna;
        private Button BuscarButton;
        private Button VolverButton;
        private Label FechaDesdeLabel;
        private Label label1;
        private DateTimePicker FechaOSDesdePicker;
        private ComboBox IdOrdenPreparacionCombo;
        private Label label3;
        private ComboBox PrioridadCombo;
        private Label label4;
        private ComboBox DescripcionClienteCombo;
        private Button GenerarOrdenButton;
        private Label FechaHastaLabel;
        private DateTimePicker FechaOSHastaPicker;
        private Button AgregarSeleccionadaOSButton;
        private ListView DetalleOSList;
        private ColumnHeader ProductoColumna;
        private ColumnHeader CantidadColumna;
        private Label DetalleOSLabel;
        private Button QuitarSeleccionadasOSButton;
        private ListView GenerarOSSeleccionadasList;
        private ColumnHeader IdOPSeleccionadaColumna;
        private ColumnHeader FechaOPSeleccionadaColumna;
        private ColumnHeader ClienteOSColumna;
        private ColumnHeader ClienteSeleccionadoColumna;
        private Label label2;
        private Label label5;
        private GroupBox groupBox1;
        private Button buttonLimpiar;
    }
}