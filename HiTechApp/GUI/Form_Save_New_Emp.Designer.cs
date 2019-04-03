namespace HiTechApp.GUI
{
    partial class Form_Save_New_Emp
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
            this.empposition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            this.empid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emp_listview = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_salary_emp = new System.Windows.Forms.ComboBox();
            this.cbo_status_emp = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbo_position_emp = new System.Windows.Forms.ComboBox();
            this.txt_emp_address = new System.Windows.Forms.TextBox();
            this.txt_emp_phone = new System.Windows.Forms.TextBox();
            this.txt_emp_lname = new System.Windows.Forms.TextBox();
            this.txt_emp_fname = new System.Windows.Forms.TextBox();
            this.txt_emp_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save_emp = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // empposition
            // 
            this.empposition.Text = "Position";
            this.empposition.Width = 100;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // modifyPasswordToolStripMenuItem
            // 
            this.modifyPasswordToolStripMenuItem.Name = "modifyPasswordToolStripMenuItem";
            this.modifyPasswordToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.modifyPasswordToolStripMenuItem.Text = "&Modify Password";
            this.modifyPasswordToolStripMenuItem.Click += new System.EventHandler(this.modifyPasswordToolStripMenuItem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Employee List";
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
            // emp_listview
            // 
            this.emp_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.empid,
            this.empname,
            this.empposition});
            this.emp_listview.FullRowSelect = true;
            this.emp_listview.GridLines = true;
            this.emp_listview.Location = new System.Drawing.Point(12, 75);
            this.emp_listview.Name = "emp_listview";
            this.emp_listview.Size = new System.Drawing.Size(423, 495);
            this.emp_listview.TabIndex = 8;
            this.emp_listview.UseCompatibleStateImageBehavior = false;
            this.emp_listview.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_salary_emp);
            this.groupBox1.Controls.Add(this.cbo_status_emp);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbo_position_emp);
            this.groupBox1.Controls.Add(this.txt_emp_address);
            this.groupBox1.Controls.Add(this.txt_emp_phone);
            this.groupBox1.Controls.Add(this.txt_emp_lname);
            this.groupBox1.Controls.Add(this.txt_emp_fname);
            this.groupBox1.Controls.Add(this.txt_emp_id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_status);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(459, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 375);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Management";
            // 
            // cbo_salary_emp
            // 
            this.cbo_salary_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_salary_emp.FormattingEnabled = true;
            this.cbo_salary_emp.Location = new System.Drawing.Point(137, 279);
            this.cbo_salary_emp.Name = "cbo_salary_emp";
            this.cbo_salary_emp.Size = new System.Drawing.Size(217, 26);
            this.cbo_salary_emp.TabIndex = 23;
            // 
            // cbo_status_emp
            // 
            this.cbo_status_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status_emp.FormattingEnabled = true;
            this.cbo_status_emp.Location = new System.Drawing.Point(137, 319);
            this.cbo_status_emp.Name = "cbo_status_emp";
            this.cbo_status_emp.Size = new System.Drawing.Size(217, 26);
            this.cbo_status_emp.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Salary";
            // 
            // cbo_position_emp
            // 
            this.cbo_position_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_position_emp.FormattingEnabled = true;
            this.cbo_position_emp.Location = new System.Drawing.Point(138, 242);
            this.cbo_position_emp.Name = "cbo_position_emp";
            this.cbo_position_emp.Size = new System.Drawing.Size(217, 26);
            this.cbo_position_emp.TabIndex = 18;
            // 
            // txt_emp_address
            // 
            this.txt_emp_address.Location = new System.Drawing.Point(138, 206);
            this.txt_emp_address.Name = "txt_emp_address";
            this.txt_emp_address.Size = new System.Drawing.Size(217, 24);
            this.txt_emp_address.TabIndex = 11;
            // 
            // txt_emp_phone
            // 
            this.txt_emp_phone.Location = new System.Drawing.Point(138, 170);
            this.txt_emp_phone.Name = "txt_emp_phone";
            this.txt_emp_phone.Size = new System.Drawing.Size(217, 24);
            this.txt_emp_phone.TabIndex = 10;
            // 
            // txt_emp_lname
            // 
            this.txt_emp_lname.Location = new System.Drawing.Point(138, 134);
            this.txt_emp_lname.Name = "txt_emp_lname";
            this.txt_emp_lname.Size = new System.Drawing.Size(217, 24);
            this.txt_emp_lname.TabIndex = 9;
            // 
            // txt_emp_fname
            // 
            this.txt_emp_fname.Location = new System.Drawing.Point(138, 99);
            this.txt_emp_fname.Name = "txt_emp_fname";
            this.txt_emp_fname.Size = new System.Drawing.Size(217, 24);
            this.txt_emp_fname.TabIndex = 8;
            // 
            // txt_emp_id
            // 
            this.txt_emp_id.Location = new System.Drawing.Point(138, 61);
            this.txt_emp_id.Name = "txt_emp_id";
            this.txt_emp_id.Size = new System.Drawing.Size(217, 24);
            this.txt_emp_id.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee ID";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_status.Location = new System.Drawing.Point(7, 29);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(314, 18);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "- Enter all information and click the save button";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(523, 530);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(317, 40);
            this.btn_exit.TabIndex = 19;
            this.btn_exit.Text = "&Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save_emp
            // 
            this.btn_save_emp.Location = new System.Drawing.Point(523, 473);
            this.btn_save_emp.Name = "btn_save_emp";
            this.btn_save_emp.Size = new System.Drawing.Size(317, 40);
            this.btn_save_emp.TabIndex = 13;
            this.btn_save_emp.Text = "&Save new Employee(ID auto-generated)";
            this.btn_save_emp.UseVisualStyleBackColor = true;
            this.btn_save_emp.Click += new System.EventHandler(this.btn_save_emp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.modifyPasswordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form_Save_New_Emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 591);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.emp_listview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_save_emp);
            this.Name = "Form_Save_New_Emp";
            this.Text = "Save New Employee";
            this.Load += new System.EventHandler(this.Form_Save_New_Emp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader empposition;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyPasswordToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColumnHeader empid;
        private System.Windows.Forms.ColumnHeader empname;
        private System.Windows.Forms.ListView emp_listview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_salary_emp;
        private System.Windows.Forms.ComboBox cbo_status_emp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox cbo_position_emp;
        private System.Windows.Forms.Button btn_save_emp;
        private System.Windows.Forms.TextBox txt_emp_address;
        private System.Windows.Forms.TextBox txt_emp_phone;
        private System.Windows.Forms.TextBox txt_emp_lname;
        private System.Windows.Forms.TextBox txt_emp_fname;
        private System.Windows.Forms.TextBox txt_emp_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_status;
    }
}