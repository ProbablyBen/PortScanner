using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortScanner
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnScan_Click(object sender, EventArgs e)
        {
            lstPorts.Items.Clear();
            StartScan();
        }

        private void StartScan()
        {
            IPAddress ip;
            if (!IPAddress.TryParse(txtIP.Text, out ip))
            {
                MessageBox.Show(this, "Failed to parse the IP Address.", "Failure");
                return;
            }

            switch (cmbScanType.Text)
            {
                case "Single Port":
                    {
                        ScanSinglePort(ip);
                        MessageBox.Show(this, "Scan Finished", "Finished.");
                        break;
                    }
                case "Port Range":
                    {
                        ScanPortRange(ip);
                        MessageBox.Show(this, "Scan Finished", "Finished.");
                        break;
                    }
                case "All Ports":
                    {
                        ScanAllPorts(ip);
                        MessageBox.Show(this, "Scan Finished", "Finished.");
                        break;
                    }
            }
        }

        private void ScanSinglePort(IPAddress ip)
        {
            ushort port;
            if (ushort.TryParse(txtPort.Text, out port))
            {
                ScanPort(ip, port);
            }
        }

        private void ScanPortRange(IPAddress ip)
        {
            ushort startRange;
            ushort endRange;
            string[] portRange = txtPort.Text.Split('-');

            // Parse the starting and ending port range values.
            if (portRange.Length == 2 && ushort.TryParse(portRange[0], out startRange) && ushort.TryParse(portRange[1], out endRange))
            {
                for (ushort i = startRange; i <= endRange; i++)
                {
                    ScanPort(ip, i);
                }
            }
            else
            {
                MessageBox.Show(this, "Failed to parse the port range.\nA range looks like this: 2-580", "Failure");
            }
        }

        private void ScanAllPorts(IPAddress ip)
        {
            for (ushort i = 0; i < ushort.MaxValue; i++)
            {
                ScanPort(ip, i);
            }
        }

        private void ScanPort(IPAddress ip, int port)
        {
            Socket s = new Socket(SocketType.Stream, ProtocolType.Tcp);
            new Thread(() =>
            {
                try
                {
                    s.Connect(ip, port);
                    s.Close();
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        lstPorts.Items.Add(new ListViewItem(new string[] { "Open", port.ToString() }));
                    });
                }
                catch (Exception ex)
                {
                    // Failed to connect to the port.
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        lstPorts.Items.Add(new ListViewItem(new string[] { "Closed", port.ToString() }));
                    });
                }
            }).Start();
        }
    }
}
