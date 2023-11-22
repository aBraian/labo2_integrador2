using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Entidades.Modelos;

namespace Natatorio_Club
{
    public partial class Frm_buscar : Form
    {
        private Natatorio natatorio;

        public Frm_buscar(Natatorio natatorio)
        {
            InitializeComponent();
            this.natatorio = natatorio;
            lbNadadores.DataSource = natatorio.ListaNadadores;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Regresar al Menu?", "Volver al Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
