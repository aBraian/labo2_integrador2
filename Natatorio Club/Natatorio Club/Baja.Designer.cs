namespace Natatorio_Club
{
    partial class Frm_baja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_baja));
            tlpMenu = new TableLayoutPanel();
            tlpContenedor = new TableLayoutPanel();
            btnCerrar = new Button();
            lbNadadores = new ListBox();
            tlpControles = new TableLayoutPanel();
            tlpSalir = new TableLayoutPanel();
            btnVolver = new Button();
            btnAceptar = new Button();
            label1 = new Label();
            tlpMenu.SuspendLayout();
            tlpContenedor.SuspendLayout();
            tlpControles.SuspendLayout();
            tlpSalir.SuspendLayout();
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
            tlpContenedor.TabIndex = 4;
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
            tlpControles.Controls.Add(label1, 0, 0);
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
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 289);
            label1.Name = "label1";
            label1.Size = new Size(129, 63);
            label1.TabIndex = 1;
            label1.Text = "Seleccione la\r\npersona a dar\r\nde baja";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Frm_baja
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
            Name = "Frm_baja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Natatorio Club";
            tlpMenu.ResumeLayout(false);
            tlpContenedor.ResumeLayout(false);
            tlpControles.ResumeLayout(false);
            tlpControles.PerformLayout();
            tlpSalir.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tlpMenu;
        private TableLayoutPanel tlpControles;
        private TableLayoutPanel tlpSalir;
        private Button btnVolver;
        private Button btnAceptar;
        private TableLayoutPanel tlpContenedor;
        private ListBox lbNadadores;
        private Button btnCerrar;
        private Label label1;
    }
}