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
            cargarpersonal();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Size = new Size(795, 454);
            esNuevo = true;
            cbxLunes.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(405, 454);
            //limpiar();
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
        public void cargarpersonal()
        {
            cbxPersonal.DataSource = PersonalCln.listar();
            cbxPersonal.DisplayMember = "nombres";
            cbxPersonal.ValueMember = "id";
        }
        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
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
