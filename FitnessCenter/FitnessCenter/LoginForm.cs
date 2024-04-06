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
            }
            else if (Option_Trainer.Checked) {
                account_type = "trainers";
            }
            else if (Option_Admin.Checked)
            {
                account_type = "adminstaff";
            }
            Account q= await conn.LoginAccount(usernameTB.Text, passwordTB.Text, account_type);

            if (q == null)
            {
                ErrorText.Text = "Unable to login, try again.";
                return;
            }
            else if (q.account_type == "members")
            {
                //open member form
                return;
            }
            else if (q.account_type == "trainers")
            {
                //take care of this later patrick
                //TrainerForm trnform = new TrainerForm();
                //trnform.Show();
                //this.Close();
                return;
            }
            else if (q.account_type == "adminstaff")
            {
                //open admin form
                return;
            }
            else
            {
                ErrorText.Text = "Unable to login, try again.";
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
