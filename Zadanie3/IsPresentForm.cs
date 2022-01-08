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
    public partial class IsPresentForm : Form
    {
        public bool tickEnd = false;
        public IsPresentForm()
        {
            InitializeComponent();
            tick = 0;
            this.ControlBox = false; //ukrycie przycisku zamykania okna
            isPresentLabel.Text = "Wciśnij dowolny klawisz \r\nw celu potwierdzenia \r\nobecności przy stanowisku. \r\n\nW przeciwnym razie, \r\nw przypadku braku \r\naktywności przez " + (30 - tick).ToString() + "\r\nsekund nastąpi wylogowanie \r\nz systemu.";
            
        }

        

        private void isPresentTimer_Tick(object sender, EventArgs e)
        {
            
            tick++;
            if(tick == 30)
            {   
                tickEnd = true;
                isPresentTimer.Stop();
                isPresentTimer.Enabled = false;
                MessageBox.Show("Brak aktywności użytkownika - nastąpiło wylogowanie z systemu");
                Application.Exit();
            }
            
        }

        private void IsPresentForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            isPresentTimer.Stop();
            MessageBox.Show("Przedłużono sesję użytkownika");
            this.Close();
        }

        private void IsPresentForm_Load(object sender, EventArgs e)
        {
            isPresentTimer.Enabled = true;
        }
    }
}
