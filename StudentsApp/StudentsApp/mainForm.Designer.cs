namespace StudentsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            viewStudentsButton = new Button();
            changeRecordsButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // viewStudentsButton
            // 
            viewStudentsButton.BackColor = Color.FromArgb(77, 161, 208);
            viewStudentsButton.FlatAppearance.BorderColor = Color.White;
            viewStudentsButton.FlatAppearance.BorderSize = 0;
            viewStudentsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(77, 161, 220);
            viewStudentsButton.Font = new Font("Courier New", 18F, FontStyle.Regular, GraphicsUnit.Point);
            viewStudentsButton.ForeColor = Color.White;
            viewStudentsButton.Location = new Point(287, 70);
            viewStudentsButton.Name = "viewStudentsButton";
            viewStudentsButton.Size = new Size(254, 76);
            viewStudentsButton.TabIndex = 0;
            viewStudentsButton.Text = "Veiw Records";
            viewStudentsButton.UseVisualStyleBackColor = false;
            viewStudentsButton.Click += ViewStudentsButton_Click;
            // 
            // changeRecordsButton
            // 
            changeRecordsButton.BackColor = Color.FromArgb(70, 116, 167);
            changeRecordsButton.FlatAppearance.BorderColor = Color.White;
            changeRecordsButton.FlatAppearance.BorderSize = 0;
            changeRecordsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 118, 181);
            changeRecordsButton.Font = new Font("Courier New", 18F, FontStyle.Regular, GraphicsUnit.Point);
            changeRecordsButton.ForeColor = Color.White;
            changeRecordsButton.Location = new Point(287, 172);
            changeRecordsButton.Name = "changeRecordsButton";
            changeRecordsButton.Size = new Size(254, 76);
            changeRecordsButton.TabIndex = 1;
            changeRecordsButton.Text = "Edit Records";
            changeRecordsButton.UseVisualStyleBackColor = false;
            changeRecordsButton.Click += ChangeRecordsButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(78, 64, 110);
            exitButton.FlatAppearance.BorderColor = Color.White;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 69, 138);
            exitButton.Font = new Font("Courier New", 18F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(287, 275);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(254, 76);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += ExitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(exitButton);
            Controls.Add(changeRecordsButton);
            Controls.Add(viewStudentsButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome, Admin!";
            ResumeLayout(false);
        }

        #endregion

        private Button viewStudentsButton;
        private Button changeRecordsButton;
        private Button exitButton;
    }
}