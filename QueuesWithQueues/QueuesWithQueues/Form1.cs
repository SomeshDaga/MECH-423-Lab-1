using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuesWithQueues
{
    public partial class Form1 : Form
    {
        // Class Variables
        ConcurrentQueue<char> dataQueue;

        public Form1()
        {
            InitializeComponent();

            // Initialize the data queue
            dataQueue = new ConcurrentQueue<char>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach(char c in txtAdd.Text)
            {
                dataQueue.Enqueue(c);
            }

            txtAdd.Clear();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            char result;

            if (dataQueue.TryDequeue(out result))
                txtGet.Text = result.ToString();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            txtCount.Text = dataQueue.Count.ToString();
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            float sum = 0;
            int nItems = 0;

            if(!string.IsNullOrWhiteSpace(txtN.Text))
                nItems = Convert.ToInt16(txtN.Text);

            if(nItems == 0 || nItems > dataQueue.Count)
                nItems = dataQueue.Count;

            for(int index = (dataQueue.Count - nItems); index < dataQueue.Count; index++)
            {
                sum += Convert.ToInt16(dataQueue.ElementAt<char>(index));
            }

            txtAvg.Text = (sum / nItems).ToString("000");
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {

            lstQueueContents.Items.Clear();

            foreach(char c in dataQueue)
                lstQueueContents.Items.Add(c.ToString());
        }
    }
}
