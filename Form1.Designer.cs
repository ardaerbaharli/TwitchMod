namespace twitchMod
{
    partial class Form1
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
            this.blacklistView = new System.Windows.Forms.ListView();
            this.txtBlacklist = new System.Windows.Forms.TextBox();
            this.AddBlacklist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBan = new System.Windows.Forms.Button();
            this.btnTimeout = new System.Windows.Forms.Button();
            this.ra600 = new System.Windows.Forms.RadioButton();
            this.ra150 = new System.Windows.Forms.RadioButton();
            this.ra300 = new System.Windows.Forms.RadioButton();
            this.ra1 = new System.Windows.Forms.RadioButton();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnShowBlacklistWords = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.SuspendLayout();
            // 
            // blacklistView
            // 
            this.blacklistView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.blacklistView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
            this.blacklistView.HideSelection = false;
            this.blacklistView.Location = new System.Drawing.Point(12, 47);
            this.blacklistView.MultiSelect = false;
            this.blacklistView.Name = "blacklistView";
            this.blacklistView.Size = new System.Drawing.Size(363, 394);
            this.blacklistView.TabIndex = 1;
            this.blacklistView.TabStop = false;
            this.blacklistView.UseCompatibleStateImageBehavior = false;
            this.blacklistView.SelectedIndexChanged += new System.EventHandler(this.blacklistView_SelectedIndexChanged);
            // 
            // txtBlacklist
            // 
            this.txtBlacklist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtBlacklist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBlacklist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
            this.txtBlacklist.Location = new System.Drawing.Point(461, 80);
            this.txtBlacklist.Name = "txtBlacklist";
            this.txtBlacklist.Size = new System.Drawing.Size(218, 29);
            this.txtBlacklist.TabIndex = 0;
            // 
            // AddBlacklist
            // 
            this.AddBlacklist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddBlacklist.Location = new System.Drawing.Point(695, 80);
            this.AddBlacklist.Name = "AddBlacklist";
            this.AddBlacklist.Size = new System.Drawing.Size(93, 44);
            this.AddBlacklist.TabIndex = 1;
            this.AddBlacklist.Text = "Add";
            this.AddBlacklist.UseVisualStyleBackColor = true;
            this.AddBlacklist.Click += new System.EventHandler(this.AddBlacklist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(456, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 3;
            this.label1.Tag = "";
            this.label1.Text = "Add Blacklist Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // btnBan
            // 
            this.btnBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBan.Location = new System.Drawing.Point(390, 263);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(94, 37);
            this.btnBan.TabIndex = 5;
            this.btnBan.TabStop = false;
            this.btnBan.Text = "Ban";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // btnTimeout
            // 
            this.btnTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTimeout.Location = new System.Drawing.Point(390, 326);
            this.btnTimeout.Name = "btnTimeout";
            this.btnTimeout.Size = new System.Drawing.Size(94, 37);
            this.btnTimeout.TabIndex = 5;
            this.btnTimeout.TabStop = false;
            this.btnTimeout.Text = "Timeout";
            this.btnTimeout.UseVisualStyleBackColor = true;
            this.btnTimeout.Click += new System.EventHandler(this.btnTimeout_Click);
            // 
            // ra600
            // 
            this.ra600.AutoSize = true;
            this.ra600.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ra600.Location = new System.Drawing.Point(517, 331);
            this.ra600.Name = "ra600";
            this.ra600.Size = new System.Drawing.Size(67, 28);
            this.ra600.TabIndex = 6;
            this.ra600.Text = "600s";
            this.ra600.UseVisualStyleBackColor = true;
            // 
            // ra150
            // 
            this.ra150.AutoSize = true;
            this.ra150.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ra150.Location = new System.Drawing.Point(663, 330);
            this.ra150.Name = "ra150";
            this.ra150.Size = new System.Drawing.Size(67, 28);
            this.ra150.TabIndex = 6;
            this.ra150.Text = "150s";
            this.ra150.UseVisualStyleBackColor = true;
            // 
            // ra300
            // 
            this.ra300.AutoSize = true;
            this.ra300.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ra300.Location = new System.Drawing.Point(590, 330);
            this.ra300.Name = "ra300";
            this.ra300.Size = new System.Drawing.Size(67, 28);
            this.ra300.TabIndex = 6;
            this.ra300.Text = "300s";
            this.ra300.UseVisualStyleBackColor = true;
            // 
            // ra1
            // 
            this.ra1.AutoSize = true;
            this.ra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ra1.Location = new System.Drawing.Point(736, 331);
            this.ra1.Name = "ra1";
            this.ra1.Size = new System.Drawing.Size(47, 28);
            this.ra1.TabIndex = 6;
            this.ra1.Text = "1s";
            this.ra1.UseVisualStyleBackColor = true;
            // 
            // num
            // 
            this.num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
            this.num.Location = new System.Drawing.Point(618, 384);
            this.num.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(77, 29);
            this.num.TabIndex = 7;
            this.num.TabStop = false;
            this.num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(642, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "or";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "GOTCHA LIST";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(386, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(573, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Message";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
            this.txtUsername.Location = new System.Drawing.Point(390, 195);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(165, 26);
            this.txtUsername.TabIndex = 12;
            this.txtUsername.TabStop = false;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMessage
            // 
            this.txtMessage.AllowDrop = true;
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
            this.txtMessage.Location = new System.Drawing.Point(574, 195);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(206, 105);
            this.txtMessage.TabIndex = 12;
            this.txtMessage.TabStop = false;
            this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShowBlacklistWords
            // 
            this.btnShowBlacklistWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnShowBlacklistWords.Location = new System.Drawing.Point(695, 130);
            this.btnShowBlacklistWords.Name = "btnShowBlacklistWords";
            this.btnShowBlacklistWords.Size = new System.Drawing.Size(93, 36);
            this.btnShowBlacklistWords.TabIndex = 13;
            this.btnShowBlacklistWords.TabStop = false;
            this.btnShowBlacklistWords.Text = "Blacklist";
            this.btnShowBlacklistWords.UseVisualStyleBackColor = true;
            this.btnShowBlacklistWords.Click += new System.EventHandler(this.btnShowBlacklistWords_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnClose.Location = new System.Drawing.Point(750, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 30);
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowBlacklistWords);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num);
            this.Controls.Add(this.ra300);
            this.Controls.Add(this.ra1);
            this.Controls.Add(this.ra150);
            this.Controls.Add(this.ra600);
            this.Controls.Add(this.btnTimeout);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBlacklist);
            this.Controls.Add(this.blacklistView);
            this.Controls.Add(this.AddBlacklist);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(11)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView blacklistView;
        private System.Windows.Forms.TextBox txtBlacklist;
        private System.Windows.Forms.Button AddBlacklist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Button btnTimeout;
        private System.Windows.Forms.RadioButton ra600;
        private System.Windows.Forms.RadioButton ra150;
        private System.Windows.Forms.RadioButton ra300;
        private System.Windows.Forms.RadioButton ra1;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnShowBlacklistWords;
        private System.Windows.Forms.Button btnClose;
    }
}

