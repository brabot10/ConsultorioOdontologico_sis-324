using C1.Framework;
using CadConsultorioOdontologico;
using ClnConsultorioOdontologico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpConsultorioOdontologico
{
    public partial class FrmHorario : Form
    {
        bool esNuevo = false;
        public FrmHorario()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var horario = HorarioCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = horario;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["idPersonal"].Visible = false;
            dgvLista.Columns["nombresPersonal"].HeaderText = "Encargado";
            dgvLista.Columns["lunes"].HeaderText = "Lunes";
            dgvLista.Columns["martes"].HeaderText = "Martes";
            dgvLista.Columns["miercoles"].HeaderText = "Miércoles";
            dgvLista.Columns["jueves"].HeaderText = "Jueves";
            dgvLista.Columns["viernes"].HeaderText = "Viernes";
            dgvLista.Columns["sabado"].HeaderText = "Sábado";
            dgvLista.Columns["mes"].HeaderText = "Mes";
            dgvLista.Columns["permiso"].HeaderText = "Permisos";
            //dgvLista.Columns["clave"].HeaderText = "Clave";
           // dgvLista.Columns["horarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha del Registro";
            btnEliminar.Enabled = horario.Count > 0;
            btnEditar.Enabled = horario.Count > 0;
            if (horario.Count > 0) dgvLista.Rows[0].Cells["mes"].Selected = true;

        }

        private void FrmHorario_Load(object sender, EventArgs e)
        {
            Size = new Size(405, 454);
            listar();
            cargarhorario();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Size = new Size(795, 454);
            esNuevo = true;
            cbxLunes.Focus();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Size = new Size(795, 454);
            esNuevo = false;

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var horario = HorarioCln.get(id);
            cbxLunes.Text = horario.lunes;
            cbxMartes.Text = horario.martes;
            cbxMiercoles.Text = horario.miercoles;
            cbxJueves.Text = horario.jueves;
            cbxViernes.Text = horario.viernes;
            cbxSabado.Text = horario.sabado;
            txtMes.Text = horario.mes;
            dtpPermiso.Value = Convert.ToDateTime(horario.permiso);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(405, 454);
            limpiar();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {   
            // Establecer DialogResult como OK para indicar que se cerró correctamente
            this.DialogResult = DialogResult.OK;

            // Cerrar el formulario
            this.Close();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }
        public void cargarhorario()
        {
            cbxPersonal.DataSource = PersonalCln.listar();
            cbxPersonal.DisplayMember = "nombres";
            cbxPersonal.ValueMember = "id";
        }
        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }
        private bool validar()
        {
            bool esValido = true;
            erpLunes.SetError(cbxLunes, "");
            erpMartes.SetError(cbxMartes, "");
            erpMiercoles.SetError(cbxMiercoles, "");
            erpJueves.SetError(cbxJueves, "");
            erpViernes.SetError(cbxViernes, "");
            erpSabado.SetError(cbxSabado, "");
            erpMes.SetError(txtMes, "");
            erpPermiso.SetError(dtpPermiso, "");
            if (string.IsNullOrEmpty(cbxLunes.Text))
            {
                esValido = false;
                erpLunes.SetError(cbxLunes, "El campo Lunes es obligatorio");
            }
 
            if (string.IsNullOrEmpty(cbxMartes.Text))
            {
                esValido = false;
                erpMartes.SetError(cbxMartes, "El campo Martes es obligatorio");
            }
            if (string.IsNullOrEmpty(cbxMiercoles.Text))
            {
                esValido = false;
                erpMiercoles.SetError(cbxMiercoles, "El campo Miércoles es obligatorio");
            }
            if (string.IsNullOrEmpty(cbxJueves.Text))
            {
                esValido = false;
                erpJueves.SetError(cbxJueves, "El campo Jueves es obligatorio");
            }
            if (string.IsNullOrEmpty(cbxViernes.Text))
            {
                esValido = false;
                erpViernes.SetError(cbxViernes, "El Viernes es obligatorio");
            }
            if (string.IsNullOrEmpty(cbxSabado.Text))
            {
                esValido = false;
                erpSabado.SetError(cbxSabado, "El campo Sábado es obligatorio");
            }
            if (string.IsNullOrEmpty(txtMes.Text))
            {
                esValido = false;
                erpMes.SetError(txtMes, "El campo Mes es obligatorio");
            }
            if (string.IsNullOrEmpty(dtpPermiso.Text))
            {
                esValido = false;
                erpPermiso.SetError(dtpPermiso, "El Fecha de Permiso es obligatorio");
            }
            else
            {
                DateTime fechaActual = DateTime.Now;
                DateTime fechaConsulta = DateTime.Parse(dtpPermiso.Text);
                if (fechaConsulta < fechaActual)
                {
                    esValido = false;
                    erpPermiso.SetError(dtpPermiso, "La fecha de permiso no puede ser anterior a la fecha actual");
                }
            }
            return esValido;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var horario = new Horario();
                horario.lunes = cbxLunes.Text;
                horario.martes = cbxMartes.Text;
                horario.miercoles = cbxMiercoles.Text;
                horario.jueves = cbxJueves.Text;
                horario.viernes = cbxViernes.Text;
                horario.sabado = cbxSabado.Text;
                horario.mes = txtMes.Text;
                horario.permiso = dtpPermiso.Value;
                horario.usuarioRegistro = Util.usuario.usuario1;


                if (esNuevo)
                {
                    horario.fechaRegistro = DateTime.Now;
                    horario.estado = 1;
                    horario.idPersonal = Convert.ToInt32(cbxPersonal.SelectedValue);
                    HorarioCln.insertar(horario);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    horario.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    HorarioCln.actualizar(horario);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Horario guardada correctamente", "::: Consultorio Odontologico - Mensaje::: ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiar()
        {
            cbxLunes.SelectedIndex = -1;
            cbxMartes.SelectedIndex = -1;
            cbxMiercoles.SelectedIndex = -1;
            cbxJueves.SelectedIndex = -1;
            cbxViernes.SelectedIndex = -1;
            cbxSabado.SelectedIndex = -1;
            txtMes.Text = string.Empty;
            dtpPermiso.Value = DateTime.Now;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string mes = dgvLista.Rows[index].Cells["mes"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro de eliminar el Horario {mes}?",
                "::: Consultorio Odontologico - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                HorarioCln.eliminar(id, "SIS324");
                listar();
                MessageBox.Show("Horario eliminada correctamente", "::: Consultorio Odontologico - Mensaje :::",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        int posX = 0;
        int posY = 0;
        private void pnlMovimiento_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMovimiento_MouseMove(object sender, MouseEventArgs e)
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
