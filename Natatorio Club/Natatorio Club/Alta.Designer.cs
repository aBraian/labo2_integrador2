namespace Natatorio_Club
{
    partial class FrmAlta
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlta));
            tlpMenu = new TableLayoutPanel();
            tlpControles = new TableLayoutPanel();
            tlpSalir = new TableLayoutPanel();
            btnVolver = new Button();
            btnAceptar = new Button();
            tlpContenedor = new TableLayoutPanel();
            btnCerrar = new Button();
            tlpDivisorDatos = new TableLayoutPanel();
            tlpDeporte = new TableLayoutPanel();
            lblTurno = new Label();
            lblNivel = new Label();
            cmbTurno = new ComboBox();
            cmbNivel = new ComboBox();
            tlpDatosPersonales = new TableLayoutPanel();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblTelefono = new Label();
            lblNacimiento = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtTelefono = new TextBox();
            dtpNacimiento = new DateTimePicker();
            epAlta = new ErrorProvider(components);
            tlpMenu.SuspendLayout();
            tlpControles.SuspendLayout();
            tlpSalir.SuspendLayout();
            tlpContenedor.SuspendLayout();
            tlpDivisorDatos.SuspendLayout();
            tlpDeporte.SuspendLayout();
            tlpDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epAlta).BeginInit();
            SuspendLayout();
            // 
            // tlpMenu
            // 
            tlpMenu.BackColor = Color.FromArgb(26, 26, 39);
            tlpMenu.ColumnCount = 2;
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpMenu.Controls.Add(tlpControles, 0, 0);
            tlpMenu.Controls.Add(tlpContenedor, 1, 0);
            tlpMenu.Dock = DockStyle.Fill;
            tlpMenu.Location = new Point(0, 0);
            tlpMenu.Name = "tlpMenu";
            tlpMenu.RowCount = 1;
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMenu.Size = new Size(1280, 720);
            tlpMenu.TabIndex = 1;
            // 
            // tlpControles
            // 
            tlpControles.ColumnCount = 1;
            tlpControles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpControles.Controls.Add(tlpSalir, 0, 1);
            tlpControles.Dock = DockStyle.Fill;
            tlpControles.Location = new Point(3, 3);
            tlpControles.Name = "tlpControles";
            tlpControles.RowCount = 2;
            tlpControles.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tlpControles.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpControles.Size = new Size(250, 714);
            tlpControles.TabIndex = 2;
            // 
            // tlpSalir
            // 
            tlpSalir.ColumnCount = 2;
            tlpSalir.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSalir.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSalir.Controls.Add(btnVolver, 1, 0);
            tlpSalir.Controls.Add(btnAceptar, 0, 0);
            tlpSalir.Location = new Point(3, 645);
            tlpSalir.Name = "tlpSalir";
            tlpSalir.RowCount = 1;
            tlpSalir.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSalir.Size = new Size(244, 66);
            tlpSalir.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Dock = DockStyle.Fill;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(125, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 60);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Dock = DockStyle.Fill;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(3, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(116, 60);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // tlpContenedor
            // 
            tlpContenedor.BackColor = Color.FromArgb(43, 46, 74);
            tlpContenedor.ColumnCount = 1;
            tlpContenedor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContenedor.Controls.Add(btnCerrar, 0, 0);
            tlpContenedor.Controls.Add(tlpDivisorDatos, 0, 1);
            tlpContenedor.Dock = DockStyle.Fill;
            tlpContenedor.Location = new Point(259, 3);
            tlpContenedor.Name = "tlpContenedor";
            tlpContenedor.RowCount = 2;
            tlpContenedor.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlpContenedor.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            tlpContenedor.Size = new Size(1018, 714);
            tlpContenedor.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(991, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 18);
            btnCerrar.TabIndex = 3;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // tlpDivisorDatos
            // 
            tlpDivisorDatos.ColumnCount = 2;
            tlpDivisorDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDivisorDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDivisorDatos.Controls.Add(tlpDeporte, 1, 0);
            tlpDivisorDatos.Controls.Add(tlpDatosPersonales, 0, 0);
            tlpDivisorDatos.Dock = DockStyle.Fill;
            tlpDivisorDatos.Location = new Point(3, 38);
            tlpDivisorDatos.Name = "tlpDivisorDatos";
            tlpDivisorDatos.RowCount = 1;
            tlpDivisorDatos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDivisorDatos.Size = new Size(1012, 673);
            tlpDivisorDatos.TabIndex = 4;
            // 
            // tlpDeporte
            // 
            tlpDeporte.ColumnCount = 2;
            tlpDeporte.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpDeporte.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpDeporte.Controls.Add(lblTurno, 0, 2);
            tlpDeporte.Controls.Add(lblNivel, 0, 3);
            tlpDeporte.Controls.Add(cmbTurno, 1, 2);
            tlpDeporte.Controls.Add(cmbNivel, 1, 3);
            tlpDeporte.Dock = DockStyle.Fill;
            tlpDeporte.Location = new Point(509, 3);
            tlpDeporte.Name = "tlpDeporte";
            tlpDeporte.RowCount = 10;
            tlpDeporte.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDeporte.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDeporte.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDeporte.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDeporte.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDeporte.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDeporte.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDeporte.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDeporte.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDeporte.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDeporte.Size = new Size(500, 667);
            tlpDeporte.TabIndex = 1;
            // 
            // lblTurno
            // 
            lblTurno.Anchor = AnchorStyles.None;
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTurno.Location = new Point(45, 177);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(59, 21);
            lblTurno.TabIndex = 5;
            lblTurno.Text = "Turno:";
            // 
            // lblNivel
            // 
            lblNivel.Anchor = AnchorStyles.None;
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNivel.Location = new Point(47, 252);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(56, 21);
            lblNivel.TabIndex = 6;
            lblNivel.Text = "Nivel:";
            // 
            // cmbTurno
            // 
            cmbTurno.Anchor = AnchorStyles.None;
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.FlatStyle = FlatStyle.Flat;
            cmbTurno.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Location = new Point(203, 173);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(244, 29);
            cmbTurno.TabIndex = 7;
            // 
            // cmbNivel
            // 
            cmbNivel.Anchor = AnchorStyles.None;
            cmbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivel.FlatStyle = FlatStyle.Flat;
            cmbNivel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(203, 248);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(244, 29);
            cmbNivel.TabIndex = 8;
            // 
            // tlpDatosPersonales
            // 
            tlpDatosPersonales.ColumnCount = 2;
            tlpDatosPersonales.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpDatosPersonales.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpDatosPersonales.Controls.Add(lblNombre, 0, 2);
            tlpDatosPersonales.Controls.Add(lblApellido, 0, 3);
            tlpDatosPersonales.Controls.Add(lblDni, 0, 4);
            tlpDatosPersonales.Controls.Add(lblTelefono, 0, 5);
            tlpDatosPersonales.Controls.Add(lblNacimiento, 0, 6);
            tlpDatosPersonales.Controls.Add(txtNombre, 1, 2);
            tlpDatosPersonales.Controls.Add(txtApellido, 1, 3);
            tlpDatosPersonales.Controls.Add(txtDni, 1, 4);
            tlpDatosPersonales.Controls.Add(txtTelefono, 1, 5);
            tlpDatosPersonales.Controls.Add(dtpNacimiento, 1, 6);
            tlpDatosPersonales.Dock = DockStyle.Fill;
            tlpDatosPersonales.Location = new Point(3, 3);
            tlpDatosPersonales.Name = "tlpDatosPersonales";
            tlpDatosPersonales.RowCount = 10;
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpDatosPersonales.Size = new Size(500, 667);
            tlpDatosPersonales.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(34, 177);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(33, 252);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(83, 21);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.None;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(52, 327);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(46, 21);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI:";
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.None;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.Location = new Point(32, 402);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(85, 21);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono:";
            // 
            // lblNacimiento
            // 
            lblNacimiento.Anchor = AnchorStyles.None;
            lblNacimiento.AutoSize = true;
            lblNacimiento.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNacimiento.Location = new Point(19, 466);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new Size(111, 42);
            lblNacimiento.TabIndex = 4;
            lblNacimiento.Text = "Fecha de Nacimiento:";
            lblNacimiento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(203, 177);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingresar nombre";
            txtNombre.Size = new Size(244, 21);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(203, 252);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingresar apellido";
            txtApellido.Size = new Size(244, 21);
            txtApellido.TabIndex = 6;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
            txtDni.BorderStyle = BorderStyle.None;
            txtDni.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(203, 327);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingresar DNI";
            txtDni.Size = new Size(244, 21);
            txtDni.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(203, 402);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingresar telefono";
            txtTelefono.Size = new Size(244, 21);
            txtTelefono.TabIndex = 8;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Anchor = AnchorStyles.None;
            dtpNacimiento.CustomFormat = "dd / MMM / yyyy";
            dtpNacimiento.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNacimiento.Format = DateTimePickerFormat.Custom;
            dtpNacimiento.Location = new Point(203, 473);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(244, 28);
            dtpNacimiento.TabIndex = 9;
            // 
            // epAlta
            // 
            epAlta.ContainerControl = this;
            epAlta.Icon = (Icon)resources.GetObject("epAlta.Icon");
            // 
            // FrmAlta
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 46, 74);
            ClientSize = new Size(1280, 720);
            Controls.Add(tlpMenu);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmAlta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Natatorio Club";
            Load += Frm_alta_Load;
            tlpMenu.ResumeLayout(false);
            tlpControles.ResumeLayout(false);
            tlpSalir.ResumeLayout(false);
            tlpContenedor.ResumeLayout(false);
            tlpDivisorDatos.ResumeLayout(false);
            tlpDeporte.ResumeLayout(false);
            tlpDeporte.PerformLayout();
            tlpDatosPersonales.ResumeLayout(false);
            tlpDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epAlta).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tlpMenu;
        private TableLayoutPanel tlpContenedor;
        private TableLayoutPanel tlpControles;
        private TableLayoutPanel tlpSalir;
        private Button btnAceptar;
        private Button btnVolver;
        private Button btnCerrar;
        private TableLayoutPanel tlpDivisorDatos;
        private TableLayoutPanel tlpDatosPersonales;
        private TableLayoutPanel tlpDeporte;
        private Label lblTurno;
        private Label lblNivel;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblTelefono;
        private Label lblNacimiento;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtTelefono;
        private DateTimePicker dtpNacimiento;
        private ComboBox cmbTurno;
        private ComboBox cmbNivel;
        private ErrorProvider epAlta;
    }
}