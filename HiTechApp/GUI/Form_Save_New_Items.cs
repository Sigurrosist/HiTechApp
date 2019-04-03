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
    public partial class Form_Save_New_Items : Form
    {
        public Form_Save_New_Items()
        {
            InitializeComponent();
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
        private void reset_lbl_color()
        {
            label1.ForeColor = Color.Black;
            label11.ForeColor = Color.Black;
            label12.ForeColor = Color.Black;
            label13.ForeColor = Color.Black;
            label14.ForeColor = Color.Black;
            label15.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            lbl_id.ForeColor = Color.Black;
            lbl_isbn10.ForeColor = Color.Black;
            lbl_isbn13.ForeColor = Color.Black;
            lbl_software.ForeColor = Color.Black;
        }
        private void reset_inputs()
        {
            InventoryController wang = new InventoryController();
            foreach (Author i in wang.Listed_authors())
            {
                cbo_author1.Items.Add(i.AuthorID + " : " + i.FirstName + " " + i.LastName);
            }
            
            cbo_author1.Items.Add("Select to add");
            cbo_author1.Text = "Select to add";
            foreach (Publisher i in wang.Listed_publishers())
            {
                cbo_publisher.Items.Add(i.PubID + " : " + i.Pub_Name);
                cbo_publisher.Text = i.PubID + " : " + i.Pub_Name;
            }
            string[] cat = { "Programming Language", "Application", "For Beginner", "For developer", "Manual" };
            string[] type = { "Book", "Software" };
            string[] year = { "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020" };
            string[] s_type = { "USB", "CD", "DVD", "Floppy Disk" };
            cbo_category.DataSource = cat;
            cbo_category.Text = "For Beginner";
            cbo_itemtype.DataSource = type;
            cbo_itemtype.Text = "Book";
            cbo_pubyear.DataSource = year;
            cbo_pubyear.DropDownHeight = 100;
            cbo_pubyear.Text = "2017";
            cbo_s_type.DataSource = s_type;
            cbo_s_type.Text = "USB";
            txt_quantity.Text = "";
            txt_isbn10.Text = "";
            txt_isbn13.Text = "";
            txt_price.Text = "";
            txt_title.Text = "";
            radio_book.Checked = true;
            lbl_id.Text = wang.Item_ID_Generator();
        }
        private string only_digits(string id)
        {
            string a;
            a = Regex.Match(id, @"\d+").Value;
            return a;
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
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.ShowDialog();
        }
        private void Form_Save_New_Items_Load(object sender, EventArgs e)
        {
            reset_inputs();
        }
        private void radio_book_CheckedChanged(object sender, EventArgs e)
        {
            book_list();
        }
        private void radio_software_CheckedChanged(object sender, EventArgs e)
        {
            software_list();
        }
        private void cbo_author1_MouseClick(object sender, MouseEventArgs e)
        {
            cbo_author1.Items.Clear();
            InventoryController wang = new InventoryController();
            foreach (Author i in wang.Listed_authors())
            {
                cbo_author1.Items.Add(i.AuthorID + " : " + i.FirstName + " " + i.LastName);
            }

            cbo_author1.Items.Add("Select to add");
            cbo_author1.Text = "Select to add";
        }
        private void cbo_publisher_MouseClick_1(object sender, MouseEventArgs e)
        {
            cbo_publisher.Items.Clear();
            InventoryController wang = new InventoryController();
            foreach (Publisher i in wang.Listed_publishers())
            {
                cbo_publisher.Items.Add(i.PubID + " : " + i.Pub_Name);
                cbo_publisher.Text = i.PubID + " : " + i.Pub_Name;
            }
        }
        private void btn_thisauthor_Click(object sender, EventArgs e)
        {
            if (!lbl_authors.Text.Contains(only_digits(cbo_author1.Text)))
            {
                if (lbl_authors.Text == "")
                {
                    lbl_authors.Text = only_digits(cbo_author1.Text);
                }
                else
                {
                    lbl_authors.Text += " " + only_digits(cbo_author1.Text);
                }
            }
            else
            {
                MessageBox.Show("The author already exists in the author list for item", "Please check again");
            }
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (lbl_authors.Text.Contains(only_digits(cbo_author1.Text)))
            {
                int answer;
                answer = Convert.ToInt32(MessageBox.Show("Do you want to delete this author information for this item.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (answer == 6)
                {
                    if (cbo_author1.Text != "Select to add")
                    {
                        lbl_authors.Text.Trim();
                        string replace = lbl_authors.Text.Replace(only_digits(cbo_author1.Text), "");
                        lbl_authors.Text = replace;
                    }
                    else
                    {
                        MessageBox.Show("No information to delete", "Please check again");
                    }
                }
                else
                {
                    MessageBox.Show("Select an author to remove from the item", "Please check again");
                }
                
            }
            else
            {
                MessageBox.Show("This item does not have the selected author", "Please check again");
            }
        }
        private void btn_newauthor_Click(object sender, EventArgs e)
        {
            Form_Add_new_author a = new Form_Add_new_author();
            a.ShowDialog();
        }
        private void btn_newpublisher_Click(object sender, EventArgs e)
        {
            Form_Add_New_Publisher a = new Form_Add_New_Publisher();
            a.ShowDialog();
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
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cbo_itemtype.Text == "Book")
            {
                if (txt_title.Text != "" && Validators.Valid_digit(txt_price.Text) != "" && Validators.Valid_10_Digits(txt_isbn10.Text.Trim()) != "" && Validators.Valid_13_Digits(txt_isbn13.Text) != "" && Validators.Valid_digit(txt_quantity.Text) != "" && lbl_authors.Text.Trim() != "")
                {
                    txt_isbn10.Text = Validators.Valid_10_Digits(txt_isbn10.Text);
                    txt_isbn13.Text = Validators.Valid_13_Digits(txt_isbn13.Text);
                    cbo_author1.Text = only_digits(cbo_author1.Text);
                    txt_title.Text = txt_title.Text;
                    Book a = new Book();
                    a.ID = lbl_id.Text;
                    a.Title = txt_title.Text;
                    a.AuthorID = lbl_authors.Text.Trim();
                    a.Category = cbo_category.Text;
                    a.Type = cbo_itemtype.Text;
                    a.Pub_Year = cbo_pubyear.Text;
                    a.PubID = only_digits(cbo_publisher.Text);
                    a.UnitPrice = Convert.ToDouble(txt_price.Text.Trim());
                    a.Quantity = Convert.ToInt32(txt_quantity.Text.Trim());
                    a.ISBN10 = txt_isbn10.Text;
                    a.ISBN13 = txt_isbn13.Text;

                    InventoryController wang = new InventoryController();
                    wang.Save_New_Book(a);
                    book_list();
                    reset_inputs();
                    MessageBox.Show("Saved. Please see the list below.");
                }
                else
                {
                    MessageBox.Show("Please make sure all the information that you have entered is correct.", "Check again");
                    reset_lbl_color();
                    if (lbl_authors.Text == "")
                    {
                        label4.ForeColor = Color.Red;
                    }
                    if (txt_quantity.Text == "")
                    {
                        label2.ForeColor = Color.Red;
                    }
                    if (txt_isbn10.Text == "")
                    {
                        lbl_isbn10.ForeColor = Color.Red;
                    }
                    if (txt_isbn13.Text == "")
                    {
                        lbl_isbn13.ForeColor = Color.Red;
                    }
                    if (txt_price.Text == "")
                    {
                        label11.ForeColor = Color.Red;
                    }
                    if (txt_title.Text == "")
                    {
                        label6.ForeColor = Color.Red;
                    }
                }
            }
            if (cbo_itemtype.Text == "Software")
            {
                if (txt_title.Text != "" && Validators.Valid_digit(txt_price.Text) != "" && Validators.Valid_digit(txt_quantity.Text) != "" && lbl_authors.Text.Trim() != "")
                {
                    cbo_author1.Text = only_digits(cbo_author1.Text);
                    txt_title.Text = txt_title.Text;
                    Software a = new Software();
                    a.ID = lbl_id.Text;
                    a.Title = txt_title.Text;
                    a.AuthorID = lbl_authors.Text.Trim();
                    a.Category = cbo_category.Text;
                    a.Type = cbo_itemtype.Text;
                    a.Pub_Year = cbo_pubyear.Text;
                    a.PubID = only_digits(cbo_publisher.Text);
                    a.UnitPrice = Convert.ToDouble(txt_price.Text.Trim());
                    a.Quantity = Convert.ToInt32(txt_quantity.Text.Trim());
                    a.Software_Type = cbo_s_type.Text;

                    InventoryController wang = new InventoryController();
                    wang.Save_New_Software(a);
                    reset_inputs();
                    radio_software.Checked = true;
                    MessageBox.Show("Saved. Please see the list below.");
                }
                else
                {
                    MessageBox.Show("Please make sure all the information that you have entered is correct.", "Check again");
                    reset_lbl_color();
                    if (lbl_authors.Text == "")
                    {
                        label4.ForeColor = Color.Red;
                    }
                    if (txt_quantity.Text == "")
                    {
                        label2.ForeColor = Color.Red;
                    }
                    if (txt_isbn10.Text == "")
                    {
                        lbl_isbn10.ForeColor = Color.Red;
                    }
                    if (txt_isbn13.Text == "")
                    {
                        lbl_isbn13.ForeColor = Color.Red;
                    }
                    if (txt_price.Text == "")
                    {
                        label6.ForeColor = Color.Red;
                    }
                    if (txt_title.Text == "")
                    {
                        label7.ForeColor = Color.Red;
                    }
                    if (label11.Text == "")
                    {
                        label11.ForeColor = Color.Red;
                    }
                }
            }
        }
        private void cbo_itemtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_itemtype.SelectedIndex == 0)
            {
                cbo_s_type.Visible = false;
                lbl_software.Visible = false;
                txt_isbn10.Visible = true;
                txt_isbn13.Visible = true;
                lbl_isbn10.Visible = true;
                lbl_isbn13.Visible = true;
            }
            if (cbo_itemtype.SelectedIndex == 1)
            {
                lbl_isbn10.Visible = false;
                lbl_isbn13.Visible = false;
                txt_isbn10.Visible = false;
                txt_isbn13.Visible = false;
                cbo_s_type.Visible = true;
                lbl_software.Visible = true;
            }
        }
    }
}
