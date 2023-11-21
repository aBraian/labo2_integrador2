namespace Integrador_Nro_2
{
    partial class FrmMenuBaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuBaja));
            tlpMenuBaja = new TableLayoutPanel();
            lbPersonas = new ListBox();
            pnlContenedorControles = new Panel();
            tlpContenedorControles = new TableLayoutPanel();
            tlpControles = new TableLayoutPanel();
            lblMensaje = new Label();
            tlpBotones = new TableLayoutPanel();
            btnVolver = new Button();
            btnDarBaja = new Button();
            tlpMenuBaja.SuspendLayout();
            pnlContenedorControles.SuspendLayout();
            tlpContenedorControles.SuspendLayout();
            tlpControles.SuspendLayout();
            tlpBotones.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMenuBaja
            // 
            tlpMenuBaja.BackColor = Color.FromArgb(37, 40, 80);
            tlpMenuBaja.ColumnCount = 2;
            tlpMenuBaja.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tlpMenuBaja.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMenuBaja.Controls.Add(lbPersonas, 1, 0);
            tlpMenuBaja.Controls.Add(pnlContenedorControles, 0, 0);
            tlpMenuBaja.Dock = DockStyle.Fill;
            tlpMenuBaja.Location = new Point(0, 0);
            tlpMenuBaja.Margin = new Padding(4, 3, 4, 3);
            tlpMenuBaja.Name = "tlpMenuBaja";
            tlpMenuBaja.RowCount = 1;
            tlpMenuBaja.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMenuBaja.Size = new Size(1332, 853);
            tlpMenuBaja.TabIndex = 1;
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
            lbPersonas.Location = new Point(354, 3);
            lbPersonas.Margin = new Padding(4, 3, 4, 3);
            lbPersonas.Name = "lbPersonas";
            lbPersonas.Size = new Size(974, 847);
            lbPersonas.TabIndex = 1;
            // 
            // pnlContenedorControles
            // 
            pnlContenedorControles.BackColor = Color.FromArgb(52, 55, 95);
            pnlContenedorControles.BorderStyle = BorderStyle.Fixed3D;
            pnlContenedorControles.Controls.Add(tlpContenedorControles);
            pnlContenedorControles.Dock = DockStyle.Fill;
            pnlContenedorControles.Location = new Point(4, 3);
            pnlContenedorControles.Margin = new Padding(4, 3, 4, 3);
            pnlContenedorControles.Name = "pnlContenedorControles";
            pnlContenedorControles.Size = new Size(342, 847);
            pnlContenedorControles.TabIndex = 2;
            // 
            // tlpContenedorControles
            // 
            tlpContenedorControles.ColumnCount = 1;
            tlpContenedorControles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpContenedorControles.Controls.Add(tlpControles, 0, 0);
            tlpContenedorControles.Dock = DockStyle.Fill;
            tlpContenedorControles.Location = new Point(0, 0);
            tlpContenedorControles.Margin = new Padding(4, 3, 4, 3);
            tlpContenedorControles.Name = "tlpContenedorControles";
            tlpContenedorControles.RowCount = 1;
            tlpContenedorControles.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpContenedorControles.Size = new Size(338, 843);
            tlpContenedorControles.TabIndex = 0;
            // 
            // tlpControles
            // 
            tlpControles.Anchor = AnchorStyles.None;
            tlpControles.ColumnCount = 1;
            tlpControles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpControles.Controls.Add(lblMensaje, 0, 0);
            tlpControles.Controls.Add(tlpBotones, 0, 1);
            tlpControles.Location = new Point(4, 247);
            tlpControles.Margin = new Padding(4, 3, 4, 3);
            tlpControles.Name = "tlpControles";
            tlpControles.RowCount = 2;
            tlpControles.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpControles.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpControles.Size = new Size(330, 348);
            tlpControles.TabIndex = 0;
            // 
            // lblMensaje
            // 
            lblMensaje.Anchor = AnchorStyles.None;
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(104, 58);
            lblMensaje.Margin = new Padding(4, 0, 4, 0);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(122, 58);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Seleccionar\r\nPersona";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpBotones
            // 
            tlpBotones.ColumnCount = 2;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBotones.Controls.Add(btnVolver, 0, 0);
            tlpBotones.Controls.Add(btnDarBaja, 0, 0);
            tlpBotones.Dock = DockStyle.Fill;
            tlpBotones.Location = new Point(3, 177);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 1;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBotones.Size = new Size(324, 168);
            tlpBotones.TabIndex = 1;
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
            btnVolver.Location = new Point(166, 3);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(154, 162);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnDarBaja
            // 
            btnDarBaja.BackColor = Color.Transparent;
            btnDarBaja.Dock = DockStyle.Fill;
            btnDarBaja.FlatAppearance.BorderSize = 0;
            btnDarBaja.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 44, 76);
            btnDarBaja.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 35, 85);
            btnDarBaja.FlatStyle = FlatStyle.Flat;
            btnDarBaja.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDarBaja.ForeColor = Color.White;
            btnDarBaja.Location = new Point(4, 3);
            btnDarBaja.Margin = new Padding(4, 3, 4, 3);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(154, 162);
            btnDarBaja.TabIndex = 4;
            btnDarBaja.Text = "Dar Baja";
            btnDarBaja.UseVisualStyleBackColor = false;
            btnDarBaja.Click += btnDarBaja_Click;
            // 
            // FrmMenuBaja
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 853);
            Controls.Add(tlpMenuBaja);
            Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenuBaja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AquaGoal";
            tlpMenuBaja.ResumeLayout(false);
            pnlContenedorControles.ResumeLayout(false);
            tlpContenedorControles.ResumeLayout(false);
            tlpControles.ResumeLayout(false);
            tlpControles.PerformLayout();
            tlpBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMenuBaja;
        private ListBox lbPersonas;
        private Panel pnlContenedorControles;
        private TableLayoutPanel tlpContenedorControles;
        private TableLayoutPanel tlpControles;
        private Label lblMensaje;
        private TableLayoutPanel tlpBotones;
        private Button btnDarBaja;
        private Button btnVolver;
    }
}