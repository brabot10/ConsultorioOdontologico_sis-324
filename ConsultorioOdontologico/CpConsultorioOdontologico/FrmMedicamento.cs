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
            dgvLista.Columns["idInventario"].Visible = false;
            dgvLista.Columns["nombresPaciente"].HeaderText = "Nombre del Paciente";
            dgvLista.Columns["articuloInventario"].HeaderText = "Nombre del Artículo";
            dgvLista.Columns["precioInventario"].HeaderText = "Precio del Artículo en Bs";
            dgvLista.Columns["cantidad"].HeaderText = "Cantidad del Medicamento";
            dgvLista.Columns["descripcion"].HeaderText = "Descripcion del Medicamento";
            dgvLista.Columns["total"].HeaderText = "total del Medicamento en Bs";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha del Registro";
            btnEditar.Enabled = medicamento.Count > 0;
            btnEliminar.Enabled = medicamento.Count > 0;
            if (medicamento.Count > 0) dgvLista.Rows[0].Cells["cantidad"].Selected = true;

        }
        private void cargarPaciente()
        {
            cbxPaciente.DataSource = PacienteCln.listar();
            cbxPaciente.DisplayMember = "nombres";
            cbxPaciente.ValueMember = "id";
        }

        private void cargarInventario()
        {
            cbxInventario.DataSource = InventarioCln.listar();
            cbxInventario.DisplayMember = "articulo";
            cbxInventario.ValueMember = "id";
        }
        private void FrmMedicamento_Load(object sender, EventArgs e)
        {
            Size = new Size(776, 344);
            listar();
            cargarPaciente();
            cargarInventario();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Size = new Size(776, 493);
            esNuevo = true;
            txtTotal.Focus();
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
            nudCantidad.Value = medicamento.cantidad;
            txtDescripcion.Text = medicamento.descripcion;
            txtTotal.Text = medicamento.total.ToString();
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
            erpCantidad.SetError(nudCantidad, "");
            erpDescripcion.SetError(txtDescripcion, "");
            erpTotal.SetError(txtTotal, "");
            if (string.IsNullOrEmpty(nudCantidad.Text))
            {
                esValido = false;
                erpCantidad.SetError(nudCantidad, "El campo Cantidad es obligatorio");
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                esValido = false;
                erpDescripcion.SetError(txtDescripcion, "El campo Descripción  es obligatorio");
            }
            if (string.IsNullOrEmpty(txtTotal.Text))
            {
                esValido = false;
                erpTotal.SetError(txtTotal, "El campo Total es obligatorio");
            }
            else if (!Regex.IsMatch(txtTotal.Text, "^\\d+$"))
            {
                esValido = false;
                erpTotal.SetError(txtTotal, "El campo Total debe contener solo números");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var medicamento = new Medicamento();
                medicamento.cantidad = nudCantidad.Value;
                medicamento.descripcion = txtDescripcion.Text.Trim();
                medicamento.total = int.Parse(txtTotal.Text);
                medicamento.usuarioRegistro = Util.usuario.usuario1;
                if (esNuevo)
                {
                    medicamento.fechaRegistro = DateTime.Now;
                    medicamento.estado = 1;
                    medicamento.idPaciente = Convert.ToInt32(cbxPaciente.SelectedValue);
                    medicamento.idInventario = Convert.ToInt32(cbxInventario.SelectedValue);
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
            nudCantidad.Value = 0;
            txtDescripcion.Text = string.Empty;
            txtTotal.Text = string.Empty;
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
        private Dictionary<Control, Color> coloresOriginales = new Dictionary<Control, Color>();
        private void CambiarColorControles(Control.ControlCollection controles, Color nuevoColor)
        {
            foreach (Control control in controles)
            {
                coloresOriginales[control] = control.BackColor;

                control.BackColor = nuevoColor;

                if (control.HasChildren)
                {
                    CambiarColorControles(control.Controls, nuevoColor);
                }
            }
        }
        private void RecargarFormularioMedicamentos()
        {
            // Coloca aquí cualquier código adicional necesario antes de recargar el formulario
            FrmMedicamento nuevoFormulario = new FrmMedicamento();
            nuevoFormulario.Show();
            this.Close();  // Cierra el formulario actual
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            var colorOriginal = this.BackColor;

            // Cambia el color de fondo de todos los controles a gris y guarda los colores originales
            CambiarColorControles(this.Controls, SystemColors.ControlDark);

            // Creamos el formulario usuario
            FrmInventario frminventraio = new FrmInventario();

            // Mostramos el formulario usuario de manera modal
            DialogResult result = frminventraio.ShowDialog();

            // Limpia el diccionario de colores originales
            //coloresOriginales.Clear();

            // Verificamos si el formulario de usuario se cerró correctamente
            if (result == DialogResult.OK)
            {
                // El código aquí se ejecutará después de que FrmUsuario se cierre
                // Desbloqueamos el funcionamiento del formulario personal
                RecargarFormularioMedicamentos();
                this.Enabled = true;
            }
        }
    }
}
