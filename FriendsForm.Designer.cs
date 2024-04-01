
namespace BasicFacebookFeatures
{
    partial class FriendsForm
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
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.labelSelectedFriendName = new System.Windows.Forms.Label();
            this.labelFriendBirthday = new System.Windows.Forms.Label();
            this.labelFriendEmail = new System.Windows.Forms.Label();
            this.labelFriendGender = new System.Windows.Forms.Label();
            this.friendPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.friendPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 16;
            this.friendsListBox.Location = new System.Drawing.Point(373, 131);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(180, 356);
            this.friendsListBox.TabIndex = 1;
            this.friendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged);
            // 
            // labelSelectedFriendName
            // 
            this.labelSelectedFriendName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSelectedFriendName.AutoSize = true;
            this.labelSelectedFriendName.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedFriendName.ForeColor = System.Drawing.Color.Teal;
            this.labelSelectedFriendName.Location = new System.Drawing.Point(57, 165);
            this.labelSelectedFriendName.Name = "labelSelectedFriendName";
            this.labelSelectedFriendName.Size = new System.Drawing.Size(130, 20);
            this.labelSelectedFriendName.TabIndex = 17;
            this.labelSelectedFriendName.Text = "Friend Name";
            // 
            // labelFriendBirthday
            // 
            this.labelFriendBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFriendBirthday.AutoSize = true;
            this.labelFriendBirthday.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendBirthday.ForeColor = System.Drawing.Color.Teal;
            this.labelFriendBirthday.Location = new System.Drawing.Point(57, 218);
            this.labelFriendBirthday.Name = "labelFriendBirthday";
            this.labelFriendBirthday.Size = new System.Drawing.Size(89, 20);
            this.labelFriendBirthday.TabIndex = 18;
            this.labelFriendBirthday.Text = "Birthday";
            // 
            // labelFriendEmail
            // 
            this.labelFriendEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFriendEmail.AutoSize = true;
            this.labelFriendEmail.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendEmail.ForeColor = System.Drawing.Color.Teal;
            this.labelFriendEmail.Location = new System.Drawing.Point(57, 283);
            this.labelFriendEmail.Name = "labelFriendEmail";
            this.labelFriendEmail.Size = new System.Drawing.Size(59, 20);
            this.labelFriendEmail.TabIndex = 19;
            this.labelFriendEmail.Text = "Email";
            // 
            // labelFriendGender
            // 
            this.labelFriendGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFriendGender.AutoSize = true;
            this.labelFriendGender.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendGender.ForeColor = System.Drawing.Color.Teal;
            this.labelFriendGender.Location = new System.Drawing.Point(57, 348);
            this.labelFriendGender.Name = "labelFriendGender";
            this.labelFriendGender.Size = new System.Drawing.Size(79, 20);
            this.labelFriendGender.TabIndex = 20;
            this.labelFriendGender.Text = "Gender";
            // 
            // friendPictureBox
            // 
            this.friendPictureBox.Location = new System.Drawing.Point(640, 228);
            this.friendPictureBox.Name = "friendPictureBox";
            this.friendPictureBox.Size = new System.Drawing.Size(162, 140);
            this.friendPictureBox.TabIndex = 21;
            this.friendPictureBox.TabStop = false;
            // 
            // FriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 565);
            this.Controls.Add(this.friendPictureBox);
            this.Controls.Add(this.labelFriendGender);
            this.Controls.Add(this.labelFriendEmail);
            this.Controls.Add(this.labelFriendBirthday);
            this.Controls.Add(this.labelSelectedFriendName);
            this.Controls.Add(this.friendsListBox);
            this.Name = "FriendsForm";
            this.Text = "FriendsForm";
            ((System.ComponentModel.ISupportInitialize)(this.friendPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.Label labelSelectedFriendName;
        private System.Windows.Forms.Label labelFriendBirthday;
        private System.Windows.Forms.Label labelFriendEmail;
        private System.Windows.Forms.Label labelFriendGender;
        private System.Windows.Forms.PictureBox friendPictureBox;
    }
}