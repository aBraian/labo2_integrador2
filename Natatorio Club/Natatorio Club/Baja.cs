using Entidades.Modelos;

namespace Natatorio_Club
{
    public partial class Frm_baja : Form
    {
        private Natatorio natatorio;

        public Frm_baja(Natatorio natatorio)
        {
            InitializeComponent();
            this.natatorio = natatorio;
            Actualizar();
        }

        private void Actualizar()
        {
            lbNadadores.DataSource = null;
            lbNadadores.DataSource = natatorio.ListaNadadores;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lbNadadores.SelectedItem != null && MessageBox.Show("¿Seguro que quiere dar de baja?", "Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                natatorio -= (Nadador)lbNadadores.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Regresar al Menu?", "Volver al Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
