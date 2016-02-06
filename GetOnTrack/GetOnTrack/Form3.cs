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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Form1 main = new Form1();

        private void instructionButton_Click(object sender, EventArgs e)
        {
            // Not actually instruction button, I am just a lazy person. XD
            main.Show();
            this.Dispose();
            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
            this.Dispose();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chooseSave(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chooseSave(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chooseSave(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chooseSave(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chooseSave(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chooseSave(6);
        }

        public void chooseSave(int saveNum)
        {
            Form5 lister = new Form5(saveNum);
            lister.Show();
            this.Dispose();
            this.Close();
        }
    }
}
