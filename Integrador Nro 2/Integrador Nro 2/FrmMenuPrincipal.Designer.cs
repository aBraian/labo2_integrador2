﻿namespace Integrador_Nro_2
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            tlpMenuPrincipal = new TableLayoutPanel();
            flpContenedorBotones = new FlowLayoutPanel();
            tlpDarAlta = new TableLayoutPanel();
            pbDarAlta = new PictureBox();
            btnDarAlta = new Button();
            tlbDarBaja = new TableLayoutPanel();
            pbDarBaja = new PictureBox();
            btnDarBaja = new Button();
            tlpModificar = new TableLayoutPanel();
            pbModificar = new PictureBox();
            btnModificar = new Button();
            flpAlta = new FlowLayoutPanel();
            tlpAlta1 = new TableLayoutPanel();
            tlpFechaNacimiento = new TableLayoutPanel();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            tlpTurno = new TableLayoutPanel();
            lblTurno = new Label();
            cmbTurno = new ComboBox();
            tlpCelular = new TableLayoutPanel();
            lblCelular = new Label();
            txtCelular = new TextBox();
            tlpDni = new TableLayoutPanel();
            lblDni = new Label();
            txtDni = new TextBox();
            tlpApellido = new TableLayoutPanel();
            lblApellido = new Label();
            txtApellido = new TextBox();
            tlpNombre = new TableLayoutPanel();
            lblNombre = new Label();
            txtNombre = new TextBox();
            tlpMenuPrincipal.SuspendLayout();
            flpContenedorBotones.SuspendLayout();
            tlpDarAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDarAlta).BeginInit();
            tlbDarBaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDarBaja).BeginInit();
            tlpModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbModificar).BeginInit();
            tlpAlta1.SuspendLayout();
            tlpFechaNacimiento.SuspendLayout();
            tlpTurno.SuspendLayout();
            tlpCelular.SuspendLayout();
            tlpDni.SuspendLayout();
            tlpApellido.SuspendLayout();
            tlpNombre.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMenuPrincipal
            // 
            tlpMenuPrincipal.BackColor = Color.FromArgb(37, 40, 80);
            tlpMenuPrincipal.ColumnCount = 2;
            tlpMenuPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tlpMenuPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMenuPrincipal.Controls.Add(flpContenedorBotones, 0, 0);
            tlpMenuPrincipal.Dock = DockStyle.Fill;
            tlpMenuPrincipal.Location = new Point(0, 0);
            tlpMenuPrincipal.Name = "tlpMenuPrincipal";
            tlpMenuPrincipal.RowCount = 1;
            tlpMenuPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMenuPrincipal.Size = new Size(1024, 768);
            tlpMenuPrincipal.TabIndex = 0;
            // 
            // flpContenedorBotones
            // 
            flpContenedorBotones.BackColor = Color.FromArgb(52, 55, 95);
            flpContenedorBotones.BorderStyle = BorderStyle.Fixed3D;
            flpContenedorBotones.Controls.Add(tlpDarAlta);
            flpContenedorBotones.Controls.Add(tlbDarBaja);
            flpContenedorBotones.Controls.Add(tlpModificar);
            flpContenedorBotones.Dock = DockStyle.Fill;
            flpContenedorBotones.FlowDirection = FlowDirection.TopDown;
            flpContenedorBotones.Location = new Point(3, 3);
            flpContenedorBotones.Name = "flpContenedorBotones";
            flpContenedorBotones.Size = new Size(344, 762);
            flpContenedorBotones.TabIndex = 0;
            // 
            // tlpDarAlta
            // 
            tlpDarAlta.ColumnCount = 2;
            tlpDarAlta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tlpDarAlta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDarAlta.Controls.Add(pbDarAlta, 0, 0);
            tlpDarAlta.Controls.Add(btnDarAlta, 1, 0);
            tlpDarAlta.Location = new Point(3, 3);
            tlpDarAlta.Name = "tlpDarAlta";
            tlpDarAlta.RowCount = 1;
            tlpDarAlta.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpDarAlta.Size = new Size(340, 60);
            tlpDarAlta.TabIndex = 1;
            // 
            // pbDarAlta
            // 
            pbDarAlta.BackColor = Color.Transparent;
            pbDarAlta.Dock = DockStyle.Fill;
            pbDarAlta.Image = (Image)resources.GetObject("pbDarAlta.Image");
            pbDarAlta.InitialImage = null;
            pbDarAlta.Location = new Point(3, 3);
            pbDarAlta.Name = "pbDarAlta";
            pbDarAlta.Size = new Size(54, 54);
            pbDarAlta.SizeMode = PictureBoxSizeMode.Zoom;
            pbDarAlta.TabIndex = 0;
            pbDarAlta.TabStop = false;
            // 
            // btnDarAlta
            // 
            btnDarAlta.Dock = DockStyle.Fill;
            btnDarAlta.FlatAppearance.BorderSize = 0;
            btnDarAlta.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 44, 76);
            btnDarAlta.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 35, 85);
            btnDarAlta.FlatStyle = FlatStyle.Flat;
            btnDarAlta.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDarAlta.ForeColor = Color.White;
            btnDarAlta.Location = new Point(63, 3);
            btnDarAlta.Name = "btnDarAlta";
            btnDarAlta.Size = new Size(274, 54);
            btnDarAlta.TabIndex = 1;
            btnDarAlta.Text = "Inscribir ";
            btnDarAlta.TextAlign = ContentAlignment.MiddleLeft;
            btnDarAlta.UseVisualStyleBackColor = true;
            btnDarAlta.Click += btnDarAlta_Click;
            // 
            // tlbDarBaja
            // 
            tlbDarBaja.ColumnCount = 2;
            tlbDarBaja.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tlbDarBaja.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlbDarBaja.Controls.Add(pbDarBaja, 0, 0);
            tlbDarBaja.Controls.Add(btnDarBaja, 1, 0);
            tlbDarBaja.Location = new Point(3, 69);
            tlbDarBaja.Name = "tlbDarBaja";
            tlbDarBaja.RowCount = 1;
            tlbDarBaja.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlbDarBaja.Size = new Size(340, 60);
            tlbDarBaja.TabIndex = 2;
            // 
            // pbDarBaja
            // 
            pbDarBaja.BackColor = Color.Transparent;
            pbDarBaja.Dock = DockStyle.Fill;
            pbDarBaja.Image = (Image)resources.GetObject("pbDarBaja.Image");
            pbDarBaja.InitialImage = null;
            pbDarBaja.Location = new Point(3, 3);
            pbDarBaja.Name = "pbDarBaja";
            pbDarBaja.Size = new Size(54, 54);
            pbDarBaja.SizeMode = PictureBoxSizeMode.Zoom;
            pbDarBaja.TabIndex = 0;
            pbDarBaja.TabStop = false;
            // 
            // btnDarBaja
            // 
            btnDarBaja.Dock = DockStyle.Fill;
            btnDarBaja.FlatAppearance.BorderSize = 0;
            btnDarBaja.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 44, 76);
            btnDarBaja.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 35, 85);
            btnDarBaja.FlatStyle = FlatStyle.Flat;
            btnDarBaja.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDarBaja.ForeColor = Color.White;
            btnDarBaja.Location = new Point(63, 3);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(274, 54);
            btnDarBaja.TabIndex = 1;
            btnDarBaja.Text = "Eliminar ";
            btnDarBaja.TextAlign = ContentAlignment.MiddleLeft;
            btnDarBaja.UseVisualStyleBackColor = true;
            btnDarBaja.Click += btnDarBaja_Click;
            // 
            // tlpModificar
            // 
            tlpModificar.ColumnCount = 2;
            tlpModificar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tlpModificar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpModificar.Controls.Add(pbModificar, 0, 0);
            tlpModificar.Controls.Add(btnModificar, 1, 0);
            tlpModificar.Location = new Point(3, 135);
            tlpModificar.Name = "tlpModificar";
            tlpModificar.RowCount = 1;
            tlpModificar.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpModificar.Size = new Size(340, 60);
            tlpModificar.TabIndex = 3;
            // 
            // pbModificar
            // 
            pbModificar.BackColor = Color.Transparent;
            pbModificar.Dock = DockStyle.Fill;
            pbModificar.Image = (Image)resources.GetObject("pbModificar.Image");
            pbModificar.InitialImage = null;
            pbModificar.Location = new Point(3, 3);
            pbModificar.Name = "pbModificar";
            pbModificar.Size = new Size(54, 54);
            pbModificar.SizeMode = PictureBoxSizeMode.Zoom;
            pbModificar.TabIndex = 0;
            pbModificar.TabStop = false;
            // 
            // btnModificar
            // 
            btnModificar.Dock = DockStyle.Fill;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 44, 76);
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 35, 85);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(63, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(274, 54);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar Información";
            btnModificar.TextAlign = ContentAlignment.MiddleLeft;
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // flpAlta
            // 
            flpAlta.BackColor = Color.FromArgb(52, 55, 95);
            flpAlta.BorderStyle = BorderStyle.Fixed3D;
            flpAlta.Location = new Point(0, 0);
            flpAlta.Name = "flpAlta";
            flpAlta.Size = new Size(200, 100);
            flpAlta.TabIndex = 0;
            // 
            // tlpAlta1
            // 
            tlpAlta1.ColumnCount = 1;
            tlpAlta1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpAlta1.Controls.Add(tlpFechaNacimiento, 0, 5);
            tlpAlta1.Controls.Add(tlpTurno, 0, 4);
            tlpAlta1.Controls.Add(tlpCelular, 0, 3);
            tlpAlta1.Controls.Add(tlpDni, 0, 2);
            tlpAlta1.Controls.Add(tlpApellido, 0, 1);
            tlpAlta1.Location = new Point(0, 0);
            tlpAlta1.Name = "tlpAlta1";
            tlpAlta1.RowCount = 6;
            tlpAlta1.Size = new Size(200, 100);
            tlpAlta1.TabIndex = 0;
            // 
            // tlpFechaNacimiento
            // 
            tlpFechaNacimiento.ColumnCount = 1;
            tlpFechaNacimiento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFechaNacimiento.Controls.Add(lblFechaNacimiento, 0, 0);
            tlpFechaNacimiento.Controls.Add(dtpFechaNacimiento, 0, 1);
            tlpFechaNacimiento.Location = new Point(4, 503);
            tlpFechaNacimiento.Margin = new Padding(4, 3, 4, 3);
            tlpFechaNacimiento.Name = "tlpFechaNacimiento";
            tlpFechaNacimiento.RowCount = 2;
            tlpFechaNacimiento.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFechaNacimiento.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFechaNacimiento.Size = new Size(192, 119);
            tlpFechaNacimiento.TabIndex = 4;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.Anchor = AnchorStyles.None;
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNacimiento.ForeColor = Color.White;
            lblFechaNacimiento.Location = new Point(38, 0);
            lblFechaNacimiento.Margin = new Padding(4, 0, 4, 0);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(116, 58);
            lblFechaNacimiento.TabIndex = 0;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Anchor = AnchorStyles.None;
            dtpFechaNacimiento.CalendarForeColor = Color.FromArgb(55, 55, 57);
            dtpFechaNacimiento.CalendarTitleForeColor = Color.FromArgb(55, 55, 57);
            dtpFechaNacimiento.CustomFormat = "dd/MMM/yyyy";
            dtpFechaNacimiento.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.Location = new Point(4, 73);
            dtpFechaNacimiento.Margin = new Padding(4, 3, 4, 3);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(184, 31);
            dtpFechaNacimiento.TabIndex = 1;
            // 
            // tlpTurno
            // 
            tlpTurno.ColumnCount = 1;
            tlpTurno.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTurno.Controls.Add(lblTurno, 0, 0);
            tlpTurno.Controls.Add(cmbTurno, 0, 1);
            tlpTurno.Location = new Point(4, 378);
            tlpTurno.Margin = new Padding(4, 3, 4, 3);
            tlpTurno.Name = "tlpTurno";
            tlpTurno.RowCount = 2;
            tlpTurno.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTurno.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTurno.Size = new Size(192, 119);
            tlpTurno.TabIndex = 3;
            // 
            // lblTurno
            // 
            lblTurno.Anchor = AnchorStyles.None;
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTurno.ForeColor = Color.White;
            lblTurno.Location = new Point(62, 15);
            lblTurno.Margin = new Padding(4, 0, 4, 0);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(67, 29);
            lblTurno.TabIndex = 0;
            lblTurno.Text = "Turno";
            // 
            // cmbTurno
            // 
            cmbTurno.Anchor = AnchorStyles.None;
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTurno.ForeColor = Color.FromArgb(55, 55, 57);
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Location = new Point(4, 70);
            cmbTurno.Margin = new Padding(4, 3, 4, 3);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.RightToLeft = RightToLeft.No;
            cmbTurno.Size = new Size(184, 37);
            cmbTurno.TabIndex = 1;
            // 
            // tlpCelular
            // 
            tlpCelular.ColumnCount = 1;
            tlpCelular.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCelular.Controls.Add(lblCelular, 0, 0);
            tlpCelular.Controls.Add(txtCelular, 0, 1);
            tlpCelular.Location = new Point(4, 253);
            tlpCelular.Margin = new Padding(4, 3, 4, 3);
            tlpCelular.Name = "tlpCelular";
            tlpCelular.RowCount = 2;
            tlpCelular.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCelular.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCelular.Size = new Size(192, 119);
            tlpCelular.TabIndex = 3;
            // 
            // lblCelular
            // 
            lblCelular.Anchor = AnchorStyles.None;
            lblCelular.AutoSize = true;
            lblCelular.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCelular.ForeColor = Color.White;
            lblCelular.Location = new Point(56, 15);
            lblCelular.Margin = new Padding(4, 0, 4, 0);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(79, 29);
            lblCelular.TabIndex = 0;
            lblCelular.Text = "Celular";
            // 
            // txtCelular
            // 
            txtCelular.Anchor = AnchorStyles.None;
            txtCelular.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelular.ForeColor = Color.FromArgb(55, 55, 57);
            txtCelular.Location = new Point(4, 73);
            txtCelular.Margin = new Padding(4, 3, 4, 3);
            txtCelular.Name = "txtCelular";
            txtCelular.PlaceholderText = "Ingresar celular";
            txtCelular.Size = new Size(184, 31);
            txtCelular.TabIndex = 1;
            // 
            // tlpDni
            // 
            tlpDni.ColumnCount = 1;
            tlpDni.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDni.Controls.Add(lblDni, 0, 0);
            tlpDni.Controls.Add(txtDni, 0, 1);
            tlpDni.Location = new Point(4, 128);
            tlpDni.Margin = new Padding(4, 3, 4, 3);
            tlpDni.Name = "tlpDni";
            tlpDni.RowCount = 2;
            tlpDni.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDni.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDni.Size = new Size(192, 119);
            tlpDni.TabIndex = 3;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.None;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.ForeColor = Color.White;
            lblDni.Location = new Point(72, 15);
            lblDni.Margin = new Padding(4, 0, 4, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(47, 29);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
            txtDni.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.ForeColor = Color.FromArgb(55, 55, 57);
            txtDni.Location = new Point(4, 73);
            txtDni.Margin = new Padding(4, 3, 4, 3);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingresar DNI";
            txtDni.Size = new Size(184, 31);
            txtDni.TabIndex = 1;
            // 
            // tlpApellido
            // 
            tlpApellido.ColumnCount = 1;
            tlpApellido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpApellido.Controls.Add(lblApellido, 0, 0);
            tlpApellido.Controls.Add(txtApellido, 0, 1);
            tlpApellido.Location = new Point(4, 3);
            tlpApellido.Margin = new Padding(4, 3, 4, 3);
            tlpApellido.Name = "tlpApellido";
            tlpApellido.RowCount = 2;
            tlpApellido.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpApellido.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpApellido.Size = new Size(192, 119);
            tlpApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.White;
            lblApellido.Location = new Point(51, 15);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(89, 29);
            lblApellido.TabIndex = 0;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.ForeColor = Color.FromArgb(55, 55, 57);
            txtApellido.Location = new Point(4, 73);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingresar apellido";
            txtApellido.Size = new Size(184, 31);
            txtApellido.TabIndex = 1;
            // 
            // tlpNombre
            // 
            tlpNombre.ColumnCount = 1;
            tlpNombre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNombre.Controls.Add(lblNombre, 0, 0);
            tlpNombre.Location = new Point(0, 0);
            tlpNombre.Margin = new Padding(4, 3, 4, 3);
            tlpNombre.Name = "tlpNombre";
            tlpNombre.RowCount = 2;
            tlpNombre.Size = new Size(200, 100);
            tlpNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(56, 0);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(87, 29);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.FromArgb(55, 55, 57);
            txtNombre.Location = new Point(4, 49);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingresar nombre";
            txtNombre.Size = new Size(192, 31);
            txtNombre.TabIndex = 1;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(tlpMenuPrincipal);
            Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Polideportivo UTN";
            FormClosing += FrmMenuPrincipal_FormClosing;
            tlpMenuPrincipal.ResumeLayout(false);
            flpContenedorBotones.ResumeLayout(false);
            tlpDarAlta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbDarAlta).EndInit();
            tlbDarBaja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbDarBaja).EndInit();
            tlpModificar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbModificar).EndInit();
            tlpAlta1.ResumeLayout(false);
            tlpFechaNacimiento.ResumeLayout(false);
            tlpFechaNacimiento.PerformLayout();
            tlpTurno.ResumeLayout(false);
            tlpTurno.PerformLayout();
            tlpCelular.ResumeLayout(false);
            tlpCelular.PerformLayout();
            tlpDni.ResumeLayout(false);
            tlpDni.PerformLayout();
            tlpApellido.ResumeLayout(false);
            tlpApellido.PerformLayout();
            tlpNombre.ResumeLayout(false);
            tlpNombre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMenuPrincipal;
        private FlowLayoutPanel flpContenedorBotones;
        private TableLayoutPanel tlpDarAlta;
        private PictureBox pbDarAlta;
        private Button btnDarAlta;
        private TableLayoutPanel tlbDarBaja;
        private PictureBox pbDarBaja;
        private Button btnDarBaja;
        private TableLayoutPanel tlpModificar;
        private PictureBox pbModificar;
        private Button btnModificar;
        private FlowLayoutPanel flpAlta;
        private TableLayoutPanel tlpAlta1;
        private TableLayoutPanel tlpFechaNacimiento;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private TableLayoutPanel tlpTurno;
        private Label lblTurno;
        private ComboBox cmbTurno;
        private TableLayoutPanel tlpCelular;
        private Label lblCelular;
        private TextBox txtCelular;
        private TableLayoutPanel tlpDni;
        private Label lblDni;
        private TextBox txtDni;
        private TableLayoutPanel tlpApellido;
        private Label lblApellido;
        private TextBox txtApellido;
        private TableLayoutPanel tlpNombre;
        private Label lblNombre;
        private TextBox txtNombre;
    }
}