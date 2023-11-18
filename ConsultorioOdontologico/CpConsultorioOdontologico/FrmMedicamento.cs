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
    public partial class FrmMedicamento : Form
    {
        bool esNuevo = false;
        public FrmMedicamento()
        {
            InitializeComponent();
        }
        private void listar()
        {
            var medicamento = MedicamentoCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = medicamento;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["idPaciente"].Visible = false;
            dgvLista.Columns["nombresPaciente"].HeaderText = "Nombre del Paciente";
            dgvLista.Columns["articulo"].HeaderText = "Nombre del Medicamento";
            dgvLista.Columns["descripcion"].HeaderText = "Descripcion del Medicamento";
            dgvLista.Columns["precio"].HeaderText = "Precio del Medicamento en Bs";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha del Registro";
            btnEditar.Enabled = medicamento.Count > 0;
            btnEliminar.Enabled = medicamento.Count > 0;
            if (medicamento.Count > 0) dgvLista.Rows[0].Cells["articulo"].Selected = true;

        }
        private void cargarPaciente()
        {
            cbxPaciente.DataSource = PacienteCln.listar();
            cbxPaciente.DisplayMember = "nombres";
            cbxPaciente.ValueMember = "id";
        }
        private void FrmMedicamento_Load(object sender, EventArgs e)
        {
            Size = new Size(776, 344);
            listar();
            cargarPaciente();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Size = new Size(776, 493);
            esNuevo = true;
            txtArticulo.Focus();
            cbxPaciente.Visible = true;
            lblPaciente.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Size = new Size(776, 493);
            esNuevo = false;

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var medicamento = MedicamentoCln.get(id);
            txtArticulo.Text = medicamento.articulo;
            txtDescripcion.Text = medicamento.descripcion;
            txtPrecio.Text = medicamento.precio.ToString();
            cbxPaciente.Visible = false;
            lblPaciente.Visible = false;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
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
            erpArticulo.SetError(txtArticulo, "");
            erpDescripcion.SetError(txtDescripcion, "");
            erpPrecio.SetError(txtPrecio, "");
            if (string.IsNullOrEmpty(txtArticulo.Text))
            {
                esValido = false;
                erpArticulo.SetError(txtArticulo, "El campo Artículo es obligatorio");
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                esValido = false;
                erpDescripcion.SetError(txtDescripcion, "El campo Descripción  es obligatorio");
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                esValido = false;
                erpPrecio.SetError(txtPrecio, "El campo Precio es obligatorio");
            }
            else if (!Regex.IsMatch(txtPrecio.Text, "^\\d+$"))
            {
                esValido = false;
                erpPrecio.SetError(txtPrecio, "El campo Precio debe contener solo números");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var medicamento = new Medicamento();
                medicamento.articulo = txtArticulo.Text.Trim();
                medicamento.descripcion = txtDescripcion.Text.Trim();
                medicamento.precio = int.Parse(txtPrecio.Text);
                medicamento.usuarioRegistro = "SIS324";
                if (esNuevo)
                {
                    medicamento.fechaRegistro = DateTime.Now;
                    medicamento.estado = 1;
                    medicamento.idPaciente = Convert.ToInt32(cbxPaciente.SelectedValue);
                    MedicamentoCln.insertar(medicamento);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    medicamento.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    MedicamentoCln.actualizar(medicamento);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Medicamento guardado correctamente", "::: Consultorio Odontologico - Mensaje::: ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiar()
        {
            txtArticulo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                int index = dgvLista.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                string articulo = dgvLista.Rows[index].Cells["articulo"].Value.ToString();
                DialogResult dialog = MessageBox.Show($"¿Está seguro que desea eliminar el Medicamento {articulo}?",
                    "::: Consultorio Odontologico - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    MedicamentoCln.eliminar(id, "SIS324");
                    listar();
                    MessageBox.Show("Medicamento eliminado correctamente", "::: Consultorio Odontologico - Mensaje :::",
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
            FrmCita llamar = new FrmCita();
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
