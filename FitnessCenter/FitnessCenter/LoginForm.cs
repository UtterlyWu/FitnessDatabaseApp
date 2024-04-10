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

            String account_type = "";

            if (Option_Member.Checked)
            {
                account_type = "members";
                Member q = await conn.getMember(usernameTB.Text);
                if (q == null)
                {
                    ErrorText.Text = "Unable to login, try again.";
                    return;
                }
                if (q.password != passwordTB.Text)
                {
                    ErrorText.Text = "Incorrect Password, try again.";
                    return;
                }
                MemberForm memform = new MemberForm(q);
                memform.Show();
                this.Close();
                return;
            }
            else if (Option_Trainer.Checked) {
                account_type = "trainers";
                Trainer q = await conn.getTrainer(usernameTB.Text);
                if (q == null)
                {
                    ErrorText.Text = "Unable to login, try again.";
                    return;
                }
                if (q.password != passwordTB.Text)
                {
                    ErrorText.Text = "Incorrect Password, try again.";
                    return;
                }
                TrainerForm trnform = new TrainerForm(q.username, q.first_name, q.last_name);
                trnform.Show();
                this.Close();
                return;
            }
            else if (Option_Admin.Checked)
            {
                account_type = "adminstaff";
                Admin q = await conn.getAdmin(usernameTB.Text);
            }
            else {
                ErrorText.Text = "No option selected. Try again. Idiot.";
                return; 
            }

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
