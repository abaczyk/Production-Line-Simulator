using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie3
{
    public partial class LoginForm : Form
    {
        public bool loginOK = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
             if (loginTextBox.Text == "abc" && passwordTextBox.Text == "123")
             {
                MessageBox.Show("Poprawnie zalogowano do systemu");
                loginOK = true;
                new ProductionLineForm().Show();
                this.Hide();
            }
             else
             {
                MessageBox.Show("Niepoprawny login i/lub hasło");
                loginTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
             }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.loginButton.PerformClick();
        }
    }
  
}
