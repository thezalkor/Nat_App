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
            button_MedReturn = new Button();
            SuspendLayout();
            // 
            // button_MedReturn
            // 
            button_MedReturn.Location = new Point(316, 143);
            button_MedReturn.Name = "button_MedReturn";
            button_MedReturn.Size = new Size(75, 23);
            button_MedReturn.TabIndex = 0;
            button_MedReturn.Text = "Return";
            button_MedReturn.UseVisualStyleBackColor = true;
            button_MedReturn.Click += button_MedReturn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_MedReturn);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Button button_MedReturn;
    }
}