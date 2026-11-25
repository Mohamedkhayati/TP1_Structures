namespace TP1_Structures
{
    partial class frmFactoriel
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            TxtN = new TextBox();
            LblRes = new Label();
            BtnCalc = new Button();
            BtnBack = new Button();
            BtnQuitter = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // TxtN
            // 
            TxtN.Location = new Point(200, 57);
            TxtN.Name = "TxtN";
            TxtN.Size = new Size(150, 23);
            TxtN.TabIndex = 5;
            // 
            // LblRes
            // 
            LblRes.AutoSize = true;
            LblRes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblRes.Location = new Point(150, 120);
            LblRes.Name = "LblRes";
            LblRes.Size = new Size(72, 21);
            LblRes.TabIndex = 3;
            LblRes.Text = "Resultat";
            // 
            // BtnCalc
            // 
            BtnCalc.Image = Properties.Resources.Green_checkmark_circle_icon;
            BtnCalc.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCalc.Location = new Point(370, 50);
            BtnCalc.Name = "BtnCalc";
            BtnCalc.Size = new Size(120, 40);
            BtnCalc.TabIndex = 4;
            BtnCalc.Text = "Calculer";
            BtnCalc.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCalc.UseVisualStyleBackColor = true;
            BtnCalc.Click += BtnCalc_Click;
            // 
            // BtnBack
            // 
            BtnBack.Image = Properties.Resources.Green_back_arrow_icon;
            BtnBack.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBack.Location = new Point(100, 200);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(140, 45);
            BtnBack.TabIndex = 2;
            BtnBack.Text = "Retour";
            BtnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnQuitter
            // 
            BtnQuitter.Image = Properties.Resources.Red_stop_button_icon;
            BtnQuitter.ImageAlign = ContentAlignment.MiddleLeft;
            BtnQuitter.Location = new Point(300, 200);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(140, 45);
            BtnQuitter.TabIndex = 1;
            BtnQuitter.Text = "Quitter";
            BtnQuitter.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnQuitter.UseVisualStyleBackColor = true;
            BtnQuitter.Click += BtnQuitter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 60);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 0;
            label1.Text = "Donner un entier positif:";
            // 
            // frmFactoriel
            // 
            ClientSize = new Size(550, 300);
            Controls.Add(label1);
            Controls.Add(BtnQuitter);
            Controls.Add(BtnBack);
            Controls.Add(LblRes);
            Controls.Add(BtnCalc);
            Controls.Add(TxtN);
            Name = "frmFactoriel";
            Text = "Calcul factoriel";
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.TextBox TxtN;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Button BtnCalc, BtnBack, BtnQuitter;
        private System.Windows.Forms.Label label1;
    }
}