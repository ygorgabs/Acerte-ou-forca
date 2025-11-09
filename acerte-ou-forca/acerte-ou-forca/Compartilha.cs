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

        public string[] getPalavras()
        {
            return palavras;
        }
        
        public void setPalavras(string[] palavras2)
        {
            palavras = palavras2;
        }

   
    }
}
