using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GradeManagmentSystem
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            using (StreamReader reader = new StreamReader(@"C:\Users\pathm\source\repos\GradeManagmentSystem\GradeManagmentSystem\LogNotes\log2.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    richTextBox1.AppendText(line + Environment.NewLine);
                }
            }

        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\pathm\source\repos\GradeManagmentSystem\GradeManagmentSystem\LogNotes\log2.txt",true);

             writer.WriteLine(richTextBox1.Text);

            writer.Close();
            MessageBox.Show("All info written");
            
        }
    }
}
