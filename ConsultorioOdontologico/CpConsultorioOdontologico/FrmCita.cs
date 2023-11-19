using CadConsultorioOdontologico;
using ClnConsultorioOdontologico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpConsultorioOdontologico
{
    public partial class FrmCita : Form
    {
        bool esNuevo = false;
        public FrmCita()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var cita = CitaCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = cita;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["idRegistro"].Visible = false;
            dgvLista.Columns["valorRegistro"].HeaderText = "Estado de la cita";
            //dgvLista.Columns["idPaciente"].Visible = false;
            dgvLista.Columns["nombresPaciente"].HeaderText = "Nombre del paciente";
            dgvLista.Columns["fecha"].HeaderText = "Fecha de la Consulta";
            dgvLista.Columns["hora"].HeaderText = "Hora de la Consulta";
            dgvLista.Columns["tratamiento"].HeaderText = "Tratamiento";
            dgvLista.Columns["pago"].HeaderText = "Historial de Pago";
            dgvLista.Columns["aCuenta"].HeaderText = "A Cuenta";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha del Registro";
            btnEditar.Enabled = cita.Count > 0;
            btnEliminar.Enabled = cita.Count > 0;
            if (cita.Count > 0) dgvLista.Rows[0].Cells["tratamiento"].Selected = true;
        }
        private void cargarPaciente()
        {
            cbxPaciente.DataSource = PacienteCln.listar();
            cbxPaciente.DisplayMember = "nombres";
            cbxPaciente.ValueMember = "id";
        }
        private void cargarRegistro()
        {
            cbxRegistro.DataSource = RegistroCln.listar();
            cbxRegistro.DisplayMember = "valor";
            cbxRegistro.ValueMember = "id";
        }
        private void FrmCita_Load(object sender, EventArgs e)
        {
            Size = new Size(776, 344);
            listar();
            cargarPaciente();
            cargarRegistro();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Size = new Size(776, 493);
            esNuevo = true;
            txtTratamiento.Focus();
            cbxPaciente.Visible = true;
            lblPaciente.Visible = true;
            cbxRegistro.Visible = true;
            lblRegistro.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Size = new Size(776, 493);
            esNuevo = false;

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var cita = CitaCln.get(id);
            dtpFecha.Value = cita.fecha;
            txtTratamiento.Text = cita.tratamiento;
            cbxPago.Text = cita.pago;
            txtAcuenta.Text = cita.aCuenta;
            dtpHora.Value = Convert.ToDateTime(cita.hora);
            cbxPaciente.Visible = false;
            lblPaciente.Visible = false;
            cbxRegistro.Visible = false;
            lblRegistro.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)//Cancelar
        {
            Size = new Size(776, 344);
            limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            RecargarFormularioLogin();
            Close();
        }
        private void RecargarFormularioLogin()
        {
            FrmPrincipal nuevoFormulario = new FrmPrincipal();
            nuevoFormulario.Show();
            this.Close();  // Cierra el formulario actual
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }
        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }
        private bool validar()
        {
            bool esValido = true;
            erpFecha.SetError(dtpFecha, "");
            erpTratamiento.SetError(txtTratamiento, "");
            erpPago.SetError(cbxPago, "");
            erpAcuenta.SetError(txtAcuenta, "");
            erpHora.SetError(dtpHora, "");
            if (string.IsNullOrEmpty(dtpFecha.Text))
            {
                esValido = false;
                erpFecha.SetError(dtpFecha, "El campo Fecha de consulta es obligatorio");
            }
            else
            {
                DateTime fechaActual = DateTime.Now;
                DateTime fechaConsulta = DateTime.Parse(dtpFecha.Text);
                if (fechaConsulta < fechaActual)
                {
                    esValido = false;
                    erpFecha.SetError(dtpFecha, "La fecha de consulta no puede ser anterior a la fecha actual");
                }
            }
            if (string.IsNullOrEmpty(txtTratamiento.Text))
            {
                esValido = false;
                erpTratamiento.SetError(txtTratamiento, "El campo Tratamiento es obligatorio");
            }
            if (string.IsNullOrEmpty(cbxPago.Text))
            {
                esValido = false;
                erpPago.SetError(cbxPago, "El campo Pago es obligatorio");
            }
            if (string.IsNullOrEmpty(txtAcuenta.Text))
            {
                esValido = false;
                erpAcuenta.SetError(txtAcuenta, "El campo a Cuenta es obligatorio");
            }
            if (string.IsNullOrEmpty(dtpHora.Text))
            {
                esValido = false;
                erpHora.SetError(dtpHora, "El campo Hora es obligatorio");
            }
            return esValido;
        }

        private void button1_Click(object sender, EventArgs e)//Guardar
        {
            if (validar())
            {
                var cita = new Cita();
                cita.fecha = dtpFecha.Value;
                cita.tratamiento = txtTratamiento.Text.Trim();
                cita.pago = cbxPago.Text;
                cita.aCuenta = txtAcuenta.Text.Trim();
                cita.hora = dtpHora.Value.TimeOfDay;
                cita.usuarioRegistro = "SIS324";

                var existeCitas = CitaCln.Listar();
                bool citaExiste = false;

                foreach (var existeCita in existeCitas)
                {
                    if (existeCita.fecha == cita.fecha && existeCita.hora == cita.hora && (esNuevo || existeCita.id != cita.id))
                    {
                        citaExiste = true;
                        break;
                    }
                }

                if (citaExiste)
                {
                    MessageBox.Show("Ya existe una cita con la misma fecha y hora de registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (esNuevo)
                {
                    cita.fechaRegistro = DateTime.Now;
                    cita.estado = 1;
                    cita.idPaciente = Convert.ToInt32(cbxPaciente.SelectedValue);
                    cita.idRegistro = Convert.ToInt32(cbxRegistro.SelectedValue);
                    CitaCln.insertar(cita);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    cita.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    CitaCln.actualizar(cita);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Cita guardada correctamente", "::: Consultorio Odontologico - Mensaje::: ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiar()
        {
            dtpFecha.Value = DateTime.Now;
            txtTratamiento.Text = string.Empty;
            cbxPago.SelectedIndex = -1;
            txtAcuenta.Text = string.Empty;
            dtpHora.Text = string.Empty;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                int index = dgvLista.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                string fecha = dgvLista.Rows[index].Cells["fecha"].Value.ToString();
                DialogResult dialog = MessageBox.Show($"¿Está seguro de eliminar la Cita {fecha}?",
                    "::: Consultorio Odontologico - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    CitaCln.eliminar(id, "SIS324");
                    listar();
                    MessageBox.Show("Cita eliminada correctamente", "::: Consultorio Odontologico - Mensaje :::",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            FrmPaciente llamar = new FrmPaciente();
            llamar.Show();
            Size = new Size(776, 344);
            this.Hide();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
 
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            FrmMedicamento llamar = new FrmMedicamento();
            llamar.Show();
            Size = new Size(776, 344);
            this.Hide();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            FrmPersonal llamar = new FrmPersonal();
            llamar.Show();
            Size = new Size(776, 344);
            this.Hide();
        }
        int posY = 0;
        int posX = 0;
        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}
