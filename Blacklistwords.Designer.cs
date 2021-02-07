
namespace twitchMod
{
    partial class Blacklistwords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRemoveBlacklistItem = new System.Windows.Forms.Button();
            this.blacklistView = new System.Windows.Forms.ListView();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemoveBlacklistItem
            // 
            this.btnRemoveBlacklistItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnRemoveBlacklistItem.Location = new System.Drawing.Point(198, 57);
            this.btnRemoveBlacklistItem.Name = "btnRemoveBlacklistItem";
            this.btnRemoveBlacklistItem.Size = new System.Drawing.Size(90, 334);
            this.btnRemoveBlacklistItem.TabIndex = 0;
            this.btnRemoveBlacklistItem.UseVisualStyleBackColor = true;
            this.btnRemoveBlacklistItem.Click += new System.EventHandler(this.btnRemoveBlacklistItem_Click);
            // 
            // blacklistView
            // 
            this.blacklistView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.blacklistView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
            this.blacklistView.HideSelection = false;
            this.blacklistView.Location = new System.Drawing.Point(12, 12);
            this.blacklistView.MultiSelect = false;
            this.blacklistView.Name = "blacklistView";
            this.blacklistView.Size = new System.Drawing.Size(180, 379);
            this.blacklistView.TabIndex = 2;
            this.blacklistView.TabStop = false;
            this.blacklistView.UseCompatibleStateImageBehavior = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnClose.Location = new System.Drawing.Point(200, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 39);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Blacklistwords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(302, 405);
            this.ControlBox = false;
            this.Controls.Add(this.blacklistView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemoveBlacklistItem);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(11)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Blacklistwords";
            this.Text = "Blacklistwords";
            this.Load += new System.EventHandler(this.Blacklistwords_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveBlacklistItem;
        private System.Windows.Forms.ListView blacklistView;
        private System.Windows.Forms.Button btnClose;
    }
}