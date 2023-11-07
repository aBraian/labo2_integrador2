namespace Integrador_Nro_2
{
    partial class FrmMenuAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuAlta));
            tlpAlta2 = new TableLayoutPanel();
            gbDeporte = new GroupBox();
            tlpDeporte = new TableLayoutPanel();
            rbFutbol = new RadioButton();
            rbNatacion = new RadioButton();
            tlpCategoria = new TableLayoutPanel();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            tlpBotones = new TableLayoutPanel();
            btnDarAlta = new Button();
            btnVolver = new Button();
            epAlta = new ErrorProvider(components);
            tlpAlta1 = new TableLayoutPanel();
            tlpNombre = new TableLayoutPanel();
            txtNombre = new TextBox();
            lblNombre = new Label();
            tlpApellido = new TableLayoutPanel();
            txtApellido = new TextBox();
            lblApellido = new Label();
            tlpDni = new TableLayoutPanel();
            txtDni = new TextBox();
            lblDni = new Label();
            tlpCelular = new TableLayoutPanel();
            txtCelular = new TextBox();
            lblCelular = new Label();
            tlpTurno = new TableLayoutPanel();
            cmbTurno = new ComboBox();
            lblTurno = new Label();
            tlpFechaNacimiento = new TableLayoutPanel();
            dtpFechaNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            flpAlta = new FlowLayoutPanel();
            tlpAlta2.SuspendLayout();
            gbDeporte.SuspendLayout();
            tlpDeporte.SuspendLayout();
            tlpCategoria.SuspendLayout();
            tlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epAlta).BeginInit();
            tlpAlta1.SuspendLayout();
            tlpNombre.SuspendLayout();
            tlpApellido.SuspendLayout();
            tlpDni.SuspendLayout();
            tlpCelular.SuspendLayout();
            tlpTurno.SuspendLayout();
            tlpFechaNacimiento.SuspendLayout();
            flpAlta.SuspendLayout();
            SuspendLayout();
            // 
            // tlpAlta2
            // 
            tlpAlta2.BackColor = Color.FromArgb(37, 40, 80);
            tlpAlta2.ColumnCount = 1;
            tlpAlta2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpAlta2.Controls.Add(gbDeporte, 0, 0);
            tlpAlta2.Controls.Add(tlpCategoria, 0, 1);
            tlpAlta2.Controls.Add(tlpBotones, 0, 2);
            tlpAlta2.Location = new Point(350, 0);
            tlpAlta2.Margin = new Padding(4, 3, 4, 3);
            tlpAlta2.Name = "tlpAlta2";
            tlpAlta2.RowCount = 4;
            tlpAlta2.RowStyles.Add(new RowStyle(SizeType.Absolute, 435F));
            tlpAlta2.RowStyles.Add(new RowStyle(SizeType.Absolute, 203F));
            tlpAlta2.RowStyles.Add(new RowStyle(SizeType.Absolute, 145F));
            tlpAlta2.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tlpAlta2.Size = new Size(673, 768);
            tlpAlta2.TabIndex = 1;
            // 
            // gbDeporte
            // 
            gbDeporte.Anchor = AnchorStyles.None;
            gbDeporte.Controls.Add(tlpDeporte);
            gbDeporte.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbDeporte.ForeColor = Color.White;
            gbDeporte.Location = new Point(136, 92);
            gbDeporte.Margin = new Padding(4, 3, 4, 3);
            gbDeporte.Name = "gbDeporte";
            gbDeporte.Padding = new Padding(4, 3, 4, 3);
            gbDeporte.Size = new Size(400, 250);
            gbDeporte.TabIndex = 0;
            gbDeporte.TabStop = false;
            gbDeporte.Text = "Seleccionar deporte";
            // 
            // tlpDeporte
            // 
            tlpDeporte.ColumnCount = 1;
            tlpDeporte.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDeporte.Controls.Add(rbFutbol, 0, 0);
            tlpDeporte.Controls.Add(rbNatacion, 0, 1);
            tlpDeporte.Dock = DockStyle.Fill;
            tlpDeporte.Location = new Point(4, 27);
            tlpDeporte.Margin = new Padding(4, 3, 4, 3);
            tlpDeporte.Name = "tlpDeporte";
            tlpDeporte.RowCount = 2;
            tlpDeporte.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDeporte.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDeporte.Size = new Size(392, 220);
            tlpDeporte.TabIndex = 0;
            // 
            // rbFutbol
            // 
            rbFutbol.Anchor = AnchorStyles.Left;
            rbFutbol.AutoSize = true;
            rbFutbol.Location = new Point(4, 38);
            rbFutbol.Margin = new Padding(4, 3, 4, 3);
            rbFutbol.Name = "rbFutbol";
            rbFutbol.Size = new Size(93, 33);
            rbFutbol.TabIndex = 0;
            rbFutbol.TabStop = true;
            rbFutbol.Text = "Futbol";
            rbFutbol.UseVisualStyleBackColor = true;
            rbFutbol.Click += rbFutbol_Click;
            // 
            // rbNatacion
            // 
            rbNatacion.Anchor = AnchorStyles.Left;
            rbNatacion.AutoSize = true;
            rbNatacion.Location = new Point(4, 148);
            rbNatacion.Margin = new Padding(4, 3, 4, 3);
            rbNatacion.Name = "rbNatacion";
            rbNatacion.Size = new Size(118, 33);
            rbNatacion.TabIndex = 1;
            rbNatacion.TabStop = true;
            rbNatacion.Text = "Natacion";
            rbNatacion.UseVisualStyleBackColor = true;
            rbNatacion.Click += rbNatacion_Click;
            // 
            // tlpCategoria
            // 
            tlpCategoria.Anchor = AnchorStyles.Top;
            tlpCategoria.ColumnCount = 1;
            tlpCategoria.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCategoria.Controls.Add(lblCategoria, 0, 0);
            tlpCategoria.Controls.Add(cmbCategoria, 0, 1);
            tlpCategoria.Location = new Point(130, 438);
            tlpCategoria.Margin = new Padding(4, 3, 4, 3);
            tlpCategoria.Name = "tlpCategoria";
            tlpCategoria.RowCount = 2;
            tlpCategoria.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCategoria.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCategoria.Size = new Size(413, 138);
            tlpCategoria.TabIndex = 4;
            // 
            // lblCategoria
            // 
            lblCategoria.Anchor = AnchorStyles.None;
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoria.ForeColor = Color.White;
            lblCategoria.Location = new Point(154, 20);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(104, 29);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.Anchor = AnchorStyles.None;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategoria.ForeColor = Color.FromArgb(55, 55, 57);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(57, 85);
            cmbCategoria.Margin = new Padding(4, 3, 4, 3);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.RightToLeft = RightToLeft.No;
            cmbCategoria.Size = new Size(299, 37);
            cmbCategoria.TabIndex = 1;
            // 
            // tlpBotones
            // 
            tlpBotones.Anchor = AnchorStyles.None;
            tlpBotones.ColumnCount = 2;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBotones.Controls.Add(btnDarAlta, 0, 0);
            tlpBotones.Controls.Add(btnVolver, 1, 0);
            tlpBotones.Location = new Point(130, 641);
            tlpBotones.Margin = new Padding(4, 3, 4, 3);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 1;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBotones.Size = new Size(413, 138);
            tlpBotones.TabIndex = 5;
            // 
            // btnDarAlta
            // 
            btnDarAlta.Anchor = AnchorStyles.None;
            btnDarAlta.BackColor = Color.White;
            btnDarAlta.FlatStyle = FlatStyle.Flat;
            btnDarAlta.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDarAlta.ForeColor = Color.FromArgb(55, 55, 57);
            btnDarAlta.Location = new Point(40, 48);
            btnDarAlta.Margin = new Padding(4, 3, 4, 3);
            btnDarAlta.Name = "btnDarAlta";
            btnDarAlta.Size = new Size(125, 42);
            btnDarAlta.TabIndex = 0;
            btnDarAlta.Text = "Dar Alta";
            btnDarAlta.UseVisualStyleBackColor = false;
            btnDarAlta.Click += btnDarAlta_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.BackColor = Color.White;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.FromArgb(55, 55, 57);
            btnVolver.Location = new Point(247, 48);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(125, 42);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // epAlta
            // 
            epAlta.ContainerControl = this;
            epAlta.Icon = (Icon)resources.GetObject("epAlta.Icon");
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
            tlpAlta1.Controls.Add(tlpNombre, 0, 0);
            tlpAlta1.Location = new Point(4, 3);
            tlpAlta1.Margin = new Padding(4, 3, 4, 3);
            tlpAlta1.Name = "tlpAlta1";
            tlpAlta1.RowCount = 7;
            tlpAlta1.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tlpAlta1.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tlpAlta1.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tlpAlta1.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tlpAlta1.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tlpAlta1.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tlpAlta1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tlpAlta1.Size = new Size(350, 768);
            tlpAlta1.TabIndex = 3;
            // 
            // tlpNombre
            // 
            tlpNombre.ColumnCount = 1;
            tlpNombre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNombre.Controls.Add(lblNombre, 0, 0);
            tlpNombre.Controls.Add(txtNombre, 0, 1);
            tlpNombre.Location = new Point(4, 3);
            tlpNombre.Margin = new Padding(4, 3, 4, 3);
            tlpNombre.Name = "tlpNombre";
            tlpNombre.RowCount = 2;
            tlpNombre.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpNombre.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpNombre.Size = new Size(340, 119);
            tlpNombre.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.FromArgb(55, 55, 57);
            txtNombre.Location = new Point(20, 73);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingresar nombre";
            txtNombre.Size = new Size(299, 31);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(126, 15);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(87, 29);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // tlpApellido
            // 
            tlpApellido.ColumnCount = 1;
            tlpApellido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpApellido.Controls.Add(lblApellido, 0, 0);
            tlpApellido.Controls.Add(txtApellido, 0, 1);
            tlpApellido.Location = new Point(4, 128);
            tlpApellido.Margin = new Padding(4, 3, 4, 3);
            tlpApellido.Name = "tlpApellido";
            tlpApellido.RowCount = 2;
            tlpApellido.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpApellido.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpApellido.Size = new Size(340, 119);
            tlpApellido.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.ForeColor = Color.FromArgb(55, 55, 57);
            txtApellido.Location = new Point(20, 73);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingresar apellido";
            txtApellido.Size = new Size(299, 31);
            txtApellido.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.White;
            lblApellido.Location = new Point(125, 15);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(89, 29);
            lblApellido.TabIndex = 0;
            lblApellido.Text = "Apellido";
            // 
            // tlpDni
            // 
            tlpDni.ColumnCount = 1;
            tlpDni.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDni.Controls.Add(lblDni, 0, 0);
            tlpDni.Controls.Add(txtDni, 0, 1);
            tlpDni.Location = new Point(4, 253);
            tlpDni.Margin = new Padding(4, 3, 4, 3);
            tlpDni.Name = "tlpDni";
            tlpDni.RowCount = 2;
            tlpDni.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDni.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDni.Size = new Size(340, 119);
            tlpDni.TabIndex = 3;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
            txtDni.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.ForeColor = Color.FromArgb(55, 55, 57);
            txtDni.Location = new Point(20, 73);
            txtDni.Margin = new Padding(4, 3, 4, 3);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingresar DNI";
            txtDni.Size = new Size(299, 31);
            txtDni.TabIndex = 1;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.None;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.ForeColor = Color.White;
            lblDni.Location = new Point(146, 15);
            lblDni.Margin = new Padding(4, 0, 4, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(47, 29);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI";
            // 
            // tlpCelular
            // 
            tlpCelular.ColumnCount = 1;
            tlpCelular.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCelular.Controls.Add(lblCelular, 0, 0);
            tlpCelular.Controls.Add(txtCelular, 0, 1);
            tlpCelular.Location = new Point(4, 378);
            tlpCelular.Margin = new Padding(4, 3, 4, 3);
            tlpCelular.Name = "tlpCelular";
            tlpCelular.RowCount = 2;
            tlpCelular.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCelular.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCelular.Size = new Size(340, 119);
            tlpCelular.TabIndex = 3;
            // 
            // txtCelular
            // 
            txtCelular.Anchor = AnchorStyles.None;
            txtCelular.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelular.ForeColor = Color.FromArgb(55, 55, 57);
            txtCelular.Location = new Point(20, 73);
            txtCelular.Margin = new Padding(4, 3, 4, 3);
            txtCelular.Name = "txtCelular";
            txtCelular.PlaceholderText = "Ingresar celular";
            txtCelular.Size = new Size(299, 31);
            txtCelular.TabIndex = 1;
            // 
            // lblCelular
            // 
            lblCelular.Anchor = AnchorStyles.None;
            lblCelular.AutoSize = true;
            lblCelular.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCelular.ForeColor = Color.White;
            lblCelular.Location = new Point(130, 15);
            lblCelular.Margin = new Padding(4, 0, 4, 0);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(79, 29);
            lblCelular.TabIndex = 0;
            lblCelular.Text = "Celular";
            // 
            // tlpTurno
            // 
            tlpTurno.ColumnCount = 1;
            tlpTurno.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTurno.Controls.Add(lblTurno, 0, 0);
            tlpTurno.Controls.Add(cmbTurno, 0, 1);
            tlpTurno.Location = new Point(4, 503);
            tlpTurno.Margin = new Padding(4, 3, 4, 3);
            tlpTurno.Name = "tlpTurno";
            tlpTurno.RowCount = 2;
            tlpTurno.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTurno.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTurno.Size = new Size(340, 119);
            tlpTurno.TabIndex = 3;
            // 
            // cmbTurno
            // 
            cmbTurno.Anchor = AnchorStyles.None;
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTurno.ForeColor = Color.FromArgb(55, 55, 57);
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Location = new Point(20, 70);
            cmbTurno.Margin = new Padding(4, 3, 4, 3);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.RightToLeft = RightToLeft.No;
            cmbTurno.Size = new Size(299, 37);
            cmbTurno.TabIndex = 1;
            // 
            // lblTurno
            // 
            lblTurno.Anchor = AnchorStyles.None;
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTurno.ForeColor = Color.White;
            lblTurno.Location = new Point(136, 15);
            lblTurno.Margin = new Padding(4, 0, 4, 0);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(67, 29);
            lblTurno.TabIndex = 0;
            lblTurno.Text = "Turno";
            // 
            // tlpFechaNacimiento
            // 
            tlpFechaNacimiento.ColumnCount = 1;
            tlpFechaNacimiento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFechaNacimiento.Controls.Add(lblFechaNacimiento, 0, 0);
            tlpFechaNacimiento.Controls.Add(dtpFechaNacimiento, 0, 1);
            tlpFechaNacimiento.Location = new Point(4, 628);
            tlpFechaNacimiento.Margin = new Padding(4, 3, 4, 3);
            tlpFechaNacimiento.Name = "tlpFechaNacimiento";
            tlpFechaNacimiento.RowCount = 2;
            tlpFechaNacimiento.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFechaNacimiento.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFechaNacimiento.Size = new Size(342, 119);
            tlpFechaNacimiento.TabIndex = 4;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Anchor = AnchorStyles.None;
            dtpFechaNacimiento.CalendarForeColor = Color.FromArgb(55, 55, 57);
            dtpFechaNacimiento.CalendarTitleForeColor = Color.FromArgb(55, 55, 57);
            dtpFechaNacimiento.CustomFormat = "dd/MMM/yyyy";
            dtpFechaNacimiento.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.Location = new Point(21, 73);
            dtpFechaNacimiento.Margin = new Padding(4, 3, 4, 3);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(299, 31);
            dtpFechaNacimiento.TabIndex = 1;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.Anchor = AnchorStyles.None;
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNacimiento.ForeColor = Color.White;
            lblFechaNacimiento.Location = new Point(67, 15);
            lblFechaNacimiento.Margin = new Padding(4, 0, 4, 0);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(207, 29);
            lblFechaNacimiento.TabIndex = 0;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // flpAlta
            // 
            flpAlta.BackColor = Color.FromArgb(52, 55, 95);
            flpAlta.BorderStyle = BorderStyle.Fixed3D;
            flpAlta.Controls.Add(tlpAlta1);
            flpAlta.Dock = DockStyle.Left;
            flpAlta.Location = new Point(0, 0);
            flpAlta.Margin = new Padding(4, 3, 4, 3);
            flpAlta.Name = "flpAlta";
            flpAlta.Size = new Size(350, 768);
            flpAlta.TabIndex = 0;
            // 
            // FrmMenuAlta
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 35, 85);
            ClientSize = new Size(1024, 768);
            Controls.Add(tlpAlta2);
            Controls.Add(flpAlta);
            Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenuAlta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Polideportivo UTN";
            Load += FrmMenuAlta_Load;
            tlpAlta2.ResumeLayout(false);
            gbDeporte.ResumeLayout(false);
            tlpDeporte.ResumeLayout(false);
            tlpDeporte.PerformLayout();
            tlpCategoria.ResumeLayout(false);
            tlpCategoria.PerformLayout();
            tlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)epAlta).EndInit();
            tlpAlta1.ResumeLayout(false);
            tlpNombre.ResumeLayout(false);
            tlpNombre.PerformLayout();
            tlpApellido.ResumeLayout(false);
            tlpApellido.PerformLayout();
            tlpDni.ResumeLayout(false);
            tlpDni.PerformLayout();
            tlpCelular.ResumeLayout(false);
            tlpCelular.PerformLayout();
            tlpTurno.ResumeLayout(false);
            tlpTurno.PerformLayout();
            tlpFechaNacimiento.ResumeLayout(false);
            tlpFechaNacimiento.PerformLayout();
            flpAlta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tlpAlta2;
        private GroupBox gbDeporte;
        private TableLayoutPanel tlpDeporte;
        private RadioButton rbFutbol;
        private RadioButton rbNatacion;
        private ErrorProvider epAlta;
        private TableLayoutPanel tlpCategoria;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private TableLayoutPanel tlpBotones;
        private Button btnDarAlta;
        private Button btnVolver;
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