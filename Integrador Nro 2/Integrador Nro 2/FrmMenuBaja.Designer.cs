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
            tlpControles = new TableLayoutPanel();
            lblSeleccionar = new Label();
            tlpBotones = new TableLayoutPanel();
            btnDarBaja = new Button();
            btnVolver = new Button();
            lbPersonas = new ListBox();
            tlpMenuBaja.SuspendLayout();
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
            tlpMenuBaja.Controls.Add(tlpControles, 0, 0);
            tlpMenuBaja.Controls.Add(lbPersonas, 1, 0);
            tlpMenuBaja.Dock = DockStyle.Fill;
            tlpMenuBaja.Location = new Point(0, 0);
            tlpMenuBaja.Name = "tlpMenuBaja";
            tlpMenuBaja.RowCount = 1;
            tlpMenuBaja.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMenuBaja.Size = new Size(1024, 768);
            tlpMenuBaja.TabIndex = 1;
            // 
            // tlpControles
            // 
            tlpControles.BackColor = Color.FromArgb(52, 55, 95);
            tlpControles.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpControles.ColumnCount = 1;
            tlpControles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpControles.Controls.Add(lblSeleccionar, 0, 0);
            tlpControles.Controls.Add(tlpBotones, 0, 1);
            tlpControles.Dock = DockStyle.Fill;
            tlpControles.Location = new Point(3, 3);
            tlpControles.Name = "tlpControles";
            tlpControles.RowCount = 2;
            tlpControles.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpControles.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpControles.Size = new Size(344, 762);
            tlpControles.TabIndex = 0;
            // 
            // lblSeleccionar
            // 
            lblSeleccionar.Anchor = AnchorStyles.None;
            lblSeleccionar.AutoSize = true;
            lblSeleccionar.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSeleccionar.ForeColor = Color.White;
            lblSeleccionar.Location = new Point(111, 161);
            lblSeleccionar.Name = "lblSeleccionar";
            lblSeleccionar.Size = new Size(122, 58);
            lblSeleccionar.TabIndex = 0;
            lblSeleccionar.Text = "Seleccionar\npersona:";
            lblSeleccionar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpBotones
            // 
            tlpBotones.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpBotones.ColumnCount = 2;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBotones.Controls.Add(btnDarBaja, 0, 0);
            tlpBotones.Controls.Add(btnVolver, 1, 0);
            tlpBotones.Dock = DockStyle.Fill;
            tlpBotones.Location = new Point(4, 384);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 1;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBotones.Size = new Size(336, 374);
            tlpBotones.TabIndex = 1;
            // 
            // btnDarBaja
            // 
            btnDarBaja.BackColor = Color.Transparent;
            btnDarBaja.Dock = DockStyle.Fill;
            btnDarBaja.FlatAppearance.BorderSize = 0;
            btnDarBaja.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 44, 76);
            btnDarBaja.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 35, 85);
            btnDarBaja.FlatStyle = FlatStyle.Flat;
            btnDarBaja.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDarBaja.ForeColor = Color.White;
            btnDarBaja.Location = new Point(5, 4);
            btnDarBaja.Margin = new Padding(4, 3, 4, 3);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(158, 366);
            btnDarBaja.TabIndex = 2;
            btnDarBaja.Text = "Dar baja";
            btnDarBaja.UseVisualStyleBackColor = false;
            btnDarBaja.Click += btnDarBaja_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Transparent;
            btnVolver.Dock = DockStyle.Fill;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 44, 76);
            btnVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 35, 85);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(172, 4);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(159, 366);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
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
            lbPersonas.TabIndex = 1;
            // 
            // FrmMenuBaja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(tlpMenuBaja);
            Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenuBaja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Polideportivo UTN";
            tlpMenuBaja.ResumeLayout(false);
            tlpControles.ResumeLayout(false);
            tlpControles.PerformLayout();
            tlpBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMenuBaja;
        private TableLayoutPanel tlpControles;
        private Label lblSeleccionar;
        private TableLayoutPanel tlpBotones;
        private Button btnDarBaja;
        private Button btnVolver;
        private ListBox lbPersonas;
    }
}