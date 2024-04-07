namespace StudentDetails
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nameTextBox = new TextBox();
            courseTextBox = new TextBox();
            marksTextBox = new TextBox();
            SaveButton = new Button();
            ExitButton = new Button();
            label5 = new Label();
            dataGridView = new DataGridView();
            LoadButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(58, 21);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 0;
            label1.Text = "Please enter student details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(142, 71);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(136, 109);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Course";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(136, 153);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 3;
            label4.Text = "Marks";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(226, 68);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(276, 27);
            nameTextBox.TabIndex = 4;
            // 
            // courseTextBox
            // 
            courseTextBox.Location = new Point(226, 106);
            courseTextBox.Name = "courseTextBox";
            courseTextBox.Size = new Size(276, 27);
            courseTextBox.TabIndex = 5;
            // 
            // marksTextBox
            // 
            marksTextBox.Location = new Point(226, 150);
            marksTextBox.Name = "marksTextBox";
            marksTextBox.Size = new Size(276, 27);
            marksTextBox.TabIndex = 6;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(252, 203);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(378, 203);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 8;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 252);
            label5.Name = "label5";
            label5.Size = new Size(267, 20);
            label5.TabIndex = 9;
            label5.Text = "Please load to update student details";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(142, 288);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(429, 150);
            dataGridView.TabIndex = 10;
            // 
            // LoadButton
            // 
            LoadButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadButton.Location = new Point(182, 470);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(94, 29);
            LoadButton.TabIndex = 11;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateButton.Location = new Point(308, 470);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 29);
            UpdateButton.TabIndex = 12;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(438, 470);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 13;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 527);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(LoadButton);
            Controls.Add(dataGridView);
            Controls.Add(label5);
            Controls.Add(ExitButton);
            Controls.Add(SaveButton);
            Controls.Add(marksTextBox);
            Controls.Add(courseTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Info";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nameTextBox;
        private TextBox courseTextBox;
        private TextBox marksTextBox;
        private Button SaveButton;
        private Button ExitButton;
        private Label label5;
        private DataGridView dataGridView;
        private Button LoadButton;
        private Button UpdateButton;
        private Button DeleteButton;
    }
}
