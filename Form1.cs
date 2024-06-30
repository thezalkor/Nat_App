
using Microsoft.VisualBasic.ApplicationServices;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace Natalie_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            if (double.TryParse(newNum, out double num) && DateTime.TryParse(newDate, out DateTime date))
            {
                chart_GrowthTrend.Series["Series1"].Points.AddXY(date, num);
            }




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

            if (e.KeyChar == '/')
            {
                errorProvider_Weight.SetError(textBox_Date, "");
                return;
            }

            e.Handled = true;
            errorProvider_Weight.SetError(textBox_Date, "Enter Date in DD/MM/YYYY Format");
        }

        private void button_ReturnGrowth_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button_SaveDataGrowth_Click(object sender, EventArgs e)
        {
            //SaveToXml("GrowthXML.xml");
            using (var writer = new StreamWriter("storeWeights.txt"))
            {
                foreach (var item in listbox_Weights.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
        }

        private void SaveToXml(string GrowthXML)
        {

            try
            {
                string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, GrowthXML);
                MessageBox.Show($"This is the xpath : {path}");
                // Save the data to an XML file
                // Create a new XML file
                System.Xml.XmlTextWriter writer = new System.Xml.XmlTextWriter(GrowthXML, System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = System.Xml.Formatting.Indented;
                writer.Indentation = 2;

                // Start the root element
                writer.WriteStartElement("GrowthData");

                // add listbox_Weights data
                writer.WriteStartElement("listbox_Weights");
                foreach (var item in listbox_Weights.Items)
                {
                    writer.WriteElementString("Weight", item.ToString());
                }
                writer.WriteEndElement();



                // Ends the document
                writer.WriteEndDocument();
                writer.Close();
                MessageBox.Show("Data Saved to XML File");



                if (System.IO.File.Exists(GrowthXML))
                {
                    MessageBox.Show("File Exists");
                }
                else
                {
                    MessageBox.Show("Failed to create File");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Saving Data to XML File: " + ex.Message);
            }

        }

        private void button_LoadGrowthXml_Click(object sender, EventArgs e)
        {
            //loadGrowthXML("GrowthXML.xml");
            using (var reader = new StreamReader("storeWeights.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    listbox_Weights.Items.Add(line);
                }
            }

            UpdateChart();
        }

        // Update the chart when a new weight is added. Meaning when a user loads in data the chart will update to show the new data.
        private void listBox_Weights_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }


        private void UpdateChart()
        {
            chart_GrowthTrend.Series["Series1"].Points.Clear();

            foreach (string item in listbox_Weights.Items) {
                string[] parts = item.Split(',');
                string weight = parts[0].Split(':')[1].Trim();
                string date = parts[1].Split(':')[1].Trim();

                if (double.TryParse(weight, out double num) && DateTime.TryParse(date, out DateTime dateValue))
                {
                    chart_GrowthTrend.Series["Series1"].Points.AddXY(dateValue, num);
                }
            }
        }

        private void loadGrowthXML(string GrowthXML)
        {
            try
            {

                XmlDocument doc = new XmlDocument();
                doc.Load(GrowthXML);

                XmlNodeList entryNodes = doc.SelectNodes("/GrowthData/listbox_Weights/Weight");

                if (entryNodes == null)
                {

                    MessageBox.Show("No Data Found in XML File");
                    return;
                }

                foreach (XmlNode node in entryNodes)
                {
                    string weight = node.SelectSingleNode("Weight").InnerText;
                    listbox_Weights.Items.Add(weight);
                }
                MessageBox.Show("Data Loaded from XML File");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Data from XML File: " + ex.Message);
            }
        }
    }
}


