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
    public partial class AdminForm : Form
    {
        Admin me;
        public AdminForm(Admin admin)
        {
            InitializeComponent();
            me = admin;
        }
    }
}
