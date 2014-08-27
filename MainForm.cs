using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;

using AForge.Video;
using AForge.Video.DirectShow;

namespace macsurvControl
{
    public partial class MainForm : Form
    {
        private Stopwatch stopWatch = null;
        public string direction;
        //public int tTime;
        public string address;
        public int upStatus, downStatus, rightStatus, leftStatus, hornStatus;
        public int output;
        //static Socket m_sockListener;
        public string RetPage;


        TcpClient client = new TcpClient();
        IPEndPoint serverEndPoint;

        // Class constructor
        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

          protected override void OnKeyDown(KeyEventArgs keyEvent)
        {
            keyEvent.Handled = true;
            if (keyEvent.KeyCode == Keys.W || keyEvent.KeyCode == Keys.NumPad8)
            {
                upBtn.BackgroundImage = global::macsurvControl.Properties.Resources.pressed;
                // Gets the key code; A, W, D 
                //lbl.Text = "KeyCode: " + keyEvent.KeyCode.ToString();
                upStatus = 1;
            }
            else if (keyEvent.KeyCode == Keys.Space)
            {
                downBtn.BackgroundImage = global::macsurvControl.Properties.Resources.pressed;
               // lbl.Text = "KeyCode: " + keyEvent.KeyCode.ToString();
                downStatus = 2;
            }
            else if (keyEvent.KeyCode == Keys.A || keyEvent.KeyCode == Keys.NumPad4)
            {
                leftBtn.BackgroundImage = global::macsurvControl.Properties.Resources.pressed;
               // lbl.Text = "KeyCode: " + keyEvent.KeyCode.ToString();
                leftStatus = 8;
            }
            else if (keyEvent.KeyCode == Keys.D || keyEvent.KeyCode == Keys.NumPad6)
            {
                rightBtn.BackgroundImage = global::macsurvControl.Properties.Resources.pressed;
               // lbl.Text = "KeyCode: " + keyEvent.KeyCode.ToString();
                rightStatus = 4;
            }
        }

        protected override void OnKeyUp(KeyEventArgs keyEvent)
        {
            keyEvent.Handled = true;
            if (Keys.W == keyEvent.KeyCode || keyEvent.KeyCode == Keys.NumPad8)//Gets the key code
            {
                upBtn.BackgroundImage = global::macsurvControl.Properties.Resources.unpressed;
                upStatus = 0; 
            }
            else if (Keys.Space == keyEvent.KeyCode)
            {
                downBtn.BackgroundImage = global::macsurvControl.Properties.Resources.unpressed;
                downStatus = 0;
            }
            else if (Keys.D == keyEvent.KeyCode || keyEvent.KeyCode == Keys.NumPad6)
            {
                rightBtn.BackgroundImage = global::macsurvControl.Properties.Resources.unpressed;
                rightStatus = 0;
            }
            else if (Keys.A == keyEvent.KeyCode || keyEvent.KeyCode == Keys.NumPad4)
            {
                leftBtn.BackgroundImage = global::macsurvControl.Properties.Resources.unpressed;
                leftStatus = 0;
            }
        }
        
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            //// create video source
            //MJPEGStream mjpegSource = new MJPEGStream("http://192.168.1.191:81/videostream.cgi?user=admin&pwd=admin&resolution=8&rate=11");
            //// open it
            //OpenVideoSource(mjpegSource);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseCurrentVideoSource();
        }

        // "Exit" menu item clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Open video source
        private void OpenVideoSource(IVideoSource source)
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;

            // stop current video source
            CloseCurrentVideoSource();

            // start new video source
            videoSourcePlayer.VideoSource = source;
            videoSourcePlayer.Start();

            // reset stop watch
            stopWatch = null;

            // start timer
            timer.Start();

            this.Cursor = Cursors.Default;
        }

        // Close video source if it is running
        private void CloseCurrentVideoSource()
        {
            if (videoSourcePlayer.VideoSource != null)
            {
                videoSourcePlayer.SignalToStop();

                // wait ~ 3 seconds
                for (int i = 0; i < 30; i++)
                {
                    if (!videoSourcePlayer.IsRunning)
                        break;
                    System.Threading.Thread.Sleep(100);
                }

                if (videoSourcePlayer.IsRunning)
                {
                    videoSourcePlayer.Stop();
                }

                videoSourcePlayer.VideoSource = null;
            }
        }

        // New frame received by the player
        private void videoSourcePlayer_NewFrame(object sender, ref Bitmap image)
        {
            DateTime now = DateTime.Now;
            Graphics g = Graphics.FromImage(image);

            // paint current time
            SolidBrush brush = new SolidBrush(Color.Red);
            g.DrawString(now.ToString(), this.Font, brush, new PointF(5, 5));
            brush.Dispose();

            g.Dispose();
        }

        // On timer event - gather statistics
        private void timer_Tick(object sender, EventArgs e)
        {
            // call motion in timer to keep the tyres rolling until keys are pressed.
           motion(upStatus + downStatus + rightStatus + leftStatus + hornStatus);
        }

        public void motion(int output)
        {
            if (client.Connected)
            {
                lblIsConn.Text = "Connected";
                lblNotify.Text = "Sending data";
                if (output == 0xC || output == 0x1C)
                {
                    output = output - 8;
                }
                if (output == 0x3 || output == 0x13)
                {
                    output = output - 2;
                }
                output += 1;
                NetworkStream clientStream = client.GetStream();
                byte[] buffer = Encoding.Default.GetBytes(new char[] { (char)output, (char)0 });
                clientStream.Write(buffer, 0, buffer.Length);
                //// show me watcha sending in debug window
                //Debug.WriteLine(Convert.ToString(buffer[1]) + Convert.ToString(buffer[0]));
                lblNotify.Text = Convert.ToString(buffer[1]) + Convert.ToString(buffer[0]);
                lblNotify.Text = "";
                clientStream.Flush();
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {            // create video source
            MJPEGStream mjpegSource = new MJPEGStream("http://192.168.1.191:81/videostream.cgi?user=admin&pwd=admin&resolution=8&rate=11");
            // open it
            OpenVideoSource(mjpegSource);

            lblNotify.Text = "";
            try
            {
                serverEndPoint = new IPEndPoint(IPAddress.Parse(txtIp.Text), 1500);
                client.Connect(serverEndPoint);
                lblIsConn.Text = "Connection Successful";
            }
            catch(Exception ex)
            {
                lblNotify.Text = "ERROR:" + ex.Message ;
            }
        }
    }
}
