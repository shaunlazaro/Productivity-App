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

namespace GetOnTrack
{
    public partial class Form4 : Form
    {
        bool killEars;
        // If true, then a loud sound will play when time is up.
        
        string alarmDisplay;
        // Tracks what task the user is doing.
        
        const string soundFilePath = "alarm-sound.wav";
        SoundPlayer sound = new System.Media.SoundPlayer(@soundFilePath);
        // Used to track where the sound file is, and play the sound.
        
        public Form4(bool playSound, string task)
        {
            InitializeComponent();
            killEars = playSound;
            alarmDisplay = task;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = alarmDisplay + " Is Over!";
            if(killEars)
            {
                sound.Play();
            }
        }

        private void Form4_Leave(object sender, EventArgs e)
        {
            sound.Stop();
            sound.Dispose();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            sound.Stop();
            sound.Dispose();
            this.Dispose();
            this.Close();
        }
    }
}
