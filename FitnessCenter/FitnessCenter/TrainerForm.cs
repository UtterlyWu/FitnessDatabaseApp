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
    public partial class TrainerForm : Form
    {
        String username;
        String first_name;
        String last_name;
        public TrainerForm(String username, String first_name, String last_name)
        {
            InitializeComponent();
            this.username = username;
            this.first_name = first_name;
            this.last_name = last_name;

            //initialize stuff on window
            usernameLabel.Text = $"Logged in as: {username}";
        }

        private void MemberIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void submitUsername_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            Member mem = await conn.getMember(usernameTextBox.Text);
            nameLabel.Text = $"Name: {mem.first_name} {mem.last_name}";
            sexLabel.Text = $"Sex: {mem.sex}";
            curWeightLabel.Text = $"Current Weight: {mem.current_weight}";
            desiredWeightLabel.Text = $"Desired Weight: {mem.desired_weight}";
            joinDateLabel.Text = $"Join Date: {mem.joined_date}";
            heightLabel.Text = $"Height: {mem.height}";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void TrainerForm_Load(object sender, EventArgs e)
        {

        }

        private void submitAchievement_Click(object sender, EventArgs e)
        {

        }
    }
}
