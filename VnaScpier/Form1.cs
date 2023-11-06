using System.Diagnostics;

using VnaLibrary;

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;

using Ivi.Visa;

namespace VnaScpier
{
    public partial class Form1 : Form
    {

        Vna MyVna = null;

        Stopwatch MyTimer = new Stopwatch();
        Double TimeInMilliSeconds;
        Double Time0, Time1;

        public Form1()
        {
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
            
            try
            {
                IEnumerable<string> devices = GlobalResourceManager.Find("?*INSTR");

                foreach (string device in devices)
                {
                    IPxiSession session = GlobalResourceManager.Open(device) as IPxiSession;


                    Console.WriteLine("Address: {0}", device);

                    if (session.ModelName.Substring(0, 5) == "M980X" || session.ModelName.Substring(0, 5) == "M937X") 
                    {
                        tbVisaAddress.Text = String.Format("TCPIP0::LocalHost::hislip_PXI0_CHASSIS1_SLOT{0}_INDEX0::INSTR", session.Slot);
                        tbVisaAddress.ForeColor = Color.Black;
                    }

                    // Close the connection to the instrument
                    session.Dispose();
                }
            }
            catch
            {
                Console.WriteLine();
            }

            btnConnect.Focus();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            MyTimer.Reset();
            MyTimer.Start();

            MyVna = new Vna();

            Time0 = MyTimer.ElapsedTicks;

            string visaAddr = tbVisaAddress.Text;
            bool init = StartVNA(visaAddr, MyVna);

            Time1 = MyTimer.ElapsedTicks;
            TimeInMilliSeconds = 1000 * (double)(Time1 - Time0) / Stopwatch.Frequency;

            if (init)
            {
                btnConnect.BackColor = Color.DarkGray;
                btnConnect.Text = "Connected";
                btnConnect.Enabled = false;
                tbScpiCommand.Text = "";
                tbOutput.Text = $"connection time = {TimeInMilliSeconds} ms";
            }
            else
            {
                tbVisaAddress.Text = "Connection Error";
                tbVisaAddress.ForeColor = Color.Red;
            }

        }


        private void btnWrite_Click(object sender, EventArgs e)
        {
            MyTimer.Reset();
            MyTimer.Start();

            Time0 = MyTimer.ElapsedTicks;

            MyVna.WriteSCPI(tbScpiCommand.Text);

            Time1 = MyTimer.ElapsedTicks;
            TimeInMilliSeconds = 1000 * (Double)(Time1 - Time0) / Stopwatch.Frequency;
            tbScpiCommand.Text = "";
            tbOutput.Text = $"command time = {TimeInMilliSeconds} ms";
        }

        private void btnWriteRead_Click(object sender, EventArgs e)
        {
            Time0 = MyTimer.ElapsedTicks;

            string cmd = MyVna.ReadSCPI(tbScpiCommand.Text);

            Time1 = MyTimer.ElapsedTicks;
            TimeInMilliSeconds = 1000 * (Double)(Time1 - Time0) / Stopwatch.Frequency;

            tbScpiCommand.Text = "";
            tbOutput.Text = cmd;
            tbOutput.Text += $"\r\ncommand time = {TimeInMilliSeconds} ms";

        }

        static bool StartVNA(string visaAddr, Vna MyVna)
        {
            const int Timeout = 100000;

            bool bInit = MyVna.InitVna(visaAddr, Timeout, out string msgError);
            if (msgError == null)
                MessageBox.Show("VISA connection error.");

            return bInit;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the testing process?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;

            }
            else
            {
                MyVna?.Close();

                GC.Collect();
            }
        }

    }


}