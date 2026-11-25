using System;
using System.Drawing; // Mouhema lel tsawer
using System.Windows.Forms;

namespace TP1_Structures
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        // Hédhi l'fonction elli bech tsa8ar l'tsawer
        private void frmAccueil_Load(object sender, EventArgs e)
        {
            if (BtnFactor.Image != null) BtnFactor.Image = new Bitmap(BtnFactor.Image, new Size(32, 32));
            if (BtnTa.Image != null) BtnTa.Image = new Bitmap(BtnTa.Image, new Size(32, 32));
            if (BtnJou.Image != null) BtnJou.Image = new Bitmap(BtnJou.Image, new Size(32, 32));
            if (BtnOuitt.Image != null) BtnOuitt.Image = new Bitmap(BtnOuitt.Image, new Size(32, 32));
        }

        private void BtnFactor_Click(object sender, EventArgs e)
        {
            frmFactoriel f = new frmFactoriel();
            f.Show();
            this.Hide();
        }

        private void BtnTa_Click(object sender, EventArgs e)
        {
            frmTableaux f = new frmTableaux();
            f.Show();
            this.Hide();
        }

        private void BtnJou_Click(object sender, EventArgs e)
        {
            frmJeu f = new frmJeu();
            f.Show();
            this.Hide();
        }

        private void BtnOuitt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}