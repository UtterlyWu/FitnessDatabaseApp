using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
