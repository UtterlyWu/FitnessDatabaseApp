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
using System.Windows.Forms.VisualStyles;
using FitnessCenter.Classes;
using Microsoft.Win32;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FitnessCenter
{
    public partial class AdminForm : Form
    {
        Admin me;
        DBConnection conn;
        Dictionary<string, int> words_to_index;
        Dictionary<string, int> trainers_to_index;
        Dictionary<int, int> rooms_to_index;
        Dictionary<int, int> index_to_rooms;
        public AdminForm(Admin admin)
        {
            InitializeComponent();
            conn = new DBConnection();
            me = admin;

            words_to_index = new Dictionary<string, int>()
            {
                { "Single" , 0 },
                { "Group"  , 1 }
            };
            trainers_to_index = new Dictionary<string, int>();
            rooms_to_index = new Dictionary<int, int>();
            index_to_rooms = new Dictionary<int, int>();
            refreshSessionListBox();
        }

        public async Task loadRooms1()
        {
            List<Room> rooms = await conn.getRooms("SELECT * FROM Rooms;");
            Rooms.Items.Clear();
            rooms_to_index.Clear();
            index_to_rooms.Clear();
            for (int i = 0; i < rooms.Count(); i++)
            {
                Rooms.Items.Add(rooms[i].room_number);//Ari Code
                rooms_to_index.Add(rooms[i].room_number, i);
                index_to_rooms.Add(i, rooms[i].room_number);
                machineRoomCombo.Items.Add(rooms[i]);
                Debug.WriteLine(rooms[i]);
            }
        }

        public async Task loadRooms()
        {
            List<Room> rooms = await conn.getRooms("SELECT * FROM Rooms;");
            for (int i = 0; i < rooms.Count; i++)
            {
                machineRoomCombo.Items.Add(rooms[i]);
                Debug.WriteLine(rooms[i]);
            }
        }

        public async Task refreshSessionListBox()
        {
            sessionListBox.Items.Clear();
            List<Session> sessions = await conn.getSessions("SELECT * FROM Sessions;");
            foreach (Session session in sessions)
            {
                sessionListBox.Items.Add(session);
            }
            await loadRooms1();
        }

        public async Task refreshDisplayedSession()
        {
            Session local_selected_session = (Session)sessionListBox.SelectedItem;
            if (local_selected_session != null && await conn.getSessions($"SELECT * FROM Sessions WHERE session_id = {local_selected_session.session_id};")!=null)
            {
                Debug.WriteLine("Trying to get id " + local_selected_session.session_id);
                Session selectedSession = (await conn.getSessions($"SELECT * FROM Sessions WHERE session_id = {local_selected_session.session_id};"))[0];
                Trainer trainer = await conn.getTrainerByID(selectedSession.trainer_id);
                nameTextBox.Text = selectedSession.name;
                trainerTextBox.Text = trainer == null ? "" : trainer.username;
                Rooms.SelectedIndex = rooms_to_index[selectedSession.room_number];
                typeComboBox.SelectedIndex = words_to_index[selectedSession.type];
                sesDescriptionTxt.Text = selectedSession.description;
                dateTextBox.Text = selectedSession.date;
                capacityTextBox.Text = selectedSession.capacity.ToString();
                attendingUsersList.Items.Clear();
                List<Member> attendees = await conn.getMembers(query: $"SELECT Members.* FROM Members NATURAL JOIN Registrations WHERE Registrations.session_id = {selectedSession.session_id};");
                for (int i = 0; i < attendees.Count; i++)
                {
                    attendingUsersList.Items.Add(attendees[i]);
                }
            }
            else
            {
                nameTextBox.Text = "";
                trainerTextBox.Text = "";
                Rooms.SelectedIndex = 0;
                typeComboBox.SelectedIndex = 0;
                sesDescriptionTxt.Text = "";
                dateTextBox.Text = "";
                capacityTextBox.Text = "";
                attendingUsersList.Items.Clear();
            }
        }

        public async Task refreshBillingsBox()
        {
            billingsListBox.Items.Clear();
            List<Billing> billings = await conn.getBillings("SELECT * FROM Billings;");
            foreach (Billing billing in billings)
            {
                billingsListBox.Items.Add(billing);
            }
        }

        public async Task refreshDisplayedBilling()
        {
            Billing selected_billing = (Billing)billingsListBox.SelectedItem;
            if (selected_billing != null)
            {
                Member member = (await conn.getMembers($"Select * FROM Members WHERE member_id = {selected_billing.member_id};"))[0];
                billingIdLabel.Text = "Billing ID: " + selected_billing.bill_id.ToString();
                amountLabel.Text = "Amount: " + selected_billing.amount.ToString();
                memberLabel.Text = "Member: " + member.username;
                cardNumberLabel.Text = "Card Number: " + selected_billing.card_number.ToString();
                purposeLabel.Text = "Purpose: " + selected_billing.purpose;
                dateLabel.Text = "Date: " + selected_billing.date;
            }
            else
            {
                billingIdLabel.Text = "Billing ID: ";
                amountLabel.Text = "Amount: ";
                memberLabel.Text = "Member: ";
                cardNumberLabel.Text = "Card Number: ";
                purposeLabel.Text = "Purpose: ";
                dateLabel.Text = "Date: ";
            }
        }

        public async Task refreshMachineBox()
        {
            machineListBox.Items.Clear();
            List<Machine> machines = await conn.getMachines("SELECT * FROM Machines;");
            foreach (Machine machine in machines)
            {
                machineListBox.Items.Add(machine);
            }
        }

        public async Task refreshMachineDisplay()
        {
            Machine selected_machine = (Machine)machineListBox.SelectedItem;
            if (selected_machine != null)
            {
                machineNameText.Text = selected_machine.name;
                machineRoomCombo.SelectedIndex = rooms_to_index[selected_machine.room_number];
                statusTextBox.Text = selected_machine.status;
            }
            else
            {
                machineNameText.Text = "";
                machineRoomCombo.SelectedIndex = 0;
                statusTextBox.Text = "";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sessionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshDisplayedSession();
        }

        private void sesDescriptionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Trainer trainer = await conn.getTrainer(trainerTextBox.Text);
            await conn.nonGetQuery($"INSERT INTO Sessions(name, trainer_id, room_number, type, description, date, capacity) " +
                                   $"VALUES ('{nameTextBox.Text}', {trainer.trainer_id}, {index_to_rooms[Rooms.SelectedIndex]}, '{typeComboBox.SelectedItem}', '{sesDescriptionTxt.Text}', '{dateTextBox.Text}', {capacityTextBox.Text})" +
                                   $"RETURNING session_id;", false);
            await refreshSessionListBox();
            sessionListBox.SelectedIndex = sessionListBox.Items.Count - 1;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            Member mem = attendingUsersList.SelectedItem as Member;
            if (mem != null)
            {
                await conn.nonGetQuery($"DELETE FROM Registrations WHERE member_id = {mem.member_id}", false);
                refreshDisplayedSession();
            }
        }

        private async void deleteSessionButton_Click(object sender, EventArgs e)
        {
            Session selected_session = (Session)sessionListBox.SelectedItem;
            if (selected_session != null)
            {
                await conn.nonGetQuery($"DELETE FROM Sessions WHERE session_id = {selected_session.session_id}", false);
                await refreshSessionListBox();
                refreshDisplayedSession();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Trainer trainer = await conn.getTrainer(trainerTextBox.Text);
            Session selected_session = (Session)sessionListBox.SelectedItem;
            await conn.nonGetQuery($"UPDATE Sessions " +
                                   $"SET name = '{nameTextBox.Text}', " +
                                   $"trainer_id = {trainer.trainer_id}, " +
                                   $"room_number = {index_to_rooms[Rooms.SelectedIndex]}, " +
                                   $"type = '{typeComboBox.SelectedItem}', " +
                                   $"description = '{sesDescriptionTxt.Text}', " +
                                   $"date = '{dateTextBox.Text}', " +
                                   $"capacity = {capacityTextBox.Text} " +
                                   $"WHERE session_id = {selected_session.session_id};", false);
            await refreshDisplayedSession();
            int selected = sessionListBox.SelectedIndex;
            await refreshSessionListBox();
            sessionListBox.SelectedIndex = selected;
        }

        private void billingsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshDisplayedBilling();
        }

        private async void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                refreshBillingsBox();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                await loadRooms();
                refreshMachineBox();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void machineListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshMachineDisplay();
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            Machine selected_machine = (Machine)machineListBox.SelectedItem;
            Room room = (Room)machineRoomCombo.SelectedItem;
            await conn.nonGetQuery($"UPDATE Machines " +
                                   $"SET name = '{machineNameText.Text}', " +
                                   $"status = '{statusTextBox.Text}', " +
                                   $"room_number = {room.room_number}" +
                                   $"WHERE machine_id = {selected_machine.machine_id};", false);
            await refreshMachineDisplay();
            int selected_machine_index = machineListBox.SelectedIndex;
            await refreshMachineBox();
            machineRoomCombo.SelectedIndex = selected_machine_index;
        }

        private void sesDateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
