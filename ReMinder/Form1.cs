using System;
using System.Windows.Forms;

namespace ReMinder
{
    public partial class MainWindow : Form
    {
        Access_DB db = new Access_DB();

        public MainWindow()
        {
            InitializeComponent();
            lbl_DB.Text = db.Connection();
        }

        private void Close(object sender, EventArgs e) { Close(); }

        private void AddReminder(object sender, EventArgs e)
        {
            lbl_DB.Text = db.Connection();
            UC_AddReminder.Visible = true;
            UC_Reminder.Visible = false;
        }

        private void Reminder(object sender, EventArgs e)
        {
            lbl_DB.Text = db.Connection();
            UC_AddReminder.Visible = false;
            UC_Reminder.Visible = true;
        }
    }
}
