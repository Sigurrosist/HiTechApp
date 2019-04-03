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
    public partial class Form_Save_New_Emp : Form
    {
        public Form_Save_New_Emp()
        {
            InitializeComponent();
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

        private void modifyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To change your password, please login again with your old and new password", "Redirecting to the login menu");
            Form_Update_Password a = new Form_Update_Password();
            a.ShowDialog();
        }
        private string[] positions = { "", "MIS Manager", "Sales Manager", "Inventory Controller", "Order Clerk", "Business Analysist", "Cleaner", "CEO", "Not Specified" };
        private string[] roles = { "", "MIS Manager", "Sales Manager", "Inventory Controller", "Order Clerk", "Business Analysist", "Cleaner", "CEO", "Not Specified" };
        private string[] salaries = { "", "38k", "39k", "41k", "42k", "43k", "44k", "45k", "46k", "47k", "48k", "49k", "50k", "51k", "52k", "53k", "54k" };
        private string[] status = { "", "On", "Off", "User", "Vacation" };
        private string[] possible_user = { "MIS Manager", "Sales Manager", "Inventory Controller", "Order Clerk" };
        private void Form_Save_New_Emp_Load(object sender, EventArgs e)
        {
            cbo_position_emp.DataSource = positions;
            cbo_salary_emp.DataSource = salaries;
            cbo_status_emp.DataSource = status;
            cbo_position_emp.Text = "";
            cbo_salary_emp.Text = "";
            cbo_status_emp.Text = "";

            txt_emp_id.ReadOnly = true;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            MISManager tolist = new MISManager();
            ListViewItem emplist;
            foreach (Employee list in tolist.Listed_Employees())
            {
                emplist = new ListViewItem(list.EID.ToString());
                emplist.SubItems.Add(list.FirstName + " " + list.LastName);
                emplist.SubItems.Add(list.Position);
                emp_listview.Items.Add(emplist);
            }
            txt_emp_id.Text = tolist.ID_Generator().ToString();
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

        private void btn_save_emp_Click(object sender, EventArgs e)
        {
            txt_emp_phone.Text = Validators.Valid_PhoneNumber(txt_emp_phone.Text);
            txt_emp_lname.Text = Validators.Valid_Name(txt_emp_lname.Text);
            txt_emp_fname.Text = Validators.Valid_Name(txt_emp_fname.Text);

            if (txt_emp_id.Text != "" && txt_emp_fname.Text != "" && txt_emp_address.Text != "" && txt_emp_lname.Text != "" && txt_emp_phone.Text != "")
            {
                Employee emp = new Employee();
                MISManager us = new MISManager();
                emp.EID = Convert.ToInt32(txt_emp_id.Text);
                emp.FirstName = txt_emp_fname.Text;
                emp.LastName = txt_emp_lname.Text;
                emp.Address = txt_emp_address.Text;
                emp.PhoneNumber = txt_emp_phone.Text;
                emp.Position = cbo_position_emp.Text;
                emp.Salary = cbo_salary_emp.Text;
                emp.Status = cbo_status_emp.Text;
                us.Save_New_Emp(emp);

                emp_listview.Items.Clear();
                ListViewItem emplist;
                foreach (Employee list in us.Listed_Employees())
                {
                    emplist = new ListViewItem(list.EID.ToString());
                    emplist.SubItems.Add(list.FirstName + " " + list.LastName);
                    emplist.SubItems.Add(list.Position);
                    emp_listview.Items.Add(emplist);
                }

                MessageBox.Show("New employee added. Please check the Employee list on the left side", "Completed");
            }
            else
            {
                MessageBox.Show("Please check all the information", "Missing Information");
                if (txt_emp_fname.Text == "")
                {
                    label2.ForeColor = Color.Red;
                }
                if(txt_emp_address.Text == "")
                {
                    label4.ForeColor = Color.Red;
                }
                if(txt_emp_lname.Text == "")
                {
                    label6.ForeColor = Color.Red;
                }
                if(txt_emp_phone.Text == "")
                {
                    label5.ForeColor = Color.Red;
                }
            }
        }
    }
}
