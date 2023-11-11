namespace Integrador_Nro_2
{
    partial class FrmMenuModificarDatosPersonales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuModificarDatosPersonales));
            epModificar = new ErrorProvider(components);
            btnVolver = new Button();
            tlpBotones = new TableLayoutPanel();
            btnModificar = new Button();
            cbFechaNacimiento = new CheckBox();
            dtpFechaNacimiento = new DateTimePicker();
            tlpFechaNacimiento = new TableLayoutPanel();
            cbCelular = new CheckBox();
            txtCelular = new TextBox();
            tlpCelular = new TableLayoutPanel();
            cbDni = new CheckBox();
            txtDni = new TextBox();
            cbApellido = new CheckBox();
            txtApellido = new TextBox();
            tlpApellido = new TableLayoutPanel();
            txtNombre = new TextBox();
            cbNombre = new CheckBox();
            tlpNombre = new TableLayoutPanel();
            lbPersonas = new ListBox();
            flpContenedorBotones = new FlowLayoutPanel();
            tlpDni = new TableLayoutPanel();
            tlpMenuModificarDatosPersonales = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)epModificar).BeginInit();
            tlpBotones.SuspendLayout();
            tlpFechaNacimiento.SuspendLayout();
            tlpCelular.SuspendLayout();
            tlpApellido.SuspendLayout();
            tlpNombre.SuspendLayout();
            flpContenedorBotones.SuspendLayout();
            tlpDni.SuspendLayout();
            tlpMenuModificarDatosPersonales.SuspendLayout();
            SuspendLayout();
            // 
            // epModificar
            // 
            epModificar.ContainerControl = this;
            epModificar.Icon = (Icon)resources.GetObject("epModificar.Icon");
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
            btnVolver.Location = new Point(175, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(166, 119);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // tlpBotones
            // 
            tlpBotones.ColumnCount = 2;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBotones.Controls.Add(btnVolver, 1, 0);
            tlpBotones.Controls.Add(btnModificar, 0, 0);
            tlpBotones.Dock = DockStyle.Fill;
            tlpBotones.Location = new Point(3, 628);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 1;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBotones.Size = new Size(344, 125);
            tlpBotones.TabIndex = 11;
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
            btnModificar.Size = new Size(166, 119);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // cbFechaNacimiento
            // 
            cbFechaNacimiento.Anchor = AnchorStyles.Left;
            cbFechaNacimiento.AutoSize = true;
            cbFechaNacimiento.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbFechaNacimiento.ForeColor = Color.White;
            cbFechaNacimiento.Location = new Point(3, 13);
            cbFechaNacimiento.Name = "cbFechaNacimiento";
            cbFechaNacimiento.Size = new Size(287, 33);
            cbFechaNacimiento.TabIndex = 2;
            cbFechaNacimiento.Text = "Cambiar Fecha Nacimiento";
            cbFechaNacimiento.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Anchor = AnchorStyles.None;
            dtpFechaNacimiento.CalendarForeColor = Color.FromArgb(55, 55, 57);
            dtpFechaNacimiento.CalendarTitleForeColor = Color.FromArgb(55, 55, 57);
            dtpFechaNacimiento.CustomFormat = "dd/MMM/yyyy";
            dtpFechaNacimiento.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.Location = new Point(58, 75);
            dtpFechaNacimiento.Margin = new Padding(4, 3, 4, 3);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(225, 27);
            dtpFechaNacimiento.TabIndex = 1;
            // 
            // tlpFechaNacimiento
            // 
            tlpFechaNacimiento.ColumnCount = 1;
            tlpFechaNacimiento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFechaNacimiento.Controls.Add(cbFechaNacimiento, 0, 0);
            tlpFechaNacimiento.Controls.Add(dtpFechaNacimiento, 0, 1);
            tlpFechaNacimiento.Location = new Point(4, 503);
            tlpFechaNacimiento.Margin = new Padding(4, 3, 4, 3);
            tlpFechaNacimiento.Name = "tlpFechaNacimiento";
            tlpFechaNacimiento.RowCount = 2;
            tlpFechaNacimiento.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFechaNacimiento.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFechaNacimiento.Size = new Size(342, 119);
            tlpFechaNacimiento.TabIndex = 10;
            // 
            // cbCelular
            // 
            cbCelular.Anchor = AnchorStyles.Left;
            cbCelular.AutoSize = true;
            cbCelular.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCelular.ForeColor = Color.White;
            cbCelular.Location = new Point(3, 13);
            cbCelular.Name = "cbCelular";
            cbCelular.Size = new Size(185, 33);
            cbCelular.TabIndex = 2;
            cbCelular.Text = "Cambiar Celular";
            cbCelular.UseVisualStyleBackColor = true;
            // 
            // txtCelular
            // 
            txtCelular.Anchor = AnchorStyles.None;
            txtCelular.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelular.ForeColor = Color.FromArgb(55, 55, 57);
            txtCelular.Location = new Point(57, 75);
            txtCelular.Margin = new Padding(4, 3, 4, 3);
            txtCelular.Name = "txtCelular";
            txtCelular.PlaceholderText = "Ingresar celular";
            txtCelular.Size = new Size(225, 27);
            txtCelular.TabIndex = 1;
            // 
            // tlpCelular
            // 
            tlpCelular.ColumnCount = 1;
            tlpCelular.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCelular.Controls.Add(cbCelular, 0, 0);
            tlpCelular.Controls.Add(txtCelular, 0, 1);
            tlpCelular.Location = new Point(4, 378);
            tlpCelular.Margin = new Padding(4, 3, 4, 3);
            tlpCelular.Name = "tlpCelular";
            tlpCelular.RowCount = 2;
            tlpCelular.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCelular.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCelular.Size = new Size(340, 119);
            tlpCelular.TabIndex = 7;
            // 
            // cbDni
            // 
            cbDni.Anchor = AnchorStyles.Left;
            cbDni.AutoSize = true;
            cbDni.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbDni.ForeColor = Color.White;
            cbDni.Location = new Point(3, 13);
            cbDni.Name = "cbDni";
            cbDni.Size = new Size(153, 33);
            cbDni.TabIndex = 2;
            cbDni.Text = "Cambiar DNI";
            cbDni.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
            txtDni.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.ForeColor = Color.FromArgb(55, 55, 57);
            txtDni.Location = new Point(57, 75);
            txtDni.Margin = new Padding(4, 3, 4, 3);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingresar DNI";
            txtDni.Size = new Size(225, 27);
            txtDni.TabIndex = 1;
            // 
            // cbApellido
            // 
            cbApellido.Anchor = AnchorStyles.Left;
            cbApellido.AutoSize = true;
            cbApellido.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbApellido.ForeColor = Color.White;
            cbApellido.Location = new Point(3, 13);
            cbApellido.Name = "cbApellido";
            cbApellido.Size = new Size(195, 33);
            cbApellido.TabIndex = 2;
            cbApellido.Text = "Cambiar Apellido";
            cbApellido.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.ForeColor = Color.FromArgb(55, 55, 57);
            txtApellido.Location = new Point(57, 75);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingresar apellido";
            txtApellido.Size = new Size(225, 27);
            txtApellido.TabIndex = 1;
            // 
            // tlpApellido
            // 
            tlpApellido.ColumnCount = 1;
            tlpApellido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpApellido.Controls.Add(cbApellido, 0, 0);
            tlpApellido.Controls.Add(txtApellido, 0, 1);
            tlpApellido.Location = new Point(4, 128);
            tlpApellido.Margin = new Padding(4, 3, 4, 3);
            tlpApellido.Name = "tlpApellido";
            tlpApellido.RowCount = 2;
            tlpApellido.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpApellido.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpApellido.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpApellido.Size = new Size(340, 119);
            tlpApellido.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.FromArgb(55, 55, 57);
            txtNombre.Location = new Point(57, 75);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingresar nombre";
            txtNombre.Size = new Size(225, 27);
            txtNombre.TabIndex = 1;
            // 
            // cbNombre
            // 
            cbNombre.Anchor = AnchorStyles.Left;
            cbNombre.AutoSize = true;
            cbNombre.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbNombre.ForeColor = Color.White;
            cbNombre.Location = new Point(3, 13);
            cbNombre.Name = "cbNombre";
            cbNombre.Size = new Size(193, 33);
            cbNombre.TabIndex = 1;
            cbNombre.Text = "Cambiar Nombre";
            cbNombre.UseVisualStyleBackColor = true;
            // 
            // tlpNombre
            // 
            tlpNombre.ColumnCount = 1;
            tlpNombre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNombre.Controls.Add(txtNombre, 0, 1);
            tlpNombre.Controls.Add(cbNombre, 0, 0);
            tlpNombre.Location = new Point(4, 3);
            tlpNombre.Margin = new Padding(4, 3, 4, 3);
            tlpNombre.Name = "tlpNombre";
            tlpNombre.RowCount = 2;
            tlpNombre.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpNombre.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpNombre.Size = new Size(340, 119);
            tlpNombre.TabIndex = 5;
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
            // flpContenedorBotones
            // 
            flpContenedorBotones.BackColor = Color.FromArgb(52, 55, 95);
            flpContenedorBotones.BorderStyle = BorderStyle.Fixed3D;
            flpContenedorBotones.Controls.Add(tlpNombre);
            flpContenedorBotones.Controls.Add(tlpApellido);
            flpContenedorBotones.Controls.Add(tlpDni);
            flpContenedorBotones.Controls.Add(tlpCelular);
            flpContenedorBotones.Controls.Add(tlpFechaNacimiento);
            flpContenedorBotones.Controls.Add(tlpBotones);
            flpContenedorBotones.Dock = DockStyle.Fill;
            flpContenedorBotones.FlowDirection = FlowDirection.TopDown;
            flpContenedorBotones.Location = new Point(3, 3);
            flpContenedorBotones.Name = "flpContenedorBotones";
            flpContenedorBotones.Size = new Size(344, 762);
            flpContenedorBotones.TabIndex = 0;
            // 
            // tlpDni
            // 
            tlpDni.ColumnCount = 1;
            tlpDni.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDni.Controls.Add(cbDni, 0, 0);
            tlpDni.Controls.Add(txtDni, 0, 1);
            tlpDni.Location = new Point(4, 253);
            tlpDni.Margin = new Padding(4, 3, 4, 3);
            tlpDni.Name = "tlpDni";
            tlpDni.RowCount = 2;
            tlpDni.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDni.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDni.Size = new Size(340, 119);
            tlpDni.TabIndex = 8;
            // 
            // tlpMenuModificarDatosPersonales
            // 
            tlpMenuModificarDatosPersonales.BackColor = Color.FromArgb(37, 40, 80);
            tlpMenuModificarDatosPersonales.ColumnCount = 2;
            tlpMenuModificarDatosPersonales.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tlpMenuModificarDatosPersonales.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMenuModificarDatosPersonales.Controls.Add(lbPersonas, 0, 0);
            tlpMenuModificarDatosPersonales.Controls.Add(flpContenedorBotones, 0, 0);
            tlpMenuModificarDatosPersonales.Dock = DockStyle.Fill;
            tlpMenuModificarDatosPersonales.Location = new Point(0, 0);
            tlpMenuModificarDatosPersonales.Name = "tlpMenuModificarDatosPersonales";
            tlpMenuModificarDatosPersonales.RowCount = 1;
            tlpMenuModificarDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMenuModificarDatosPersonales.Size = new Size(1024, 768);
            tlpMenuModificarDatosPersonales.TabIndex = 2;
            // 
            // FrmMenuModificarDatosPersonales
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(tlpMenuModificarDatosPersonales);
            Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenuModificarDatosPersonales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AquaGoal";
            Load += FrmMenuModificarDatosPersonales_Load;
            ((System.ComponentModel.ISupportInitialize)epModificar).EndInit();
            tlpBotones.ResumeLayout(false);
            tlpFechaNacimiento.ResumeLayout(false);
            tlpFechaNacimiento.PerformLayout();
            tlpCelular.ResumeLayout(false);
            tlpCelular.PerformLayout();
            tlpApellido.ResumeLayout(false);
            tlpApellido.PerformLayout();
            tlpNombre.ResumeLayout(false);
            tlpNombre.PerformLayout();
            flpContenedorBotones.ResumeLayout(false);
            tlpDni.ResumeLayout(false);
            tlpDni.PerformLayout();
            tlpMenuModificarDatosPersonales.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ErrorProvider epModificar;
        private TableLayoutPanel tlpMenuModificarDatosPersonales;
        private ListBox lbPersonas;
        private FlowLayoutPanel flpContenedorBotones;
        private TableLayoutPanel tlpNombre;
        private TextBox txtNombre;
        private CheckBox cbNombre;
        private TableLayoutPanel tlpApellido;
        private CheckBox cbApellido;
        private TextBox txtApellido;
        private TableLayoutPanel tlpDni;
        private CheckBox cbDni;
        private TextBox txtDni;
        private TableLayoutPanel tlpCelular;
        private CheckBox cbCelular;
        private TextBox txtCelular;
        private TableLayoutPanel tlpFechaNacimiento;
        private CheckBox cbFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private TableLayoutPanel tlpBotones;
        private Button btnVolver;
        private Button btnModificar;
    }
}