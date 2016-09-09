using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class frmMainWindow : Form
    {
        //Class Variables
        int timeCounter;
        int currentTime;
        int itemLimit = 20;

        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void txtDrawingWindow_MouseMove(object sender, MouseEventArgs e)
        {
            // Calculate time delay between mouse moves
            currentTime = timeCounter * tmrMoveDelayCounter.Interval;
            lstDeltaTime.Items.Add(currentTime.ToString("000000"));
            timeCounter = 0; // Restart count

            // Limit listbox items to item limit and remove old entries
            while(lstDeltaTime.Items.Count > itemLimit)
            {
                lstDeltaTime.Items.RemoveAt(0);
            }

            // Select the latest entry
            lstDeltaTime.SelectedIndex = lstDeltaTime.Items.Count - 1;

            txtXPos.Text = e.X.ToString("0000");
            txtYPos.Text = e.Y.ToString("0000");
        }

        private void tmrMoveDelayCounter_Tick(object sender, EventArgs e)
        {
            timeCounter++;
        }
    }
}
