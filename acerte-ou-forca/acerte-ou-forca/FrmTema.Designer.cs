namespace acerte_ou_forca
{
    partial class FrmTema
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
            btnAnimais = new Button();
            btnPapelaria = new Button();
            btnEletronicos = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAnimais
            // 
            btnAnimais.BackColor = Color.FromArgb(47, 62, 92);
            btnAnimais.FlatAppearance.BorderSize = 0;
            btnAnimais.FlatStyle = FlatStyle.Flat;
            btnAnimais.Font = new Font("Arial Rounded MT Bold", 12F);
            btnAnimais.ForeColor = Color.White;
            btnAnimais.Image = Properties.Resources.pets1;
            btnAnimais.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnimais.Location = new Point(164, 86);
            btnAnimais.Margin = new Padding(3, 2, 3, 2);
            btnAnimais.Name = "btnAnimais";
            btnAnimais.Size = new Size(165, 41);
            btnAnimais.TabIndex = 0;
            btnAnimais.Text = "Animais";
            btnAnimais.TextAlign = ContentAlignment.MiddleRight;
            btnAnimais.UseVisualStyleBackColor = false;
            btnAnimais.Click += btnAnimais_Click;
            // 
            // btnPapelaria
            // 
            btnPapelaria.BackColor = Color.FromArgb(47, 62, 92);
            btnPapelaria.FlatAppearance.BorderSize = 0;
            btnPapelaria.FlatStyle = FlatStyle.Flat;
            btnPapelaria.Font = new Font("Arial Rounded MT Bold", 12F);
            btnPapelaria.ForeColor = Color.White;
            btnPapelaria.Image = Properties.Resources.paper;
            btnPapelaria.ImageAlign = ContentAlignment.MiddleLeft;
            btnPapelaria.Location = new Point(164, 242);
            btnPapelaria.Margin = new Padding(3, 2, 3, 2);
            btnPapelaria.Name = "btnPapelaria";
            btnPapelaria.Size = new Size(165, 41);
            btnPapelaria.TabIndex = 1;
            btnPapelaria.Text = "Papelaria";
            btnPapelaria.TextAlign = ContentAlignment.MiddleRight;
            btnPapelaria.UseVisualStyleBackColor = false;
            btnPapelaria.Click += btnPapelaria_Click;
            // 
            // btnEletronicos
            // 
            btnEletronicos.BackColor = Color.FromArgb(47, 62, 92);
            btnEletronicos.FlatAppearance.BorderSize = 0;
            btnEletronicos.FlatStyle = FlatStyle.Flat;
            btnEletronicos.Font = new Font("Arial Rounded MT Bold", 12F);
            btnEletronicos.ForeColor = Color.White;
            btnEletronicos.Image = Properties.Resources.eletronico;
            btnEletronicos.ImageAlign = ContentAlignment.MiddleLeft;
            btnEletronicos.Location = new Point(164, 163);
            btnEletronicos.Margin = new Padding(3, 2, 3, 2);
            btnEletronicos.Name = "btnEletronicos";
            btnEletronicos.Size = new Size(165, 41);
            btnEletronicos.TabIndex = 2;
            btnEletronicos.Text = "Eletrônicos";
            btnEletronicos.TextAlign = ContentAlignment.MiddleRight;
            btnEletronicos.UseVisualStyleBackColor = false;
            btnEletronicos.Click += btnEletronicos_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 27);
            label1.Name = "label1";
            label1.Size = new Size(252, 46);
            label1.TabIndex = 3;
            label1.Text = "Selecione um tema";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmTema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 211, 227);
            ClientSize = new Size(515, 320);
            Controls.Add(label1);
            Controls.Add(btnEletronicos);
            Controls.Add(btnPapelaria);
            Controls.Add(btnAnimais);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmTema";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acerte ou Forca";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAnimais;
        private Button btnPapelaria;
        private Button btnEletronicos;
        private Label label1;
    }
}