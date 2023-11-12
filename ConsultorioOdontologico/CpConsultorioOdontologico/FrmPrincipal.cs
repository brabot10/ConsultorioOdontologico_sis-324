using ClnConsultorioOdontologico;
using MySql.Data.MySqlClient;
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
        MySqlConnection conexionDB = UsuarioCln.conexion();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmPaciente llamar = new FrmPaciente();
            llamar.Show();
            Size = new Size(776, 344);
            this.Hide();
            //try
            //{
            //    conexionDB.Open();
            //}
            //catch (Exception ex)
            //{
            //  MessageBox.Show(ex.Message);
            //}
            //MySqlCommand codigo = new MySqlCommand();
            //codigo.Connection = conexionDB;

            //codigo.CommandText = ("SELECT * FROM usuario WHERE usuario = '" + txtUsuario.Text + "'and clave = '" + txtClave.Text + "' ");

            //MySqlDataReader leer = codigo.ExecuteReader();

            //if (leer.Read())
            //{
            //   FrmPaciente llamar = new FrmPaciente();
            //   llamar.Show();
            //   Size = new Size(776, 344);
            //   this.Hide();
            // }
            //else
            //{
            //   MessageBox.Show("Usuario o Contraseña Incorrecta");
            //   txtUsuario.Clear();
            //    txtClave.Clear();
            // }
            // conexionDB.Close();

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
    }
}
