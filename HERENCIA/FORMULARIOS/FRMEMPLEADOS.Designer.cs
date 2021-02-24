
namespace FORMULARIOS
{
    partial class FRMEMPLEADOS
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
            this.GboEmpleados = new System.Windows.Forms.GroupBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboTipoContrato = new System.Windows.Forms.ComboBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.lblApMaterno = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.lblApPaterno = new System.Windows.Forms.Label();
            this.DGVEMPLEADOS = new System.Windows.Forms.DataGridView();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.APPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOCONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUELDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GboEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADOS)).BeginInit();
            this.SuspendLayout();
            // 
            // GboEmpleados
            // 
            this.GboEmpleados.Controls.Add(this.cmbTipo);
            this.GboEmpleados.Controls.Add(this.txtNombres);
            this.GboEmpleados.Controls.Add(this.lblNombres);
            this.GboEmpleados.Controls.Add(this.lblTipo);
            this.GboEmpleados.Controls.Add(this.txtCedula);
            this.GboEmpleados.Controls.Add(this.lblCedula);
            this.GboEmpleados.Controls.Add(this.btnGuardar);
            this.GboEmpleados.Controls.Add(this.cboTipoContrato);
            this.GboEmpleados.Controls.Add(this.cboSexo);
            this.GboEmpleados.Controls.Add(this.txtApMaterno);
            this.GboEmpleados.Controls.Add(this.txtApPaterno);
            this.GboEmpleados.Controls.Add(this.lblApMaterno);
            this.GboEmpleados.Controls.Add(this.lblSexo);
            this.GboEmpleados.Controls.Add(this.lblTipoContrato);
            this.GboEmpleados.Controls.Add(this.lblApPaterno);
            this.GboEmpleados.Location = new System.Drawing.Point(24, 15);
            this.GboEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.GboEmpleados.Name = "GboEmpleados";
            this.GboEmpleados.Padding = new System.Windows.Forms.Padding(4);
            this.GboEmpleados.Size = new System.Drawing.Size(1204, 310);
            this.GboEmpleados.TabIndex = 0;
            this.GboEmpleados.TabStop = false;
            this.GboEmpleados.Text = "Empleados";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(553, 243);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(228, 26);
            this.txtCedula.TabIndex = 17;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(549, 189);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(61, 20);
            this.lblCedula.TabIndex = 16;
            this.lblCedula.Text = "Cédula";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(208)))));
            this.btnGuardar.Location = new System.Drawing.Point(962, 142);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(226, 148);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboTipoContrato
            // 
            this.cboTipoContrato.FormattingEnabled = true;
            this.cboTipoContrato.Items.AddRange(new object[] {
            "NUEVO",
            "LONGEVO"});
            this.cboTipoContrato.Location = new System.Drawing.Point(42, 241);
            this.cboTipoContrato.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoContrato.Name = "cboTipoContrato";
            this.cboTipoContrato.Size = new System.Drawing.Size(150, 28);
            this.cboTipoContrato.TabIndex = 14;
            this.cboTipoContrato.Text = "NUEVO";
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cboSexo.Location = new System.Drawing.Point(902, 90);
            this.cboSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(150, 28);
            this.cboSexo.TabIndex = 12;
            this.cboSexo.Text = "FEMENINO";
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(320, 92);
            this.txtApMaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(228, 26);
            this.txtApMaterno.TabIndex = 9;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(48, 92);
            this.txtApPaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(223, 26);
            this.txtApPaterno.TabIndex = 8;
            // 
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.Location = new System.Drawing.Point(348, 42);
            this.lblApMaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(134, 20);
            this.lblApMaterno.TabIndex = 7;
            this.lblApMaterno.Text = "Apellido Materno";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(920, 42);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 20);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo";
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Location = new System.Drawing.Point(38, 189);
            this.lblTipoContrato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(133, 20);
            this.lblTipoContrato.TabIndex = 2;
            this.lblTipoContrato.Text = "Tipo de Contrato";
            // 
            // lblApPaterno
            // 
            this.lblApPaterno.AutoSize = true;
            this.lblApPaterno.Location = new System.Drawing.Point(61, 42);
            this.lblApPaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApPaterno.Name = "lblApPaterno";
            this.lblApPaterno.Size = new System.Drawing.Size(131, 20);
            this.lblApPaterno.TabIndex = 0;
            this.lblApPaterno.Text = "Apellido Paterno";
            // 
            // DGVEMPLEADOS
            // 
            this.DGVEMPLEADOS.AllowUserToAddRows = false;
            this.DGVEMPLEADOS.AllowUserToOrderColumns = true;
            this.DGVEMPLEADOS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(208)))));
            this.DGVEMPLEADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEMPLEADOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APPATERNO,
            this.APMATERNO,
            this.NOMBRES,
            this.SEXO,
            this.TIPO,
            this.TIPOCONTRATO,
            this.SUELDO,
            this.CEDULA});
            this.DGVEMPLEADOS.Location = new System.Drawing.Point(24, 386);
            this.DGVEMPLEADOS.Margin = new System.Windows.Forms.Padding(4);
            this.DGVEMPLEADOS.Name = "DGVEMPLEADOS";
            this.DGVEMPLEADOS.RowHeadersWidth = 51;
            this.DGVEMPLEADOS.RowTemplate.Height = 24;
            this.DGVEMPLEADOS.Size = new System.Drawing.Size(1223, 204);
            this.DGVEMPLEADOS.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(290, 189);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(41, 20);
            this.lblTipo.TabIndex = 18;
            this.lblTipo.Text = "Tipo";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(592, 42);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(77, 20);
            this.lblNombres.TabIndex = 19;
            this.lblNombres.Text = "Nombres";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(576, 92);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(228, 26);
            this.txtNombres.TabIndex = 20;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "NUEVO",
            "LONGEVO"});
            this.cmbTipo.Location = new System.Drawing.Point(262, 241);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(150, 28);
            this.cmbTipo.TabIndex = 21;
            this.cmbTipo.Text = "NUEVO";
            // 
            // APPATERNO
            // 
            this.APPATERNO.HeaderText = "APELLIDO PATERNO";
            this.APPATERNO.MinimumWidth = 6;
            this.APPATERNO.Name = "APPATERNO";
            this.APPATERNO.Width = 220;
            // 
            // APMATERNO
            // 
            this.APMATERNO.HeaderText = "APELLIDO MATERNO";
            this.APMATERNO.MinimumWidth = 6;
            this.APMATERNO.Name = "APMATERNO";
            this.APMATERNO.Width = 220;
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.MinimumWidth = 6;
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.Width = 125;
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.MinimumWidth = 6;
            this.SEXO.Name = "SEXO";
            this.SEXO.Width = 125;
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.MinimumWidth = 6;
            this.TIPO.Name = "TIPO";
            this.TIPO.Width = 125;
            // 
            // TIPOCONTRATO
            // 
            this.TIPOCONTRATO.HeaderText = "TIPO DE CONTRATO";
            this.TIPOCONTRATO.MinimumWidth = 6;
            this.TIPOCONTRATO.Name = "TIPOCONTRATO";
            this.TIPOCONTRATO.Width = 175;
            // 
            // SUELDO
            // 
            this.SUELDO.HeaderText = "SUELDO";
            this.SUELDO.MinimumWidth = 6;
            this.SUELDO.Name = "SUELDO";
            this.SUELDO.Width = 125;
            // 
            // CEDULA
            // 
            this.CEDULA.HeaderText = "CÉDULA";
            this.CEDULA.MinimumWidth = 6;
            this.CEDULA.Name = "CEDULA";
            this.CEDULA.Width = 125;
            // 
            // FRMEMPLEADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1511, 808);
            this.Controls.Add(this.DGVEMPLEADOS);
            this.Controls.Add(this.GboEmpleados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMEMPLEADOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMEMPLEADOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GboEmpleados.ResumeLayout(false);
            this.GboEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GboEmpleados;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboTipoContrato;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.Label lblApMaterno;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.Label lblApPaterno;
        private System.Windows.Forms.DataGridView DGVEMPLEADOS;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOCONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUELDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
    }
}