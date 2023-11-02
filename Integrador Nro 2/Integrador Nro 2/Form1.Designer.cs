namespace Integrador_Nro_2
{
    partial class FrmMenuAlta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuAlta));
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblCelular = new Label();
            lblFechaNacimiento = new Label();
            btnAlta = new Button();
            btnCancelar = new Button();
            lblHorario = new Label();
            gbDeporte = new GroupBox();
            rbNatacion = new RadioButton();
            rbFutbol = new RadioButton();
            lblEspecialidad = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtCelular = new TextBox();
            cmbHorario = new ComboBox();
            dtpFechaNacimiento = new DateTimePicker();
            cmbEspecialidad = new ComboBox();
            gbDeporte.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(100, 100);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(76, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.White;
            lblApellido.Location = new Point(100, 175);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(76, 25);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.Transparent;
            lblDni.Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.ForeColor = Color.White;
            lblDni.Location = new Point(100, 250);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(41, 25);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.BackColor = Color.Transparent;
            lblCelular.Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCelular.ForeColor = Color.White;
            lblCelular.Location = new Point(100, 325);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(68, 25);
            lblCelular.TabIndex = 3;
            lblCelular.Text = "Celular";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.BackColor = Color.Transparent;
            lblFechaNacimiento.Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNacimiento.ForeColor = Color.White;
            lblFechaNacimiento.Location = new Point(100, 475);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(178, 25);
            lblFechaNacimiento.TabIndex = 4;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // btnAlta
            // 
            btnAlta.Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlta.Location = new Point(100, 600);
            btnAlta.Margin = new Padding(3, 4, 3, 4);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(104, 36);
            btnAlta.TabIndex = 5;
            btnAlta.Text = "Aceptar";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(297, 600);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 36);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.BackColor = Color.Transparent;
            lblHorario.Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblHorario.ForeColor = Color.White;
            lblHorario.Location = new Point(100, 400);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(71, 25);
            lblHorario.TabIndex = 7;
            lblHorario.Text = "Horario";
            // 
            // gbDeporte
            // 
            gbDeporte.BackColor = Color.Transparent;
            gbDeporte.Controls.Add(rbNatacion);
            gbDeporte.Controls.Add(rbFutbol);
            gbDeporte.Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbDeporte.ForeColor = Color.White;
            gbDeporte.Location = new Point(512, 100);
            gbDeporte.Margin = new Padding(3, 4, 3, 4);
            gbDeporte.Name = "gbDeporte";
            gbDeporte.Padding = new Padding(3, 4, 3, 4);
            gbDeporte.Size = new Size(400, 259);
            gbDeporte.TabIndex = 8;
            gbDeporte.TabStop = false;
            gbDeporte.Text = "Seleccionar deporte";
            // 
            // rbNatacion
            // 
            rbNatacion.AutoSize = true;
            rbNatacion.FlatAppearance.CheckedBackColor = Color.Black;
            rbNatacion.Location = new Point(47, 150);
            rbNatacion.Name = "rbNatacion";
            rbNatacion.Size = new Size(105, 29);
            rbNatacion.TabIndex = 14;
            rbNatacion.Text = "Natacion";
            rbNatacion.UseVisualStyleBackColor = true;
            rbNatacion.MouseClick += rbNatacion_MouseClick;
            // 
            // rbFutbol
            // 
            rbFutbol.AutoSize = true;
            rbFutbol.FlatAppearance.CheckedBackColor = Color.Black;
            rbFutbol.Location = new Point(47, 75);
            rbFutbol.Name = "rbFutbol";
            rbFutbol.Size = new Size(83, 29);
            rbFutbol.TabIndex = 13;
            rbFutbol.Text = "Futbol";
            rbFutbol.UseVisualStyleBackColor = true;
            rbFutbol.MouseClick += rbFutbol_MouseClick;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.BackColor = Color.Transparent;
            lblEspecialidad.Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEspecialidad.ForeColor = Color.White;
            lblEspecialidad.Location = new Point(512, 400);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(113, 25);
            lblEspecialidad.TabIndex = 9;
            lblEspecialidad.Text = "Especialidad";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(100, 129);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingresar nombre";
            txtNombre.Size = new Size(301, 28);
            txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(100, 204);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingresar apellido";
            txtApellido.Size = new Size(301, 28);
            txtApellido.TabIndex = 11;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(100, 279);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingresar DNI";
            txtDni.Size = new Size(301, 28);
            txtDni.TabIndex = 12;
            // 
            // txtCelular
            // 
            txtCelular.Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelular.Location = new Point(100, 354);
            txtCelular.Margin = new Padding(3, 4, 3, 4);
            txtCelular.Name = "txtCelular";
            txtCelular.PlaceholderText = "Ingresar celular";
            txtCelular.Size = new Size(301, 28);
            txtCelular.TabIndex = 13;
            // 
            // cmbHorario
            // 
            cmbHorario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHorario.Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbHorario.FormattingEnabled = true;
            cmbHorario.Location = new Point(100, 429);
            cmbHorario.Margin = new Padding(3, 4, 3, 4);
            cmbHorario.Name = "cmbHorario";
            cmbHorario.Size = new Size(301, 33);
            cmbHorario.TabIndex = 14;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CustomFormat = "dd/MMMM/yyyy";
            dtpFechaNacimiento.Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.Location = new Point(100, 504);
            dtpFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(301, 28);
            dtpFechaNacimiento.TabIndex = 15;
            dtpFechaNacimiento.Value = new DateTime(2023, 11, 1, 19, 56, 12, 0);
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(512, 429);
            cmbEspecialidad.Margin = new Padding(3, 4, 3, 4);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(301, 33);
            cmbEspecialidad.TabIndex = 16;
            // 
            // FrmMenuAlta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1024, 768);
            ControlBox = false;
            Controls.Add(cmbEspecialidad);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(cmbHorario);
            Controls.Add(txtCelular);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblEspecialidad);
            Controls.Add(gbDeporte);
            Controls.Add(lblHorario);
            Controls.Add(btnCancelar);
            Controls.Add(btnAlta);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblCelular);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenuAlta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Polideportivo UTN";
            Load += FrmMenuAlta_Load;
            gbDeporte.ResumeLayout(false);
            gbDeporte.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblCelular;
        private Label lblFechaNacimiento;
        private Button btnAlta;
        private Button btnCancelar;
        private Label lblHorario;
        private GroupBox gbDeporte;
        private Label lblEspecialidad;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtCelular;
        private ComboBox cmbHorario;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cmbEspecialidad;
        private RadioButton rbNatacion;
        private RadioButton rbFutbol;
    }
}