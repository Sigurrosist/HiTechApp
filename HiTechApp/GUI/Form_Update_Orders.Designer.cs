namespace HiTechApp.GUI
{
    partial class Form_Update_Orders
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.date_expected = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.modifyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_save_order = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_shipping = new System.Windows.Forms.DateTimePicker();
            this.txt_order_status = new System.Windows.Forms.TextBox();
            this.listview_addeditem = new System.Windows.Forms.ListView();
            this.btn_add_items = new System.Windows.Forms.Button();
            this.cbo_OCID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_payment_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_order_method = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_client = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_order_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listview_orders = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(830, 642);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(191, 31);
            this.btn_Exit.TabIndex = 127;
            this.btn_Exit.Text = "E&XIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // date_expected
            // 
            this.date_expected.Location = new System.Drawing.Point(149, 490);
            this.date_expected.Name = "date_expected";
            this.date_expected.Size = new System.Drawing.Size(245, 22);
            this.date_expected.TabIndex = 125;
            this.date_expected.ValueChanged += new System.EventHandler(this.date_expected_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(687, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 124;
            this.label8.Text = "ORDER STATUS :: ";
            // 
            // modifyPasswordToolStripMenuItem
            // 
            this.modifyPasswordToolStripMenuItem.Name = "modifyPasswordToolStripMenuItem";
            this.modifyPasswordToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.modifyPasswordToolStripMenuItem.Text = "Modify Password";
            this.modifyPasswordToolStripMenuItem.Click += new System.EventHandler(this.modifyPasswordToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1066, 28);
            this.menuStrip1.TabIndex = 123;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_save_order
            // 
            this.btn_save_order.Location = new System.Drawing.Point(595, 642);
            this.btn_save_order.Name = "btn_save_order";
            this.btn_save_order.Size = new System.Drawing.Size(191, 31);
            this.btn_save_order.TabIndex = 122;
            this.btn_save_order.Text = "&Update Order";
            this.btn_save_order.UseVisualStyleBackColor = true;
            this.btn_save_order.Click += new System.EventHandler(this.btn_save_order_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Item Price";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item ID";
            // 
            // date_shipping
            // 
            this.date_shipping.Location = new System.Drawing.Point(149, 541);
            this.date_shipping.Name = "date_shipping";
            this.date_shipping.Size = new System.Drawing.Size(245, 22);
            this.date_shipping.TabIndex = 126;
            this.date_shipping.ValueChanged += new System.EventHandler(this.date_shipping_ValueChanged);
            // 
            // txt_order_status
            // 
            this.txt_order_status.Location = new System.Drawing.Point(690, 306);
            this.txt_order_status.Multiline = true;
            this.txt_order_status.Name = "txt_order_status";
            this.txt_order_status.ReadOnly = true;
            this.txt_order_status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_order_status.Size = new System.Drawing.Size(331, 313);
            this.txt_order_status.TabIndex = 121;
            // 
            // listview_addeditem
            // 
            this.listview_addeditem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listview_addeditem.FullRowSelect = true;
            this.listview_addeditem.GridLines = true;
            this.listview_addeditem.Location = new System.Drawing.Point(421, 382);
            this.listview_addeditem.Name = "listview_addeditem";
            this.listview_addeditem.Size = new System.Drawing.Size(246, 237);
            this.listview_addeditem.TabIndex = 120;
            this.listview_addeditem.UseCompatibleStateImageBehavior = false;
            this.listview_addeditem.View = System.Windows.Forms.View.Details;
            // 
            // btn_add_items
            // 
            this.btn_add_items.Location = new System.Drawing.Point(421, 337);
            this.btn_add_items.Name = "btn_add_items";
            this.btn_add_items.Size = new System.Drawing.Size(246, 31);
            this.btn_add_items.TabIndex = 119;
            this.btn_add_items.Text = "Update Item detail";
            this.btn_add_items.UseVisualStyleBackColor = true;
            this.btn_add_items.Click += new System.EventHandler(this.btn_add_items_Click);
            // 
            // cbo_OCID
            // 
            this.cbo_OCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_OCID.FormattingEnabled = true;
            this.cbo_OCID.Location = new System.Drawing.Point(149, 593);
            this.cbo_OCID.Name = "cbo_OCID";
            this.cbo_OCID.Size = new System.Drawing.Size(245, 24);
            this.cbo_OCID.TabIndex = 118;
            this.cbo_OCID.SelectedIndexChanged += new System.EventHandler(this.cbo_OCID_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 596);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 117;
            this.label7.Text = "Order Clerk ID ::";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 116;
            this.label6.Text = "Shipping Date ::";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 115;
            this.label5.Text = "Expected Date ::";
            // 
            // cbo_payment_status
            // 
            this.cbo_payment_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_payment_status.FormattingEnabled = true;
            this.cbo_payment_status.Location = new System.Drawing.Point(149, 441);
            this.cbo_payment_status.Name = "cbo_payment_status";
            this.cbo_payment_status.Size = new System.Drawing.Size(245, 24);
            this.cbo_payment_status.TabIndex = 114;
            this.cbo_payment_status.SelectedIndexChanged += new System.EventHandler(this.cbo_payment_status_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 113;
            this.label4.Text = "Payment Status ::";
            // 
            // cbo_order_method
            // 
            this.cbo_order_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_order_method.FormattingEnabled = true;
            this.cbo_order_method.Location = new System.Drawing.Point(149, 393);
            this.cbo_order_method.Name = "cbo_order_method";
            this.cbo_order_method.Size = new System.Drawing.Size(245, 24);
            this.cbo_order_method.TabIndex = 112;
            this.cbo_order_method.SelectedIndexChanged += new System.EventHandler(this.cbo_order_method_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 111;
            this.label2.Text = "Order Method ::";
            // 
            // cbo_client
            // 
            this.cbo_client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_client.FormattingEnabled = true;
            this.cbo_client.Location = new System.Drawing.Point(149, 344);
            this.cbo_client.Name = "cbo_client";
            this.cbo_client.Size = new System.Drawing.Size(245, 24);
            this.cbo_client.TabIndex = 110;
            this.cbo_client.SelectedIndexChanged += new System.EventHandler(this.cbo_client_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 109;
            this.label3.Text = "Client ::";
            // 
            // lbl_order_id
            // 
            this.lbl_order_id.AutoSize = true;
            this.lbl_order_id.Location = new System.Drawing.Point(146, 306);
            this.lbl_order_id.Name = "lbl_order_id";
            this.lbl_order_id.Size = new System.Drawing.Size(326, 17);
            this.lbl_order_id.TabIndex = 108;
            this.lbl_order_id.Text = "Doubleclick the order to update from the list above";
            this.lbl_order_id.TextChanged += new System.EventHandler(this.lbl_order_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 107;
            this.label1.Text = "ORDER :: ";
            // 
            // listview_orders
            // 
            this.listview_orders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listview_orders.FullRowSelect = true;
            this.listview_orders.GridLines = true;
            this.listview_orders.Location = new System.Drawing.Point(17, 31);
            this.listview_orders.Name = "listview_orders";
            this.listview_orders.Size = new System.Drawing.Size(1004, 235);
            this.listview_orders.TabIndex = 128;
            this.listview_orders.UseCompatibleStateImageBehavior = false;
            this.listview_orders.View = System.Windows.Forms.View.Details;
            this.listview_orders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listview_orders_MouseDoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "OrderID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Client ID";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Order Method";
            this.columnHeader6.Width = 107;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Payment Status";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Shipping Date";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Expected Date";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "OCID";
            // 
            // Form_Update_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 716);
            this.Controls.Add(this.listview_orders);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.date_expected);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_save_order);
            this.Controls.Add(this.date_shipping);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Update_Orders";
            this.Text = "Update Orders";
            this.Load += new System.EventHandler(this.Form_Update_Orders_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DateTimePicker date_expected;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem modifyPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_save_order;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.DateTimePicker date_shipping;
        private System.Windows.Forms.TextBox txt_order_status;
        private System.Windows.Forms.ListView listview_addeditem;
        private System.Windows.Forms.Button btn_add_items;
        private System.Windows.Forms.ComboBox cbo_OCID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_payment_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_order_method;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_order_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listview_orders;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}