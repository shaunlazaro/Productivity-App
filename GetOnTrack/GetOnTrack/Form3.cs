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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 homePage = new Form1();
            homePage.Show();
            this.Hide();
        }
        public void OpenView()
        {
            button3.Visible = false;
            openViewButton.Visible = false;
            Form4 viewCards = new Form4();
            viewCards.Show();
            this.Hide();
        }

        private void openViewButton_Click(object sender, EventArgs e)
        {
            OpenView();
        }
    }
}
