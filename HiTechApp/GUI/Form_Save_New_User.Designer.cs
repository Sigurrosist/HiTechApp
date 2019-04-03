namespace HiTechApp.GUI
{
    partial class Form_Save_New_User
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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_update = new System.Windows.Forms.RadioButton();
            this.rad_save = new System.Windows.Forms.RadioButton();
            this.cbo_user_role = new System.Windows.Forms.ComboBox();
            this.btn_user_save = new System.Windows.Forms.Button();
            this.txt_user_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.user_listview = new System.Windows.Forms.ListView();
            this.userid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userrole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emp_listview = new System.Windows.Forms.ListView();
            this.empid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empposition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(443, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "User List";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Employee List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.cbo_user_role);
            this.groupBox2.Controls.Add(this.btn_user_save);
            this.groupBox2.Controls.Add(this.txt_user_id);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(724, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 320);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_update);
            this.groupBox1.Controls.Add(this.rad_save);
            this.groupBox1.Location = new System.Drawing.Point(22, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 68);
            this.groupBox1.TabIndex = 169;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose the task to perform";
            // 
            // rad_update
            // 
            this.rad_update.AutoSize = true;
            this.rad_update.Location = new System.Drawing.Point(163, 24);
            this.rad_update.Name = "rad_update";
            this.rad_update.Size = new System.Drawing.Size(136, 22);
            this.rad_update.TabIndex = 1;
            this.rad_update.TabStop = true;
            this.rad_update.Text = "Update the User";
            this.rad_update.UseVisualStyleBackColor = true;
            // 
            // rad_save
            // 
            this.rad_save.AutoSize = true;
            this.rad_save.Location = new System.Drawing.Point(15, 24);
            this.rad_save.Name = "rad_save";
            this.rad_save.Size = new System.Drawing.Size(132, 22);
            this.rad_save.TabIndex = 0;
            this.rad_save.TabStop = true;
            this.rad_save.Text = "Save New User";
            this.rad_save.UseVisualStyleBackColor = true;
            // 
            // cbo_user_role
            // 
            this.cbo_user_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_user_role.FormattingEnabled = true;
            this.cbo_user_role.Location = new System.Drawing.Point(137, 95);
            this.cbo_user_role.Name = "cbo_user_role";
            this.cbo_user_role.Size = new System.Drawing.Size(199, 26);
            this.cbo_user_role.TabIndex = 20;
            // 
            // btn_user_save
            // 
            this.btn_user_save.Location = new System.Drawing.Point(37, 255);
            this.btn_user_save.Name = "btn_user_save";
            this.btn_user_save.Size = new System.Drawing.Size(299, 28);
            this.btn_user_save.TabIndex = 20;
            this.btn_user_save.Text = "Save New User Or Update Existed User";
            this.btn_user_save.UseVisualStyleBackColor = true;
            this.btn_user_save.Click += new System.EventHandler(this.btn_user_save_Click);
            // 
            // txt_user_id
            // 
            this.txt_user_id.Location = new System.Drawing.Point(137, 46);
            this.txt_user_id.Name = "txt_user_id";
            this.txt_user_id.ReadOnly = true;
            this.txt_user_id.Size = new System.Drawing.Size(199, 24);
            this.txt_user_id.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "User ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(15, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(509, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "- Please select the employee from the list to promote the employee to a user";
            // 
            // user_listview
            // 
            this.user_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userid,
            this.userrole});
            this.user_listview.FullRowSelect = true;
            this.user_listview.GridLines = true;
            this.user_listview.Location = new System.Drawing.Point(447, 174);
            this.user_listview.Name = "user_listview";
            this.user_listview.Size = new System.Drawing.Size(253, 462);
            this.user_listview.TabIndex = 15;
            this.user_listview.UseCompatibleStateImageBehavior = false;
            this.user_listview.View = System.Windows.Forms.View.Details;
            this.user_listview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.user_listview_MouseDoubleClick);
            // 
            // userid
            // 
            this.userid.Text = "ID";
            // 
            // userrole
            // 
            this.userrole.Text = "Role";
            this.userrole.Width = 150;
            // 
            // emp_listview
            // 
            this.emp_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.empid,
            this.empname,
            this.empposition});
            this.emp_listview.FullRowSelect = true;
            this.emp_listview.GridLines = true;
            this.emp_listview.Location = new System.Drawing.Point(18, 174);
            this.emp_listview.Name = "emp_listview";
            this.emp_listview.Size = new System.Drawing.Size(405, 462);
            this.emp_listview.TabIndex = 14;
            this.emp_listview.UseCompatibleStateImageBehavior = false;
            this.emp_listview.View = System.Windows.Forms.View.Details;
            this.emp_listview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.emp_listview_MouseDoubleClick);
            // 
            // empid
            // 
            this.empid.Text = "ID";
            // 
            // empname
            // 
            this.empname.Text = "Name";
            this.empname.Width = 150;
            // 
            // empposition
            // 
            this.empposition.Text = "Position";
            this.empposition.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(15, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "- Please select the user to update";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 28);
            this.menuStrip1.TabIndex = 166;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(761, 594);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(299, 42);
            this.btn_Exit.TabIndex = 167;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 20);
            this.label2.TabIndex = 168;
            this.label2.Text = "<< Save New User or Updated Users>>";
            // 
            // Form_Save_New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.user_listview);
            this.Controls.Add(this.emp_listview);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Save_New_User";
            this.Text = "Save New Users / Update User Information";
            this.Load += new System.EventHandler(this.Form_Save_New_User_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbo_user_role;
        private System.Windows.Forms.Button btn_user_save;
        private System.Windows.Forms.TextBox txt_user_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView user_listview;
        private System.Windows.Forms.ColumnHeader userid;
        private System.Windows.Forms.ColumnHeader userrole;
        private System.Windows.Forms.ListView emp_listview;
        private System.Windows.Forms.ColumnHeader empid;
        private System.Windows.Forms.ColumnHeader empname;
        private System.Windows.Forms.ColumnHeader empposition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_update;
        private System.Windows.Forms.RadioButton rad_save;
    }
}