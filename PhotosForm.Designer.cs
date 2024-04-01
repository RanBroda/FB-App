
namespace BasicFacebookFeatures
{
    partial class PhotosForm
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
            this.albumsListsBox = new System.Windows.Forms.ListBox();
            this.albumPicturesBox = new System.Windows.Forms.PictureBox();
            this.nextPicLeft = new System.Windows.Forms.Button();
            this.nextPicRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.albumPicturesBox)).BeginInit();
            this.SuspendLayout();
            // 
            // albumsListsBox
            // 
            this.albumsListsBox.FormattingEnabled = true;
            this.albumsListsBox.ItemHeight = 16;
            this.albumsListsBox.Location = new System.Drawing.Point(31, 102);
            this.albumsListsBox.Name = "albumsListsBox";
            this.albumsListsBox.Size = new System.Drawing.Size(722, 132);
            this.albumsListsBox.TabIndex = 2;
            this.albumsListsBox.SelectedIndexChanged += new System.EventHandler(this.albumsListsBox_SelectedIndexChanged);
            // 
            // albumPicturesBox
            // 
            this.albumPicturesBox.Location = new System.Drawing.Point(299, 243);
            this.albumPicturesBox.Name = "albumPicturesBox";
            this.albumPicturesBox.Size = new System.Drawing.Size(217, 195);
            this.albumPicturesBox.TabIndex = 3;
            this.albumPicturesBox.TabStop = false;
            // 
            // nextPicLeft
            // 
            this.nextPicLeft.Location = new System.Drawing.Point(31, 317);
            this.nextPicLeft.Name = "nextPicLeft";
            this.nextPicLeft.Size = new System.Drawing.Size(83, 50);
            this.nextPicLeft.TabIndex = 5;
            this.nextPicLeft.Text = "<<";
            this.nextPicLeft.UseVisualStyleBackColor = true;
            this.nextPicLeft.Click += new System.EventHandler(this.nextPicLeft_Click);
            // 
            // nextPicRight
            // 
            this.nextPicRight.Location = new System.Drawing.Point(670, 317);
            this.nextPicRight.Name = "nextPicRight";
            this.nextPicRight.Size = new System.Drawing.Size(83, 50);
            this.nextPicRight.TabIndex = 6;
            this.nextPicRight.Text = ">>";
            this.nextPicRight.UseVisualStyleBackColor = true;
            this.nextPicRight.Click += new System.EventHandler(this.nextPicRight_Click);
            // 
            // PhotosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextPicRight);
            this.Controls.Add(this.nextPicLeft);
            this.Controls.Add(this.albumPicturesBox);
            this.Controls.Add(this.albumsListsBox);
            this.Name = "PhotosForm";
            this.Text = "PhotosForm";
            ((System.ComponentModel.ISupportInitialize)(this.albumPicturesBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox albumsListsBox;
        private System.Windows.Forms.PictureBox albumPicturesBox;
        private System.Windows.Forms.Button nextPicLeft;
        private System.Windows.Forms.Button nextPicRight;
    }
}