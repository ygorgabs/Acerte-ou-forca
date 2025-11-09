using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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

            foreach (char letra in palavraSelecionada)
            {
                palavraEncriptada += "*";
            }

            lblPalavra.Text = palavraEncriptada;
        }

        private void FrmForca_Load(object sender, EventArgs e)
        {
            palavras = compartilha.getPalavras();
            sortearPalavra();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var letra = txtLetra.Text.ToUpper()[0];
            
            if((int)letra < 65 || (int)letra > 90)
            {
                MessageBox.Show("Permitido somente letras. Por favor, digite um valor de A-Z");
                return;
            }

            lblLetras.Text += letra + " ";

            if (!palavraSelecionada.Contains(letra))
            {
                switch (contaErros)
                {
                    case 0:
                        pbCabeca.Image = Properties.Resources.forca_cabeca;
                        break;
                    case 1:
                        pbTronco.Image = Properties.Resources.forca_tronco;
                        break;
                    case 2:
                        pbBracoDir.Image = Properties.Resources.forca_braco_perna_dir;
                        break;
                    case 3:
                        pbBracoEsq.Image = Properties.Resources.forca_braco_perna_esq;
                        break;
                    case 4:
                        pbPernaDir.Image = Properties.Resources.forca_braco_perna_dir;
                        break;
                    case 5:
                        pbPernaEsq.Image = Properties.Resources.forca_braco_perna_esq;
                        break;
                }

                contaErros++;
                if (contaErros == 6) MessageBox.Show("Sem mais tentativas. Tente novamente com outra palavra");
                return;
            }

            char[] palavra = palavraEncriptada.ToCharArray();
            for (int i  = 0; i < palavraSelecionada.Length; i++)
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
            if (contaAcertos == palavraSelecionada.Length) MessageBox.Show("Parabéns você acertou!!!");
        }
    } // Fim classe
}
