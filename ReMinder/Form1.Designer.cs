namespace ReMinder
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_DB = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pnl_Nav = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Reminder = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.UC_Reminder = new ReMinder.Reminder();
            this.UC_AddReminder = new ReMinder.AddReminder();
            this.pnl_Header.SuspendLayout();
            this.pnl_Nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnl_Header.Controls.Add(this.lbl_DB);
            this.pnl_Header.Controls.Add(this.lbl_Header);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(500, 100);
            this.pnl_Header.TabIndex = 0;
            // 
            // lbl_DB
            // 
            this.lbl_DB.AutoSize = true;
            this.lbl_DB.Location = new System.Drawing.Point(12, 9);
            this.lbl_DB.Name = "lbl_DB";
            this.lbl_DB.Size = new System.Drawing.Size(30, 13);
            this.lbl_DB.TabIndex = 1;
            this.lbl_DB.Text = "temp";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(176, 39);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(157, 36);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "ReMinder";
            // 
            // pnl_Nav
            // 
            this.pnl_Nav.Controls.Add(this.btn_Close);
            this.pnl_Nav.Controls.Add(this.button4);
            this.pnl_Nav.Controls.Add(this.btn_Reminder);
            this.pnl_Nav.Controls.Add(this.button3);
            this.pnl_Nav.Controls.Add(this.btn_Add);
            this.pnl_Nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Nav.Location = new System.Drawing.Point(0, 100);
            this.pnl_Nav.Name = "pnl_Nav";
            this.pnl_Nav.Size = new System.Drawing.Size(500, 65);
            this.pnl_Nav.TabIndex = 1;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Bisque;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Perpetua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(400, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(100, 65);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.Close);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Bisque;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Perpetua", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(300, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btn_Reminder
            // 
            this.btn_Reminder.BackColor = System.Drawing.Color.Bisque;
            this.btn_Reminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reminder.Font = new System.Drawing.Font("Perpetua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reminder.Location = new System.Drawing.Point(0, 0);
            this.btn_Reminder.Name = "btn_Reminder";
            this.btn_Reminder.Size = new System.Drawing.Size(100, 65);
            this.btn_Reminder.TabIndex = 0;
            this.btn_Reminder.Text = "Reminder";
            this.btn_Reminder.UseVisualStyleBackColor = false;
            this.btn_Reminder.Click += new System.EventHandler(this.Reminder);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Bisque;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Perpetua", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(200, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Bisque;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Perpetua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(100, 0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 65);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add Reminder";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.AddReminder);
            // 
            // UC_Reminder
            // 
            this.UC_Reminder.BackColor = System.Drawing.Color.CadetBlue;
            this.UC_Reminder.Location = new System.Drawing.Point(0, 165);
            this.UC_Reminder.Name = "UC_Reminder";
            this.UC_Reminder.Size = new System.Drawing.Size(500, 435);
            this.UC_Reminder.TabIndex = 3;
            // 
            // UC_AddReminder
            // 
            this.UC_AddReminder.BackColor = System.Drawing.Color.CadetBlue;
            this.UC_AddReminder.Location = new System.Drawing.Point(0, 165);
            this.UC_AddReminder.Name = "UC_AddReminder";
            this.UC_AddReminder.Size = new System.Drawing.Size(500, 435);
            this.UC_AddReminder.TabIndex = 2;
            this.UC_AddReminder.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.UC_Reminder);
            this.Controls.Add(this.UC_AddReminder);
            this.Controls.Add(this.pnl_Nav);
            this.Controls.Add(this.pnl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReMinder";
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Nav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Panel pnl_Nav;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Reminder;
        private System.Windows.Forms.Button btn_Add;
        private AddReminder UC_AddReminder;
        private System.Windows.Forms.Label lbl_DB;
        private Reminder UC_Reminder;
    }
}

