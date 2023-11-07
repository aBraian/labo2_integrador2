using Entidades.Modelos;

namespace Integrador_Nro_2
{
    public partial class FrmMenuPrincipal : Form
    {
        private Polideportivo polideportivo;
        private const int CAPACIDAD_FUTBOL = 1;
        private const int CAPACIDAD_NATACION = 1;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            polideportivo = new Polideportivo(CAPACIDAD_FUTBOL, CAPACIDAD_NATACION);
        }

        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            FrmMenuAlta menuAlta = new FrmMenuAlta(polideportivo);
            menuAlta.ShowDialog();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            FrmMenuBaja menuBaja;
            do
            {
                menuBaja = new FrmMenuBaja(polideportivo);
                menuBaja.ShowDialog();
            } while (menuBaja.DialogResult == DialogResult.OK);
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Cerrar programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
