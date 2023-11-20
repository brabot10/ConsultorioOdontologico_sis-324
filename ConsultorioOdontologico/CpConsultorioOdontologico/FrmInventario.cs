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
    public partial class FrmInventario : Form
    {
        bool esNuevo = false;
        public FrmInventario()
        {
            InitializeComponent();
        }
        private void listar()
        {
            var inventario = InventarioCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = inventario;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["articulo"].HeaderText = "Nombre del Artículo";
            dgvLista.Columns["precio"].HeaderText = "Precio del Artículo en Bs";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha del Registro";
            btnEditar.Enabled = inventario.Count > 0;
            btnEliminar.Enabled = inventario.Count > 0;
            if (inventario.Count > 0) dgvLista.Rows[0].Cells["articulo"].Selected = true;

        }
        private void FrmInventario_Load(object sender, EventArgs e)
        {
            Size = new Size(405, 296);
            listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(405, 454);
            txtArticulo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Size = new Size(405, 454);
            esNuevo = false;

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var personal = InventarioCln.get(id);
            txtArticulo.Text = personal.articulo;
            nudPrecio.Value = personal.precio;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(405, 296);
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

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }
        private bool validar()
        {
            bool esValido = true;
            erpArticulo.SetError(txtArticulo, "");
            erpPrecio.SetError(nudPrecio, "");
            if (string.IsNullOrEmpty(txtArticulo.Text))
            {
                esValido = false;
                erpArticulo.SetError(txtArticulo, "El campo Articulo es obligatorio");
            }
            if (string.IsNullOrEmpty(nudPrecio.Text))
            {
                esValido = false;
                erpPrecio.SetError(nudPrecio, "El campo Precio es obligatorio");

            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var inventario = new Inventario();
                inventario.articulo = txtArticulo.Text.Trim();
                inventario.precio = nudPrecio.Value;
                inventario.usuarioRegistro = Util.usuario.usuario1;

                if (esNuevo)
                {
                    inventario.fechaRegistro = DateTime.Now;
                    inventario.estado = 1;
                    InventarioCln.insertar(inventario);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    inventario.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    InventarioCln.actualizar(inventario);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Articulo guardado correctamente", "::: Consultorio Odontologico - Mensaje::: ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiar()
        {
            txtArticulo.Text = string.Empty;
            nudPrecio.Value = 0;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string articulo = dgvLista.Rows[index].Cells["articulo"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea eliminar el Artículo {articulo}?",
                "::: Consultorio Odontologico - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                InventarioCln.eliminar(id, "SIS457");
                listar();
                MessageBox.Show("Artículo eliminado correctamente", "::: Consultorio Odontologico - Mensaje :::",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        int posX = 0;
        int posY = 0;

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
