using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GradeManagmentSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using MySqlConnection conn = new MySqlConnection("server=localhost;database=grademanagmentsystem;uid=root;pwd=;");

            String query = "SELECT * FROM grade";

            MySqlDataAdapter adpt = new MySqlDataAdapter(query, conn);

            DataTable dt = new DataTable();

            adpt.Fill(dt);

            dataGridView1.DataSource = dt;

        }
    }
}
