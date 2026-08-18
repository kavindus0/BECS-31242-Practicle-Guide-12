namespace GradeManagmentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            String marks = txtMarks.Text;
            int mark2 = int.Parse(marks);
            if (mark2 >= 75)
            {
                txtGrade.Text = "A";
            } else if (mark2 >= 65)
            {
                txtGrade.Text = "B";
            }
            else if (mark2 >= 55)
            {
                txtGrade.Text = "C";
            }
            else if (mark2 >= 35)
            {
                txtGrade.Text = "S";
            }
            else
            {
                txtGrade.Text = "F";
            }
        }
    }
}
