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
    public partial class PhotosForm : Form
    {
        private readonly User r_LoggedInUser;
        private Photo[] m_Photos;
        private int m_IteratorPhotos;
        public PhotosForm(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            fetchAlbums();
        }
        private async void fetchAlbums()
        {
            albumsListsBox.Items.Clear();


            await Task.Run(() => {

                foreach (Album album in r_LoggedInUser.Albums)
                {
                    albumsListsBox.Items.Add(album);
                }

                if (albumsListsBox.Items.Count == 0)
                {
                    MessageBox.Show("No albums have been found");
                }
           });            
        }

        private void albumsListsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_IteratorPhotos = 0;
            showAlbumInPictureBox();
        }
        private void showAlbumInPictureBox()
        {
            if (albumsListsBox.SelectedItems.Count == 1)
            {
                Album selectedAlbum = albumsListsBox.SelectedItem as Album;
                m_Photos = selectedAlbum.Photos.ToArray();
                if (selectedAlbum.PictureAlbumURL != null && m_Photos.Length != 0)
                {
                    loadPhoto();
                }
                else
                {
                    MessageBox.Show("No photos in this album.");
                }
            }
        }
        private void nextPicRight_Click(object sender, EventArgs e)
        {
            m_IteratorPhotos = (m_IteratorPhotos + 1) % m_Photos.Length;
            loadPhoto();
        }
        private void loadPhoto()
        {
            albumPicturesBox.LoadAsync(m_Photos[m_IteratorPhotos].PictureAlbumURL);
        }

        private void nextPicLeft_Click(object sender, EventArgs e)
        {
            m_IteratorPhotos = (m_IteratorPhotos - 1 + m_Photos.Length) % m_Photos.Length;
            loadPhoto();
        }
    }
}
