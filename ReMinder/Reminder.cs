using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ReMinder
{
    public partial class Reminder : UserControl
    {
        Access_DB db = new Access_DB();

        public Reminder()
        {
            InitializeComponent();
            DB_Refresh();
        }

        private void Event_SIC(object sender, EventArgs e)
        {
            lstbx_Dates.SelectedIndex = lstbx_Titles.SelectedIndex;
        }

        private void Date_SIC(object sender, EventArgs e)
        {
            lstbx_Titles.SelectedIndex = lstbx_Dates.SelectedIndex;
        }

        private void Reload_VC(object sender, EventArgs e)
        {
            DB_Refresh();
        }

        public void DB_Refresh()
        {
            LoadData(db.SELECT("*", "tbl_Reminder"));
            db.conn.Close();

            void LoadData(OleDbDataReader read)
            {
                lstbx_Titles.Items.Clear();
                lstbx_Dates.Items.Clear();
                while (read.Read())
                {
                    lstbx_Titles.Items.Add($"{read["event_title"]}");
                    lstbx_Dates.Items.Add($"{read["event_date"]}");
                }
            }
        }
    }
}
