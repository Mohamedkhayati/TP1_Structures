using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP1_Structures
{
    public partial class frmTableaux : Form
    {
        const int n = 5;
        float[] T = new float[n];
        int i = 0;

        public frmTableaux()
        {
            InitializeComponent();
        }

        // Hédhi l'fonction elli bech tsa8ar l'tsawer
        private void frmTableaux_Load(object sender, EventArgs e)
        {
            if (BtnEnreg.Image != null) BtnEnreg.Image = new Bitmap(BtnEnreg.Image, new Size(24, 24));
            if (BtnCalc.Image != null) BtnCalc.Image = new Bitmap(BtnCalc.Image, new Size(24, 24));
            if (BtnQ.Image != null) BtnQ.Image = new Bitmap(BtnQ.Image, new Size(24, 24));
        }

        private void BtnEnreg_Click(object sender, EventArgs e)
        {
            if (float.TryParse(TxtN.Text, out float val) && val >= 0)
            {
                T[i] = val;
                LblT.Text += TxtN.Text + " | ";
                i++;
                TxtN.Clear(); TxtN.Focus();
                LblRes.Text = "Entrez la note de l'élève N°: " + (i + 1);

                if (i == n)
                {
                    BtnCalc.Enabled = true; BtnEnreg.Enabled = false; TxtN.Enabled = false;
                }
            }
            else { MessageBox.Show("Saisie invalide."); }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            float somme = 0;
            for (int j = 0; j < n; j++) somme += T[j];
            float moy = somme / n;
            LblMoy.Text = moy.ToString("F2");

            float sommeCarre = 0;
            for (int j = 0; j < n; j++) sommeCarre += (float)Math.Pow(T[j] - moy, 2);
            LblEcart.Text = Math.Sqrt(sommeCarre / n).ToString("F4");

            int inf = 0, sup = 0;
            for (int j = 0; j < n; j++) { if (T[j] < 10) inf++; else sup++; }
            LblInf.Text = inf.ToString(); LblSup.Text = sup.ToString();
        }

        private void BtnQ_Click(object sender, EventArgs e)
        {
            new frmAccueil().Show();
            this.Close();
        }
    }
}