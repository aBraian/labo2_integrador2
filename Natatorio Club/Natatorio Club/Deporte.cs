using Entidades.Enumerados;
using Entidades.Excepciones;
using Entidades.Modelos;

namespace Natatorio_Club
{
    public partial class Frm_deporte : Form
    {
        private Natatorio natatorio;

        public Frm_deporte(Natatorio natatorio)
        {
            InitializeComponent();
            this.natatorio = natatorio;
            InicializarNivel();
            InicializarTurno();
            Actualizar();
        }

        private void InicializarNivel()
        {
            cmbNivel.DataSource = Enum.GetValues(typeof(ENivel));
        }

        private void InicializarTurno()
        {
            cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));
        }

        private void Actualizar()
        {
            lbNadadores.DataSource = null;
            lbNadadores.DataSource = natatorio.ListaNadadores;
        }

        private Nadador EditarNivel(Nadador nadador)
        {
            nadador.Nivel = (ENivel)cmbNivel.SelectedItem;
            return nadador;
        }

        private Nadador EditarTurno(Nadador nadador)
        {
            nadador.Turno = (ETurno)cmbTurno.SelectedItem;
            if (natatorio.ValidarCapacidad(nadador))
            {
                return nadador;
            }
            throw new MenuModificarException("No fue posible modificar.");
        }

        private void Frm_deporte_Load(object sender, EventArgs e)
        {
            rbNivel.Checked = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbNadadores.SelectedItem != null)
                {
                    epEditar.Clear();
                    Nadador nadador = (Nadador)lbNadadores.SelectedItem;
                    Nadador copia = nadador.Copia;
                    if (rbNivel.Checked)
                    {
                        copia = EditarNivel(copia);
                    }
                    else if (rbTurno.Checked)
                    {
                        copia = EditarTurno(copia);
                    }
                    if (MessageBox.Show("¿Seguro que quiere editar los datos?", "Modificar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        natatorio.Reemplazar(nadador, copia);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    throw new MenuModificarException("Lista vacia.");
                }
            }
            catch (MenuModificarException ex)
            {
                epEditar.SetError(lblMensaje, ex.Message);
            }
            catch (NatatorioException ex)
            {
                epEditar.SetError(lblMensaje, ex.Message);
            }
            catch (EdadInvalidaException ex)
            {
                epEditar.SetError(lblMensaje, ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
