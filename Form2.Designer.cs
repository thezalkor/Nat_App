namespace Natalie_App
{
    partial class Form2
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
            button_GoToMeds = new Button();
            label_MedList = new Label();
            button_GoToContacts = new Button();
            button_GoToWeights = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_GoToMeds
            // 
            button_GoToMeds.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_GoToMeds.Location = new Point(258, 19);
            button_GoToMeds.Name = "button_GoToMeds";
            button_GoToMeds.Size = new Size(122, 46);
            button_GoToMeds.TabIndex = 4;
            button_GoToMeds.Text = "Medications";
            button_GoToMeds.UseVisualStyleBackColor = true;
            button_GoToMeds.Click += button_GoToMeds_Click;
            // 
            // label_MedList
            // 
            label_MedList.AutoSize = true;
            label_MedList.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_MedList.Location = new Point(116, 97);
            label_MedList.Name = "label_MedList";
            label_MedList.Size = new Size(534, 25);
            label_MedList.TabIndex = 5;
            label_MedList.Text = "Click on a button to Navigate to those pages";
            label_MedList.UseWaitCursor = true;
            // 
            // button_GoToContacts
            // 
            button_GoToContacts.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_GoToContacts.Location = new Point(480, 19);
            button_GoToContacts.Name = "button_GoToContacts";
            button_GoToContacts.Size = new Size(122, 46);
            button_GoToContacts.TabIndex = 6;
            button_GoToContacts.Text = "Contact List";
            button_GoToContacts.UseVisualStyleBackColor = true;
            button_GoToContacts.Click += button_GoToContacts_Click;
            // 
            // button_GoToWeights
            // 
            button_GoToWeights.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_GoToWeights.Location = new Point(37, 19);
            button_GoToWeights.Name = "button_GoToWeights";
            button_GoToWeights.Size = new Size(122, 46);
            button_GoToWeights.TabIndex = 7;
            button_GoToWeights.Text = "Growth Chart";
            button_GoToWeights.UseVisualStyleBackColor = true;
            button_GoToWeights.Click += button_GoToWeights_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(button_GoToWeights);
            panel1.Controls.Add(button_GoToContacts);
            panel1.Controls.Add(button_GoToMeds);
            panel1.Location = new Point(58, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 82);
            panel1.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label_MedList);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_GoToMeds;
        private Label label_MedList;
        private Button button_GoToContacts;
        private Button button_GoToWeights;
        private Panel panel1;
    }
}