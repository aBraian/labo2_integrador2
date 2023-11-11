using Entidades.Modelos;
using Entidades.Excepciones;

namespace Integrador_Nro_2
{
    public partial class FrmMenuModificarDeportes : Form
    {
        private Polideportivo polideportivo;

        public FrmMenuModificarDeportes(Polideportivo polideportivo)
        {
            InitializeComponent();
            InicializarTurno();
            this.polideportivo = polideportivo;
            Actualizar();
        }

        private void InicializarTurno()
        {
            cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));
        }

        private void Actualizar()
        {
            lbPersonas.DataSource = null;
            lbPersonas.DataSource = polideportivo.ListaPersonas;
        }

        private void ListarDeportes()
        {
            if (rbFutbol.Checked)
            {
                cmbCategoria.DataSource = Enum.GetValues(typeof(EPosicion));
            }
            else
            {
                cmbCategoria.DataSource = Enum.GetValues(typeof(ENivel));
            }
        }

        private void FrmMenuModificarDeportes_Load(object sender, EventArgs e)
        {
            rbFutbol.Checked = true;
            rbCambiarDeporte.Checked = true;
            ListarDeportes();
        }

        private Persona ModificarCategoria(Persona persona)
        {
            if (rbFutbol.Checked && persona.Deporte == EDeporte.Futbol)
            {
                Futbolista futbolista = (Futbolista)persona;
                futbolista.Posicion = (EPosicion)cmbCategoria.SelectedItem;
                return futbolista;
            }
            else if (rbNatacion.Checked && persona.Deporte == EDeporte.Natacion)
            {
                Nadador nadador = (Nadador)persona;
                nadador.Nivel = (ENivel)cmbCategoria.SelectedItem;
                return nadador;
            }
            throw new MenuModificarException("La persona no practica el deporte seleccionado.");
        }

        private Persona ModificarTurno(Persona persona)
        {
            persona.Turno = (ETurno)cmbTurno.SelectedItem;
            if (polideportivo.ValidarTurno(persona))
            {
                return persona;
            }
            throw new MenuModificarException("No fue posible modificar.");
        }

        private Persona ModificarDeporte(Persona persona)
        {
            bool error = true;
            persona.Turno = (ETurno)cmbTurno.SelectedItem;
            if (rbFutbol.Checked && persona.Deporte == EDeporte.Natacion)
            {
                EPosicion posicion = (EPosicion)cmbCategoria.SelectedItem;
                Futbolista futbolista = new Futbolista(persona.Nombre, persona.Apellido, persona.Dni,
                    persona.Celular, persona.FechaNacimiento, persona.Turno, posicion);
                persona = futbolista;
                error = false;
            }
            else if (rbNatacion.Checked && persona.Deporte == EDeporte.Futbol)
            {
                ENivel nivel = (ENivel)cmbCategoria.SelectedItem;
                Nadador nadador = new Nadador(persona.Nombre, persona.Apellido, persona.Dni, persona.Celular,
                    persona.FechaNacimiento, persona.Turno, nivel);
                persona = nadador;
                error = false;
            }
            if (error)
            {
                throw new MenuModificarException("La persona ya practica el deporte seleccionado.");
            }
            if (polideportivo.ValidarTurno(persona))
            {
                return persona;
            }
            throw new MenuModificarException("No fue posible modificar.");
        }

        private void HabilitarSelectores(bool deporte, bool categoria, bool turno)
        {
            tlpSeleccionDeporte.Enabled = deporte;
            tlpSeleccionCategoria.Enabled = categoria;
            tlpSeleccionTurno.Enabled = turno;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbPersonas.SelectedItem != null)
                {
                    epModificar.Clear();
                    Persona persona = (Persona)lbPersonas.SelectedItem;
                    Persona copia = persona.Copia;
                    int indice = polideportivo[persona];
                    if (rbCambiarCategoria.Checked)
                    {
                        copia = ModificarCategoria(copia);
                    }
                    else if (rbCambiarTurno.Checked)
                    {
                        copia = ModificarTurno(copia);
                    }
                    else if (rbCambiarDeporte.Checked)
                    {
                        copia = ModificarDeporte(copia);
                    }
                    else
                    {
                        throw new MenuModificarException("Seleccione un cambio.");
                    }
                    if (MessageBox.Show("¿Seguro que quiere modificar los datos?", "Modificar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        polideportivo.ListaPersonas[indice] = copia;
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
                epModificar.SetError(lblMensaje, ex.Message);
            }
            catch (PolideportivoException ex)
            {
                epModificar.SetError(lblMensaje, ex.Message);
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

        private void rbCambiarDeporte_Click(object sender, EventArgs e)
        {
            HabilitarSelectores(true, true, true);
        }

        private void rbCambiarCategoria_Click(object sender, EventArgs e)
        {
            HabilitarSelectores(true, true, false);
        }

        private void rbCambiarTurno_Click(object sender, EventArgs e)
        {
            HabilitarSelectores(false, false, true);
        }
    }
}
