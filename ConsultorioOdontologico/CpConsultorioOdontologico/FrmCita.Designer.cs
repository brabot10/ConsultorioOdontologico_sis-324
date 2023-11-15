namespace CpConsultorioOdontologico
{
    partial class FrmCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCita));
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
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.pnlDatosDes = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.cbxPaciente = new System.Windows.Forms.ComboBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.cbxPago = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtAcuenta = new System.Windows.Forms.TextBox();
            this.lblAcuenta = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnMedicamentos = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.erpFecha = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTratamiento = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpPago = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpAcuenta = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpHora = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlDatos.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.pnlDatosDes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTratamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpAcuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHora)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.pnlDatos.Controls.Add(this.pnlAcciones);
            this.pnlDatos.Controls.Add(this.gbxLista);
            this.pnlDatos.Controls.Add(this.btnBuscar);
            this.pnlDatos.Controls.Add(this.txtParametro);
            this.pnlDatos.Controls.Add(this.lblBusqueda);
            this.pnlDatos.Location = new System.Drawing.Point(207, 87);
            this.pnlDatos.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(828, 334);
            this.pnlDatos.TabIndex = 40;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Location = new System.Drawing.Point(17, 239);
            this.pnlAcciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(789, 89);
            this.pnlAcciones.TabIndex = 36;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btnEditar.Image = global::CpConsultorioOdontologico.Properties.Resources.EditarCitas;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(219, 6);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(184, 73);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Re Consulta";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btnEliminar.Image = global::CpConsultorioOdontologico.Properties.Resources.EliminarCitas;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(423, 6);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 73);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btnNuevo.Image = global::CpConsultorioOdontologico.Properties.Resources.NuevoCitas;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(53, 6);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(148, 73);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Consulta";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btnCerrar.Image = global::CpConsultorioOdontologico.Properties.Resources.CerrarCitas;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(605, 6);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(148, 73);
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
            this.gbxLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.gbxLista.Location = new System.Drawing.Point(13, 75);
            this.gbxLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxLista.Size = new System.Drawing.Size(789, 159);
            this.gbxLista.TabIndex = 35;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Citas:";
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLista.EnableHeadersVisualStyles = false;
            this.dgvLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(203)))), ((int)(((byte)(209)))));
            this.dgvLista.Location = new System.Drawing.Point(7, 26);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgvLista.Size = new System.Drawing.Size(776, 127);
            this.dgvLista.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btnBuscar.Image = global::CpConsultorioOdontologico.Properties.Resources.BuscarCitas;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(659, 6);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(148, 64);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtParametro
            // 
            this.txtParametro.BackColor = System.Drawing.Color.White;
            this.txtParametro.Location = new System.Drawing.Point(8, 46);
            this.txtParametro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(644, 22);
            this.txtParametro.TabIndex = 32;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.lblBusqueda.Location = new System.Drawing.Point(9, 14);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(197, 20);
            this.lblBusqueda.TabIndex = 31;
            this.lblBusqueda.Text = "Buscar cita por fecha:";
            // 
            // pnlDatosDes
            // 
            this.pnlDatosDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.pnlDatosDes.Controls.Add(this.groupBox1);
            this.pnlDatosDes.Location = new System.Drawing.Point(0, 421);
            this.pnlDatosDes.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDatosDes.Name = "pnlDatosDes";
            this.pnlDatosDes.Size = new System.Drawing.Size(1035, 187);
            this.pnlDatosDes.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.groupBox1.Controls.Add(this.lblPaciente);
            this.groupBox1.Controls.Add(this.cbxPaciente);
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.cbxPago);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txtAcuenta);
            this.groupBox1.Controls.Add(this.lblAcuenta);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtTratamiento);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.lblTratamiento);
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.lblPago);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1032, 186);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Cita:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(577, 54);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(133, 18);
            this.lblPaciente.TabIndex = 33;
            this.lblPaciente.Text = "Asignar la cita a:";
            // 
            // cbxPaciente
            // 
            this.cbxPaciente.BackColor = System.Drawing.Color.Wheat;
            this.cbxPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.cbxPaciente.FormattingEnabled = true;
            this.cbxPaciente.Location = new System.Drawing.Point(735, 50);
            this.cbxPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPaciente.Name = "cbxPaciente";
            this.cbxPaciente.Size = new System.Drawing.Size(252, 26);
            this.cbxPaciente.TabIndex = 32;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(735, 18);
            this.txtHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHora.MaxLength = 250;
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(252, 24);
            this.txtHora.TabIndex = 29;
            // 
            // cbxPago
            // 
            this.cbxPago.BackColor = System.Drawing.Color.Wheat;
            this.cbxPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.cbxPago.FormattingEnabled = true;
            this.cbxPago.Items.AddRange(new object[] {
            "CANCELADO",
            "PENDIENTE"});
            this.cbxPago.Location = new System.Drawing.Point(204, 96);
            this.cbxPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPago.Name = "cbxPago";
            this.cbxPago.Size = new System.Drawing.Size(352, 26);
            this.cbxPago.TabIndex = 27;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(203)))), ((int)(((byte)(209)))));
            this.dtpFecha.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(168)))));
            this.dtpFecha.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.dtpFecha.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(168)))));
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(204, 18);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(352, 26);
            this.dtpFecha.TabIndex = 26;
            // 
            // txtAcuenta
            // 
            this.txtAcuenta.Location = new System.Drawing.Point(204, 134);
            this.txtAcuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAcuenta.MaxLength = 100;
            this.txtAcuenta.Name = "txtAcuenta";
            this.txtAcuenta.Size = new System.Drawing.Size(351, 24);
            this.txtAcuenta.TabIndex = 25;
            // 
            // lblAcuenta
            // 
            this.lblAcuenta.AutoSize = true;
            this.lblAcuenta.Location = new System.Drawing.Point(11, 134);
            this.lblAcuenta.Name = "lblAcuenta";
            this.lblAcuenta.Size = new System.Drawing.Size(78, 18);
            this.lblAcuenta.TabIndex = 24;
            this.lblAcuenta.Text = "A cuenta:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btnGuardar.Image = global::CpConsultorioOdontologico.Properties.Resources.GuardarCitas;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(617, 84);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(176, 73);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Location = new System.Drawing.Point(204, 58);
            this.txtTratamiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTratamiento.MaxLength = 250;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(352, 24);
            this.txtTratamiento.TabIndex = 21;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(11, 28);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(135, 18);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "Fecha de la Cita:";
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Location = new System.Drawing.Point(11, 62);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(103, 18);
            this.lblTratamiento.TabIndex = 16;
            this.lblTratamiento.Text = "Tratamiento:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(577, 25);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(126, 18);
            this.lblHora.TabIndex = 14;
            this.lblHora.Text = "Hora de la Cita:";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(11, 98);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(137, 18);
            this.lblPago.TabIndex = 8;
            this.lblPago.Text = "Estado del Pago:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btnCancelar.Image = global::CpConsultorioOdontologico.Properties.Resources.CalcelarCitas;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(828, 86);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(173, 70);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(207, -1);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(828, 89);
            this.pnlTitulo.TabIndex = 39;
            this.pnlTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseMove);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(19, 25);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(788, 39);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Consultorio Odontologico :::Citas::";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.pnlMenu.Controls.Add(this.btnPersonal);
            this.pnlMenu.Controls.Add(this.btnMedicamentos);
            this.pnlMenu.Controls.Add(this.btnCitas);
            this.pnlMenu.Controls.Add(this.btnPaciente);
            this.pnlMenu.Controls.Add(this.pbxLogo);
            this.pnlMenu.Location = new System.Drawing.Point(-1, -1);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(209, 422);
            this.pnlMenu.TabIndex = 38;
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(168)))));
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.btnPersonal.Image = global::CpConsultorioOdontologico.Properties.Resources.personal;
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.Location = new System.Drawing.Point(0, 338);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(207, 73);
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
            this.btnMedicamentos.Location = new System.Drawing.Point(0, 261);
            this.btnMedicamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMedicamentos.Name = "btnMedicamentos";
            this.btnMedicamentos.Size = new System.Drawing.Size(207, 73);
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
            this.btnCitas.Location = new System.Drawing.Point(0, 185);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(207, 73);
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
            this.btnPaciente.Location = new System.Drawing.Point(0, 108);
            this.btnPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(207, 73);
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
            this.pbxLogo.Location = new System.Drawing.Point(56, 4);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(97, 114);
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // erpFecha
            // 
            this.erpFecha.ContainerControl = this;
            // 
            // erpTratamiento
            // 
            this.erpTratamiento.ContainerControl = this;
            // 
            // erpPago
            // 
            this.erpPago.ContainerControl = this;
            // 
            // erpAcuenta
            // 
            this.erpAcuenta.ContainerControl = this;
            // 
            // erpHora
            // 
            this.erpHora.ContainerControl = this;
            // 
            // FrmCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 607);
            this.Controls.Add(this.pnlDatosDes);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCita";
            this.Load += new System.EventHandler(this.FrmCita_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.pnlDatosDes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTratamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpAcuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Panel pnlDatosDes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtAcuenta;
        private System.Windows.Forms.Label lblAcuenta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMedicamentos;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.ErrorProvider erpFecha;
        private System.Windows.Forms.ErrorProvider erpTratamiento;
        private System.Windows.Forms.ErrorProvider erpPago;
        private System.Windows.Forms.ErrorProvider erpAcuenta;
        private System.Windows.Forms.ErrorProvider erpHora;
        private System.Windows.Forms.ComboBox cbxPago;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.ComboBox cbxPaciente;
    }
}