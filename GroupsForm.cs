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

namespace BasicFacebookFeatures
{
    public partial class GroupsForm : Form
    {
        private  User r_LoggedInUser;
        private GroupProxy m_Selected;
        private EnumarbleLongDescGroups Enome = new EnumarbleLongDescGroups();
        private IEnumerator<Group> it;
        public GroupsForm(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            fetchGroups();
        }
        private void fetchGroups()
        {
            it = Enome.GetEnumerator();
            groupsListBox.Items.Clear();
            groupsListBox.Visible = true;
            foreach (Group group in r_LoggedInUser.Groups)
            {
                if (group.Name != null && group.Description != null)
                {
                    groupsListBox.Items.Add(new GroupProxy { Group = group });
                    if (group.Description.Length > 50)
                    {
                        Enome.m_LongDescPosts.Add(new GroupProxy { Group = group });
                    }
                }
            }

            if (groupsListBox.Items.Count == 0)
            {
                MessageBox.Show("No groups have been found");
            }

            if (it.Current != null)
            {
                if (it.Current.Description.Contains("i"))
                {
                    listLongI.Items.Add(it.Current.Name);
                }
            }
        }

        private void groupsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_Selected = groupsListBox.SelectedItem as GroupProxy;

            if (groupsListBox.SelectedItems.Count == 1)
            {
                m_Selected.WasGroupUpdated();
                lableCount.Text = string.Format("Is the description of the group long?: {0} ", m_Selected.IsTheTextLong());
                lableMembers.Text = string.Format(
                    "The are members in the group that their names start with 'I'."/*, m_Selected.GetMembersWithI()*/);
            }
        }
    }
}
