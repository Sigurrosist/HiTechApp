namespace HiTechApp.GUI
{
    partial class Form_Save_New_Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_order_id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_client = new System.Windows.Forms.ComboBox();
            this.cbo_order_method = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_payment_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_OCID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add_items = new System.Windows.Forms.Button();
            this.listview_addeditem = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_order_status = new System.Windows.Forms.TextBox();
            this.btn_save_order = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.date_expected = new System.Windows.Forms.DateTimePicker();
            this.date_shipping = new System.Windows.Forms.DateTimePicker();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.listview_orders = new System.Windows.Forms.ListView();
            this.orderid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ordermetho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expecdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shipdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderclerkid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listview_list_itemdetail = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_reset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDER :: ";
            // 
            // lbl_order_id
            // 
            this.lbl_order_id.AutoSize = true;
            this.lbl_order_id.Location = new System.Drawing.Point(144, 74);
            this.lbl_order_id.Name = "lbl_order_id";
            this.lbl_order_id.Size = new System.Drawing.Size(267, 18);
            this.lbl_order_id.TabIndex = 1;
            this.lbl_order_id.Text = "Order ID will be automatically generated";
            this.lbl_order_id.TextChanged += new System.EventHandler(this.lbl_order_id_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client ::";
            // 
            // cbo_client
            // 
            this.cbo_client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_client.FormattingEnabled = true;
            this.cbo_client.Location = new System.Drawing.Point(147, 112);
            this.cbo_client.Name = "cbo_client";
            this.cbo_client.Size = new System.Drawing.Size(272, 26);
            this.cbo_client.TabIndex = 3;
            this.cbo_client.SelectedIndexChanged += new System.EventHandler(this.cbo_client_SelectedIndexChanged);
            // 
            // cbo_order_method
            // 
            this.cbo_order_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_order_method.FormattingEnabled = true;
            this.cbo_order_method.Location = new System.Drawing.Point(147, 161);
            this.cbo_order_method.Name = "cbo_order_method";
            this.cbo_order_method.Size = new System.Drawing.Size(272, 26);
            this.cbo_order_method.TabIndex = 5;
            this.cbo_order_method.SelectedIndexChanged += new System.EventHandler(this.cbo_order_method_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Order Method ::";
            // 
            // cbo_payment_status
            // 
            this.cbo_payment_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_payment_status.FormattingEnabled = true;
            this.cbo_payment_status.Location = new System.Drawing.Point(147, 209);
            this.cbo_payment_status.Name = "cbo_payment_status";
            this.cbo_payment_status.Size = new System.Drawing.Size(272, 26);
            this.cbo_payment_status.TabIndex = 7;
            this.cbo_payment_status.SelectedIndexChanged += new System.EventHandler(this.cbo_payment_status_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Payment Status ::";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Expected Date ::";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Shipping Date ::";
            // 
            // cbo_OCID
            // 
            this.cbo_OCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_OCID.FormattingEnabled = true;
            this.cbo_OCID.Location = new System.Drawing.Point(147, 361);
            this.cbo_OCID.Name = "cbo_OCID";
            this.cbo_OCID.Size = new System.Drawing.Size(272, 26);
            this.cbo_OCID.TabIndex = 13;
            this.cbo_OCID.SelectedIndexChanged += new System.EventHandler(this.cbo_OCID_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Order Clerk ID ::";
            // 
            // btn_add_items
            // 
            this.btn_add_items.Location = new System.Drawing.Point(457, 102);
            this.btn_add_items.Name = "btn_add_items";
            this.btn_add_items.Size = new System.Drawing.Size(137, 31);
            this.btn_add_items.TabIndex = 89;
            this.btn_add_items.Text = "Add Item";
            this.btn_add_items.UseVisualStyleBackColor = true;
            this.btn_add_items.Click += new System.EventHandler(this.btn_add_items_Click);
            // 
            // listview_addeditem
            // 
            this.listview_addeditem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listview_addeditem.FullRowSelect = true;
            this.listview_addeditem.GridLines = true;
            this.listview_addeditem.Location = new System.Drawing.Point(457, 150);
            this.listview_addeditem.Name = "listview_addeditem";
            this.listview_addeditem.Size = new System.Drawing.Size(208, 237);
            this.listview_addeditem.TabIndex = 90;
            this.listview_addeditem.UseCompatibleStateImageBehavior = false;
            this.listview_addeditem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Item Price";
            this.columnHeader3.Width = 70;
            // 
            // txt_order_status
            // 
            this.txt_order_status.Location = new System.Drawing.Point(703, 58);
            this.txt_order_status.Multiline = true;
            this.txt_order_status.Name = "txt_order_status";
            this.txt_order_status.ReadOnly = true;
            this.txt_order_status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_order_status.Size = new System.Drawing.Size(277, 329);
            this.txt_order_status.TabIndex = 98;
            // 
            // btn_save_order
            // 
            this.btn_save_order.Location = new System.Drawing.Point(782, 408);
            this.btn_save_order.Name = "btn_save_order";
            this.btn_save_order.Size = new System.Drawing.Size(191, 31);
            this.btn_save_order.TabIndex = 100;
            this.btn_save_order.Text = "Submit &Order";
            this.btn_save_order.UseVisualStyleBackColor = true;
            this.btn_save_order.Click += new System.EventHandler(this.btn_save_order_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.modifyPasswordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 102;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // modifyPasswordToolStripMenuItem
            // 
            this.modifyPasswordToolStripMenuItem.Name = "modifyPasswordToolStripMenuItem";
            this.modifyPasswordToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.modifyPasswordToolStripMenuItem.Text = "Modify Password";
            this.modifyPasswordToolStripMenuItem.Click += new System.EventHandler(this.modifyPasswordToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(700, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 18);
            this.label8.TabIndex = 103;
            this.label8.Text = "ORDER STATUS :: ";
            // 
            // date_expected
            // 
            this.date_expected.Location = new System.Drawing.Point(147, 258);
            this.date_expected.Name = "date_expected";
            this.date_expected.Size = new System.Drawing.Size(272, 24);
            this.date_expected.TabIndex = 104;
            this.date_expected.ValueChanged += new System.EventHandler(this.date_expected_ValueChanged);
            // 
            // date_shipping
            // 
            this.date_shipping.Location = new System.Drawing.Point(147, 309);
            this.date_shipping.Name = "date_shipping";
            this.date_shipping.Size = new System.Drawing.Size(272, 24);
            this.date_shipping.TabIndex = 105;
            this.date_shipping.ValueChanged += new System.EventHandler(this.date_shipping_ValueChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(782, 683);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(191, 31);
            this.btn_Exit.TabIndex = 106;
            this.btn_Exit.Text = "E&XIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // listview_orders
            // 
            this.listview_orders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderid,
            this.clientid,
            this.ordermetho,
            this.expecdate,
            this.shipdate,
            this.orderclerkid,
            this.totalprice});
            this.listview_orders.FullRowSelect = true;
            this.listview_orders.GridLines = true;
            this.listview_orders.Location = new System.Drawing.Point(15, 470);
            this.listview_orders.Name = "listview_orders";
            this.listview_orders.Size = new System.Drawing.Size(735, 203);
            this.listview_orders.TabIndex = 107;
            this.listview_orders.UseCompatibleStateImageBehavior = false;
            this.listview_orders.View = System.Windows.Forms.View.Details;
            this.listview_orders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listview_orders_MouseDoubleClick);
            // 
            // orderid
            // 
            this.orderid.Text = "Order ID";
            this.orderid.Width = 70;
            // 
            // clientid
            // 
            this.clientid.Text = "Client ID";
            this.clientid.Width = 70;
            // 
            // ordermetho
            // 
            this.ordermetho.Text = "Order Method";
            this.ordermetho.Width = 120;
            // 
            // expecdate
            // 
            this.expecdate.Text = "Expected Date";
            this.expecdate.Width = 150;
            // 
            // shipdate
            // 
            this.shipdate.Text = "Shipping Date";
            this.shipdate.Width = 150;
            // 
            // orderclerkid
            // 
            this.orderclerkid.Text = "Clerk ID";
            this.orderclerkid.Width = 80;
            // 
            // totalprice
            // 
            this.totalprice.Text = "Total (CAD)";
            this.totalprice.Width = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(513, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 18);
            this.label9.TabIndex = 108;
            this.label9.Text = "Double click the order to see items";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(700, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 18);
            this.label10.TabIndex = 109;
            // 
            // listview_list_itemdetail
            // 
            this.listview_list_itemdetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listview_list_itemdetail.FullRowSelect = true;
            this.listview_list_itemdetail.GridLines = true;
            this.listview_list_itemdetail.Location = new System.Drawing.Point(772, 470);
            this.listview_list_itemdetail.Name = "listview_list_itemdetail";
            this.listview_list_itemdetail.Size = new System.Drawing.Size(208, 203);
            this.listview_list_itemdetail.TabIndex = 110;
            this.listview_list_itemdetail.UseCompatibleStateImageBehavior = false;
            this.listview_list_itemdetail.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Item ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity";
            this.columnHeader5.Width = 65;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Item Price";
            this.columnHeader6.Width = 70;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(605, 408);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(145, 31);
            this.btn_reset.TabIndex = 111;
            this.btn_reset.Text = "Reset the form";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form_Save_New_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 726);
            this.ControlBox = false;
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.listview_list_itemdetail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listview_orders);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.date_shipping);
            this.Controls.Add(this.date_expected);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_save_order);
            this.Controls.Add(this.txt_order_status);
            this.Controls.Add(this.listview_addeditem);
            this.Controls.Add(this.btn_add_items);
            this.Controls.Add(this.cbo_OCID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_payment_status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_order_method);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_client);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_order_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_Save_New_Order";
            this.Text = "New Order Form";
            this.Load += new System.EventHandler(this.Form_Save_New_Order_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_order_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_client;
        private System.Windows.Forms.ComboBox cbo_order_method;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_payment_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_OCID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_add_items;
        private System.Windows.Forms.ListView listview_addeditem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txt_order_status;
        private System.Windows.Forms.Button btn_save_order;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyPasswordToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker date_expected;
        private System.Windows.Forms.DateTimePicker date_shipping;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ListView listview_orders;
        private System.Windows.Forms.ColumnHeader orderid;
        private System.Windows.Forms.ColumnHeader clientid;
        private System.Windows.Forms.ColumnHeader ordermetho;
        private System.Windows.Forms.ColumnHeader expecdate;
        private System.Windows.Forms.ColumnHeader shipdate;
        private System.Windows.Forms.ColumnHeader orderclerkid;
        private System.Windows.Forms.ColumnHeader totalprice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listview_list_itemdetail;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_reset;
    }
}