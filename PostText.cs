using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class PostText : ISelectedPost
    {
        protected ISelectedPost m_postText;
        public PostText(ISelectedPost i_postText)
        {
            m_postText = i_postText;
        }

        public virtual bool checkSelectedPost(Post i_post)
        {
            return m_postText.checkSelectedPost(i_post);
        }
    }
}
