﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupoB_TPP3_Prototipos.MenuOrdenesSeleccion
{
    public partial class MenuOrdenesSeleccionForm : Form
    {
        public MenuOrdenesSeleccionForm()
        {
            InitializeComponent();
        }

        private void buttonListarOrdenesSeleccion_Click(object sender, EventArgs e)
        {
            ListarOrdenSeleccion.ListarOrdenSeleccionForm listarOrdenSeleccionForm = new ListarOrdenSeleccion.ListarOrdenSeleccionForm();
            listarOrdenSeleccionForm.ShowDialog();
        }
    }
}
