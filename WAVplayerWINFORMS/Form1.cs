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
                DisplaySongPlaying(_items[selectedIndex]);
            }
            catch
            {
                DisplayError("The file you entered is not a WAV. Please select a new file.");
            }
        }
        
        private void stopbutton_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
        
        private void addbutton_Click(object sender, EventArgs e)
        {
            EvaluateSongEntry();
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
                EvaluateSongEntry();
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
        }

        private void DisplaySongPlaying(string filepath)
        {
            /*
            while(label2.Width < groupBox1.Width)
            {
                label2.Font = new Font(label2.Font.FontFamily, label2.Font.Size - 2.5f, label2.Font.Style);
                label2.Text = "Now Playing - " + filepath.ToString();
            }
            */
            if (label2.Width > groupBox1.Width)
            {
                //weird results here. Everytime you play a new song the font size shrinks by 0.5 "points" maybe?
                //i need to return to the original font size for each new song played to be evaluated by my if statement
                //
                label2.Text = "Now Playing - " + filepath.ToString();
                label2.Font = new Font(label2.Font.FontFamily, label2.Font.Size - 0.5f, label2.Font.Style);
                label2.Text = "Now Playing - " + filepath.ToString();
            }
            else
            {
                label2.Text = "Now Playing - " + filepath.ToString();
            }
            //label2.Text = "Now Playing - " + filepath.ToString();
            //Control(string text, int left, int top, int width, int height);
            
        }
        
        private void DisplayError(string errorMessage)
        {
            label1.Text = errorMessage;
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

        private void EvaluateSongEntry()
        {
            if (NewSongPlaylistEntry.Text == "")
            {
                DisplayError("You must enter a file to be added to the playlist window.");
            }
            else
            {
                AddItems(_items, NewSongPlaylistEntry.Text);
                ResetPlaylist(_items);
                NewSongPlaylistEntry.Clear();
            }
        }

        


            
    }
}
