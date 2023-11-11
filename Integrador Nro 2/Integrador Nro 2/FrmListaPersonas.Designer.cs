namespace Integrador_Nro_2
{
    partial class FrmListaPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaPersonas));
            tlpListaPersonas = new TableLayoutPanel();
            tlpContenedorControles = new TableLayoutPanel();
            tlpControles = new TableLayoutPanel();
            lblMensaje = new Label();
            tlpBotones = new TableLayoutPanel();
            btnVolver = new Button();
            lbPersonas = new ListBox();
            tlpListaPersonas.SuspendLayout();
            tlpContenedorControles.SuspendLayout();
            tlpControles.SuspendLayout();
            tlpBotones.SuspendLayout();
            SuspendLayout();
            // 
            // tlpListaPersonas
            // 
            tlpListaPersonas.BackColor = Color.FromArgb(37, 40, 80);
            tlpListaPersonas.ColumnCount = 2;
            tlpListaPersonas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tlpListaPersonas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpListaPersonas.Controls.Add(tlpContenedorControles, 0, 0);
            tlpListaPersonas.Controls.Add(lbPersonas, 1, 0);
            tlpListaPersonas.Dock = DockStyle.Fill;
            tlpListaPersonas.Location = new Point(0, 0);
            tlpListaPersonas.Name = "tlpListaPersonas";
            tlpListaPersonas.RowCount = 1;
            tlpListaPersonas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpListaPersonas.Size = new Size(1024, 768);
            tlpListaPersonas.TabIndex = 0;
            // 
            // tlpContenedorControles
            // 
            tlpContenedorControles.BackColor = Color.FromArgb(52, 55, 95);
            tlpContenedorControles.ColumnCount = 1;
            tlpContenedorControles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpContenedorControles.Controls.Add(tlpControles, 0, 0);
            tlpContenedorControles.Dock = DockStyle.Fill;
            tlpContenedorControles.Location = new Point(4, 3);
            tlpContenedorControles.Margin = new Padding(4, 3, 4, 3);
            tlpContenedorControles.Name = "tlpContenedorControles";
            tlpContenedorControles.RowCount = 1;
            tlpContenedorControles.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpContenedorControles.Size = new Size(342, 762);
            tlpContenedorControles.TabIndex = 5;
            // 
            // tlpControles
            // 
            tlpControles.Anchor = AnchorStyles.None;
            tlpControles.ColumnCount = 1;
            tlpControles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpControles.Controls.Add(lblMensaje, 0, 0);
            tlpControles.Controls.Add(tlpBotones, 0, 1);
            tlpControles.Location = new Point(6, 207);
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
            lblMensaje.Location = new Point(75, 72);
            lblMensaje.Margin = new Padding(4, 0, 4, 0);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(179, 29);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Lista de Personas";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpBotones
            // 
            tlpBotones.ColumnCount = 1;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBotones.Controls.Add(btnVolver, 0, 0);
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
            btnVolver.BackgroundImageLayout = ImageLayout.None;
            btnVolver.Dock = DockStyle.Fill;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 44, 76);
            btnVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 35, 85);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("HelveticaNowText Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(4, 3);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(316, 162);
            btnVolver.TabIndex = 5;
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
            lbPersonas.TabIndex = 4;
            // 
            // FrmListaPersonas
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(tlpListaPersonas);
            Font = new Font("HelveticaNowText Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmListaPersonas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AquaGoal";
            tlpListaPersonas.ResumeLayout(false);
            tlpContenedorControles.ResumeLayout(false);
            tlpControles.ResumeLayout(false);
            tlpControles.PerformLayout();
            tlpBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpListaPersonas;
        private ListBox lbPersonas;
        private TableLayoutPanel tlpContenedorControles;
        private TableLayoutPanel tlpControles;
        private Label lblMensaje;
        private TableLayoutPanel tlpBotones;
        private Button btnVolver;
    }
}