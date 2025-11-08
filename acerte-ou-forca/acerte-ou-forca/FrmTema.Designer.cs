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
            btnAnimais.Location = new Point(74, 192);
            btnAnimais.Name = "btnAnimais";
            btnAnimais.Size = new Size(75, 23);
            btnAnimais.TabIndex = 0;
            btnAnimais.Text = "Animais";
            btnAnimais.UseVisualStyleBackColor = true;
            btnAnimais.Click += btnAnimais_Click;
            // 
            // btnPapelaria
            // 
            btnPapelaria.Location = new Point(209, 192);
            btnPapelaria.Name = "btnPapelaria";
            btnPapelaria.Size = new Size(75, 23);
            btnPapelaria.TabIndex = 1;
            btnPapelaria.Text = "Papelaria";
            btnPapelaria.UseVisualStyleBackColor = true;
            // 
            // btnEletronicos
            // 
            btnEletronicos.Location = new Point(347, 192);
            btnEletronicos.Name = "btnEletronicos";
            btnEletronicos.Size = new Size(75, 23);
            btnEletronicos.TabIndex = 2;
            btnEletronicos.Text = "Eletrônicos";
            btnEletronicos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 48);
            label1.Name = "label1";
            label1.Size = new Size(208, 46);
            label1.TabIndex = 3;
            label1.Text = "Selecione um tema";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmTema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 320);
            Controls.Add(label1);
            Controls.Add(btnEletronicos);
            Controls.Add(btnPapelaria);
            Controls.Add(btnAnimais);
            Name = "FrmTema";
            Text = "FrmTema";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAnimais;
        private Button btnPapelaria;
        private Button btnEletronicos;
        private Label label1;
    }
}