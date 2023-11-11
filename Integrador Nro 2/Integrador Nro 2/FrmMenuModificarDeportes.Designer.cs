namespace Integrador_Nro_2
{
    partial class FrmMenuModificarDeportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuModificarDeportes));
            tlpMenuModificarDeportes = new TableLayoutPanel();
            lbPersonas = new ListBox();
            flpContenedorControles = new FlowLayoutPanel();
            tlpCambios = new TableLayoutPanel();
            gpSeleccionarCambio = new GroupBox();
            tlpSeleccionarCambios = new TableLayoutPanel();
            rbCambiarTurno = new RadioButton();
            rbCambiarDeporte = new RadioButton();
            rbCambiarCategoria = new RadioButton();
            tlpSeleccionDeporte = new TableLayoutPanel();
            grpSeleccionarDeporte = new GroupBox();
            tlpSeleccionarDeporte = new TableLayoutPanel();
            rbNatacion = new RadioButton();
            rbFutbol = new RadioButton();
            tlpSeleccionCategoria = new TableLayoutPanel();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            tlpSeleccionTurno = new TableLayoutPanel();
            cmbTurno = new ComboBox();
            lblTurno = new Label();
            lblMensaje = new Label();
            tlpBotones = new TableLayoutPanel();
            btnModificar = new Button();
            btnVolver = new Button();
            epModificar = new ErrorProvider(components);
            tlpMenuModificarDeportes.SuspendLayout();
            flpContenedorControles.SuspendLayout();
            tlpCambios.SuspendLayout();
            gpSeleccionarCambio.SuspendLayout();
            tlpSeleccionarCambios.SuspendLayout();
            tlpSeleccionDeporte.SuspendLayout();
            grpSeleccionarDeporte.SuspendLayout();
            tlpSeleccionarDeporte.SuspendLayout();
            tlpSeleccionCategoria.SuspendLayout();
            tlpSeleccionTurno.SuspendLayout();
            tlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epModificar).BeginInit();
            SuspendLayout();
            // 
            // tlpMenuModificarDeportes
            // 
            tlpMenuModificarDeportes.BackColor = Color.FromArgb(37, 40, 80);
            tlpMenuModificarDeportes.ColumnCount = 2;
            tlpMenuModificarDeportes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tlpMenuModificarDeportes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMenuModificarDeportes.Controls.Add(lbPersonas, 0, 0);
            tlpMenuModificarDeportes.Controls.Add(flpContenedorControles, 0, 0);
            tlpMenuModificarDeportes.Dock = DockStyle.Fill;
            tlpMenuModificarDeportes.Location = new Point(0, 0);
            tlpMenuModificarDeportes.Name = "tlpMenuModificarDeportes";
            tlpMenuModificarDeportes.RowCount = 1;
            tlpMenuModificarDeportes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMenuModificarDeportes.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMenuModificarDeportes.Size = new Size(1024, 768);
            tlpMenuModificarDeportes.TabIndex = 3;
            // 
            // lbPersonas
            // 
            lbPersonas.BackColor = Color.FromArgb(37, 40, 80);
            lbPersonas.BorderStyle = BorderStyle.None;
            lbPersonas.Dock = DockStyle.Fill;
            lbPersonas.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPersonas.ForeColor = Color.White;
            lbPersonas.FormattingEnabled = true;
            lbPersonas.HorizontalScrollbar = true;
            lbPersonas.ItemHeight = 29;
            lbPersonas.Location = new Point(353, 3);
            lbPersonas.Name = "lbPersonas";
            lbPersonas.Size = new Size(668, 762);
            lbPersonas.TabIndex = 2;
            // 
            // flpContenedorControles
            // 
            flpContenedorControles.BackColor = Color.FromArgb(52, 55, 95);
            flpContenedorControles.BorderStyle = BorderStyle.Fixed3D;
            flpContenedorControles.Controls.Add(tlpCambios);
            flpContenedorControles.Controls.Add(tlpSeleccionDeporte);
            flpContenedorControles.Controls.Add(tlpSeleccionCategoria);
            flpContenedorControles.Controls.Add(tlpSeleccionTurno);
            flpContenedorControles.Controls.Add(lblMensaje);
            flpContenedorControles.Controls.Add(tlpBotones);
            flpContenedorControles.Dock = DockStyle.Fill;
            flpContenedorControles.FlowDirection = FlowDirection.TopDown;
            flpContenedorControles.Location = new Point(3, 3);
            flpContenedorControles.Name = "flpContenedorControles";
            flpContenedorControles.Size = new Size(344, 762);
            flpContenedorControles.TabIndex = 0;
            // 
            // tlpCambios
            // 
            tlpCambios.BackgroundImageLayout = ImageLayout.None;
            tlpCambios.ColumnCount = 1;
            tlpCambios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCambios.Controls.Add(gpSeleccionarCambio, 0, 0);
            tlpCambios.Location = new Point(3, 3);
            tlpCambios.Name = "tlpCambios";
            tlpCambios.RowCount = 1;
            tlpCambios.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpCambios.Size = new Size(340, 200);
            tlpCambios.TabIndex = 19;
            // 
            // gpSeleccionarCambio
            // 
            gpSeleccionarCambio.Anchor = AnchorStyles.None;
            gpSeleccionarCambio.Controls.Add(tlpSeleccionarCambios);
            gpSeleccionarCambio.FlatStyle = FlatStyle.Flat;
            gpSeleccionarCambio.ForeColor = Color.White;
            gpSeleccionarCambio.Location = new Point(20, 3);
            gpSeleccionarCambio.Name = "gpSeleccionarCambio";
            gpSeleccionarCambio.Size = new Size(300, 194);
            gpSeleccionarCambio.TabIndex = 0;
            gpSeleccionarCambio.TabStop = false;
            gpSeleccionarCambio.Text = "Seleccionar Cambio";
            // 
            // tlpSeleccionarCambios
            // 
            tlpSeleccionarCambios.ColumnCount = 1;
            tlpSeleccionarCambios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSeleccionarCambios.Controls.Add(rbCambiarTurno, 0, 2);
            tlpSeleccionarCambios.Controls.Add(rbCambiarDeporte, 0, 0);
            tlpSeleccionarCambios.Controls.Add(rbCambiarCategoria, 0, 1);
            tlpSeleccionarCambios.Dock = DockStyle.Fill;
            tlpSeleccionarCambios.Location = new Point(3, 27);
            tlpSeleccionarCambios.Name = "tlpSeleccionarCambios";
            tlpSeleccionarCambios.RowCount = 3;
            tlpSeleccionarCambios.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpSeleccionarCambios.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpSeleccionarCambios.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpSeleccionarCambios.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpSeleccionarCambios.Size = new Size(294, 164);
            tlpSeleccionarCambios.TabIndex = 1;
            // 
            // rbCambiarTurno
            // 
            rbCambiarTurno.Anchor = AnchorStyles.Left;
            rbCambiarTurno.AutoSize = true;
            rbCambiarTurno.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbCambiarTurno.ForeColor = Color.White;
            rbCambiarTurno.Location = new Point(3, 117);
            rbCambiarTurno.Name = "rbCambiarTurno";
            rbCambiarTurno.Size = new Size(190, 29);
            rbCambiarTurno.TabIndex = 2;
            rbCambiarTurno.TabStop = true;
            rbCambiarTurno.Text = "Cambiar Solo Turno";
            rbCambiarTurno.UseVisualStyleBackColor = true;
            rbCambiarTurno.Click += rbCambiarTurno_Click;
            // 
            // rbCambiarDeporte
            // 
            rbCambiarDeporte.Anchor = AnchorStyles.Left;
            rbCambiarDeporte.AutoSize = true;
            rbCambiarDeporte.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbCambiarDeporte.ForeColor = Color.White;
            rbCambiarDeporte.Location = new Point(3, 10);
            rbCambiarDeporte.Name = "rbCambiarDeporte";
            rbCambiarDeporte.Size = new Size(170, 29);
            rbCambiarDeporte.TabIndex = 0;
            rbCambiarDeporte.TabStop = true;
            rbCambiarDeporte.Text = "Cambiar Deporte";
            rbCambiarDeporte.UseVisualStyleBackColor = true;
            rbCambiarDeporte.Click += rbCambiarDeporte_Click;
            // 
            // rbCambiarCategoria
            // 
            rbCambiarCategoria.Anchor = AnchorStyles.Left;
            rbCambiarCategoria.AutoSize = true;
            rbCambiarCategoria.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbCambiarCategoria.ForeColor = Color.White;
            rbCambiarCategoria.Location = new Point(3, 60);
            rbCambiarCategoria.Name = "rbCambiarCategoria";
            rbCambiarCategoria.Size = new Size(223, 29);
            rbCambiarCategoria.TabIndex = 1;
            rbCambiarCategoria.TabStop = true;
            rbCambiarCategoria.Text = "Cambiar Solo Categoria";
            rbCambiarCategoria.UseVisualStyleBackColor = true;
            rbCambiarCategoria.Click += rbCambiarCategoria_Click;
            // 
            // tlpSeleccionDeporte
            // 
            tlpSeleccionDeporte.ColumnCount = 1;
            tlpSeleccionDeporte.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSeleccionDeporte.Controls.Add(grpSeleccionarDeporte, 0, 0);
            tlpSeleccionDeporte.Location = new Point(3, 209);
            tlpSeleccionDeporte.Name = "tlpSeleccionDeporte";
            tlpSeleccionDeporte.RowCount = 1;
            tlpSeleccionDeporte.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSeleccionDeporte.Size = new Size(340, 150);
            tlpSeleccionDeporte.TabIndex = 20;
            // 
            // grpSeleccionarDeporte
            // 
            grpSeleccionarDeporte.Anchor = AnchorStyles.None;
            grpSeleccionarDeporte.Controls.Add(tlpSeleccionarDeporte);
            grpSeleccionarDeporte.ForeColor = Color.White;
            grpSeleccionarDeporte.Location = new Point(20, 3);
            grpSeleccionarDeporte.Name = "grpSeleccionarDeporte";
            grpSeleccionarDeporte.Size = new Size(300, 144);
            grpSeleccionarDeporte.TabIndex = 0;
            grpSeleccionarDeporte.TabStop = false;
            grpSeleccionarDeporte.Text = "Seleccionar Deporte";
            // 
            // tlpSeleccionarDeporte
            // 
            tlpSeleccionarDeporte.ColumnCount = 1;
            tlpSeleccionarDeporte.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSeleccionarDeporte.Controls.Add(rbNatacion, 0, 1);
            tlpSeleccionarDeporte.Controls.Add(rbFutbol, 0, 0);
            tlpSeleccionarDeporte.Dock = DockStyle.Fill;
            tlpSeleccionarDeporte.Location = new Point(3, 27);
            tlpSeleccionarDeporte.Name = "tlpSeleccionarDeporte";
            tlpSeleccionarDeporte.RowCount = 2;
            tlpSeleccionarDeporte.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSeleccionarDeporte.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSeleccionarDeporte.Size = new Size(294, 114);
            tlpSeleccionarDeporte.TabIndex = 0;
            // 
            // rbNatacion
            // 
            rbNatacion.Anchor = AnchorStyles.Left;
            rbNatacion.AutoSize = true;
            rbNatacion.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbNatacion.ForeColor = Color.White;
            rbNatacion.Location = new Point(3, 71);
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
            rbFutbol.ForeColor = Color.White;
            rbFutbol.Location = new Point(3, 14);
            rbFutbol.Name = "rbFutbol";
            rbFutbol.Size = new Size(83, 29);
            rbFutbol.TabIndex = 0;
            rbFutbol.TabStop = true;
            rbFutbol.Text = "Futbol";
            rbFutbol.UseVisualStyleBackColor = true;
            rbFutbol.Click += rbFutbol_Click;
            // 
            // tlpSeleccionCategoria
            // 
            tlpSeleccionCategoria.ColumnCount = 1;
            tlpSeleccionCategoria.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSeleccionCategoria.Controls.Add(cmbCategoria, 0, 1);
            tlpSeleccionCategoria.Controls.Add(lblCategoria, 0, 0);
            tlpSeleccionCategoria.Location = new Point(3, 365);
            tlpSeleccionCategoria.Name = "tlpSeleccionCategoria";
            tlpSeleccionCategoria.RowCount = 2;
            tlpSeleccionCategoria.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpSeleccionCategoria.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpSeleccionCategoria.Size = new Size(340, 100);
            tlpSeleccionCategoria.TabIndex = 21;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Anchor = AnchorStyles.None;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategoria.ForeColor = Color.FromArgb(55, 55, 57);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(57, 58);
            cmbCategoria.Margin = new Padding(4, 3, 4, 3);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.RightToLeft = RightToLeft.No;
            cmbCategoria.Size = new Size(225, 33);
            cmbCategoria.TabIndex = 2;
            // 
            // lblCategoria
            // 
            lblCategoria.Anchor = AnchorStyles.None;
            lblCategoria.AutoSize = true;
            lblCategoria.ForeColor = Color.White;
            lblCategoria.Location = new Point(60, 10);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(219, 29);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Seleccionar Categoria";
            // 
            // tlpSeleccionTurno
            // 
            tlpSeleccionTurno.ColumnCount = 1;
            tlpSeleccionTurno.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSeleccionTurno.Controls.Add(cmbTurno, 0, 1);
            tlpSeleccionTurno.Controls.Add(lblTurno, 0, 0);
            tlpSeleccionTurno.Location = new Point(3, 471);
            tlpSeleccionTurno.Name = "tlpSeleccionTurno";
            tlpSeleccionTurno.RowCount = 2;
            tlpSeleccionTurno.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpSeleccionTurno.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpSeleccionTurno.Size = new Size(340, 100);
            tlpSeleccionTurno.TabIndex = 22;
            // 
            // cmbTurno
            // 
            cmbTurno.Anchor = AnchorStyles.None;
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTurno.ForeColor = Color.FromArgb(55, 55, 57);
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Location = new Point(57, 58);
            cmbTurno.Margin = new Padding(4, 3, 4, 3);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.RightToLeft = RightToLeft.No;
            cmbTurno.Size = new Size(225, 33);
            cmbTurno.TabIndex = 2;
            // 
            // lblTurno
            // 
            lblTurno.Anchor = AnchorStyles.None;
            lblTurno.AutoSize = true;
            lblTurno.ForeColor = Color.White;
            lblTurno.Location = new Point(79, 10);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(182, 29);
            lblTurno.TabIndex = 0;
            lblTurno.Text = "Seleccionar Turno";
            // 
            // lblMensaje
            // 
            lblMensaje.Anchor = AnchorStyles.None;
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(71, 574);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(203, 100);
            lblMensaje.TabIndex = 23;
            lblMensaje.Text = "*Se tendra en cuenta la\r\ncapacidad disponible\r\nen el turno y/o deporte\r\nseleccionado.";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpBotones
            // 
            tlpBotones.ColumnCount = 2;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBotones.Controls.Add(btnModificar, 0, 0);
            tlpBotones.Controls.Add(btnVolver, 1, 0);
            tlpBotones.Location = new Point(3, 677);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 1;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotones.Size = new Size(340, 78);
            tlpBotones.TabIndex = 24;
            // 
            // btnModificar
            // 
            btnModificar.Dock = DockStyle.Fill;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 44, 76);
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 35, 85);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(3, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(164, 72);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Dock = DockStyle.Fill;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 44, 76);
            btnVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 35, 85);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(173, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(164, 72);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // epModificar
            // 
            epModificar.ContainerControl = this;
            epModificar.Icon = (Icon)resources.GetObject("epModificar.Icon");
            // 
            // FrmMenuModificarDeportes
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(tlpMenuModificarDeportes);
            Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenuModificarDeportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AquaGoal";
            Load += FrmMenuModificarDeportes_Load;
            tlpMenuModificarDeportes.ResumeLayout(false);
            flpContenedorControles.ResumeLayout(false);
            flpContenedorControles.PerformLayout();
            tlpCambios.ResumeLayout(false);
            gpSeleccionarCambio.ResumeLayout(false);
            tlpSeleccionarCambios.ResumeLayout(false);
            tlpSeleccionarCambios.PerformLayout();
            tlpSeleccionDeporte.ResumeLayout(false);
            grpSeleccionarDeporte.ResumeLayout(false);
            tlpSeleccionarDeporte.ResumeLayout(false);
            tlpSeleccionarDeporte.PerformLayout();
            tlpSeleccionCategoria.ResumeLayout(false);
            tlpSeleccionCategoria.PerformLayout();
            tlpSeleccionTurno.ResumeLayout(false);
            tlpSeleccionTurno.PerformLayout();
            tlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)epModificar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMenuModificarDeportes;
        private ListBox lbPersonas;
        private FlowLayoutPanel flpContenedorControles;
        private ErrorProvider epModificar;
        private CheckBox cbDeporte;
        private CheckBox cbTurno;
        private TableLayoutPanel tlpCambios;
        private TableLayoutPanel tlpSeleccionarCambios;
        private RadioButton rbCambiarDeporte;
        private RadioButton rbCambiarTurno;
        private RadioButton rbCambiarCategoria;
        private GroupBox gpSeleccionarCambio;
        private GroupBox grpSeleccionarDeporte;
        private TableLayoutPanel tlpSeleccionDeporte;
        private TableLayoutPanel tlpSeleccionarDeporte;
        private RadioButton rbNatacion;
        private RadioButton rbFutbol;
        private TableLayoutPanel tlpSeleccionCategoria;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private TableLayoutPanel tlpSeleccionTurno;
        private ComboBox cmbTurno;
        private Label lblTurno;
        private TableLayoutPanel tlpBotones;
        private Button btnVolver;
        private Button btnModificar;
        private Label lblMensaje;
    }
}