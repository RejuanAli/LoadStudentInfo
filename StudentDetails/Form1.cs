using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.Xml.Linq;

namespace StudentDetails
{
    public partial class Form1 : Form
    {
        private const string FileName = "StudentInfo.txt";
        private const int MaxStudents = 4;
        private const int MaxCourses = 3;
        private BindingList<Student> students = new BindingList<Student>();
        public Form1()
        {
            InitializeComponent();
            dataGridView.DataSource = students;
            dataGridView.ReadOnly = false;
            students = new BindingList<Student>();
            LoadDataFromFile();
            UpdateDataGridView();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (students.Count >= MaxStudents)
            {
                MessageBox.Show($"Maximum number of students ({MaxStudents}) reached.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = nameTextBox.Text;
            string course = courseTextBox.Text;
            int marks;

            if (!int.TryParse(marksTextBox.Text, out marks))
            {
                MessageBox.Show("Please enter valid marks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (students.Count(s => s.Course == course) >= MaxCourses)
            {
                MessageBox.Show($"Maximum number of students for course '{course}' reached.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the student already has three courses
            if (students.Count(s => s.Name == name) >= MaxCourses)
            {
                MessageBox.Show($"Student '{name}' has already reached the maximum number of courses ({MaxCourses}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate marks
            if (!IsValidMarks())
            {
                MessageBox.Show("Please enter valid marks (0 to 100).", "Invalid Marks", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student student = new Student(name, course, marks);
            students.Add(student);
            SaveDataToFile();
            MessageBox.Show("Student data saved successfully!");
        }

        private bool IsValidMarks()
        {
            if (int.TryParse(marksTextBox.Text, out int marks))
            {
                return marks >= 0 && marks <= 100;
            }
            return false;
        }
        private void SaveDataToFile()
        {
            File.WriteAllText(FileName, string.Empty);

            using (StreamWriter writer = new StreamWriter(FileName))
            {
                foreach (var student in students)
                {
                    writer.WriteLine($"{student.Name},{student.Course},{student.Marks}");
                }
            }
        }
        private void UpdateDataGridView()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = students;
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadDataFromFile();
            MessageBox.Show("Student data load successfully!");
        }
        private void LoadDataFromFile()
        {
            students.Clear();
            try
            {
                if (File.Exists(FileName))
                {
                    using (StreamReader reader = new StreamReader(FileName))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] parts = line.Split(',');
                            if (parts.Length == 3 && int.TryParse(parts[2], out int marks))
                            {
                                students.Add(new Student(parts[0], parts[1], marks));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell != null)
            {
                int selectedIndex = dataGridView.CurrentCell.RowIndex;

                // Remove data in memory
                students.RemoveAt(selectedIndex);

                // Update data in the file
                UpdateDataInFile();

                // Clear input fields
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
            MessageBox.Show("Student data deleted successfully!");
        }
        private void UpdateDataInFile()
        {
            using (StreamWriter sw = new StreamWriter(FileName))
            {
                foreach (var student in students)
                {
                    sw.WriteLine($"{student.Name},{student.Course},{student.Marks}");
                }
            }
        }
        private void ClearInputs()
        {
            nameTextBox.Clear();
            courseTextBox.Clear();
            marksTextBox.Clear();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView.Rows[selectedIndex];

                students[selectedIndex].Name = selectedRow.Cells[0].Value.ToString();
                students[selectedIndex].Course = selectedRow.Cells[1].Value.ToString();
                students[selectedIndex].Marks = Convert.ToInt32(selectedRow.Cells[2].Value.ToString());

                int marks;
                Student selectedStudent = students[selectedIndex];
                UpdateDataToFile();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
            MessageBox.Show("Student data update successfully!");
        }

        private void UpdateDataToFile()
        {
            File.Delete(FileName);
            foreach (var student in students)
            {
                File.AppendAllText(FileName, $"{student.Name},{student.Course},{student.Marks}" + Environment.NewLine);
            }
            
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Course { get; set; }
        public int Marks { get; set; }

        public Student(string name, string course, int marks)
        {
            Name = name;
            Course = course;
            Marks = marks;
        }
    }


}
