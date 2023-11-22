using Entidades.Modelos;
using Entidades.Serializacion;

namespace Natatorio_Club
{
    public partial class Frm_menu : Form
    {
        private Natatorio natatorio;
        private const int CAPACIDAD = 10;

        public Frm_menu()
        {
            InitializeComponent();
            natatorio = new Natatorio(CAPACIDAD);
            ObtenerLista();
        }

        private void ObtenerLista()
        {
            List<Nadador>? listado = Archivos<Nadador>.LeerJson();
            if (listado is not null)
            {
                natatorio.ListaNadadores = listado;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAlta submenu = new FrmAlta(natatorio);
            submenu.ShowDialog();
            natatorio.Ordenar();
            Archivos<Nadador>.GuardarJson(natatorio.ListaNadadores);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Frm_baja submenu;
            do
            {
                submenu = new Frm_baja(natatorio);
                natatorio.Ordenar();
                Archivos<Nadador>.GuardarJson(natatorio.ListaNadadores);
            } while (submenu.ShowDialog() == DialogResult.OK);
        }

        private void btnDatosPersonales_Click(object sender, EventArgs e)
        {
            Frm_datosPersonales submenu;
            do
            {
                submenu = new Frm_datosPersonales(natatorio);
                natatorio.Ordenar();
                Archivos<Nadador>.GuardarJson(natatorio.ListaNadadores);
            } while (submenu.ShowDialog() == DialogResult.OK);
        }

        private void btnDeporte_Click(object sender, EventArgs e)
        {
            Frm_deporte submenu;
            do
            {
                submenu = new Frm_deporte(natatorio);
                natatorio.Ordenar();
                Archivos<Nadador>.GuardarJson(natatorio.ListaNadadores);
            } while (submenu.ShowDialog() == DialogResult.OK);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Frm_buscar submenu = new Frm_buscar(natatorio);
            submenu.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerrar el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}