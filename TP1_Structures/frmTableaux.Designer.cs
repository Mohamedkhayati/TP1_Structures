namespace TP1_Structures
{
    partial class frmTableaux
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
            BtnEnreg = new Button();
            BtnCalc = new Button();
            BtnQ = new Button();
            LblRes = new Label();
            LblT = new Label();
            LblMoy = new Label();
            LblEcart = new Label();
            LblInf = new Label();
            LblSup = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // TxtN
            // 
            TxtN.Location = new Point(200, 30);
            TxtN.Name = "TxtN";
            TxtN.Size = new Size(100, 23);
            TxtN.TabIndex = 13;
            // 
            // BtnEnreg
            // 
            BtnEnreg.Image = Properties.Resources.Grey_plus_icon;
            BtnEnreg.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEnreg.Location = new Point(330, 25);
            BtnEnreg.Name = "BtnEnreg";
            BtnEnreg.Size = new Size(130, 40);
            BtnEnreg.TabIndex = 12;
            BtnEnreg.Text = "Enregistrer";
            BtnEnreg.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEnreg.Click += BtnEnreg_Click;
            // 
            // BtnCalc
            // 
            BtnCalc.Enabled = false;
            BtnCalc.Image = Properties.Resources.Green_checkmark_circle_icon;
            BtnCalc.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCalc.Location = new Point(330, 150);
            BtnCalc.Name = "BtnCalc";
            BtnCalc.Size = new Size(130, 45);
            BtnCalc.TabIndex = 11;
            BtnCalc.Text = "Calculer";
            BtnCalc.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCalc.Click += BtnCalc_Click;
            // 
            // BtnQ
            // 
            BtnQ.Image = Properties.Resources.Red_stop_button_icon;
            BtnQ.ImageAlign = ContentAlignment.MiddleLeft;
            BtnQ.Location = new Point(330, 230);
            BtnQ.Name = "BtnQ";
            BtnQ.Size = new Size(130, 45);
            BtnQ.TabIndex = 10;
            BtnQ.Text = "Quitter";
            BtnQ.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnQ.Click += BtnQ_Click;
            // 
            // LblRes
            // 
            LblRes.AutoSize = true;
            LblRes.Location = new Point(30, 30);
            LblRes.Name = "LblRes";
            LblRes.Size = new Size(159, 15);
            LblRes.TabIndex = 9;
            LblRes.Text = "Entrez la note de l'élève N°: 1";
            // 
            // LblT
            // 
            LblT.AutoSize = true;
            LblT.Location = new Point(30, 70);
            LblT.Name = "LblT";
            LblT.Size = new Size(0, 15);
            LblT.TabIndex = 8;
            // 
            // LblMoy
            // 
            LblMoy.AutoSize = true;
            LblMoy.Location = new Point(200, 150);
            LblMoy.Name = "LblMoy";
            LblMoy.Size = new Size(13, 15);
            LblMoy.TabIndex = 7;
            LblMoy.Text = "0";
            // 
            // LblEcart
            // 
            LblEcart.AutoSize = true;
            LblEcart.Location = new Point(200, 190);
            LblEcart.Name = "LblEcart";
            LblEcart.Size = new Size(13, 15);
            LblEcart.TabIndex = 6;
            LblEcart.Text = "0";
            // 
            // LblInf
            // 
            LblInf.AutoSize = true;
            LblInf.Location = new Point(200, 230);
            LblInf.Name = "LblInf";
            LblInf.Size = new Size(13, 15);
            LblInf.TabIndex = 5;
            LblInf.Text = "0";
            // 
            // LblSup
            // 
            LblSup.AutoSize = true;
            LblSup.Location = new Point(200, 270);
            LblSup.Name = "LblSup";
            LblSup.Size = new Size(13, 15);
            LblSup.TabIndex = 4;
            LblSup.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 150);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Moyenne:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 190);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Ecart-type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 230);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Notes < 10:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 270);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Notes >= 10:";
            // 
            // frmTableaux
            // 
            ClientSize = new Size(520, 350);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(LblSup);
            Controls.Add(LblInf);
            Controls.Add(LblEcart);
            Controls.Add(LblMoy);
            Controls.Add(LblT);
            Controls.Add(LblRes);
            Controls.Add(BtnQ);
            Controls.Add(BtnCalc);
            Controls.Add(BtnEnreg);
            Controls.Add(TxtN);
            Name = "frmTableaux";
            Text = "Les Tableaux";
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.TextBox TxtN;
        private System.Windows.Forms.Button BtnEnreg, BtnCalc, BtnQ;
        private System.Windows.Forms.Label LblRes, LblT, LblMoy, LblEcart, LblInf, LblSup, label1, label2, label3, label4;
    }
}