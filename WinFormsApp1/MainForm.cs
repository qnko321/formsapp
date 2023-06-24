using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        List<Class> data;
        List<string> subjects = new List<string>() {
            "Български език и литература",
            "Математика",
            "Английски език",
            "Информационни Технологии",
            "Физическо възпитание и спорт",
            "География",
            "История",
            "Биология",
            "Физика",
            "Химия",
        };

        public MainForm()
        {
            InitializeComponent();
            data = new List<Class>();
        }

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(@"data.txt"))
            {
                string json = reader.ReadToEnd();
                data = JsonConvert.DeserializeObject<List<Class>>(json) ?? new List<Class>();

            }

            for (int i = 0; i < data.Count; i++)
            {
                comboBox1.Items.Add(data[i].Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Class selectedClass = data[comboBox1.SelectedIndex];
            UpdateStudentList(selectedClass.Students);
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm form = new AddStudentForm();
            List<string> classes = new List<string>();
            foreach (var schoolClass in data)
            {
                classes.Add(schoolClass.Name);
            }
            form.Populate(subjects, classes, AddStudent);
            Enabled = false;
            form.Show();
            form.FormClosed += Form_FormClosed;
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            AddNewClassForm form = new AddNewClassForm();
            List<string> classes = new List<string>();
            foreach (var schoolClass in data)
            {
                classes.Add(schoolClass.Name);
            }
            form.Populate(AddClass);
            Enabled = false;
            form.Show();
            form.FormClosed += Form_FormClosed;
        }

        private void Form_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            using (StreamWriter writer = new StreamWriter("data.txt"))
            {
                writer.Write(json);
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;

            Class selectedClass = data[comboBox1.SelectedIndex];
            UpdateStudentList(selectedClass.Students);
        }

        private void searchStudent_button_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Моля първо избере клас в който да търсите ученик");
                return;
            }

            Class selectedClass = data[comboBox1.SelectedIndex];

            if (searchStudent_textBox.Text == "" || searchStudent_textBox.Text == null)
            {
                UpdateStudentList(selectedClass.Students);
                return;
            }

            List<Student> result = selectedClass.Students.Where(item => item.Name.Contains(searchStudent_textBox.Text)).ToList();

            if (result.Count == 0)
            {
                MessageBox.Show($"Не са намерени ученици в \"{selectedClass.Name}\" клас с име \"{searchStudent_textBox.Text}\"");
                return;
            }

            UpdateStudentList(result);
        }

        private void calculateAverageGradeClass_button_Click(object sender, EventArgs e)
        {
            DisplayClassAverageGrade();
        }

        #endregion

        #region AddData

        public void AddStudent(int classIndex, string name, int[] grades)
        {
            double gradeSum = 0;
            foreach (int grade in grades)
            {
                gradeSum += grade;
            }
            double averageGrade = gradeSum / subjects.Count;

            Student new_student = new Student
            {
                Name = name,
                Class = data[classIndex].Name,
                AverageGrade = averageGrade,
            };
            data[classIndex].Students.Add(new_student);
            UpdateStudentNumbers(data[classIndex]);
            Enabled = true;
            if (comboBox1.SelectedIndex == -1) { return; }
            Class selectedClass = data[comboBox1.SelectedIndex];
            UpdateStudentList(selectedClass.Students);
        }

        public void AddClass(string name)
        {
            Class klas = new Class
            {
                Name = name,
                Students = new List<Student>(),
            };

            comboBox1.Items.Add(klas.Name);

            data.Add(klas);
        }

        #endregion

        #region UI

        private void DisplayClassAverageGrade()
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Моля изберете клас");
                return;
            }
            Class selectedClass = data[comboBox1.SelectedIndex];
            double gradeSum = 0;
            foreach (Student student in selectedClass.Students)
            {
                gradeSum += student.AverageGrade;
            }
            double averageGrade = gradeSum / selectedClass.Students.Count;

            MessageBox.Show($"Среден успех на \"{selectedClass.Name}\" клас: {averageGrade}");
        }

        private void UpdateStudentNumbers(Class klas)
        {
            List<Student> sortedStudents = klas.Students.OrderBy(student => student.Name).ToList();

            for (int i = 0; i < sortedStudents.Count; i++)
            {
                Student student = sortedStudents[i];
                student.Number = i + 1;
            }
        }

        private void UpdateStudentList(List<Student> students)
        {
            flowLayoutPanel1.Controls.Clear();

            Panel headerPanel = new Panel()
            {
                Width = flowLayoutPanel1.Width - 5,
                Height = 40,
                BackColor = SystemColors.Control,
            };

            Label numberHeader = new()
            {
                Text = "Номер",
                Width = 50,
                Height = 40,
                TextAlign = ContentAlignment.MiddleLeft,
            };

            Label nameHeader = new()
            {
                Text = "Име",
                Width = flowLayoutPanel1.Width / 3,
                Height = 40,
                Location = new Point(50, 0),
                TextAlign = ContentAlignment.MiddleLeft,
            };

            Label averageGradeHeader = new()
            {
                Text = "Среден Успех",
                Width = 50 + flowLayoutPanel1.Width / 3,
                Height = 40,
                Location = new Point((int)((double)(flowLayoutPanel1.Width / 3) * 1.5), 0),
                TextAlign = ContentAlignment.MiddleLeft,
            };

            headerPanel.Controls.Add(numberHeader);
            headerPanel.Controls.Add(nameHeader);
            headerPanel.Controls.Add(averageGradeHeader);

            flowLayoutPanel1.Controls.Add(headerPanel);

            List<Student> sortedStudents = students.OrderBy(student => student.AverageGrade).ToList();
            sortedStudents.Reverse();
            for (int student_index = 0; student_index < sortedStudents.Count; student_index++)
            {
                Student student = sortedStudents[student_index];

                Panel studentPanel = new()
                {
                    Width = flowLayoutPanel1.Width,
                    Height = 30,
                };

                Label numberLabel = new()
                {
                    Text = student.Number.ToString(),
                    Width = 50,
                    TextAlign = ContentAlignment.MiddleCenter,
                };

                Label nameLabel = new()
                {
                    Text = student.Name,
                    Width = flowLayoutPanel1.Width / 3,
                    Location = new Point(50, 0)
                };

                Label averageGradeLabel = new()
                {
                    Text = student.AverageGrade.ToString(),
                    Width = 50 + flowLayoutPanel1.Width / 3,
                    Height = 40,
                    Location = new Point((int)((double)(flowLayoutPanel1.Width / 3) * 1.5), 0),
                    TextAlign = ContentAlignment.MiddleLeft,
                };


                studentPanel.Controls.Add(numberLabel);
                studentPanel.Controls.Add(nameLabel);
                studentPanel.Controls.Add(averageGradeLabel);

                flowLayoutPanel1.Controls.Add(studentPanel);
            }
        }

        #endregion
    }
}