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
    public partial class Form_Sales : Form
    {
        public Form_Sales()
        {
            InitializeComponent();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int answer;
            answer = Convert.ToInt32(MessageBox.Show("Do you want to exit the program.", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (answer == 6)
            {
                this.Close();
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To change your password, please login again with your old and new password", "Redirecting to the login menu");
            Form_Update_Password a = new Form_Update_Password();
            a.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.ShowDialog();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if(rad_newclient.Checked)
            {
                Form_Save_New_Clients a = new Form_Save_New_Clients();
                a.ShowDialog();
            }
            if(rad_list_search_client.Checked)
            {
                Form_List_Search_Client a = new Form_List_Search_Client();
                a.ShowDialog();
            }
            if(rad_updateclient.Checked)
            {
                Form_Update_Clients a = new Form_Update_Clients();
                a.ShowDialog();
            }
        }

        private void Form_Sales_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            rad_newclient.Checked = true;
        }
    }
}
