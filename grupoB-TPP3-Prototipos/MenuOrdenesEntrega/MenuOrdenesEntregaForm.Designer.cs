﻿namespace grupoB_TPP3_Prototipos.MenuOrdenesEntrega
{
    partial class MenuOrdenesEntregaForm
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
            buttonListarOrdenesEntrega = new Button();
            buttonDespacharOrdenEntrega = new Button();
            buttonGenerarOrdenEntrega = new Button();
            SuspendLayout();
            // 
            // buttonListarOrdenesEntrega
            // 
            buttonListarOrdenesEntrega.Location = new Point(222, 50);
            buttonListarOrdenesEntrega.Name = "buttonListarOrdenesEntrega";
            buttonListarOrdenesEntrega.Size = new Size(173, 97);
            buttonListarOrdenesEntrega.TabIndex = 0;
            buttonListarOrdenesEntrega.Text = "Listar Ordenes de Entrega";
            buttonListarOrdenesEntrega.UseVisualStyleBackColor = true;
            buttonListarOrdenesEntrega.Click += buttonListarOrdenesEntrega_Click;
            // 
            // buttonDespacharOrdenEntrega
            // 
            buttonDespacharOrdenEntrega.Location = new Point(222, 287);
            buttonDespacharOrdenEntrega.Name = "buttonDespacharOrdenEntrega";
            buttonDespacharOrdenEntrega.Size = new Size(173, 97);
            buttonDespacharOrdenEntrega.TabIndex = 1;
            buttonDespacharOrdenEntrega.Text = "Despachar Orden de Entrega";
            buttonDespacharOrdenEntrega.UseVisualStyleBackColor = true;
            buttonDespacharOrdenEntrega.Click += buttonDespacharOrdenEntrega_Click;
            // 
            // buttonGenerarOrdenEntrega
            // 
            buttonGenerarOrdenEntrega.Location = new Point(222, 170);
            buttonGenerarOrdenEntrega.Name = "buttonGenerarOrdenEntrega";
            buttonGenerarOrdenEntrega.Size = new Size(173, 97);
            buttonGenerarOrdenEntrega.TabIndex = 2;
            buttonGenerarOrdenEntrega.Text = "Generar Orden de Entrega ";
            buttonGenerarOrdenEntrega.UseVisualStyleBackColor = true;
            buttonGenerarOrdenEntrega.Click += buttonGenerarOrdenEntrega_Click;
            // 
            // MenuOrdenesEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 433);
            Controls.Add(buttonGenerarOrdenEntrega);
            Controls.Add(buttonDespacharOrdenEntrega);
            Controls.Add(buttonListarOrdenesEntrega);
            Name = "MenuOrdenesEntregaForm";
            Text = "MenuOrdenesEntregaForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonListarOrdenesEntrega;
        private Button buttonDespacharOrdenEntrega;
        private Button buttonGenerarOrdenEntrega;
    }
}