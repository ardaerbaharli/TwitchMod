using System;
using System.Drawing;
using System.Windows.Forms;

namespace twitchMod
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        private void Start_Load(object sender, EventArgs e)
        {
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.TabStop = false;

            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.TabStop = true;

        }

        #region Move the window by form
        private bool mouseDown;
        private Point lastLocation;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion
        public bool DidUserEnterChannelName { get; private set; }
        public static string channelName { get; set; }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtChannelName.Text != null)
            {
                DidUserEnterChannelName = true;
                channelName = txtChannelName.Text;
                Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}