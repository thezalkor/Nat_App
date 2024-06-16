
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace Natalie_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            // newNum = new weight, newDate = new date
            string newNum = textBox_Weight.Text;
            string newDate = textBox_Date.Text;


            // Adds to the ListBox field on the same line. 
            string newWeight = $"Weight: {newNum} kg, Date: {newDate}";
            listbox_Weights.Items.Add(newWeight);

            // Adds Date and Weight to Chart
          
            if(double.TryParse(newNum, out double num) && DateTime.TryParse(newDate, out DateTime date))
            {
                chart_GrowthTrend.Series["Series1"].Points.AddXY(date, num);
            }
            //chart_GrowthTrend.Series["Series1"].Points.AddXY(newDate, newNum);



            textBox_Weight.Clear();
            textBox_Date.Clear();
            errorProvider_Weight.SetError(listbox_Weights, "");

          
        }

        private void textBox_Weight_Keypress(object sender, KeyPressEventArgs e)
        {
            //Only whole numbers or one decimal point can be used in the user input. Spits out error message if anything else is used. 
            if (char.IsControl(e.KeyChar))
            {
                errorProvider_Weight.SetError(textBox_Date, "");
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                errorProvider_Weight.SetError(textBox_Date, "");
                return;
            }

            if (e.KeyChar == '.' && textBox_Date.Text.IndexOf('.') == -1)
            {
                errorProvider_Weight.SetError(textBox_Date, "");
                return;
            }

            e.Handled = true;
            errorProvider_Weight.SetError(textBox_Weight, "Only Decimal or Whole Numbers Allowed");
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (listbox_Weights.Items.Count > 0)
            {
                listbox_Weights.Items.RemoveAt(0);
                errorProvider_Weight.SetError(listbox_Weights, "");
            }
            else
            {
                errorProvider_Weight.SetError(listbox_Weights, "No entries to remove!");
            }
        }

        private void textBox_Date_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Limits to only Date to be entered in DD/MM/YYYY format
            if (char.IsControl(e.KeyChar))
            {
                errorProvider_Weight.SetError(textBox_Date, "");
                return;
            }

            // only allow numbers and / 
            if (char.IsDigit(e.KeyChar)) 
            {
                errorProvider_Weight.SetError(textBox_Date, "");
                return;
            }
                
            if(e.KeyChar == '/')
            {
              errorProvider_Weight.SetError(textBox_Date, "");
                return;
            }

            e.Handled = true;
            errorProvider_Weight.SetError(textBox_Date, "Enter Date in DD/MM/YYYY Format");
        }

    }
}

/*public class Data_GrowthTrend
{
    public string Dates { get; set; }
    public double Weight { get; set; }
}

*/