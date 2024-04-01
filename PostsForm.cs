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

namespace BasicFacebookFeatures
{
    public partial class PostsForm : Form
    {
        private readonly User r_LoggedInUser;
        public PostsForm(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
            fetchPosts();
        }
        private void fetchPosts()
        {
            postsListBox.Items.Clear();

            foreach (Post post in r_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    postsListBox.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    postsListBox.Items.Add(post.Caption);
                }
                else
                {
                    postsListBox.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (postsListBox.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }
    }
}
