using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Zadanie3
{
    public partial class ProductionLineForm : Form
    {
  
        public ProductionLineForm()
        {
            InitializeComponent();
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
            cpuValueLabel.Text = String.Empty;
            ramValueLabel.Text = String.Empty;
        }

        private void testTimer_Tick(object sender, EventArgs e)
        {
            tick++;

            if (tick == 60) 
            {
                productionTimer.Stop();
                productionTimer.Enabled = false;
                isPresentForm.Enabled = true;
                isPresentForm.ShowDialog();
            }

            if (isPresentForm.keyPressed)
            {
                tick = 0;
                productionTimer.Start();
                productionTimer.Enabled = true;
            }
        }

        private void ProductionLineForm_Load(object sender, EventArgs e)
        {
            productionTimer.Enabled = true;
        }

        //zeby program po zamknieciu okna "Linia produkcyjna" nie zajmował miejsca w pamieci
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

        private void cpuChange()
        {
            if (issueList.Contains(1))
                cpuValue = random.Next(80, 100);
            else
                cpuValue = random.Next(5, 30);
            if (cpuValue < MAX_NORMAL_VALUE)
            {
                cpuValueLabel.ForeColor = Color.Green;
                exitProgramsButton.BackColor = DefaultBackColor;
            }
            else
            {
                cpuValueLabel.ForeColor = Color.Red;
                exitProgramsButton.Enabled = true;
            }
            cpuValueLabel.Text = cpuValue.ToString() + "%";
        }

        private void ramChange()
        {
            if (issueList.Contains(2))
                ramValue = random.Next(80, 100);
            else
                ramValue = random.Next(5, 30);
            if (ramValue < MAX_NORMAL_VALUE)
            {
                ramValueLabel.ForeColor = Color.Green;
                exitProgramsButton.BackColor = DefaultBackColor;
            }
            else
            {
                ramValueLabel.ForeColor = Color.Red;
                exitProgramsButton.Enabled = true;
            }
            ramValueLabel.Text = ramValue.ToString() + "%";

            if(ramValue < MAX_NORMAL_VALUE && cpuValue < MAX_NORMAL_VALUE)
            {
                exitProgramsButton.Enabled = false;
            }
            else
                exitProgramsButton.BackColor = Color.Red;
        }

        private void coreChange()
        {
            if (issueList.Contains(3))
                temp0 = random.Next(80, 100);
            else
                temp0 = random.Next(35, 50);

            if (issueList.Contains(4))
                temp1 = random.Next(80, 100);
            else
                temp1 = random.Next(35, 50);

            if (issueList.Contains(5))
                temp2 = random.Next(80, 100);
            else
                temp2 = random.Next(35, 50);

            if (issueList.Contains(6))
                temp3 = random.Next(80, 100);
            else
                temp3 = random.Next(35, 50);

            temp0List.Add(temp0);
            temp1List.Add(temp1);
            temp2List.Add(temp2);
            temp3List.Add(temp3);

            if (temp0 < MAX_NORMAL_VALUE)
            {
                currTemp0Label.ForeColor = Color.Green;
                lowerCore0Button.BackColor = DefaultBackColor;
                lowerCore0Button.Enabled = false;
            }
            else
            {
                currTemp0Label.ForeColor = Color.Red;
                lowerCore0Button.BackColor = Color.Red;
                lowerCore0Button.Enabled = true;
            }

            if (temp1 < MAX_NORMAL_VALUE)
            {
                currTemp1Label.ForeColor = Color.Green;
                lowerCore1Button.BackColor = DefaultBackColor;
                lowerCore1Button.Enabled = false;
            }
            else
            {
                currTemp1Label.ForeColor = Color.Red;
                lowerCore1Button.BackColor = Color.Red;
                lowerCore1Button.Enabled = true;
            }
            if (temp2 < MAX_NORMAL_VALUE)
            {
                currTemp2Label.ForeColor = Color.Green;
                lowerCore2Button.BackColor = DefaultBackColor;
                lowerCore2Button.Enabled = false;
            }
            else
            {
                currTemp2Label.ForeColor = Color.Red;
                lowerCore2Button.BackColor = Color.Red;
                lowerCore2Button.Enabled = true;
            }

            if (temp3 < MAX_NORMAL_VALUE)
            {
                currTemp3Label.ForeColor = Color.Green;
                lowerCore3Button.BackColor = DefaultBackColor;
                lowerCore3Button.Enabled = false;
            }
            else
            {
                currTemp3Label.ForeColor = Color.Red;
                lowerCore3Button.BackColor = Color.Red;
                lowerCore3Button.Enabled = true;
            }
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

        }

        private void randIssue_Click(object sender, EventArgs e)
        {
            issueNumber = random.Next(1, 7);

            while (issueList.Contains(issueNumber))
                issueNumber = random.Next(1, 7); 
            issueList.Add(issueNumber);
        }
        private void changeTimer_Tick(object sender, EventArgs e)
        {
            cpuChange();
            ramChange();
            coreChange();
        }

        private void fixCpuRam_Click(object sender, EventArgs e)
        {
            issueList.Remove(1);
            issueList.Remove(2);
        }
        private void fixCore0_Click(object sender, EventArgs e)
        {
            issueList.Remove(3);
        }

        private void fixCore1_Click(object sender, EventArgs e)
        {
            issueList.Remove(4);
        }

        private void fixCore2_Click(object sender, EventArgs e)
        {
            issueList.Remove(5);
        }
        private void fixCore3_Click(object sender, EventArgs e)
        {
            issueList.Remove(6);
        }
        private void resetIssue()
        {
            issueNumber = 0;
        }
    }
}
