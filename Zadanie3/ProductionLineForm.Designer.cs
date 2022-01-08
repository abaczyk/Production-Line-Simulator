using System;
using System.Collections;

namespace Zadanie3
{
    partial class ProductionLineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        
        private System.ComponentModel.IContainer components = null;
        int tick;
        int temp0;
        int temp1;
        int temp2;
        int temp3;

        int cpuValue;
        int ramValue;
        Random random = new Random();
        ArrayList temp0List = new ArrayList();
        ArrayList temp1List = new ArrayList();
        ArrayList temp2List = new ArrayList();
        ArrayList temp3List = new ArrayList();
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
            this.components = new System.ComponentModel.Container();
            this.testTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ramLabel = new System.Windows.Forms.Label();
            this.ramUsage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cpuUsage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.maxTemp3Label = new System.Windows.Forms.Label();
            this.maxTemp2Label = new System.Windows.Forms.Label();
            this.maxTemp1Label = new System.Windows.Forms.Label();
            this.maxTemp0Label = new System.Windows.Forms.Label();
            this.minTemp3Label = new System.Windows.Forms.Label();
            this.minTemp2Label = new System.Windows.Forms.Label();
            this.minTemp1Label = new System.Windows.Forms.Label();
            this.minTemp0Label = new System.Windows.Forms.Label();
            this.currTemp3Label = new System.Windows.Forms.Label();
            this.currTemp2Label = new System.Windows.Forms.Label();
            this.currTemp1Label = new System.Windows.Forms.Label();
            this.currTemp0Label = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.core3Label = new System.Windows.Forms.Label();
            this.core2Label = new System.Windows.Forms.Label();
            this.core1Label = new System.Windows.Forms.Label();
            this.core0Label = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // testTimer
            // 
            this.testTimer.Interval = 1000;
            this.testTimer.Tick += new System.EventHandler(this.testTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cpuLabel.Location = new System.Drawing.Point(46, 25);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(119, 29);
            this.cpuLabel.TabIndex = 6;
            this.cpuLabel.Text = "Procesor";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(565, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 55);
            this.button1.TabIndex = 16;
            this.button1.Text = "Wyłącz niepotrzebne programy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ramLabel
            // 
            this.ramLabel.AutoSize = true;
            this.ramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ramLabel.Location = new System.Drawing.Point(300, 25);
            this.ramLabel.Name = "ramLabel";
            this.ramLabel.Size = new System.Drawing.Size(162, 87);
            this.ramLabel.TabIndex = 17;
            this.ramLabel.Text = "Pamięć RAM\r\n\r\n\r\n";
            // 
            // ramUsage
            // 
            this.ramUsage.AutoSize = true;
            this.ramUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ramUsage.Location = new System.Drawing.Point(300, 60);
            this.ramUsage.Name = "ramUsage";
            this.ramUsage.Size = new System.Drawing.Size(147, 25);
            this.ramUsage.TabIndex = 18;
            this.ramUsage.Text = "Wykorzystanie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(45, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(405, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "Temparatury rdzeni procesora\r\n";
            // 
            // cpuUsage
            // 
            this.cpuUsage.AutoSize = true;
            this.cpuUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cpuUsage.Location = new System.Drawing.Point(46, 61);
            this.cpuUsage.Name = "cpuUsage";
            this.cpuUsage.Size = new System.Drawing.Size(147, 25);
            this.cpuUsage.TabIndex = 20;
            this.cpuUsage.Text = "Wykorzystanie:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(719, 3);
            this.label6.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(565, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 44);
            this.button2.TabIndex = 22;
            this.button2.Text = "Zmniejsz użycie rdzenia #0\r\n\r\n ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(565, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 44);
            this.button3.TabIndex = 23;
            this.button3.Text = "Zmniejsz użycie rdzenia #1\r\n\r\n";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(565, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 44);
            this.button4.TabIndex = 24;
            this.button4.Text = "Zmniejsz użycie rdzenia #2\r\n\r\n";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(565, 352);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 44);
            this.button5.TabIndex = 25;
            this.button5.Text = "Zmniejsz użycie rdzenia #3\r\n\r\n\r\n";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(565, 122);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 55);
            this.button6.TabIndex = 26;
            this.button6.Text = "Generuj losową usterkę";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // maxTemp3Label
            // 
            this.maxTemp3Label.AutoSize = true;
            this.maxTemp3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxTemp3Label.Location = new System.Drawing.Point(360, 200);
            this.maxTemp3Label.Name = "maxTemp3Label";
            this.maxTemp3Label.Size = new System.Drawing.Size(66, 25);
            this.maxTemp3Label.TabIndex = 26;
            this.maxTemp3Label.Text = "temp3";
            // 
            // maxTemp2Label
            // 
            this.maxTemp2Label.AutoSize = true;
            this.maxTemp2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxTemp2Label.Location = new System.Drawing.Point(360, 150);
            this.maxTemp2Label.Name = "maxTemp2Label";
            this.maxTemp2Label.Size = new System.Drawing.Size(66, 25);
            this.maxTemp2Label.TabIndex = 25;
            this.maxTemp2Label.Text = "temp3";
            // 
            // maxTemp1Label
            // 
            this.maxTemp1Label.AutoSize = true;
            this.maxTemp1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxTemp1Label.Location = new System.Drawing.Point(360, 100);
            this.maxTemp1Label.Name = "maxTemp1Label";
            this.maxTemp1Label.Size = new System.Drawing.Size(66, 25);
            this.maxTemp1Label.TabIndex = 24;
            this.maxTemp1Label.Text = "temp3";
            // 
            // maxTemp0Label
            // 
            this.maxTemp0Label.AutoSize = true;
            this.maxTemp0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxTemp0Label.Location = new System.Drawing.Point(360, 50);
            this.maxTemp0Label.Name = "maxTemp0Label";
            this.maxTemp0Label.Size = new System.Drawing.Size(66, 25);
            this.maxTemp0Label.TabIndex = 23;
            this.maxTemp0Label.Text = "temp3";
            // 
            // minTemp3Label
            // 
            this.minTemp3Label.AutoSize = true;
            this.minTemp3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minTemp3Label.Location = new System.Drawing.Point(260, 200);
            this.minTemp3Label.Name = "minTemp3Label";
            this.minTemp3Label.Size = new System.Drawing.Size(66, 25);
            this.minTemp3Label.TabIndex = 22;
            this.minTemp3Label.Text = "temp2";
            // 
            // minTemp2Label
            // 
            this.minTemp2Label.AutoSize = true;
            this.minTemp2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minTemp2Label.Location = new System.Drawing.Point(260, 150);
            this.minTemp2Label.Name = "minTemp2Label";
            this.minTemp2Label.Size = new System.Drawing.Size(66, 25);
            this.minTemp2Label.TabIndex = 21;
            this.minTemp2Label.Text = "temp2";
            // 
            // minTemp1Label
            // 
            this.minTemp1Label.AutoSize = true;
            this.minTemp1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minTemp1Label.Location = new System.Drawing.Point(260, 100);
            this.minTemp1Label.Name = "minTemp1Label";
            this.minTemp1Label.Size = new System.Drawing.Size(66, 25);
            this.minTemp1Label.TabIndex = 20;
            this.minTemp1Label.Text = "temp2";
            // 
            // minTemp0Label
            // 
            this.minTemp0Label.AutoSize = true;
            this.minTemp0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minTemp0Label.Location = new System.Drawing.Point(260, 50);
            this.minTemp0Label.Name = "minTemp0Label";
            this.minTemp0Label.Size = new System.Drawing.Size(66, 25);
            this.minTemp0Label.TabIndex = 19;
            this.minTemp0Label.Text = "temp2";
            // 
            // currTemp3Label
            // 
            this.currTemp3Label.AutoSize = true;
            this.currTemp3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currTemp3Label.Location = new System.Drawing.Point(110, 200);
            this.currTemp3Label.Name = "currTemp3Label";
            this.currTemp3Label.Size = new System.Drawing.Size(66, 25);
            this.currTemp3Label.TabIndex = 18;
            this.currTemp3Label.Text = "temp1";
            // 
            // currTemp2Label
            // 
            this.currTemp2Label.AutoSize = true;
            this.currTemp2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currTemp2Label.Location = new System.Drawing.Point(110, 150);
            this.currTemp2Label.Name = "currTemp2Label";
            this.currTemp2Label.Size = new System.Drawing.Size(66, 25);
            this.currTemp2Label.TabIndex = 17;
            this.currTemp2Label.Text = "temp1";
            // 
            // currTemp1Label
            // 
            this.currTemp1Label.AutoSize = true;
            this.currTemp1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currTemp1Label.Location = new System.Drawing.Point(110, 100);
            this.currTemp1Label.Name = "currTemp1Label";
            this.currTemp1Label.Size = new System.Drawing.Size(66, 25);
            this.currTemp1Label.TabIndex = 16;
            this.currTemp1Label.Text = "temp1";
            // 
            // currTemp0Label
            // 
            this.currTemp0Label.AutoSize = true;
            this.currTemp0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currTemp0Label.Location = new System.Drawing.Point(110, 50);
            this.currTemp0Label.Name = "currTemp0Label";
            this.currTemp0Label.Size = new System.Drawing.Size(66, 25);
            this.currTemp0Label.TabIndex = 15;
            this.currTemp0Label.Text = "temp1";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minLabel.Location = new System.Drawing.Point(260, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(49, 25);
            this.minLabel.TabIndex = 12;
            this.minLabel.Text = "Min.";
            // 
            // core3Label
            // 
            this.core3Label.AutoSize = true;
            this.core3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.core3Label.Location = new System.Drawing.Point(3, 200);
            this.core3Label.Name = "core3Label";
            this.core3Label.Size = new System.Drawing.Size(101, 25);
            this.core3Label.TabIndex = 10;
            this.core3Label.Text = "Rdzeń #3:";
            // 
            // core2Label
            // 
            this.core2Label.AutoSize = true;
            this.core2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.core2Label.Location = new System.Drawing.Point(3, 150);
            this.core2Label.Name = "core2Label";
            this.core2Label.Size = new System.Drawing.Size(101, 25);
            this.core2Label.TabIndex = 9;
            this.core2Label.Text = "Rdzeń #2:";
            // 
            // core1Label
            // 
            this.core1Label.AutoSize = true;
            this.core1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.core1Label.Location = new System.Drawing.Point(3, 100);
            this.core1Label.Name = "core1Label";
            this.core1Label.Size = new System.Drawing.Size(101, 25);
            this.core1Label.TabIndex = 8;
            this.core1Label.Text = "Rdzeń #1:";
            // 
            // core0Label
            // 
            this.core0Label.AutoSize = true;
            this.core0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.core0Label.Location = new System.Drawing.Point(3, 50);
            this.core0Label.Name = "core0Label";
            this.core0Label.Size = new System.Drawing.Size(101, 25);
            this.core0Label.TabIndex = 7;
            this.core0Label.Text = "Rdzeń #0:";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxLabel.Location = new System.Drawing.Point(360, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(55, 25);
            this.maxLabel.TabIndex = 13;
            this.maxLabel.Text = "Max.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.Controls.Add(this.maxLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.core0Label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.core1Label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.core2Label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.core3Label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.minLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.currTemp0Label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.currTemp1Label, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.currTemp2Label, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.currTemp3Label, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.minTemp0Label, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.minTemp1Label, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.minTemp2Label, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.minTemp3Label, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.maxTemp0Label, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.maxTemp1Label, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.maxTemp2Label, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.maxTemp3Label, 3, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(51, 152);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 250);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // ProductionLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 414);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cpuUsage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cpuLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ramUsage);
            this.Controls.Add(this.ramLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductionLineForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linia produkcyjna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductionLineForm_FormClosing);
            this.Load += new System.EventHandler(this.ProductionLineForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer testTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ramLabel;
        private System.Windows.Forms.Label ramUsage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cpuUsage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label maxTemp3Label;
        private System.Windows.Forms.Label maxTemp2Label;
        private System.Windows.Forms.Label maxTemp1Label;
        private System.Windows.Forms.Label maxTemp0Label;
        private System.Windows.Forms.Label minTemp3Label;
        private System.Windows.Forms.Label minTemp2Label;
        private System.Windows.Forms.Label minTemp1Label;
        private System.Windows.Forms.Label minTemp0Label;
        private System.Windows.Forms.Label currTemp3Label;
        private System.Windows.Forms.Label currTemp2Label;
        private System.Windows.Forms.Label currTemp1Label;
        private System.Windows.Forms.Label currTemp0Label;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label core3Label;
        private System.Windows.Forms.Label core2Label;
        private System.Windows.Forms.Label core1Label;
        private System.Windows.Forms.Label core0Label;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}