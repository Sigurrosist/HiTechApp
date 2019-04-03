using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HCL.Business.Company;
using HCL.Business.Order;
using HCL.Business.People;
using HCL.Business.Items;
using System.Diagnostics;

namespace HiTechApp.GUI
{
    public partial class Form_Save_New_Order : Form
    {
        public Form_Save_New_Order()
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
        bool saved = false;
        double tps = 0;
        double tvq = 0;
        double subtotal = 0;
        double total = 0;
        private void btn_add_items_Click(object sender, EventArgs e)
        {
            Clerk mary = new Clerk();
            File.Delete(@"C:\JooyeonMok_HCL_FinalProject\Adding_Items_List.dat");
            Form_Add_Items_To_Order a = new Form_Add_Items_To_Order();
            a.FormClosed += (s, args) =>
            {
                try
                {
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
                    saved = true;
                }
                catch
                {
                    MessageBox.Show("No item is saved", "Please add items");
                }
            };
            a.ShowDialog();
        }

        private void list_orders()
        {
            Clerk mary = new Clerk();
            ListViewItem i = new ListViewItem();
            listview_orders.Items.Clear();
            foreach (Order_Client a in mary.Listed_Orders())
            {
                i = new ListViewItem(a.OrderID);
                i.SubItems.Add(a.ClientID);
                i.SubItems.Add(a.OrderMethod);
                i.SubItems.Add(a.ExpectedDate);
                i.SubItems.Add(a.ShippingDate);
                i.SubItems.Add(a.OrderClerkID);
                string[] u = a.ItemList.Split('+');
                double total = 0;
                foreach (string c in u)
                {
                    string[] v = c.Split(',');
                    total = total + Convert.ToDouble(v[2]);
                }
                i.SubItems.Add(total.ToString());
                listview_orders.Items.Add(i);
            }
        }
        private void Form_Save_New_Order_Load(object sender, EventArgs e)
        {
            Clerk mary = new Clerk();
            foreach (Institute i in mary.List_Client())
            {
                cbo_client.Items.Add(i.Id + " - " + i.Name);
            }
            mary.Bring_New_Order_Status();
            string[] ordermethod = { "Phone", "E-Mail", "Fax" };
            string[] paymentstatus = { "Received", "Waiting", "Delayed" };
            cbo_order_method.DataSource = ordermethod;
            cbo_order_method.Text = "Phone";
            cbo_payment_status.DataSource = paymentstatus;
            cbo_payment_status.Text = "Waiting";
            foreach (string i in mary.List_OrderClerkID())
            {
                cbo_OCID.Items.Add(i);
                cbo_OCID.Text = i;
            }
            lbl_order_id.Text = mary.Order_ID_Generator();
            list_orders();
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

        private void lbl_order_id_TextChanged(object sender, EventArgs e)
        {
            Clerk mary = new Clerk();
            string target = "- Order ID :";
            string replace = "- Order ID : " + lbl_order_id.Text;
            mary.Refresh_Order_Status(target, replace);
            read_new_order_status();
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

        private void btn_save_order_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Regex.Match(cbo_client.Text, @"\d+").Value);
            Clerk mary = new Clerk();
            SalesManager peter = new SalesManager();
            double clientcredit = (Convert.ToDouble(peter.Searched_Client_by_id(id).Credit_Left));
            if ((clientcredit - total) < 0)
            {
                MessageBox.Show("The client does not have enough credit. \nCredit Left : " + clientcredit + "\nPurchase Total : " + total.ToString() + "\n Credit exceeded : " + (clientcredit - total).ToString(), "");
                File.Delete("C:\\JooyeonMok_HCL_FinalProject\\Adding_Items_List.dat");
                File.Delete("C:\\JooyeonMok_HCL_FinalProject\\Order_Status.txt");
                btn_add_items.Visible = true;
                listview_addeditem.Items.Clear();
                txt_order_status.Text = "";
                mary.Bring_New_Order_Status();
                read_new_order_status();
            }
            else
            {
                string itemlist = mary.Read_Added_Items_List();
                    if (cbo_OCID.Text != "" && saved && cbo_client.Text != "")
                    {
                        Order_Client one = new Order_Client();
                        one.OrderID = lbl_order_id.Text;
                        one.ClientID = Regex.Match(cbo_client.Text, @"\d+").Value;
                        one.ItemList = itemlist;
                        one.OrderMethod = cbo_order_method.Text;
                        one.Payment_status = cbo_payment_status.Text;
                        one.ShippingDate = date_shipping.Text;
                        one.ExpectedDate = date_expected.Text;
                        one.OrderClerkID = cbo_OCID.Text;
                        mary.Save_New_Order(one);

                        MessageBox.Show("Saved the order for ID : " + lbl_order_id.Text, "Completed");
                        foreach (Institute ii in mary.List_Client())
                        {
                            cbo_client.Items.Add(ii.Id + " - " + ii.Name);
                        }
                        string[] ordermethod = { "Phone", "E-Mail", "Fax" };
                        string[] paymentstatus = { "Received", "Waiting", "Delayed" };
                        cbo_order_method.DataSource = ordermethod;
                        cbo_order_method.Text = "Phone";
                        cbo_payment_status.DataSource = paymentstatus;
                        cbo_payment_status.Text = "Waiting";
                        foreach (string io in mary.List_OrderClerkID())
                        {
                            cbo_OCID.Items.Add(io);
                            cbo_OCID.Text = io;
                        }
                        lbl_order_id.Text = mary.Order_ID_Generator();
                        listview_addeditem.Items.Clear();
                        btn_add_items.Visible = true;
                        //mary.Bring_New_OrderStatus();


                        InventoryController wang = new InventoryController();
                        string[] control_inven_item_list = itemlist.Split('+');
                        foreach (string oi in control_inven_item_list)
                        {
                            string[] cols = oi.Split(',');
                            if (wang.Is_It_a_Book(cols[0]))
                            {
                                Book a = new Book();
                                a.ID = wang.Searched_Book_by_ID(cols[0]).ID;
                                a.AuthorID = wang.Searched_Book_by_ID(cols[0]).AuthorID;
                                a.Category = wang.Searched_Book_by_ID(cols[0]).Category;
                                a.ISBN10 = wang.Searched_Book_by_ID(cols[0]).ISBN10;
                                a.ISBN10 = wang.Searched_Book_by_ID(cols[0]).ISBN13;
                                a.PubID = wang.Searched_Book_by_ID(cols[0]).PubID;
                                a.Pub_Year = wang.Searched_Book_by_ID(cols[0]).Pub_Year;
                                a.Quantity = wang.Searched_Book_by_ID(cols[0]).Quantity - Convert.ToInt32(cols[1]);
                                a.Title = wang.Searched_Book_by_ID(cols[0]).Title;
                                a.Type = wang.Searched_Book_by_ID(cols[0]).Type;
                                a.UnitPrice = wang.Searched_Book_by_ID(cols[0]).UnitPrice;
                                wang.Update_a_Book(a);
                            }
                            else
                            {
                                Software a = new Software();
                                a.ID = wang.Searched_Software_by_ID(cols[0]).ID;
                                a.AuthorID = wang.Searched_Software_by_ID(cols[0]).AuthorID;
                                a.Category = wang.Searched_Software_by_ID(cols[0]).Category;
                                a.Software_Type = wang.Searched_Software_by_ID(cols[0]).Software_Type;
                                a.PubID = wang.Searched_Software_by_ID(cols[0]).PubID;
                                a.Pub_Year = wang.Searched_Software_by_ID(cols[0]).Pub_Year;
                                a.Quantity = wang.Searched_Software_by_ID(cols[0]).Quantity - Convert.ToInt32(cols[1]);
                                a.Title = wang.Searched_Software_by_ID(cols[0]).Title;
                                a.Type = wang.Searched_Software_by_ID(cols[0]).Type;
                                a.UnitPrice = wang.Searched_Software_by_ID(cols[0]).UnitPrice;
                                wang.Update_a_Software(a);
                            }

                            Institute client = new Institute();
                            client.Id = peter.Searched_Client_by_id(id).Id;
                            client.Name = peter.Searched_Client_by_id(id).Name;
                            client.Person_in_Charge = peter.Searched_Client_by_id(id).Person_in_Charge;
                            client.Phone = peter.Searched_Client_by_id(id).Phone;
                            client.PostalCode = peter.Searched_Client_by_id(id).PostalCode;
                            client.Status = peter.Searched_Client_by_id(id).Status;
                            client.Street_Name = peter.Searched_Client_by_id(id).Street_Name;
                            client.Street_Number = peter.Searched_Client_by_id(id).Street_Number;
                            client.City = peter.Searched_Client_by_id(id).City;
                            client.Credit_Contract = peter.Searched_Client_by_id(id).Credit_Contract;
                            client.Credit_Left = (clientcredit - total).ToString();
                            client.Email = peter.Searched_Client_by_id(id).Email;
                            peter.Update_Client(client);
                        }
                    mary.Open_New_Order_Status();
                }
                else
                    {
                        MessageBox.Show("Please check missing information. Make sure that the items to order are saved properly.", "Missing Information");
                    }
                }
            }

        private void listview_orders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listview_list_itemdetail.Items.Clear();
            Clerk mary = new Clerk();
            ListViewItem list;
            string itemlist = mary.Searched_Order_by_ID(listview_orders.SelectedItems[0].SubItems[0].Text).ItemList;
            string[] eachitems = itemlist.Split('+');
            foreach (string each in eachitems)
            {
                string[] itemdetail = each.Split(',');
                list = new ListViewItem(itemdetail[0]);
                list.SubItems.Add(itemdetail[1]);
                list.SubItems.Add(itemdetail[2]);
                listview_list_itemdetail.Items.Add(list);
            }
        }

        private void item_cost_reset()
        {
            bool saved = false;
            double tps = 0;
            double tvq = 0;
            double subtotal = 0;
            double total = 0;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            item_cost_reset();
            txt_order_status.Text = "";
        }
    }
}
   