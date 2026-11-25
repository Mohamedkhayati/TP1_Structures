namespace TP1_Structures
{
    partial class frmJeu
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Txt1 = new TextBox();
            Txt2 = new TextBox();
            Txt3 = new TextBox();
            Txt4 = new TextBox();
            TxtP1 = new TextBox();
            TxtP2 = new TextBox();
            TxtP3 = new TextBox();
            TxtP4 = new TextBox();
            LblNbJeu = new Label();
            BtnAfficher = new Button();
            BtnCacher = new Button();
            BtnRejouer = new Button();
            BtnVerifier = new Button();
            BtnQuitter = new Button();
            GrB1 = new GroupBox();
            timer1 = new System.Windows.Forms.Timer(components);
            GrB1.SuspendLayout();
            SuspendLayout();
            // 
            // Txt1
            // 
            Txt1.Location = new Point(20, 20);
            Txt1.Name = "Txt1";
            Txt1.Size = new Size(40, 23);
            Txt1.TabIndex = 0;
            // 
            // Txt2
            // 
            Txt2.Location = new Point(70, 20);
            Txt2.Name = "Txt2";
            Txt2.Size = new Size(40, 23);
            Txt2.TabIndex = 1;
            // 
            // Txt3
            // 
            Txt3.Location = new Point(120, 20);
            Txt3.Name = "Txt3";
            Txt3.Size = new Size(40, 23);
            Txt3.TabIndex = 2;
            // 
            // Txt4
            // 
            Txt4.Location = new Point(170, 20);
            Txt4.Name = "Txt4";
            Txt4.Size = new Size(40, 23);
            Txt4.TabIndex = 3;
            // 
            // TxtP1
            // 
            TxtP1.Location = new Point(20, 100);
            TxtP1.Name = "TxtP1";
            TxtP1.Size = new Size(40, 23);
            TxtP1.TabIndex = 4;
            // 
            // TxtP2
            // 
            TxtP2.Location = new Point(70, 100);
            TxtP2.Name = "TxtP2";
            TxtP2.Size = new Size(40, 23);
            TxtP2.TabIndex = 5;
            // 
            // TxtP3
            // 
            TxtP3.Location = new Point(120, 100);
            TxtP3.Name = "TxtP3";
            TxtP3.Size = new Size(40, 23);
            TxtP3.TabIndex = 6;
            // 
            // TxtP4
            // 
            TxtP4.Location = new Point(170, 100);
            TxtP4.Name = "TxtP4";
            TxtP4.Size = new Size(40, 23);
            TxtP4.TabIndex = 7;
            // 
            // LblNbJeu
            // 
            LblNbJeu.AutoSize = true;
            LblNbJeu.Location = new Point(230, 20);
            LblNbJeu.Name = "LblNbJeu";
            LblNbJeu.Size = new Size(13, 15);
            LblNbJeu.TabIndex = 8;
            LblNbJeu.Text = "1";
            // 
            // BtnAfficher
            // 
            BtnAfficher.Image = Properties.Resources.Purple_question_mark_icon;
            BtnAfficher.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAfficher.Location = new Point(280, 15);
            BtnAfficher.Name = "BtnAfficher";
            BtnAfficher.Size = new Size(110, 35);
            BtnAfficher.TabIndex = 9;
            BtnAfficher.Text = "Afficher";
            BtnAfficher.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnAfficher.Click += BtnAfficher_Click;
            // 
            // BtnCacher
            // 
            BtnCacher.Image = Properties.Resources.Red_minus_circle_icon;
            BtnCacher.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCacher.Location = new Point(280, 60);
            BtnCacher.Name = "BtnCacher";
            BtnCacher.Size = new Size(110, 35);
            BtnCacher.TabIndex = 10;
            BtnCacher.Text = "Cacher";
            BtnCacher.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCacher.Click += BtnCacher_Click;
            // 
            // BtnRejouer
            // 
            BtnRejouer.Image = Properties.Resources.Green_refresh_icon;
            BtnRejouer.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRejouer.Location = new Point(20, 150);
            BtnRejouer.Name = "BtnRejouer";
            BtnRejouer.Size = new Size(110, 35);
            BtnRejouer.TabIndex = 11;
            BtnRejouer.Text = "Rejouer";
            BtnRejouer.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnRejouer.Click += BtnRejouer_Click;
            // 
            // BtnVerifier
            // 
            BtnVerifier.Image = Properties.Resources.Green_checkmark_circle_icon1;
            BtnVerifier.ImageAlign = ContentAlignment.MiddleLeft;
            BtnVerifier.Location = new Point(280, 105);
            BtnVerifier.Name = "BtnVerifier";
            BtnVerifier.Size = new Size(110, 35);
            BtnVerifier.TabIndex = 12;
            BtnVerifier.Text = "Vérifier";
            BtnVerifier.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnVerifier.Click += BtnVerifier_Click;
            // 
            // BtnQuitter
            // 
            BtnQuitter.Image = Properties.Resources.Red_stop_button_icon;
            BtnQuitter.ImageAlign = ContentAlignment.MiddleLeft;
            BtnQuitter.Location = new Point(150, 150);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(110, 35);
            BtnQuitter.TabIndex = 13;
            BtnQuitter.Text = "Quitter";
            BtnQuitter.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnQuitter.Click += BtnQuitter_Click;
            // 
            // GrB1
            // 
            GrB1.Controls.Add(Txt1);
            GrB1.Controls.Add(Txt2);
            GrB1.Controls.Add(Txt3);
            GrB1.Controls.Add(Txt4);
            GrB1.Controls.Add(TxtP1);
            GrB1.Controls.Add(TxtP2);
            GrB1.Controls.Add(TxtP3);
            GrB1.Controls.Add(TxtP4);
            GrB1.Controls.Add(LblNbJeu);
            GrB1.Controls.Add(BtnAfficher);
            GrB1.Controls.Add(BtnCacher);
            GrB1.Controls.Add(BtnRejouer);
            GrB1.Controls.Add(BtnVerifier);
            GrB1.Controls.Add(BtnQuitter);
            GrB1.Location = new Point(20, 20);
            GrB1.Name = "GrB1";
            GrB1.Size = new Size(400, 200);
            GrB1.TabIndex = 0;
            GrB1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // frmJeu
            // 
            ClientSize = new Size(450, 250);
            Controls.Add(GrB1);
            Name = "frmJeu";
            Text = "Jeux";
            Load += frmJeu_Load;
            GrB1.ResumeLayout(false);
            GrB1.PerformLayout();
            ResumeLayout(false);
        }
        private System.Windows.Forms.TextBox Txt1, Txt2, Txt3, Txt4, TxtP1, TxtP2, TxtP3, TxtP4;
        private System.Windows.Forms.Label LblNbJeu;
        private System.Windows.Forms.Button BtnAfficher, BtnCacher, BtnRejouer, BtnVerifier, BtnQuitter;
        private System.Windows.Forms.GroupBox GrB1;
        private System.Windows.Forms.Timer timer1;
    }
}