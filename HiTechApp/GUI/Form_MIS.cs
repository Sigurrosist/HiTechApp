using System;
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
    public partial class Form_MIS : Form
    {
        public Form_MIS()
        {
            InitializeComponent();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To change your password, please login again with your old and new password","Redirecting to the login menu");
            Form_Update_Password a = new Form_Update_Password();
            a.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.ShowDialog();
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            int answer;
            answer = Convert.ToInt32(MessageBox.Show("Do you want to exit the program.", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (answer == 6)
            {
                this.Close();
            }
        }

        private void Form_MIS_Load(object sender, EventArgs e)
        {
            rad_newemp.Checked = true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (rad_newemp.Checked)
            {
                Form_Save_New_Emp a = new Form_Save_New_Emp();
                a.ShowDialog();
            }
            if (rad_newuser.Checked)
            {
                Form_Save_New_User a = new Form_Save_New_User();
                a.ShowDialog();
            }
            if (rad_updatemp.Checked)
            {
                Form_Update_Emp a = new Form_Update_Emp();
                a.ShowDialog();
            }
            if (rad_list_search.Checked)
            {
                Form_List_Search_Emp_User a = new Form_List_Search_Emp_User();
                a.ShowDialog();
            }
        }
    }
}
