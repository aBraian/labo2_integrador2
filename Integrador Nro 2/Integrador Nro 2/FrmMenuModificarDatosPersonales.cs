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
                Persona persona;
                if (lbPersonas.SelectedItem != null)
                {
                    persona = (Persona)lbPersonas.SelectedItem;
                    if (cbNombre.Checked)
                    {
                        persona.Nombre = txtNombre.Text;
                    }
                    if (cbApellido.Checked)
                    {
                        persona.Apellido = txtApellido.Text;
                    }
                    if (cbDni.Checked)
                    {
                        persona.Dni = txtDni.Text;
                    }
                    if (cbCelular.Checked)
                    {
                        persona.Celular = txtCelular.Text;
                    }
                    if (cbFechaNacimiento.Checked)
                    {
                        persona.FechaNacimiento = dtpFechaNacimiento.Value;
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (NombreException ex)
            {
                epModificar.SetError(cbNombre, ex.Message);
            }
            catch (ApellidoException ex)
            {
                epModificar.SetError(cbApellido, ex.Message);
            }
            catch (DniException ex)
            {
                epModificar.SetError(cbDni, ex.Message);
            }
            catch (CelularException ex)
            {
                epModificar.SetError(cbCelular, ex.Message);
            }
            catch (FechaNacimientoException ex)
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
