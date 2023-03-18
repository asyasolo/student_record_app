namespace StudentsApp
{
    partial class EditRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRecords));
            nameLabel = new Label();
            surnameLabel = new Label();
            majorLabel = new Label();
            gpaLabel = new Label();
            nameText = new TextBox();
            surnameText = new TextBox();
            gpaText = new TextBox();
            majorCombo = new ComboBox();
            studentListGrid = new DataGridView();
            saveRecordButton = new Button();
            EditRecordButton = new Button();
            DeleteRecordButton = new Button();
            loginLabel = new Label();
            passwordLabel = new Label();
            loginText = new TextBox();
            passwordText = new TextBox();
            label1 = new Label();
            searchFeature = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)studentListGrid).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(24, 45);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(87, 33);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(477, 45);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(141, 33);
            surnameLabel.TabIndex = 1;
            surnameLabel.Text = "Surname";
            // 
            // majorLabel
            // 
            majorLabel.AutoSize = true;
            majorLabel.Location = new Point(24, 139);
            majorLabel.Name = "majorLabel";
            majorLabel.Size = new Size(105, 33);
            majorLabel.TabIndex = 2;
            majorLabel.Text = "Major";
            // 
            // gpaLabel
            // 
            gpaLabel.AutoSize = true;
            gpaLabel.Location = new Point(477, 139);
            gpaLabel.Name = "gpaLabel";
            gpaLabel.Size = new Size(69, 33);
            gpaLabel.TabIndex = 3;
            gpaLabel.Text = "GPA";
            // 
            // nameText
            // 
            nameText.Location = new Point(124, 37);
            nameText.Name = "nameText";
            nameText.Size = new Size(295, 41);
            nameText.TabIndex = 4;
            // 
            // surnameText
            // 
            surnameText.Location = new Point(663, 37);
            surnameText.Name = "surnameText";
            surnameText.Size = new Size(198, 41);
            surnameText.TabIndex = 5;
            // 
            // gpaText
            // 
            gpaText.Location = new Point(663, 136);
            gpaText.Name = "gpaText";
            gpaText.Size = new Size(198, 41);
            gpaText.TabIndex = 6;
            // 
            // majorCombo
            // 
            majorCombo.FormattingEnabled = true;
            majorCombo.Items.AddRange(new object[] { "Agriculture", "Arts", "Business", "Communications", "Community Services", "Engineering & Technology", "Economics", "Nursing", "Psychology", "English Language and Literature" });
            majorCombo.Location = new Point(124, 136);
            majorCombo.Name = "majorCombo";
            majorCombo.Size = new Size(295, 41);
            majorCombo.TabIndex = 7;
            // 
            // studentListGrid
            // 
            studentListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentListGrid.Location = new Point(24, 257);
            studentListGrid.Name = "studentListGrid";
            studentListGrid.RowHeadersWidth = 51;
            studentListGrid.RowTemplate.Height = 25;
            studentListGrid.Size = new Size(867, 316);
            studentListGrid.TabIndex = 8;
            studentListGrid.CellDoubleClick += studentListGrid_CellDoubleClick;
            // 
            // saveRecordButton
            // 
            saveRecordButton.BackColor = Color.FromArgb(165, 202, 207);
            saveRecordButton.Location = new Point(914, 87);
            saveRecordButton.Name = "saveRecordButton";
            saveRecordButton.Size = new Size(167, 49);
            saveRecordButton.TabIndex = 9;
            saveRecordButton.Text = "Save";
            saveRecordButton.UseVisualStyleBackColor = false;
            saveRecordButton.Click += SaveRecordButton_Click;
            // 
            // EditRecordButton
            // 
            EditRecordButton.BackColor = Color.FromArgb(250, 214, 177);
            EditRecordButton.Location = new Point(914, 170);
            EditRecordButton.Name = "EditRecordButton";
            EditRecordButton.Size = new Size(167, 49);
            EditRecordButton.TabIndex = 10;
            EditRecordButton.Text = "Edit";
            EditRecordButton.UseVisualStyleBackColor = false;
            EditRecordButton.Click += EditRecordButton_Click;
            // 
            // DeleteRecordButton
            // 
            DeleteRecordButton.BackColor = Color.FromArgb(251, 183, 183);
            DeleteRecordButton.Location = new Point(914, 257);
            DeleteRecordButton.Name = "DeleteRecordButton";
            DeleteRecordButton.Size = new Size(167, 49);
            DeleteRecordButton.TabIndex = 11;
            DeleteRecordButton.Text = "Delete";
            DeleteRecordButton.UseVisualStyleBackColor = false;
            DeleteRecordButton.Click += DeleteRecordButton_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(24, 88);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(105, 33);
            loginLabel.TabIndex = 12;
            loginLabel.Text = "Login";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(477, 88);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(159, 33);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password";
            // 
            // loginText
            // 
            loginText.Location = new Point(124, 85);
            loginText.Name = "loginText";
            loginText.Size = new Size(295, 41);
            loginText.TabIndex = 14;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(663, 85);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(198, 41);
            passwordText.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 212);
            label1.Name = "label1";
            label1.Size = new Size(285, 33);
            label1.TabIndex = 16;
            label1.Text = "Search by Major";
            // 
            // searchFeature
            // 
            searchFeature.FormattingEnabled = true;
            searchFeature.Items.AddRange(new object[] { "Agriculture", "Arts", "Business", "Communications", "Community Services", "Engineering & Technology", "Economics", "Nursing", "Psychology", "English Language and Literature" });
            searchFeature.Location = new Point(323, 209);
            searchFeature.Name = "searchFeature";
            searchFeature.Size = new Size(486, 41);
            searchFeature.TabIndex = 17;
            searchFeature.SelectedValueChanged += searchFeature_SelectedValueChanged;
            // 
            // EditRecords
            // 
            AutoScaleDimensions = new SizeF(18F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1108, 590);
            Controls.Add(searchFeature);
            Controls.Add(label1);
            Controls.Add(passwordText);
            Controls.Add(loginText);
            Controls.Add(passwordLabel);
            Controls.Add(loginLabel);
            Controls.Add(DeleteRecordButton);
            Controls.Add(EditRecordButton);
            Controls.Add(saveRecordButton);
            Controls.Add(studentListGrid);
            Controls.Add(majorCombo);
            Controls.Add(gpaText);
            Controls.Add(surnameText);
            Controls.Add(nameText);
            Controls.Add(gpaLabel);
            Controls.Add(majorLabel);
            Controls.Add(surnameLabel);
            Controls.Add(nameLabel);
            Font = new Font("Courier New", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            Name = "EditRecords";
            Text = "EditRecords";
            ((System.ComponentModel.ISupportInitialize)studentListGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label surnameLabel;
        private Label majorLabel;
        private Label gpaLabel;
        private TextBox nameText;
        private TextBox surnameText;
        private TextBox gpaText;
        private ComboBox majorCombo;
        private DataGridView studentListGrid;
        private Button saveRecordButton;
        private Button EditRecordButton;
        private Button DeleteRecordButton;
        private Label loginLabel;
        private Label passwordLabel;
        private TextBox loginText;
        private TextBox passwordText;
        private Label label1;
        private ComboBox searchFeature;
    }
}