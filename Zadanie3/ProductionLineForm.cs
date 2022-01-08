using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Collections;

namespace Zadanie3
{
    public partial class ProductionLineForm : Form
    {
        public ProductionLineForm()
        {
            InitializeComponent();
            label1.Text = String.Empty;
            tick = 0;

            currTemp0Label.Text = String.Empty;
            currTemp1Label.Text = String.Empty;
            currTemp2Label.Text = String.Empty;
            currTemp3Label.Text = String.Empty;
            minTemp0Label.Text = String.Empty;
            minTemp1Label.Text = String.Empty;
            minTemp2Label.Text = String.Empty;
            minTemp3Label.Text = String.Empty;
            maxTemp0Label.Text = String.Empty;
            maxTemp1Label.Text = String.Empty;
            maxTemp2Label.Text = String.Empty;
            maxTemp3Label.Text = String.Empty;
        }

        private void testTimer_Tick(object sender, EventArgs e)
        {
            tick++;
            label1.Text = tick.ToString();
            temp0 = random.Next(35, 50);
            temp1 = random.Next(35, 50);
            temp2 = random.Next(35, 50);
            temp3 = random.Next(35, 50);
            temp0List.Add(temp0);
            temp1List.Add(temp1);
            temp2List.Add(temp2);
            temp3List.Add(temp3);

            cpuValue = random.Next(5, 30);
            ramValue = random.Next(5, 30);
            cpuUsage.Text = "Wykorzystanie: " + cpuValue + "%";
            ramUsage.Text = "Wykorzystanie: " + ramValue + "%";

            currTemp0Label.Text = temp0.ToString() + " °C";
            currTemp1Label.Text = temp1.ToString() + " °C";
            currTemp2Label.Text = temp2.ToString() + " °C";
            currTemp3Label.Text = temp3.ToString() + " °C";

            minTemp0Label.Text = getMinValue(temp0List).ToString() + " °C";
            minTemp1Label.Text = getMinValue(temp1List).ToString() + " °C";
            minTemp2Label.Text = getMinValue(temp2List).ToString() + " °C";
            minTemp3Label.Text = getMinValue(temp3List).ToString() + " °C";

            maxTemp0Label.Text = getMaxValue(temp0List).ToString() + " °C";
            maxTemp1Label.Text = getMaxValue(temp1List).ToString() + " °C";
            maxTemp2Label.Text = getMaxValue(temp2List).ToString() + " °C";
            maxTemp3Label.Text = getMaxValue(temp3List).ToString() + " °C";


            if (tick == 30)
            { 
                testTimer.Stop();
                testTimer.Enabled = false;
                IsPresentForm isPresentForm = new IsPresentForm();
                isPresentForm.Enabled = true;
                isPresentForm.ShowDialog();
               
            }
        }

        private void ProductionLineForm_Load(object sender, EventArgs e)
        {
            testTimer.Enabled = true;
        }

        private void ProductionLineForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private object getMinValue(ArrayList arrayList)
        {
            arrayList.Sort();
            return arrayList[0];
        }

        private object getMaxValue(ArrayList arrayList)
        {
            arrayList.Sort();
            arrayList.Reverse();
            return arrayList[0];
        }

    }
}
