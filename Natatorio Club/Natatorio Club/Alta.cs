using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Entidades.Enumerados;
using Entidades.Excepciones;
using Entidades.Modelos;

namespace Natatorio_Club
{
    public partial class FrmAlta : Form
    {
        private Natatorio natatorio;

        public FrmAlta(Natatorio natarorio)
        {
            InitializeComponent();
            ListarNivel();
            ListarTurnos();
            this.natatorio = natarorio;
        }

        private void ListarNivel()
        {
            cmbNivel.DataSource = Enum.GetValues(typeof(ENivel));
        }

        private void ListarTurnos()
        {
            cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));
        }

        private Nadador DarAlta()
        {
            return new Nadador(txtNombre.Text, txtApellido.Text, txtDni.Text, txtTelefono.Text, dtpNacimiento.Value,
                (ETurno)cmbTurno.SelectedItem, (ENivel)cmbNivel.SelectedItem);
        }

        private void Frm_alta_Load(object sender, EventArgs e)
        {
            dtpNacimiento.Value = DateTime.Now;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                epAlta.Clear();
                natatorio += DarAlta();
                MessageBox.Show("Se dio de alta.", "Menu Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (TelefonoInvalidoException ex)
            {
                epAlta.SetError(lblTelefono, ex.Message);
            }
            catch (FechaNacimientoInvalidaException ex)
            {
                epAlta.SetError(lblNacimiento, ex.Message);
            }
            catch (EdadInvalidaException ex)
            {
                epAlta.SetError(lblNacimiento, ex.Message);
            }
            catch (NatatorioException ex)
            {
                epAlta.SetError(btnAceptar, ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Regresar al Menu?", "Volver al Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
