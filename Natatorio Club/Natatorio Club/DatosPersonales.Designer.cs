namespace Natatorio_Club
{
    partial class Frm_datosPersonales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_datosPersonales));
            tlpMenu = new TableLayoutPanel();
            tlpContenedor = new TableLayoutPanel();
            btnCerrar = new Button();
            lbNadadores = new ListBox();
            tlpControles = new TableLayoutPanel();
            tlpSalir = new TableLayoutPanel();
            btnVolver = new Button();
            btnAceptar = new Button();
            tlpEditarDatos = new TableLayoutPanel();
            tlpNacimiento = new TableLayoutPanel();
            dtpNacimiento = new DateTimePicker();
            cbNacimiento = new CheckBox();
            tlpTelefono = new TableLayoutPanel();
            txtTelefono = new TextBox();
            cbTelefono = new CheckBox();
            tlpDni = new TableLayoutPanel();
            txtDni = new TextBox();
            cbDni = new CheckBox();
            tlpApellido = new TableLayoutPanel();
            txtApellido = new TextBox();
            cbApellido = new CheckBox();
            tlpNombre = new TableLayoutPanel();
            txtNombre = new TextBox();
            cbNombre = new CheckBox();
            epEditar = new ErrorProvider(components);
            tlpMenu.SuspendLayout();
            tlpContenedor.SuspendLayout();
            tlpControles.SuspendLayout();
            tlpSalir.SuspendLayout();
            tlpEditarDatos.SuspendLayout();
            tlpNacimiento.SuspendLayout();
            tlpTelefono.SuspendLayout();
            tlpDni.SuspendLayout();
            tlpApellido.SuspendLayout();
            tlpNombre.SuspendLayout();
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
            tlpContenedor.TabIndex = 5;
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
            tlpControles.TabIndex = 4;
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
            tlpEditarDatos.Controls.Add(tlpNacimiento, 0, 4);
            tlpEditarDatos.Controls.Add(tlpTelefono, 0, 3);
            tlpEditarDatos.Controls.Add(tlpDni, 0, 2);
            tlpEditarDatos.Controls.Add(tlpApellido, 0, 1);
            tlpEditarDatos.Controls.Add(tlpNombre, 0, 0);
            tlpEditarDatos.Location = new Point(3, 3);
            tlpEditarDatos.Name = "tlpEditarDatos";
            tlpEditarDatos.RowCount = 6;
            tlpEditarDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEditarDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEditarDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEditarDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEditarDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEditarDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpEditarDatos.Size = new Size(244, 636);
            tlpEditarDatos.TabIndex = 1;
            // 
            // tlpNacimiento
            // 
            tlpNacimiento.ColumnCount = 1;
            tlpNacimiento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNacimiento.Controls.Add(dtpNacimiento, 0, 1);
            tlpNacimiento.Controls.Add(cbNacimiento, 0, 0);
            tlpNacimiento.Location = new Point(3, 403);
            tlpNacimiento.Name = "tlpNacimiento";
            tlpNacimiento.RowCount = 2;
            tlpNacimiento.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpNacimiento.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpNacimiento.Size = new Size(238, 94);
            tlpNacimiento.TabIndex = 4;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Anchor = AnchorStyles.None;
            dtpNacimiento.CustomFormat = "dd / MMM / yyyy";
            dtpNacimiento.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNacimiento.Format = DateTimePickerFormat.Custom;
            dtpNacimiento.Location = new Point(3, 56);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(232, 28);
            dtpNacimiento.TabIndex = 10;
            // 
            // cbNacimiento
            // 
            cbNacimiento.Anchor = AnchorStyles.Left;
            cbNacimiento.AutoSize = true;
            cbNacimiento.FlatAppearance.BorderSize = 0;
            cbNacimiento.FlatStyle = FlatStyle.Flat;
            cbNacimiento.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbNacimiento.Location = new Point(3, 11);
            cbNacimiento.Name = "cbNacimiento";
            cbNacimiento.Size = new Size(228, 25);
            cbNacimiento.TabIndex = 0;
            cbNacimiento.Text = "Editar fecha nacimiento";
            cbNacimiento.UseVisualStyleBackColor = true;
            // 
            // tlpTelefono
            // 
            tlpTelefono.ColumnCount = 1;
            tlpTelefono.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTelefono.Controls.Add(txtTelefono, 0, 1);
            tlpTelefono.Controls.Add(cbTelefono, 0, 0);
            tlpTelefono.Location = new Point(3, 303);
            tlpTelefono.Name = "tlpTelefono";
            tlpTelefono.RowCount = 2;
            tlpTelefono.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTelefono.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTelefono.Size = new Size(238, 94);
            tlpTelefono.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(3, 60);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingresar telefono";
            txtTelefono.Size = new Size(232, 21);
            txtTelefono.TabIndex = 6;
            // 
            // cbTelefono
            // 
            cbTelefono.Anchor = AnchorStyles.Left;
            cbTelefono.AutoSize = true;
            cbTelefono.FlatAppearance.BorderSize = 0;
            cbTelefono.FlatStyle = FlatStyle.Flat;
            cbTelefono.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbTelefono.Location = new Point(3, 11);
            cbTelefono.Name = "cbTelefono";
            cbTelefono.Size = new Size(150, 25);
            cbTelefono.TabIndex = 0;
            cbTelefono.Text = "Editar telefono";
            cbTelefono.UseVisualStyleBackColor = true;
            // 
            // tlpDni
            // 
            tlpDni.ColumnCount = 1;
            tlpDni.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDni.Controls.Add(txtDni, 0, 1);
            tlpDni.Controls.Add(cbDni, 0, 0);
            tlpDni.Location = new Point(3, 203);
            tlpDni.Name = "tlpDni";
            tlpDni.RowCount = 2;
            tlpDni.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDni.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDni.Size = new Size(238, 94);
            tlpDni.TabIndex = 2;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
            txtDni.BorderStyle = BorderStyle.None;
            txtDni.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(3, 60);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingresar DNI";
            txtDni.Size = new Size(232, 21);
            txtDni.TabIndex = 6;
            // 
            // cbDni
            // 
            cbDni.Anchor = AnchorStyles.Left;
            cbDni.AutoSize = true;
            cbDni.FlatAppearance.BorderSize = 0;
            cbDni.FlatStyle = FlatStyle.Flat;
            cbDni.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbDni.Location = new Point(3, 11);
            cbDni.Name = "cbDni";
            cbDni.Size = new Size(112, 25);
            cbDni.TabIndex = 0;
            cbDni.Text = "Editar DNI";
            cbDni.UseVisualStyleBackColor = true;
            // 
            // tlpApellido
            // 
            tlpApellido.ColumnCount = 1;
            tlpApellido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpApellido.Controls.Add(txtApellido, 0, 1);
            tlpApellido.Controls.Add(cbApellido, 0, 0);
            tlpApellido.Location = new Point(3, 103);
            tlpApellido.Name = "tlpApellido";
            tlpApellido.RowCount = 2;
            tlpApellido.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpApellido.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpApellido.Size = new Size(238, 94);
            tlpApellido.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(3, 60);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingresar apellido";
            txtApellido.Size = new Size(232, 21);
            txtApellido.TabIndex = 6;
            // 
            // cbApellido
            // 
            cbApellido.Anchor = AnchorStyles.Left;
            cbApellido.AutoSize = true;
            cbApellido.FlatAppearance.BorderSize = 0;
            cbApellido.FlatStyle = FlatStyle.Flat;
            cbApellido.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbApellido.Location = new Point(3, 11);
            cbApellido.Name = "cbApellido";
            cbApellido.Size = new Size(149, 25);
            cbApellido.TabIndex = 0;
            cbApellido.Text = "Editar Apellido";
            cbApellido.UseVisualStyleBackColor = true;
            // 
            // tlpNombre
            // 
            tlpNombre.ColumnCount = 1;
            tlpNombre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNombre.Controls.Add(txtNombre, 0, 1);
            tlpNombre.Controls.Add(cbNombre, 0, 0);
            tlpNombre.Location = new Point(3, 3);
            tlpNombre.Name = "tlpNombre";
            tlpNombre.RowCount = 2;
            tlpNombre.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpNombre.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpNombre.Size = new Size(238, 94);
            tlpNombre.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(3, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingresar nombre";
            txtNombre.Size = new Size(232, 21);
            txtNombre.TabIndex = 6;
            // 
            // cbNombre
            // 
            cbNombre.Anchor = AnchorStyles.Left;
            cbNombre.AutoSize = true;
            cbNombre.FlatAppearance.BorderSize = 0;
            cbNombre.FlatStyle = FlatStyle.Flat;
            cbNombre.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbNombre.Location = new Point(3, 11);
            cbNombre.Name = "cbNombre";
            cbNombre.Size = new Size(148, 25);
            cbNombre.TabIndex = 0;
            cbNombre.Text = "Editar Nombre";
            cbNombre.UseVisualStyleBackColor = true;
            // 
            // epEditar
            // 
            epEditar.ContainerControl = this;
            epEditar.Icon = (Icon)resources.GetObject("epEditar.Icon");
            // 
            // Frm_datosPersonales
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
            Name = "Frm_datosPersonales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Natatorio Club";
            Load += Frm_datosPersonales_Load;
            tlpMenu.ResumeLayout(false);
            tlpContenedor.ResumeLayout(false);
            tlpControles.ResumeLayout(false);
            tlpSalir.ResumeLayout(false);
            tlpEditarDatos.ResumeLayout(false);
            tlpNacimiento.ResumeLayout(false);
            tlpNacimiento.PerformLayout();
            tlpTelefono.ResumeLayout(false);
            tlpTelefono.PerformLayout();
            tlpDni.ResumeLayout(false);
            tlpDni.PerformLayout();
            tlpApellido.ResumeLayout(false);
            tlpApellido.PerformLayout();
            tlpNombre.ResumeLayout(false);
            tlpNombre.PerformLayout();
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
        private TableLayoutPanel tlpNombre;
        private CheckBox cbNombre;
        private TextBox txtNombre;
        private TableLayoutPanel tlpNacimiento;
        private CheckBox cbNacimiento;
        private TableLayoutPanel tlpTelefono;
        private TextBox txtTelefono;
        private CheckBox cbTelefono;
        private TableLayoutPanel tlpDni;
        private TextBox txtDni;
        private CheckBox cbDni;
        private TableLayoutPanel tlpApellido;
        private TextBox txtApellido;
        private CheckBox cbApellido;
        private DateTimePicker dtpNacimiento;
        private ErrorProvider epEditar;
    }
}