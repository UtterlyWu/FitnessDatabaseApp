using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessCenter.Classes;

namespace FitnessCenter
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void option_member_CheckedChanged(object sender, EventArgs e)
        {
            if (option_member.Checked)
            {
                option_trainer.Checked = false;
                option_admin.Checked = false;
            }
        }

        private void option_trainer_CheckedChanged(object sender, EventArgs e)
        {
            if (option_trainer.Checked)
            {
                option_member.Checked = false;
                option_admin.Checked = false;
            }
        }

        private void option_admin_CheckedChanged(object sender, EventArgs e)
        {
            if (option_admin.Checked)
            {
                option_member.Checked = false;
                option_trainer.Checked = false;
            }
        }

        private async void Register_Click(object sender, EventArgs e)
        {
            if (!option_trainer.Checked && !option_admin.Checked && !option_member.Checked) {
                ErrorText.Text = "Please select type";
                return;
            }
            if (username.Text == "" || password.Text == "" || firstname.Text == "" || lastname.Text == "")
            {
                ErrorText.Text = "Please fill in all sections";
                return;
            }

            DBConnection conn = new DBConnection();
            
            if(option_member.Checked)
            {
                Member c = await conn.getMember(username.Text);
                if (c != null)
                {
                    ErrorText.Text = "username: " + username.Text + " taken";
                    return;
                }
                await conn.register(username.Text, password.Text, firstname.Text, lastname.Text, "members");
                Member q = await conn.getMember(username.Text);
                MemberForm memform = new MemberForm(new Member(q.username, q.password, q.first_name, q.last_name));
                memform.Show();
                this.Close();
                return;
            }
            if (option_trainer.Checked)
            {
                Trainer c = await conn.getTrainer(username.Text);
                if (c != null)
                {
                    ErrorText.Text = "username: " + username.Text + " taken";
                    return;
                }
                conn.register(username.Text, password.Text, firstname.Text, lastname.Text, "trainers");
                Trainer q = await conn.getTrainer(username.Text);
                TrainerForm trnform = new TrainerForm(q);
                trnform.Show();
                this.Close();
                return;
            }
            if (option_admin.Checked)
            {
                Admin c = await conn.getAdmin(username.Text);
                if (c != null)
                {
                    ErrorText.Text = "username: " + username.Text + " taken";
                    return;
                }
                conn.register(username.Text, password.Text, firstname.Text, lastname.Text, "adminstaff");
                Admin a = await conn.getAdmin(username.Text);
            }
        }
    }
}
