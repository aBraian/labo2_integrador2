using Entidades.Excepciones;
using Entidades.Modelos;
namespace Integrador_Nro_2
{
    public partial class FrmMenuAlta : Form
    {
        private Polideportivo polideportivo;

        public FrmMenuAlta()
        {
            InitializeComponent();
            InicializarPolideportivo();
        }

        private void InicializarPolideportivo()
        {
            this.polideportivo = new Polideportivo(10, 10);
        }

        private void InicializarHorario()
        {
            cmbHorario.DataSource = Enum.GetValues(typeof(EHorario));
        }

        private void FrmMenuAlta_Load(object sender, EventArgs e)
        {
            InicializarHorario();
            cmbEspecialidad.Items.Add("Seleccionar deporte");
        }

        private void rbFutbol_MouseClick(object sender, MouseEventArgs e)
        {
            lblEspecialidad.Text = "Posicion";
            cmbEspecialidad.DataSource = Enum.GetValues(typeof(EPosicion));
        }

        private void rbNatacion_MouseClick(object sender, MouseEventArgs e)
        {
            lblEspecialidad.Text = "Nivel";
            cmbEspecialidad.DataSource = Enum.GetValues(typeof(ENivel));
        }

        private Persona? DarAltaPersona()
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            string celular = txtCelular.Text;
            EHorario horario = (EHorario)cmbHorario.SelectedItem;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            if (rbFutbol.Checked)
            {
                EPosicion posicion = (EPosicion)cmbEspecialidad.SelectedItem;
                return new Futbolista(dni, nombre, apellido, celular, fechaNacimiento, horario, posicion);
            }
            else if (rbNatacion.Checked)
            {
                ENivel nivel = (ENivel)cmbEspecialidad.SelectedItem;
                return new Nadador(dni, nombre, apellido, celular, fechaNacimiento, horario, nivel);
            }
            return null;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                polideportivo += DarAltaPersona();
                foreach (Persona item in polideportivo.ListaPersonas)
                {
                    MessageBox.Show(item.Informacion);
                }
                if (MessageBox.Show("¿Desea continuar?", "Continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Close();
                }
            }
            catch (AlfabetoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CelularException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DniException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FechaNacimientoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (PolideportivoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}