namespace Natatorio_Club
{
    partial class Frm_deporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_deporte));
            tlpMenu = new TableLayoutPanel();
            tlpContenedor = new TableLayoutPanel();
            btnCerrar = new Button();
            lbNadadores = new ListBox();
            tlpControles = new TableLayoutPanel();
            tlpSalir = new TableLayoutPanel();
            btnVolver = new Button();
            btnAceptar = new Button();
            tlpEditarDatos = new TableLayoutPanel();
            gpSeleccionarCambios = new GroupBox();
            tlpCambios = new TableLayoutPanel();
            rbTurno = new RadioButton();
            rbNivel = new RadioButton();
            tlpNivel = new TableLayoutPanel();
            cmbNivel = new ComboBox();
            lblNivel = new Label();
            tlpTurno = new TableLayoutPanel();
            lblTurno = new Label();
            cmbTurno = new ComboBox();
            lblMensaje = new Label();
            epEditar = new ErrorProvider(components);
            tlpMenu.SuspendLayout();
            tlpContenedor.SuspendLayout();
            tlpControles.SuspendLayout();
            tlpSalir.SuspendLayout();
            tlpEditarDatos.SuspendLayout();
            gpSeleccionarCambios.SuspendLayout();
            tlpCambios.SuspendLayout();
            tlpNivel.SuspendLayout();
            tlpTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epEditar).BeginInit();
            SuspendLayout();
            // 
            // tlpMenu
            // 
            tlpMenu.BackColor = Color.FromArgb(26, 26, 39);
            tlpMenu.ColumnCount = 2;
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpMenu.Controls.Add(tlpContenedor, 0, 0);
            tlpMenu.Controls.Add(tlpControles, 0, 0);
            tlpMenu.Dock = DockStyle.Fill;
            tlpMenu.Location = new Point(0, 0);
            tlpMenu.Name = "tlpMenu";
            tlpMenu.RowCount = 1;
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMenu.Size = new Size(1280, 720);
            tlpMenu.TabIndex = 1;
            // 
            // tlpContenedor
            // 
            tlpContenedor.BackColor = Color.FromArgb(43, 46, 74);
            tlpContenedor.ColumnCount = 1;
            tlpContenedor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContenedor.Controls.Add(btnCerrar, 0, 0);
            tlpContenedor.Controls.Add(lbNadadores, 0, 1);
            tlpContenedor.Dock = DockStyle.Fill;
            tlpContenedor.Location = new Point(259, 3);
            tlpContenedor.Name = "tlpContenedor";
            tlpContenedor.RowCount = 2;
            tlpContenedor.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlpContenedor.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            tlpContenedor.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContenedor.Size = new Size(1018, 714);
            tlpContenedor.TabIndex = 6;
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
            btnCerrar.TabIndex = 4;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lbNadadores
            // 
            lbNadadores.BackColor = Color.FromArgb(43, 46, 74);
            lbNadadores.BorderStyle = BorderStyle.None;
            lbNadadores.Dock = DockStyle.Fill;
            lbNadadores.ForeColor = Color.White;
            lbNadadores.FormattingEnabled = true;
            lbNadadores.HorizontalScrollbar = true;
            lbNadadores.ItemHeight = 23;
            lbNadadores.Location = new Point(3, 38);
            lbNadadores.Name = "lbNadadores";
            lbNadadores.Size = new Size(1012, 673);
            lbNadadores.TabIndex = 5;
            // 
            // tlpControles
            // 
            tlpControles.ColumnCount = 1;
            tlpControles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpControles.Controls.Add(tlpSalir, 0, 1);
            tlpControles.Controls.Add(tlpEditarDatos, 0, 0);
            tlpControles.Dock = DockStyle.Fill;
            tlpControles.Location = new Point(3, 3);
            tlpControles.Name = "tlpControles";
            tlpControles.RowCount = 2;
            tlpControles.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tlpControles.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpControles.Size = new Size(250, 714);
            tlpControles.TabIndex = 3;
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
            // tlpEditarDatos
            // 
            tlpEditarDatos.ColumnCount = 1;
            tlpEditarDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpEditarDatos.Controls.Add(gpSeleccionarCambios, 0, 0);
            tlpEditarDatos.Controls.Add(tlpNivel, 0, 1);
            tlpEditarDatos.Controls.Add(tlpTurno, 0, 2);
            tlpEditarDatos.Controls.Add(lblMensaje, 0, 3);
            tlpEditarDatos.Location = new Point(3, 3);
            tlpEditarDatos.Name = "tlpEditarDatos";
            tlpEditarDatos.RowCount = 4;
            tlpEditarDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tlpEditarDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEditarDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEditarDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEditarDatos.Size = new Size(244, 636);
            tlpEditarDatos.TabIndex = 1;
            // 
            // gpSeleccionarCambios
            // 
            gpSeleccionarCambios.BackColor = Color.Transparent;
            gpSeleccionarCambios.Controls.Add(tlpCambios);
            gpSeleccionarCambios.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gpSeleccionarCambios.ForeColor = Color.White;
            gpSeleccionarCambios.Location = new Point(3, 3);
            gpSeleccionarCambios.Name = "gpSeleccionarCambios";
            gpSeleccionarCambios.Size = new Size(238, 125);
            gpSeleccionarCambios.TabIndex = 0;
            gpSeleccionarCambios.TabStop = false;
            gpSeleccionarCambios.Text = "Seleccionar Cambios";
            // 
            // tlpCambios
            // 
            tlpCambios.ColumnCount = 1;
            tlpCambios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCambios.Controls.Add(rbTurno, 0, 1);
            tlpCambios.Controls.Add(rbNivel, 0, 0);
            tlpCambios.Dock = DockStyle.Fill;
            tlpCambios.Location = new Point(3, 24);
            tlpCambios.Name = "tlpCambios";
            tlpCambios.RowCount = 2;
            tlpCambios.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCambios.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCambios.Size = new Size(232, 98);
            tlpCambios.TabIndex = 0;
            // 
            // rbTurno
            // 
            rbTurno.Anchor = AnchorStyles.Left;
            rbTurno.AutoSize = true;
            rbTurno.Location = new Point(3, 61);
            rbTurno.Name = "rbTurno";
            rbTurno.Size = new Size(128, 25);
            rbTurno.TabIndex = 1;
            rbTurno.TabStop = true;
            rbTurno.Text = "Editar Turno";
            rbTurno.UseVisualStyleBackColor = true;
            // 
            // rbNivel
            // 
            rbNivel.Anchor = AnchorStyles.Left;
            rbNivel.AutoSize = true;
            rbNivel.Location = new Point(3, 12);
            rbNivel.Name = "rbNivel";
            rbNivel.Size = new Size(125, 25);
            rbNivel.TabIndex = 0;
            rbNivel.TabStop = true;
            rbNivel.Text = "Editar Nivel";
            rbNivel.UseVisualStyleBackColor = true;
            // 
            // tlpNivel
            // 
            tlpNivel.ColumnCount = 1;
            tlpNivel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNivel.Controls.Add(cmbNivel, 0, 1);
            tlpNivel.Controls.Add(lblNivel, 0, 0);
            tlpNivel.Location = new Point(3, 153);
            tlpNivel.Name = "tlpNivel";
            tlpNivel.RowCount = 2;
            tlpNivel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpNivel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpNivel.Size = new Size(238, 94);
            tlpNivel.TabIndex = 1;
            // 
            // cmbNivel
            // 
            cmbNivel.Anchor = AnchorStyles.None;
            cmbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivel.FlatStyle = FlatStyle.Flat;
            cmbNivel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(3, 56);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(232, 29);
            cmbNivel.TabIndex = 9;
            // 
            // lblNivel
            // 
            lblNivel.Anchor = AnchorStyles.None;
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNivel.Location = new Point(91, 13);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(56, 21);
            lblNivel.TabIndex = 7;
            lblNivel.Text = "Nivel:";
            // 
            // tlpTurno
            // 
            tlpTurno.ColumnCount = 1;
            tlpTurno.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTurno.Controls.Add(lblTurno, 0, 0);
            tlpTurno.Controls.Add(cmbTurno, 0, 1);
            tlpTurno.Location = new Point(3, 253);
            tlpTurno.Name = "tlpTurno";
            tlpTurno.RowCount = 2;
            tlpTurno.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTurno.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTurno.Size = new Size(238, 94);
            tlpTurno.TabIndex = 2;
            // 
            // lblTurno
            // 
            lblTurno.Anchor = AnchorStyles.None;
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTurno.Location = new Point(89, 13);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(59, 21);
            lblTurno.TabIndex = 6;
            lblTurno.Text = "Turno:";
            // 
            // cmbTurno
            // 
            cmbTurno.Anchor = AnchorStyles.None;
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.FlatStyle = FlatStyle.Flat;
            cmbTurno.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Location = new Point(3, 56);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(232, 29);
            cmbTurno.TabIndex = 8;
            // 
            // lblMensaje
            // 
            lblMensaje.Anchor = AnchorStyles.None;
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje.Location = new Point(33, 451);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(177, 84);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "*Se tiene en cuenta\r\nla capacidad \r\ndisponible en el \r\nturno seleccionado*";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // epEditar
            // 
            epEditar.ContainerControl = this;
            epEditar.Icon = (Icon)resources.GetObject("epEditar.Icon");
            // 
            // Frm_deporte
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 46, 74);
            ClientSize = new Size(1280, 720);
            Controls.Add(tlpMenu);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Frm_deporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Natatorio Club";
            Load += Frm_deporte_Load;
            tlpMenu.ResumeLayout(false);
            tlpContenedor.ResumeLayout(false);
            tlpControles.ResumeLayout(false);
            tlpSalir.ResumeLayout(false);
            tlpEditarDatos.ResumeLayout(false);
            tlpEditarDatos.PerformLayout();
            gpSeleccionarCambios.ResumeLayout(false);
            tlpCambios.ResumeLayout(false);
            tlpCambios.PerformLayout();
            tlpNivel.ResumeLayout(false);
            tlpNivel.PerformLayout();
            tlpTurno.ResumeLayout(false);
            tlpTurno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epEditar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tlpMenu;
        private TableLayoutPanel tlpControles;
        private TableLayoutPanel tlpSalir;
        private Button btnVolver;
        private Button btnAceptar;
        private TableLayoutPanel tlpContenedor;
        private Button btnCerrar;
        private ListBox lbNadadores;
        private TableLayoutPanel tlpEditarDatos;
        private GroupBox gpSeleccionarCambios;
        private TableLayoutPanel tlpCambios;
        private RadioButton rbTurno;
        private RadioButton rbNivel;
        private TableLayoutPanel tlpNivel;
        private TableLayoutPanel tlpTurno;
        private Label lblMensaje;
        private Label lblTurno;
        private ComboBox cmbTurno;
        private Label lblNivel;
        private ComboBox cmbNivel;
        private ErrorProvider epEditar;
    }
}