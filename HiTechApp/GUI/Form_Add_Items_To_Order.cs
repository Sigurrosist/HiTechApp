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
using System.IO;

namespace HiTechApp.GUI
{
    public partial class Form_Add_Items_To_Order : Form
    {
        public Form_Add_Items_To_Order()
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

        private void book_list()
        {
            listview_search_item.Items.Clear();
            InventoryController wang = new InventoryController();
            ListViewItem list;
            foreach (Book a in wang.Listed_Books())
            {
                list = new ListViewItem(a.ID);
                list.SubItems.Add(a.Title);
                list.SubItems.Add(a.Type);
                list.SubItems.Add(a.UnitPrice.ToString());
                list.SubItems.Add(a.Quantity.ToString());
                listview_search_item.Items.Add(list);
            }
        }
        private void software_list()
        {
            listview_search_item.Items.Clear();
            InventoryController wang = new InventoryController();
            ListViewItem list;
            foreach (Software a in wang.Listed_Software())
            {
                list = new ListViewItem(a.ID);
                list.SubItems.Add(a.Title);
                list.SubItems.Add(a.Type);
                list.SubItems.Add(a.UnitPrice.ToString());
                list.SubItems.Add(a.Quantity.ToString());
                listview_search_item.Items.Add(list);
            }
        }
        private void Form_Add_Items_To_Order_Load(object sender, EventArgs e)
        {
            radio_book.Checked = true;
            cbo_type.Items.Add("Book");
            cbo_type.Items.Add("Software");
            cbo_type.Text = "Book";
            rad_item_id.Checked = true;
            if (File.Exists(@"C:\JooyeonMok_HCL_FinalProject\Adding_Items_List.dat"))
            {
                ListViewItem l = new ListViewItem();
                Clerk mary = new Clerk();
                InventoryController wang = new InventoryController();
                string toadd = mary.Read_Added_Items_List();
                if (toadd.Contains('+'))
                {
                    string[] field = toadd.Split('+');
                    foreach (string i in field)
                    {
                        string[] col = i.Split(',');
                        l = new ListViewItem(col[0]);
                        if (wang.Is_It_a_Book(col[0]))
                        {
                            l.SubItems.Add(wang.Searched_Book_by_ID(col[0]).Title);
                        }
                        else
                        {
                            l.SubItems.Add(wang.Searched_Software_by_ID(col[0]).Title);
                        }
                        l.SubItems.Add(col[1]);
                        l.SubItems.Add(col[2]);
                        listview_added_items.Items.Add(l);
                    }
                }
                else
                {
                    string[] col = toadd.Split(',');
                    l = new ListViewItem(col[0]);
                    if (wang.Is_It_a_Book(col[0]))
                    {
                        l.SubItems.Add(wang.Searched_Book_by_ID(col[0]).Title);
                    }
                    else
                    {
                        l.SubItems.Add(wang.Searched_Software_by_ID(col[0]).Title);
                    }
                    l.SubItems.Add(col[1]);
                    l.SubItems.Add(col[2]);
                    listview_added_items.Items.Add(l);
                }
            }
        }

        private void radio_book_CheckedChanged(object sender, EventArgs e)
        {
            book_list();
        }

        private void radio_software_CheckedChanged(object sender, EventArgs e)
        {
            software_list();
        }

        private void listview_search_item_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            InventoryController one = new InventoryController();
            string type = listview_search_item.SelectedItems[0].SubItems[2].Text;
            string id = listview_search_item.SelectedItems[0].SubItems[0].Text;
            if (type == "Book")
            {
                txt_itemid.Text = one.Searched_Book_by_ID(id).ID;
                txt_title.Text = one.Searched_Book_by_ID(id).Title;
                txt_type.Text = one.Searched_Book_by_ID(id).Type;
            }
            if (type == "Software")
            {
                txt_itemid.Text = one.Searched_Software_by_ID(id).ID;
                txt_title.Text = one.Searched_Software_by_ID(id).Title;
                txt_type.Text = one.Searched_Software_by_ID(id).Type;         
            }
        }

