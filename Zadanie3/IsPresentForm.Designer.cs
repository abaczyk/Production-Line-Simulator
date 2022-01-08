namespace Zadanie3
{
    partial class IsPresentForm
    {
        LoginForm loginForm = new LoginForm();
        ProductionLineForm productionLineForm;
        int tick;
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
            this.components = new System.ComponentModel.Container();
            this.isPresentTimer = new System.Windows.Forms.Timer(this.components);
            this.isPresentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // isPresentTimer
            // 
            this.isPresentTimer.Interval = 1000;
            this.isPresentTimer.Tick += new System.EventHandler(this.isPresentTimer_Tick);
            // 
            // isPresentLabel
            // 
            this.isPresentLabel.AutoSize = true;
            this.isPresentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.isPresentLabel.Location = new System.Drawing.Point(12, 36);
            this.isPresentLabel.Name = "isPresentLabel";
            this.isPresentLabel.Size = new System.Drawing.Size(81, 58);
            this.isPresentLabel.TabIndex = 0;
            this.isPresentLabel.Text = "label1\r\n\r\n";
            // 
            // IsPresentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.isPresentLabel);
            this.Enabled = false;
            this.Name = "IsPresentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IsPresentForm";
            this.Load += new System.EventHandler(this.IsPresentForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsPresentForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer isPresentTimer;
        private System.Windows.Forms.Label isPresentLabel;
    }
}