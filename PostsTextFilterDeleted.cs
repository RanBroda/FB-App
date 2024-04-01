using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class PostsTextFilterDeleted : PostText
    {
        public PostsTextFilterDeleted(ISelectedPost i_postText) : base(i_postText) { }
        public override bool checkSelectedPost(Post i_post)
        {
            return m_postText.checkSelectedPost(i_post);
        }
    }
}
