using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HCL.Business.Company;
using HCL.Business.Items;
using HCL.Business.Order;
using HCL.Business.People;
using HCL.Validation;

namespace HiTechApp.GUI
{
    public partial class Form_LogIn : Form
    {
        public Form_LogIn()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            MISManager henry = new MISManager();
            if (henry.Valid_login(txt_id.Text.Trim(), txt_password.Text.Trim()))
            {
                User loginuser = new User();
                loginuser.Usercode = henry.Searched_by_userid(txt_id.Text.Trim()).Usercode;
                if (loginuser.Usercode == 1)
                {
                    Form_MIS a = new Form_MIS();
                    a.ShowDialog();
                }
                if (loginuser.Usercode == 2)
                {
                    Form_Sales a = new Form_Sales();
                    a.ShowDialog();
                }
                if(loginuser.Usercode == 3)
                {
                    Form_Inventory a = new Form_Inventory();
                    a.ShowDialog();
                }
                if(loginuser.Usercode == 4)
                {
                    Form_OrderClerk a = new Form_OrderClerk();
                    a.ShowDialog();
                }
                else
                {
                    MessageBox.Show("This user is currently not having any roles for the system", "No roles indecated - Check with MIS Manager");
                }
                txt_id.Text = "";
                txt_password.Text = "";
            }
            else
            {
                MessageBox.Show("Login Denied","Check it again");
            }
        }

        private void Form_LogIn_Load(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
            DataFileCopy();
        }

        private static void DataFileCopy()
        {
            string datainfofoldersource = Application.StartupPath + "\\Data File" + "\\JooyeonMok_HCL_FinalProject";
            string datainfofolderinstall = @"C:\JooyeonMok_HCL_FinalProject";
            DirectoryInfo dir = new DirectoryInfo(datainfofoldersource);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                MessageBox.Show("Data Folder does not exist or could not be found: /n" + datainfofoldersource);
            }

            if (!Directory.Exists(datainfofolderinstall)) 
            {
                Directory.CreateDirectory(datainfofolderinstall);
                FileInfo[] data = dir.GetFiles();
                foreach (FileInfo file in data)
                {
                    string temppath = Path.Combine(datainfofolderinstall, file.Name);
                    file.CopyTo(temppath, false);
                }
            }
        }
        private void btb_cancel_Click(object sender, EventArgs e)
        {
            int answer;
            answer = Convert.ToInt32(MessageBox.Show("Do you want to exit the program?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (answer == 6)
            {
                this.Close();
            }
        }
    }
}
