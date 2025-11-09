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
        String[] palavras;

        public FrmForca()
        {
            InitializeComponent();
        }

        private void FrmForca_Load(object sender, EventArgs e)
        {
            palavras = compartilha.getPalavras();
        }
    }
}
