using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public sealed class SingeltonFacadosRef
    {
        private SingeltonFacadosRef() { }

        public static SingeltonFacadosRef Instance { get { return Singelton<SingeltonFacadosRef>.Instance; } }

        private Album PeakRndAlbum(Album[] i_UserAlbums)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, i_UserAlbums.Length);
            return i_UserAlbums[num];
        }

        public string[] PeakRndPic(User i_LoggedInUser)
        {
            Album rndAlbum = PeakRndAlbum(i_LoggedInUser.Albums.ToArray());
            Photo[] photos = rndAlbum.Photos.ToArray();
            Random rnd = new Random();
            int num = rnd.Next(0, photos.Length);

            while (!(rndAlbum.PictureAlbumURL != null && photos.Length != 0))
            {
                rndAlbum = PeakRndAlbum(i_LoggedInUser.Albums.ToArray());
            }

            string[] retVal = new string[2];
            retVal[0] = photos[num].PictureAlbumURL;
            retVal[1] = rndAlbum.CreatedTime.ToString();
            
            return retVal;
        }

        public Post PeakRndPost(User i_LoggedInUser)
        {
            List<Post> allPosts = new List<Post>();

            foreach (Post post in i_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    allPosts.Add(post);
                }
            }

            Random rnd = new Random();
            int num = rnd.Next(0, allPosts.Count);
            Post chosenPost = allPosts[num];

            return chosenPost;
        }
    }
}
