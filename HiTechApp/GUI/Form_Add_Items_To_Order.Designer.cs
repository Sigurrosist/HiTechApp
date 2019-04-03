namespace HiTechApp.GUI
{
    partial class Form_Add_Items_To_Order
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listview_search_item = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.btn_item_search = new System.Windows.Forms.Button();
            this.rad_item_title = new System.Windows.Forms.RadioButton();
            this.rad_item_id = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_software = new System.Windows.Forms.RadioButton();
            this.radio_book = new System.Windows.Forms.RadioButton();
            this.txt_itemid = new System.Windows.Forms.TextBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.cbo_quantity = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listview_added_items = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lbl_order_id = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listview_search_item);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(887, 426);
            this.groupBox3.TabIndex = 88;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search For Item";
            // 
            // listview_search_item
            // 
            this.listview_search_item.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.title,
            this.type,
            this.price,
            this.quantity});
            this.listview_search_item.FullRowSelect = true;
            this.listview_search_item.GridLines = true;
            this.listview_search_item.Location = new System.Drawing.Point(20, 187);
            this.listview_search_item.Name = "listview_search_item";
            this.listview_search_item.Size = new System.Drawing.Size(861, 233);
            this.listview_search_item.TabIndex = 82;
            this.listview_search_item.UseCompatibleStateImageBehavior = false;
            this.listview_search_item.View = System.Windows.Forms.View.Details;
            this.listview_search_item.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listview_search_item_MouseDoubleClick);
            // 
            // id
            // 
            this.id.Text = "ItemID";
            this.id.Width = 70;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 250;
            // 
            // type
            // 
            this.type.Text = "Item Type";
            this.type.Width = 151;
            // 
            // price
            // 
            this.price.Text = "Price (CAD)";
            this.price.Width = 80;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_key);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbo_type);
            this.groupBox2.Controls.Add(this.btn_item_search);
            this.groupBox2.Controls.Add(this.rad_item_title);
            this.groupBox2.Controls.Add(this.rad_item_id);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 56);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search By";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(468, 23);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(159, 24);
            this.txt_key.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 94;
            this.label2.Text = "Keyword :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 93;
            this.label1.Text = "Item Type :";
            // 
            // cbo_type
            // 
            this.cbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Location = new System.Drawing.Point(250, 21);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(121, 26);
            this.cbo_type.TabIndex = 92;
            // 
            // btn_item_search
            // 
            this.btn_item_search.Location = new System.Drawing.Point(702, 16);
            this.btn_item_search.Name = "btn_item_search";
            this.btn_item_search.Size = new System.Drawing.Size(158, 34);
            this.btn_item_search.TabIndex = 90;
            this.btn_item_search.Text = "Search For &Item";
            this.btn_item_search.UseVisualStyleBackColor = true;
            this.btn_item_search.Click += new System.EventHandler(this.btn_item_search_Click);
            // 
            // rad_item_title
            // 
            this.rad_item_title.AutoSize = true;
            this.rad_item_title.Location = new System.Drawing.Point(78, 23);
            this.rad_item_title.Name = "rad_item_title";
            this.rad_item_title.Size = new System.Drawing.Size(56, 22);
            this.rad_item_title.TabIndex = 87;
            this.rad_item_title.TabStop = true;
            this.rad_item_title.Text = "Title";
            this.rad_item_title.UseVisualStyleBackColor = true;
            // 
            // rad_item_id
            // 
            this.rad_item_id.AutoSize = true;
            this.rad_item_id.Location = new System.Drawing.Point(7, 23);
            this.rad_item_id.Name = "rad_item_id";
            this.rad_item_id.Size = new System.Drawing.Size(43, 22);
            this.rad_item_id.TabIndex = 86;
            this.rad_item_id.TabStop = true;
            this.rad_item_id.Text = "ID";
            this.rad_item_id.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_software);
            this.groupBox1.Controls.Add(this.radio_book);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 56);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search For";
            // 
            // radio_software
            // 
            this.radio_software.AutoSize = true;
            this.radio_software.Location = new System.Drawing.Point(496, 21);
            this.radio_software.Name = "radio_software";
            this.radio_software.Size = new System.Drawing.Size(88, 22);
            this.radio_software.TabIndex = 1;
            this.radio_software.TabStop = true;
            this.radio_software.Text = "Software";
            this.radio_software.UseVisualStyleBackColor = true;
            this.radio_software.CheckedChanged += new System.EventHandler(this.radio_software_CheckedChanged);
            // 
            // radio_book
            // 
            this.radio_book.AutoSize = true;
            this.radio_book.Location = new System.Drawing.Point(217, 21);
            this.radio_book.Name = "radio_book";
            this.radio_book.Size = new System.Drawing.Size(65, 22);
            this.radio_book.TabIndex = 0;
            this.radio_book.TabStop = true;
            this.radio_book.Text = "Book";
            this.radio_book.UseVisualStyleBackColor = true;
            this.radio_book.CheckedChanged += new System.EventHandler(this.radio_book_CheckedChanged);
            // 
            // txt_itemid
            // 
            this.txt_itemid.Location = new System.Drawing.Point(147, 34);
            this.txt_itemid.Name = "txt_itemid";
            this.txt_itemid.ReadOnly = true;
            this.txt_itemid.Size = new System.Drawing.Size(231, 24);
            this.txt_itemid.TabIndex = 91;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(401, 137);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(36, 31);
            this.btn_remove.TabIndex = 109;
            this.btn_remove.Text = "<<";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // cbo_quantity
            // 
            this.cbo_quantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_quantity.FormattingEnabled = true;
            this.cbo_quantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111"});
            this.cbo_quantity.Location = new System.Drawing.Point(147, 131);
            this.cbo_quantity.Name = "cbo_quantity";
            this.cbo_quantity.Size = new System.Drawing.Size(231, 26);
            this.cbo_quantity.TabIndex = 108;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 18);
            this.label11.TabIndex = 107;
            this.label11.Text = "Quantity ::";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 18);
            this.label12.TabIndex = 105;
            this.label12.Text = "Title ::";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 18);
            this.label13.TabIndex = 103;
            this.label13.Text = "Item ID ::";
            // 
            // listview_added_items
            // 
            this.listview_added_items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listview_added_items.FullRowSelect = true;
            this.listview_added_items.GridLines = true;
            this.listview_added_items.Location = new System.Drawing.Point(454, 34);
            this.listview_added_items.Name = "listview_added_items";
            this.listview_added_items.Size = new System.Drawing.Size(427, 169);
            this.listview_added_items.TabIndex = 101;
            this.listview_added_items.UseCompatibleStateImageBehavior = false;
            this.listview_added_items.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item ID";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(401, 76);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(36, 31);
            this.btn_add.TabIndex = 100;
            this.btn_add.Text = ">>";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_type);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txt_title);
            this.groupBox4.Controls.Add(this.listview_added_items);
            this.groupBox4.Controls.Add(this.btn_remove);
            this.groupBox4.Controls.Add(this.btn_add);
            this.groupBox4.Controls.Add(this.txt_itemid);
            this.groupBox4.Controls.Add(this.cbo_quantity);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 540);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(887, 236);
            this.groupBox4.TabIndex = 85;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add or Remove Items to order";
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(147, 179);
            this.txt_type.Name = "txt_type";
            this.txt_type.ReadOnly = true;
            this.txt_type.Size = new System.Drawing.Size(231, 24);
            this.txt_type.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 111;
            this.label4.Text = "Type ::";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(147, 83);
            this.txt_title.Name = "txt_title";
            this.txt_title.ReadOnly = true;
            this.txt_title.Size = new System.Drawing.Size(231, 24);
            this.txt_title.TabIndex = 110;
            // 
            // lbl_order_id
            // 
            this.lbl_order_id.AutoSize = true;
            this.lbl_order_id.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_order_id.Location = new System.Drawing.Point(12, 507);
            this.lbl_order_id.Name = "lbl_order_id";
            this.lbl_order_id.Size = new System.Drawing.Size(437, 17);
            this.lbl_order_id.TabIndex = 89;
            this.lbl_order_id.Text = "Double Click the item to add from the list above, and set the quantity";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(704, 782);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(195, 32);
            this.btn_save.TabIndex = 90;
            this.btn_save.Text = "&Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(933, 28);
            this.menuStrip1.TabIndex = 94;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 17);
            this.label3.TabIndex = 95;
            this.label3.Text = "Search Items, and double click the items to add";
            // 
            // Form_Add_Items_To_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 831);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_order_id);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Add_Items_To_Order";
            this.Text = "Add Items to Order";
            this.Load += new System.EventHandler(this.Form_Add_Items_To_Order_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listview_search_item;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_type;
        private System.Windows.Forms.TextBox txt_itemid;
        private System.Windows.Forms.Button btn_item_search;
        private System.Windows.Forms.RadioButton rad_item_title;
        private System.Windows.Forms.RadioButton rad_item_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_software;
        private System.Windows.Forms.RadioButton radio_book;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ComboBox cbo_quantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listview_added_items;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_order_id;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyPasswordToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}