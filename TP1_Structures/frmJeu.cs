using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TP1_Structures
{
    public partial class frmJeu : Form
    {
        List<TextBox> LTxtC = new List<TextBox>();
        List<TextBox> LTxtP = new List<TextBox>();
        int nbJeux = 0;
        bool animation = false;

        public frmJeu()
        {
            InitializeComponent();
        }

        private void frmJeu_Load(object sender, EventArgs e)
        {
            // 1. Nsa8rou l'tsawer
            if (BtnAfficher.Image != null) BtnAfficher.Image = new Bitmap(BtnAfficher.Image, new Size(24, 24));
            if (BtnCacher.Image != null) BtnCacher.Image = new Bitmap(BtnCacher.Image, new Size(24, 24));
            if (BtnRejouer.Image != null) BtnRejouer.Image = new Bitmap(BtnRejouer.Image, new Size(24, 24));
            if (BtnVerifier.Image != null) BtnVerifier.Image = new Bitmap(BtnVerifier.Image, new Size(24, 24));
            if (BtnQuitter.Image != null) BtnQuitter.Image = new Bitmap(BtnQuitter.Image, new Size(24, 24));

            // 2. L'code mte3 l'jeu
            LTxtC.AddRange(new TextBox[] { Txt1, Txt2, Txt3, Txt4 });
            LTxtP.AddRange(new TextBox[] { TxtP1, TxtP2, TxtP3, TxtP4 });
            Random r = new Random();
            int n1, n2, n3, n4;
            n1 = r.Next(0, 10); Txt1.Text = n1.ToString();
            do { n2 = r.Next(0, 10); } while (n2 == n1); Txt2.Text = n2.ToString();
            do { n3 = r.Next(0, 10); } while (n3 == n2 || n3 == n1); Txt3.Text = n3.ToString();
            do { n4 = r.Next(0, 10); } while (n4 == n3 || n4 == n2 || n4 == n1); Txt4.Text = n4.ToString();
        }

        private void BtnCacher_Click(object sender, EventArgs e) { for (int i = 0; i < 4; i++) LTxtC[i].ForeColor = Color.White; }
        private void BtnAfficher_Click(object sender, EventArgs e) { for (int i = 0; i < 4; i++) LTxtC[i].ForeColor = Color.Black; }

        private void BtnRejouer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++) { LTxtP[i].BackColor = Color.White; LTxtP[i].Text = ""; }
            LTxtP[0].Focus();
        }

        private void BtnVerifier_Click(object sender, EventArgs e)
        {
            int correct = 0;
            for (int i = 0; i < 4; i++)
            {
                if (LTxtP[i].Text == LTxtC[i].Text) { LTxtP[i].BackColor = Color.Lime; correct++; }
                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (LTxtP[i].Text == LTxtC[j].Text) { LTxtP[i].BackColor = Color.Yellow; break; }
                    }
                }
            }
            if (correct == 4)
            {
                timer1.Start();
                for (int i = 0; i < 4; i++) LTxtC[i].ForeColor = Color.Black;
            }
            else
            {
                nbJeux++; LblNbJeu.Text = (nbJeux + 1).ToString();
                if (nbJeux == 3)
                {
                    GrB1.Enabled = false;
                    for (int i = 0; i < 4; i++) LTxtC[i].ForeColor = Color.Black;
                    MessageBox.Show("Vous avez perdu", "Game Over");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (animation) { for (int i = 0; i < 4; i++) LTxtC[i].BackColor = Color.Yellow; animation = false; }
            else { for (int i = 0; i < 4; i++) LTxtC[i].BackColor = Color.Red; animation = true; }
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            new frmAccueil().Show();
            this.Close();
        }
    }
}