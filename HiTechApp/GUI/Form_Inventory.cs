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
    public partial class Form_Inventory : Form
    {
        public Form_Inventory()
        {
            InitializeComponent();
        }
        private void exit()
        {
            int answer;
            answer = Convert.ToInt32(MessageBox.Show("Do you want to exit the program.", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (answer == 6)
            {
                this.Close();
            }
        }
        private void new_item()
        {
            Form_Save_New_Items a = new Form_Save_New_Items();
            a.ShowDialog();
        }
        private void new_author()
        {
            Form_Add_new_author a = new Form_Add_new_author();
            a.ShowDialog();
        }
        private void new_publisher()
        {
            Form_Add_New_Publisher a = new Form_Add_New_Publisher();
            a.ShowDialog();
        }
        private void list_search()
        {
            Form_List_Search a = new Form_List_Search();
            a.ShowDialog();
        }
        private void modify_item()
        {
            Form_Update_Items a = new Form_Update_Items();
            a.ShowDialog();
        }
        private void remove_item()
        {
            Form_Remove a = new Form_Remove();
            a.ShowDialog();
        }

        private void Form_Inventory_Load(object sender, EventArgs e)
        {
            rad_newitem.Checked = true;
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if(rad_newitem.Checked)
            {
                new_item();
            }
            if(rad_delete.Checked)
            {
                remove_item();
            }
            if(rad_list_search.Checked)
            {
                list_search();
            }
            if(rad_newauthor.Checked)
            {
                new_author();
            }
            if(rad_newpublisher.Checked)
            {
                new_publisher();
            }
            if(rad_updateitem.Checked)
            {
                modify_item();
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To change your password, please login again with your old and new password", "Redirecting to the login menu");
            Form_Update_Password a = new Form_Update_Password();
            a.ShowDialog();
        }
    }
}
