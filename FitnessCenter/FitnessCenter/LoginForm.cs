namespace FitnessCenter
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Closed += (s, args) => this.Close();
            this.Hide();
            registerForm.ShowDialog();
        }
    }
}
