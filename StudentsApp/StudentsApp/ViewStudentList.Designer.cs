namespace StudentsApp
{
    partial class ViewStudentList
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
            studentListGrid = new DataGridView();
            studentListLabel = new Label();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)studentListGrid).BeginInit();
            SuspendLayout();
            // 
            // studentListGrid
            // 
            studentListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentListGrid.Location = new Point(12, 56);
            studentListGrid.Name = "studentListGrid";
            studentListGrid.RowTemplate.Height = 25;
            studentListGrid.Size = new Size(776, 315);
            studentListGrid.TabIndex = 0;
            // 
            // studentListLabel
            // 
            studentListLabel.AutoSize = true;
            studentListLabel.Font = new Font("Courier New", 18F, FontStyle.Regular, GraphicsUnit.Point);
            studentListLabel.Location = new Point(153, 17);
            studentListLabel.Name = "studentListLabel";
            studentListLabel.Size = new Size(488, 27);
            studentListLabel.TabIndex = 1;
            studentListLabel.Text = "There is a list of your classmates";
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(164, 197, 234);
            exitButton.Font = new Font("Courier New", 18F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.Location = new Point(245, 390);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(317, 48);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // ViewStudentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(exitButton);
            Controls.Add(studentListLabel);
            Controls.Add(studentListGrid);
            Name = "ViewStudentList";
            Text = "Student List";
            ((System.ComponentModel.ISupportInitialize)studentListGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView studentListGrid;
        private Label studentListLabel;
        private Button exitButton;
    }
}