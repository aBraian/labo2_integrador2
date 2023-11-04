using Entidades.Excepciones;
using Entidades.Modelos;
namespace Integrador_Nro_2
{
    public partial class FrmMenuAlta : Form
    {
        private Polideportivo polideportivo;
        private bool flagEventoClosing = true;

        public FrmMenuAlta(Polideportivo polideportivo)
        {
            InitializeComponent();
            this.polideportivo = polideportivo;
        }

        private void InicializarHorario()
        {
            cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));
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
            ETurno turno = (ETurno)cmbTurno.SelectedItem;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            if (rbFutbol.Checked)
            {
                EPosicion posicion = (EPosicion)cmbEspecialidad.SelectedItem;
                return new Futbolista(nombre, apellido, dni, celular, fechaNacimiento, turno, posicion);
            }
            else if (rbNatacion.Checked)
            {
                ENivel nivel = (ENivel)cmbEspecialidad.SelectedItem;
                return new Nadador(nombre, apellido, dni, celular, fechaNacimiento, turno, nivel);
            }
            return null;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                epExcepciones.Clear();
                polideportivo += DarAltaPersona();
                MessageBox.Show("Se dio de alta correctamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                flagEventoClosing = false;
                this.Close();
            }
            catch (NombreException ex)
            {
                epExcepciones.SetError(txtNombre, ex.Message);
            }
            catch (ApellidoException ex)
            {
                epExcepciones.SetError(txtApellido, ex.Message);
            }
            catch (DniException ex)
            {
                epExcepciones.SetError(txtDni, ex.Message);
            }
            catch (CelularException ex)
            {
                epExcepciones.SetError(txtCelular, ex.Message);
            }
            catch (FechaNacimientoException ex)
            {
                epExcepciones.SetError(dtpFechaNacimiento, ex.Message);
            }
            catch (PolideportivoException ex)
            {
                epExcepciones.SetError(gbDeporte, ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere regresar al menu principal?", "Volver al menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                flagEventoClosing = false;
                this.Close();
            }
        }

        private void FrmMenuAlta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagEventoClosing && MessageBox.Show("¿Cerrar menu alta?", "Volver al menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}