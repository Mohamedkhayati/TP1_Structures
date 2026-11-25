using System;
using System.Windows.Forms;

namespace TP1_Structures
{
    public partial class frmFactoriel : Form
    {
        public frmFactoriel()
        {
            InitializeComponent();
        }
        private void frmFactoriel_Load(object sender, EventArgs e)
        {
            if (BtnCalc.Image != null) BtnCalc.Image = new Bitmap(BtnCalc.Image, new Size(24, 24));
            if (BtnBack.Image != null) BtnBack.Image = new Bitmap(BtnBack.Image, new Size(24, 24));
            if (BtnQuitter.Image != null) BtnQuitter.Image = new Bitmap(BtnQuitter.Image, new Size(24, 24));
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtN.Text, out int n) && n > 0)
            {
                long fact = 1;
                for (int i = 1; i <= n; i++) { fact *= i; }
                LblRes.Text = $"Factoriel ( {n} ) = {fact}";
            }
            else { MessageBox.Show("Veuillez entrer un entier positif > 0"); }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new frmAccueil().Show();
            this.Close();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}