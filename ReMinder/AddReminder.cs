using System;
using System.Windows.Forms;

namespace ReMinder
{
    public partial class AddReminder : UserControl
    {
        Access_DB db = new Access_DB();

        string event_Date, event_Title, event_Desc;
        int titleCount, descCount, temp;

        public AddReminder()
        {
            InitializeComponent();
            titleCount = 30;
            descCount = 100;
        }

        #region Buttons
        private void AddReminder_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.CadetBlue;
        }
        private void Add(object sender, EventArgs e)
        {
            if (check())
            {
                event_Date = $"{dtp_Date.Value.ToLongDateString()}";
                event_Title = txtbx_Title.Text;
                event_Desc = txtbx_Description.Text;

                MessageBox.Show(db.INSERT("tbl_Reminder", 
                                          "event_date, event_title, event_description", 
                                          $"'{event_Date}', '{event_Title}', '{event_Desc}'")
                );
                Clear();
            }
            bool check()
            {
                if (dtp_Date.Value > DateTime.Now && txtbx_Title.Text != "")
                    return true;
                if (dtp_Date.Value <= DateTime.Now)
                    lbl_DateWarning.Visible = true;
                else
                    lbl_DateWarning.Visible = false;
                if (txtbx_Title.Text == "")
                    lbl_TitleWarning.Visible = true;
                else
                    lbl_TitleWarning.Visible = false;
                return false;
            }
            void Clear()
            {
                dtp_Date.Value = DateTime.Now;
                txtbx_Title.Text = "";
                txtbx_Description.Text = "";
            }
        }
        #endregion

        #region TextBoxes
        private void TitleInputChange(object sender, EventArgs e)
        {
            temp = titleCount - txtbx_Title.TextLength;
            lbl_TitleCount.Text = temp.ToString();
        }
        private void DescInputChange(object sender, EventArgs e)
        {
            temp = descCount - txtbx_Description.TextLength;
            lbl_DescCount.Text = temp.ToString();
        }
        #endregion
    }
}
