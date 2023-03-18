namespace StudentsApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            usernameLabel = new Label();
            passwordLabel = new Label();
            label3 = new Label();
            usernameText = new TextBox();
            passwordText = new TextBox();
            userTypeCombo = new ComboBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(79, 132);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(159, 33);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(79, 190);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(159, 33);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 250);
            label3.Name = "label3";
            label3.Size = new Size(231, 33);
            label3.TabIndex = 2;
            label3.Text = "Type of user";
            // 
            // usernameText
            // 
            usernameText.Location = new Point(324, 124);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(234, 41);
            usernameText.TabIndex = 3;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(324, 182);
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = '*';
            passwordText.Size = new Size(234, 41);
            passwordText.TabIndex = 4;
            // 
            // userTypeCombo
            // 
            userTypeCombo.FormattingEnabled = true;
            userTypeCombo.Items.AddRange(new object[] { "Student", "Employee", "Admin" });
            userTypeCombo.Location = new Point(324, 242);
            userTypeCombo.Name = "userTypeCombo";
            userTypeCombo.Size = new Size(234, 41);
            userTypeCombo.TabIndex = 5;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(164, 197, 234);
            loginButton.Location = new Point(128, 349);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(337, 48);
            loginButton.TabIndex = 6;
            loginButton.Text = "Sign in";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(18F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(627, 531);
            Controls.Add(loginButton);
            Controls.Add(userTypeCombo);
            Controls.Add(passwordText);
            Controls.Add(usernameText);
            Controls.Add(label3);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Font = new Font("Courier New", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label passwordLabel;
        private Label label3;
        private TextBox usernameText;
        private TextBox passwordText;
        private ComboBox userTypeCombo;
        private Button loginButton;
    }
}