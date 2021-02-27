using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace twitchMod
{
    public partial class Blacklistwords : Form
    {
        public Blacklistwords()
        {
            InitializeComponent();
        }
        private void Blacklistwords_Load(object sender, EventArgs e)
        {
            btnRemoveBlacklistItem.FlatStyle = FlatStyle.Flat;
            btnRemoveBlacklistItem.FlatAppearance.BorderSize = 0;
            btnRemoveBlacklistItem.TabStop = true;
            btnRemoveBlacklistItem.Text = "R\nE\nM\nO\nV\nE";

            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.TabStop = false;

            blacklistView.View = View.Details;
            blacklistView.Columns.Add("Words");

            blacklistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            blacklistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            List<string> blacklistWords = Database.GetBlacklistWords();
            FillListview(blacklistWords);
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
        private void btnRemoveBlacklistItem_Click(object sender, EventArgs e)
        {
            try
            {
                string word = blacklistView.SelectedItems[0].Text;

                if (word != null)
                    Database.RemoveBlacklistWord(word);

                List<string> blacklistWords = Database.GetBlacklistWords();
                FillListview(blacklistWords);
                Form1.UpdateFilter();
            }
            catch (Exception)
            {
                MessageBox.Show("You should click on a word in the list first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      
      
       

        private void FillListview(List<string> blacklistWords)
        {
            blacklistView.Items.Clear();
            foreach (var word in blacklistWords)
            {
                blacklistView.Items.Add(word);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}