using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HCL.Business.Company;
using HCL.Business.Items;
using HCL.Business.People;
using HCL.Validation;

namespace HiTechApp.GUI
{
    public partial class Form_Save_New_User : Form
    {
        public Form_Save_New_User()
        {
            InitializeComponent();
        }
        private string[] roles = { "", "MIS Manager", "Sales Manager", "Inventory Controller", "Order Clerk", "Business Analysist", "Cleaner", "CEO", "Not Specified" };
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            int answer;
            answer = Convert.ToInt32(MessageBox.Show("Do you want to exit the program.", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (answer == 6)
            {
                this.Close();
            }
        }

        private void emp_listview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MISManager one = new MISManager();
            int id = Convert.ToInt32(emp_listview.SelectedItems[0].SubItems[0].Text);
            one.Searched_by_id(id);
            txt_user_id.Text = one.Searched_by_id(id).EID.ToString();
            cbo_user_role.Text = one.Searched_by_id(id).Position;
        }

        private void renew_lists()
        {
            emp_listview.Items.Clear();
            MISManager tolist = new MISManager();
            ListViewItem emplist;
            foreach (Employee list in tolist.Listed_Employees())
            {
                emplist = new ListViewItem(list.EID.ToString());
                emplist.SubItems.Add(list.FirstName + " " + list.LastName);
                emplist.SubItems.Add(list.Position);
                emp_listview.Items.Add(emplist);
            }
            user_listview.Items.Clear();
            ListViewItem userlist;
            foreach (User us in tolist.Listed_Users())
            {
                userlist = new ListViewItem(us.UID.ToString());
                if (us.Usercode == 1)
                { userlist.SubItems.Add("MIS Manager"); }
                if (us.Usercode == 2)
                { userlist.SubItems.Add("Sales Manager"); }
                if (us.Usercode == 3)
                { userlist.SubItems.Add("Inventory Controller"); }
                if (us.Usercode == 4)
                { userlist.SubItems.Add("Order Clerk"); }
                if (us.Usercode == 0)
                { userlist.SubItems.Add("Not Specified"); }
                user_listview.Items.Add(userlist);
            }
            cbo_user_role.DataSource = roles;
            rad_save.Checked = true;
        }
        private void Form_Save_New_User_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            rad_save.Checked = true;
            renew_lists();
        }

        private void user_listview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MISManager one = new MISManager();
            int id = Convert.ToInt32(user_listview.SelectedItems[0].SubItems[0].Text);
            one.Searched_by_id(id);
            txt_user_id.Text = one.Searched_by_id(id).EID.ToString();
            cbo_user_role.Text = one.Searched_by_id(id).Position;
        }

        private void btn_user_save_Click(object sender, EventArgs e)
        {
            MISManager henry = new MISManager();
            int code = 0;
            if (cbo_user_role.Text.Trim() == "MIS Manager")
            {
                code = 1;
            }
            if (cbo_user_role.Text.Trim() == "Sales Manager")
            {
                code = 2;
            }
            if (cbo_user_role.Text.Trim() == "Inventory Controller")
            {
                code = 3;
            }
            if (cbo_user_role.Text.Trim() == "Order Clerk")
            {
                code = 4;
            }
            else
            {
                code = 0;
            }

            if (rad_save.Checked)
            {
                if (henry.Searched_by_userid(txt_user_id.Text).UID == 0)
                {
                    User a = new User();
                    if (txt_user_id.Text != "" && cbo_user_role.Text != "")
                    {
                        a.UID = Convert.ToInt32(txt_user_id.Text);
                        a.Password = txt_user_id.Text;
                        a.Usercode = code;
                        henry.Save_New_User(a);
                        MessageBox.Show("New user : " + txt_user_id.Text + " is saved for the role : " + cbo_user_role.Text, "Saved");
                        renew_lists();
                    }
                    else
                    {
                        MessageBox.Show("Please check all information entered","Missing information");
                    }
                }
                else
                {
                    MessageBox.Show("The user is already in the user list : " + txt_user_id.Text, "Please Check again");
                }

            }
            if (rad_update.Checked)
            {
                if (henry.Searched_by_userid(txt_user_id.Text).UID == 0)
                {
                    MessageBox.Show("There is no information for this UserID : " + txt_user_id.Text ,"Please Check again");
                }
                else
                {
                    User a = new User();
                    a.UID = henry.Searched_by_userid(txt_user_id.Text).UID;
                    a.Password = henry.Searched_by_userid(txt_user_id.Text).Password;
                    a.Usercode = code;
                    henry.Update_Users(a);
                    string role = "";
                    if (a.Usercode == 1)
                    { role = "MIS Manager"; }
                    if (a.Usercode == 2)
                    { role = "Sales Manager"; }
                    if (a.Usercode == 3)
                    { role = "Inventory Controller"; }
                    if (a.Usercode == 4)
                    { role = "Order Clerk"; }
                    if (a.Usercode == 0)
                    { role = "Not Specified"; }
                    MessageBox.Show("Update Completed for user ID : " + a.UID + ".\nAssigned user code : " + role, "Updated");
                    renew_lists();
                }
            }
        }
    }
}
