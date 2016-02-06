using System;
using System.Collections;
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
    public partial class Form5 : Form
    {
        public Form5(int saveNum)
        {
            InitializeComponent();
            saveNumber = saveNum;
        }

        int saveNumber;
        string savePath;
        public string[] toDoList = new string[14];
        IComparer revComparer = new ReverseComparer(); 


        private void button1_Click(object sender, EventArgs e)
        {
            int arrayElement; 
            if(int.TryParse(NumberOnList.Text, out arrayElement))
            {
                if(arrayElement > 0 && arrayElement < 15)
                {
                    toDoList[arrayElement - 1] = NewTaskBox.Text;
                    RefreshToDo(toDoList);
                }
                else
                {                
                   MessageBox.Show("Enter a number between 1 and 14");
                }
            }
            else
            {
                MessageBox.Show("Enter a number between 1 and 14");
            }
        }

        public void RefreshToDo(string[] list)
        {
            label2.Text = "";
            int arrayElement = 1;
            string listNumber = arrayElement.ToString();
            foreach(string s in list)
            {
                label2.Text += listNumber;
                label2.Text += ":  ";
                label2.Text += s;
                label2.Text += "\n";
                arrayElement++;
                listNumber = arrayElement.ToString();
            }
        }


        // Handles the form closing.
        private void backbutton_Click(object sender, EventArgs e)
        {
            Form3 saveChoosing = new Form3();
            saveChoosing.Show();
            this.Dispose();
            this.Close();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form3 saveChoosing = new Form3();
            saveChoosing.Show();
            this.Dispose();
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //Loads all elements in text file into array.
            if(saveNumber == 1) savePath = ""
            if(saveNumber == 2)
            if(saveNumber == 3)
            if(saveNumber == 4)
            if(saveNumber == 5)
            if(saveNumber == 6)
            RefreshToDo(toDoList);
        }

    }
    public class ReverseComparer : IComparer
    {
        // Call CaseInsensitiveComparer.Compare with the parameters reversed.
        public int Compare(Object x, Object y)
        {
            return (new CaseInsensitiveComparer()).Compare(y, x);
        }
    }

}
