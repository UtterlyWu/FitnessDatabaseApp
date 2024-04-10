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
    public partial class MemberForm : Form
    {
        Member me;
        public MemberForm(Member m)
        {
            InitializeComponent();
            me = m;
            setCurs();

        }

        private void setCurs()
        {
            username.Text = me.username;
            name.Text = me.first_name +" "+ me.last_name;

            if (me.height != 0) { curHeight.Text = "current: " + me.height; }
            else { curHeight.Text = "current: None"; }
            if (me.current_weight != 0) { curWeight.Text = "current: " + me.current_weight; }
            else { curWeight.Text = "current: None"; }
            if (me.desired_weight != 0) { curDesWeight.Text = "current: " + me.desired_weight; }
            else { curDesWeight.Text = "current: None"; }
            if (me.sex != null) { curSex.Text = "current: " + me.sex; }
            else { curSex.Text = "current: None"; }
        }
        private void option_male_CheckedChanged(object sender, EventArgs e)
        {
            if (option_male.Checked)
            {
                option_female.Checked = false;
                option_other.Checked = false;
            }
        }

        private void option_female_CheckedChanged(object sender, EventArgs e)
        {
            if (option_female.Checked)
            {
                option_male.Checked = false;
                option_other.Checked = false;
            }
        }

        private void option_other_CheckedChanged(object sender, EventArgs e)
        {
            if (option_other.Checked)
            {
                option_male.Checked = false;
                option_female.Checked = false;
            }
        }
    }
}
