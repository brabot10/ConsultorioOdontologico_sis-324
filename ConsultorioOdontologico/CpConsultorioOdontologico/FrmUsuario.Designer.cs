namespace CpConsultorioOdontologico
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.cbxPersonal = new System.Windows.Forms.ComboBox();
            this.erpUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlMovimiento = new System.Windows.Forms.Panel();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.erpClave = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).BeginInit();
            this.pnlMovimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpClave)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxLista
            // 
            this.gbxLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.gbxLista.Location = new System.Drawing.Point(3, 106);
            this.gbxLista.Margin = new System.Windows.Forms.Padding(2);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Padding = new System.Windows.Forms.Padding(2);
            this.gbxLista.Size = new System.Drawing.Size(372, 161);
            this.gbxLista.TabIndex = 36;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Usuarios";
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
            this.dgvLista.Location = new System.Drawing.Point(17, 20);
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
            this.dgvLista.Size = new System.Drawing.Size(334, 123);
            this.dgvLista.TabIndex = 0;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.txtUsuario.Location = new System.Drawing.Point(110, 279);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(253, 21);
            this.txtUsuario.TabIndex = 40;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(4, 283);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 16);
            this.lblUsuario.TabIndex = 39;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonal.ForeColor = System.Drawing.Color.White;
            this.lblPersonal.Location = new System.Drawing.Point(4, 334);
            this.lblPersonal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(101, 16);
            this.lblPersonal.TabIndex = 42;
            this.lblPersonal.Text = "Asignar al Dr:";
            // 
            // cbxPersonal
            // 
            this.cbxPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.cbxPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.cbxPersonal.FormattingEnabled = true;
            this.cbxPersonal.Items.AddRange(new object[] {
            "CANCELADO",
            "PENDIENTE"});
            this.cbxPersonal.Location = new System.Drawing.Point(109, 334);
            this.cbxPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPersonal.Name = "cbxPersonal";
            this.cbxPersonal.Size = new System.Drawing.Size(254, 21);
            this.cbxPersonal.TabIndex = 41;
            // 
            // erpUsuario
            // 
            this.erpUsuario.ContainerControl = this;
            // 
            // pnlMovimiento
            // 
            this.pnlMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.pnlMovimiento.Controls.Add(this.btnEliminar);
            this.pnlMovimiento.Controls.Add(this.txtClave);
            this.pnlMovimiento.Controls.Add(this.btnGuardar);
            this.pnlMovimiento.Controls.Add(this.lblClave);
            this.pnlMovimiento.Controls.Add(this.btnBuscar);
            this.pnlMovimiento.Controls.Add(this.lblPersonal);
            this.pnlMovimiento.Controls.Add(this.txtParametro);
            this.pnlMovimiento.Controls.Add(this.cbxPersonal);
            this.pnlMovimiento.Controls.Add(this.lblBusqueda);
            this.pnlMovimiento.Controls.Add(this.txtUsuario);
            this.pnlMovimiento.Controls.Add(this.lblUsuario);
            this.pnlMovimiento.Controls.Add(this.btnCancelar);
            this.pnlMovimiento.Controls.Add(this.gbxLista);
            this.pnlMovimiento.Location = new System.Drawing.Point(12, 12);
            this.pnlMovimiento.Name = "pnlMovimiento";
            this.pnlMovimiento.Size = new System.Drawing.Size(381, 430);
            this.pnlMovimiento.TabIndex = 43;
            this.pnlMovimiento.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMovimiento_MouseMove);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.txtClave.Location = new System.Drawing.Point(110, 305);
            this.txtClave.Margin = new System.Windows.Forms.Padding(2);
            this.txtClave.MaxLength = 20;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(253, 21);
            this.txtClave.TabIndex = 44;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.White;
            this.lblClave.Location = new System.Drawing.Point(4, 309);
            this.lblClave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(51, 16);
            this.lblClave.TabIndex = 43;
            this.lblClave.Text = "Clave:";
            // 
            // txtParametro
            // 
            this.txtParametro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txtParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.txtParametro.Location = new System.Drawing.Point(20, 51);
            this.txtParametro.Margin = new System.Windows.Forms.Padding(2);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(197, 21);
            this.txtParametro.TabIndex = 35;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.White;
            this.lblBusqueda.Location = new System.Drawing.Point(16, 25);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(197, 16);
            this.lblBusqueda.TabIndex = 34;
            this.lblBusqueda.Text = "Buscar usuario por nombre:";
            // 
            // erpClave
            // 
            this.erpClave.ContainerControl = this;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::CpConsultorioOdontologico.Properties.Resources.user_eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(254, 359);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 57);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::CpConsultorioOdontologico.Properties.Resources.user_guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(18, 359);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 59);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::CpConsultorioOdontologico.Properties.Resources.user_buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(254, 25);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 52);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::CpConsultorioOdontologico.Properties.Resources.user_cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(137, 359);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 57);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(405, 454);
            this.Controls.Add(this.pnlMovimiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).EndInit();
            this.pnlMovimiento.ResumeLayout(false);
            this.pnlMovimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpClave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPersonal;
        private System.Windows.Forms.ComboBox cbxPersonal;
        private System.Windows.Forms.ErrorProvider erpUsuario;
        private System.Windows.Forms.Panel pnlMovimiento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.ErrorProvider erpClave;
        private System.Windows.Forms.Button btnEliminar;
    }
}