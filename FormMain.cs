using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        FacebookWrapper.LoginResult m_LoginResult;
        private HomePage m_HomePage;
        private User m_LoggedInUser;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Ran's and Lior's app");

            if (m_LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(
                "825466099184874",
                "email",
                "public_profile",
                "user_birthday",
                "user_events",
                "user_likes",
                "user_location",
                "user_posts",
                "user_link",
                "user_photos",
                "user_friends",
                "groups_access_member_info"
                );

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                m_HomePage = new HomePage(m_LoggedInUser);
                m_HomePage.Show();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }
    }
}
