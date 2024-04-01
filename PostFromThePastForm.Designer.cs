
namespace BasicFacebookFeatures
{
    partial class PostFromThePastForm
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
            this.DateOfPostTB = new System.Windows.Forms.Label();
            this.PostFromPastTB = new System.Windows.Forms.Label();
            this.PastPostClickBtn = new System.Windows.Forms.Button();
            this.ShareBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateOfPostTB
            // 
            this.DateOfPostTB.AutoSize = true;
            this.DateOfPostTB.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfPostTB.Location = new System.Drawing.Point(106, 178);
            this.DateOfPostTB.Name = "DateOfPostTB";
            this.DateOfPostTB.Size = new System.Drawing.Size(543, 19);
            this.DateOfPostTB.TabIndex = 5;
            this.DateOfPostTB.Text = "Hit the \"CLICK ME!\" button to generate a post from your timeline!";
            // 
            // PostFromPastTB
            // 
            this.PostFromPastTB.AutoSize = true;
            this.PostFromPastTB.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostFromPastTB.Location = new System.Drawing.Point(235, 310);
            this.PostFromPastTB.Name = "PostFromPastTB";
            this.PostFromPastTB.Size = new System.Drawing.Size(329, 25);
            this.PostFromPastTB.TabIndex = 6;
            this.PostFromPastTB.Text = "The post will be posted here";
            // 
            // PastPostClickBtn
            // 
            this.PastPostClickBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.PastPostClickBtn.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PastPostClickBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PastPostClickBtn.Location = new System.Drawing.Point(110, 460);
            this.PastPostClickBtn.Name = "PastPostClickBtn";
            this.PastPostClickBtn.Size = new System.Drawing.Size(155, 41);
            this.PastPostClickBtn.TabIndex = 23;
            this.PastPostClickBtn.Text = "Click Me!";
            this.PastPostClickBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PastPostClickBtn.UseVisualStyleBackColor = false;
            this.PastPostClickBtn.Click += new System.EventHandler(this.PastPostClickBtn_Click);
            // 
            // ShareBtn
            // 
            this.ShareBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.ShareBtn.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShareBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ShareBtn.Location = new System.Drawing.Point(628, 460);
            this.ShareBtn.Name = "ShareBtn";
            this.ShareBtn.Size = new System.Drawing.Size(155, 41);
            this.ShareBtn.TabIndex = 24;
            this.ShareBtn.Text = "Share";
            this.ShareBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShareBtn.UseVisualStyleBackColor = false;
            this.ShareBtn.Click += new System.EventHandler(this.ShareBtn_Click);
            // 
            // PostFromThePastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 568);
            this.Controls.Add(this.ShareBtn);
            this.Controls.Add(this.PastPostClickBtn);
            this.Controls.Add(this.PostFromPastTB);
            this.Controls.Add(this.DateOfPostTB);
            this.Name = "PostFromThePastForm";
            this.Text = "PostFromThePastForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DateOfPostTB;
        private System.Windows.Forms.Label PostFromPastTB;
        private System.Windows.Forms.Button PastPostClickBtn;
        private System.Windows.Forms.Button ShareBtn;
    }
}