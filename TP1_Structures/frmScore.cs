using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP1_Structures
{
    public partial class frmScore : Form
    {
        public frmScore()
        {
            InitializeComponent();
        }

        private void frmScore_Load(object sender, EventArgs e)
        {
            // 1. Nsa8rou l'tsawer
            if (BtnInit.Image != null) BtnInit.Image = new Bitmap(BtnInit.Image, new Size(24, 24));
            if (BtnCalc.Image != null) BtnCalc.Image = new Bitmap(BtnCalc.Image, new Size(24, 24));
            if (BtnAjout.Image != null) BtnAjout.Image = new Bitmap(BtnAjout.Image, new Size(24, 24));
            if (BtnQuit.Image != null) BtnQuit.Image = new Bitmap(BtnQuit.Image, new Size(24, 24));

            // 2. L'code mte3 l'heure w date
            LblDate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) { LblHeure.Text = DateTime.Now.ToLongTimeString(); }

        private void TxtLang_KeyPress(object sender, KeyPressEventArgs e) { if ((e.KeyChar < '0') || (e.KeyChar > '9')) e.KeyChar = (char)0; }
        private void TxtTech_KeyPress(object sender, KeyPressEventArgs e) { if ((e.KeyChar < '0') || (e.KeyChar > '9')) e.KeyChar = (char)0; }

        private void TxtLang_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (TxtLang.Text == "") { MessageBox.Show("Il faut saisir une note"); e.Cancel = true; }
            else if (int.Parse(TxtLang.Text) > 20) { MessageBox.Show("Note entre 0 et 20"); TxtLang.SelectAll(); e.Cancel = true; }
        }

        private void TxtTech_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (TxtTech.Text == "") { MessageBox.Show("Il faut saisir une note"); e.Cancel = true; }
            else if (int.Parse(TxtTech.Text) > 20) { MessageBox.Show("Note entre 0 et 20"); TxtTech.SelectAll(); e.Cancel = true; }
        }

        private void BtnChance_Click(object sender, EventArgs e) { TxtChance.Text = new Random().Next(0, 16).ToString(); }

        private void BtnInit_Click(object sender, EventArgs e)
        {
            TxtCin.Text = ""; TxtTel.Text = ""; TxtNom.Text = ""; TxtPrenom.Text = "";
            TxtLang.Text = "0"; TxtTech.Text = "0"; TxtChance.Text = "0"; TxtScore.Text = "";
            RdFem.Checked = false; RdMas.Checked = false;
            ChkExper.Checked = false; ChkMotiv.Checked = false; ChkDip.Checked = false;
            CmbAge.SelectedIndex = -1; BtnAjout.Enabled = false;
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (TxtCin.Text == "" || TxtNom.Text == "" || TxtPrenom.Text == "" || CmbAge.SelectedIndex == -1)
            {
                MessageBox.Show("Il faut saisir toutes les informations"); return;
            }

            int note = int.Parse(TxtLang.Text) + int.Parse(TxtTech.Text);
            int sexe = RdMas.Checked ? 7 : (RdFem.Checked ? 5 : 0);

            int bonus = 0;
            if (ChkExper.Checked) bonus += 15;
            if (ChkMotiv.Checked) bonus += 10;
            if (ChkDip.Checked) bonus += 5;

            int age = 0;
            if (CmbAge.SelectedIndex == 0) age = 20;
            else if (CmbAge.SelectedIndex == 1) age = 10;
            else if (CmbAge.SelectedIndex == 2) age = 5;

            int chance = TxtChance.Text != "" ? int.Parse(TxtChance.Text) : 0;

            TxtScore.Text = (note + sexe + bonus + age + chance).ToString();
            BtnAjout.Enabled = true;
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            Lst1.Items.Add(TxtCin.Text); Lst2.Items.Add(TxtNom.Text); Lst3.Items.Add(TxtPrenom.Text); Lst4.Items.Add(TxtScore.Text);
            BtnInit.PerformClick();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            new frmAccueil().Show();
            this.Close();
        }
    }
}