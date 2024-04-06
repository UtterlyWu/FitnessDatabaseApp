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
        Trainer user;
        DBConnection conn;
        Member selected;

        public TrainerForm(Trainer user)
        {
            InitializeComponent();
            this.user = user;
            this.selected = null;
            conn = new DBConnection();

            //initialize stuff on window
            usernameLabel.Text = $"Logged in as: {user.username}";
            trainerNameLabel.Text = $"Name: {user.first_name} {user.last_name}";
        }

        private async void submitUsername_Click(object sender, EventArgs e)
        {
            //Display user information
            Member mem = await conn.getMember(usernameTextBox.Text);
            if (mem != null)
            {
                nameLabel.Text = $"Name: {mem.first_name} {mem.last_name}";
                sexLabel.Text = $"Sex: {mem.sex}";
                curWeightLabel.Text = $"Current Weight: {mem.current_weight}";
                desiredWeightLabel.Text = $"Desired Weight: {mem.desired_weight}";
                joinDateLabel.Text = $"Join Date: {mem.joined_date}";
                heightLabel.Text = $"Height: {mem.height}";
            }
            else
            {
                nameLabel.Text = "Name:";
                sexLabel.Text = "Sex:";
                curWeightLabel.Text = "Current Weight:";
                desiredWeightLabel.Text = "Desired Weight:";
                joinDateLabel.Text = "Join Date:";
                heightLabel.Text = "Height:";
            }

            //Display user achievements
            List<Achievement> achievements = await conn.getAchievements(usernameTextBox.Text);


        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm loginfrm = new LoginForm();
            loginfrm.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteAchivementButton_Click(object sender, EventArgs e)
        {

        }

        private void viewAchievementButton_Click(object sender, EventArgs e)
        {

        }

        private void submitAchievement_Click(object sender, EventArgs e)
        {
            conn.addAchievement(achievementNameBox.Text, achievementDescriptionBox.Text, selected.member_id, user.trainer_id);
        }
    }
}
