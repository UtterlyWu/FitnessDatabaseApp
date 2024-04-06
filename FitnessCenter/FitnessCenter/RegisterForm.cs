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
                conn.register(username.Text, password.Text, firstname.Text, lastname.Text, "members");
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
            }
        }
    }
}
