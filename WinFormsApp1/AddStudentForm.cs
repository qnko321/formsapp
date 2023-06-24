using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class AddStudentForm : Form
    {
        AddStudentCallback addCallback;

        private static readonly int[] grades = { 
            2,
            3,
            4,
            5,
            6,
        };

        private int[] studentSubjects;

        public AddStudentForm()
        {
            InitializeComponent();
        }

        public void Populate(List<string> subjects, List<string> classes, AddStudentCallback callback)
        {
            studentSubjects = new int[subjects.Count];

            class_comboBox.Items.AddRange(classes.ToArray());
            addCallback = callback;

            int panelHeight = 0;
            for (int i = 0; i < subjects.Count; i++)
            {
                string subject = subjects[i];

                Panel subjectPanel = new()
                {
                    Width = grades_FlowLayoutPanel.Width,
                    Height = 30,
                };

                Label subjectNameLabel = new()
                {
                    Text = subject,
                    Location = new Point(0, 0),
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoSize = true,
                };

                ComboBox gradeComboBox = new()
                {
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Width = 45,
                    Location = new Point(subjectPanel.Width - (45 + 5), 0),
                    Anchor = AnchorStyles.Right,
                    Name = i.ToString(),
                };
                
                gradeComboBox.SelectedIndexChanged += GradeComboBox_SelectedIndexChanged;

                foreach (int grade in grades)
                {
                    gradeComboBox.Items.Add(grade.ToString());
                }

                subjectNameLabel.Height = gradeComboBox.Height;

                subjectPanel.Controls.Add(subjectNameLabel);
                subjectPanel.Controls.Add(gradeComboBox);

                grades_FlowLayoutPanel.Controls.Add(subjectPanel);

                panelHeight += 35;
            }
            grades_FlowLayoutPanel.Height = panelHeight;
            Height += panelHeight;
        }

        private void GradeComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int comboBoxIndex = int.Parse(comboBox.Name);
            studentSubjects[comboBoxIndex] = comboBox.SelectedIndex + 2;
        }

        private void addStudent_button_Click(object sender, EventArgs e)
        {
            addCallback(class_comboBox.SelectedIndex, name_textBox.Text, studentSubjects);
            Close();
        }
    }
}
