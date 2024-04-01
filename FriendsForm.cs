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
    public partial class FriendsForm : Form
    {
        private readonly List<User> r_FriendList;
        private User m_SelectedFriend = null;
        private User m_LoggedInUser;
        public FriendsForm(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            fetchFriends();
        }
        private void fetchFriends()
        {
            friendsListBox.Items.Clear();
            //We couldn't fetch friends list, therefore we wrote an example of code if fetching was possible
            //r_FriendList = new List<User>(friends);
            //if(r_FriendList.Count > 0)
            //{
            //    friendsListBox.DisplayMember = "Name";
            //    friendsListBox.DataSource = r_FriendList;
            // }

            //else
            //{
            //    MessageBox.Show("No friends in your friend list");
            //}
        }


        private void updatePhotoOfSelectedFriend()
        {
            try
            {
                if (!string.IsNullOrEmpty(m_SelectedFriend.PictureLargeURL))
                {
                    friendPictureBox.LoadAsync(m_SelectedFriend.PictureLargeURL);
                    friendPictureBox.Visible = true;
                }
                else
                {
                    friendPictureBox.Visible = false;
                }
            }
            catch (Exception i_Exception)
            {
                friendPictureBox.Visible = false;
            }
        }

        private void updateSelectedFriendInformation()
        {
            try
            {
                labelSelectedFriendName.Text = string.Format("{0} {1}", m_SelectedFriend.FirstName, m_SelectedFriend.LastName);
                labelFriendBirthday.Text = string.Format("Birthday: {0}", m_SelectedFriend.Birthday);
                labelFriendEmail.Text = string.Format("Email: {0}", m_SelectedFriend.Email);
                labelFriendGender.Text = string.Format("Gender: {0}", m_SelectedFriend.Gender.ToString());
            }
            catch (Exception exception)
            {
            }
        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (friendsListBox.SelectedItems.Count == 1)
                 {
                   m_SelectedFriend = friendsListBox.SelectedItem as User;
                   updatePhotoOfSelectedFriend();
                   updateSelectedFriendInformation();
                 }
        }
    }
}
