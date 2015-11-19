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
        // Opens Focus
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 timeOrganizer = new Form2();
            timeOrganizer.Show();
            this.Hide();
        }

        // Opens Study
        private void button3_Click(object sender, EventArgs e)
        {
            Form3 flashCards = new Form3();
            flashCards.Show();
            this.Hide();
        }
        // Opens Handy
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 calculator = new Form4();
            calculator.Show();
            this.Hide();
        }

    }
}
