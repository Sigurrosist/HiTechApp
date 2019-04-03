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
    public partial class Form_OrderClerk : Form
    {
        public Form_OrderClerk()
        {
            InitializeComponent();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To change your password, please login again with your old and new password", "Redirecting to the login menu");
            Form_Update_Password a = new Form_Update_Password();
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.ShowDialog();
        }

        private void Form_OrderClerk_Load(object sender, EventArgs e)
        {
            rad_neworder.Checked = true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (rad_neworder.Checked)
            {
                Form_Save_New_Order a = new Form_Save_New_Order();
                a.ShowDialog();
            }
            if (rad_updateorders.Checked)
            {
                Form_Update_Orders a = new Form_Update_Orders();
                a.ShowDialog();
            }
            if (rad_list_search_orders.Checked)
            {
                Form_List_Search_Orders a = new Form_List_Search_Orders();
                a.ShowDialog();
            }
            if(rad_delete.Checked)
            {
                Form_Delete_Orders a = new Form_Delete_Orders();
                a.ShowDialog();
            }
        }
    }
}
