namespace TP1_Structures
{
    partial class frmScore
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxtCin = new System.Windows.Forms.TextBox(); this.TxtTel = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox(); this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtLang = new System.Windows.Forms.TextBox(); this.TxtTech = new System.Windows.Forms.TextBox();
            this.TxtChance = new System.Windows.Forms.TextBox(); this.TxtScore = new System.Windows.Forms.TextBox();
            this.LblDate = new System.Windows.Forms.Label(); this.LblHeure = new System.Windows.Forms.Label();
            this.RdMas = new System.Windows.Forms.RadioButton(); this.RdFem = new System.Windows.Forms.RadioButton();
            this.ChkExper = new System.Windows.Forms.CheckBox(); this.ChkMotiv = new System.Windows.Forms.CheckBox(); this.ChkDip = new System.Windows.Forms.CheckBox();
            this.CmbAge = new System.Windows.Forms.ComboBox();
            this.BtnCalc = new System.Windows.Forms.Button(); this.BtnQuit = new System.Windows.Forms.Button();
            this.BtnInit = new System.Windows.Forms.Button(); this.BtnChance = new System.Windows.Forms.Button(); this.BtnAjout = new System.Windows.Forms.Button();
            this.Lst1 = new System.Windows.Forms.ListBox(); this.Lst2 = new System.Windows.Forms.ListBox(); this.Lst3 = new System.Windows.Forms.ListBox(); this.Lst4 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // Textboxes
            this.TxtCin.Location = new System.Drawing.Point(80, 20); this.TxtCin.Name = "TxtCin"; this.TxtCin.MaxLength = 8;
            this.TxtTel.Location = new System.Drawing.Point(80, 60); this.TxtTel.Name = "TxtTel";
            this.TxtNom.Location = new System.Drawing.Point(250, 20); this.TxtNom.Name = "TxtNom";
            this.TxtPrenom.Location = new System.Drawing.Point(250, 60); this.TxtPrenom.Name = "TxtPrenom";
            this.TxtLang.Location = new System.Drawing.Point(80, 100); this.TxtLang.Name = "TxtLang"; this.TxtLang.Text = "0"; this.TxtLang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLang_KeyPress); this.TxtLang.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLang_Validating);
            this.TxtTech.Location = new System.Drawing.Point(80, 140); this.TxtTech.Name = "TxtTech"; this.TxtTech.Text = "0"; this.TxtTech.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTech_KeyPress); this.TxtTech.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTech_Validating);
            this.TxtChance.Location = new System.Drawing.Point(250, 220); this.TxtChance.Name = "TxtChance"; this.TxtChance.Text = "0"; this.TxtChance.ReadOnly = true;
            this.TxtScore.Location = new System.Drawing.Point(80, 280); this.TxtScore.Name = "TxtScore"; this.TxtScore.ReadOnly = true;
            // Radios / Checks
            this.RdMas.Location = new System.Drawing.Point(250, 100); this.RdMas.Name = "RdMas"; this.RdMas.Text = "Masculin";
            this.RdFem.Location = new System.Drawing.Point(250, 130); this.RdFem.Name = "RdFem"; this.RdFem.Text = "Féminin";
            this.ChkExper.Location = new System.Drawing.Point(80, 180); this.ChkExper.Name = "ChkExper"; this.ChkExper.Text = "Expérience";
            this.ChkMotiv.Location = new System.Drawing.Point(200, 180); this.ChkMotiv.Name = "ChkMotiv"; this.ChkMotiv.Text = "Motivations";
            this.ChkDip.Location = new System.Drawing.Point(320, 180); this.ChkDip.Name = "ChkDip"; this.ChkDip.Text = "Diplômes";
            // Combo
            this.CmbAge.Location = new System.Drawing.Point(80, 220); this.CmbAge.Name = "CmbAge";
            this.CmbAge.Items.AddRange(new object[] { "20-30", "30-40", "40 et plus" });
            // Labels Date/Time
            this.LblDate.AutoSize = true; this.LblDate.Location = new System.Drawing.Point(450, 20); this.LblDate.Name = "LblDate";
            this.LblHeure.AutoSize = true; this.LblHeure.Location = new System.Drawing.Point(450, 50); this.LblHeure.Name = "LblHeure";
            // Buttons
            this.BtnChance.Location = new System.Drawing.Point(400, 215); this.BtnChance.Name = "BtnChance"; this.BtnChance.Size = new System.Drawing.Size(90, 30); this.BtnChance.Text = "Générer";
            this.BtnChance.Click += new System.EventHandler(this.BtnChance_Click);

            this.BtnInit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInit.Location = new System.Drawing.Point(80, 320); this.BtnInit.Name = "BtnInit"; this.BtnInit.Size = new System.Drawing.Size(110, 35); this.BtnInit.Text = "Initialiser";
            this.BtnInit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInit.Click += new System.EventHandler(this.BtnInit_Click);

            this.BtnCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCalc.Location = new System.Drawing.Point(200, 320); this.BtnCalc.Name = "BtnCalc"; this.BtnCalc.Size = new System.Drawing.Size(110, 35); this.BtnCalc.Text = "Calculer";
            this.BtnCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);

            this.BtnAjout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjout.Location = new System.Drawing.Point(320, 320); this.BtnAjout.Name = "BtnAjout"; this.BtnAjout.Size = new System.Drawing.Size(110, 35); this.BtnAjout.Text = "Ajouter"; this.BtnAjout.Enabled = false;
            this.BtnAjout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);

            this.BtnQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQuit.Location = new System.Drawing.Point(440, 320); this.BtnQuit.Name = "BtnQuit"; this.BtnQuit.Size = new System.Drawing.Size(110, 35); this.BtnQuit.Text = "Quitter";
            this.BtnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // Lists
            this.Lst1.Location = new System.Drawing.Point(80, 380); this.Lst1.Name = "Lst1"; this.Lst1.Size = new System.Drawing.Size(100, 100);
            this.Lst2.Location = new System.Drawing.Point(190, 380); this.Lst2.Name = "Lst2"; this.Lst2.Size = new System.Drawing.Size(100, 100);
            this.Lst3.Location = new System.Drawing.Point(300, 380); this.Lst3.Name = "Lst3"; this.Lst3.Size = new System.Drawing.Size(100, 100);
            this.Lst4.Location = new System.Drawing.Point(410, 380); this.Lst4.Name = "Lst4"; this.Lst4.Size = new System.Drawing.Size(100, 100);
            // Timer
            this.timer1.Interval = 1000; this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // Form
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.Lst1); this.Controls.Add(this.Lst2); this.Controls.Add(this.Lst3); this.Controls.Add(this.Lst4);
            this.Controls.Add(this.BtnQuit); this.Controls.Add(this.BtnAjout); this.Controls.Add(this.BtnCalc); this.Controls.Add(this.BtnInit);
            this.Controls.Add(this.BtnChance); this.Controls.Add(this.LblHeure); this.Controls.Add(this.LblDate); this.Controls.Add(this.CmbAge);
            this.Controls.Add(this.ChkDip); this.Controls.Add(this.ChkMotiv); this.Controls.Add(this.ChkExper); this.Controls.Add(this.RdFem);
            this.Controls.Add(this.RdMas); this.Controls.Add(this.TxtScore); this.Controls.Add(this.TxtChance); this.Controls.Add(this.TxtTech);
            this.Controls.Add(this.TxtLang); this.Controls.Add(this.TxtPrenom); this.Controls.Add(this.TxtNom); this.Controls.Add(this.TxtTel); this.Controls.Add(this.TxtCin);
            this.Name = "frmScore"; this.Text = "Calcul de score";
            this.Load += new System.EventHandler(this.frmScore_Load);
            this.ResumeLayout(false); this.PerformLayout();
        }
        private System.Windows.Forms.TextBox TxtCin, TxtTel, TxtNom, TxtPrenom, TxtLang, TxtTech, TxtChance, TxtScore;
        private System.Windows.Forms.Label LblDate, LblHeure;
        private System.Windows.Forms.RadioButton RdMas, RdFem;
        private System.Windows.Forms.CheckBox ChkExper, ChkMotiv, ChkDip;
        private System.Windows.Forms.ComboBox CmbAge;
        private System.Windows.Forms.Button BtnCalc, BtnQuit, BtnInit, BtnChance, BtnAjout;
        private System.Windows.Forms.ListBox Lst1, Lst2, Lst3, Lst4;
        private System.Windows.Forms.Timer timer1;
    }
}