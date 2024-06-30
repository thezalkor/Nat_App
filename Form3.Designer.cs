namespace Natalie_App
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            button_MedReturn = new Button();
            textBox_DoseStr = new TextBox();
            panel1 = new Panel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            textBox_RefillRemain = new TextBox();
            textBox_Pharm = new TextBox();
            textBox_DateFilled = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBox_Expire = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox_MedSched = new TextBox();
            textBox_Prescribe = new TextBox();
            textBox_Dose = new TextBox();
            textBox_MedName = new TextBox();
            listBox_Meds = new ListBox();
            errorProvider_Medications = new ErrorProvider(components);
            panel2 = new Panel();
            button_AddMed = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Medications).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button_MedReturn
            // 
            button_MedReturn.Location = new Point(702, 12);
            button_MedReturn.Name = "button_MedReturn";
            button_MedReturn.Size = new Size(75, 23);
            button_MedReturn.TabIndex = 0;
            button_MedReturn.Text = "Return";
            button_MedReturn.UseVisualStyleBackColor = true;
            button_MedReturn.Click += button_MedReturn_Click;
            // 
            // textBox_DoseStr
            // 
            textBox_DoseStr.Location = new Point(169, 62);
            textBox_DoseStr.Name = "textBox_DoseStr";
            textBox_DoseStr.Size = new Size(33, 23);
            textBox_DoseStr.TabIndex = 1;
            textBox_DoseStr.KeyPress += textBox_DoseStr_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBox_RefillRemain);
            panel1.Controls.Add(textBox_Pharm);
            panel1.Controls.Add(textBox_DateFilled);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox_Expire);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox_MedSched);
            panel1.Controls.Add(textBox_Prescribe);
            panel1.Controls.Add(textBox_Dose);
            panel1.Controls.Add(textBox_MedName);
            panel1.Controls.Add(textBox_DoseStr);
            panel1.Location = new Point(12, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 318);
            panel1.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(208, 120);
            label12.Name = "label12";
            label12.Size = new Size(29, 15);
            label12.TabIndex = 21;
            label12.Text = "MLs";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(208, 65);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 20;
            label11.Text = "MEQ/ML";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 255);
            label10.Name = "label10";
            label10.Size = new Size(98, 15);
            label10.TabIndex = 19;
            label10.Text = "Refills Remaining";
            // 
            // textBox_RefillRemain
            // 
            textBox_RefillRemain.Location = new Point(20, 273);
            textBox_RefillRemain.Name = "textBox_RefillRemain";
            textBox_RefillRemain.Size = new Size(43, 23);
            textBox_RefillRemain.TabIndex = 18;
            textBox_RefillRemain.KeyPress += textBox_RefillRemain_KeyPress;
            // 
            // textBox_Pharm
            // 
            textBox_Pharm.Location = new Point(169, 218);
            textBox_Pharm.Name = "textBox_Pharm";
            textBox_Pharm.Size = new Size(100, 23);
            textBox_Pharm.TabIndex = 17;
            textBox_Pharm.KeyPress += textBox_Pharm_KeyPress;
            // 
            // textBox_DateFilled
            // 
            textBox_DateFilled.Location = new Point(20, 218);
            textBox_DateFilled.Name = "textBox_DateFilled";
            textBox_DateFilled.Size = new Size(100, 23);
            textBox_DateFilled.TabIndex = 16;
            textBox_DateFilled.KeyPress += textBox_DateFilled_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 200);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 15;
            label9.Text = "Date Filled";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(169, 200);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 14;
            label8.Text = "Pharmacy";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(169, 150);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 13;
            label7.Text = "Expiration";
            // 
            // textBox_Expire
            // 
            textBox_Expire.Location = new Point(169, 168);
            textBox_Expire.Name = "textBox_Expire";
            textBox_Expire.Size = new Size(100, 23);
            textBox_Expire.TabIndex = 12;
            textBox_Expire.KeyPress += textBox_Expire_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 150);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 11;
            label6.Text = "Doctor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 99);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 10;
            label5.Text = "Schedule";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(169, 99);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 9;
            label4.Text = "Dose";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 44);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 8;
            label3.Text = "Dosage Strength";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 44);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 7;
            label2.Text = "Medication Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Size = new Size(313, 18);
            label1.TabIndex = 6;
            label1.Text = "Enter Medication Information Here";
            // 
            // textBox_MedSched
            // 
            textBox_MedSched.Location = new Point(20, 117);
            textBox_MedSched.Name = "textBox_MedSched";
            textBox_MedSched.Size = new Size(100, 23);
            textBox_MedSched.TabIndex = 5;
            // 
            // textBox_Prescribe
            // 
            textBox_Prescribe.Location = new Point(20, 168);
            textBox_Prescribe.Name = "textBox_Prescribe";
            textBox_Prescribe.Size = new Size(100, 23);
            textBox_Prescribe.TabIndex = 4;
            textBox_Prescribe.KeyPress += textBox_Prescribe_KeyPress;
            // 
            // textBox_Dose
            // 
            textBox_Dose.Location = new Point(169, 117);
            textBox_Dose.Name = "textBox_Dose";
            textBox_Dose.Size = new Size(33, 23);
            textBox_Dose.TabIndex = 3;
            textBox_Dose.KeyPress += textBox_Dose_KeyPress;
            // 
            // textBox_MedName
            // 
            textBox_MedName.Location = new Point(20, 62);
            textBox_MedName.Name = "textBox_MedName";
            textBox_MedName.Size = new Size(100, 23);
            textBox_MedName.TabIndex = 2;
            textBox_MedName.KeyPress += textBox_MedName_Keypress;
            // 
            // listBox_Meds
            // 
            listBox_Meds.FormattingEnabled = true;
            listBox_Meds.ItemHeight = 15;
            listBox_Meds.Location = new Point(474, 91);
            listBox_Meds.Name = "listBox_Meds";
            listBox_Meds.Size = new Size(257, 319);
            listBox_Meds.TabIndex = 3;
            listBox_Meds.MouseDoubleClick += listBox_Meds_MouseDoubleClick;
            // 
            // errorProvider_Medications
            // 
            errorProvider_Medications.ContainerControl = this;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(button_AddMed);
            panel2.Location = new Point(390, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(78, 240);
            panel2.TabIndex = 4;
            // 
            // button_AddMed
            // 
            button_AddMed.BackColor = Color.Green;
            button_AddMed.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_AddMed.Location = new Point(0, 82);
            button_AddMed.Name = "button_AddMed";
            button_AddMed.Size = new Size(78, 79);
            button_AddMed.TabIndex = 0;
            button_AddMed.Text = "Add Med";
            button_AddMed.UseVisualStyleBackColor = false;
            button_AddMed.Click += button_AddMed_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(listBox_Meds);
            Controls.Add(panel1);
            Controls.Add(button_MedReturn);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Medications).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button_MedReturn;
        private TextBox textBox_DoseStr;
        private Panel panel1;
        private Label label1;
        private TextBox textBox_MedSched;
        private TextBox textBox_Prescribe;
        private TextBox textBox_Dose;
        private TextBox textBox_MedName;
        private TextBox textBox_Expire;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListBox listBox_Meds;
        private Label label10;
        private TextBox textBox_RefillRemain;
        private TextBox textBox_Pharm;
        private TextBox textBox_DateFilled;
        private Label label9;
        private Label label8;
        private Label label7;
        private ErrorProvider errorProvider_Medications;
        private Label label11;
        private Label label12;
        private Panel panel2;
        private Button button_AddMed;
    }
}