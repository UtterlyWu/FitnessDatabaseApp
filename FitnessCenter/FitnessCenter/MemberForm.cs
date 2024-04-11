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
        public MemberForm(Member m)
        {
            InitializeComponent();
            me = m;
            routinedict = new Dictionary<int, Routine>();
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
    }
}
