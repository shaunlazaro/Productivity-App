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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Open Focus
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 timeOrganizer = new Form2();
            timeOrganizer.Show();
            this.Hide();
        }

        //Open Study
        private void button3_Click(object sender, EventArgs e)
        {
            Form3 flashCards = new Form3();
            flashCards.Show();
            this.Hide;
        }

    }
}