        private void btn_item_search_Click(object sender, EventArgs e)
        {
            if (rad_item_id.Checked)
            {
                InventoryController wang = new InventoryController();
                if (wang.Searched_Book_by_ID(txt_key.Text.Trim()).ID != "" || wang.Searched_Software_by_ID(txt_key.Text.Trim()).ID != "")
                {
                    listview_search_item.Items.Clear();
                    if (cbo_type.Text == "Book")
                    {
                        ListViewItem a = new ListViewItem(wang.Searched_Book_by_ID(txt_key.Text.Trim()).ID);
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_key.Text.Trim()).Title);
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_key.Text.Trim()).Type);
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_key.Text.Trim()).UnitPrice.ToString());
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_key.Text.Trim()).Quantity.ToString());
                        listview_search_item.Items.Add(a);
                    }
                    else
                    {
                        ListViewItem a = new ListViewItem(wang.Searched_Software_by_ID(txt_key.Text.Trim()).ID);
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_key.Text.Trim()).Title);
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_key.Text.Trim()).Type);
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_key.Text.Trim()).UnitPrice.ToString());
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_key.Text.Trim()).Quantity.ToString());
                        listview_search_item.Items.Add(a);
                    }
                    txt_key.Text = "";
                }
                else
                {
                    MessageBox.Show("There is no result with the ID that you entered.", "Please check again.");
                }
            }
            if (rad_item_title.Checked)
            {
                InventoryController wang = new InventoryController();
                listview_search_item.Items.Clear();
                if (cbo_type.Text == "Book")
                {
                    ListViewItem a = new ListViewItem();
                    foreach (Book i in wang.Searched_Books_by_Title(txt_key.Text.Trim()))
                    {
                        a = new ListViewItem(i.ID);
                        a.SubItems.Add(i.Title);                      
                        a.SubItems.Add(i.Type);
                        a.SubItems.Add(i.UnitPrice.ToString());
                        a.SubItems.Add(i.Quantity.ToString());
                        listview_search_item.Items.Add(a);
                    }
                }
                else
                {
                    ListViewItem a = new ListViewItem();
                    foreach (Software i in wang.Searched_Software_by_Title(txt_key.Text.Trim()))
                    {
                        a = new ListViewItem(i.ID);
                        a.SubItems.Add(i.Title);
                        a.SubItems.Add(i.Type);
                        a.SubItems.Add(i.UnitPrice.ToString());
                        a.SubItems.Add(i.Quantity.ToString());
                        listview_search_item.Items.Add(a);
                    }
                    txt_key.Text = "";
                }
            }       
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            InventoryController wang = new InventoryController();
            SalesManager peter = new SalesManager();
            try
            {
                if (txt_type.Text == "Book")
                {
                    if (wang.Searched_Book_by_ID(txt_itemid.Text).ID != "" && wang.Searched_Book_by_ID(txt_itemid.Text).Quantity >= Convert.ToInt32(cbo_quantity.Text))
                    {
                        ListViewItem a = new ListViewItem(txt_itemid.Text);
                        a.SubItems.Add(txt_title.Text);
                        a.SubItems.Add(cbo_quantity.Text);
                        double total = wang.Searched_Book_by_ID(txt_itemid.Text).UnitPrice * Convert.ToInt32(cbo_quantity.Text);
                        a.SubItems.Add(total.ToString());
                        listview_added_items.Items.Add(a);
                    }
                    else
                    {
                        MessageBox.Show("There are not enough items in the inventory. The current quantity for this item is : " + wang.Searched_Book_by_ID(txt_itemid.Text).Quantity.ToString(), "Inventory Issue!");
                    }
                }
                if (txt_type.Text == "Software")
                {
                    if (wang.Searched_Software_by_ID(txt_itemid.Text).ID != "" && wang.Searched_Software_by_ID(txt_itemid.Text).Quantity >= Convert.ToInt32(cbo_quantity.Text))
                    {
                        ListViewItem a = new ListViewItem(txt_itemid.Text);
                        a.SubItems.Add(txt_title.Text);
                        a.SubItems.Add(cbo_quantity.Text);
                        double total = wang.Searched_Software_by_ID(txt_itemid.Text).UnitPrice * Convert.ToInt32(cbo_quantity.Text);
                        a.SubItems.Add(total.ToString());
                        listview_added_items.Items.Add(a);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please choose the item to add", "No item selected to add");
            }
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listview_added_items.Items)
            {
                if (item.Selected)
                    listview_added_items.Items.Remove(item);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string toadd = "";
                foreach (ListViewItem item in listview_added_items.Items)
                {
                    toadd += item.Text + "," + item.SubItems[2].Text + "," + item.SubItems[3].Text + "+";
                }
                Clerk mary = new Clerk();
                toadd = toadd.Remove(toadd.Length - 1);
                mary.Write_Added_Items_List(toadd);
                this.Close();
            }
            catch
            {
                MessageBox.Show("No item to be saved","Please choose items");
            }
        }
    }
}
