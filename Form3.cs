using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Natalie_App
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void button_MedReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        // Next 3 methods are for the user to input the medication name, pharmacy, and prescribing doctor. And for Letters and spaces and . only 
        private void textBox_MedName_Keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                errorProvider_Medications.SetError(textBox_MedName, "Please enter only letters, no symbols or numbers!");
                e.Handled = true;
            }
            else
            {
                errorProvider_Medications.SetError(textBox_MedName, "");
            }
        }

        private void textBox_Pharm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {

                errorProvider_Medications.SetError(textBox_Pharm, "Please enter only letters, no symbols or numbers!");
                e.Handled = true;
            }
            else
            {
                errorProvider_Medications.SetError(textBox_Pharm, "");
            }
        }

        private void textBox_Prescribe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && (e.KeyChar != '.' || textBox_MedName.Text.Contains('.')))
            {
                errorProvider_Medications.SetError(textBox_Prescribe, "Please enter only letters, no symbols or numbers!");
                e.Handled = true;
            }
            else
            {
                errorProvider_Medications.SetError(textBox_Prescribe, "");
            }
        }

        // These next few methods only allow for numbers, / and decimal points. No letters
        private void textBox_DoseStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.' || textBox_DoseStr.Text.Contains('.')))
            {
                errorProvider_Medications.SetError(textBox_DoseStr, "Please enter only numbers. One decimal is allowed");
                e.Handled = true;
            }
            else
            {
                errorProvider_Medications.SetError(textBox_DoseStr, "");
            }
        }

        private void textBox_Dose_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.' || textBox_Dose.Text.Contains('.')))
            {
                errorProvider_Medications.SetError(textBox_Dose, "Please enter only numbers. One decimal is allowed");
                e.Handled = true;
            }
            else
            {
                errorProvider_Medications.SetError(textBox_Dose, "");
            }
        }

        private void textBox_Expire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '/'))
            {
                errorProvider_Medications.SetError(textBox_Expire, "Please enter a valid date in the format DD/MM/YYYY");
                e.Handled = true;
            }
            else
            {
                errorProvider_Medications.SetError(textBox_Expire, "");
            }
        }

        private void textBox_DateFilled_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '/'))
            {
                errorProvider_Medications.SetError(textBox_Expire, "Please enter a valid date in the format DD/MM/YYYY");
                e.Handled = true;
            }
            else
            {
                errorProvider_Medications.SetError(textBox_Expire, "");
            }
        }

        private void textBox_RefillRemain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.' || textBox_Dose.Text.Contains('.')))
            {
                errorProvider_Medications.SetError(textBox_DoseStr, "Please enter only numbers. One decimal is allowed");
                e.Handled = true;
            }
            else
            {
                errorProvider_Medications.SetError(textBox_DoseStr, "");
            }
        }

        private void button_AddMed_Click(object sender, EventArgs e)
        {
            MedicationEntry entry = new MedicationEntry
            {
                MedName = textBox_MedName.Text,
                Pharm = textBox_Pharm.Text,
                Prescribe = textBox_Prescribe.Text,
                DoseStr = textBox_DoseStr.Text,
                Dose = textBox_Dose.Text,
                Expire = textBox_Expire.Text,
                DateFilled = textBox_DateFilled.Text,
                RefillRemain = textBox_RefillRemain.Text,
                Sched = textBox_MedSched.Text

            };

            listBox_Meds.Items.Add(entry);

            // clear entries to add new ones, once Add button is clicked
            textBox_MedName.Clear();
            textBox_Pharm.Clear();
            textBox_Prescribe.Clear();
            textBox_DoseStr.Clear();
            textBox_Dose.Clear();
            textBox_Expire.Clear();
            textBox_DateFilled.Clear();
            textBox_RefillRemain.Clear();
            textBox_MedSched.Clear();
        }

        private void listBox_Meds_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox_Meds.SelectedItem != null)
            {
                MedicationEntry entry = (MedicationEntry)listBox_Meds.SelectedItem;
                MedInfoForm medInfo = new MedInfoForm(entry);
                medInfo.ShowDialog();
            }
        }
    }

    public class MedicationEntry
    {
        // Delcaring properties as nullable ? to allow for empty strings
        public string? MedName { get; set; }
        public string? Pharm { get; set; }
        public string? Prescribe { get; set; }
        public string? DoseStr { get; set; }
        public string? Dose { get; set; }
        public string? Expire { get; set; }
        public string? DateFilled { get; set; }
        public string? RefillRemain { get; set; }
        public string? Sched { get; set; }

        //Display the MedName in the listbox
        public override string ToString()
        {
            return MedName ?? "N/A";
        }
    }
}


