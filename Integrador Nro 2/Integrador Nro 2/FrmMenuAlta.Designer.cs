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
            epAlta = new ErrorProvider(components);
            tlpMenuAlta = new TableLayoutPanel();
            flpDatosPersonales = new FlowLayoutPanel();
            tlpNombre = new TableLayoutPanel();
            lblNombre = new Label();
            txtNombre = new TextBox();
            tlpApellido = new TableLayoutPanel();
            txtApellido = new TextBox();
            lblApellido = new Label();
            tlpDni = new TableLayoutPanel();
            txtDni = new TextBox();
            lblDni = new Label();
            tlpCelular = new TableLayoutPanel();
            txtCelular = new TextBox();
            lblCelular = new Label();
            tlpFechaNacimiento = new TableLayoutPanel();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            tlpBotones = new TableLayoutPanel();
            btnVolver = new Button();
            btnDarAlta = new Button();
            flpDatosDeporte = new FlowLayoutPanel();
            tlpSeleccionDeporte = new TableLayoutPanel();
            gpSeleccionarDeporte = new GroupBox();
            tlpSeleccionarDeporte = new TableLayoutPanel();
            rbNatacion = new RadioButton();
            rbFutbol = new RadioButton();
            tlpCategoria = new TableLayoutPanel();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            tlpTurno = new TableLayoutPanel();
            cmbTurno = new ComboBox();
            lblTurno = new Label();
            ((System.ComponentModel.ISupportInitialize)epAlta).BeginInit();
            tlpMenuAlta.SuspendLayout();
            flpDatosPersonales.SuspendLayout();
            tlpNombre.SuspendLayout();
            tlpApellido.SuspendLayout();
            tlpDni.SuspendLayout();
            tlpCelular.SuspendLayout();
            tlpFechaNacimiento.SuspendLayout();
            tlpBotones.SuspendLayout();
            flpDatosDeporte.SuspendLayout();
            tlpSeleccionDeporte.SuspendLayout();
            gpSeleccionarDeporte.SuspendLayout();
            tlpSeleccionarDeporte.SuspendLayout();
            tlpCategoria.SuspendLayout();
            tlpTurno.SuspendLayout();
            SuspendLayout();
            // 
            // epAlta
            // 
            epAlta.ContainerControl = this;
            epAlta.Icon = (Icon)resources.GetObject("epAlta.Icon");
            // 
            // tlpMenuAlta
            // 
            tlpMenuAlta.BackColor = Color.FromArgb(37, 40, 80);
            tlpMenuAlta.ColumnCount = 2;
            tlpMenuAlta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tlpMenuAlta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMenuAlta.Controls.Add(flpDatosPersonales, 0, 0);
            tlpMenuAlta.Controls.Add(flpDatosDeporte, 1, 0);
            tlpMenuAlta.Dock = DockStyle.Fill;
            tlpMenuAlta.Location = new Point(0, 0);
            tlpMenuAlta.Name = "tlpMenuAlta";
            tlpMenuAlta.RowCount = 1;
            tlpMenuAlta.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMenuAlta.Size = new Size(1024, 768);
            tlpMenuAlta.TabIndex = 0;
            // 
            // flpDatosPersonales
            // 
            flpDatosPersonales.BackColor = Color.FromArgb(52, 55, 95);
            flpDatosPersonales.BorderStyle = BorderStyle.Fixed3D;
            flpDatosPersonales.Controls.Add(tlpNombre);
            flpDatosPersonales.Controls.Add(tlpApellido);
            flpDatosPersonales.Controls.Add(tlpDni);
            flpDatosPersonales.Controls.Add(tlpCelular);
            flpDatosPersonales.Controls.Add(tlpFechaNacimiento);
            flpDatosPersonales.Controls.Add(tlpBotones);
            flpDatosPersonales.Dock = DockStyle.Fill;
            flpDatosPersonales.FlowDirection = FlowDirection.TopDown;
            flpDatosPersonales.Location = new Point(3, 3);
            flpDatosPersonales.Name = "flpDatosPersonales";
            flpDatosPersonales.Size = new Size(344, 762);
            flpDatosPersonales.TabIndex = 0;
            // 
            // tlpNombre
            // 
            tlpNombre.ColumnCount = 1;
            tlpNombre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNombre.Controls.Add(lblNombre, 0, 0);
            tlpNombre.Controls.Add(txtNombre, 0, 1);
            tlpNombre.Location = new Point(3, 3);
            tlpNombre.Name = "tlpNombre";
            tlpNombre.RowCount = 2;
            tlpNombre.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpNombre.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpNombre.Size = new Size(340, 100);
            tlpNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(126, 10);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(87, 29);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(57, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingresar nombre";
            txtNombre.Size = new Size(225, 27);
            txtNombre.TabIndex = 1;
            // 
            // tlpApellido
            // 
            tlpApellido.ColumnCount = 1;
            tlpApellido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpApellido.Controls.Add(txtApellido, 0, 1);
            tlpApellido.Controls.Add(lblApellido, 0, 0);
            tlpApellido.Location = new Point(3, 109);
            tlpApellido.Name = "tlpApellido";
            tlpApellido.RowCount = 2;
            tlpApellido.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpApellido.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpApellido.Size = new Size(340, 100);
            tlpApellido.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(57, 61);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingresar apellido";
            txtApellido.Size = new Size(225, 27);
            txtApellido.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(125, 10);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(89, 29);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // tlpDni
            // 
            tlpDni.ColumnCount = 1;
            tlpDni.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDni.Controls.Add(txtDni, 0, 1);
            tlpDni.Controls.Add(lblDni, 0, 0);
            tlpDni.Location = new Point(3, 215);
            tlpDni.Name = "tlpDni";
            tlpDni.RowCount = 2;
            tlpDni.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDni.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDni.Size = new Size(340, 100);
            tlpDni.TabIndex = 2;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
            txtDni.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(57, 61);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingresar DNI";
            txtDni.Size = new Size(225, 27);
            txtDni.TabIndex = 2;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.None;
            lblDni.AutoSize = true;
            lblDni.Location = new Point(146, 10);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(47, 29);
            lblDni.TabIndex = 1;
            lblDni.Text = "DNI";
            // 
            // tlpCelular
            // 
            tlpCelular.ColumnCount = 1;
            tlpCelular.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCelular.Controls.Add(txtCelular, 0, 1);
            tlpCelular.Controls.Add(lblCelular, 0, 0);
            tlpCelular.Location = new Point(3, 321);
            tlpCelular.Name = "tlpCelular";
            tlpCelular.RowCount = 2;
            tlpCelular.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCelular.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCelular.Size = new Size(340, 100);
            tlpCelular.TabIndex = 3;
            // 
            // txtCelular
            // 
            txtCelular.Anchor = AnchorStyles.None;
            txtCelular.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelular.Location = new Point(57, 61);
            txtCelular.Name = "txtCelular";
            txtCelular.PlaceholderText = "Ingresar celular";
            txtCelular.Size = new Size(225, 27);
            txtCelular.TabIndex = 2;
            // 
            // lblCelular
            // 
            lblCelular.Anchor = AnchorStyles.None;
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(130, 10);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(79, 29);
            lblCelular.TabIndex = 1;
            lblCelular.Text = "Celular";
            // 
            // tlpFechaNacimiento
            // 
            tlpFechaNacimiento.ColumnCount = 1;
            tlpFechaNacimiento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFechaNacimiento.Controls.Add(lblFechaNacimiento, 0, 0);
            tlpFechaNacimiento.Controls.Add(dtpFechaNacimiento, 0, 1);
            tlpFechaNacimiento.Location = new Point(3, 427);
            tlpFechaNacimiento.Name = "tlpFechaNacimiento";
            tlpFechaNacimiento.RowCount = 2;
            tlpFechaNacimiento.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFechaNacimiento.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFechaNacimiento.Size = new Size(340, 100);
            tlpFechaNacimiento.TabIndex = 4;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.Anchor = AnchorStyles.None;
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(65, 10);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(210, 29);
            lblFechaNacimiento.TabIndex = 1;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Anchor = AnchorStyles.None;
            dtpFechaNacimiento.CustomFormat = "dd/MMM/yyyy";
            dtpFechaNacimiento.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.Location = new Point(57, 61);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(225, 27);
            dtpFechaNacimiento.TabIndex = 2;
            // 
            // tlpBotones
            // 
            tlpBotones.ColumnCount = 2;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBotones.Controls.Add(btnVolver, 0, 0);
            tlpBotones.Controls.Add(btnDarAlta, 0, 0);
            tlpBotones.Location = new Point(3, 533);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 1;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBotones.Size = new Size(340, 222);
            tlpBotones.TabIndex = 5;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Transparent;
            btnVolver.Dock = DockStyle.Fill;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 44, 76);
            btnVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 35, 85);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(174, 3);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(162, 216);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnDarAlta
            // 
            btnDarAlta.BackColor = Color.Transparent;
            btnDarAlta.Dock = DockStyle.Fill;
            btnDarAlta.FlatAppearance.BorderSize = 0;
            btnDarAlta.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 44, 76);
            btnDarAlta.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 35, 85);
            btnDarAlta.FlatStyle = FlatStyle.Flat;
            btnDarAlta.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDarAlta.ForeColor = Color.White;
            btnDarAlta.Location = new Point(4, 3);
            btnDarAlta.Margin = new Padding(4, 3, 4, 3);
            btnDarAlta.Name = "btnDarAlta";
            btnDarAlta.Size = new Size(162, 216);
            btnDarAlta.TabIndex = 3;
            btnDarAlta.Text = "Dar Alta";
            btnDarAlta.UseVisualStyleBackColor = false;
            btnDarAlta.Click += btnDarAlta_Click;
            // 
            // flpDatosDeporte
            // 
            flpDatosDeporte.Controls.Add(tlpSeleccionDeporte);
            flpDatosDeporte.Controls.Add(tlpCategoria);
            flpDatosDeporte.Controls.Add(tlpTurno);
            flpDatosDeporte.Dock = DockStyle.Fill;
            flpDatosDeporte.FlowDirection = FlowDirection.TopDown;
            flpDatosDeporte.Location = new Point(353, 3);
            flpDatosDeporte.Name = "flpDatosDeporte";
            flpDatosDeporte.Size = new Size(668, 762);
            flpDatosDeporte.TabIndex = 1;
            // 
            // tlpSeleccionDeporte
            // 
            tlpSeleccionDeporte.ColumnCount = 1;
            tlpSeleccionDeporte.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSeleccionDeporte.Controls.Add(gpSeleccionarDeporte, 0, 0);
            tlpSeleccionDeporte.Location = new Point(3, 3);
            tlpSeleccionDeporte.Name = "tlpSeleccionDeporte";
            tlpSeleccionDeporte.RowCount = 1;
            tlpSeleccionDeporte.RowStyles.Add(new RowStyle(SizeType.Absolute, 275F));
            tlpSeleccionDeporte.Size = new Size(674, 370);
            tlpSeleccionDeporte.TabIndex = 0;
            // 
            // gpSeleccionarDeporte
            // 
            gpSeleccionarDeporte.Anchor = AnchorStyles.None;
            gpSeleccionarDeporte.Controls.Add(tlpSeleccionarDeporte);
            gpSeleccionarDeporte.ForeColor = Color.White;
            gpSeleccionarDeporte.Location = new Point(162, 60);
            gpSeleccionarDeporte.Name = "gpSeleccionarDeporte";
            gpSeleccionarDeporte.Size = new Size(350, 250);
            gpSeleccionarDeporte.TabIndex = 0;
            gpSeleccionarDeporte.TabStop = false;
            gpSeleccionarDeporte.Text = "Seleccionar Deporte";
            // 
            // tlpSeleccionarDeporte
            // 
            tlpSeleccionarDeporte.ColumnCount = 1;
            tlpSeleccionarDeporte.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSeleccionarDeporte.Controls.Add(rbNatacion, 0, 1);
            tlpSeleccionarDeporte.Controls.Add(rbFutbol, 0, 0);
            tlpSeleccionarDeporte.Dock = DockStyle.Fill;
            tlpSeleccionarDeporte.Location = new Point(3, 27);
            tlpSeleccionarDeporte.Name = "tlpSeleccionarDeporte";
            tlpSeleccionarDeporte.RowCount = 2;
            tlpSeleccionarDeporte.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSeleccionarDeporte.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSeleccionarDeporte.Size = new Size(344, 220);
            tlpSeleccionarDeporte.TabIndex = 0;
            // 
            // rbNatacion
            // 
            rbNatacion.Anchor = AnchorStyles.Left;
            rbNatacion.AutoSize = true;
            rbNatacion.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbNatacion.Location = new Point(3, 150);
            rbNatacion.Name = "rbNatacion";
            rbNatacion.Size = new Size(105, 29);
            rbNatacion.TabIndex = 1;
            rbNatacion.TabStop = true;
            rbNatacion.Text = "Natacion";
            rbNatacion.UseVisualStyleBackColor = true;
            rbNatacion.Click += rbNatacion_Click;
            // 
            // rbFutbol
            // 
            rbFutbol.Anchor = AnchorStyles.Left;
            rbFutbol.AutoSize = true;
            rbFutbol.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbFutbol.Location = new Point(3, 40);
            rbFutbol.Name = "rbFutbol";
            rbFutbol.Size = new Size(83, 29);
            rbFutbol.TabIndex = 0;
            rbFutbol.TabStop = true;
            rbFutbol.Text = "Futbol";
            rbFutbol.UseVisualStyleBackColor = true;
            rbFutbol.Click += rbFutbol_Click;
            // 
            // tlpCategoria
            // 
            tlpCategoria.ColumnCount = 1;
            tlpCategoria.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCategoria.Controls.Add(lblCategoria, 0, 0);
            tlpCategoria.Controls.Add(cmbCategoria, 0, 1);
            tlpCategoria.Location = new Point(3, 379);
            tlpCategoria.Name = "tlpCategoria";
            tlpCategoria.RowCount = 2;
            tlpCategoria.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCategoria.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCategoria.Size = new Size(674, 150);
            tlpCategoria.TabIndex = 1;
            // 
            // lblCategoria
            // 
            lblCategoria.Anchor = AnchorStyles.None;
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(285, 23);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(104, 29);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.Anchor = AnchorStyles.None;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(224, 96);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(225, 33);
            cmbCategoria.TabIndex = 2;
            // 
            // tlpTurno
            // 
            tlpTurno.ColumnCount = 1;
            tlpTurno.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTurno.Controls.Add(cmbTurno, 0, 1);
            tlpTurno.Controls.Add(lblTurno, 0, 0);
            tlpTurno.Location = new Point(3, 535);
            tlpTurno.Name = "tlpTurno";
            tlpTurno.RowCount = 2;
            tlpTurno.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTurno.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTurno.Size = new Size(674, 150);
            tlpTurno.TabIndex = 2;
            // 
            // cmbTurno
            // 
            cmbTurno.Anchor = AnchorStyles.None;
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Location = new Point(224, 96);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(225, 33);
            cmbTurno.TabIndex = 3;
            // 
            // lblTurno
            // 
            lblTurno.Anchor = AnchorStyles.None;
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(303, 23);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(67, 29);
            lblTurno.TabIndex = 1;
            lblTurno.Text = "Turno";
            // 
            // FrmMenuAlta
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 768);
            Controls.Add(tlpMenuAlta);
            Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenuAlta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AquaGoal";
            Load += FrmMenuAlta_Load;
            ((System.ComponentModel.ISupportInitialize)epAlta).EndInit();
            tlpMenuAlta.ResumeLayout(false);
            flpDatosPersonales.ResumeLayout(false);
            tlpNombre.ResumeLayout(false);
            tlpNombre.PerformLayout();
            tlpApellido.ResumeLayout(false);
            tlpApellido.PerformLayout();
            tlpDni.ResumeLayout(false);
            tlpDni.PerformLayout();
            tlpCelular.ResumeLayout(false);
            tlpCelular.PerformLayout();
            tlpFechaNacimiento.ResumeLayout(false);
            tlpFechaNacimiento.PerformLayout();
            tlpBotones.ResumeLayout(false);
            flpDatosDeporte.ResumeLayout(false);
            tlpSeleccionDeporte.ResumeLayout(false);
            gpSeleccionarDeporte.ResumeLayout(false);
            tlpSeleccionarDeporte.ResumeLayout(false);
            tlpSeleccionarDeporte.PerformLayout();
            tlpCategoria.ResumeLayout(false);
            tlpCategoria.PerformLayout();
            tlpTurno.ResumeLayout(false);
            tlpTurno.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider epAlta;
        private TableLayoutPanel tlpMenuAlta;
        private FlowLayoutPanel flpDatosPersonales;
        private TableLayoutPanel tlpNombre;
        private TableLayoutPanel tlpApellido;
        private TableLayoutPanel tlpDni;
        private TableLayoutPanel tlpCelular;
        private TableLayoutPanel tlpFechaNacimiento;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblCelular;
        private Label lblFechaNacimiento;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtCelular;
        private DateTimePicker dtpFechaNacimiento;
        private TableLayoutPanel tlpBotones;
        private Button btnDarAlta;
        private Button btnVolver;
        private FlowLayoutPanel flpDatosDeporte;
        private TableLayoutPanel tlpSeleccionDeporte;
        private TableLayoutPanel tlpCategoria;
        private TableLayoutPanel tlpTurno;
        private GroupBox gpSeleccionarDeporte;
        private TableLayoutPanel tlpSeleccionarDeporte;
        private RadioButton rbNatacion;
        private RadioButton rbFutbol;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Label lblTurno;
        private ComboBox cmbTurno;
    }
}