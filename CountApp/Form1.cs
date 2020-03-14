using System;
using System.Drawing;
using System.Windows.Forms;

namespace _02CountingApp
{
    public partial class Form1 : Form
    {
        int count = 0;
        bool by1, by2, by5, by10 = false;

        public Form1()
        {
            InitializeComponent();
            by1 = true;
            lbl_Count.Text = $"Count: {count}";
        }

        #region Button Event Handlers
        private void btn_Count(object sender, EventArgs e)
        {
            if (by1) { count++; }
            if (by2){ count += 2; }
            if (by5) { count += 5; }
            if (by10) { count += 10; }
            lbl_Count.Text = $"Count: {count}";
        }

        private void btn_reset(object sender, EventArgs e)
        {
            count = 0;
            lbl_Count.Text = $"Count: {count}";
        }

        private void btn_By10(object sender, EventArgs e)
        {
            btn_by10.BackColor = Color.DarkOrange;
            by10 = true;
            btn_by1.BackColor = SystemColors.Highlight;
            by1 = false;
            btn_by2.BackColor = SystemColors.Highlight;
            by2 = false;
            btn_by5.BackColor = SystemColors.Highlight;
            by5 = false;
        }

        private void btn_By5(object sender, EventArgs e)
        {
            btn_by10.BackColor = SystemColors.Highlight;
            by10 = false;
            btn_by1.BackColor = SystemColors.Highlight;
            by1 = false;
            btn_by2.BackColor = SystemColors.Highlight;
            by2 = false;
            btn_by5.BackColor = Color.DarkOrange;
            by5 = true;
        }

        private void btn_By2(object sender, EventArgs e)
        {
            btn_by10.BackColor = SystemColors.Highlight;
            by10 = false;
            btn_by1.BackColor = SystemColors.Highlight;
            by1 = false;
            btn_by2.BackColor = Color.DarkOrange;
            by2 = true;
            btn_by5.BackColor = SystemColors.Highlight;
            by5 = false;
        }

        private void btn_By1(object sender, EventArgs e)
        {
            btn_by10.BackColor = SystemColors.Highlight;
            by10 = false;
            btn_by1.BackColor = Color.DarkOrange;
            by1 = true;
            btn_by2.BackColor = SystemColors.Highlight;
            by2 = false;
            btn_by5.BackColor = SystemColors.Highlight;
            by5 = false;
        }
        #endregion 
    }
}
