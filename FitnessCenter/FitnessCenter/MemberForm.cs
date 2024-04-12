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
        DBConnection conn;
        Dictionary<int, Routine> routinedict;
        Dictionary<int, Session> sessiondict;
        Dictionary<int, Achievement> achdict;
        public MemberForm(Member m)
        {
            InitializeComponent();
            me = m;
            routinedict = new Dictionary<int, Routine>();
            sessiondict = new Dictionary<int, Session>();
            achdict = new Dictionary<int, Achievement>();
            setCurs();
            conn = new DBConnection();

            if (me.sex != null)
            {
                if (me.sex == "male") { option_male.Checked = true; }
                if (me.sex == "female") { option_female.Checked = true; }
                if (me.sex == "other") { option_other.Checked = true; }
            }

            loadRoutines();

        }

        private void setCurs()
        {
            username.Text = me.username;
            name.Text = me.first_name + " " + me.last_name;

            if (me.height != -1) { curHeight.Text = "current: " + me.height; }
            else { curHeight.Text = "current: None"; }
            if (me.current_weight != -1) { curWeight.Text = "current: " + me.current_weight; }
            else { curWeight.Text = "current: None"; }
            if (me.desired_weight != -1) { curDesWeight.Text = "current: " + me.desired_weight; }
            else { curDesWeight.Text = "current: None"; }
            if (me.sex != null) { curSex.Text = "current: " + me.sex; }
            else { curSex.Text = "current: None"; }
            setRoutine.Enabled = false;
            RegButton.Enabled = false;

            WelcomeText.Text = $"Welcome {me.first_name}! Here's some stats!";
            if (me.current_weight != -1)
            {
                Weight.Text = $"Weight: {me.current_weight}lbs";
                CurrentWeight.Text = $"You Weigh {me.current_weight}lbs";
            }

            if (me.desired_weight != -1)
            {
                ShouldWeigh.Text = $"You Should Weigh: {me.desired_weight}lbs";
            }

            if (me.height != -1)
            {
                Height.Text = $"Height: {me.height}cm";
            }

            if (me.desired_weight != -1 && me.current_weight != -1)
            {
                if (me.current_weight < me.desired_weight)
                {
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = (int)me.desired_weight;
                    progressBar1.Value = (int)me.current_weight;
                }
                else
                {
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = (int)me.current_weight;
                    progressBar1.Value = (int)me.desired_weight;
                }

            }

        }

        private async void loadSessions()
        {
            IEnumerable<Session> sessions = await conn.GetSessions();
            int index = 0;
            sessiondict.Clear();
            Sessions.Items.Clear();
            foreach (Session session in sessions)
            {
                sessiondict.Add(index, session);
                if (await conn.isInSession(me.member_id, session.session_id))
                {
                    Sessions.Items.Add(session.name + " (REGISTERED)");
                }
                else { Sessions.Items.Add(session.name); }

                index++;
            }
            loadAchievements();
        }

        private async void loadAchievements()
        {
            achdict.Clear();
            IEnumerable<Achievement> achievements = await conn.getAchievements(new List<string> { "member_id" }, new List<string> { me.member_id.ToString() });
            int index = 0;

            foreach (Achievement achievement in achievements)
            {
                AchievementsList.Items.Add(achievement.name);
                achdict.Add(index, achievement);
                index++;
            }
        }

        private async void loadRoutines()
        {
            routinedict.Clear();
            Routines.Items.Clear();
            IEnumerable<Routine> routines = await conn.GetRoutines();
            if (routines == null) { ErrorTextSS.Text = "No routines"; return; }
            routines = routines.OrderBy(r => r.catagory);
            int index;
            if (me.routine_id == -1)
            {
                index = 0;
            }
            else
            {
                Routines.Items.Insert(0, "current");
                index = 1;
            }
            foreach (Routine routine in routines)
            {
                String routineStr = $"Title: {routine.title} \n Category: {routine.catagory}";
                if (routine.routine_id != me.routine_id)
                {
                    Routines.Items.Add(routineStr);
                    routinedict.Add(index, routine);
                    index++;
                }
                else { routinedict.Add(0, routine); }
            }
            loadSessions();
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

        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm loginfrm = new LoginForm();
            loginfrm.Show();
            this.Close();
        }

        private async void setAttribues_click(object sender, EventArgs e)
        {
            if (setFN.Text != "")
            {
                await conn.updateAttributeStr("first_name", setFN.Text, "members", me.username);
                name.Text = setFN.Text + " " + me.last_name;
                me.first_name = setFN.Text;
                setFN.Text = "";
            }
            if (setLS.Text != "")
            {
                await conn.updateAttributeStr("last_name", setLS.Text, "members", me.username);
                name.Text = me.first_name + " " + setLS.Text;
                me.last_name = setLS.Text;
                setLS.Text = "";
            }
            int result;
            if (setDesWeight.Text != "" && int.TryParse(setDesWeight.Text, out result))
            {
                await conn.updateAttributeInt("desired_weight", result, me.username);
                curDesWeight.Text = "current: " + result;
                me.desired_weight = result;
                setDesWeight.Text = "";
            }
            if (setWeight.Text != "" && int.TryParse(setWeight.Text, out result))
            {
                await conn.updateAttributeInt("current_weight", result, me.username);
                curWeight.Text = "current: " + result;
                me.current_weight = result;
                setWeight.Text = "";
            }
            if (setHeight.Text != "" && int.TryParse(setHeight.Text, out result))
            {
                await conn.updateAttributeInt("height", result, me.username);
                curHeight.Text = "current: " + result;
                me.height = result;
                setHeight.Text = "";
            }

            if (option_male.Checked && me.sex != "male") { await conn.updateAttributeStr("sex", "male", "members", me.username); curSex.Text = "current: male"; }
            if (option_female.Checked && me.sex != "female") { await conn.updateAttributeStr("sex", "female", "members", me.username); curSex.Text = "current: female"; }
            if (option_other.Checked && me.sex != "other") { await conn.updateAttributeStr("sex", "other", "members", me.username); curSex.Text = "current: other"; }
            setCurs();
        }

        private void Routines_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_descbox();
        }

        private void update_descbox()
        {
            Routine selectedRoutine;
            if (Routines.SelectedIndex == -1)
            {
                selectedRoutine = routinedict[0];
            }
            else
            {
                selectedRoutine = routinedict[Routines.SelectedIndex];
            }

            RoutineDesc.Text = $"Title: {selectedRoutine.title} \n\nCategory: {selectedRoutine.catagory} \n\nDescription: {selectedRoutine.description}";
            if (selectedRoutine.routine_id == me.routine_id) { setRoutine.Enabled = false; }
            else { setRoutine.Enabled = true; }
        }

        private async void setRoutine_Click(object sender, EventArgs e)
        {
            Routine selectedRoutine = routinedict[Routines.SelectedIndex];
            me.routine_id = selectedRoutine.routine_id;
            await conn.updateAttributeInt("routine_id", me.routine_id, me.username);
            loadRoutines();
            setRoutine.Enabled = false;
        }

        private async void Sessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegButton.Enabled = true;
            Session selectedSession;
            if (Sessions.SelectedIndex == -1)
            {
                selectedSession = sessiondict[0];
            }
            else
            {
                selectedSession = sessiondict[Sessions.SelectedIndex];
            }

            Trainer trainer = await conn.getTrainerByID(selectedSession.trainer_id);

            SessionInfo.Text = $"{selectedSession.type}: {selectedSession.name} \n\nTrainer: {trainer.first_name} {trainer.last_name} \n\nDescription: {selectedSession.description}\n\nRoom Number: {selectedSession.room_number} \n\n {await conn.countSession(selectedSession.session_id)}/{selectedSession.capacity} registered";

            if (await conn.isInSession(me.member_id, selectedSession.session_id)) { RegButton.Text = "Unregister"; }
            else if (await conn.countSession(selectedSession.session_id) >= selectedSession.capacity) { RegButton.Enabled = false; }
            else { RegButton.Text = "Register"; }

            DateTime selectedDate = DateTime.Parse(selectedSession.date);

            monthCalendar.SetDate(selectedDate);
        }

        private async void RegButton_Click(object sender, EventArgs e)
        {
            Session selectedSession;
            if (Sessions.SelectedIndex == -1)
            {
                selectedSession = sessiondict[0];
            }
            else
            {
                selectedSession = sessiondict[Sessions.SelectedIndex];
            }

            if (RegButton.Text == "Unregister")
            {
                await conn.unRegisterForSession(me.member_id, selectedSession.session_id);
                RegButton.Text = "Register";
            }
            else
            {
                PaymentForm paymentsForm = new PaymentForm(me.member_id,"Session");
                paymentsForm.ShowDialog();

                if (paymentsForm.PaymentCompleted)
                {
                    await conn.registerForSession(me.member_id, selectedSession.session_id);
                    RegButton.Text = "Unregister";
                }
                else
                {
                    return;
                }
            }
            RegButton.Enabled = false;
            loadSessions();
        }

        private async void AchievementsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegButton.Enabled = true;
            Achievement selectedAchievement = achdict[AchievementsList.SelectedIndex];
           
            Trainer trainer = await conn.getTrainerByID(selectedAchievement.trainer_id);

            AcheivmentInfo.Text = $"name: {selectedAchievement.name}\n\nAwarded By: {trainer.first_name} {trainer.last_name} on {selectedAchievement.date}\n\nDescription: {selectedAchievement.description}";

        }

        private void bmi_Click(object sender, EventArgs e)
        {
            if(me.current_weight==-1 || me.height==-1) {myBMI.Text = "cannot calculate";myBMI.ForeColor = Color.Black; return; }
            double weightInKg = me.current_weight * 0.453592;

            double heightInM = me.height / 100.0;

            double BMICalc = weightInKg / (heightInM * heightInM);
            BMICalc =  Math.Round(BMICalc, 2);


            myBMI.Text = BMICalc.ToString();
            if(BMICalc > 30 || BMICalc < 18.5) { myBMI.ForeColor = Color.Red; }
            else { myBMI.ForeColor = Color.DarkGreen; }
        }
    }
}
