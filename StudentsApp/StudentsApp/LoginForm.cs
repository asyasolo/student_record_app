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


namespace StudentsApp
{
    public partial class LoginForm : Form
    {
        SqlConnection connect = new("Data Source=DESKTOP-VN7BM1R\\SQLEXPRESS;Initial Catalog=studentList;Integrated Security=True");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text;
            string password = passwordText.Text;
            string userType = userTypeCombo.SelectedItem.ToString();
            string userTypeTable = "";

            try
            {
                if (username == "" || password == "")
                {
                    MessageBox.Show(" Please, provide login and password ");

                }
                else
                {
                    // specifying the type
                    if (userType == "Admin" || userType == "Employee")
                    {
                        connect.Open();

                        SqlCommand cmd = new("select * from adminUsers where U_Login=@username and U_Password=@password and U_Type=@userType", connect);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@userType", userType);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        int count = ds.Tables[0].Rows.Count;
                        if (count == 1 && userType == "Admin")
                        {
                            // navigate to admin form
                            MainForm adminForm = new();
                            adminForm.Show();
                            this.Hide();
                        }
                        else if (count == 1 && userType == "Employee")
                        {
                            // navigate to employee form
                            EmpoyeeForm empoyeeForm = new();
                            empoyeeForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(" Check your login, password and user type again. ");
                        }

                        connect.Close();
                    }
                    else if (userType == "Student")
                    {
                        connect.Open();

                        SqlCommand cmd = new("select * from studentRecords where Student_Login=@username and Student_Password=@password", connect);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        int count = ds.Tables[0].Rows.Count;
                        if (count == 1 && userType == "Student")
                        {
                            // navigate to viewStudentList form
                            ViewStudentList viewStudentList = new();
                            viewStudentList.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(" Check your login, password and user type again. ");
                        }

                        connect.Close();
                    }
                    else
                    {
                        MessageBox.Show("Smth went Wrong");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
