using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Diagnostics;
using SDRSharp.Common;
using SDRSharp.Radio;
using System.Reflection.Emit;
using System.Net.Sockets;
using System.Net;

namespace SDRSharp.UDPSignalExporter
{
    public partial class ControlPanel : UserControl
    {
        private ISharpControl _control;
        private static System.Timers.Timer captureSignalTimer;
        private UdpClient udpClient;
        private int udpPort = 9988;
        private String udpAddress = "255.255.255.255";
        private bool exporterEnabled = false;

        public ControlPanel(ISharpControl control)
        {
            _control = control;
            captureSignalTimer = new System.Timers.Timer(500);
            captureSignalTimer.Elapsed += CaptureSignalEvent;
            captureSignalTimer.AutoReset = true;

            udpClient = new UdpClient();

            _control.PropertyChanged += this.HandleRadioPropertyChanged;
            InitializeComponent();
        }

        private void _control_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void toggleExporterBtn(object sender, EventArgs e)
        {
            ToggleExporterState();
        }

        private void ToggleExporterState()
        {
            if (exporterEnabled)
            {
                DisableExporter();
            }
            else
            {
                EnableExporter();
            }
        }

        private void EnableExporter()
        {
            exporterEnabled = true;
            if (_control.IsPlaying)
            {
                captureSignalTimer.Start();
            }
            EnableBtn.Text = "Disable";
        }

        private void DisableExporter()
        {
            exporterEnabled = false;
            captureSignalTimer.Stop();
            EnableBtn.Text = "Enable";

        }
        void HandleRadioPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Debug.WriteLine(e.PropertyName);

            switch (e.PropertyName)
            {
                case "StartRadio":
                    if (exporterEnabled)
                    {
                        captureSignalTimer.Start();
                    }
                    break;
                case "StopRadio":
                    captureSignalTimer.Stop();
                    break;
            }
        }

        private void CaptureSignalEvent(object sender, System.EventArgs e)
        {
            //Debug.WriteLine("Floor: " + _control.VisualFloor + "dB Peak: " + _control.VisualPeak + "db SNR: " + _control.VisualSNR + "db");
            var values = String.Format("{0:0.#};{1:0.#};{2:0.#}\n", _control.VisualFloor, _control.VisualPeak, _control.VisualSNR);
            var data = Encoding.UTF8.GetBytes(values);
            try
            {
                udpClient.Send(data, data.Length, udpAddress, udpPort);
            }
            catch (SocketException err)
            {
                DisableExporter();
                MessageBox.Show(err.Message + " Please provide a valid IP Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PortValueChanged(object sender, EventArgs e)
        {
            udpPort = Convert.ToInt32(ipPortUpDown.Value);
        }

        private void AddressBoxValueChanged(object sender, EventArgs e)
        {
            udpAddress = ipAddressBox.Text;
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            var helpWindow = new HelpForm();
            helpWindow.Show();
        }

        private void IntervalUpDown_ValueChanged(object sender, EventArgs e)
        {
            captureSignalTimer.Interval = Convert.ToDouble(intervalUpDown.Value);
            if (captureSignalTimer.Enabled)
            {
                captureSignalTimer.Stop();
                captureSignalTimer.Start();
            }
        }
    }
}
