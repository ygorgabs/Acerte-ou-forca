namespace acerte_ou_forca
{
    partial class FrmForca
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
            pbCabeca = new PictureBox();
            pbPernaEsq = new PictureBox();
            pbPernaDir = new PictureBox();
            pbBracoEsq = new PictureBox();
            pbBracoDir = new PictureBox();
            pbTronco = new PictureBox();
            panelBoneco = new Panel();
            txtLetra = new TextBox();
            label1 = new Label();
            btnVerificar = new Button();
            btnNovoTema = new Button();
            btnNovaPalavra = new Button();
            label2 = new Label();
            lblLetras = new Label();
            lblPalavra = new Label();
            lblContVitorias = new Label();
            lblTema = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCabeca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPernaEsq).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPernaDir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBracoEsq).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBracoDir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTronco).BeginInit();
            panelBoneco.SuspendLayout();
            SuspendLayout();
            // 
            // pbCabeca
            // 
            pbCabeca.Location = new Point(95, 37);
            pbCabeca.Name = "pbCabeca";
            pbCabeca.Size = new Size(100, 100);
            pbCabeca.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCabeca.TabIndex = 0;
            pbCabeca.TabStop = false;
            // 
            // pbPernaEsq
            // 
            pbPernaEsq.ErrorImage = null;
            pbPernaEsq.Location = new Point(48, 259);
            pbPernaEsq.Name = "pbPernaEsq";
            pbPernaEsq.Size = new Size(100, 100);
            pbPernaEsq.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPernaEsq.TabIndex = 1;
            pbPernaEsq.TabStop = false;
            // 
            // pbPernaDir
            // 
            pbPernaDir.Location = new Point(145, 259);
            pbPernaDir.Name = "pbPernaDir";
            pbPernaDir.Size = new Size(100, 100);
            pbPernaDir.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPernaDir.TabIndex = 2;
            pbPernaDir.TabStop = false;
            // 
            // pbBracoEsq
            // 
            pbBracoEsq.Location = new Point(22, 150);
            pbBracoEsq.Name = "pbBracoEsq";
            pbBracoEsq.Size = new Size(100, 100);
            pbBracoEsq.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBracoEsq.TabIndex = 3;
            pbBracoEsq.TabStop = false;
            // 
            // pbBracoDir
            // 
            pbBracoDir.ErrorImage = null;
            pbBracoDir.Location = new Point(170, 149);
            pbBracoDir.Name = "pbBracoDir";
            pbBracoDir.Size = new Size(100, 100);
            pbBracoDir.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBracoDir.TabIndex = 4;
            pbBracoDir.TabStop = false;
            // 
            // pbTronco
            // 
            pbTronco.Location = new Point(119, 133);
            pbTronco.Name = "pbTronco";
            pbTronco.Size = new Size(50, 129);
            pbTronco.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTronco.TabIndex = 5;
            pbTronco.TabStop = false;
            // 
            // panelBoneco
            // 
            panelBoneco.BackColor = Color.White;
            panelBoneco.Controls.Add(pbCabeca);
            panelBoneco.Controls.Add(pbTronco);
            panelBoneco.Controls.Add(pbPernaEsq);
            panelBoneco.Controls.Add(pbBracoDir);
            panelBoneco.Controls.Add(pbPernaDir);
            panelBoneco.Controls.Add(pbBracoEsq);
            panelBoneco.Dock = DockStyle.Left;
            panelBoneco.Location = new Point(0, 0);
            panelBoneco.Name = "panelBoneco";
            panelBoneco.Size = new Size(292, 451);
            panelBoneco.TabIndex = 6;
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(337, 259);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(267, 23);
            txtLetra.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F);
            label1.Location = new Point(337, 237);
            label1.Name = "label1";
            label1.Size = new Size(138, 18);
            label1.TabIndex = 8;
            label1.Text = "Digite uma letra:";
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.FromArgb(47, 62, 92);
            btnVerificar.FlatAppearance.BorderSize = 0;
            btnVerificar.FlatStyle = FlatStyle.Flat;
            btnVerificar.Font = new Font("Arial Rounded MT Bold", 11.25F);
            btnVerificar.ForeColor = Color.White;
            btnVerificar.Location = new Point(610, 249);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(90, 33);
            btnVerificar.TabIndex = 9;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnNovoTema
            // 
            btnNovoTema.BackColor = Color.FromArgb(47, 62, 92);
            btnNovoTema.FlatAppearance.BorderSize = 0;
            btnNovoTema.FlatStyle = FlatStyle.Flat;
            btnNovoTema.Font = new Font("Arial Rounded MT Bold", 11.25F);
            btnNovoTema.ForeColor = Color.White;
            btnNovoTema.Location = new Point(522, 407);
            btnNovoTema.Name = "btnNovoTema";
            btnNovoTema.Size = new Size(163, 32);
            btnNovoTema.TabIndex = 10;
            btnNovoTema.Text = "Outro tema";
            btnNovoTema.UseVisualStyleBackColor = false;
            btnNovoTema.Click += btnNovoTema_Click;
            // 
            // btnNovaPalavra
            // 
            btnNovaPalavra.BackColor = Color.FromArgb(47, 62, 92);
            btnNovaPalavra.FlatAppearance.BorderSize = 0;
            btnNovaPalavra.FlatStyle = FlatStyle.Flat;
            btnNovaPalavra.Font = new Font("Arial Rounded MT Bold", 11.25F);
            btnNovaPalavra.ForeColor = Color.White;
            btnNovaPalavra.Location = new Point(354, 407);
            btnNovaPalavra.Name = "btnNovaPalavra";
            btnNovaPalavra.Size = new Size(160, 32);
            btnNovaPalavra.TabIndex = 12;
            btnNovaPalavra.Text = "Outra palavra";
            btnNovaPalavra.UseVisualStyleBackColor = false;
            btnNovaPalavra.Click += btnNovaPalavra_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(337, 300);
            label2.Name = "label2";
            label2.Size = new Size(144, 18);
            label2.TabIndex = 13;
            label2.Text = "Letras utilizadas:";
            // 
            // lblLetras
            // 
            lblLetras.AutoSize = true;
            lblLetras.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLetras.Location = new Point(337, 334);
            lblLetras.Name = "lblLetras";
            lblLetras.Size = new Size(0, 22);
            lblLetras.TabIndex = 14;
            // 
            // lblPalavra
            // 
            lblPalavra.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPalavra.Location = new Point(327, 95);
            lblPalavra.Name = "lblPalavra";
            lblPalavra.Size = new Size(396, 71);
            lblPalavra.TabIndex = 15;
            lblPalavra.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblContVitorias
            // 
            lblContVitorias.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContVitorias.Location = new Point(550, 9);
            lblContVitorias.Name = "lblContVitorias";
            lblContVitorias.Size = new Size(173, 45);
            lblContVitorias.TabIndex = 16;
            lblContVitorias.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTema
            // 
            lblTema.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTema.Location = new Point(308, 9);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(173, 45);
            lblTema.TabIndex = 17;
            lblTema.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmForca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 211, 227);
            ClientSize = new Size(735, 451);
            Controls.Add(lblTema);
            Controls.Add(lblContVitorias);
            Controls.Add(lblPalavra);
            Controls.Add(lblLetras);
            Controls.Add(label2);
            Controls.Add(btnNovaPalavra);
            Controls.Add(btnNovoTema);
            Controls.Add(btnVerificar);
            Controls.Add(label1);
            Controls.Add(txtLetra);
            Controls.Add(panelBoneco);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmForca";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acerte ou Forca";
            FormClosed += FrmForca_FormClosed;
            Load += FrmForca_Load;
            ((System.ComponentModel.ISupportInitialize)pbCabeca).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPernaEsq).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPernaDir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBracoEsq).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBracoDir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTronco).EndInit();
            panelBoneco.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbCabeca;
        private PictureBox pbPernaEsq;
        private PictureBox pbPernaDir;
        private PictureBox pbBracoEsq;
        private PictureBox pbBracoDir;
        private PictureBox pbTronco;
        private Panel panelBoneco;
        private TextBox txtLetra;
        private Label label1;
        private Button btnVerificar;
        private Button btnNovoTema;
        private Button btnNovaPalavra;
        private Label label2;
        private Label lblLetras;
        private Label lblPalavra;
        private Label lblContVitorias;
        private Label lblTema;
    }
}