using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures
{
    class PostTextCore : ISelectedPost
    {
        public bool checkSelectedPost(Post i_post)
        {
            return true;
        }
    }
}
