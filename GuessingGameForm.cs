using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Threading;
using BasicFacebookFeatures.Strategy;

namespace BasicFacebookFeatures
{
    public partial class GuessingGameForm : Form
    {
        private readonly User r_LoggedInUser;
        private string m_ans;
        private int m_Score;
        public IGuessingGameStrategy Ans_Format { get; set; }

        public GuessingGameForm(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            m_Score = 0;
            InitializeComponent();
            fetchPictureBox();
        }

        private async void fetchPictureBox()
        {
            string[] picData = null;

            await Task.Run(() =>
            {
                picData = SingeltonFacadosRef.Instance.PeakRndPic(r_LoggedInUser);
            });

            if (picData != null)
            {
                this.m_ans = Ans_Format.AnswerFormat(picData[1]);
                PictureGuessBox.LoadAsync(picData[0]);
                MessageBox.Show(m_ans);
            }
        }


        private void GuessBtn_Click(object sender, EventArgs e)
        {
        
            if (m_ans.Equals(this.GuessBox.Text))
            {
                m_Score++;
                this.guessValueTB.BackColor = System.Drawing.Color.Green;
                this.guessValueTB.Text = "Correct!";
                this.ScoreTB.Text = string.Format("Score: {0}", m_Score);
                fetchPictureBox();
            }
            else
            {
               this.guessValueTB.BackColor = System.Drawing.Color.Red;
               this.guessValueTB.Text = "Wrong! Try again.";
            }
        }

        private void EndGameBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("You scored: {0} points. Bye Bye", m_Score)); 
            this.Close();
        }

        private void GuessBox_TextChanged(object sender, EventArgs e)
        {
            this.guessValueTB.BackColor = System.Drawing.SystemColors.Control;
            this.guessValueTB.Text = "";
        }
    }
}
