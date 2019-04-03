namespace HiTechApp.GUI
{
    partial class Form_Save_New_Items
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
            this.radio_software = new System.Windows.Forms.RadioButton();
            this.radio_book = new System.Windows.Forms.RadioButton();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_authors = new System.Windows.Forms.Label();
            this.btn_newpublisher = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_newauthor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_thisauthor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pubyear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isbn10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isbn13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbo_itemtype = new System.Windows.Forms.ComboBox();
            this.cbo_publisher = new System.Windows.Forms.ComboBox();
            this.lbl_isbn10 = new System.Windows.Forms.Label();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbo_author1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbo_category = new System.Windows.Forms.ComboBox();
            this.lbl_isbn13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_s_type = new System.Windows.Forms.ComboBox();
            this.lbl_software = new System.Windows.Forms.Label();
            this.cbo_pubyear = new System.Windows.Forms.ComboBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_isbn13 = new System.Windows.Forms.TextBox();
            this.txt_isbn10 = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio_software
            // 
            this.radio_software.AutoSize = true;
            this.radio_software.Location = new System.Drawing.Point(255, 21);
            this.radio_software.Name = "radio_software";
            this.radio_software.Size = new System.Drawing.Size(84, 21);
            this.radio_software.TabIndex = 1;
            this.radio_software.TabStop = true;
            this.radio_software.Text = "Software";
            this.radio_software.UseVisualStyleBackColor = true;
            this.radio_software.CheckedChanged += new System.EventHandler(this.radio_software_CheckedChanged);
            // 
            // radio_book
            // 
            this.radio_book.AutoSize = true;
            this.radio_book.Location = new System.Drawing.Point(39, 21);
            this.radio_book.Name = "radio_book";
            this.radio_book.Size = new System.Drawing.Size(61, 21);
            this.radio_book.TabIndex = 0;
            this.radio_book.TabStop = true;
            this.radio_book.Text = "Book";
            this.radio_book.UseVisualStyleBackColor = true;
            this.radio_book.CheckedChanged += new System.EventHandler(this.radio_book_CheckedChanged);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(349, 207);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(147, 28);
            this.btn_remove.TabIndex = 167;
            this.btn_remove.Text = "Remove this Author";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1188, 625);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(300, 31);
            this.btn_exit.TabIndex = 166;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_authors
            // 
            this.lbl_authors.AutoSize = true;
            this.lbl_authors.Location = new System.Drawing.Point(181, 245);
            this.lbl_authors.Name = "lbl_authors";
            this.lbl_authors.Size = new System.Drawing.Size(0, 17);
            this.lbl_authors.TabIndex = 164;
            // 
            // btn_newpublisher
            // 
            this.btn_newpublisher.Location = new System.Drawing.Point(987, 304);
            this.btn_newpublisher.Name = "btn_newpublisher";
            this.btn_newpublisher.Size = new System.Drawing.Size(158, 23);
            this.btn_newpublisher.TabIndex = 163;
            this.btn_newpublisher.Text = "Save New Publisher";
            this.btn_newpublisher.UseVisualStyleBackColor = true;
            this.btn_newpublisher.Click += new System.EventHandler(this.btn_newpublisher_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(412, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(569, 17);
            this.label8.TabIndex = 162;
            this.label8.Text = "If there is no information for the publisher you are looking for, please add new " +
    "publishers.";
            // 
            // btn_newauthor
            // 
            this.btn_newauthor.Location = new System.Drawing.Point(987, 262);
            this.btn_newauthor.Name = "btn_newauthor";
            this.btn_newauthor.Size = new System.Drawing.Size(158, 23);
            this.btn_newauthor.TabIndex = 161;
            this.btn_newauthor.Text = "Save New Author";
            this.btn_newauthor.UseVisualStyleBackColor = true;
            this.btn_newauthor.Click += new System.EventHandler(this.btn_newauthor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(446, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(535, 17);
            this.label5.TabIndex = 160;
            this.label5.Text = "If there is no information for the author you are looking for, please add new aut" +
    "hors.";
            // 
            // btn_thisauthor
            // 
            this.btn_thisauthor.Location = new System.Drawing.Point(181, 207);
            this.btn_thisauthor.Name = "btn_thisauthor";
            this.btn_thisauthor.Size = new System.Drawing.Size(147, 28);
            this.btn_thisauthor.TabIndex = 159;
            this.btn_thisauthor.Text = "Add this Author";
            this.btn_thisauthor.UseVisualStyleBackColor = true;
            this.btn_thisauthor.Click += new System.EventHandler(this.btn_thisauthor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 158;
            this.label4.Text = "Added Author ID";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.title,
            this.authorid,
            this.category,
            this.type,
            this.pubyear,
            this.publisher,
            this.price,
            this.isbn10,
            this.isbn13,
            this.stype,
            this.quantity});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(17, 378);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1471, 233);
            this.listView1.TabIndex = 145;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ItemID";
            this.id.Width = 45;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 230;
            // 
            // authorid
            // 
            this.authorid.Text = "Author ID";
            this.authorid.Width = 100;
            // 
            // category
            // 
            this.category.Text = "Category";
            this.category.Width = 130;
            // 
            // type
            // 
            this.type.Text = "Item Type";
            this.type.Width = 70;
            // 
            // pubyear
            // 
            this.pubyear.Text = "Year";
            this.pubyear.Width = 45;
            // 
            // publisher
            // 
            this.publisher.Text = "Publisher ID";
            this.publisher.Width = 75;
            // 
            // price
            // 
            this.price.Text = "Price";
            // 
            // isbn10
            // 
            this.isbn10.Text = "ISBN10";
            this.isbn10.Width = 80;
            // 
            // isbn13
            // 
            this.isbn13.Text = "ISBN13";
            this.isbn13.Width = 100;
            // 
            // stype
            // 
            this.stype.Text = "Software Type";
            this.stype.Width = 90;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            // 
            // cbo_itemtype
            // 
            this.cbo_itemtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_itemtype.FormattingEnabled = true;
            this.cbo_itemtype.Location = new System.Drawing.Point(665, 178);
            this.cbo_itemtype.Name = "cbo_itemtype";
            this.cbo_itemtype.Size = new System.Drawing.Size(315, 24);
            this.cbo_itemtype.TabIndex = 144;
            this.cbo_itemtype.SelectedIndexChanged += new System.EventHandler(this.cbo_itemtype_SelectedIndexChanged);
            // 
            // cbo_publisher
            // 
            this.cbo_publisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_publisher.FormattingEnabled = true;
            this.cbo_publisher.Location = new System.Drawing.Point(665, 116);
            this.cbo_publisher.Name = "cbo_publisher";
            this.cbo_publisher.Size = new System.Drawing.Size(315, 24);
            this.cbo_publisher.TabIndex = 143;
            this.cbo_publisher.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbo_publisher_MouseClick_1);
            // 
            // lbl_isbn10
            // 
            this.lbl_isbn10.AutoSize = true;
            this.lbl_isbn10.Location = new System.Drawing.Point(995, 90);
            this.lbl_isbn10.Name = "lbl_isbn10";
            this.lbl_isbn10.Size = new System.Drawing.Size(69, 17);
            this.lbl_isbn10.TabIndex = 131;
            this.lbl_isbn10.Text = "ISBN (10)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cbo_author1
            // 
            this.cbo_author1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_author1.FormattingEnabled = true;
            this.cbo_author1.Location = new System.Drawing.Point(181, 177);
            this.cbo_author1.Name = "cbo_author1";
            this.cbo_author1.Size = new System.Drawing.Size(250, 24);
            this.cbo_author1.TabIndex = 141;
            this.cbo_author1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbo_author1_MouseClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 17);
            this.label15.TabIndex = 140;
            this.label15.Text = "Category";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(520, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 139;
            this.label14.Text = "ItemType";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(520, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 17);
            this.label13.TabIndex = 138;
            this.label13.Text = "Published year";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(520, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 17);
            this.label12.TabIndex = 137;
            this.label12.Text = "Publisher ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(520, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 136;
            this.label11.Text = "Unit Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(14, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 135;
            this.label9.Text = "Item ID";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(178, 90);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(218, 17);
            this.lbl_id.TabIndex = 134;
            this.lbl_id.Text = "ID will be generated automatically";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 133;
            this.label7.Text = "Author ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 132;
            this.label6.Text = "Title";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cbo_category
            // 
            this.cbo_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_category.FormattingEnabled = true;
            this.cbo_category.Location = new System.Drawing.Point(181, 146);
            this.cbo_category.Name = "cbo_category";
            this.cbo_category.Size = new System.Drawing.Size(250, 24);
            this.cbo_category.TabIndex = 142;
            // 
            // lbl_isbn13
            // 
            this.lbl_isbn13.AutoSize = true;
            this.lbl_isbn13.Location = new System.Drawing.Point(995, 119);
            this.lbl_isbn13.Name = "lbl_isbn13";
            this.lbl_isbn13.Size = new System.Drawing.Size(69, 17);
            this.lbl_isbn13.TabIndex = 130;
            this.lbl_isbn13.Text = "ISBN (13)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 25);
            this.label1.TabIndex = 129;
            this.label1.Text = "<< Save New Item Information >>";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_software);
            this.groupBox1.Controls.Add(this.radio_book);
            this.groupBox1.Location = new System.Drawing.Point(17, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 56);
            this.groupBox1.TabIndex = 157;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 156;
            this.label3.Text = "<< LIST >>";
            // 
            // cbo_s_type
            // 
            this.cbo_s_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_s_type.FormattingEnabled = true;
            this.cbo_s_type.Location = new System.Drawing.Point(1155, 181);
            this.cbo_s_type.Name = "cbo_s_type";
            this.cbo_s_type.Size = new System.Drawing.Size(300, 24);
            this.cbo_s_type.TabIndex = 155;
            // 
            // lbl_software
            // 
            this.lbl_software.AutoSize = true;
            this.lbl_software.Location = new System.Drawing.Point(995, 184);
            this.lbl_software.Name = "lbl_software";
            this.lbl_software.Size = new System.Drawing.Size(99, 17);
            this.lbl_software.TabIndex = 154;
            this.lbl_software.Text = "Software Type";
            // 
            // cbo_pubyear
            // 
            this.cbo_pubyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_pubyear.FormattingEnabled = true;
            this.cbo_pubyear.Location = new System.Drawing.Point(665, 87);
            this.cbo_pubyear.Name = "cbo_pubyear";
            this.cbo_pubyear.Size = new System.Drawing.Size(315, 24);
            this.cbo_pubyear.TabIndex = 153;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(1155, 150);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(300, 22);
            this.txt_quantity.TabIndex = 152;
            // 
            // txt_isbn13
            // 
            this.txt_isbn13.Location = new System.Drawing.Point(1155, 118);
            this.txt_isbn13.Name = "txt_isbn13";
            this.txt_isbn13.Size = new System.Drawing.Size(300, 22);
            this.txt_isbn13.TabIndex = 151;
            // 
            // txt_isbn10
            // 
            this.txt_isbn10.Location = new System.Drawing.Point(1155, 89);
            this.txt_isbn10.Name = "txt_isbn10";
            this.txt_isbn10.Size = new System.Drawing.Size(300, 22);
            this.txt_isbn10.TabIndex = 150;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(665, 150);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(315, 22);
            this.txt_price.TabIndex = 149;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(995, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 147;
            this.label2.Text = "Quantity";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1534, 28);
            this.menuStrip1.TabIndex = 165;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(181, 116);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(315, 22);
            this.txt_title.TabIndex = 148;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(1155, 211);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(300, 31);
            this.btn_save.TabIndex = 146;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form_Save_New_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 688);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_authors);
            this.Controls.Add(this.btn_newpublisher);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_newauthor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_thisauthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cbo_itemtype);
            this.Controls.Add(this.cbo_publisher);
            this.Controls.Add(this.lbl_isbn10);
            this.Controls.Add(this.cbo_author1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_category);
            this.Controls.Add(this.lbl_isbn13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_s_type);
            this.Controls.Add(this.lbl_software);
            this.Controls.Add(this.cbo_pubyear);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_isbn13);
            this.Controls.Add(this.txt_isbn10);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.btn_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Save_New_Items";
            this.Text = "Save New Item";
            this.Load += new System.EventHandler(this.Form_Save_New_Items_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_software;
        private System.Windows.Forms.RadioButton radio_book;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_authors;
        private System.Windows.Forms.Button btn_newpublisher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_newauthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_thisauthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader authorid;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader pubyear;
        private System.Windows.Forms.ColumnHeader publisher;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader isbn10;
        private System.Windows.Forms.ColumnHeader isbn13;
        private System.Windows.Forms.ColumnHeader stype;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ComboBox cbo_itemtype;
        private System.Windows.Forms.ComboBox cbo_publisher;
        private System.Windows.Forms.Label lbl_isbn10;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbo_author1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbo_category;
        private System.Windows.Forms.Label lbl_isbn13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_s_type;
        private System.Windows.Forms.Label lbl_software;
        private System.Windows.Forms.ComboBox cbo_pubyear;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_isbn13;
        private System.Windows.Forms.TextBox txt_isbn10;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Button btn_save;
    }
}