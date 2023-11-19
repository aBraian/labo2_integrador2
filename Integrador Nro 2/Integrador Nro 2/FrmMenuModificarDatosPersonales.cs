using Entidades.Modelos;
using Entidades.Excepciones;

namespace Integrador_Nro_2
{
    public partial class FrmMenuModificarDatosPersonales : Form
    {
        private Polideportivo polideportivo;

        public FrmMenuModificarDatosPersonales(Polideportivo polideportivo)
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

        private void FrmMenuModificarDatosPersonales_Load(object sender, EventArgs e)
        {
            dtpFechaNacimiento.Value = DateTime.Now;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                epModificar.Clear();
                if (lbPersonas.SelectedItem != null)
                {
                    Persona persona = (Persona)lbPersonas.SelectedItem;
                    Persona copia = persona.Copia;
                    int indice = polideportivo[persona];
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
                    if (cbCelular.Checked)
                    {
                        copia.Celular = txtCelular.Text;
                    }
                    if (cbFechaNacimiento.Checked)
                    {
                        copia.FechaNacimiento = dtpFechaNacimiento.Value;
                        copia.Edad = copia.ObtenerEdad(copia.FechaNacimiento);
                    }
                    if (MessageBox.Show("¿Seguro que quiere modificar los datos?", "Modificar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        polideportivo.ListaPersonas[indice] = copia;
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (NombreInvalidoException ex)
            {
                epModificar.SetError(cbNombre, ex.Message);
            }
            catch (ApellidoInvalidoException ex)
            {
                epModificar.SetError(cbApellido, ex.Message);
            }
            catch (DniInvalidoException ex)
            {
                epModificar.SetError(cbDni, ex.Message);
            }
            catch (CelularInvalidoException ex)
            {
                epModificar.SetError(cbCelular, ex.Message);
            }
            catch (FechaNacimientoInvalidaException ex)
            {
                epModificar.SetError(cbFechaNacimiento, ex.Message);
            }
            catch (EdadInvalidaException ex)
            {
                epModificar.SetError(cbFechaNacimiento, ex.Message);
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
                this.Close();
            }
        }
    }
}
