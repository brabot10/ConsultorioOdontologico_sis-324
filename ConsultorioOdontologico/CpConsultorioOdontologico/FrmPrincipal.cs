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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool validar()
        {
            bool esValido = true;
            erpUsuario.SetError(txtUsuario, "");
            erpClave.SetError(txtClave, "");
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                erpUsuario.SetError(txtUsuario, "El campo usuario es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                erpClave.SetError(txtClave, "El campo contraseña es obligatorio");
                esValido = false;
            }
            return esValido;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                FrmPaciente llamar = new FrmPaciente();
                llamar.Show();
                Size = new Size(776, 344);
                this.Hide();
            }
            /*if (validar())
            {
                var usuario = UsuarioCln.validar(txtUsuario.Text, Util.Encrypt(txtClave.Text));
                if (usuario != null)
                {
                    Util.usuario = usuario;
                    txtClave.Text = string.Empty;
                    txtUsuario.Focus();
                    txtUsuario.SelectAll();
                    FrmPaciente llamar = new FrmPaciente();
                    llamar.Show();
                    Size = new Size(776, 344);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos",
                        "::: Minerva - Mensaje :::", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }*/

            /*if (validar())
            {
                var usuario = UsuarioCln.validar(txtUsuario.Text, Util.Encrypt(txtClave.Text));
                if (usuario != null)
                {
                    Util.usuario = usuario;
                    txtClave.Text = string.Empty;
                    txtUsuario.Focus();
                    txtUsuario.SelectAll();
                    Visible = false;
                    new FrmPaciente (this).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos",
                        "::: Minerva - Mensaje :::", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }*/


        }

        private void pnlCabeza_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnIngresar.PerformClick();
        }
        int posY = 0;
        int posX = 0;
        private void pnlCabeza_MouseMove(object sender, MouseEventArgs e)
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
