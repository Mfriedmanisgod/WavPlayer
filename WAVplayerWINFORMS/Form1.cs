using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Collections;
using Microsoft.VisualBasic;
using System.IO;

namespace WAVplayerWINFORMS
{
    public partial class PlayList : Form
    {
        List<string> _items = new List<string>();

        SoundPlayer player = new SoundPlayer();

        public PlayList()
        {
            InitializeComponent();
        }
        
        private void playbutton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = playlistWindow.SelectedIndex;
                player.SoundLocation = _items[selectedIndex];
                player.Play();
                DisplaySongPlaying(label2);
            }
            catch
            {
                DisplayError(label1);
            }
        }
        
        private void stopbutton_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
        
        private void addbutton_Click(object sender, EventArgs e)
        {
            if (this.NewSongPlaylistEntry.Text != "")
            {
                AddItems(_items, NewSongPlaylistEntry.Text);

                ResetPlaylist(_items);

                this.NewSongPlaylistEntry.Focus();
            }
            else
            {
                DisplayError(label1);
                //MessageBox.Show("Please enter a file to add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.NewSongPlaylistEntry.Focus();
            }
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            int selectedIndex = playlistWindow.SelectedIndex;

            try
            {
                _items.RemoveAt(selectedIndex);
            }
            catch
            {
            }

            ResetPlaylist(_items);
        }

        private void NewSongPlaylistEntry_Click(object sender, EventArgs e)
        {
            NewSongPlaylistEntry.Text = string.Empty;
        }

        private void NewSongPlaylistEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (NewSongPlaylistEntry.Text == "")
                {
                    DisplayError(label1);
                }
                else
                {
                    AddItems(_items, NewSongPlaylistEntry.Text);
                    ResetPlaylist(_items);
                }
                //this.NewSongPlaylistEntry.Focus();
                //refactor without the focus method
            }
        }
        
        private void AddItems(List<string> list, string addItem)
        {
            list.Add(addItem);
        }      
            
        private void ResetPlaylist(List<string> list)
        {
            playlistWindow.DataSource = null;
            playlistWindow.DataSource = list;
            this.NewSongPlaylistEntry.Clear();
        }

        private void DisplaySongPlaying(Label songplayWindow)
        {
            int selectedIndex = playlistWindow.SelectedIndex;
            string filepath = _items[selectedIndex] as string;
            songplayWindow.Text = "Now Playing - " + filepath.ToString();
        }
        
        private void DisplayError(Label errorWindow)
        {
            int selectedIndex = playlistWindow.SelectedIndex;

            //if (selectedIndex = ".mp3" as string)
            errorWindow.Text = "ERROR - Please Enter a file to be added to the playlist".ToString();
            string extension = Path.GetExtension(filepath);
            

        }

        private void browserButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) 
            {
                string file = openFileDialog1.FileName;
                try
		        {
		            AddItems(_items, file);
                    ResetPlaylist(_items);
		        }
                catch (IOException)
		        {
                }
            }

	     
        }

        

        

        
            
    }
}
