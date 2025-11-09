using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acerte_ou_forca
{
    public partial class FrmForca : Form
    {
        Compartilha compartilha = new Compartilha();
        string[] palavras;
        string palavraSelecionada, palavraEncriptada;
        int contaErros = 0, contaAcertos = 0;
        bool mudarTema = false;

        public FrmForca()
        {
            InitializeComponent();
        }

        private void sortearPalavra()
        {
            if (palavras == null || palavras.Length == 0) return;

            Random rnd = new Random();
            int posicao = rnd.Next(palavras.Length);

            palavraSelecionada = palavras[posicao].ToUpper();
            palavraEncriptada = "";

            foreach (char letra in palavraSelecionada)
            {
                palavraEncriptada += "*";
            }

            lblPalavra.Text = palavraEncriptada;
        }

        private void verificaErro()
        {
            switch (contaErros)
            {
                case 0:
                    pbCabeca.Image = Properties.Resources.cabeca;
                    break;
                case 1:
                    pbTronco.Image = Properties.Resources.tronco;
                    break;
                case 2:
                    pbBracoDir.Image = Properties.Resources.braco_direito;
                    break;
                case 3:
                    pbBracoEsq.Image = Properties.Resources.braco_esquerdo;
                    break;
                case 4:
                    pbPernaDir.Image = Properties.Resources.perna_direita;
                    break;
                case 5:
                    pbPernaEsq.Image = Properties.Resources.perna_esquerda;
                    break;
            }

            contaErros++;
            txtLetra.Text = "";
            if (contaErros == 6)
            {
                MessageBox.Show("Sem mais tentativas. Tente novamente com outra palavra");
                btnVerificar.Enabled = false;
            }
        }

        private void verificaAcerto(char letra)
        {
            char[] palavra = palavraEncriptada.ToCharArray();
            for (int i = 0; i < palavraSelecionada.Length; i++)
            {
                if (palavraSelecionada[i].Equals(letra))
                {
                    palavra[i] = letra;
                    Debug.WriteLine(palavra[i]);
                    contaAcertos++;
                }
            }

            palavraEncriptada = new string(palavra);
            lblPalavra.Text = palavraEncriptada;
            txtLetra.Text = "";
            if (contaAcertos == palavraSelecionada.Length)
            {
                btnVerificar.Enabled = false;
                MessageBox.Show("Parabéns você acertou!!!");
                compartilha.setVitorias();
                lblContVitorias.Text = "Total de vitórias: " + compartilha.getVitorias();
            }

        }

        private void FrmForca_Load(object sender, EventArgs e)
        {
            palavras = compartilha.getPalavras();
            sortearPalavra();
            lblContVitorias.Text = "Total de vitórias: " + compartilha.getVitorias();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtLetra.Text == null || txtLetra.Text == "")
            {
                MessageBox.Show("Necessário digitar uma letra para jogar.");
                return;
            }

            var letra = txtLetra.Text.ToUpper()[0];

            if ((int)letra < 65 || (int)letra > 90)
            {
                MessageBox.Show("Permitido somente letras. Por favor, digite um valor de A-Z");
                return;
            }

            lblLetras.Text += letra + " ";

            if (!palavraSelecionada.Contains(letra))
            {
                verificaErro();
                return;
            }

            verificaAcerto(letra);
        }

        private void btnNovaPalavra_Click(object sender, EventArgs e)
        {
            pbCabeca.Image = null;
            pbTronco.Image = null;
            pbBracoDir.Image = null;
            pbBracoEsq.Image = null;
            pbPernaDir.Image = null;
            pbPernaEsq.Image = null;

            contaAcertos = 0;
            contaErros = 0;

            lblLetras.Text = "";
            lblContVitorias.Text = "Total de Vitórias: " + compartilha.getVitorias();

            btnVerificar.Enabled = true;
            sortearPalavra();
        }

        private void FrmForca_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!mudarTema) Application.Exit();
        }

        private void btnNovoTema_Click(object sender, EventArgs e)
        {
            mudarTema = true;
            this.Close();
        }


    } // Fim classe
}
