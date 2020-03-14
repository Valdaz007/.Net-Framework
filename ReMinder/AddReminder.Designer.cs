namespace ReMinder
{
    partial class AddReminder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Info = new System.Windows.Forms.Label();
            this.lbl_Event = new System.Windows.Forms.Label();
            this.txtbx_Title = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txtbx_Description = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_DateWarning = new System.Windows.Forms.Label();
            this.lbl_TitleWarning = new System.Windows.Forms.Label();
            this.lbl_TitleCount = new System.Windows.Forms.Label();
            this.lbl_DescCount = new System.Windows.Forms.Label();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info.Location = new System.Drawing.Point(26, 22);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(186, 31);
            this.lbl_Info.TabIndex = 0;
            this.lbl_Info.Text = "Add Reminder";
            // 
            // lbl_Event
            // 
            this.lbl_Event.AutoSize = true;
            this.lbl_Event.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Event.Location = new System.Drawing.Point(27, 169);
            this.lbl_Event.Name = "lbl_Event";
            this.lbl_Event.Size = new System.Drawing.Size(62, 25);
            this.lbl_Event.TabIndex = 1;
            this.lbl_Event.Text = "Event";
            // 
            // txtbx_Title
            // 
            this.txtbx_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Title.Location = new System.Drawing.Point(32, 197);
            this.txtbx_Title.MaxLength = 30;
            this.txtbx_Title.Name = "txtbx_Title";
            this.txtbx_Title.Size = new System.Drawing.Size(356, 26);
            this.txtbx_Title.TabIndex = 2;
            this.txtbx_Title.TextChanged += new System.EventHandler(this.TitleInputChange);
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(27, 244);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(109, 25);
            this.lbl_Description.TabIndex = 3;
            this.lbl_Description.Text = "Description";
            // 
            // txtbx_Description
            // 
            this.txtbx_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Description.Location = new System.Drawing.Point(32, 272);
            this.txtbx_Description.MaxLength = 100;
            this.txtbx_Description.Multiline = true;
            this.txtbx_Description.Name = "txtbx_Description";
            this.txtbx_Description.Size = new System.Drawing.Size(356, 133);
            this.txtbx_Description.TabIndex = 4;
            this.txtbx_Description.TextChanged += new System.EventHandler(this.DescInputChange);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(425, 95);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 50);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.Add);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(27, 95);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(53, 25);
            this.lbl_Date.TabIndex = 6;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(32, 123);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(356, 26);
            this.dtp_Date.TabIndex = 8;
            // 
            // lbl_DateWarning
            // 
            this.lbl_DateWarning.AutoSize = true;
            this.lbl_DateWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_DateWarning.Location = new System.Drawing.Point(177, 104);
            this.lbl_DateWarning.Name = "lbl_DateWarning";
            this.lbl_DateWarning.Size = new System.Drawing.Size(153, 17);
            this.lbl_DateWarning.TabIndex = 9;
            this.lbl_DateWarning.Text = "Enter the Correct Date!";
            this.lbl_DateWarning.Visible = false;
            // 
            // lbl_TitleWarning
            // 
            this.lbl_TitleWarning.AutoSize = true;
            this.lbl_TitleWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_TitleWarning.Location = new System.Drawing.Point(177, 178);
            this.lbl_TitleWarning.Name = "lbl_TitleWarning";
            this.lbl_TitleWarning.Size = new System.Drawing.Size(126, 17);
            this.lbl_TitleWarning.TabIndex = 10;
            this.lbl_TitleWarning.Text = "Enter Events\' Title!";
            this.lbl_TitleWarning.Visible = false;
            // 
            // lbl_TitleCount
            // 
            this.lbl_TitleCount.AutoSize = true;
            this.lbl_TitleCount.Location = new System.Drawing.Point(369, 178);
            this.lbl_TitleCount.Name = "lbl_TitleCount";
            this.lbl_TitleCount.Size = new System.Drawing.Size(19, 13);
            this.lbl_TitleCount.TabIndex = 11;
            this.lbl_TitleCount.Text = "30";
            // 
            // lbl_DescCount
            // 
            this.lbl_DescCount.AutoSize = true;
            this.lbl_DescCount.Location = new System.Drawing.Point(363, 253);
            this.lbl_DescCount.Name = "lbl_DescCount";
            this.lbl_DescCount.Size = new System.Drawing.Size(25, 13);
            this.lbl_DescCount.TabIndex = 12;
            this.lbl_DescCount.Text = "100";
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.AutoSize = true;
            this.lbl_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Desc.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Desc.Location = new System.Drawing.Point(177, 249);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(69, 17);
            this.lbl_Desc.TabIndex = 13;
            this.lbl_Desc.Text = "Optional";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.lbl_Info);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 75);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Coral;
            this.panel3.Location = new System.Drawing.Point(415, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 50);
            this.panel3.TabIndex = 6;
            // 
            // AddReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbl_Desc);
            this.Controls.Add(this.lbl_DescCount);
            this.Controls.Add(this.lbl_TitleCount);
            this.Controls.Add(this.lbl_TitleWarning);
            this.Controls.Add(this.lbl_DateWarning);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.txtbx_Description);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.txtbx_Title);
            this.Controls.Add(this.lbl_Event);
            this.Controls.Add(this.panel1);
            this.Name = "AddReminder";
            this.Size = new System.Drawing.Size(500, 435);
            this.Load += new System.EventHandler(this.AddReminder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Label lbl_Event;
        private System.Windows.Forms.TextBox txtbx_Title;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txtbx_Description;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_DateWarning;
        private System.Windows.Forms.Label lbl_TitleWarning;
        private System.Windows.Forms.Label lbl_TitleCount;
        private System.Windows.Forms.Label lbl_DescCount;
        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}
