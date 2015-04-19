namespace WAVplayerWINFORMS
{
    partial class PlayList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Play = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.playlistWindow = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.NewSongPlaylistEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
<<<<<<< HEAD
=======
            this.groupBox2.SuspendLayout();
>>>>>>> 11836b5728152075a2dbb21d0dacfcb244427154
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.Location = new System.Drawing.Point(15, 142);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(82, 32);
            this.Play.TabIndex = 0;
            this.Play.Text = "PLAY";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(125, 142);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(82, 32);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "STOP";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // playlistWindow
            // 
            this.playlistWindow.FormattingEnabled = true;
            this.playlistWindow.Location = new System.Drawing.Point(362, 50);
            this.playlistWindow.Name = "playlistWindow";
            this.playlistWindow.Size = new System.Drawing.Size(244, 199);
            this.playlistWindow.TabIndex = 6;
<<<<<<< HEAD
            
=======
>>>>>>> 11836b5728152075a2dbb21d0dacfcb244427154
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(12, 38);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(60, 20);
            this.Add.TabIndex = 7;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.Location = new System.Drawing.Point(236, 141);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(82, 33);
            this.Remove.TabIndex = 8;
            this.Remove.Text = "REMOVE";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.removebutton_Click);
            // 
            // NewSongPlaylistEntry
            // 
            this.NewSongPlaylistEntry.ForeColor = System.Drawing.SystemColors.GrayText;
            this.NewSongPlaylistEntry.Location = new System.Drawing.Point(12, 12);
            this.NewSongPlaylistEntry.Name = "NewSongPlaylistEntry";
            this.NewSongPlaylistEntry.Size = new System.Drawing.Size(374, 20);
            this.NewSongPlaylistEntry.TabIndex = 9;
            this.NewSongPlaylistEntry.Click += new System.EventHandler(this.NewSongPlaylistEntry_Click);
            this.NewSongPlaylistEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewSongPlaylistEntry_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(21, 190);
=======
            this.label1.Location = new System.Drawing.Point(6, 0);
>>>>>>> 11836b5728152075a2dbb21d0dacfcb244427154
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Error list";
<<<<<<< HEAD
            
=======
>>>>>>> 11836b5728152075a2dbb21d0dacfcb244427154
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.browserButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "FilePlaying";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 64);
            this.groupBox1.Name = "groupBox1";
<<<<<<< HEAD
            this.groupBox1.Size = new System.Drawing.Size(329, 61);
=======
            this.groupBox1.Size = new System.Drawing.Size(329, 27);
>>>>>>> 11836b5728152075a2dbb21d0dacfcb244427154
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
<<<<<<< HEAD
            this.groupBox2.Location = new System.Drawing.Point(15, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 59);
=======
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 28);
>>>>>>> 11836b5728152075a2dbb21d0dacfcb244427154
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // PlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 261);
<<<<<<< HEAD
            this.Controls.Add(this.label1);
=======
>>>>>>> 11836b5728152075a2dbb21d0dacfcb244427154
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewSongPlaylistEntry);
            this.Controls.Add(this.playlistWindow);
            this.Name = "PlayList";
            this.Text = "Willard\'s WAV Wizzard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
<<<<<<< HEAD
=======
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
>>>>>>> 11836b5728152075a2dbb21d0dacfcb244427154
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.ListBox playlistWindow;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.TextBox NewSongPlaylistEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

