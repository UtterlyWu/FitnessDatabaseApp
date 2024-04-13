using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FitnessCenter.Classes;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            dateTimePicker.MinDate = DateTime.Now;
            refresh_availability();
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

        async void refresh_sessions()
        {

            sessionListBox.Items.Clear();
            List<Session> sessions = await conn.getSessions($"SELECT * FROM Sessions WHERE trainer_id = {user.trainer_id}");
            if (sessions != null)
            {
                for (int i = 0; i < sessions.Count; i++)
                {
                    sessionListBox.Items.Add(sessions[i]);
                }
            }
        }

        async void refresh_availability()
        {
            availabilityListBox.Items.Clear();
            List<Availability> availabilities = await conn.getAvailability($"SELECT * FROM Availability WHERE trainer_id = {user.trainer_id}");
            if (availabilities != null)
            {
                for (int i = 0; i < availabilities.Count; i++)
                {
                    availabilityListBox.Items.Add(availabilities[i]);
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
            if (cur_viewed_achievement != null)
            {
                cur_viewed_achievement.Close();
            }
        }

        private void deleteAchivementButton_Click(object sender, EventArgs e)
        {
            Achievement selected_achievement = (Achievement)achievementListBox.SelectedItem;
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
                int achievement_id = await conn.nonGetQuery($"INSERT INTO public.Achievements(name, description, member_id, date, trainer_id) VALUES ('{achievementNameBox.Text}', '{achievementDescriptionBox.Text}', {selected_mem.member_id}, '{sqlFormattedDate}', {user.trainer_id}) RETURNING achievement_id", true);
                achievementListBox.Items.Add(new Achievement(achievement_id, achievementNameBox.Text, achievementDescriptionBox.Text, selected_mem.member_id, sqlFormattedDate, user.trainer_id));
                achievementNameBox.Text = "";
                achievementDescriptionBox.Text = "";
            }
        }

        private async void addTimeButton_Click(object sender, EventArgs e)
        {
            await conn.nonGetQuery($"INSERT INTO Availability(date, trainer_id) VALUES ('{dateTimePicker.Value.ToString("yyyy-MM-dd")}', {user.trainer_id})", false);
            Availability to_add = new Availability(dateTimePicker.Value.ToString("yyyy-MM-dd"), user.trainer_id);
            availabilityListBox.Items.Add(to_add);
        }

        private async void deleteTimeButton_Click(object sender, EventArgs e)
        {
            Availability selected_availability = (Availability)availabilityListBox.SelectedItem;
            if (selected_availability != null)
            {
                List<Session> session = await conn.getSessions($"SELECT * FROM public.sessions WHERE date = '{selected_availability.date}'");
                Debug.WriteLine(session);
                if(session != null)
                {
                    Session s = session.FirstOrDefault();
                    await conn.nonGetQuery($"DELETE FROM public.registrations WHERE session_id = {s.session_id}", false);
                    await conn.nonGetQuery($"DELETE FROM public.sessions WHERE session_id = {s.session_id}", false);
                    await conn.nonGetQuery($"DELETE FROM Availability WHERE date = '{selected_availability.date}' AND trainer_id = {user.trainer_id}", false);
                }
                refresh_availability();
            }
        }

        private async void refreshSelectedSession()
        {
            Session selected_session = (Session)sessionListBox.SelectedItem;
            if (selected_session != null)
            {
                sesNameLabel.Text = $"Session Name: {selected_session.name}";
                sesLocationLabel.Text = $"Room Number: {selected_session.room_number}";
                sesTypeLabel.Text = $"Session Type: {selected_session.type}";
                sesDescriptionTxt.Text = $"{selected_session.description}";
                sesDateLabel.Text = $"Session Date: {selected_session.date}";

                attendingUserList.Items.Clear();
                List<Member> attendees = await conn.getMembers(query: $"SELECT Members.* FROM Members NATURAL JOIN Registrations WHERE Registrations.session_id = {selected_session.session_id};");
                for (int i = 0; i < attendees.Count; i++)
                {
                    attendingUserList.Items.Add(attendees[i]);
                }

                sesCapacityLabel.Text = $"Attending Members ({attendees.Count}/{selected_session.capacity}):";
            }
            else
            {
                sesNameLabel.Text = $"Session Name:";
                sesLocationLabel.Text = $"Room Number:";
                sesTypeLabel.Text = $"Session Type:";
                sesDescriptionTxt.Text = $"Session Description:";
                sesDateLabel.Text = $"Session Date:";
                sesCapacityLabel.Text = $"Attending Members:";
                attendingUserList.Items.Clear();
            }
        }

        private async void sessionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshSelectedSession();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                refresh_sessions();
            }
        }

        private void refreshSessions_Click(object sender, EventArgs e)
        {
            refresh_sessions();
            refreshSelectedSession();

        }

        private void dateTimePicker_DropDown(object sender, EventArgs e)
        {
            dateTimePicker.MinDate = DateTime.Now;
        }
    }
}
