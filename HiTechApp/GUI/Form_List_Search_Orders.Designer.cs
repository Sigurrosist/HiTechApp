namespace HiTechApp.GUI
{
    partial class Form_List_Search_Orders
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
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview_orders = new System.Windows.Forms.ListView();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_order_status = new System.Windows.Forms.TextBox();
            this.listview_addeditem = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_instruction1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_search_method = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_instruction2 = new System.Windows.Forms.Label();
            this.lbl_target = new System.Windows.Forms.Label();
            this.cbo_target = new System.Windows.Forms.ComboBox();
            this.rad_book = new System.Windows.Forms.RadioButton();
            this.rad_software = new System.Windows.Forms.RadioButton();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.btn_list = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "OCID";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Shipping Date";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Payment Status";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Order Method";
            this.columnHeader6.Width = 107;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Client ID";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "OrderID";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Expected Date";
            this.columnHeader9.Width = 150;
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
            this.listview_orders.Location = new System.Drawing.Point(17, 64);
            this.listview_orders.Name = "listview_orders";
            this.listview_orders.Size = new System.Drawing.Size(1004, 235);
            this.listview_orders.TabIndex = 150;
            this.listview_orders.UseCompatibleStateImageBehavior = false;
            this.listview_orders.View = System.Windows.Forms.View.Details;
            this.listview_orders.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listview_orders_ItemSelectionChanged);
            this.listview_orders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listview_orders_MouseDoubleClick);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(830, 667);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(191, 31);
            this.btn_Exit.TabIndex = 149;
            this.btn_Exit.Text = "E&XIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(654, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 146;
            this.label8.Text = "ORDER STATUS :: ";
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
            this.menuStrip1.Size = new System.Drawing.Size(1080, 28);
            this.menuStrip1.TabIndex = 145;
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
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(109, 621);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(191, 31);
            this.btn_search.TabIndex = 144;
            this.btn_search.Text = "&Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_order_status
            // 
            this.txt_order_status.Location = new System.Drawing.Point(666, 331);
            this.txt_order_status.Multiline = true;
            this.txt_order_status.Name = "txt_order_status";
            this.txt_order_status.ReadOnly = true;
            this.txt_order_status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_order_status.Size = new System.Drawing.Size(355, 313);
            this.txt_order_status.TabIndex = 143;
            // 
            // listview_addeditem
            // 
            this.listview_addeditem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listview_addeditem.FullRowSelect = true;
            this.listview_addeditem.GridLines = true;
            this.listview_addeditem.Location = new System.Drawing.Point(393, 331);
            this.listview_addeditem.Name = "listview_addeditem";
            this.listview_addeditem.Size = new System.Drawing.Size(246, 313);
            this.listview_addeditem.TabIndex = 142;
            this.listview_addeditem.UseCompatibleStateImageBehavior = false;
            this.listview_addeditem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Item Price";
            this.columnHeader3.Width = 70;
            // 
            // lbl_instruction1
            // 
            this.lbl_instruction1.AutoSize = true;
            this.lbl_instruction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instruction1.Location = new System.Drawing.Point(14, 334);
            this.lbl_instruction1.Name = "lbl_instruction1";
            this.lbl_instruction1.Size = new System.Drawing.Size(184, 18);
            this.lbl_instruction1.TabIndex = 131;
            this.lbl_instruction1.Text = "1. Select a search method.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 129;
            this.label1.Text = "Search by :: ";
            // 
            // cbo_search_method
            // 
            this.cbo_search_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_search_method.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_search_method.FormattingEnabled = true;
            this.cbo_search_method.Location = new System.Drawing.Point(133, 383);
            this.cbo_search_method.Name = "cbo_search_method";
            this.cbo_search_method.Size = new System.Drawing.Size(217, 26);
            this.cbo_search_method.TabIndex = 151;
            this.cbo_search_method.TextChanged += new System.EventHandler(this.cbo_search_method_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 152;
            this.label2.Text = "ORDER LIST :: ";
            // 
            // lbl_instruction2
            // 
            this.lbl_instruction2.AutoSize = true;
            this.lbl_instruction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instruction2.Location = new System.Drawing.Point(14, 445);
            this.lbl_instruction2.Name = "lbl_instruction2";
            this.lbl_instruction2.Size = new System.Drawing.Size(238, 18);
            this.lbl_instruction2.TabIndex = 153;
            this.lbl_instruction2.Text = "2. Enter the keyword for the search";
            // 
            // lbl_target
            // 
            this.lbl_target.AutoSize = true;
            this.lbl_target.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_target.Location = new System.Drawing.Point(16, 524);
            this.lbl_target.Name = "lbl_target";
            this.lbl_target.Size = new System.Drawing.Size(82, 18);
            this.lbl_target.TabIndex = 155;
            this.lbl_target.Text = "Keyword :: ";
            // 
            // cbo_target
            // 
            this.cbo_target.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_target.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_target.FormattingEnabled = true;
            this.cbo_target.Location = new System.Drawing.Point(146, 521);
            this.cbo_target.Name = "cbo_target";
            this.cbo_target.Size = new System.Drawing.Size(204, 26);
            this.cbo_target.TabIndex = 156;
            this.cbo_target.SelectedIndexChanged += new System.EventHandler(this.cbo_target_SelectedIndexChanged);
            // 
            // rad_book
            // 
            this.rad_book.AutoSize = true;
            this.rad_book.Location = new System.Drawing.Point(104, 480);
            this.rad_book.Name = "rad_book";
            this.rad_book.Size = new System.Drawing.Size(61, 21);
            this.rad_book.TabIndex = 0;
            this.rad_book.TabStop = true;
            this.rad_book.Text = "Book";
            this.rad_book.UseVisualStyleBackColor = true;
            this.rad_book.CheckedChanged += new System.EventHandler(this.rad_book_CheckedChanged);
            // 
            // rad_software
            // 
            this.rad_software.AutoSize = true;
            this.rad_software.Location = new System.Drawing.Point(245, 480);
            this.rad_software.Name = "rad_software";
            this.rad_software.Size = new System.Drawing.Size(84, 21);
            this.rad_software.TabIndex = 1;
            this.rad_software.TabStop = true;
            this.rad_software.Text = "Software";
            this.rad_software.UseVisualStyleBackColor = true;
            this.rad_software.CheckedChanged += new System.EventHandler(this.rad_software_CheckedChanged);
            // 
            // datepicker
            // 
            this.datepicker.Location = new System.Drawing.Point(119, 553);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(231, 22);
            this.datepicker.TabIndex = 158;
            this.datepicker.ValueChanged += new System.EventHandler(this.datepicker_ValueChanged);
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(583, 667);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(191, 31);
            this.btn_list.TabIndex = 159;
            this.btn_list.Text = "&LIST";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // Form_List_Search_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 740);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.rad_software);
            this.Controls.Add(this.rad_book);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.cbo_target);
            this.Controls.Add(this.lbl_target);
            this.Controls.Add(this.lbl_instruction2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_search_method);
            this.Controls.Add(this.listview_orders);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_order_status);
            this.Controls.Add(this.listview_addeditem);
            this.Controls.Add(this.lbl_instruction1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_List_Search_Orders";
            this.Text = "List and Search Orders";
            this.Load += new System.EventHandler(this.Form_List_Search_Orders_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listview_orders;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyPasswordToolStripMenuItem;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_order_status;
        private System.Windows.Forms.ListView listview_addeditem;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lbl_instruction1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_search_method;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_instruction2;
        private System.Windows.Forms.Label lbl_target;
        private System.Windows.Forms.ComboBox cbo_target;
        private System.Windows.Forms.RadioButton rad_software;
        private System.Windows.Forms.RadioButton rad_book;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Button btn_list;
    }
}