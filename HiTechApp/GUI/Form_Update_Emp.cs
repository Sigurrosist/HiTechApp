﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiTechApp.GUI
{
    public partial class Form_Update_Emp : Form
    {
        public Form_Update_Emp()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int answer;
            answer = Convert.ToInt32(MessageBox.Show("Do you want to exit the program.", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (answer == 6)
            {
                this.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            int answer;
            answer = Convert.ToInt32(MessageBox.Show("Do you want to exit the program.", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (answer == 6)
            {
                this.Close();
            }
        }

        private void Form_Update_Emp_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void modifyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To change your password, please login again with your old and new password", "Redirecting to the login menu");
            Form_Update_Password a = new Form_Update_Password();
            a.ShowDialog();
        }
    }
}
