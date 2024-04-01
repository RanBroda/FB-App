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
    public partial class PostFromThePastForm : Form
    {
        private readonly User r_LoggedInUser;
        public PostFromThePastForm(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        private void PastPostClickBtn_Click(object sender, EventArgs e)
        {
            Post chosenPost = SingeltonFacadosRef.Instance.PeakRndPost(r_LoggedInUser);
            DateOfPostTB.Text = string.Format("On {0} you posted:", chosenPost.UpdateTime.ToString());
            PostFromPastTB.Text = chosenPost.Message;
        }

        private void ShareBtn_Click(object sender, EventArgs e)
        {
            string newPost = string.Format("{0}I found an old memory from {1}:{0}{2}", Environment.NewLine, DateOfPostTB.Text, PostFromPastTB.Text);
            MessageBox.Show(string.Format("Your memory post was uploaded to your profile:{0}", newPost));
        }
    }

}
