using Entidades.Modelos;

namespace Integrador_Nro_2
{
    public partial class FrmMenuPrincipal : Form
    {
        private Polideportivo polideportivo;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            InicializarPolideportivo();
        }

        private void InicializarPolideportivo()
        {
            this.polideportivo = new Polideportivo(10, 10);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuAlta menuAlta = new FrmMenuAlta(this.polideportivo);
            menuAlta.ShowDialog();
            this.Show();
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
