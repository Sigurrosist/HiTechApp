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
    public partial class Form_Add_new_author : Form
    {
        public Form_Add_new_author()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Form_Inventory a = new Form_Inventory();
            MessageBox.Show("Please find the added author in the author list.","Go back to the Item Save Menu");
            this.Hide();
            a.ShowDialog();
        }
    }
}
