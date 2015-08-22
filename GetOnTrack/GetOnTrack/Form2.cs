using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetOnTrack
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int totalTime;
        // Used to track the input in the first textbox as an int, rather than a string with x:xx format.

        string totalTimeInMinutes;
        // Used to track the input in the first textbox as a string, rather than an int with x... format.
        
        string currentAlarmName;
        // Used to track the input in the second textbox.

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
                lengthInput.ForeColor = Color.Red;
            }
        }

        //Puts the bottom progress bar's total time.
        private void setLength_Click(object sender, EventArgs e)
        {
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
            addAlarm.Focus();
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
        private void alarmInputMax_TextChanged(object sender, EventArgs e)
        {
            if (alarmName.Text.Length != 0)
            {
                alarmName.ForeColor = Color.Lime;
                addAlarm.Enabled = true;
            }
            else
            {
                addAlarm.Enabled = false;
            }
        }
        private void addAlarm_Click(object sender, EventArgs e)
        {
            currentAlarmName = alarmName.Text;
        }
        #endregion
        //

        //Covers the use of third button.
        #region StartProgram
        private void setTimer_Click(object sender, EventArgs e)
        {

        }
        #endregion
        //Activates the timers that run the actual progress bar

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


    }
}
