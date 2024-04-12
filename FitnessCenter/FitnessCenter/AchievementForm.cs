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
    public partial class AchievementForm : Form
    {
        DBConnection conn;
        public Achievement viewing;
        public delegate void SaveEvent();
        public SaveEvent achievement_saved;

        public AchievementForm(Achievement viewing)
        {
            InitializeComponent();
            conn = new DBConnection(); ;

            this.viewing = viewing;
            achievementNameTxt.Text = viewing.name;
            AchievementDescTxt.Text = viewing.description;
        }

        private void AchievementForm_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Save_Click(object sender, EventArgs e)
        {
            if (achievementNameTxt.Text.Trim() != "")
            {
                conn.updateAchievement(viewing.achievement_id, achievementNameTxt.Text, AchievementDescTxt.Text);
                achievement_saved();
            }
        }
    }
}
