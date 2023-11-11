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

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            polideportivo.Ordenar();
        }

        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            FrmMenuAlta menuAlta = new FrmMenuAlta(polideportivo);
            menuAlta.ShowDialog();
            polideportivo.Ordenar();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            FrmMenuBaja menuBaja;
            do
            {
                menuBaja = new FrmMenuBaja(polideportivo);
                menuBaja.ShowDialog();
                polideportivo.Ordenar();
            } while (menuBaja.DialogResult == DialogResult.OK);
        }

        private void btnDatosPersonales_Click(object sender, EventArgs e)
        {
            FrmMenuModificarDatosPersonales menuDatosPersonales;
            do
            {
                menuDatosPersonales = new FrmMenuModificarDatosPersonales(polideportivo);
                menuDatosPersonales.ShowDialog();
                polideportivo.Ordenar();
            } while (menuDatosPersonales.DialogResult == DialogResult.OK);
        }

        private void btnDeportes_Click(object sender, EventArgs e)
        {
            FrmMenuModificarDeportes menuDeportes;
            do
            {
                menuDeportes = new FrmMenuModificarDeportes(polideportivo);
                menuDeportes.ShowDialog();
                polideportivo.Ordenar();
            } while (menuDeportes.DialogResult == DialogResult.OK);
        }

        private void btnListaPersonas_Click(object sender, EventArgs e)
        {
            FrmListaPersonas menuListaPersonas = new FrmListaPersonas(polideportivo);
            menuListaPersonas.ShowDialog();
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
