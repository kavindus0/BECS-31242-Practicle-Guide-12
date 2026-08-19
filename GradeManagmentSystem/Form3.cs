using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
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
    public partial class Form3 : Form
    {
        String connstr = "server=localhost;database=grademanagmentsystem;uid=root;pwd=;";
        public Form3()
        {
            InitializeComponent();
        }

        private List<StudentGradeItem> GetGrades()
        {
            var grades = new List<StudentGradeItem>();

            using var conn = new MySqlConnection(connstr);
            string query = "SELECT * FROM grade";

            using var cmd = new MySqlCommand(query, conn);

            conn.Open();

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                grades.Add(new StudentGradeItem
                {
                    StudentID = reader.IsDBNull(reader.GetOrdinal("StudentID")) ? null : reader.GetString("studentID"),
                    Marks = reader.IsDBNull(reader.GetOrdinal("Marks")) ? 0 : reader.GetInt32("Marks")
                });
            }
            return grades;
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer
            {
                Dock = DockStyle.Fill,
                ProcessingMode = ProcessingMode.Local
            };

            this.Controls.Add(reportViewer);
            reportViewer.LocalReport.ReportPath = Path.Combine(Application.StartupPath, "Report1.rdlc");

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("StudentGradeDataset",GetGrades()));

            reportViewer.RefreshReport();

        }


    }

    public class StudentGradeItem
    {
        public string StudentID { get; set; }

        public int Marks { get; set; }
    }





}
