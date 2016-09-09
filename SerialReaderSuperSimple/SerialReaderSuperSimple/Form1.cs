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

namespace SerialReaderSuperSimple
{
    // Struct to store acceleration data
    public struct AccelData
    {
        byte start;
        public byte x { get; set; }
        public byte y { get; set; }
        public byte z { get; set; }
    };

    public partial class Form1 : Form
    {
        // Class Variables
        byte[] data; // Holds all data in input buffer
        ConcurrentQueue<AccelData> dataQueue = new ConcurrentQueue<AccelData>(); // Stores acceleration data
        int packetSize;

        public Form1()
        {
            InitializeComponent();

            data = new byte[serGumstick.ReadBufferSize];
            packetSize = System.Runtime.InteropServices.Marshal.SizeOf(typeof(AccelData));
            serGumstick.ReceivedBytesThreshold = packetSize;
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            AccelData accel = new AccelData();

            // Deque all 'old' acceleration values. Use the latest one
            for (int i = dataQueue.Count; i > 0; i--)
                dataQueue.TryDequeue(out accel);
            
            txtXAccel.Text = accel.x.ToString();
            txtYAccel.Text = accel.y.ToString();
            txtZAccel.Text = accel.z.ToString();
        }

        private void serGumstick_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            AccelData accel = new AccelData();
            byte[] latestData = new byte[packetSize];

            // No. of bytes in input buffer
            int bytesToRead = serGumstick.BytesToRead;

            // Read in all the bytes in the buffer
            lock(serGumstick)
                serGumstick.Read(data, 0, serGumstick.ReadBufferSize);

            // Store latest data
            Array.Copy(data, bytesToRead - packetSize, latestData, 0, packetSize);

            // Look for new byte (255) and assign accelerations
            for(int index = 0; index < packetSize; index++)
            {
                if(latestData[index] == 255)
                {
                    accel.x = latestData[(index + 1) % 4];
                    accel.y = latestData[(index + 2) % 4];
                    accel.z = latestData[(index + 3) % 4];
                    dataQueue.Enqueue(accel);
                }
            }
        }

        private void btnComStatus_Click(object sender, EventArgs e)
        {
            if(cmbComPort.SelectedItem != null && !string.IsNullOrWhiteSpace(cmbComPort.SelectedItem.ToString()))
            {
                try
                {
                    if (!serGumstick.IsOpen)
                    {
                        serGumstick.Open();
                        btnComStatus.Text = "Disconnect";
                        cmbComPort.Enabled = false;
                    }
                    else
                    {
                        lock(serGumstick)
                            serGumstick.Close();

                        btnComStatus.Text = "Connect";
                        cmbComPort.Enabled = true;
                    }
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR");
                }
            }
        }

        private void cmbComPort_DropDown(object sender, EventArgs e)
        {
            // Remove all ports from combo box as some may no longer exist
            cmbComPort.Items.Clear();

            // Populate combo box with available devices / ports
            cmbComPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames().ToArray());
        }

        private void cmbComPort_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Check if connection to this port is active or not
            serGumstick.PortName = cmbComPort.SelectedItem.ToString();
            if (serGumstick.IsOpen)
                btnComStatus.Text = "Disconnect";
            else
                btnComStatus.Text = "Connect";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            lock (serGumstick)
                serGumstick.Close();
        }
    }
}
