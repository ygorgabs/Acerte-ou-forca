using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acerte_ou_forca
{
    public class Compartilha
    {
        public enum Tema
        {
            Animais,
            Papelaria,
            Eletronicos
        }

        private static string[] palavras;
        private static int vitorias = 0;
        private static Tema tema;

        public string[] getPalavras()
        {
            return palavras;
        }
        
        public void setPalavras(string[] palavras2)
        {
            palavras = palavras2;
        }

        public int getVitorias()
        {
            return vitorias;
        }

        public void setVitorias()
        {
            vitorias++;
        }

        public Tema getTema()
        {
            return tema;
        }

        public void setTema(Tema tema2)
        {
            tema = tema2;
        }
    }
}
