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
using HCL.Business.Order;
using HCL.Business.People;
using HCL.Business.Items;

namespace HiTechApp.GUI
{
    public partial class Form_Delete_Orders : Form
    {
        public Form_Delete_Orders()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            User a = new User();
            Clerk mary = new Clerk();
            MISManager finduser = new MISManager();
            a.Usercode = finduser.Searched_by_userid(txt_your_id.Text).Usercode;
            if (a.Valid_login(txt_your_id.Text, txt_password.Text) && a.Usercode == 4)
            {                
                if (mary.Searched_Order_by_ID(txt_item_id.Text).ClientID == txt_item_name.Text)
                {
                    int answer = Convert.ToInt32(MessageBox.Show("Do you really want to delete the information for " + txt_item_id.Text.Trim() + " : " + mary.Searched_Order_by_ID(txt_item_id.Text).ClientID + "?", "Check again", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                    if (answer == 6)
                    {
                        if (mary.Delete_Order(txt_item_id.Text))
                        {
                            MessageBox.Show("Deleted", "Done");
                        }
                        else
                        {
                            MessageBox.Show("Cannot find the order", "Try again");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Logon Denied", "Check again");
            }

        }
    }
}
