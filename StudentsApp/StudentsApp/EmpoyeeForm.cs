using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsApp
{
    public partial class EmpoyeeForm : Form
    {
        public EmpoyeeForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void viewStudentsButton_Click(object sender, EventArgs e)
        {
            ViewStudentList viewStudentList = new();
            viewStudentList.Show();
        }

        private void changeRecordsButton_Click(object sender, EventArgs e)
        {
            EditRecords mainForm = new EditRecords("employee");
            mainForm.Show();
        }
    }
}
