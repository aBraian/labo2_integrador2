using Entidades.Excepciones;
using Entidades.Extensiones;
using Entidades.Modelos;

namespace Natatorio_Club
{
    public partial class Frm_datosPersonales : Form
    {
        private Natatorio natatorio;

        public Frm_datosPersonales(Natatorio natatorio)
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

        private void Frm_datosPersonales_Load(object sender, EventArgs e)
        {
            dtpNacimiento.Value = DateTime.Now;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                epEditar.Clear();
                if (lbNadadores.SelectedItem != null)
                {
                    Nadador nadador = (Nadador)lbNadadores.SelectedItem;
                    Nadador copia = nadador.Copia;
                    if (cbNombre.Checked)
                    {
                        copia.Nombre = txtNombre.Text;
                    }
                    if (cbApellido.Checked)
                    {
                        copia.Apellido = txtApellido.Text;
                    }
                    if (cbDni.Checked)
                    {
                        copia.Dni = txtDni.Text;
                    }
                    if (cbTelefono.Checked)
                    {
                        copia.Telefono = txtTelefono.Text;
                    }
                    if (cbNacimiento.Checked)
                    {
                        copia.FechaNacimiento = dtpNacimiento.Value;
                        copia.Edad = copia.FechaNacimiento.ObtenerEdad();
                    }
                    if (MessageBox.Show("¿Seguro que quiere editar los datos?", "Modificar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        natatorio.Reemplazar(nadador, copia);
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (NombreInvalidoException ex)
            {
                epEditar.SetError(cbNombre, ex.Message);
            }
            catch (ApellidoInvalidoException ex)
            {
                epEditar.SetError(cbApellido, ex.Message);
            }
            catch (DniInvalidoException ex)
            {
                epEditar.SetError(cbDni, ex.Message);
            }
            catch (TelefonoInvalidoException ex)
            {
                epEditar.SetError(cbTelefono, ex.Message);
            }
            catch (FechaNacimientoInvalidaException ex)
            {
                epEditar.SetError(cbNacimiento, ex.Message);
            }
            catch (EdadInvalidaException ex)
            {
                epEditar.SetError(cbNacimiento, ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
