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
    public partial class FrmPersonal : Form
    {
        bool cedula = false;
        bool esNuevo = false;
        public FrmPersonal()
        {
            InitializeComponent();
        }
        private void listar()
        {
            var personal = PersonalCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = personal;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["cedulaIdentidad"].HeaderText = "Cedula de Identidad";
            dgvLista.Columns["nombres"].HeaderText = "Nombre";
            dgvLista.Columns["primerApellido"].HeaderText = "Primer Apellido";
            dgvLista.Columns["segundoApellido"].HeaderText = "Segundo Apellido";
            dgvLista.Columns["direccion"].HeaderText = "Dirección";
            dgvLista.Columns["celular"].HeaderText = "Celular";
            dgvLista.Columns["cargo"].HeaderText = "Cargo";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha del Registro";
            btnEditar.Enabled = personal.Count > 0;
            btnEliminar.Enabled = personal.Count > 0;
            if (personal.Count > 0) dgvLista.Rows[0].Cells["nombres"].Selected = true;

        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            Size = new Size(776, 344);
            listar();
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
            var personal = PersonalCln.get(id);
            txtCedulaIdentidad.Text = personal.cedulaIdentidad;
            txtNombre.Text = personal.nombres;
            txtPrimerApellido.Text = personal.primerApellido;
            txtSegundoApellido.Text = personal.segundoApellido;
            txtDireccion.Text = personal.direccion;
            txtCelular.Text = personal.celular.ToString();
            txtCargo.Text = personal.cargo;
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
            erpCedulaIdentidad.SetError(txtCedulaIdentidad, "");
            erpNombre.SetError(txtNombre, "");
            erpPrimerApellido.SetError(txtPrimerApellido, "");
            erpSegundoApellido.SetError(txtSegundoApellido, "");
            erpDireccion.SetError(txtDireccion, "");
            erpCelular.SetError(txtCelular, "");
            erpCargo.SetError(txtCargo, "");
            if (string.IsNullOrEmpty(txtCedulaIdentidad.Text))
            {
                esValido = false;
                erpCedulaIdentidad.SetError(txtCedulaIdentidad, "El campo Cedula de Identidad es obligatorio");
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                esValido = false;
                erpNombre.SetError(txtNombre, "El campo Nombre es obligatorio");
            }
            else if (!Regex.IsMatch(txtNombre.Text, "^[a-zA-Z\\s]+$"))
            {
                esValido = false;
                erpNombre.SetError(txtNombre, "El campo Nombre debe contener solo letras y espacios");
            }
            if (string.IsNullOrEmpty(txtPrimerApellido.Text))
            {
                esValido = false;
                erpPrimerApellido.SetError(txtPrimerApellido, "El campo Primer Apellido es obligatorio");
            }
            else if (!Regex.IsMatch(txtPrimerApellido.Text, "^[a-zA-Z\\s]+$"))
            {
                esValido = false;
                erpPrimerApellido.SetError(txtPrimerApellido, "El campo Primer Apellido debe contener solo letras y espacios");
            }
            if (string.IsNullOrEmpty(txtSegundoApellido.Text))
            {
                esValido = false;
                erpSegundoApellido.SetError(txtSegundoApellido, "El campo Segundo Apellido es obligatorio");
            }
            else if (!Regex.IsMatch(txtSegundoApellido.Text, "^[a-zA-Z\\s]+$"))
            {
                esValido = false;
                erpSegundoApellido.SetError(txtSegundoApellido, "El campo Segundo Apellido debe contener solo letras y espacios");
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                esValido = false;
                erpDireccion.SetError(txtDireccion, "El campo dirección es obligatorio");
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
            if (string.IsNullOrEmpty(txtCargo.Text))
            {
                esValido = false;
                erpCargo.SetError(txtCargo, "El campo Cargo es obligatorio");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cedula == true)
            {
                if (validar())
                {
                    var personal = new Personal();
                    personal.cedulaIdentidad = txtCedulaIdentidad.Text.Trim();
                    personal.nombres = txtNombre.Text.Trim();
                    personal.primerApellido = txtPrimerApellido.Text;
                    personal.segundoApellido = txtSegundoApellido.Text;
                    personal.direccion = txtDireccion.Text;
                    personal.celular = int.Parse(txtCelular.Text);
                    personal.cargo = txtCargo.Text;
                    personal.usuarioRegistro = "SIS324";
                    var existePersonales = PersonalCln.listar();
                    bool personalExiste = false;

                    foreach (var existePaciente in existePersonales)
                    {
                        if (existePaciente.cedulaIdentidad == personal.cedulaIdentidad && (esNuevo || existePaciente.id != personal.id))
                        {
                            personalExiste = true;
                            break;
                        }
                    }

                    if (personalExiste)
                    {
                        MessageBox.Show("Ya existe un personal con el mismo CI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (esNuevo)
                    {
                        personal.fechaRegistro = DateTime.Now;
                        personal.estado = 1;
                        PersonalCln.insertar(personal);
                        cedula = false;
                    }
                    else
                    {
                        int index = dgvLista.CurrentCell.RowIndex;
                        personal.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                        PersonalCln.actualizar(personal);
                    }
                    listar();
                    btnCancelar.PerformClick();
                    MessageBox.Show("Personal guardado correctamente", "::: Consultorio Odontologico - Mensaje::: ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                if (validar())
                {
                    var personal = new Personal();
                    personal.cedulaIdentidad = txtCedulaIdentidad.Text.Trim();
                    personal.nombres = txtNombre.Text.Trim();
                    personal.primerApellido = txtPrimerApellido.Text;
                    personal.segundoApellido = txtSegundoApellido.Text;
                    personal.direccion = txtDireccion.Text;
                    personal.celular = int.Parse(txtCelular.Text);
                    personal.cargo = txtCargo.Text;
                    personal.usuarioRegistro = "SIS324";
                    if (esNuevo)
                    {
                        personal.fechaRegistro = DateTime.Now;
                        personal.estado = 1;
                        PersonalCln.insertar(personal);
                    }
                    else
                    {
                        int index = dgvLista.CurrentCell.RowIndex;
                        personal.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                        PersonalCln.actualizar(personal);
                    }
                    listar();
                    btnCancelar.PerformClick();
                    MessageBox.Show("Personal guardado correctamente", "::: Consultorio Odontologico - Mensaje::: ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
        private void limpiar()
        {
            txtCedulaIdentidad.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtCargo.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                int index = dgvLista.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                string nombres = dgvLista.Rows[index].Cells["nombres"].Value.ToString();
                DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja al Personal {nombres}?",
                    "::: Consultorio Odontologico - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    PersonalCln.eliminar(id, "SIS324");
                    listar();
                    MessageBox.Show("Personal dado de baja correctamente", "::: Consultorio Odontologico - Mensaje :::",
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

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            FrmMedicamento llamar = new FrmMedicamento();
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
        private void RecargarFormularioPersonal()
        {
            // Coloca aquí cualquier código adicional necesario antes de recargar el formulario
            FrmPersonal nuevoFormulario = new FrmPersonal();
            nuevoFormulario.Show();
            this.Close();  // Cierra el formulario actual
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            var colorOriginal = this.BackColor;

            // Cambia el color de fondo de todos los controles a gris y guarda los colores originales
            CambiarColorControles(this.Controls, SystemColors.ControlDark);

            // Creamos el formulario usuario
            FrmUsuario frmUsuario = new FrmUsuario();

            // Mostramos el formulario usuario de manera modal
            DialogResult result = frmUsuario.ShowDialog();

            // Limpia el diccionario de colores originales
            //coloresOriginales.Clear();

            // Verificamos si el formulario de usuario se cerró correctamente
            if (result == DialogResult.OK)
            {
                // El código aquí se ejecutará después de que FrmUsuario se cierre
                // Desbloqueamos el funcionamiento del formulario personal
                RecargarFormularioPersonal();
                this.Enabled = true;
            }
        }
    }
}
