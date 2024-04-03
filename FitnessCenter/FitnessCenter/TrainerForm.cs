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
    }
}
