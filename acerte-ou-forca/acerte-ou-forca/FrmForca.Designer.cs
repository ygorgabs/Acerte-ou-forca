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
            pbBracoEsq.Location = new Point(22, 143);
            pbBracoEsq.Name = "pbBracoEsq";
            pbBracoEsq.Size = new Size(100, 100);
            pbBracoEsq.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBracoEsq.TabIndex = 3;
            pbBracoEsq.TabStop = false;
            // 
            // pbBracoDir
            // 
            pbBracoDir.Location = new Point(170, 143);
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
            label1.Location = new Point(337, 241);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 8;
            label1.Text = "Digite uma letra:";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(610, 259);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 9;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnNovoTema
            // 
            btnNovoTema.Location = new Point(518, 416);
            btnNovoTema.Name = "btnNovoTema";
            btnNovoTema.Size = new Size(97, 23);
            btnNovoTema.TabIndex = 10;
            btnNovoTema.Text = "Outro tema";
            btnNovoTema.UseVisualStyleBackColor = true;
            btnNovoTema.Click += btnNovoTema_Click;
            // 
            // btnNovaPalavra
            // 
            btnNovaPalavra.Location = new Point(409, 416);
            btnNovaPalavra.Name = "btnNovaPalavra";
            btnNovaPalavra.Size = new Size(94, 23);
            btnNovaPalavra.TabIndex = 12;
            btnNovaPalavra.Text = "Outra palavra";
            btnNovaPalavra.UseVisualStyleBackColor = true;
            btnNovaPalavra.Click += btnNovaPalavra_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 300);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 13;
            label2.Text = "Letras utilizadas:";
            // 
            // lblLetras
            // 
            lblLetras.AutoSize = true;
            lblLetras.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLetras.Location = new Point(337, 315);
            lblLetras.Name = "lblLetras";
            lblLetras.Size = new Size(0, 25);
            lblLetras.TabIndex = 14;
            // 
            // lblPalavra
            // 
            lblPalavra.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPalavra.Location = new Point(327, 95);
            lblPalavra.Name = "lblPalavra";
            lblPalavra.Size = new Size(396, 71);
            lblPalavra.TabIndex = 15;
            lblPalavra.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblContVitorias
            // 
            lblContVitorias.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContVitorias.Location = new Point(550, 9);
            lblContVitorias.Name = "lblContVitorias";
            lblContVitorias.Size = new Size(173, 45);
            lblContVitorias.TabIndex = 16;
            lblContVitorias.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmForca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 451);
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
            Name = "FrmForca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmForca";
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
    }
}