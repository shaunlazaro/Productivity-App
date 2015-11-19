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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        // To Do For Back Button
        // To Do: Create instructions.
        // To Do: Insert instructions into showLabels method.
        // To Do: Insert instructions into hideLabels method.
        #region Back Button
        // Show Instructions Button
        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text=="Show Instructions")
            {
                button2.Text = "Hide Instructions";
                showInstructions();
            }
            else
            {
                button2.Text = "Show Instructions";
                hideInstructions();
            }
        }

        // Shows the label objects that have the instructions in them.
        public void showInstructions()
        {

        }

        // Hides the labels with the instructions in them.
        public void hideInstructions()
        {

        }

        #endregion

        #region Home Button
        // Back Button.
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }
        #endregion
    }
}
