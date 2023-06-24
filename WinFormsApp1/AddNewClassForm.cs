namespace WinFormsApp1
{
    public partial class AddNewClassForm : Form
    {
        private AddClassCallback callback;

        public AddNewClassForm()
        {
            InitializeComponent();
        }

        public void Populate(AddClassCallback callback)
        {
            this.callback = callback;
        }

        private void AddNewClassForm_Load(object sender, EventArgs e)
        {

        }

        private void addClass_button_Click(object sender, EventArgs e)
        {
            callback(className_textBox.Text);
            Close();
        }
    }
}
