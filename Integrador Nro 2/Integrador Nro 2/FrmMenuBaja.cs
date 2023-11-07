using Entidades.Modelos;

namespace Integrador_Nro_2
{
    public partial class FrmMenuBaja : Form
    {
        private Polideportivo polideportivo;

        public FrmMenuBaja(Polideportivo polideportivo)
        {
            InitializeComponent();
            this.polideportivo = polideportivo;
            Actualizar();
        }

        private void Actualizar()
        {
            lbPersonas.DataSource = null;
            lbPersonas.DataSource = polideportivo.ListaPersonas;
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            if (lbPersonas.SelectedItem != null && MessageBox.Show("¿Seguro que quiere dar de baja?", "Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                polideportivo -= (Persona)lbPersonas.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere regresar al menu principal?", "Volver al menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
