namespace Natatorio_Club
{
    partial class Frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_menu));
            tlpMenu = new TableLayoutPanel();
            tlpContenedor = new TableLayoutPanel();
            btnCerrar = new Button();
            tlpControles = new TableLayoutPanel();
            tlpSubmenu = new TableLayoutPanel();
            pbBuscar = new PictureBox();
            pbDeporte = new PictureBox();
            pbDatosPersonales = new PictureBox();
            pbBaja = new PictureBox();
            btnBuscar = new Button();
            btnDeporte = new Button();
            btnDatosPersonales = new Button();
            btnBaja = new Button();
            btnAlta = new Button();
            pbAlta = new PictureBox();
            tlpMenu.SuspendLayout();
            tlpContenedor.SuspendLayout();
            tlpControles.SuspendLayout();
            tlpSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDatosPersonales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBaja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAlta).BeginInit();
            SuspendLayout();
            // 
            // tlpMenu
            // 
            tlpMenu.BackColor = Color.FromArgb(26, 26, 39);
            tlpMenu.ColumnCount = 2;
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpMenu.Controls.Add(tlpContenedor, 1, 0);
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
            tlpContenedor.Dock = DockStyle.Fill;
            tlpContenedor.Location = new Point(259, 3);
            tlpContenedor.Name = "tlpContenedor";
            tlpContenedor.RowCount = 2;
            tlpContenedor.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlpContenedor.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            tlpContenedor.Size = new Size(1018, 714);
            tlpContenedor.TabIndex = 0;
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
            btnCerrar.TabIndex = 3;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // tlpControles
            // 
            tlpControles.ColumnCount = 1;
            tlpControles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpControles.Controls.Add(tlpSubmenu, 0, 0);
            tlpControles.Dock = DockStyle.Fill;
            tlpControles.Location = new Point(3, 3);
            tlpControles.Name = "tlpControles";
            tlpControles.RowCount = 2;
            tlpControles.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tlpControles.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpControles.Size = new Size(250, 714);
            tlpControles.TabIndex = 1;
            // 
            // tlpSubmenu
            // 
            tlpSubmenu.ColumnCount = 2;
            tlpSubmenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpSubmenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tlpSubmenu.Controls.Add(pbBuscar, 0, 4);
            tlpSubmenu.Controls.Add(pbDeporte, 0, 3);
            tlpSubmenu.Controls.Add(pbDatosPersonales, 0, 2);
            tlpSubmenu.Controls.Add(pbBaja, 0, 1);
            tlpSubmenu.Controls.Add(btnBuscar, 1, 4);
            tlpSubmenu.Controls.Add(btnDeporte, 1, 3);
            tlpSubmenu.Controls.Add(btnDatosPersonales, 1, 2);
            tlpSubmenu.Controls.Add(btnBaja, 1, 1);
            tlpSubmenu.Controls.Add(btnAlta, 1, 0);
            tlpSubmenu.Controls.Add(pbAlta, 0, 0);
            tlpSubmenu.Location = new Point(3, 3);
            tlpSubmenu.Name = "tlpSubmenu";
            tlpSubmenu.RowCount = 6;
            tlpSubmenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpSubmenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpSubmenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpSubmenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpSubmenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpSubmenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpSubmenu.Size = new Size(244, 316);
            tlpSubmenu.TabIndex = 0;
            // 
            // pbBuscar
            // 
            pbBuscar.Anchor = AnchorStyles.None;
            pbBuscar.Image = (Image)resources.GetObject("pbBuscar.Image");
            pbBuscar.Location = new Point(3, 203);
            pbBuscar.Name = "pbBuscar";
            pbBuscar.Size = new Size(55, 44);
            pbBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            pbBuscar.TabIndex = 7;
            pbBuscar.TabStop = false;
            // 
            // pbDeporte
            // 
            pbDeporte.Anchor = AnchorStyles.None;
            pbDeporte.Image = (Image)resources.GetObject("pbDeporte.Image");
            pbDeporte.Location = new Point(3, 153);
            pbDeporte.Name = "pbDeporte";
            pbDeporte.Size = new Size(55, 44);
            pbDeporte.SizeMode = PictureBoxSizeMode.Zoom;
            pbDeporte.TabIndex = 6;
            pbDeporte.TabStop = false;
            // 
            // pbDatosPersonales
            // 
            pbDatosPersonales.Anchor = AnchorStyles.None;
            pbDatosPersonales.Image = (Image)resources.GetObject("pbDatosPersonales.Image");
            pbDatosPersonales.Location = new Point(3, 103);
            pbDatosPersonales.Name = "pbDatosPersonales";
            pbDatosPersonales.Size = new Size(55, 44);
            pbDatosPersonales.SizeMode = PictureBoxSizeMode.Zoom;
            pbDatosPersonales.TabIndex = 5;
            pbDatosPersonales.TabStop = false;
            // 
            // pbBaja
            // 
            pbBaja.Anchor = AnchorStyles.None;
            pbBaja.Image = (Image)resources.GetObject("pbBaja.Image");
            pbBaja.Location = new Point(3, 53);
            pbBaja.Name = "pbBaja";
            pbBaja.Size = new Size(55, 44);
            pbBaja.SizeMode = PictureBoxSizeMode.Zoom;
            pbBaja.TabIndex = 4;
            pbBaja.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(64, 203);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(177, 44);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnDeporte
            // 
            btnDeporte.Cursor = Cursors.Hand;
            btnDeporte.FlatAppearance.BorderSize = 0;
            btnDeporte.FlatStyle = FlatStyle.Flat;
            btnDeporte.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeporte.Location = new Point(64, 153);
            btnDeporte.Name = "btnDeporte";
            btnDeporte.Size = new Size(177, 44);
            btnDeporte.TabIndex = 2;
            btnDeporte.Text = "Deporte";
            btnDeporte.TextAlign = ContentAlignment.MiddleLeft;
            btnDeporte.UseVisualStyleBackColor = true;
            btnDeporte.Click += btnDeporte_Click;
            // 
            // btnDatosPersonales
            // 
            btnDatosPersonales.Cursor = Cursors.Hand;
            btnDatosPersonales.FlatAppearance.BorderSize = 0;
            btnDatosPersonales.FlatStyle = FlatStyle.Flat;
            btnDatosPersonales.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDatosPersonales.Location = new Point(64, 103);
            btnDatosPersonales.Name = "btnDatosPersonales";
            btnDatosPersonales.Size = new Size(177, 44);
            btnDatosPersonales.TabIndex = 2;
            btnDatosPersonales.Text = "Datos Personales";
            btnDatosPersonales.TextAlign = ContentAlignment.MiddleLeft;
            btnDatosPersonales.UseVisualStyleBackColor = true;
            btnDatosPersonales.Click += btnDatosPersonales_Click;
            // 
            // btnBaja
            // 
            btnBaja.Cursor = Cursors.Hand;
            btnBaja.FlatAppearance.BorderSize = 0;
            btnBaja.FlatStyle = FlatStyle.Flat;
            btnBaja.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaja.Location = new Point(64, 53);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(177, 44);
            btnBaja.TabIndex = 1;
            btnBaja.Text = "Baja";
            btnBaja.TextAlign = ContentAlignment.MiddleLeft;
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnAlta
            // 
            btnAlta.Cursor = Cursors.Hand;
            btnAlta.Dock = DockStyle.Fill;
            btnAlta.FlatAppearance.BorderSize = 0;
            btnAlta.FlatStyle = FlatStyle.Flat;
            btnAlta.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlta.Location = new Point(64, 3);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(177, 44);
            btnAlta.TabIndex = 0;
            btnAlta.Text = "Alta";
            btnAlta.TextAlign = ContentAlignment.MiddleLeft;
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // pbAlta
            // 
            pbAlta.Anchor = AnchorStyles.None;
            pbAlta.Image = (Image)resources.GetObject("pbAlta.Image");
            pbAlta.Location = new Point(3, 3);
            pbAlta.Name = "pbAlta";
            pbAlta.Size = new Size(55, 44);
            pbAlta.SizeMode = PictureBoxSizeMode.Zoom;
            pbAlta.TabIndex = 3;
            pbAlta.TabStop = false;
            // 
            // Frm_menu
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 46, 74);
            ClientSize = new Size(1280, 720);
            Controls.Add(tlpMenu);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Frm_menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Natatorio Club";
            tlpMenu.ResumeLayout(false);
            tlpContenedor.ResumeLayout(false);
            tlpControles.ResumeLayout(false);
            tlpSubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDatosPersonales).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBaja).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAlta).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tlpMenu;
        private TableLayoutPanel tlpContenedor;
        private TableLayoutPanel tlpControles;
        private TableLayoutPanel tlpSubmenu;
        private Button button2;
        private Button btnAlta;
        private Button btnBuscar;
        private Button btnDeporte;
        private Button btnDatosPersonales;
        private Button btnBaja;
        private PictureBox pbBuscar;
        private PictureBox pbDeporte;
        private PictureBox pbDatosPersonales;
        private PictureBox pbBaja;
        private PictureBox pbAlta;
        private Button btnCerrar;
    }
}