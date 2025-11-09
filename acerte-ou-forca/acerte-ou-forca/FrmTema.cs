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
    public partial class FrmTema : Form
    {
        Compartilha comp = new Compartilha();

        public FrmTema()
        {
            InitializeComponent();
        }

        private void obterPalavras(Compartilha.Tema tema)
        {
            var arquivo = "";
            switch (tema)
            {
                case Compartilha.Tema.Animais:
                    arquivo = "animais.txt";
                    break;
                case Compartilha.Tema.Papelaria:
                    arquivo = "papelaria.txt";
                    break;
                case Compartilha.Tema.Eletronicos:
                    arquivo = "eletronicos.txt";
                    break;
            }

            string[] linhas = File.ReadAllLines(arquivo);

            if (linhas == null || linhas.Length == 0)
            {
                MessageBox.Show("Não foi possível obter as palavras");
                return;
            }

            comp.setTema(tema);
            comp.setPalavras(linhas);
        }

        private void iniciarJogo()
        {
            var frm = new FrmForca();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            obterPalavras(Compartilha.Tema.Animais);
            iniciarJogo();
        }

        private void btnPapelaria_Click(object sender, EventArgs e)
        {
            obterPalavras(Compartilha.Tema.Papelaria);
            iniciarJogo();
        }

        private void btnEletronicos_Click(object sender, EventArgs e)
        {
            obterPalavras(Compartilha.Tema.Eletronicos);
            iniciarJogo();
        }
    }
}
