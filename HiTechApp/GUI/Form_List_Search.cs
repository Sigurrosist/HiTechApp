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
    public partial class Form_List_Search : Form
    {
        public Form_List_Search()
        {
            InitializeComponent();
        }

        private void Form_List_Search_Load(object sender, EventArgs e)
        {
            radio_book.Checked = true;
            rad_item_id.Checked = true;
            rad_publisher_id.Checked = true;
            rad_author_id.Checked = true;
            author_list();
            publisher_list();
            cbo_type.Items.Add("Book");
            cbo_type.Items.Add("Software");
            cbo_type.Text = "Book";
        }
        private void book_list()
        {
            listView1.Items.Clear();
            InventoryController wang = new InventoryController();
            ListViewItem list;
            foreach (Book a in wang.Listed_Books())
            {
                list = new ListViewItem(a.ID);
                list.SubItems.Add(a.Title);
                list.SubItems.Add(a.AuthorID.Replace(",", " - "));
                list.SubItems.Add(a.Category);
                list.SubItems.Add(a.Type);
                list.SubItems.Add(a.Pub_Year);
                list.SubItems.Add(a.PubID);
                list.SubItems.Add(a.UnitPrice.ToString());
                list.SubItems.Add(a.ISBN10);
                list.SubItems.Add(a.ISBN13);
                list.SubItems.Add("N/A");
                list.SubItems.Add(a.Quantity.ToString());
                listView1.Items.Add(list);
            }
        }
        private void software_list()
        {
            listView1.Items.Clear();
            InventoryController wang = new InventoryController();
            ListViewItem list;
            foreach (Software a in wang.Listed_Software())
            {
                list = new ListViewItem(a.ID);
                list.SubItems.Add(a.Title);
                list.SubItems.Add(a.AuthorID.Replace(",", " - "));
                list.SubItems.Add(a.Category);
                list.SubItems.Add(a.Type);
                list.SubItems.Add(a.Pub_Year);
                list.SubItems.Add(a.PubID);
                list.SubItems.Add(a.UnitPrice.ToString());
                list.SubItems.Add("N/A");
                list.SubItems.Add("N/A");
                list.SubItems.Add(a.Software_Type);
                list.SubItems.Add(a.Quantity.ToString());
                listView1.Items.Add(list);
            }
        }
        private void author_list()
        {
            listView2.Items.Clear();
            ListViewItem writers = new ListViewItem();
            InventoryController wang = new InventoryController();
            foreach (Author i in wang.Listed_authors())
            {
                writers = new ListViewItem(i.AuthorID);
                writers.SubItems.Add(i.FirstName + ", " + i.LastName);
                writers.SubItems.Add(i.Email);
                listView2.Items.Add(writers);
            }
        }
        private void publisher_list()
        {
            listView3.Items.Clear();
            ListViewItem pubs = new ListViewItem();
            InventoryController wang = new InventoryController();
            foreach (Publisher i in wang.Listed_publishers())
            {
                pubs = new ListViewItem(i.PubID);
                pubs.SubItems.Add(i.Pub_Name);
                listView3.Items.Add(pubs);
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

        private void btn_item_search_Click(object sender, EventArgs e)
        {
            if (rad_item_id.Checked)
            {
                InventoryController wang = new InventoryController();
                if (wang.Searched_Book_by_ID(txt_item.Text.Trim()).ID != "" || wang.Searched_Software_by_ID(txt_item.Text.Trim()).ID != "")
                {
                    listView1.Items.Clear();
                    if (cbo_type.Text == "Book")
                    {
                        ListViewItem a = new ListViewItem(wang.Searched_Book_by_ID(txt_item.Text.Trim()).ID);
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_item.Text.Trim()).Title);
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_item.Text.Trim()).AuthorID);
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_item.Text.Trim()).Category);
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_item.Text.Trim()).Type);
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_item.Text.Trim()).Pub_Year);
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_item.Text.Trim()).PubID);
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_item.Text.Trim()).UnitPrice.ToString());
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_item.Text.Trim()).ISBN10);
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_item.Text.Trim()).ISBN13);
                        a.SubItems.Add("N/A");
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_item.Text.Trim()).Quantity.ToString());
                        listView1.Items.Add(a);
                    }
                    else
                    {
                        ListViewItem a = new ListViewItem(wang.Searched_Software_by_ID(txt_item.Text.Trim()).ID);
                        a.SubItems.Add(wang.Searched_Software_by_ID(txt_item.Text.Trim()).Title);
                        a.SubItems.Add(wang.Searched_Software_by_ID(txt_item.Text.Trim()).AuthorID);
                        a.SubItems.Add(wang.Searched_Software_by_ID(txt_item.Text.Trim()).Category);
                        a.SubItems.Add(wang.Searched_Software_by_ID(txt_item.Text.Trim()).Type);
                        a.SubItems.Add(wang.Searched_Software_by_ID(txt_item.Text.Trim()).Pub_Year);
                        a.SubItems.Add(wang.Searched_Software_by_ID(txt_item.Text.Trim()).PubID);
                        a.SubItems.Add(wang.Searched_Software_by_ID(txt_item.Text.Trim()).UnitPrice.ToString());
                        a.SubItems.Add("N/A");
                        a.SubItems.Add("N/A");
                        a.SubItems.Add(wang.Searched_Software_by_ID(txt_item.Text.Trim()).Software_Type);                        
                        a.SubItems.Add(wang.Searched_Book_by_ID(txt_item.Text.Trim()).Quantity.ToString());
                        listView1.Items.Add(a);
                    }
                    txt_item.Text = "";
                }
                else
                {
                    MessageBox.Show("There is no result with the ID that you entered.", "Please check again.");
                }
            }
            if (rad_item_title.Checked)
            {
                InventoryController wang = new InventoryController();
                listView1.Items.Clear();
                if (cbo_type.Text == "Book")
                {
                    ListViewItem a = new ListViewItem();
                    foreach (Book i in wang.Searched_Books_by_Title(txt_item.Text.Trim()))
                    {
                        a = new ListViewItem(i.ID);
                        a.SubItems.Add(i.Title);
                        a.SubItems.Add(i.AuthorID);
                        a.SubItems.Add(i.Category);
                        a.SubItems.Add(i.Type);
                        a.SubItems.Add(i.Pub_Year);
                        a.SubItems.Add(i.PubID);
                        a.SubItems.Add(i.UnitPrice.ToString());
                        a.SubItems.Add(i.ISBN10);
                        a.SubItems.Add(i.ISBN13);
                        a.SubItems.Add("N/A");
                        a.SubItems.Add(i.Quantity.ToString());
                        listView1.Items.Add(a);
                    }
                }
                else
                {
                    ListViewItem a = new ListViewItem();
                    foreach (Software i in wang.Searched_Software_by_Title(txt_item.Text.Trim()))
                    {
                        a = new ListViewItem(i.ID);
                        a.SubItems.Add(i.Title);
                        a.SubItems.Add(i.AuthorID);
                        a.SubItems.Add(i.Category);
                        a.SubItems.Add(i.Type);
                        a.SubItems.Add(i.Pub_Year);
                        a.SubItems.Add(i.PubID);
                        a.SubItems.Add(i.UnitPrice.ToString());
                        a.SubItems.Add("N/A");
                        a.SubItems.Add("N/A");
                        a.SubItems.Add(i.Software_Type);
                        a.SubItems.Add(i.Quantity.ToString());
                        listView1.Items.Add(a);
                    }
                    txt_item.Text = "";
                }
            }
            if(rad_pub_year.Checked)
            {
                InventoryController wang = new InventoryController();
                listView1.Items.Clear();
                if (cbo_type.Text == "Book")
                {
                    ListViewItem a = new ListViewItem();
                    foreach (Book i in wang.Searched_Books_by_PubYear(txt_item.Text.Trim()))
                    {
                        a = new ListViewItem(i.ID);
                        a.SubItems.Add(i.Title);
                        a.SubItems.Add(i.AuthorID);
                        a.SubItems.Add(i.Category);
                        a.SubItems.Add(i.Type);
                        a.SubItems.Add(i.Pub_Year);
                        a.SubItems.Add(i.PubID);
                        a.SubItems.Add(i.UnitPrice.ToString());
                        a.SubItems.Add(i.ISBN10);
                        a.SubItems.Add(i.ISBN13);
                        a.SubItems.Add("N/A");
                        a.SubItems.Add(i.Quantity.ToString());
                        listView1.Items.Add(a);
                    }
                }
                else
                {
                    ListViewItem a = new ListViewItem();
                    foreach (Software i in wang.Searched_Software_by_PubYear(txt_item.Text.Trim()))
                    {
                        a = new ListViewItem(i.ID);
                        a.SubItems.Add(i.Title);
                        a.SubItems.Add(i.AuthorID);
                        a.SubItems.Add(i.Category);
                        a.SubItems.Add(i.Type);
                        a.SubItems.Add(i.Pub_Year);
                        a.SubItems.Add(i.PubID);
                        a.SubItems.Add(i.UnitPrice.ToString());
                        a.SubItems.Add("N/A");
                        a.SubItems.Add("N/A");
                        a.SubItems.Add(i.Software_Type);
                        a.SubItems.Add(i.Quantity.ToString());
                        listView1.Items.Add(a);
                    }
                    txt_item.Text = "";
                }
            }
            if(rad_aid.Checked)
            {
                InventoryController wang = new InventoryController();
                listView1.Items.Clear();
                if (cbo_type.Text == "Book")
                {
                    ListViewItem a = new ListViewItem();
                    foreach (Book i in wang.Searched_Book_by_AuthorID(txt_item.Text.Trim()))
                    {
                        a = new ListViewItem(i.ID);
                        a.SubItems.Add(i.Title);
                        a.SubItems.Add(i.AuthorID);
                        a.SubItems.Add(i.Category);
                        a.SubItems.Add(i.Type);
                        a.SubItems.Add(i.Pub_Year);
                        a.SubItems.Add(i.PubID);
                        a.SubItems.Add(i.UnitPrice.ToString());
                        a.SubItems.Add(i.ISBN10);
                        a.SubItems.Add(i.ISBN13);
                        a.SubItems.Add("N/A");
                        a.SubItems.Add(i.Quantity.ToString());
                        listView1.Items.Add(a);
                    }
                }
                else
                {
                    ListViewItem a = new ListViewItem();
                    foreach (Software i in wang.Searched_Software_by_AuthorID(txt_item.Text.Trim()))
                    {
                        a = new ListViewItem(i.ID);
                        a.SubItems.Add(i.Title);
                        a.SubItems.Add(i.AuthorID);
                        a.SubItems.Add(i.Category);
                        a.SubItems.Add(i.Type);
                        a.SubItems.Add(i.Pub_Year);
                        a.SubItems.Add(i.PubID);
                        a.SubItems.Add(i.UnitPrice.ToString());
                        a.SubItems.Add("N/A");
                        a.SubItems.Add("N/A");
                        a.SubItems.Add(i.Software_Type);
                        a.SubItems.Add(i.Quantity.ToString());
                        listView1.Items.Add(a);
                    }
                    txt_item.Text = "";
                }
            }
        }

        private void btn_author_search_Click(object sender, EventArgs e)
        {
            InventoryController wang = new InventoryController();
            listView2.Items.Clear();
            ListViewItem a = new ListViewItem();
            if (rad_author_id.Checked)
            {
                a = new ListViewItem(wang.Searched_author_by_id(txt_author.Text.Trim()).AuthorID);
                a.SubItems.Add(wang.Searched_author_by_id(txt_author.Text.Trim()).FirstName + " " + wang.Searched_author_by_id(txt_author.Text.Trim()).LastName);
                a.SubItems.Add(wang.Searched_author_by_id(txt_author.Text.Trim()).Email);
                listView2.Items.Add(a);
            }
            else
            {
                foreach(Author i in wang.Searched_Authors_by_Name(txt_author.Text.Trim()))
                {
                    a = new ListViewItem(i.AuthorID);
                    a.SubItems.Add(i.FirstName + " " + i.LastName);
                    a.SubItems.Add(i.Email);
                    listView2.Items.Add(a);
                }
            }
        }

        private void btn_pub_search_Click(object sender, EventArgs e)
        {
            InventoryController wang = new InventoryController();
            listView3.Items.Clear();
            ListViewItem a = new ListViewItem();
            if (rad_publisher_id.Checked)
            {
                a = new ListViewItem(wang.Searched_publisher_by_id(txt_pub.Text.Trim()).PubID);
                a.SubItems.Add(wang.Searched_publisher_by_id(txt_pub.Text.Trim()).Pub_Name);
                listView3.Items.Add(a);
            }
            if (rad_publisher_name.Checked)
            {
                foreach (Publisher i in wang.Searched_Publishers_by_Name(txt_pub.Text.Trim()))
                {
                    a = new ListViewItem(i.PubID);
                    a.SubItems.Add(i.Pub_Name);
                    listView3.Items.Add(a);
                }
            }
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
        private void btn_exit_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit();
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

    }
}
