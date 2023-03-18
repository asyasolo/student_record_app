using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsApp
{
    public partial class ViewStudentList : Form
    {
        string path = @"Data Source=YourDB;Initial Catalog=studentList;Integrated Security=True";
        SqlConnection connect;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public ViewStudentList()
        {
            InitializeComponent();
            connect = new SqlConnection(path);
            Display();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void Display()
        {
            try
            {
                dt = new DataTable();
                connect.Open();
                adapter = new SqlDataAdapter("select Student_Name, Student_Surname, Student_GPA, Student_Major from studentRecords", connect);
                adapter.Fill(dt);
                studentListGrid.DataSource = dt;

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
