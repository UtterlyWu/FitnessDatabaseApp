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
        Member selected_mem;
        AchievementForm cur_viewed_achievement;

        public TrainerForm(Trainer user)
        {
            InitializeComponent();
            conn = new DBConnection();

            this.user = user;
            selected_mem = null;
            cur_viewed_achievement = null;

            usernameLabel.Text = $"Logged in as: {user.username}";
            trainerNameLabel.Text = $"Name: {user.first_name} {user.last_name}";
        }

        void achievement_form_closed(object sender, FormClosedEventArgs e)
        {
            cur_viewed_achievement = null;
        }

        async void refresh_achievements()
        {
            if (selected_mem != null)
            {
                achievementListBox.Items.Clear();
                List<Achievement> achievements = await conn.getAchievements(new List<string> { "member_id" }, new List<string> { selected_mem.member_id.ToString() });
                for (int i = 0; i < achievements.Count; i++)
                {
                    achievementListBox.Items.Add(achievements[i]);
                }

            }
        }

        private async void submitUsername_Click(object sender, EventArgs e)
        {
            selected_mem = await conn.getMember(usernameTextBox.Text);
            if (selected_mem != null)
            {
                //Display user information
                nameLabel.Text = $"Name: {selected_mem.first_name} {selected_mem.last_name}";
                sexLabel.Text = $"Sex: {selected_mem.sex}";
                curWeightLabel.Text = $"Current Weight: {selected_mem.current_weight}";
                desiredWeightLabel.Text = $"Desired Weight: {selected_mem.desired_weight}";
                joinDateLabel.Text = $"Join Date: {selected_mem.joined_date}";
                heightLabel.Text = $"Height: {selected_mem.height}";
                //Display achievements
                refresh_achievements();
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
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm loginfrm = new LoginForm();
            loginfrm.Show();
            this.Close();
            cur_viewed_achievement.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteAchivementButton_Click(object sender, EventArgs e)
        {
            Achievement selected_achievement = (Achievement) achievementListBox.SelectedItem;
            if (selected_achievement != null)
            {
                List<string> argument = new List<string>() { "achievement_id" };
                List<string> value = new List<string>() { selected_achievement.achievement_id.ToString() };
                conn.deleteRow("Achievements", argument, value);
                achievementListBox.Items.RemoveAt(achievementListBox.SelectedIndex);
                if (cur_viewed_achievement != null && selected_achievement.achievement_id == cur_viewed_achievement.viewing.achievement_id)
                {
                    cur_viewed_achievement.Close();
                }
            }
        }

        private void viewAchievementButton_Click(object sender, EventArgs e)
        {

            Achievement selected_achievement = (Achievement)achievementListBox.SelectedItem;
            if (selected_achievement != null)
            {
                if (cur_viewed_achievement != null)
                {
                    cur_viewed_achievement.Close();
                }
                AchievementForm achievementfrm = new AchievementForm(selected_achievement);
                cur_viewed_achievement = achievementfrm;
                cur_viewed_achievement.FormClosed += new FormClosedEventHandler(achievement_form_closed);
                cur_viewed_achievement.achievement_saved += refresh_achievements;
                achievementfrm.Show();
            }
        }

        private async void submitAchievement_Click(object sender, EventArgs e)
        {
            if (achievementNameBox.Text != "" && selected_mem != null)
            {
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
                int achievement_id = await conn.addAchievement(achievementNameBox.Text, achievementDescriptionBox.Text, selected_mem.member_id, sqlFormattedDate, user.trainer_id);
                achievementListBox.Items.Add(new Achievement(achievement_id, achievementNameBox.Text, achievementDescriptionBox.Text, selected_mem.member_id, sqlFormattedDate, user.trainer_id));
                achievementNameBox.Text = "";
                achievementDescriptionBox.Text = "";
            }
        }
    }
}
