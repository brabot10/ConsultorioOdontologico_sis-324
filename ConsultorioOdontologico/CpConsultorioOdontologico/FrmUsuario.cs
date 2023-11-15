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
    public partial class FrmUsuario : Form
    {
        bool esNuevo = true;

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var usuario = UsuarioCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = usuario;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["usuario"].HeaderText = "Usuario";
            dgvLista.Columns["clave"].HeaderText = "Clave";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha del Registro";
            if (usuario.Count > 0) dgvLista.Rows[0].Cells["usuario"].Selected = true;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            listar();
            cargarPersonal();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            // Establecer DialogResult como OK para indicar que se cerró correctamente
            this.DialogResult = DialogResult.OK;

            // Cerrar el formulario
            this.Close();

           // Close();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }
        private void cargarPersonal()
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
            erpUsuario.SetError(txtUsuario, "");
            erpClave.SetError(txtClave, "");
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                esValido = false;
                erpUsuario.SetError(txtUsuario, "El campo Usuario es obligatorio");
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                esValido = false;
                erpClave.SetError(txtClave, "El campo CLave es obligatorio");
            }

            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var usuario = new Usuario();
                usuario.usuario1 = txtUsuario.Text.Trim();
                usuario.clave = txtClave.Text.Trim();
                usuario.usuarioRegistro = "SIS324";

                var existeUsuario = UsuarioCln.listar();
                bool usuarioExiste = false;

                foreach (var existeUsuarios in existeUsuario)
                {
                    if (existeUsuarios.usuario1 == usuario.usuario1 && (esNuevo || existeUsuarios.id != usuario.id))
                    {
                        usuarioExiste = true;
                        break;
                    }
                }

                if (usuarioExiste)
                {
                    MessageBox.Show("Ya existe un usuario con el mismo Nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (esNuevo)
                {
                    usuario.fechaRegistro = DateTime.Now;
                    usuario.estado = 1;
                    usuario.idPersonal = Convert.ToInt32(cbxPersonal.SelectedValue);
                    UsuarioCln.insertar(usuario);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    usuario.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    UsuarioCln.actualizar(usuario);
                }
                listar();
                MessageBox.Show("Usuario guardado correctamente", "::: Consultorio Odontologico - Mensaje::: ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiar()
        {
            txtUsuario.Text = string.Empty;
        }


    }
}
