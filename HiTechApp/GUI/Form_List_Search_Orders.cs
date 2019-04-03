using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using HCL.Business.Company;
using HCL.Business.Order;
using HCL.Business.People;
using HCL.Business.Items;

namespace HiTechApp.GUI
{
    public partial class Form_List_Search_Orders : Form
    {
        public Form_List_Search_Orders()
        {
            InitializeComponent();
        }

        private void Form_List_Search_Orders_Load(object sender, EventArgs e)
        {
            Clerk mary = new Clerk();
            mary.Bring_New_Order_Status();
            ListViewItem list;
            foreach (Order_Client a in mary.Listed_Orders())
            {
                list = new ListViewItem(a.OrderID);
                list.SubItems.Add(a.ClientID);
                list.SubItems.Add(a.OrderMethod);
                list.SubItems.Add(a.Payment_status);
                list.SubItems.Add(a.ShippingDate);
                list.SubItems.Add(a.ExpectedDate);
                list.SubItems.Add(a.OrderClerkID);
                listview_orders.Items.Add(list);
            }
            cbo_target.Visible = false;
            btn_search.Visible = false;
            datepicker.Visible = false;
            rad_book.Visible = false;
            rad_software.Visible = false;
            string[] search_methods = { "Order ID", "Client ID", "Included Item", "Payment Status",  "Order Method", "Shipping Date", "Expected Date", "Order Clerk ID"};
            cbo_search_method.DataSource = search_methods;
        }

        private void listview_orders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clerk mary = new Clerk();
            listview_addeditem.Items.Clear();
            txt_order_status.Text = "";
            mary.Bring_New_Order_Status();
            read_new_order_status();
            ListViewItem l = new ListViewItem();
            double tps = 0;
            double tvq = 0;
            double subtotal = 0;
            double total = 0;
            string toadd = mary.Searched_Order_by_ID(listview_orders.SelectedItems[0].SubItems[0].Text).ItemList;
            string[] field = toadd.Split('+');
            foreach (string i in field)
            {
                string[] col = i.Split(',');
                l = new ListViewItem(col[0]);
                l.SubItems.Add(col[1]);
                l.SubItems.Add(col[2]);
                listview_addeditem.Items.Add(l);
                subtotal = subtotal + Convert.ToDouble(col[2]);
            }
            subtotal = Math.Round(subtotal, 2);
            tps = subtotal * 0.05;
            tps = Math.Round(tps, 2);
            tvq = subtotal * 0.09775;
            tvq = Math.Round(tvq, 2);
            total = tps + tvq + subtotal;

            string target = "";
            string replace = "";
            target = "Client";
            replace = "- Client : " + listview_orders.SelectedItems[0].SubItems[1].Text;
            mary.Refresh_Order_Status(target, replace);
            target = "Order Method";
            replace = "- Order Method : " + listview_orders.SelectedItems[0].SubItems[2].Text;
            mary.Refresh_Order_Status(target, replace);
            target = "Payment Status";
            replace = "- Payment Status : " + listview_orders.SelectedItems[0].SubItems[3].Text;
            mary.Refresh_Order_Status(target, replace);
            target = "Expected";
            replace = "- Expected Date : " + listview_orders.SelectedItems[0].SubItems[5].Text;
            mary.Refresh_Order_Status(target, replace);
            target = "Shipping";
            replace = "- Shipping Date : " + listview_orders.SelectedItems[0].SubItems[4].Text;
            mary.Refresh_Order_Status(target, replace);
            target = "Clerk";
            replace = "- Order Clerk ID : " + listview_orders.SelectedItems[0].SubItems[6].Text;
            mary.Refresh_Order_Status(target, replace);
            target = "- Order ID :";
            replace = "- Order ID : " + listview_orders.SelectedItems[0].SubItems[0].Text;
            mary.Refresh_Order_Status(target, replace);
            mary.Add_Item_List(toadd, tps.ToString(), tvq.ToString(), subtotal.ToString(), total.ToString());
            read_new_order_status();
        }
        private void read_new_order_status()
        {
            Clerk mary = new Clerk();
            txt_order_status.Text = "";
            foreach (string i in mary.Read_Order_Status())
            {
                txt_order_status.Text += i + Environment.NewLine;
            }
        }

