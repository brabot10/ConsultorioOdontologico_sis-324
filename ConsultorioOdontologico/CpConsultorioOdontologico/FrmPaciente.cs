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
    public partial class FrmPaciente : Form
    {
        //FrmPrincipal frmPrincipal;

        bool esNuevo = false;
        bool cedula = false;
        //(FrmPrincipal frmPrincipal)
        public FrmPaciente()
        {
            InitializeComponent();
            //this.frmPrincipal = frmPrincipal;
        }
        private void listar()
        {
            var paciente = PacienteCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = paciente;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["idPersonal"].HeaderText = "Doctor Asignado";
            dgvLista.Columns["nombres"].HeaderText = "Nombre";
            dgvLista.Columns["cedulaIdentidad"].HeaderText = "Cedula de Identidad";
            dgvLista.Columns["alergias"].HeaderText = "Alergias";
            dgvLista.Columns["fechaNacimiento"].HeaderText = "Fecha de Nacimiento";
            dgvLista.Columns["celular"].HeaderText = "Celular";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha del Registro";
            btnEditar.Enabled = paciente.Count > 0;
            btnEliminar.Enabled = paciente.Count > 0;
            if (paciente.Count > 0) dgvLista.Rows[0].Cells["nombres"].Selected = true;

        }
        private void cargarPersonal()
        {
            cbxPersonal.DataSource = PersonalCln.listar();
            cbxPersonal.DisplayMember = "nombres";
            cbxPersonal.ValueMember = "id";
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            Size = new Size(776, 344);
            listar();
            cargarPersonal();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Size = new Size(776, 493);
            esNuevo = true;
            txtCelular.Focus();
            cedula = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Size = new Size(776, 493);
            esNuevo = false;

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var paciente = PacienteCln.get(id);
            txtNombre.Text = paciente.nombres;
            txtCedulaIdentidad.Text = paciente.cedulaIdentidad;
            txtAlergias.Text = paciente.alergias;
            dtpFechaNacimiento.Value = paciente.fechaNacimiento;
            txtCelular.Text = paciente.celular.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(776, 344);
            limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
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
            erpNombre.SetError(txtNombre, "");
            erpCedulaIdentidad.SetError(txtCedulaIdentidad, "");
            erpAlergias.SetError(txtAlergias, "");
            erpFechaNacimiento.SetError(dtpFechaNacimiento, "");
            erpCelular.SetError(txtCelular, "");
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                esValido = false;
                erpNombre.SetError(txtNombre, "El campo Nombre es obligatorio");
            }
            if (string.IsNullOrEmpty(txtCedulaIdentidad.Text))
            {
                esValido = false;
                erpCedulaIdentidad.SetError(txtCedulaIdentidad, "El campo Cedula de Identidad es obligatorio");
            }
            if (string.IsNullOrEmpty(txtAlergias.Text))
            {
                esValido = false;
                erpAlergias.SetError(txtAlergias, "El campo Alergias es obligatorio");
            }
            else if (!Regex.IsMatch(txtAlergias.Text, "^[a-zA-Z\\s]+$"))
            {
                esValido = false;
                erpAlergias.SetError(txtAlergias, "El campo Alergias debe contener solo letras y espacios");
            }
            if (string.IsNullOrEmpty(dtpFechaNacimiento.Text))
            {
                esValido = false;
                erpFechaNacimiento.SetError(dtpFechaNacimiento, "El campo Fecha de Nacimiento es obligatorio");
            }
            else
            {
                DateTime fechaActual = DateTime.Now;
                DateTime fechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Text);
                if (fechaActual.Year - fechaNacimiento.Year < 1)
                {
                    esValido = false;
                    erpFechaNacimiento.SetError(dtpFechaNacimiento, "El paciente debe ser mayor a un año");
                }
            }
            if (string.IsNullOrEmpty(txtCelular.Text))
            {
                esValido = false;
                erpCelular.SetError(txtCelular, "El campo Celular es obligatorio");
            }
            else if (!Regex.IsMatch(txtCelular.Text, "^\\d+$"))
            {
                esValido = false;
                erpCelular.SetError(txtCelular, "El campo Celular debe contener solo números");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cedula == true)
            {
                if (validar())
                {
                    var paciente = new Paciente();
                    paciente.nombres = txtNombre.Text.Trim();
                    paciente.cedulaIdentidad = txtCedulaIdentidad.Text.Trim();
                    paciente.alergias = txtAlergias.Text;
                    paciente.fechaNacimiento = dtpFechaNacimiento.Value;
                    paciente.celular = int.Parse(txtCelular.Text);
                    paciente.usuarioRegistro = "SIS324";

                    var existePacientes = PacienteCln.listar();
                    bool pacienteExiste = false;

                    foreach (var existePaciente in existePacientes)
                    {
                        if (existePaciente.cedulaIdentidad == paciente.cedulaIdentidad && (esNuevo || existePaciente.id != paciente.id))
                        {
                            pacienteExiste = true;
                            break;
                        }
                    }

                    if (pacienteExiste)
                    {
                        MessageBox.Show("Ya existe un paciente con el mismo CI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (esNuevo)
                    {
                        paciente.fechaRegistro = DateTime.Now;
                        paciente.estado = 1;
                        paciente.idPersonal = Convert.ToInt32(cbxPersonal.SelectedValue);
                        PacienteCln.insertar(paciente);
                    }
                    else
                    {
                        int index = dgvLista.CurrentCell.RowIndex;
                        paciente.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                        PacienteCln.actualizar(paciente);
                    }
                    listar();
                    btnCancelar.PerformClick();
                    MessageBox.Show("Paciente guardado correctamente", "::: Consultorio Odontologico - Mensaje::: ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else
            {
                if (validar())
                {
                    var paciente = new Paciente();
                    paciente.nombres = txtNombre.Text.Trim();
                    paciente.cedulaIdentidad = txtCedulaIdentidad.Text.Trim();
                    paciente.alergias = txtAlergias.Text;
                    paciente.fechaNacimiento = dtpFechaNacimiento.Value;
                    paciente.celular = int.Parse(txtCelular.Text);
                    paciente.usuarioRegistro = "SIS324";

                    if (esNuevo)
                    {
                        paciente.fechaRegistro = DateTime.Now;
                        paciente.estado = 1;
                        paciente.idPersonal = Convert.ToInt32(cbxPersonal.SelectedValue);
                        PacienteCln.insertar(paciente);
                    }
                    else
                    {
                        int index = dgvLista.CurrentCell.RowIndex;
                        paciente.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                        PacienteCln.actualizar(paciente);
                    }
                    listar();
                    btnCancelar.PerformClick();
                    MessageBox.Show("Paciente guardado correctamente", "::: Consultorio Odontologico - Mensaje::: ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void limpiar()
        {
            txtCelular.Text = string.Empty;
            txtCedulaIdentidad.Text = string.Empty;
            txtAlergias.Text = string.Empty;
            dtpFechaNacimiento.Value = DateTime.Now;
            txtCelular.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                int index = dgvLista.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                string nombres = dgvLista.Rows[index].Cells["nombres"].Value.ToString();
                DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja al Paciente {nombres}?",
                    "::: Consultorio Odontologico - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    PacienteCln.eliminar(id, "SIS324");
                    listar();
                    MessageBox.Show("Paciente dado de baja correctamente", "::: Consultorio Odontologico - Mensaje :::",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {

        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            FrmCita llamar = new FrmCita();
            llamar.Show();
            Size = new Size(776, 344);
            this.Hide();
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

        private void FrmPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
           // frmPrincipal.Visible = true;
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
