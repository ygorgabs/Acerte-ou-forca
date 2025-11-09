namespace acerte_ou_forca
{
    partial class FrmInicio
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
            btnInicio = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(47, 62, 92);
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(158, 154);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(152, 41);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Iniciar";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo2;
            pictureBox1.Location = new Point(45, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 211, 227);
            ClientSize = new Size(480, 303);
            Controls.Add(pictureBox1);
            Controls.Add(btnInicio);
            Name = "FrmInicio";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acerte ou Forca";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnInicio;
        private PictureBox pictureBox1;
    }
}
