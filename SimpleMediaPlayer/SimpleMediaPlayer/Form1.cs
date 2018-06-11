/*/
 * Author: Lochlan Kennedy (AKA Pharahtato)
 * Date: 31/05/2018
 * Copyright © Lochlan Kennedy 2018
 /*/ 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using WMPLib;
using System.Diagnostics;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        List<string> videoDirectories = new List<string>();
        int currentVideo = 0;
        //int listCount;
        int listPosition;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.settings.volume = VolumeSlider.Value;
            
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            //Do NOT Delete this code block VS will have a fit!
        }

        private void AddVideoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD1 = new OpenFileDialog();
            oFD1.Multiselect = true;
            oFD1.Filter = "Video Files|*.mp4;*.mkv;*.avi;*.wmv;*.flv;*.m2t";

            if (oFD1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach(String file in oFD1.FileNames)
                {
                    videoDirectories.Add(file);
                    VideoList.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file));
                }              

            }


        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {

            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPaused)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                if (videoDirectories.Count > 0)
                {
                    axWindowsMediaPlayer1.URL = videoDirectories[currentVideo];
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                else
                {
                    MessageBox.Show("Please Add A Video To The List.");
                }

            }
            
        }

        private void axWindowsMediaPlayer1_EndOfStream(object sender, AxWMPLib._WMPOCXEvents_EndOfStreamEvent e)
        {
            currentVideo++;
            if (currentVideo < videoDirectories.Count)
            {
               axWindowsMediaPlayer1.URL = videoDirectories[currentVideo];
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void VolumeSlider_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = VolumeSlider.Value;
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void MakeItTVChannel()
        {
            //TODO: Add randomization to the list of videos and or audio files. insert a random included advertisement video
            //This will create the effect of watching TV.
            //Future Applications for this could be for an ASP.Net website, to host an in home streaming service or various other ways of creating a feel of watching tv from
            //your collection of ripped dvds and legally downloaded video files.

        }

        private void PreviousChapterBtn_Click(object sender, EventArgs e)
        {
            if(videoDirectories.Count > 0)
            {
                if(currentVideo > 0)
                {
                    currentVideo--;
                    axWindowsMediaPlayer1.URL = videoDirectories[currentVideo];
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
        }

        private void NextChapterBtn_Click(object sender, EventArgs e)
        {
            if (videoDirectories.Count > 0)
            {
                if (currentVideo >= 0)
                {
                    listPosition = currentVideo;
                    currentVideo++;
                    if(currentVideo < videoDirectories.Count)
                    {
                        axWindowsMediaPlayer1.URL = videoDirectories[currentVideo];
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                    else
                    {
                        currentVideo = listPosition;
                        MessageBox.Show("No More Videos In The List");
                    }
                    
                }
            }
        }

        private void RemoveVideoBtn_Click(object sender, EventArgs e)
        {
            videoDirectories.RemoveAt(VideoList.SelectedIndex);
            VideoList.Items.RemoveAt(VideoList.SelectedIndex);
        }
    }
}
