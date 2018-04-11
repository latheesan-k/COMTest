using System;
using System.Linq;
using System.IO.Ports;
using System.Windows.Forms;
using System.Collections.Generic;

namespace COMTest
{
    public partial class COMTest : Form
    {
        private List<string> comPorts = new List<string>();

        private SerialPort port;

        public COMTest()
        {
            InitializeComponent();
        }

        private void COMTest_Load(object sender, EventArgs e)
        {
            string[] comPortsSearch = SerialPort.GetPortNames();
            foreach (string comPort in comPortsSearch)
            {
                comPorts.Add(comPort);
            }
            comPortList.DataSource = comPorts.ToArray();
            comPortList.SelectedIndex = 0;

            parity.DataSource = Enum.GetValues(typeof(Parity)).Cast<Parity>();
            parity.SelectedIndex = 0;

            stopBits.DataSource = Enum.GetValues(typeof(StopBits)).Cast<StopBits>();
            stopBits.SelectedIndex = 1;

            flowControl.DataSource = Enum.GetValues(typeof(Handshake)).Cast<Handshake>();
            flowControl.SelectedIndex = 0;

            WriteLog("Successfully loaded {0} COM port(s)", comPorts.Count);
        }

        private void COMTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectCOMPort();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            if (actionButton.Text == "Connect")
            {
                WriteLog("Connecting to {0}...", comPortList.SelectedItem);

                try
                {
                    if (string.IsNullOrEmpty(baudRate.Text))
                    {
                        throw new Exception("invalid baud rate");
                    }

                    if (string.IsNullOrEmpty(dataBits.Text))
                    {
                        throw new Exception("invalid speed (bits)");
                    }

                    port = new SerialPort();
                    port.PortName = comPortList.SelectedItem.ToString();
                    port.BaudRate = Convert.ToInt32(baudRate.Text);
                    port.Parity = (Parity)Enum.Parse(typeof(Parity), parity.Text);
                    port.DataBits = Convert.ToInt32(dataBits.Text);
                    port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBits.Text);
                    port.Handshake = (Handshake)Enum.Parse(typeof(Handshake), flowControl.Text);
                    port.RtsEnable = rtsEnable.Checked;
                    port.ReadTimeout = Convert.ToInt32(timeoutMS.Text);
                    port.WriteTimeout = Convert.ToInt32(timeoutMS.Text);
                    port.DataReceived += Port_DataReceived;
                    port.Open();

                    WriteLog("Success, connected");

                    inputData.Enabled = true;
                    sendButton.Enabled = true;
                    comPortList.Enabled = false;
                    baudRate.Enabled = false;
                    parity.Enabled = false;
                    dataBits.Enabled = false;
                    stopBits.Enabled = false;
                    flowControl.Enabled = false;
                    rtsEnable.Enabled = false;
                    lfChar.Enabled = false;
                    timeoutMS.Enabled = false;
                    actionButton.Text = "Disconnect";
                }
                catch (Exception exception)
                {
                    WriteLog("Failed to connect - {0}", exception.Message.Trim());
                }
            }
            else
            {
                WriteLog("Disconnecting from {0}...", comPortList.SelectedItem);

                try
                {
                    DisconnectCOMPort();

                    WriteLog("Success, disconnected");

                    inputData.Enabled = false;
                    sendButton.Enabled = false;
                    comPortList.Enabled = true;
                    baudRate.Enabled = true;
                    parity.Enabled = true;
                    dataBits.Enabled = true;
                    stopBits.Enabled = true;
                    flowControl.Enabled = true;
                    rtsEnable.Enabled = true;
                    lfChar.Enabled = true;
                    timeoutMS.Enabled = true;
                    actionButton.Text = "Connect";
                }
                catch (Exception exception)
                {
                    WriteLog("Failed to disconnect - {0}", exception.Message.Trim());
                }
            }
        }

        private void DisconnectCOMPort()
        {
            if (port != null)
            {
                port.DataReceived -= Port_DataReceived;
                port.Close();
                port.Dispose();
                port = null;
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            WriteLog("Received: {0}", port.ReadExisting());
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (port == null)
                {
                    throw new Exception("not connected to selected COM Port");
                }

                if (string.IsNullOrEmpty(inputData.Text))
                {
                    throw new Exception("You not entered the input data to write");
                }

                string inputDataText = string.Format("{0}{1}",
                    inputData.Text,
                    (!string.IsNullOrEmpty(lfChar.Text) ? lfChar.Text : ""));

                WriteLog("Writing: {0}", inputDataText);

                port.Write(inputData.Text);
            }
            catch (Exception exception)
            {
                WriteLog("Failed to write data - {0}", exception.Message.Trim());
            }
        }

        private void WriteLog(string message, params object[] args)
        {
            if (args.Length > 0)
            { 
                message = string.Format(message, args);
            }

            outputBox.AppendText(string.Format("[ {0} ] : {1}\r\n",
                DateTime.Now.ToLongTimeString(),
                message));
        }
    }
}
