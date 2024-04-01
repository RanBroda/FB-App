
namespace BasicFacebookFeatures
{
    partial class GroupsForm
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
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.lableCount = new System.Windows.Forms.Label();
            this.lableMembers = new System.Windows.Forms.Label();
            this.listLongI = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // groupsListBox
            // 
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.ItemHeight = 16;
            this.groupsListBox.Location = new System.Drawing.Point(-1, 60);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(801, 132);
            this.groupsListBox.TabIndex = 0;
            this.groupsListBox.SelectedIndexChanged += new System.EventHandler(this.groupsListBox_SelectedIndexChanged);
            // 
            // lableCount
            // 
            this.lableCount.AutoSize = true;
            this.lableCount.Location = new System.Drawing.Point(275, 261);
            this.lableCount.Name = "lableCount";
            this.lableCount.Size = new System.Drawing.Size(0, 17);
            this.lableCount.TabIndex = 1;
            // 
            // lableMembers
            // 
            this.lableMembers.AutoSize = true;
            this.lableMembers.Location = new System.Drawing.Point(278, 221);
            this.lableMembers.Name = "lableMembers";
            this.lableMembers.Size = new System.Drawing.Size(0, 17);
            this.lableMembers.TabIndex = 2;
            // 
            // listLongI
            // 
            this.listLongI.FormattingEnabled = true;
            this.listLongI.ItemHeight = 16;
            this.listLongI.Location = new System.Drawing.Point(-1, 328);
            this.listLongI.Name = "listLongI";
            this.listLongI.Size = new System.Drawing.Size(801, 116);
            this.listLongI.TabIndex = 3;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listLongI);
            this.Controls.Add(this.lableMembers);
            this.Controls.Add(this.lableCount);
            this.Controls.Add(this.groupsListBox);
            this.Name = "GroupsForm";
            this.Text = "GroupsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox groupsListBox;
        private System.Windows.Forms.Label lableCount;
        private System.Windows.Forms.Label lableMembers;
        private System.Windows.Forms.ListBox listLongI;
    }
}