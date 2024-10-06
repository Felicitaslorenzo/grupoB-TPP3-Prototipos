namespace grupoB_TPP3_Prototipos.PrepararOrdenSeleccion
{
    partial class RetirarOrdenSeleccionForm
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
            label1 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            ProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            UbicacionColumna = new ColumnHeader();
            listView2 = new ListView();
            IdOrdenColumna = new ColumnHeader();
            nombreClienteColumna = new ColumnHeader();
            fechaEmisionColumna = new ColumnHeader();
            fechaDespachoColumna = new ColumnHeader();
            SeleccionarButton = new Button();
            ConfirmarButton = new Button();
            CancelarButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 0;
            label1.Text = "Ordenes de Preparación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(662, 32);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 1;
            label2.Text = "Productos de orden";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ProductoColumna, CantidadColumna, UbicacionColumna });
            listView1.Location = new Point(662, 71);
            listView1.Name = "listView1";
            listView1.Size = new Size(476, 239);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ProductoColumna
            // 
            ProductoColumna.Text = "Producto";
            ProductoColumna.Width = 100;
            // 
            // CantidadColumna
            // 
            CantidadColumna.Text = "Cantidad";
            CantidadColumna.Width = 100;
            // 
            // UbicacionColumna
            // 
            UbicacionColumna.Text = "Ubicación";
            UbicacionColumna.Width = 100;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, nombreClienteColumna, fechaEmisionColumna, fechaDespachoColumna });
            listView2.Location = new Point(12, 71);
            listView2.Name = "listView2";
            listView2.Size = new Size(547, 239);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // IdOrdenColumna
            // 
            IdOrdenColumna.Text = "ID Orden";
            IdOrdenColumna.Width = 100;
            // 
            // nombreClienteColumna
            // 
            nombreClienteColumna.Text = "Cliente";
            nombreClienteColumna.Width = 80;
            // 
            // fechaEmisionColumna
            // 
            fechaEmisionColumna.Text = "Fecha Emision";
            fechaEmisionColumna.Width = 140;
            // 
            // fechaDespachoColumna
            // 
            fechaDespachoColumna.Text = "Fecha Despacho";
            fechaDespachoColumna.Width = 140;
            // 
            // SeleccionarButton
            // 
            SeleccionarButton.Location = new Point(433, 333);
            SeleccionarButton.Name = "SeleccionarButton";
            SeleccionarButton.Size = new Size(129, 36);
            SeleccionarButton.TabIndex = 4;
            SeleccionarButton.Text = "Seleccionar";
            SeleccionarButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmarButton
            // 
            ConfirmarButton.Location = new Point(847, 333);
            ConfirmarButton.Name = "ConfirmarButton";
            ConfirmarButton.Size = new Size(129, 45);
            ConfirmarButton.TabIndex = 5;
            ConfirmarButton.Text = "Confirmar";
            ConfirmarButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(1009, 333);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(129, 45);
            CancelarButton.TabIndex = 6;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // PrepararOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 399);
            Controls.Add(CancelarButton);
            Controls.Add(ConfirmarButton);
            Controls.Add(SeleccionarButton);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PrepararOrdenSeleccionForm";
            Text = "PrepararOrdenSeleccionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView listView1;
        private ListView listView2;
        private ColumnHeader IdOrdenColumna;
        private ColumnHeader nombreClienteColumna;
        private ColumnHeader fechaEmisionColumna;
        private ColumnHeader fechaDespachoColumna;
        private ColumnHeader ProductoColumna;
        private ColumnHeader CantidadColumna;
        private ColumnHeader UbicacionColumna;
        private Button SeleccionarButton;
        private Button ConfirmarButton;
        private Button CancelarButton;
    }
}