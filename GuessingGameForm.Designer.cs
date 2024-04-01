
namespace BasicFacebookFeatures
{
    partial class GuessingGameForm
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
            this.PictureGuessBox = new System.Windows.Forms.PictureBox();
            this.GuessBox = new System.Windows.Forms.TextBox();
            this.guessValueTB = new System.Windows.Forms.RichTextBox();
            this.ScoreTB = new System.Windows.Forms.Label();
            this.GuessBtn = new System.Windows.Forms.Button();
            this.EndGameBtn = new System.Windows.Forms.Button();
            this.guessingGameLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureGuessBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureGuessBox
            // 
            this.PictureGuessBox.Location = new System.Drawing.Point(263, 121);
            this.PictureGuessBox.Name = "PictureGuessBox";
            this.PictureGuessBox.Size = new System.Drawing.Size(274, 208);
            this.PictureGuessBox.TabIndex = 4;
            this.PictureGuessBox.TabStop = false;
            // 
            // GuessBox
            // 
            this.GuessBox.Location = new System.Drawing.Point(589, 182);
            this.GuessBox.Name = "GuessBox";
            this.GuessBox.Size = new System.Drawing.Size(155, 22);
            this.GuessBox.TabIndex = 14;
            this.GuessBox.TextChanged += new System.EventHandler(this.GuessBox_TextChanged);
            // 
            // guessValueTB
            // 
            this.guessValueTB.BackColor = System.Drawing.SystemColors.Control;
            this.guessValueTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guessValueTB.Location = new System.Drawing.Point(217, 365);
            this.guessValueTB.Name = "guessValueTB";
            this.guessValueTB.Size = new System.Drawing.Size(349, 41);
            this.guessValueTB.TabIndex = 20;
            this.guessValueTB.Text = "";
            // 
            // ScoreTB
            // 
            this.ScoreTB.AutoSize = true;
            this.ScoreTB.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTB.Location = new System.Drawing.Point(43, 201);
            this.ScoreTB.Name = "ScoreTB";
            this.ScoreTB.Size = new System.Drawing.Size(127, 32);
            this.ScoreTB.TabIndex = 21;
            this.ScoreTB.Text = "Score: 0";
            // 
            // GuessBtn
            // 
            this.GuessBtn.BackColor = System.Drawing.Color.LightPink;
            this.GuessBtn.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.GuessBtn.Location = new System.Drawing.Point(589, 234);
            this.GuessBtn.Name = "GuessBtn";
            this.GuessBtn.Size = new System.Drawing.Size(155, 41);
            this.GuessBtn.TabIndex = 22;
            this.GuessBtn.Text = "Guess!";
            this.GuessBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuessBtn.UseVisualStyleBackColor = false;
            this.GuessBtn.Click += new System.EventHandler(this.GuessBtn_Click);
            // 
            // EndGameBtn
            // 
            this.EndGameBtn.BackColor = System.Drawing.Color.LightPink;
            this.EndGameBtn.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndGameBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.EndGameBtn.Location = new System.Drawing.Point(589, 374);
            this.EndGameBtn.Name = "EndGameBtn";
            this.EndGameBtn.Size = new System.Drawing.Size(179, 55);
            this.EndGameBtn.TabIndex = 23;
            this.EndGameBtn.Text = "End Game";
            this.EndGameBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EndGameBtn.UseVisualStyleBackColor = false;
            this.EndGameBtn.Click += new System.EventHandler(this.EndGameBtn_Click);
            // 
            // guessingGameLable
            // 
            this.guessingGameLable.AutoSize = true;
            this.guessingGameLable.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessingGameLable.Location = new System.Drawing.Point(290, 35);
            this.guessingGameLable.Name = "guessingGameLable";
            this.guessingGameLable.Size = new System.Drawing.Size(229, 32);
            this.guessingGameLable.TabIndex = 24;
            this.guessingGameLable.Text = "Guessing Game";
            // 
            // GuessingGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guessingGameLable);
            this.Controls.Add(this.EndGameBtn);
            this.Controls.Add(this.GuessBtn);
            this.Controls.Add(this.ScoreTB);
            this.Controls.Add(this.guessValueTB);
            this.Controls.Add(this.GuessBox);
            this.Controls.Add(this.PictureGuessBox);
            this.Name = "GuessingGameForm";
            this.Text = "GuessingGameForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureGuessBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureGuessBox;
        private System.Windows.Forms.TextBox GuessBox;
        private System.Windows.Forms.RichTextBox guessValueTB;
        private System.Windows.Forms.Label ScoreTB;
        private System.Windows.Forms.Button GuessBtn;
        private System.Windows.Forms.Button EndGameBtn;
        private System.Windows.Forms.Label guessingGameLable;
    }
}