using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class EnumarbleLongDescGroups : IEnumerable<Group>
    {
        public List<Group> m_LongDescPosts = new List<Group>();
        
        public IEnumerator<Group> GetEnumerator()
        {
            foreach(Group group in m_LongDescPosts)
            {
                yield return group;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public object Current
        {
            get { return m_LongDescPosts[0].Description; }
        }
    }
}
