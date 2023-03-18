namespace StudentsApp
{
    partial class EmpoyeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpoyeeForm));
            exitButton = new Button();
            changeRecordsButton = new Button();
            viewStudentsButton = new Button();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(78, 64, 110);
            exitButton.FlatAppearance.BorderColor = Color.White;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 69, 138);
            exitButton.Font = new Font("Courier New", 18F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(313, 363);
            exitButton.Margin = new Padding(3, 4, 3, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(290, 101);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // changeRecordsButton
            // 
            changeRecordsButton.BackColor = Color.FromArgb(70, 116, 167);
            changeRecordsButton.FlatAppearance.BorderColor = Color.White;
            changeRecordsButton.FlatAppearance.BorderSize = 0;
            changeRecordsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 118, 181);
            changeRecordsButton.Font = new Font("Courier New", 18F, FontStyle.Regular, GraphicsUnit.Point);
            changeRecordsButton.ForeColor = Color.White;
            changeRecordsButton.Location = new Point(313, 225);
            changeRecordsButton.Margin = new Padding(3, 4, 3, 4);
            changeRecordsButton.Name = "changeRecordsButton";
            changeRecordsButton.Size = new Size(290, 101);
            changeRecordsButton.TabIndex = 4;
            changeRecordsButton.Text = "Change Records";
            changeRecordsButton.UseVisualStyleBackColor = false;
            changeRecordsButton.Click += changeRecordsButton_Click;
            // 
            // viewStudentsButton
            // 
            viewStudentsButton.BackColor = Color.FromArgb(77, 161, 208);
            viewStudentsButton.FlatAppearance.BorderColor = Color.White;
            viewStudentsButton.FlatAppearance.BorderSize = 0;
            viewStudentsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(77, 161, 220);
            viewStudentsButton.Font = new Font("Courier New", 18F, FontStyle.Regular, GraphicsUnit.Point);
            viewStudentsButton.ForeColor = Color.White;
            viewStudentsButton.Location = new Point(313, 89);
            viewStudentsButton.Margin = new Padding(3, 4, 3, 4);
            viewStudentsButton.Name = "viewStudentsButton";
            viewStudentsButton.Size = new Size(290, 101);
            viewStudentsButton.TabIndex = 3;
            viewStudentsButton.Text = "View Students";
            viewStudentsButton.UseVisualStyleBackColor = false;
            viewStudentsButton.Click += viewStudentsButton_Click;
            // 
            // EmpoyeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            ControlBox = false;
            Controls.Add(exitButton);
            Controls.Add(changeRecordsButton);
            Controls.Add(viewStudentsButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmpoyeeForm";
            Text = "Welcome, Empoyee!";
            ResumeLayout(false);
        }

        #endregion

        private Button exitButton;
        private Button changeRecordsButton;
        private Button viewStudentsButton;
    }
}