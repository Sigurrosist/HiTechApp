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
    public partial class Form_Update_Orders : Form
    {
        public Form_Update_Orders()
        {
            InitializeComponent();
        }
        double tps = 0;
        double tvq = 0;
        double subtotal = 0;
        double total = 0;
        double to_reset_credit = 0;
        private void purchase_amount_reset()
        {
            tps = 0;
            tvq = 0;
            subtotal = 0;
            total = 0;
            to_reset_credit = 0;
        }
        private void Form_Update_Orders_Load(object sender, EventArgs e)
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
            btn_add_items.Visible = false;
            foreach (Institute i in mary.List_Client())
            {
                cbo_client.Items.Add(i.Id + " - " + i.Name);
                cbo_client.Text = i.Id + " - " + i.Name;
            }
            string[] ordermethod = { "Phone", "E-Mail", "Fax" };
            cbo_order_method.DataSource = ordermethod;
            cbo_order_method.Text = "Phone";
            string[] paymentstatus = { "Received", "Waiting", "Delayed" };
            cbo_payment_status.DataSource = paymentstatus;
            cbo_payment_status.Text = "Waiting";
            mary.Read_Order_Status();
            foreach (string i in mary.List_OrderClerkID())
            {
                cbo_OCID.Items.Add(i);
                cbo_OCID.Text = i;
            }
            purchase_amount_reset();
        }

        private void order_list()
        {
            purchase_amount_reset();
            Clerk mary = new Clerk();
            SalesManager peter = new SalesManager();
            lbl_order_id.Text = mary.Searched_Order_by_ID(listview_orders.SelectedItems[0].SubItems[0].Text).OrderID;
            cbo_client.Text = mary.Searched_Order_by_ID(listview_orders.SelectedItems[0].SubItems[0].Text).ClientID + " - " + peter.Searched_Client_by_id(Convert.ToInt32(mary.Searched_Order_by_ID(listview_orders.SelectedItems[0].SubItems[0].Text).ClientID)).Name;
            cbo_order_method.Text = mary.Searched_Order_by_ID(listview_orders.SelectedItems[0].SubItems[0].Text).OrderMethod;
            cbo_payment_status.Text = mary.Searched_Order_by_ID(listview_orders.SelectedItems[0].SubItems[0].Text).Payment_status;
            cbo_OCID.Text = mary.Searched_Order_by_ID(listview_orders.SelectedItems[0].SubItems[0].Text).OrderClerkID;
            date_expected.Text = mary.Searched_Order_by_ID(listview_orders.SelectedItems[0].SubItems[0].Text).ExpectedDate;
            date_shipping.Text = mary.Searched_Order_by_ID(listview_orders.SelectedItems[0].SubItems[0].Text).ShippingDate;
            ListViewItem l = new ListViewItem();
            string toadd = mary.Searched_Order_by_ID(listview_orders.SelectedItems[0].SubItems[0].Text).ItemList;
            mary.Write_Added_Items_List(toadd);
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
            mary.Add_Item_List(toadd, tps.ToString(), tvq.ToString(), subtotal.ToString(), total.ToString());
            btn_add_items.Visible = true;
            to_reset_credit = subtotal;

            string target = "";
            string replace = "";
            target = "Client";
            replace = "- Client : " + cbo_client.Text;
            mary.Refresh_Order_Status(target, replace);
            target = "Order Method";
            replace = "- Order Method : " + cbo_order_method.Text;
            mary.Refresh_Order_Status(target, replace);
            target = "Payment Status";
            replace = "- Payment Status : " + cbo_payment_status.Text;
            mary.Refresh_Order_Status(target, replace);
            target = "Expected";
            replace = "- Expected Date : " + date_expected.Text;
            mary.Refresh_Order_Status(target, replace);
            target = "Shipping";
            replace = "- Shipping Date : " + date_shipping.Text;
            mary.Refresh_Order_Status(target, replace);
            target = "Clerk";
            replace = "- Order Clerk ID : " + cbo_OCID.Text;
            mary.Refresh_Order_Status(target, replace);
            target = "- Order ID :";
            replace = "- Order ID : " + lbl_order_id.Text;
            mary.Refresh_Order_Status(target, replace);
            read_new_order_status();
        }
        private void listview_orders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clerk mary = new Clerk();
            mary.Bring_New_Order_Status();
            listview_addeditem.Items.Clear();
            order_list();
            if (cbo_payment_status.Text == "Received")
            {
                btn_save_order.Visible = false;
                btn_add_items.Visible = false;
            }
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
        private void cbo_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clerk mary = new Clerk();
            string target = "";
            string replace = "";
            target = "Client";
            replace = "- Client : " + cbo_client.Text;
            mary.Refresh_Order_Status(target, replace);
            read_new_order_status();
        }

        private void cbo_order_method_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clerk mary = new Clerk();
            string target = "";
            string replace = "";
            target = "Order Method";
            replace = "- Order Method : " + cbo_order_method.Text;
            mary.Refresh_Order_Status(target, replace);
            read_new_order_status();
        }

        private void cbo_payment_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clerk mary = new Clerk();
            string target = "";
            string replace = "";
            target = "Payment Status";
            replace = "- Payment Status : " + cbo_payment_status.Text;
            mary.Refresh_Order_Status(target, replace);
            read_new_order_status();
        }

        private void date_expected_ValueChanged(object sender, EventArgs e)
        {
            Clerk mary = new Clerk();
            string target = "";
            string replace = "";
            target = "Expected";
            replace = "- Expected Date : " + date_expected.Text;
            mary.Refresh_Order_Status(target, replace);
            read_new_order_status();
        }

        private void date_shipping_ValueChanged(object sender, EventArgs e)
        {
            Clerk mary = new Clerk();
            string target = "";
            string replace = "";
            target = "Shipping";
            replace = "- Shipping Date : " + date_shipping.Text;
            mary.Refresh_Order_Status(target, replace);
            read_new_order_status();
        }

        private void cbo_OCID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clerk mary = new Clerk();
            string target = "";
            string replace = "";
            target = "Clerk";
            replace = "- Order Clerk ID : " + cbo_OCID.Text;
            mary.Refresh_Order_Status(target, replace);
            read_new_order_status();
        }

        private void lbl_order_id_TextChanged(object sender, EventArgs e)
        {
            Clerk mary = new Clerk();
            string target = "- Order ID :";
            string replace = "- Order ID : " + lbl_order_id.Text;
            mary.Refresh_Order_Status(target, replace);
            read_new_order_status();
        }

        private void btn_add_items_Click(object sender, EventArgs e)
        {
            Clerk mary = new Clerk();
            tps = 0;
            tvq = 0;
            subtotal = 0;
            total = 0;

            Form_Add_Items_To_Order a = new Form_Add_Items_To_Order();
            a.FormClosed += (s, args) =>
            {
                try
                {
                    mary.Bring_New_Order_Status();
                    listview_addeditem.Items.Clear();
                    ListViewItem l = new ListViewItem();
                    string toadd = mary.Read_Added_Items_List();
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
                    mary.Add_Item_List(toadd, tps.ToString(), tvq.ToString(), subtotal.ToString(), total.ToString());
                    read_new_order_status();
                    btn_add_items.Visible = false;
                }
                catch
                {
                    MessageBox.Show("No item is saved", "Please add items");
                }
            };
            a.ShowDialog();
        }

        private void btn_save_order_Click(object sender, EventArgs e)
        {
            try
            {
                Clerk mary = new Clerk(); 
                string newclientid = Regex.Match(cbo_client.Text, @"\d+").Value;
                string oldclientid = mary.Searched_Order_by_ID(lbl_order_id.Text).ClientID;
                string newitemlist = mary.Read_Added_Items_List();
                string olditemlist = mary.Searched_Order_by_ID(lbl_order_id.Text).ItemList;

                if (newclientid != oldclientid)
                {
                    if(mary.Check_Credit(newclientid, total.ToString()))
                    {
                        mary.Update_Client_Credit(oldclientid, to_reset_credit);
                        string minus_total = "-" + total.ToString();
                        mary.Update_Client_Credit(newclientid, Convert.ToDouble(minus_total));
                        string[] item_reset = olditemlist.Split('+');
                        foreach(string o in item_reset)
                        {
                            string[] y = o.Split(',');
                            mary.Update_Item_Quantity(y[0], Convert.ToInt32(y[1]));
                        }
                        item_reset = newitemlist.Split('+');
                        foreach (string o in item_reset)
                        {
                            string[] y = o.Split(',');
                            string minus_quantity = "-" + y[1];
                            mary.Update_Item_Quantity(y[0], Convert.ToInt32(minus_quantity));
                        }
                        Order_Client one = new Order_Client();
                        one.OrderID = lbl_order_id.Text;
                        one.ClientID = Regex.Match(cbo_client.Text, @"\d+").Value;
                        one.ItemList = newitemlist;
                        one.OrderMethod = cbo_order_method.Text;
                        one.Payment_status = cbo_payment_status.Text;
                        one.ShippingDate = date_shipping.Text;
                        one.ExpectedDate = date_expected.Text;
                        one.OrderClerkID = cbo_OCID.Text;
                        mary.Update_Order(one);
                        if (cbo_payment_status.Text == "Received")
                        {
                            btn_save_order.Visible = false;
                            btn_add_items.Visible = false;
                        }
                        MessageBox.Show("Order ID : " + one.OrderID + " has been updated.\n ***The client for this order has been changed from " + oldclientid + " to " + newclientid + ".***\n Credit for the previous client has been returned.");
                        mary.Open_New_Order_Status();
                    }
                    else
                    {
                        MessageBox.Show("The client does not have enough credit for this order", "Please check again");
                    }
                }
                else
                {
                    double tocheckcredit = total - to_reset_credit;
                    if (mary.Check_Credit(oldclientid, tocheckcredit.ToString()))
                    {
                        mary.Update_Client_Credit(oldclientid, to_reset_credit);
                        string minus_total = "-" + total.ToString();
                        mary.Update_Client_Credit(oldclientid, Convert.ToDouble(minus_total));
                        string[] item_reset = olditemlist.Split('+');
                        foreach (string o in item_reset)
                        {
                            string[] y = o.Split(',');
                            mary.Update_Item_Quantity(y[0], Convert.ToInt32(y[1]));
                        }
                        item_reset = newitemlist.Split('+');
                        foreach (string o in item_reset)
                        {
                            string[] y = o.Split(',');
                            string minus = "-" + y[1];
                            mary.Update_Item_Quantity(y[0], Convert.ToInt32(minus));
                        }
                        Order_Client one = new Order_Client();
                        one.OrderID = lbl_order_id.Text;
                        one.ClientID = Regex.Match(cbo_client.Text, @"\d+").Value;
                        one.ItemList = newitemlist;
                        one.OrderMethod = cbo_order_method.Text;
                        one.Payment_status = cbo_payment_status.Text;
                        one.ShippingDate = date_shipping.Text;
                        one.ExpectedDate = date_expected.Text;
                        one.OrderClerkID = cbo_OCID.Text;
                        mary.Update_Order(one);
                        MessageBox.Show("Order ID : " + one.OrderID + " has been updated.\n" + "\n Credit for the client has been renewed.");
                        mary.Open_New_Order_Status();
                        if (cbo_payment_status.Text == "Received")
                        {
                            btn_save_order.Visible = false;
                            btn_add_items.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The client does not have enough credit for this order", "Please check again");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please double-click the order to update first", "No order selected");
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
