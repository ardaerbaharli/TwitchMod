using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib.Api;
using TwitchLib.Client;
using TwitchLib.Client.Extensions;
using TwitchLib.Client.Models;

namespace twitchMod
{
    public partial class Form1 : Form
    {
        public Form1(string cn)
        {
            InitializeComponent();
            channelName = cn;
        }

        public static string channelName;

        public static string botName = "BOT NAME";
        public static string botToken = "ENTER BOT TOKEN HERE";
        public static string clientId = "ENTER CLIENT ID HERE";
        public static string streamerToken = "ENTER TOKEN FOR MODERATION";
        private void Form1_Load(object sender, EventArgs e)
        {
            blacklistView.View = View.Details;
            blacklistView.Columns.Add("Username");
            blacklistView.Columns.Add("Message");

            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.TabStop = false;

            btnBan.FlatStyle = FlatStyle.Flat;
            btnBan.FlatAppearance.BorderSize = 1;
            btnBan.TabStop = true;

            btnShowBlacklistWords.FlatStyle = FlatStyle.Flat;
            btnShowBlacklistWords.FlatAppearance.BorderSize = 1;
            btnShowBlacklistWords.TabStop = true;

            btnTimeout.FlatStyle = FlatStyle.Flat;
            btnTimeout.FlatAppearance.BorderSize = 1;
            btnTimeout.TabStop = true;

            AddBlacklist.FlatStyle = FlatStyle.Flat;
            AddBlacklist.FlatAppearance.BorderSize =1;
            AddBlacklist.TabStop = true;

            Control.CheckForIllegalCrossThreadCalls = false;
            Connect();
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

        readonly ConnectionCredentials credentials = new ConnectionCredentials(botName, botToken);
        public static TwitchClient client;
        public static TwitchAPI api;

        private List<string> filter;
        public void Connect()
        {
            filter = Database.GetBlacklistWords();
            client = new TwitchClient();
            client.Initialize(credentials, channelName);
            client.OnConnected += Client_OnConnected;
            client.OnMessageReceived += Client_OnMessageReceived;
            client.Connect();

            api = new TwitchAPI();
            api.Settings.ClientId = clientId;
            api.Settings.AccessToken = botToken;
        }


        private void Client_OnConnected(object sender, TwitchLib.Client.Events.OnConnectedArgs e)
        {
            Console.WriteLine("Connected.");
            label2.Text = "Connected to " + channelName;
        }

        private async void Client_OnMessageReceived(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
        {
            string message = e.ChatMessage.Message;
            string[] fragmentedMessage = message.Split(' ', ',', '.', ':', ';', '\t');
            string username = e.ChatMessage.Username;
            if (filter.Any(s => message.Contains(s)))
            {
                await AddToList(username, message);
            }
        }

        private Task AddToList(string username, string message)
        {
            ListViewItem itm = new ListViewItem(new[] { username, message });

            blacklistView.Items.Add(itm);

            foreach (ColumnHeader column in blacklistView.Columns)
            {
                column.Width = -2;
            }
            return Task.CompletedTask;
        }

        private void AddBlacklist_Click(object sender, EventArgs e)
        {
            Database.AddBlacklistWord(txtBlacklist.Text);
            txtBlacklist.Clear();
            filter = Database.GetBlacklistWords();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            try
            {
                string username = blacklistView.SelectedItems[0].Text;
                string message = blacklistView.SelectedItems[0].SubItems[1].Text;

                if (username != null && message != null)
                    client.BanUser(channelName, username, message);
            }
            catch (Exception)
            {
                MessageBox.Show("You should click a name in the list first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimeout_Click(object sender, EventArgs e)
        {
            try
            {
                string username = blacklistView.SelectedItems[0].Text;
                string message = blacklistView.SelectedItems[0].SubItems[1].Text;
                int timeoutDuration = Convert.ToInt32(num.Value);

                if (ra600.Checked)
                {
                    ra600.Checked = false;
                    timeoutDuration = 600;
                }
                else if (ra300.Checked)
                {
                    ra300.Checked = false;
                    timeoutDuration = 300;
                }
                else if (ra150.Checked)
                {
                    ra150.Checked = false;
                    timeoutDuration = 150;
                }
                else if (ra1.Checked)
                {
                    ra1.Checked = false;
                    timeoutDuration = 1;
                }
                if (username != null && message != null)
                {
                    client.TimeoutUser(channelName, username, TimeSpan.FromSeconds(timeoutDuration), message);
                    num.Value = 1;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("You should click a name in the list first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void blacklistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blacklistView.SelectedItems.Count == 0)
                return;

            string username = blacklistView.SelectedItems[0].Text;
            string message = blacklistView.SelectedItems[0].SubItems[1].Text;
            txtUsername.Text = username;
            txtMessage.Text = message;
        }

        private void btnShowBlacklistWords_Click(object sender, EventArgs e)
        {
            Blacklistwords b = new Blacklistwords();
            b.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
