using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS7341_Manager
{
    public partial class Form1 : Form
    {
        string dataIn;
        string dataOut;

        public Boolean fIdent;

        public void PortNameToCbox(ComboBox cbox)
        {
            cbox.Items.Clear();

            foreach (string port in SerialPort.GetPortNames())
            {
                cbox.Items.Add(port);
            }
        }
        public void OpenPort(string port)
        {
            try
            {
                serialPort.PortName     = port;
                serialPort.BaudRate     = Convert.ToInt32(cboxBaud.SelectedItem);
                serialPort.DataBits     = Convert.ToInt32(cboxData.SelectedItem);
                serialPort.Parity       = (Parity)Enum.Parse(typeof(Parity), cboxParity.Text);
                serialPort.StopBits     = (StopBits)Enum.Parse(typeof(StopBits), cboxStopBits.Text);
                serialPort.Handshake    = (Handshake)Enum.Parse(typeof(Handshake), cboxHandshake.Text);

                serialPort.ReadTimeout = 500;
                serialPort.WriteTimeout = 500;

                serialPort.Open(); 
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }        
        public void SetDefaults()
        {
            // Load port settings
            cboxBaud.SelectedIndex      = 11;
            cboxData.SelectedIndex      = 3;
            cboxParity.SelectedIndex    = 0;
            cboxStopBits.SelectedIndex  = 0;
            cboxHandshake.SelectedIndex = 0;

            pictureBox.Image = null;

            lblHost.Text = " ";
            lblPeriph.Text = " ";
            lblRelease.Text = " ";

            tabControl.SelectedTab.BackgroundImage = SetImageOpacity(AS7341_Manager.Properties.Resources.chip_256, 0.20F);

            btnConnect.Text = "Connect";
        }
        public Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
                                                  ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                                   0, 0, image.Width, image.Height,
                                   GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        public Form1()
        {
            InitializeComponent();
            SetDefaults();
        }

        private void btnComs_Click(object sender, EventArgs e)
        {
            PortNameToCbox(cboxPort);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(serialPort.IsOpen)
            {
                serialPort.Close();
                btnConnect.BackColor = Color.Transparent;
                btnConnect.Text = "Connect";
                btnComs.Enabled = true;
                toolStripLblStatus.Text = "Unconnected !";
                panelPort.Enabled = true;

                lblHost.Text = "";
                lblPeriph.Text = "";
                lblRelease.Text = "";
                pictureBox.Image = null;
            }
            else
            {
                OpenPort(cboxPort.Text);
                if (serialPort.IsOpen)
                {
                    btnConnect.BackColor = Color.Green;
                    btnConnect.Text = "Connected";
                    btnComs.Enabled = false;
                    panelPort.Enabled = false;
                    toolStripLblStatus.Text = "Connected !";
                }
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort.ReadExisting();
            this.Invoke(new EventHandler(DataProceed));
        }

        private void DataProceed(object sender, EventArgs e)
        {
            toolStripLblStatus.Text = dataIn;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cboxPort.Items.AddRange(ports);
            cboxPort.SelectedIndex = 0;
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            if(serialPort.IsOpen)
            {
                serialPort.WriteLine("_Whois");     // ESP32-AS7341-Rel.21.09.22
                fIdent = true;
            }
            else
            {
                lblHost.Text = "";
                lblPeriph.Text = "";
                lblRelease.Text = "";
                pictureBox.Image = null;

                toolStripLblStatus.Text = "Device not connect !";
            }
        }
        // maintenance procedures
        private void toolStripLblStatus_TextChanged(object sender, EventArgs e)
        {
            if(serialPort.IsOpen)
            {   
                // send identifiers to labels
                if(fIdent == true)
                {
                    string[] input = toolStripLblStatus.Text.Split('-');
                    if(input.GetLength(0) == 3)
                    {
                        lblHost.Text = input[0];
                        lblPeriph.Text = input[1];
                        lblRelease.Text = input[2];
                        pictureBox.Image = AS7341_Manager.Properties.Resources.chip_64;
                    }
                    else
                    {
                        lblHost.Text = "";
                        lblPeriph.Text = "";
                        lblRelease.Text = "";
                        pictureBox.Image = null;
                    }
                    fIdent = false;
                }










            }

            toolStripLblStatus.Text = " ";
        }
    }
}
