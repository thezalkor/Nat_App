﻿using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Natalie_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ChartArea chartArea2 = new ChartArea();
            Legend legend2 = new Legend();
            Series series2 = new Series();
            Title title2 = new Title();
            panel1 = new Panel();
            button_ClearDataTesting = new Button();
            button_SaveDataGrowth = new Button();
            button_ReturnGrowth = new Button();
            label_Date = new Label();
            label_Weight = new Label();
            textBox_Date = new TextBox();
            listbox_Weights = new ListBox();
            button_Remove = new Button();
            label_EnterWeight = new Label();
            button_Add = new Button();
            textBox_Weight = new TextBox();
            errorProvider_Weight = new ErrorProvider(components);
            chart_GrowthTrend = new Chart();
            panel2 = new Panel();
            button_LoadGrowthXml = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Weight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_GrowthTrend).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button_LoadGrowthXml);
            panel1.Controls.Add(button_ClearDataTesting);
            panel1.Controls.Add(button_SaveDataGrowth);
            panel1.Controls.Add(button_ReturnGrowth);
            panel1.Controls.Add(label_Date);
            panel1.Controls.Add(label_Weight);
            panel1.Controls.Add(textBox_Date);
            panel1.Controls.Add(listbox_Weights);
            panel1.Controls.Add(button_Remove);
            panel1.Controls.Add(label_EnterWeight);
            panel1.Controls.Add(button_Add);
            panel1.Controls.Add(textBox_Weight);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 166);
            panel1.TabIndex = 1;
            // 
            // button_ClearDataTesting
            // 
            button_ClearDataTesting.BackColor = Color.LightCoral;
            button_ClearDataTesting.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button_ClearDataTesting.Location = new Point(568, 130);
            button_ClearDataTesting.Name = "button_ClearDataTesting";
            button_ClearDataTesting.Size = new Size(121, 33);
            button_ClearDataTesting.TabIndex = 11;
            button_ClearDataTesting.Text = "CLEAR ALL DATA";
            button_ClearDataTesting.UseVisualStyleBackColor = false;
            // 
            // button_SaveDataGrowth
            // 
            button_SaveDataGrowth.BackColor = Color.Orchid;
            button_SaveDataGrowth.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button_SaveDataGrowth.Location = new Point(568, 37);
            button_SaveDataGrowth.Name = "button_SaveDataGrowth";
            button_SaveDataGrowth.Size = new Size(116, 45);
            button_SaveDataGrowth.TabIndex = 10;
            button_SaveDataGrowth.Text = "SAVE DATA";
            button_SaveDataGrowth.UseVisualStyleBackColor = false;
            button_SaveDataGrowth.Click += button_SaveDataGrowth_Click;
            // 
            // button_ReturnGrowth
            // 
            button_ReturnGrowth.BackColor = Color.Bisque;
            button_ReturnGrowth.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_ReturnGrowth.Location = new Point(670, 3);
            button_ReturnGrowth.Name = "button_ReturnGrowth";
            button_ReturnGrowth.Size = new Size(75, 23);
            button_ReturnGrowth.TabIndex = 9;
            button_ReturnGrowth.Text = "Return";
            button_ReturnGrowth.UseVisualStyleBackColor = false;
            button_ReturnGrowth.Click += button_ReturnGrowth_Click;
            // 
            // label_Date
            // 
            label_Date.AutoSize = true;
            label_Date.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Date.Location = new Point(427, 88);
            label_Date.Name = "label_Date";
            label_Date.Size = new Size(140, 14);
            label_Date.TabIndex = 8;
            label_Date.Text = "Date DD/MM/YYYY";
            // 
            // label_Weight
            // 
            label_Weight.AutoSize = true;
            label_Weight.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Weight.Location = new Point(324, 88);
            label_Weight.Name = "label_Weight";
            label_Weight.Size = new Size(54, 14);
            label_Weight.TabIndex = 7;
            label_Weight.Text = "Weight";
            // 
            // textBox_Date
            // 
            textBox_Date.Location = new Point(437, 105);
            textBox_Date.Name = "textBox_Date";
            textBox_Date.Size = new Size(100, 23);
            textBox_Date.TabIndex = 6;
            textBox_Date.KeyPress += textBox_Date_KeyPress;
            // 
            // listbox_Weights
            // 
            listbox_Weights.Dock = DockStyle.Left;
            listbox_Weights.FormattingEnabled = true;
            listbox_Weights.ItemHeight = 15;
            listbox_Weights.Location = new Point(0, 0);
            listbox_Weights.Name = "listbox_Weights";
            listbox_Weights.Size = new Size(247, 166);
            listbox_Weights.TabIndex = 5;
            // 
            // button_Remove
            // 
            button_Remove.BackColor = Color.OrangeRed;
            button_Remove.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Remove.Location = new Point(423, 45);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(75, 23);
            button_Remove.TabIndex = 4;
            button_Remove.Text = "Remove Weight";
            button_Remove.UseVisualStyleBackColor = false;
            button_Remove.Click += button_Remove_Click;
            // 
            // label_EnterWeight
            // 
            label_EnterWeight.AutoSize = true;
            label_EnterWeight.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_EnterWeight.Location = new Point(324, 17);
            label_EnterWeight.Name = "label_EnterWeight";
            label_EnterWeight.Size = new Size(195, 14);
            label_EnterWeight.TabIndex = 3;
            label_EnterWeight.Text = "Enter Natalie's Weight Here.";
            // 
            // button_Add
            // 
            button_Add.BackColor = Color.SeaGreen;
            button_Add.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Add.Location = new Point(324, 45);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(75, 23);
            button_Add.TabIndex = 1;
            button_Add.Text = "Add Weight";
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // textBox_Weight
            // 
            textBox_Weight.Location = new Point(300, 105);
            textBox_Weight.Name = "textBox_Weight";
            textBox_Weight.Size = new Size(100, 23);
            textBox_Weight.TabIndex = 2;
            textBox_Weight.KeyPress += textBox_Weight_Keypress;
            // 
            // errorProvider_Weight
            // 
            errorProvider_Weight.ContainerControl = this;
            // 
            // chart_GrowthTrend
            // 
            chartArea2.AxisX.LabelStyle.Format = "dd/MM/yyyy";
            chartArea2.AxisX.Title = "Date";
            chartArea2.AxisY.Title = "Weight (Kg)";
            chartArea2.Name = "ChartArea1";
            chart_GrowthTrend.ChartAreas.Add(chartArea2);
            chart_GrowthTrend.ImeMode = ImeMode.NoControl;
            legend2.Name = "Legend1";
            chart_GrowthTrend.Legends.Add(legend2);
            chart_GrowthTrend.Location = new Point(12, 3);
            chart_GrowthTrend.Name = "chart_GrowthTrend";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "Weight";
            series2.Name = "Series1";
            chart_GrowthTrend.Series.Add(series2);
            chart_GrowthTrend.Size = new Size(748, 300);
            chart_GrowthTrend.TabIndex = 9;
            chart_GrowthTrend.TabStop = false;
            chart_GrowthTrend.Text = "chart1";
            title2.Name = "Growth Trend";
            chart_GrowthTrend.Titles.Add(title2);
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(chart_GrowthTrend);
            panel2.Location = new Point(12, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(779, 310);
            panel2.TabIndex = 10;
            // 
            // button_LoadGrowthXml
            // 
            button_LoadGrowthXml.BackColor = Color.DarkOrange;
            button_LoadGrowthXml.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button_LoadGrowthXml.Location = new Point(568, 88);
            button_LoadGrowthXml.Name = "button_LoadGrowthXml";
            button_LoadGrowthXml.Size = new Size(116, 36);
            button_LoadGrowthXml.TabIndex = 12;
            button_LoadGrowthXml.Text = "Load Data";
            button_LoadGrowthXml.UseVisualStyleBackColor = false;
            button_LoadGrowthXml.Click += button_LoadGrowthXml_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 496);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Weight).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_GrowthTrend).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button_Remove;
        private Label label_EnterWeight;
        private TextBox textBox_Weight;
        private Button button_Add;
        private ListBox listbox_Weights;
        private ErrorProvider errorProvider_Weight;
        private TextBox textBox_Date;
        private Label label_Date;
        private Label label_Weight;
        private Chart chart_GrowthTrend;
        private Panel panel2;
        private Button button_ReturnGrowth;
        private Button button_SaveDataGrowth;
        private Button button_ClearDataTesting;
        private Button button_loadGrowthXML;
        private Button button_LoadGrowthXml;
    }
}
