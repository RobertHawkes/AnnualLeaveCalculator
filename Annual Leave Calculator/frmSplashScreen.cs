using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Annual_Leave_Calculator
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void tmrSplashScreen_Tick(object sender, EventArgs e)
        {
            try
            {
                //disable the timer to prevent another timer firing
                tmrSplashScreen.Enabled = false;

                //Load player registration screen
                //instantiating a new player form
                frmMain newMain = new frmMain();

                //display the player form
                newMain.Show();

                //hide current form (referenced as "this")
                this.Hide();
            }
            catch (Exception ex)
            {
                //display any error message
                MessageBox.Show(ex.Message);
            }
        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            try
            {
                if (pgbSplash.Value != 10)
                {
                    pgbSplash.Value++;
                }
                else
                {
                    tmrProgress.Stop();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error detected: " + ex.Message);
            }
        }
    }
}
