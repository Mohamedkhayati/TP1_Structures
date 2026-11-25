namespace TP1_Structures
{
    partial class frmAccueil
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            BtnFactor = new Button();
            BtnTa = new Button();
            BtnJou = new Button();
            BtnOuitt = new Button();
            SuspendLayout();
            // 
            // BtnFactor
            // 
            BtnFactor.Image = Properties.Resources.Calculator_icon;
            BtnFactor.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFactor.Location = new Point(150, 40);
            BtnFactor.Name = "BtnFactor";
            BtnFactor.Size = new Size(250, 64);
            BtnFactor.TabIndex = 3;
            BtnFactor.Text = "Calcul Factoriel";
            BtnFactor.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnFactor.UseVisualStyleBackColor = true;
            BtnFactor.Click += BtnFactor_Click;
            // 
            // BtnTa
            // 
            BtnTa.Image = Properties.Resources.Blue_plus_icon;
            BtnTa.ImageAlign = ContentAlignment.MiddleLeft;
            BtnTa.Location = new Point(150, 110);
            BtnTa.Name = "BtnTa";
            BtnTa.Size = new Size(250, 50);
            BtnTa.TabIndex = 2;
            BtnTa.Text = "Les tableaux";
            BtnTa.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnTa.UseVisualStyleBackColor = true;
            BtnTa.Click += BtnTa_Click;
            // 
            // BtnJou
            // 
            BtnJou.Image = Properties.Resources.Gamepad_icon;
            BtnJou.ImageAlign = ContentAlignment.MiddleLeft;
            BtnJou.Location = new Point(150, 180);
            BtnJou.Name = "BtnJou";
            BtnJou.Size = new Size(250, 50);
            BtnJou.TabIndex = 1;
            BtnJou.Text = "Jouer";
            BtnJou.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnJou.UseVisualStyleBackColor = true;
            BtnJou.Click += BtnJou_Click;
            // 
            // BtnOuitt
            // 
            BtnOuitt.Image = Properties.Resources.Red_stop_button_icon;
            BtnOuitt.ImageAlign = ContentAlignment.MiddleLeft;
            BtnOuitt.Location = new Point(150, 250);
            BtnOuitt.Name = "BtnOuitt";
            BtnOuitt.Size = new Size(250, 50);
            BtnOuitt.TabIndex = 0;
            BtnOuitt.Text = "Quitter";
            BtnOuitt.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnOuitt.UseVisualStyleBackColor = true;
            BtnOuitt.Click += BtnOuitt_Click;
            // 
            // frmAccueil
            // 
            ClientSize = new Size(550, 350);
            Controls.Add(BtnOuitt);
            Controls.Add(BtnJou);
            Controls.Add(BtnTa);
            Controls.Add(BtnFactor);
            Name = "frmAccueil";
            Text = "TP 2";
            ResumeLayout(false);
        }
        private System.Windows.Forms.Button BtnFactor, BtnTa, BtnJou, BtnOuitt;
    }
}