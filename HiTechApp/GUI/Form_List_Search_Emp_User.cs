using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HCL.Business.Company;
using HCL.Business.Items;
using HCL.Business.People;
using HCL.Validation;

namespace HiTechApp.GUI
{
    public partial class Form_List_Search_Emp_User : Form
    {
        public Form_List_Search_Emp_User()
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

        private void modifyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To change your password, please login again with your old and new password", "Redirecting to the login menu");
            Form_Update_Password a = new Form_Update_Password();
            a.ShowDialog();
        }

        private void Form_List_Search_Emp_User_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
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
    }
}
