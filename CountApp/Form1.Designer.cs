namespace _02CountingApp
{
    partial class Form1
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
            this.lbl_CountBy = new System.Windows.Forms.Label();
            this.btn_by1 = new System.Windows.Forms.Button();
            this.btn_by2 = new System.Windows.Forms.Button();
            this.btn_by5 = new System.Windows.Forms.Button();
            this.btn_by10 = new System.Windows.Forms.Button();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.btn_Press = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_CountBy
            // 
            this.lbl_CountBy.AutoSize = true;
            this.lbl_CountBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CountBy.Location = new System.Drawing.Point(12, 9);
            this.lbl_CountBy.Name = "lbl_CountBy";
            this.lbl_CountBy.Size = new System.Drawing.Size(102, 31);
            this.lbl_CountBy.TabIndex = 0;
            this.lbl_CountBy.Text = "Count: ";
            // 
            // btn_by1
            // 
            this.btn_by1.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_by1.FlatAppearance.BorderSize = 0;
            this.btn_by1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_by1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_by1.Location = new System.Drawing.Point(120, 9);
            this.btn_by1.Name = "btn_by1";
            this.btn_by1.Size = new System.Drawing.Size(112, 31);
            this.btn_by1.TabIndex = 1;
            this.btn_by1.Text = "By 1";
            this.btn_by1.UseVisualStyleBackColor = false;
            this.btn_by1.Click += new System.EventHandler(this.btn_By1);
            // 
            // btn_by2
            // 
            this.btn_by2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_by2.FlatAppearance.BorderSize = 0;
            this.btn_by2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_by2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_by2.Location = new System.Drawing.Point(238, 9);
            this.btn_by2.Name = "btn_by2";
            this.btn_by2.Size = new System.Drawing.Size(112, 31);
            this.btn_by2.TabIndex = 2;
            this.btn_by2.Text = "By 2";
            this.btn_by2.UseVisualStyleBackColor = false;
            this.btn_by2.Click += new System.EventHandler(this.btn_By2);
            // 
            // btn_by5
            // 
            this.btn_by5.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_by5.FlatAppearance.BorderSize = 0;
            this.btn_by5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_by5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_by5.Location = new System.Drawing.Point(356, 9);
            this.btn_by5.Name = "btn_by5";
            this.btn_by5.Size = new System.Drawing.Size(112, 31);
            this.btn_by5.TabIndex = 3;
            this.btn_by5.Text = "By 5";
            this.btn_by5.UseVisualStyleBackColor = false;
            this.btn_by5.Click += new System.EventHandler(this.btn_By5);
            // 
            // btn_by10
            // 
            this.btn_by10.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_by10.FlatAppearance.BorderSize = 0;
            this.btn_by10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_by10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_by10.Location = new System.Drawing.Point(474, 9);
            this.btn_by10.Name = "btn_by10";
            this.btn_by10.Size = new System.Drawing.Size(112, 31);
            this.btn_by10.TabIndex = 4;
            this.btn_by10.Text = "By 10";
            this.btn_by10.UseVisualStyleBackColor = false;
            this.btn_by10.Click += new System.EventHandler(this.btn_By10);
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Count.Location = new System.Drawing.Point(232, 154);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(102, 31);
            this.lbl_Count.TabIndex = 5;
            this.lbl_Count.Text = "Count: ";
            // 
            // btn_Press
            // 
            this.btn_Press.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Press.FlatAppearance.BorderSize = 0;
            this.btn_Press.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Press.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Press.Location = new System.Drawing.Point(162, 256);
            this.btn_Press.Name = "btn_Press";
            this.btn_Press.Size = new System.Drawing.Size(132, 66);
            this.btn_Press.TabIndex = 6;
            this.btn_Press.Text = "Count";
            this.btn_Press.UseVisualStyleBackColor = false;
            this.btn_Press.Click += new System.EventHandler(this.btn_Count);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(336, 256);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(132, 66);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_reset);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 370);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Press);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.btn_by10);
            this.Controls.Add(this.btn_by5);
            this.Controls.Add(this.btn_by2);
            this.Controls.Add(this.btn_by1);
            this.Controls.Add(this.lbl_CountBy);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Count";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CountBy;
        private System.Windows.Forms.Button btn_by1;
        private System.Windows.Forms.Button btn_by2;
        private System.Windows.Forms.Button btn_by5;
        private System.Windows.Forms.Button btn_by10;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Button btn_Press;
        private System.Windows.Forms.Button btn_Reset;
    }
}

