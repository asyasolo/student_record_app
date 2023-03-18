using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace StudentsApp
{
    public partial class EditRecords : Form
    {
        // String connection
        string path = @"Data Source=YourDB;Initial Catalog=studentList;Integrated Security=True";
        SqlConnection connect;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        int ID;

        public EditRecords(string source)
        {
            InitializeComponent();
            connect = new SqlConnection(path);

            if (source == "employee")
            {
                DeleteRecordButton.Enabled = false;
            }
            else if (source == "admin")
            {
                DeleteRecordButton.Enabled = true;
            }

            Display();
        }

        private void SaveRecordButton_Click(object sender, EventArgs e)
        {

            if (nameText.Text == "" || surnameText.Text == "" || gpaText.Text == "" || loginText.Text == "" || passwordText.Text == "")
            {
                MessageBox.Show(" Please, enter all of required information. ");
            }
            else
            {
                try
                {
                    connect.Open();
                    cmd = new SqlCommand("insert into studentRecords (Student_Name, Student_Surname, Student_GPA, Student_Major, Student_Login, Student_Password) values (@Name, @Surname, @GPA, @Major, @Login, @Password)", connect);
                    cmd.Parameters.AddWithValue("@Name", nameText.Text);
                    cmd.Parameters.AddWithValue("@Surname", surnameText.Text);
                    cmd.Parameters.AddWithValue("@GPA", gpaText.Text);
                    cmd.Parameters.AddWithValue("@Major", majorCombo.Text.ToString());
                    cmd.Parameters.AddWithValue("@Login", loginText.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordText.Text);

                    cmd.ExecuteNonQuery();
                    connect.Close();

                    MessageBox.Show(" The record has been saved to the database. ");
                    Clear();
                    Display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Clear()
        {
            nameText.Text = "";
            surnameText.Text = "";
            gpaText.Text = "";
            loginText.Text = "";
            passwordText.Text = "";
        }

        public void Display()
        {
            try
            {
                dt = new DataTable();
                connect.Open();
                adapter = new SqlDataAdapter("SELECT * FROM studentRecords", connect);
                adapter.Fill(dt);
                studentListGrid.DataSource = dt;

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void studentListGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(studentListGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            nameText.Text = studentListGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            surnameText.Text = studentListGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            gpaText.Text = studentListGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            majorCombo.Text = studentListGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            loginText.Text = studentListGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            passwordText.Text = studentListGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void EditRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                cmd = new SqlCommand("update studentRecords set Student_Name='" + nameText.Text + "', Student_Surname='" + surnameText.Text + "', Student_GPA='" + gpaText.Text + "', Student_Major='" + majorCombo.Text + "', Student_Login='" + loginText.Text + "', Student_Password='" + passwordText.Text + "' where Student_Id='" + ID + "'", connect);
                cmd.ExecuteNonQuery();


                connect.Close();
                MessageBox.Show(" The record has been updated. ");
                Clear();
                Display();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                cmd = new SqlCommand("delete from studentRecords where Student_Id='" + ID + "' ", connect);
                cmd.ExecuteNonQuery();
                connect.Close();

                MessageBox.Show(" The record has been deleted ");
                Clear();
                Display();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void searchFeature_SelectedValueChanged(object sender, EventArgs e)
        {
            connect.Open();

            adapter = new SqlDataAdapter("select * from studentRecords where Student_Major like '" + searchFeature.Text + "'", connect);

            dt = new DataTable();
            adapter.Fill(dt);
            studentListGrid.DataSource = dt;

            connect.Close();
        }
    }
}
