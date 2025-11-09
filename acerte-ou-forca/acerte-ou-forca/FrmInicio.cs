namespace acerte_ou_forca
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmTema frm = new FrmTema();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