        private void rad_book_CheckedChanged(object sender, EventArgs e)
        {
            cbo_target.Items.Clear();
            if (rad_book.Visible)
            {
                InventoryController wang = new InventoryController();
                foreach (Book i in wang.Listed_Books())
                {
                    cbo_target.Items.Add(i.ID + " : " + i.Title);
                }
                cbo_target.Visible = true;
            }
        }

        private void rad_software_CheckedChanged(object sender, EventArgs e)
        {
            cbo_target.Items.Clear();
            if (rad_software.Visible)
            {
                InventoryController wang = new InventoryController();
                foreach (Software i in wang.Listed_Software())
                {
                    cbo_target.Items.Add(i.ID + " : " + i.Title);
                }
                cbo_target.Visible = true;
            }
        }

        private void cbo_target_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_target.Visible)
            {
                btn_search.Visible = true;
            }
        }

        private string only_digits(string whatever)
        {
            whatever = Regex.Match(whatever, @"\d+").Value;
            return whatever;
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            ListViewItem list;
            Clerk mary = new Clerk();
            txt_order_status.Text = "";
            mary.Bring_New_Order_Status();
            listview_addeditem.Items.Clear();
            if (cbo_search_method.Text == "Order ID")
            {
                listview_orders.Items.Clear();
                list = new ListViewItem(mary.Searched_Order_by_ID(cbo_target.Text).OrderID);
                list.SubItems.Add(mary.Searched_Order_by_ID(cbo_target.Text).ClientID);
                list.SubItems.Add(mary.Searched_Order_by_ID(cbo_target.Text).OrderMethod);
                list.SubItems.Add(mary.Searched_Order_by_ID(cbo_target.Text).Payment_status);
                list.SubItems.Add(mary.Searched_Order_by_ID(cbo_target.Text).ShippingDate);
                list.SubItems.Add(mary.Searched_Order_by_ID(cbo_target.Text).ExpectedDate);
                list.SubItems.Add(mary.Searched_Order_by_ID(cbo_target.Text).OrderClerkID);
                listview_orders.Items.Add(list);
            }
            if (cbo_search_method.Text == "Client ID")
            {
                listview_orders.Items.Clear();
                foreach (Order_Client a in mary.Search_Orders_by_ClientID(only_digits(cbo_target.Text)))
                {
                    list = new ListViewItem(a.OrderID);
                    list.SubItems.Add(a.ClientID);
                    list.SubItems.Add(a.OrderMethod);
                    list.SubItems.Add(a.Payment_status);
                    list.SubItems.Add(a.ShippingDate);
                    list.SubItems.Add(a.ExpectedDate);
                    list.SubItems.Add(a.OrderClerkID);
                    listview_orders.Items.Add(list);
                }
            }
            if (cbo_search_method.Text == "Included Item")
            {
                listview_orders.Items.Clear();
                foreach (Order_Client a in mary.Searched_Orders_by_Included_Item(only_digits(cbo_target.Text)))
                {
                    list = new ListViewItem(a.OrderID);
                    list.SubItems.Add(a.ClientID);
                    list.SubItems.Add(a.OrderMethod);
                    list.SubItems.Add(a.Payment_status);
                    list.SubItems.Add(a.ShippingDate);
                    list.SubItems.Add(a.ExpectedDate);
                    list.SubItems.Add(a.OrderClerkID);
                    listview_orders.Items.Add(list);
                }
            }
            if (cbo_search_method.Text == "Payment Status")
            {
                listview_orders.Items.Clear();
                foreach (Order_Client a in mary.Searched_Orders_by_Payment_Status(cbo_target.Text))
                {
                    list = new ListViewItem(a.OrderID);
                    list.SubItems.Add(a.ClientID);
                    list.SubItems.Add(a.OrderMethod);
                    list.SubItems.Add(a.Payment_status);
                    list.SubItems.Add(a.ShippingDate);
                    list.SubItems.Add(a.ExpectedDate);
                    list.SubItems.Add(a.OrderClerkID);
                    listview_orders.Items.Add(list);
                }
            }
            if (cbo_search_method.Text == "Order Method")
            {
                listview_orders.Items.Clear();
                foreach (Order_Client a in mary.Searched_Orders_by_Order_Method(cbo_target.Text))
                {
                    list = new ListViewItem(a.OrderID);
                    list.SubItems.Add(a.ClientID);
                    list.SubItems.Add(a.OrderMethod);
                    list.SubItems.Add(a.Payment_status);
                    list.SubItems.Add(a.ShippingDate);
                    list.SubItems.Add(a.ExpectedDate);
                    list.SubItems.Add(a.OrderClerkID);
                    listview_orders.Items.Add(list);
                }
            }
            if (cbo_search_method.Text == "Shipping Date")
            {
                listview_orders.Items.Clear();
                foreach (Order_Client a in mary.Searched_Orders_by_Shipping_Date(datepicker.Text))
                {
                    list = new ListViewItem(a.OrderID);
                    list.SubItems.Add(a.ClientID);
                    list.SubItems.Add(a.OrderMethod);
                    list.SubItems.Add(a.Payment_status);
                    list.SubItems.Add(a.ShippingDate);
                    list.SubItems.Add(a.ExpectedDate);
                    list.SubItems.Add(a.OrderClerkID);
                    listview_orders.Items.Add(list);
                }
            }
            if (cbo_search_method.Text == "Expected Date")
            {
                listview_orders.Items.Clear();
                foreach (Order_Client a in mary.Searched_Orders_by_Expected_Date(datepicker.Text))
                {
                    list = new ListViewItem(a.OrderID);
                    list.SubItems.Add(a.ClientID);
                    list.SubItems.Add(a.OrderMethod);
                    list.SubItems.Add(a.Payment_status);
                    list.SubItems.Add(a.ShippingDate);
                    list.SubItems.Add(a.ExpectedDate);
                    list.SubItems.Add(a.OrderClerkID);
                    listview_orders.Items.Add(list);
                }
            }
            if (cbo_search_method.Text == "Order Clerk ID")
            {
                listview_orders.Items.Clear();
                foreach (Order_Client a in mary.Searched_Orders_by_Order_Clerk_ID(cbo_target.Text))
                {
                    list = new ListViewItem(a.OrderID);
                    list.SubItems.Add(a.ClientID);
                    list.SubItems.Add(a.OrderMethod);
                    list.SubItems.Add(a.Payment_status);
                    list.SubItems.Add(a.ShippingDate);
                    list.SubItems.Add(a.ExpectedDate);
                    list.SubItems.Add(a.OrderClerkID);
                    listview_orders.Items.Add(list);
                }
            }
        }

        private void cbo_search_method_TextChanged(object sender, EventArgs e)
        {
            Clerk mary = new Clerk();
            cbo_target.Items.Clear();
            cbo_target.Text = null;
            if (cbo_search_method.Text == "Order ID")
            {
                cbo_target.Visible = false;
                btn_search.Visible = false;
                datepicker.Visible = false;
                rad_book.Visible = false;
                rad_software.Visible = false;
                lbl_target.Text = "Order ID ::";
                foreach (string i in mary.Order_ID_List())
                {
                    cbo_target.Items.Add(i);
                }
                cbo_target.Visible = true;
            }
            if (cbo_search_method.Text == "Client ID")
            {
                cbo_target.Visible = false;
                btn_search.Visible = false;
                datepicker.Visible = false;
                rad_book.Visible = false;
                rad_software.Visible = false;
                lbl_target.Text = "Client ID ::";
                foreach (Institute i in mary.List_Client())
                {
                    cbo_target.Items.Add(i.Id + " : " + i.Name);
                }
                cbo_target.Visible = true;
            }
            if (cbo_search_method.Text == "Included Item")
            {
                cbo_target.Visible = false;
                btn_search.Visible = false;
                datepicker.Visible = false;
                rad_book.Visible = true;
                rad_software.Visible = true;
                lbl_target.Text = "Item ID ::";
                rad_book.Checked = true;
            }
            if (cbo_search_method.Text == "Payment Status")
            {
                cbo_target.Visible = false;
                btn_search.Visible = false;
                datepicker.Visible = false;
                rad_book.Visible = false;
                rad_software.Visible = false;
                lbl_target.Text = "Payment Status ::";
                cbo_target.Items.Add("Received");
                cbo_target.Items.Add("Waiting");
                cbo_target.Items.Add("Delayed");
                cbo_target.Visible = true;
            }
            if (cbo_search_method.Text == "Order Method")
            {
                cbo_target.Visible = false;
                btn_search.Visible = false;
                datepicker.Visible = false;
                rad_book.Visible = false;
                rad_software.Visible = false;
                lbl_target.Text = "Order Method ::";
                cbo_target.Items.Add("Phone");
                cbo_target.Items.Add("E-Mail");
                cbo_target.Items.Add("Fax");
                cbo_target.Visible = true;
            }
            if (cbo_search_method.Text == "Shipping Date")
            {
                cbo_target.Visible = false;
                btn_search.Visible = false;
                datepicker.Visible = false;
                rad_book.Visible = false;
                rad_software.Visible = false;
                lbl_target.Text = "Shipping Date ::";
                datepicker.Visible = true;
            }
            if (cbo_search_method.Text == "Expected Date")
            {
                cbo_target.Visible = false;
                btn_search.Visible = false;
                datepicker.Visible = false;
                rad_book.Visible = false;
                rad_software.Visible = false;
                lbl_target.Text = "Expected Date ::";
                datepicker.Visible = true;
            }
            if (cbo_search_method.Text == "Order Clerk ID")
            {
                cbo_target.Visible = false;
                btn_search.Visible = false;
                datepicker.Visible = false;
                rad_book.Visible = false;
                rad_software.Visible = false;
                lbl_target.Text = "Order Clerk ID ::";
                foreach (string i in mary.List_OrderClerkID())
                {
                    cbo_target.Items.Add(i);
                }
                cbo_target.Visible = true;
            }
        }

        private void listview_orders_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            txt_order_status.Text = "";
            Clerk mary = new Clerk();
            mary.Bring_New_Order_Status();
            read_new_order_status();
        }

        private void datepicker_ValueChanged(object sender, EventArgs e)
        {
            if (datepicker.Visible)
            {
                btn_search.Visible = true;
            }
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            Clerk mary = new Clerk();
            txt_order_status.Text = "";
            mary.Bring_New_Order_Status();
            listview_addeditem.Items.Clear();
            ListViewItem list;
            foreach (Order_Client a in mary.Listed_Orders())
            {
                list = new ListViewItem(a.OrderID);
                list.SubItems.Add(a.ClientID);
                list.SubItems.Add(a.OrderMethod);
                list.SubItems.Add(a.Payment_status);
                list.SubItems.Add(a.ShippingDate);
                list.SubItems.Add(a.ExpectedDate);
                list.SubItems.Add(a.OrderClerkID);
                listview_orders.Items.Add(list);
            }
            cbo_target.Visible = false;
            btn_search.Visible = false;
            datepicker.Visible = false;
            rad_book.Visible = false;
            rad_software.Visible = false;
            string[] search_methods = { "Order ID", "Client ID", "Included Item", "Payment Status", "Order Method", "Shipping Date", "Expected Date", "Order Clerk ID" };
            cbo_search_method.DataSource = search_methods;
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

        private void modifyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
