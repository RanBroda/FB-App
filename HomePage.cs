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
using BasicFacebookFeatures.Strategy;

namespace BasicFacebookFeatures
{
    public partial class HomePage : Form
    {

        private readonly User r_LoggedInUser;

        public HomePage(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            InitializeProfile();
        }

        public void InitializeProfile()
        {
            this.UserNameTB.Text = r_LoggedInUser.Name;
            this.pictureBox1.Image = r_LoggedInUser.ImageNormal;
        }

        private void PostsBtn_Click(object sender, EventArgs e)
        {
            PostsForm postsForm = new PostsForm(r_LoggedInUser);
            postsForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                GroupsForm groupsForm = new GroupsForm(r_LoggedInUser);
                groupsForm.ShowDialog();
        }

        private void PhotosBtn_Click(object sender, EventArgs e)
        {
            PhotosForm photosForm = new PhotosForm(r_LoggedInUser);
            photosForm.ShowDialog();
        }

        private void FriendsBtn_Click(object sender, EventArgs e)
        {
            FriendsForm friendsForm = new FriendsForm(r_LoggedInUser);
            friendsForm.ShowDialog();
        }

        private void GuessYearBtn_Click(object sender, EventArgs e)
        {
            GuessingGameForm guessForm = new GuessingGameForm(r_LoggedInUser) { Ans_Format = new GuessByYear() };
            guessForm.ShowDialog();
        }

        private void PastPostBtn_Click(object sender, EventArgs e)
        {
            PostFromThePastForm PastPostBtnForm = new PostFromThePastForm(r_LoggedInUser);
            PastPostBtnForm.ShowDialog();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if (postTextBox.Text != String.Empty)
            {
                /* Adding the post to the user timeline
                Post post = new Post();
                post.Message = postTextBox.Text;
                timeline.add(post);
                */
                MessageBox.Show(string.Format("A new post was added to your timeline!\n{0}", postTextBox.Text));
                postTextBox.Clear();
            }
            else
            {
                MessageBox.Show("No text was found. please try again!");
            }
        }
    }
}
