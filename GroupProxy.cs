using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.DevTools.Page;
using FacebookWrapper.ObjectModel;
namespace BasicFacebookFeatures
{
    class GroupProxy : Group
    {
        public Group Group { get; set; }
        private int numOfIMembers = 0;

        public override string ToString()
        {
            return string.Format("{0} , Description: {1}", Group.Name, Group.Description);
        }
        public string IsTheTextLong()
        {
            if (Group.Description.Length > 50)
            {
                return "Yes";
            }

            return "No";
        }

        public int GetMembersWithI()
        {
            foreach (User member in Group.Members)
            {
                if (member.Name.StartsWith("I"))
                {
                    numOfIMembers++;
                }
            }

            return numOfIMembers;
        }

        public void WasGroupUpdated()
        {
            try
            {
                if (Group.UpdateTime.Value.Year.Equals(DateTime.Now.Year))
                {
                    MessageBox.Show("The Group was recently updated.");
                }
            }

            catch (Exception e)
            {
            }
        }
    }
}