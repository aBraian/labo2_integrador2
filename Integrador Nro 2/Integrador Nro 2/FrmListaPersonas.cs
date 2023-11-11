using Entidades.Modelos;

namespace Integrador_Nro_2
{
    public partial class FrmListaPersonas : Form
    {
        private Polideportivo polideportivo;

        public FrmListaPersonas(Polideportivo polideportivo)
        {
            InitializeComponent();
            this.polideportivo = polideportivo;
            lbPersonas.DataSource = polideportivo.ListaPersonas;
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
