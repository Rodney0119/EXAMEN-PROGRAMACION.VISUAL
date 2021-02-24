
namespace FORMULARIOS
{
    partial class FRMCLIENTE
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
            this.GPBCLIENTE = new System.Windows.Forms.GroupBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtCodigoPedido = new System.Windows.Forms.TextBox();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.lblCodigoPedido = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblApMaterno = new System.Windows.Forms.Label();
            this.lblApPaterno = new System.Windows.Forms.Label();
            this.DGVClientes = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.APPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMSEGSOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIDOPEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumSegSoc = new System.Windows.Forms.TextBox();
            this.lblNumSegSoc = new System.Windows.Forms.Label();
            this.GPBCLIENTE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // GPBCLIENTE
            // 
            this.GPBCLIENTE.Controls.Add(this.lblNumSegSoc);
            this.GPBCLIENTE.Controls.Add(this.txtNumSegSoc);
            this.GPBCLIENTE.Controls.Add(this.txtNombre);
            this.GPBCLIENTE.Controls.Add(this.lblNombre);
            this.GPBCLIENTE.Controls.Add(this.txtCedula);
            this.GPBCLIENTE.Controls.Add(this.lblCedula);
            this.GPBCLIENTE.Controls.Add(this.btnGuardar);
            this.GPBCLIENTE.Controls.Add(this.cmbSexo);
            this.GPBCLIENTE.Controls.Add(this.cmbCategoria);
            this.GPBCLIENTE.Controls.Add(this.txtCodigoPedido);
            this.GPBCLIENTE.Controls.Add(this.txtApMaterno);
            this.GPBCLIENTE.Controls.Add(this.txtApPaterno);
            this.GPBCLIENTE.Controls.Add(this.lblCodigoPedido);
            this.GPBCLIENTE.Controls.Add(this.lblCategoria);
            this.GPBCLIENTE.Controls.Add(this.lblSexo);
            this.GPBCLIENTE.Controls.Add(this.lblApMaterno);
            this.GPBCLIENTE.Controls.Add(this.lblApPaterno);
            this.GPBCLIENTE.Location = new System.Drawing.Point(18, 17);
            this.GPBCLIENTE.Margin = new System.Windows.Forms.Padding(2);
            this.GPBCLIENTE.Name = "GPBCLIENTE";
            this.GPBCLIENTE.Padding = new System.Windows.Forms.Padding(2);
            this.GPBCLIENTE.Size = new System.Drawing.Size(1162, 202);
            this.GPBCLIENTE.TabIndex = 0;
            this.GPBCLIENTE.TabStop = false;
            this.GPBCLIENTE.Text = "CLIENTE";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(397, 153);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(150, 26);
            this.txtCedula.TabIndex = 14;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(393, 118);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(61, 20);
            this.lblCedula.TabIndex = 13;
            this.lblCedula.Text = "Cédula";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(206)))), ((int)(((byte)(116)))));
            this.btnGuardar.Location = new System.Drawing.Point(918, 77);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(172, 103);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cmbSexo.Location = new System.Drawing.Point(678, 67);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(110, 28);
            this.cmbSexo.TabIndex = 11;
            this.cmbSexo.Text = "FEMENINO";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "NUEVO",
            "LONGEVO"});
            this.cmbCategoria.Location = new System.Drawing.Point(19, 153);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(140, 28);
            this.cmbCategoria.TabIndex = 10;
            this.cmbCategoria.Text = "NUEVO";
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.Location = new System.Drawing.Point(197, 153);
            this.txtCodigoPedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.Size = new System.Drawing.Size(150, 26);
            this.txtCodigoPedido.TabIndex = 9;
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(197, 69);
            this.txtApMaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(142, 26);
            this.txtApMaterno.TabIndex = 6;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(18, 69);
            this.txtApPaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(139, 26);
            this.txtApPaterno.TabIndex = 5;
            // 
            // lblCodigoPedido
            // 
            this.lblCodigoPedido.AutoSize = true;
            this.lblCodigoPedido.Location = new System.Drawing.Point(193, 118);
            this.lblCodigoPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoPedido.Name = "lblCodigoPedido";
            this.lblCodigoPedido.Size = new System.Drawing.Size(140, 20);
            this.lblCodigoPedido.TabIndex = 4;
            this.lblCodigoPedido.Text = "Código de Pedido";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(15, 118);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(81, 20);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(697, 41);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 20);
            this.lblSexo.TabIndex = 1;
            this.lblSexo.Text = "Sexo";
            // 
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.Location = new System.Drawing.Point(193, 41);
            this.lblApMaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(134, 20);
            this.lblApMaterno.TabIndex = 1;
            this.lblApMaterno.Text = "Apellido Materno";
            // 
            // lblApPaterno
            // 
            this.lblApPaterno.AutoSize = true;
            this.lblApPaterno.Location = new System.Drawing.Point(15, 41);
            this.lblApPaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApPaterno.Name = "lblApPaterno";
            this.lblApPaterno.Size = new System.Drawing.Size(131, 20);
            this.lblApPaterno.TabIndex = 0;
            this.lblApPaterno.Text = "Apellido Paterno";
            // 
            // DGVClientes
            // 
            this.DGVClientes.AllowUserToAddRows = false;
            this.DGVClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(206)))), ((int)(((byte)(116)))));
            this.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APPATERNO,
            this.APMATERNO,
            this.NOMBRE,
            this.SEXO,
            this.NUMSEGSOC,
            this.CATEGORIA,
            this.CODIDOPEDIDO,
            this.CEDULA});
            this.DGVClientes.Location = new System.Drawing.Point(18, 239);
            this.DGVClientes.Margin = new System.Windows.Forms.Padding(2);
            this.DGVClientes.Name = "DGVClientes";
            this.DGVClientes.RowHeadersWidth = 51;
            this.DGVClientes.RowTemplate.Height = 24;
            this.DGVClientes.Size = new System.Drawing.Size(1222, 204);
            this.DGVClientes.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(413, 41);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 20);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombres";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(397, 69);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(198, 26);
            this.txtNombre.TabIndex = 16;
            // 
            // APPATERNO
            // 
            this.APPATERNO.HeaderText = "APELLIDO PATERNO";
            this.APPATERNO.MinimumWidth = 6;
            this.APPATERNO.Name = "APPATERNO";
            this.APPATERNO.Width = 200;
            // 
            // APMATERNO
            // 
            this.APMATERNO.HeaderText = "APELLIDO MATERNO";
            this.APMATERNO.MinimumWidth = 6;
            this.APMATERNO.Name = "APMATERNO";
            this.APMATERNO.Width = 200;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.MinimumWidth = 6;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Width = 125;
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.MinimumWidth = 6;
            this.SEXO.Name = "SEXO";
            this.SEXO.Width = 125;
            // 
            // NUMSEGSOC
            // 
            this.NUMSEGSOC.HeaderText = "NÚMERO DE SEGURIDAD SOCIAL";
            this.NUMSEGSOC.MinimumWidth = 6;
            this.NUMSEGSOC.Name = "NUMSEGSOC";
            this.NUMSEGSOC.Width = 125;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.HeaderText = "CATEGORÍA";
            this.CATEGORIA.MinimumWidth = 6;
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.Width = 170;
            // 
            // CODIDOPEDIDO
            // 
            this.CODIDOPEDIDO.HeaderText = "CÓDIGO DEL PEDIDO";
            this.CODIDOPEDIDO.MinimumWidth = 6;
            this.CODIDOPEDIDO.Name = "CODIDOPEDIDO";
            this.CODIDOPEDIDO.Width = 220;
            // 
            // CEDULA
            // 
            this.CEDULA.HeaderText = "CÉDULA";
            this.CEDULA.MinimumWidth = 6;
            this.CEDULA.Name = "CEDULA";
            this.CEDULA.Width = 125;
            // 
            // txtNumSegSoc
            // 
            this.txtNumSegSoc.Location = new System.Drawing.Point(590, 155);
            this.txtNumSegSoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumSegSoc.Name = "txtNumSegSoc";
            this.txtNumSegSoc.Size = new System.Drawing.Size(198, 26);
            this.txtNumSegSoc.TabIndex = 17;
            // 
            // lblNumSegSoc
            // 
            this.lblNumSegSoc.AutoSize = true;
            this.lblNumSegSoc.Location = new System.Drawing.Point(586, 118);
            this.lblNumSegSoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumSegSoc.Name = "lblNumSegSoc";
            this.lblNumSegSoc.Size = new System.Drawing.Size(199, 20);
            this.lblNumSegSoc.TabIndex = 18;
            this.lblNumSegSoc.Text = "Número Seguridad Social";
            // 
            // FRMCLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1511, 808);
            this.Controls.Add(this.DGVClientes);
            this.Controls.Add(this.GPBCLIENTE);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMCLIENTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GPBCLIENTE.ResumeLayout(false);
            this.GPBCLIENTE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GPBCLIENTE;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtCodigoPedido;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.Label lblCodigoPedido;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblApMaterno;
        private System.Windows.Forms.Label lblApPaterno;
        private System.Windows.Forms.DataGridView DGVClientes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMSEGSOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIDOPEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
        private System.Windows.Forms.Label lblNumSegSoc;
        private System.Windows.Forms.TextBox txtNumSegSoc;
    }
}