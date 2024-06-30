namespace Natalie_App
{
    partial class MedInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            label_MedName = new Label();
            label_Pharm = new Label();
            label_Prescribe = new Label();
            label_DoseStr = new Label();
            label_Dose = new Label();
            label_Expire = new Label();
            label_RefillRemain = new Label();
            label_Sched = new Label();
            label_DateFilled = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_MedName
            // 
            label_MedName.AutoSize = true;
            label_MedName.Location = new Point(18, 17);
            label_MedName.Name = "label_MedName";
            label_MedName.Size = new Size(102, 15);
            label_MedName.TabIndex = 0;
            label_MedName.Text = "Medication Name";
            // 
            // label_Pharm
            // 
            label_Pharm.AutoSize = true;
            label_Pharm.Location = new Point(384, 17);
            label_Pharm.Name = "label_Pharm";
            label_Pharm.Size = new Size(64, 15);
            label_Pharm.TabIndex = 1;
            label_Pharm.Text = "Pharmarcy";
            // 
            // label_Prescribe
            // 
            label_Prescribe.AutoSize = true;
            label_Prescribe.Location = new Point(18, 140);
            label_Prescribe.Name = "label_Prescribe";
            label_Prescribe.Size = new Size(59, 15);
            label_Prescribe.TabIndex = 2;
            label_Prescribe.Text = "Prescriber";
            // 
            // label_DoseStr
            // 
            label_DoseStr.AutoSize = true;
            label_DoseStr.Location = new Point(18, 113);
            label_DoseStr.Name = "label_DoseStr";
            label_DoseStr.Size = new Size(115, 15);
            label_DoseStr.TabIndex = 3;
            label_DoseStr.Text = "Medication Strength";
            // 
            // label_Dose
            // 
            label_Dose.AutoSize = true;
            label_Dose.Location = new Point(18, 43);
            label_Dose.Name = "label_Dose";
            label_Dose.Size = new Size(109, 15);
            label_Dose.TabIndex = 4;
            label_Dose.Text = "Medication Dosage";
            // 
            // label_Expire
            // 
            label_Expire.AutoSize = true;
            label_Expire.Location = new Point(384, 68);
            label_Expire.Name = "label_Expire";
            label_Expire.Size = new Size(87, 15);
            label_Expire.TabIndex = 5;
            label_Expire.Text = "Expiration Date";
            // 
            // label_RefillRemain
            // 
            label_RefillRemain.AutoSize = true;
            label_RefillRemain.Location = new Point(386, 43);
            label_RefillRemain.Name = "label_RefillRemain";
            label_RefillRemain.Size = new Size(62, 15);
            label_RefillRemain.TabIndex = 6;
            label_RefillRemain.Text = "Date Filled";
            // 
            // label_Sched
            // 
            label_Sched.AutoSize = true;
            label_Sched.Location = new Point(384, 94);
            label_Sched.Name = "label_Sched";
            label_Sched.Size = new Size(98, 15);
            label_Sched.TabIndex = 7;
            label_Sched.Text = "Remaining Refills";
            // 
            // label_DateFilled
            // 
            label_DateFilled.AutoSize = true;
            label_DateFilled.Location = new Point(19, 78);
            label_DateFilled.Name = "label_DateFilled";
            label_DateFilled.Size = new Size(114, 15);
            label_DateFilled.TabIndex = 8;
            label_DateFilled.Text = "Times Taken Per Day";
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlanchedAlmond;
            panel1.Controls.Add(label_MedName);
            panel1.Controls.Add(label_DateFilled);
            panel1.Controls.Add(label_Pharm);
            panel1.Controls.Add(label_Sched);
            panel1.Controls.Add(label_Prescribe);
            panel1.Controls.Add(label_RefillRemain);
            panel1.Controls.Add(label_DoseStr);
            panel1.Controls.Add(label_Expire);
            panel1.Controls.Add(label_Dose);
            panel1.Location = new Point(37, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 174);
            panel1.TabIndex = 9;
            // 
            // MedInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "MedInfoForm";
            Text = "Medication Info";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label_MedName;
        private Label label_Pharm;
        private Label label_Prescribe;
        private Label label_DoseStr;
        private Label label_Dose;
        private Label label_Expire;
        private Label label_RefillRemain;
        private Label label_Sched;
        private Label label_DateFilled;
        private Panel panel1;
    }
}