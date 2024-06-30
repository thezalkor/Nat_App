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
    public partial class MedInfoForm : Form
    {
        public MedInfoForm(MedicationEntry entry)
        {
            InitializeComponent();

            label_MedName.Text = $"Medication Name : {entry.MedName ?? "N/A"}";
            label_Pharm.Text = $"Pharmacy: {entry.Pharm ?? "N/A"}";
            label_Prescribe.Text = $"Prescribed By: {entry.Prescribe ?? "N/A"}";
            label_DoseStr.Text = $"Medication Strength: {entry.DoseStr ?? "N/A"}";
            label_Dose.Text = $"Medication Dosage: {entry.Dose ?? "N/A"}";
            label_Expire.Text = $"Expiration Date: {entry.Expire ?? "N/A"}";
            label_RefillRemain.Text = $"Number of Refils Remaining: {entry.RefillRemain ?? "N/A"}";
            label_Sched.Text = $"How many Doses Per Day: {entry.Sched ?? "N/A"}";
            label_DateFilled.Text = $"Fill Date: {entry.DateFilled ?? "N/A"}";
        }
    }
}
