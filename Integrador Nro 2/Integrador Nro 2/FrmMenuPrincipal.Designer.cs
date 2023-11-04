namespace Integrador_Nro_2
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            flpNavegar = new FlowLayoutPanel();
            tlpAgregar = new TableLayoutPanel();
            btnAgregar = new Button();
            pbAgregar = new PictureBox();
            tlpQuitar = new TableLayoutPanel();
            btnQuitar = new Button();
            pbQuitar = new PictureBox();
            tlpModificar = new TableLayoutPanel();
            btnModificar = new Button();
            pbModificar = new PictureBox();
            tlpBuscar = new TableLayoutPanel();
            pbBuscar = new PictureBox();
            btnBuscar = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            button3 = new Button();
            pictureBox4 = new PictureBox();
            flpNavegar.SuspendLayout();
            tlpAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAgregar).BeginInit();
            tlpQuitar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQuitar).BeginInit();
            tlpModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbModificar).BeginInit();
            tlpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBuscar).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // flpNavegar
            // 
            flpNavegar.BackColor = Color.FromArgb(55, 55, 57);
            flpNavegar.BorderStyle = BorderStyle.Fixed3D;
            flpNavegar.Controls.Add(tlpAgregar);
            flpNavegar.Controls.Add(tlpQuitar);
            flpNavegar.Controls.Add(tlpModificar);
            flpNavegar.Controls.Add(tlpBuscar);
            flpNavegar.Location = new Point(12, 12);
            flpNavegar.Name = "flpNavegar";
            flpNavegar.Size = new Size(300, 744);
            flpNavegar.TabIndex = 5;
            // 
            // tlpAgregar
            // 
            tlpAgregar.ColumnCount = 2;
            tlpAgregar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tlpAgregar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpAgregar.Controls.Add(btnAgregar, 1, 0);
            tlpAgregar.Controls.Add(pbAgregar, 0, 0);
            tlpAgregar.Location = new Point(3, 3);
            tlpAgregar.Name = "tlpAgregar";
            tlpAgregar.RowCount = 1;
            tlpAgregar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAgregar.Size = new Size(290, 50);
            tlpAgregar.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(55, 55, 57);
            btnAgregar.Dock = DockStyle.Fill;
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 57);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 25, 26);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(53, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(234, 44);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar persona";
            btnAgregar.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pbAgregar
            // 
            pbAgregar.BackColor = Color.Transparent;
            pbAgregar.BackgroundImage = (Image)resources.GetObject("pbAgregar.BackgroundImage");
            pbAgregar.BackgroundImageLayout = ImageLayout.Zoom;
            pbAgregar.Dock = DockStyle.Fill;
            pbAgregar.Location = new Point(3, 3);
            pbAgregar.Name = "pbAgregar";
            pbAgregar.Size = new Size(44, 44);
            pbAgregar.TabIndex = 8;
            pbAgregar.TabStop = false;
            // 
            // tlpQuitar
            // 
            tlpQuitar.ColumnCount = 2;
            tlpQuitar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tlpQuitar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpQuitar.Controls.Add(btnQuitar, 1, 0);
            tlpQuitar.Controls.Add(pbQuitar, 0, 0);
            tlpQuitar.Location = new Point(3, 59);
            tlpQuitar.Name = "tlpQuitar";
            tlpQuitar.RowCount = 1;
            tlpQuitar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpQuitar.Size = new Size(290, 50);
            tlpQuitar.TabIndex = 8;
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = Color.FromArgb(55, 55, 57);
            btnQuitar.Dock = DockStyle.Fill;
            btnQuitar.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 57);
            btnQuitar.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 25, 26);
            btnQuitar.FlatStyle = FlatStyle.Flat;
            btnQuitar.ForeColor = Color.White;
            btnQuitar.Location = new Point(53, 3);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(234, 44);
            btnQuitar.TabIndex = 8;
            btnQuitar.Text = "Quitar persona";
            btnQuitar.TextAlign = ContentAlignment.MiddleLeft;
            btnQuitar.UseVisualStyleBackColor = false;
            // 
            // pbQuitar
            // 
            pbQuitar.BackColor = Color.Transparent;
            pbQuitar.BackgroundImage = (Image)resources.GetObject("pbQuitar.BackgroundImage");
            pbQuitar.BackgroundImageLayout = ImageLayout.Zoom;
            pbQuitar.Dock = DockStyle.Fill;
            pbQuitar.Location = new Point(3, 3);
            pbQuitar.Name = "pbQuitar";
            pbQuitar.Size = new Size(44, 44);
            pbQuitar.TabIndex = 8;
            pbQuitar.TabStop = false;
            // 
            // tlpModificar
            // 
            tlpModificar.ColumnCount = 2;
            tlpModificar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tlpModificar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpModificar.Controls.Add(btnModificar, 1, 0);
            tlpModificar.Controls.Add(pbModificar, 0, 0);
            tlpModificar.Location = new Point(3, 115);
            tlpModificar.Name = "tlpModificar";
            tlpModificar.RowCount = 1;
            tlpModificar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpModificar.Size = new Size(290, 50);
            tlpModificar.TabIndex = 11;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(55, 55, 57);
            btnModificar.Dock = DockStyle.Fill;
            btnModificar.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 57);
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 25, 26);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(53, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(234, 44);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar persona";
            btnModificar.TextAlign = ContentAlignment.MiddleLeft;
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // pbModificar
            // 
            pbModificar.BackColor = Color.Transparent;
            pbModificar.BackgroundImage = (Image)resources.GetObject("pbModificar.BackgroundImage");
            pbModificar.BackgroundImageLayout = ImageLayout.Zoom;
            pbModificar.Dock = DockStyle.Fill;
            pbModificar.Location = new Point(3, 3);
            pbModificar.Name = "pbModificar";
            pbModificar.Size = new Size(44, 44);
            pbModificar.TabIndex = 8;
            pbModificar.TabStop = false;
            // 
            // tlpBuscar
            // 
            tlpBuscar.BackColor = Color.Transparent;
            tlpBuscar.ColumnCount = 2;
            tlpBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tlpBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBuscar.Controls.Add(pbBuscar, 0, 0);
            tlpBuscar.Controls.Add(btnBuscar, 1, 0);
            tlpBuscar.Location = new Point(3, 171);
            tlpBuscar.Name = "tlpBuscar";
            tlpBuscar.RowCount = 1;
            tlpBuscar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBuscar.Size = new Size(290, 50);
            tlpBuscar.TabIndex = 10;
            // 
            // pbBuscar
            // 
            pbBuscar.BackColor = Color.Transparent;
            pbBuscar.BackgroundImage = (Image)resources.GetObject("pbBuscar.BackgroundImage");
            pbBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            pbBuscar.Dock = DockStyle.Fill;
            pbBuscar.Location = new Point(3, 3);
            pbBuscar.Name = "pbBuscar";
            pbBuscar.Size = new Size(44, 44);
            pbBuscar.TabIndex = 8;
            pbBuscar.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(55, 55, 57);
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 57);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 25, 26);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(53, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(234, 44);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar persona";
            btnBuscar.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(button3, 1, 0);
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(53, 3);
            button3.Name = "button3";
            button3.Size = new Size(144, 94);
            button3.TabIndex = 8;
            button3.Text = "Agregar persona";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 94);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 26);
            ClientSize = new Size(1024, 768);
            Controls.Add(flpNavegar);
            Font = new Font("HelveticaNowText Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Polideportivo UTN";
            FormClosing += FrmMenuPrincipal_FormClosing;
            flpNavegar.ResumeLayout(false);
            tlpAgregar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAgregar).EndInit();
            tlpQuitar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbQuitar).EndInit();
            tlpModificar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbModificar).EndInit();
            tlpBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBuscar).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flpNavegar;
        private PictureBox pbAgregar;
        private TableLayoutPanel tlpAgregar;
        private Button btnAgregar;
        private TableLayoutPanel tlpQuitar;
        private Button btnQuitar;
        private PictureBox pbQuitar;
        private TableLayoutPanel tlpModificar;
        private Button btnModificar;
        private PictureBox pbModificar;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button3;
        private PictureBox pictureBox4;
        private TableLayoutPanel tlpBuscar;
        private Button btnBuscar;
        private PictureBox pbBuscar;
    }
}