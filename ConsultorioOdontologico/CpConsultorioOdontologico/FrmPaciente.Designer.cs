namespace CpConsultorioOdontologico
{
    partial class FrmPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaciente));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnMedicamentos = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.pnlDatosDes = new System.Windows.Forms.Panel();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.cbxPersonal = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtAlergias = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblAlergias = new System.Windows.Forms.Label();
            this.txtCedulaIdentidad = new System.Windows.Forms.TextBox();
            this.lblCedulaIdentidad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.erpNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCedulaIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpAlergias = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpFechaNacimiento = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCelular = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.pnlDatosDes.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpAlergias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFechaNacimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCelular)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.pnlMenu.Controls.Add(this.btnPersonal);
            this.pnlMenu.Controls.Add(this.btnMedicamentos);
            this.pnlMenu.Controls.Add(this.btnCitas);
            this.pnlMenu.Controls.Add(this.btnPaciente);
            this.pnlMenu.Controls.Add(this.pbxLogo);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(157, 342);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(168)))));
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.btnPersonal.Image = global::CpConsultorioOdontologico.Properties.Resources.personal;
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.Location = new System.Drawing.Point(0, 275);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(155, 59);
            this.btnPersonal.TabIndex = 16;
            this.btnPersonal.Text = "  Personal";
            this.btnPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnMedicamentos
            // 
            this.btnMedicamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(168)))));
            this.btnMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicamentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.btnMedicamentos.Image = global::CpConsultorioOdontologico.Properties.Resources.medicamentos;
            this.btnMedicamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicamentos.Location = new System.Drawing.Point(0, 212);
            this.btnMedicamentos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMedicamentos.Name = "btnMedicamentos";
            this.btnMedicamentos.Size = new System.Drawing.Size(155, 59);
            this.btnMedicamentos.TabIndex = 15;
            this.btnMedicamentos.Text = "           Medicamentos";
            this.btnMedicamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedicamentos.UseVisualStyleBackColor = false;
            this.btnMedicamentos.Click += new System.EventHandler(this.btnMedicamentos_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(168)))));
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.btnCitas.Image = global::CpConsultorioOdontologico.Properties.Resources.citas;
            this.btnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.Location = new System.Drawing.Point(0, 150);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(2);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(155, 59);
            this.btnCitas.TabIndex = 14;
            this.btnCitas.Text = "Citas";
            this.btnCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(168)))));
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.btnPaciente.Image = global::CpConsultorioOdontologico.Properties.Resources.Paciente;
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(0, 88);
            this.btnPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(155, 59);
            this.btnPaciente.TabIndex = 13;
            this.btnPaciente.Text = "Pacientes";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaciente.UseVisualStyleBackColor = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImage = global::CpConsultorioOdontologico.Properties.Resources.pacientes;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLogo.Image = global::CpConsultorioOdontologico.Properties.Resources.pacientes;
            this.pbxLogo.Location = new System.Drawing.Point(42, 3);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(73, 93);
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(156, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(620, 71);
            this.pnlTitulo.TabIndex = 2;
            this.pnlTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseMove);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(14, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(591, 32);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Consultorio Odontologico :::Pacientes:::";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.White;
            this.lblBusqueda.Location = new System.Drawing.Point(7, 11);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(233, 16);
            this.lblBusqueda.TabIndex = 31;
            this.lblBusqueda.Text = "Buscar por nombre del Paciente:";
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.pnlDatos.Controls.Add(this.pnlAcciones);
            this.pnlDatos.Controls.Add(this.gbxLista);
            this.pnlDatos.Controls.Add(this.btnBuscar);
            this.pnlDatos.Controls.Add(this.txtParametro);
            this.pnlDatos.Controls.Add(this.lblBusqueda);
            this.pnlDatos.Location = new System.Drawing.Point(156, 71);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(620, 271);
            this.pnlDatos.TabIndex = 30;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Location = new System.Drawing.Point(13, 194);
            this.pnlAcciones.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(592, 72);
            this.pnlAcciones.TabIndex = 36;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.btnEditar.Image = global::CpConsultorioOdontologico.Properties.Resources.btnEditar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(175, 5);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(111, 59);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.btnEliminar.Image = global::CpConsultorioOdontologico.Properties.Resources._3017912_annul_cancel_clean_delete_eliminate_icon;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(317, 5);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 59);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.btnNuevo.Image = global::CpConsultorioOdontologico.Properties.Resources.btnNuevo;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(36, 5);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(111, 59);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.btnCerrar.Image = global::CpConsultorioOdontologico.Properties.Resources._1891023_cancel_cercle_close_delete_dismiss_icon;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(454, 5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(111, 59);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLista.ForeColor = System.Drawing.Color.White;
            this.gbxLista.Location = new System.Drawing.Point(10, 61);
            this.gbxLista.Margin = new System.Windows.Forms.Padding(2);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Padding = new System.Windows.Forms.Padding(2);
            this.gbxLista.Size = new System.Drawing.Size(592, 129);
            this.gbxLista.TabIndex = 35;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Pacientes:";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLista.EnableHeadersVisualStyles = false;
            this.dgvLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(203)))), ((int)(((byte)(209)))));
            this.dgvLista.Location = new System.Drawing.Point(5, 21);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(203)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(203)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.dgvLista.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(582, 103);
            this.dgvLista.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.btnBuscar.Image = global::CpConsultorioOdontologico.Properties.Resources.btnCliente;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(494, 5);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 52);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(6, 37);
            this.txtParametro.Margin = new System.Windows.Forms.Padding(2);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(484, 20);
            this.txtParametro.TabIndex = 32;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // pnlDatosDes
            // 
            this.pnlDatosDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.pnlDatosDes.Controls.Add(this.gbxDatos);
            this.pnlDatosDes.Location = new System.Drawing.Point(0, 342);
            this.pnlDatosDes.Name = "pnlDatosDes";
            this.pnlDatosDes.Size = new System.Drawing.Size(776, 152);
            this.pnlDatosDes.TabIndex = 31;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.lblPersonal);
            this.gbxDatos.Controls.Add(this.cbxPersonal);
            this.gbxDatos.Controls.Add(this.dtpFechaNacimiento);
            this.gbxDatos.Controls.Add(this.txtCelular);
            this.gbxDatos.Controls.Add(this.lblCelular);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.txtAlergias);
            this.gbxDatos.Controls.Add(this.lblFechaNacimiento);
            this.gbxDatos.Controls.Add(this.lblAlergias);
            this.gbxDatos.Controls.Add(this.txtCedulaIdentidad);
            this.gbxDatos.Controls.Add(this.lblCedulaIdentidad);
            this.gbxDatos.Controls.Add(this.txtNombre);
            this.gbxDatos.Controls.Add(this.lblNombre);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.ForeColor = System.Drawing.Color.White;
            this.gbxDatos.Location = new System.Drawing.Point(2, 2);
            this.gbxDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDatos.Size = new System.Drawing.Size(774, 151);
            this.gbxDatos.TabIndex = 37;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos del Producto";
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Location = new System.Drawing.Point(439, 46);
            this.lblPersonal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(94, 15);
            this.lblPersonal.TabIndex = 35;
            this.lblPersonal.Text = "Asignar al Dr:";
            // 
            // cbxPersonal
            // 
            this.cbxPersonal.BackColor = System.Drawing.Color.Wheat;
            this.cbxPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.cbxPersonal.FormattingEnabled = true;
            this.cbxPersonal.Items.AddRange(new object[] {
            "CANCELADO",
            "PENDIENTE"});
            this.cbxPersonal.Location = new System.Drawing.Point(537, 43);
            this.cbxPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPersonal.Name = "cbxPersonal";
            this.cbxPersonal.Size = new System.Drawing.Size(214, 23);
            this.cbxPersonal.TabIndex = 34;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.dtpFechaNacimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(203)))), ((int)(((byte)(209)))));
            this.dtpFechaNacimiento.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(168)))));
            this.dtpFechaNacimiento.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.dtpFechaNacimiento.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(168)))));
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(154, 106);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaNacimiento.TabIndex = 26;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(536, 18);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(2);
            this.txtCelular.MaxLength = 100;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(215, 21);
            this.txtCelular.TabIndex = 25;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(439, 24);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(57, 15);
            this.lblCelular.TabIndex = 24;
            this.lblCelular.Text = "Celular:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.btnGuardar.Image = global::CpConsultorioOdontologico.Properties.Resources._1891021_approved_check_checkbox_checkmark_confirm_icon;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(463, 81);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 59);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtAlergias
            // 
            this.txtAlergias.Location = new System.Drawing.Point(154, 78);
            this.txtAlergias.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlergias.MaxLength = 250;
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.Size = new System.Drawing.Size(265, 21);
            this.txtAlergias.TabIndex = 21;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(7, 111);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(147, 15);
            this.lblFechaNacimiento.TabIndex = 18;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblAlergias
            // 
            this.lblAlergias.AutoSize = true;
            this.lblAlergias.Location = new System.Drawing.Point(8, 81);
            this.lblAlergias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlergias.Name = "lblAlergias";
            this.lblAlergias.Size = new System.Drawing.Size(63, 15);
            this.lblAlergias.TabIndex = 16;
            this.lblAlergias.Text = "Alergias:";
            // 
            // txtCedulaIdentidad
            // 
            this.txtCedulaIdentidad.Location = new System.Drawing.Point(154, 45);
            this.txtCedulaIdentidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedulaIdentidad.MaxLength = 15;
            this.txtCedulaIdentidad.Name = "txtCedulaIdentidad";
            this.txtCedulaIdentidad.Size = new System.Drawing.Size(265, 21);
            this.txtCedulaIdentidad.TabIndex = 15;
            // 
            // lblCedulaIdentidad
            // 
            this.lblCedulaIdentidad.AutoSize = true;
            this.lblCedulaIdentidad.Location = new System.Drawing.Point(7, 49);
            this.lblCedulaIdentidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCedulaIdentidad.Name = "lblCedulaIdentidad";
            this.lblCedulaIdentidad.Size = new System.Drawing.Size(140, 15);
            this.lblCedulaIdentidad.TabIndex = 14;
            this.lblCedulaIdentidad.Text = "Cedula de Identidad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 15);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 21);
            this.txtNombre.TabIndex = 13;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 23);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 15);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.btnCancelar.Image = global::CpConsultorioOdontologico.Properties.Resources.btnCancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(621, 81);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 57);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // erpNombre
            // 
            this.erpNombre.ContainerControl = this;
            // 
            // erpCedulaIdentidad
            // 
            this.erpCedulaIdentidad.ContainerControl = this;
            // 
            // erpAlergias
            // 
            this.erpAlergias.ContainerControl = this;
            // 
            // erpFechaNacimiento
            // 
            this.erpFechaNacimiento.ContainerControl = this;
            // 
            // erpCelular
            // 
            this.erpCelular.ContainerControl = this;
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 493);
            this.Controls.Add(this.pnlDatosDes);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPaciente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPaciente_FormClosing);
            this.Load += new System.EventHandler(this.FrmPaciente_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.pnlDatosDes.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpAlergias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFechaNacimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCelular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel pnlDatosDes;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtAlergias;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblAlergias;
        private System.Windows.Forms.TextBox txtCedulaIdentidad;
        private System.Windows.Forms.Label lblCedulaIdentidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnMedicamentos;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.ErrorProvider erpNombre;
        private System.Windows.Forms.ErrorProvider erpCedulaIdentidad;
        private System.Windows.Forms.ErrorProvider erpAlergias;
        private System.Windows.Forms.ErrorProvider erpFechaNacimiento;
        private System.Windows.Forms.ErrorProvider erpCelular;
        private System.Windows.Forms.Label lblPersonal;
        private System.Windows.Forms.ComboBox cbxPersonal;
    }
}