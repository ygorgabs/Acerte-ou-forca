using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acerte_ou_forca
{
    public partial class FrmTema : Form
    {
        public FrmTema()
        {
            InitializeComponent();
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            FrmForca frm = new FrmForca();
            frm.Show();
            this.Hide();
        }
    }
}
