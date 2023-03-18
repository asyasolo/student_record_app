namespace StudentsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ChangeRecordsButton_Click(object sender, EventArgs e)
        {
            EditRecords editRecords = new("admin");
            editRecords.Show();
        }

        private void ViewStudentsButton_Click(object sender, EventArgs e)
        {
            ViewStudentList viewRecords = new ViewStudentList();
            viewRecords.Show();
        }
    }
}