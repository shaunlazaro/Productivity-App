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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int totalTime; int totalTime2;
        // Used to track the input in the first textbox as an int, rather than a string with x:xx format.

        int timeTracker = 0;

        string totalTimeInMinutes;
        // Used to track the input in the first textbox as a string, rather than an int with x... format.
        
        string currentAlarmName;
        // Used to track the input in the second textbox.

        const string soundFilePath = "alarm-sound.wav";
        // Used to track where the sound file is.

        private void Form2_Load(object sender, EventArgs e)
        {
            // Declare variables used.
            totalTime = 3600; //Tracks how long task will be done.
        }

        // Covers the use of first textbox and first button.
        #region SetTotalTime

        //Does "CheckInputIsInTime" then enables setLength button if true is returned.
        private void lengthInput_TextChanged(object sender, EventArgs e)
        {
            //Checks to see if the time is in the correct format.
            if (CheckInputIsInTime(lengthInput.Text, out totalTime))
            {
                setLength.Enabled = true;
                lengthInput.ForeColor = Color.Lime;
                label2.Text = String.Format("You Will {0} For {1} More Seconds", alarmName.Text, totalTime); 
            }
            else
            {
                setLength.Enabled = false;
                lengthInput.ForeColor = Color.Red;
            }
        }

        //Puts the bottom progress bar's total time.
        private void setLength_Click(object sender, EventArgs e)
        {
            totalTime2 = totalTime;
            label2.Text = String.Format("You Will {0} For {1} More Seconds", alarmName.Text, totalTime); 
            progressBar2.Maximum = totalTime;
            progressBar2.Step = 1;
            totalTimeInMinutes = lengthInput.Text;
            lengthInput.Text = "Time set!";
            setLength.Enabled = false;
            lengthInput.Enabled = false;
            alarmName.Enabled= true;
            addAlarm.Enabled = true;
            alarmName.ForeColor = Color.Lime;
            alarmName.Focus();
            label2.ForeColor = Color.Red;
        }

        #endregion
        // Checks lengthInput for correct format (m:s), then enables the setLength button if it is.
        // setLength button gives the "totalTime" object the value of lengthInput.Text, then activates
        // the SetAlarm textBoxes (addAlarm region).

        #region CheckInputIsInTime
        //Returns true if in correct format (m:s)
        public bool CheckInputIsInTime(string lol, out int seconds)
        {
            bool validInput = false;
            bool colonExists = false;
            string lolTrim = lol.Trim();
            int minutes;
            seconds = 0;
            foreach (char c in lolTrim)
            {
                if (c == ':')
                {
                    colonExists = true;
                    break;
                }
            }
            if (colonExists)
            {
                //Add string length error checking - done
                //Add tryparse method - done
                string[] seperatedInput = lol.Split(new char[] { ':' });
                if (int.TryParse(seperatedInput[0], out minutes))
                {
                    if (int.TryParse(seperatedInput[1], out seconds))
                    {
                        seconds = seconds + minutes * 60;
                        validInput = true;
                    }
                }
            }

            return validInput;
        }
        #endregion
        // CheckInputIsInTime (string, out int) returns true or false.

        #region ConvertToMinutes
        public string ConvertToMinutes(int timeInput)
        {
            string output = "0:0";
            int minutes = 0;
            int seconds = 0;
            for (int x = timeInput; x > 60; x -= 60 )
            {
                minutes++;
                timeInput = x;
            }
            seconds = timeInput;
            output = minutes +  ": " + seconds;
            return output;
        }
        #endregion
        // ConvertToMinutes(int) returns string with minutes format (assuming input is in seconds)(x:x).
        // Doesnt Work!!
        // Covers the use of second textbox, and second button.
        #region addAlarm
        private void alarmName_TextChanged(object sender, EventArgs e)
        {
            if (alarmName.Text.Length != 0)
            {
                alarmName.ForeColor = Color.Lime;
                addAlarm.Enabled = true;
                label2.Text = String.Format("You Will {0} For {1} More Seconds", alarmName.Text, totalTime2); 
            }
            else
            {
                addAlarm.Enabled = false;
                label2.ForeColor = Color.Red;
            }

        }
        private void addAlarm_Click(object sender, EventArgs e)
        {
            currentAlarmName = alarmName.Text;
            setTimer.Enabled = true;
            label2.Text = String.Format("You Will {0} For {1} More Seconds", alarmName.Text, totalTime2);
            alarmName.Enabled = false;
            addAlarm.Enabled = false;
            label2.ForeColor = Color.Lime;
        }
        #endregion
        //Checks alarmInputMax textbox if it has text in it;

        //Covers the countdown and stuff.
        #region Timers
        public void StartProgram(string Name, int totalTime)
        {
            Timer.Enabled = true;
            timeTracker = totalTime2;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {   
            progressBar2.PerformStep();
            timeTracker--;
            label2.Text = String.Format("You Will {0} For {1} More Seconds", alarmName.Text, timeTracker);
            if (timeTracker == 0)
            {
                Timer.Enabled = false;
                TimerDone();
            }
        }
        public void TimerDone()
        {
            PlayCompletionSound();
            alarmName.Enabled = true;
            alarmName.ForeColor = Color.Red;
            lengthInput.Enabled = true;
            lengthInput.ForeColor = Color.Lime;
            lengthInput.Text = "60:00";
            alarmName.Text = "Do Homework";
            totalTime = 3600;
            addAlarm.Enabled = false;
        }
        public void PlayCompletionSound()
        {
            //To-Do!!!!
            SoundPlayer sound = new System.Media.SoundPlayer(@soundFilePath);
            sound.Play();
        }
        #endregion
        //Contains startProgram, which disables all buttons and labels until the progress bar is full.
        
        //Covers the use of third button.
        #region SetTimerButton
        private void setTimer_Click(object sender, EventArgs e)
        {
            StartProgram(currentAlarmName, totalTime2);
            progressBar2.Maximum = totalTime2;
            progressBar2.Step = 1;
            Timer.Interval = 1000;
        }
        #endregion
        //Activates StartProgram

        //Covers what happens when Form1
        #region FormClose
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Close();
            this.Close();
        }
        #endregion
        //Holds the Form2_FormClosing method (closes Form1 when Form2 is closed)

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 homePage = new Form1();
            homePage.Show();
            this.Hide();
        }

        private void instructionButton_Click(object sender, EventArgs e)
        {
            if (label3.Visible)
            {
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                instructionButton.Text = "Show Instructions";
            }
            else if (!label3.Visible)
            {
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                instructionButton.Text = "Hide Instructions";
            }
        }

    }
}
