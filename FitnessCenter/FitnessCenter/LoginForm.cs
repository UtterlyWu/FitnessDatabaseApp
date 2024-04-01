using FitnessCenter.Classes;

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

        private async void login_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();

            Task<IEnumerable<Member>> q = conn.LoginMember(usernameTB.Text, passwordTB.Text);
            //Account does not exist
            IEnumerable<Member> t = await q;
            if (t == null)
            {
                ErrorText.Text = "Error";
                return;
            }
            if (!t.Any())
            {
                ErrorText.Text = "Username or Password incorrect";
                return;
            }

            ErrorText.Text = "We good";
            ErrorText.Text = t.First().first_name;


        }

        private void Option_Member_CheckedChanged(object sender, EventArgs e)
        {
            if (Option_Member.Checked)
            {
                Option_Trainer.Checked = false;
                Option_Admin.Checked = false;
            }
        }

        private void Option_Trainer_CheckedChanged(object sender, EventArgs e)
        {
            if (Option_Trainer.Checked)
            {
                Option_Member.Checked = false;
                Option_Admin.Checked = false;
            }
        }

        private void Option_Admin_CheckedChanged(object sender, EventArgs e)
        {
            if (Option_Admin.Checked)
            {
                Option_Member.Checked = false;
                Option_Trainer.Checked = false;
            }
        }
    }
}
