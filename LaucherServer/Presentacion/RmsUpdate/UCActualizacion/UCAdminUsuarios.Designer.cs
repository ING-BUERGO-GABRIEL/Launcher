namespace LauncherServer.Presentacion.RmsUpdate.UCActualizacion
{
    partial class UCAdminUsuarios
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LvlContenido = new System.Windows.Forms.Label();
            this.LvlTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabListaUser = new System.Windows.Forms.TabPage();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.GvListaUsuario = new System.Windows.Forms.DataGridView();
            this.numSec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPrivilegios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEditUser = new System.Windows.Forms.TabPage();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.gbxDatosUsuario = new System.Windows.Forms.GroupBox();
            this.lvID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbTipoPrivilegio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabListaUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvListaUsuario)).BeginInit();
            this.tabEditUser.SuspendLayout();
            this.gbxLogin.SuspendLayout();
            this.gbxDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(517, 16);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(102, 31);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(640, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 31);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelarClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.LvlContenido);
            this.panel2.Controls.Add(this.LvlTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 83);
            this.panel2.TabIndex = 6;
            // 
            // LvlContenido
            // 
            this.LvlContenido.AutoSize = true;
            this.LvlContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvlContenido.Location = new System.Drawing.Point(40, 47);
            this.LvlContenido.Name = "LvlContenido";
            this.LvlContenido.Size = new System.Drawing.Size(261, 18);
            this.LvlContenido.TabIndex = 1;
            this.LvlContenido.Text = "Seleccione el usuario que desea editar";
            // 
            // LvlTitulo
            // 
            this.LvlTitulo.AutoSize = true;
            this.LvlTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvlTitulo.Location = new System.Drawing.Point(23, 19);
            this.LvlTitulo.Name = "LvlTitulo";
            this.LvlTitulo.Size = new System.Drawing.Size(187, 20);
            this.LvlTitulo.TabIndex = 0;
            this.LvlTitulo.Text = "Administrar Usuarios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnSiguiente);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 61);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 345);
            this.panel3.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabListaUser);
            this.tabControl1.Controls.Add(this.tabEditUser);
            this.tabControl1.Location = new System.Drawing.Point(10, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(749, 333);
            this.tabControl1.TabIndex = 7;
            // 
            // tabListaUser
            // 
            this.tabListaUser.Controls.Add(this.btnEditar);
            this.tabListaUser.Controls.Add(this.btnCrear);
            this.tabListaUser.Controls.Add(this.GvListaUsuario);
            this.tabListaUser.Location = new System.Drawing.Point(4, 25);
            this.tabListaUser.Name = "tabListaUser";
            this.tabListaUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabListaUser.Size = new System.Drawing.Size(741, 304);
            this.tabListaUser.TabIndex = 0;
            this.tabListaUser.Text = "Lista de Usuarios";
            this.tabListaUser.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(618, 57);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 41);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(618, 10);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(117, 41);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // GvListaUsuario
            // 
            this.GvListaUsuario.AllowUserToAddRows = false;
            this.GvListaUsuario.AllowUserToDeleteRows = false;
            this.GvListaUsuario.AllowUserToResizeColumns = false;
            this.GvListaUsuario.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.GvListaUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.GvListaUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvListaUsuario.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.GvListaUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvListaUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GvListaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvListaUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSec,
            this.nombre,
            this.correo,
            this.tipoPrivilegios,
            this.estado});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GvListaUsuario.DefaultCellStyle = dataGridViewCellStyle8;
            this.GvListaUsuario.Location = new System.Drawing.Point(6, 6);
            this.GvListaUsuario.Name = "GvListaUsuario";
            this.GvListaUsuario.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvListaUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GvListaUsuario.RowHeadersVisible = false;
            this.GvListaUsuario.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GvListaUsuario.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.GvListaUsuario.RowTemplate.Height = 20;
            this.GvListaUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GvListaUsuario.Size = new System.Drawing.Size(599, 292);
            this.GvListaUsuario.TabIndex = 6;
            // 
            // numSec
            // 
            this.numSec.DataPropertyName = "numSec";
            this.numSec.FillWeight = 50.43856F;
            this.numSec.HeaderText = "ID";
            this.numSec.MinimumWidth = 6;
            this.numSec.Name = "numSec";
            this.numSec.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.FillWeight = 105.2905F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.FillWeight = 105.2905F;
            this.correo.HeaderText = "Correo";
            this.correo.MinimumWidth = 6;
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // tipoPrivilegios
            // 
            this.tipoPrivilegios.DataPropertyName = "tipoPrivilegios";
            this.tipoPrivilegios.FillWeight = 133.6898F;
            this.tipoPrivilegios.HeaderText = "Tipo de Privilegio";
            this.tipoPrivilegios.MinimumWidth = 6;
            this.tipoPrivilegios.Name = "tipoPrivilegios";
            this.tipoPrivilegios.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.FillWeight = 105.2905F;
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // tabEditUser
            // 
            this.tabEditUser.Controls.Add(this.btnEditarUsuario);
            this.tabEditUser.Controls.Add(this.gbxLogin);
            this.tabEditUser.Controls.Add(this.gbxDatosUsuario);
            this.tabEditUser.Controls.Add(this.btnRegistrar);
            this.tabEditUser.Location = new System.Drawing.Point(4, 25);
            this.tabEditUser.Name = "tabEditUser";
            this.tabEditUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditUser.Size = new System.Drawing.Size(741, 304);
            this.tabEditUser.TabIndex = 1;
            this.tabEditUser.Text = "Editar Usuario";
            this.tabEditUser.UseVisualStyleBackColor = true;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(137, 255);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(103, 36);
            this.btnEditarUsuario.TabIndex = 13;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.txtPassword);
            this.gbxLogin.Controls.Add(this.label6);
            this.gbxLogin.Controls.Add(this.label5);
            this.gbxLogin.Controls.Add(this.textBox4);
            this.gbxLogin.Location = new System.Drawing.Point(18, 168);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(710, 73);
            this.gbxLogin.TabIndex = 12;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "Login";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(508, 35);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 22);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Usuario:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(161, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 22);
            this.textBox4.TabIndex = 7;
            // 
            // gbxDatosUsuario
            // 
            this.gbxDatosUsuario.Controls.Add(this.lvID);
            this.gbxDatosUsuario.Controls.Add(this.textBox1);
            this.gbxDatosUsuario.Controls.Add(this.label4);
            this.gbxDatosUsuario.Controls.Add(this.label1);
            this.gbxDatosUsuario.Controls.Add(this.cbEstado);
            this.gbxDatosUsuario.Controls.Add(this.textBox2);
            this.gbxDatosUsuario.Controls.Add(this.cbTipoPrivilegio);
            this.gbxDatosUsuario.Controls.Add(this.label2);
            this.gbxDatosUsuario.Controls.Add(this.label3);
            this.gbxDatosUsuario.Controls.Add(this.textBox3);
            this.gbxDatosUsuario.Location = new System.Drawing.Point(15, 9);
            this.gbxDatosUsuario.Name = "gbxDatosUsuario";
            this.gbxDatosUsuario.Size = new System.Drawing.Size(713, 150);
            this.gbxDatosUsuario.TabIndex = 11;
            this.gbxDatosUsuario.TabStop = false;
            this.gbxDatosUsuario.Text = "Datos Usuario";
            // 
            // lvID
            // 
            this.lvID.AutoSize = true;
            this.lvID.Location = new System.Drawing.Point(36, 35);
            this.lvID.Name = "lvID";
            this.lvID.Size = new System.Drawing.Size(26, 16);
            this.lvID.TabIndex = 1;
            this.lvID.Text = "ID :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estado :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre :";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(533, 104);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 24);
            this.cbEstado.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 22);
            this.textBox2.TabIndex = 4;
            // 
            // cbTipoPrivilegio
            // 
            this.cbTipoPrivilegio.DisplayMember = "tipoPrivilegios";
            this.cbTipoPrivilegio.FormattingEnabled = true;
            this.cbTipoPrivilegio.Location = new System.Drawing.Point(533, 64);
            this.cbTipoPrivilegio.Name = "cbTipoPrivilegio";
            this.cbTipoPrivilegio.Size = new System.Drawing.Size(121, 24);
            this.cbTipoPrivilegio.TabIndex = 8;
            this.cbTipoPrivilegio.ValueMember = "codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de privilegio :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de privilegio :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(168, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 22);
            this.textBox3.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(19, 255);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(103, 36);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // UCAdminUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UCAdminUsuarios";
            this.Size = new System.Drawing.Size(771, 489);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabListaUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvListaUsuario)).EndInit();
            this.tabEditUser.ResumeLayout(false);
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.gbxDatosUsuario.ResumeLayout(false);
            this.gbxDatosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LvlContenido;
        private System.Windows.Forms.Label LvlTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnSiguiente;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.DataGridView GvListaUsuario;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabListaUser;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TabPage tabEditUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSec;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPrivilegios;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox gbxDatosUsuario;
        private System.Windows.Forms.Label lvID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbTipoPrivilegio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtPassword;
    }
}
