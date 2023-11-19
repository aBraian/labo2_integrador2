using Entidades.Enumerados;
using Entidades.Excepciones;
using Entidades.Modelos;

namespace Integrador_Nro_2
{
    public partial class FrmMenuAlta : Form
    {
        private Polideportivo polideportivo;

        public FrmMenuAlta(Polideportivo polideportivo)
        {
            InitializeComponent();
            InicializarTurno();
            this.polideportivo = polideportivo;
        }

        private void InicializarTurno()
        {
            cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));
        }

        private void ListarDeportes()
        {
            if (rbFutbol.Checked)
            {
                lblCategoria.Text = "Posicion";
                cmbCategoria.DataSource = Enum.GetValues(typeof(EPosicion));
            }
            else
            {
                lblCategoria.Text = "Nivel";
                cmbCategoria.DataSource = Enum.GetValues(typeof(ENivel));
            }
        }

        private Persona DarAltaPersona()
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            string celular = txtCelular.Text;
            ETurno turno = (ETurno)cmbTurno.SelectedItem;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            if (rbFutbol.Checked)
            {
                EPosicion posicion = (EPosicion)cmbCategoria.SelectedItem;
                return new Futbolista(nombre, apellido, dni, celular, fechaNacimiento, turno, posicion);
            }
            else
            {
                ENivel nivel = (ENivel)cmbCategoria.SelectedItem;
                return new Nadador(nombre, apellido, dni, celular, fechaNacimiento, turno, nivel);
            }
        }

        private void FrmMenuAlta_Load(object sender, EventArgs e)
        {
            rbFutbol.Checked = true;
            dtpFechaNacimiento.Value = DateTime.Now;
            ListarDeportes();
        }

        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                epAlta.Clear();
                polideportivo += DarAltaPersona();
                MessageBox.Show("Alta exitosa.", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NombreInvalidoException ex)
            {
                epAlta.SetError(lblNombre, ex.Message);
            }
            catch (ApellidoInvalidoException ex)
            {
                epAlta.SetError(lblApellido, ex.Message);
            }
            catch (DniInvalidoException ex)
            {
                epAlta.SetError(lblDni, ex.Message);
            }
            catch (CelularInvalidoException ex)
            {
                epAlta.SetError(lblCelular, ex.Message);
            }
            catch (FechaNacimientoInvalidaException ex)
            {
                epAlta.SetError(lblFechaNacimiento, ex.Message);
            }
            catch (EdadInvalidaException ex)
            {
                epAlta.SetError(lblFechaNacimiento, ex.Message);
            }
            catch (PolideportivoException ex)
            {
                epAlta.SetError(btnDarAlta, ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere regresar al menu principal?", "Volver al menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void rbFutbol_Click(object sender, EventArgs e)
        {
            ListarDeportes();
        }

        private void rbNatacion_Click(object sender, EventArgs e)
        {
            ListarDeportes();
        }
    }
}
