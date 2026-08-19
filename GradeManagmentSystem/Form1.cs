using MySql.Data.MySqlClient;
using System.Data;

namespace GradeManagmentSystem
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string getGrade(int mark2)
        {
            if (mark2 >= 75)
            {
                return "A";
            }
            else if (mark2 >= 65)
            {
                return "B";
            }
            else if (mark2 >= 55)
            {
                return "C";
            }
            else if (mark2 >= 35)
            {
                return "S";
            }
            else
            {
                return "F";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 notes = new Form4();
            notes.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string conn = "server=localhost;database=grademanagmentsystem;uid=root;pwd=;";

            string query = "INSERT into grade VALUES(@stdID,@CourseID,@Status,@Marks,@Grade)";

            MySqlCommand cmd = new MySqlCommand(query, new MySqlConnection(conn));

            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@stdID", txtStdID.Text);
            cmd.Parameters.AddWithValue("@CourseID", listBox1.Text);
            cmd.Parameters.AddWithValue("@Status", rbCompulsory.Checked ? "Compulsary" : rbOptional.Checked ? "Optional" : String.Empty);
            cmd.Parameters.AddWithValue("@Marks", txtMarks.Text);
            cmd.Parameters.AddWithValue("@Grade", txtGrade.Text = getGrade(int.Parse(txtMarks.Text)));

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            MessageBox.Show("Grade Inserted Successfully");

            txtGrade.Clear();
            txtMarks.Clear();
            txtStdID.Clear();
            listBox1.SelectedIndex = -1;
            rbCompulsory.Checked = false;
            rbOptional.Checked = false;


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gradeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 gradeBookForm = new Form2();
            gradeBookForm.Show();
        }

        private void gradeSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 summaryform = new Form3();
            summaryform.Show();
        }
    }
}
