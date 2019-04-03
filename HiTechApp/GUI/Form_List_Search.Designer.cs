namespace HiTechApp.GUI
{
    partial class Form_List_Search
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_software = new System.Windows.Forms.RadioButton();
            this.radio_book = new System.Windows.Forms.RadioButton();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.btn_item_search = new System.Windows.Forms.Button();
            this.rad_aid = new System.Windows.Forms.RadioButton();
            this.rad_pub_year = new System.Windows.Forms.RadioButton();
            this.rad_item_title = new System.Windows.Forms.RadioButton();
            this.rad_item_id = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.btn_author_search = new System.Windows.Forms.Button();
            this.rad_author_name = new System.Windows.Forms.RadioButton();
            this.rad_author_id = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txt_pub = new System.Windows.Forms.TextBox();
            this.btn_pub_search = new System.Windows.Forms.Button();
            this.rad_publisher_name = new System.Windows.Forms.RadioButton();
            this.rad_publisher_id = new System.Windows.Forms.RadioButton();
            this.btn_exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_software);
            this.groupBox1.Controls.Add(this.radio_book);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 56);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search For";
            // 
            // radio_software
            // 
            this.radio_software.AutoSize = true;
            this.radio_software.Location = new System.Drawing.Point(177, 21);
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
            this.radio_book.Location = new System.Drawing.Point(39, 21);
            this.radio_book.Name = "radio_book";
            this.radio_book.Size = new System.Drawing.Size(65, 22);
            this.radio_book.TabIndex = 0;
            this.radio_book.TabStop = true;
            this.radio_book.Text = "Book";
            this.radio_book.UseVisualStyleBackColor = true;
            this.radio_book.CheckedChanged += new System.EventHandler(this.radio_book_CheckedChanged);
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
            this.listView1.Location = new System.Drawing.Point(20, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1442, 233);
            this.listView1.TabIndex = 82;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ItemID";
            this.id.Width = 70;
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
            this.type.Width = 151;
            // 
            // pubyear
            // 
            this.pubyear.Text = "Year";
            this.pubyear.Width = 45;
            // 
            // publisher
            // 
            this.publisher.Text = "Publisher ID";
            this.publisher.Width = 104;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbo_type);
            this.groupBox2.Controls.Add(this.txt_item);
            this.groupBox2.Controls.Add(this.btn_item_search);
            this.groupBox2.Controls.Add(this.rad_aid);
            this.groupBox2.Controls.Add(this.rad_pub_year);
            this.groupBox2.Controls.Add(this.rad_item_title);
            this.groupBox2.Controls.Add(this.rad_item_id);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(334, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1128, 56);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 94;
            this.label2.Text = "Keyword :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 93;
            this.label1.Text = "Item Type :";
            // 
            // cbo_type
            // 
            this.cbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Location = new System.Drawing.Point(512, 20);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(121, 26);
            this.cbo_type.TabIndex = 92;
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(744, 21);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(156, 24);
            this.txt_item.TabIndex = 91;
            // 
            // btn_item_search
            // 
            this.btn_item_search.Location = new System.Drawing.Point(986, 16);
            this.btn_item_search.Name = "btn_item_search";
            this.btn_item_search.Size = new System.Drawing.Size(136, 34);
            this.btn_item_search.TabIndex = 90;
            this.btn_item_search.Text = "Search For &Item";
            this.btn_item_search.UseVisualStyleBackColor = true;
            this.btn_item_search.Click += new System.EventHandler(this.btn_item_search_Click);
            // 
            // rad_aid
            // 
            this.rad_aid.AutoSize = true;
            this.rad_aid.Location = new System.Drawing.Point(307, 23);
            this.rad_aid.Name = "rad_aid";
            this.rad_aid.Size = new System.Drawing.Size(90, 22);
            this.rad_aid.TabIndex = 89;
            this.rad_aid.TabStop = true;
            this.rad_aid.Text = "Author ID";
            this.rad_aid.UseVisualStyleBackColor = true;
            // 
            // rad_pub_year
            // 
            this.rad_pub_year.AutoSize = true;
            this.rad_pub_year.Location = new System.Drawing.Point(151, 23);
            this.rad_pub_year.Name = "rad_pub_year";
            this.rad_pub_year.Size = new System.Drawing.Size(127, 22);
            this.rad_pub_year.TabIndex = 88;
            this.rad_pub_year.TabStop = true;
            this.rad_pub_year.Text = "Published Year";
            this.rad_pub_year.UseVisualStyleBackColor = true;
            // 
            // rad_item_title
            // 
            this.rad_item_title.AutoSize = true;
            this.rad_item_title.Location = new System.Drawing.Point(71, 23);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1480, 340);
            this.groupBox3.TabIndex = 87;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search For Item";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listView2);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(13, 387);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(802, 400);
            this.groupBox4.TabIndex = 88;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search For Author";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.name,
            this.email});
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(164, 42);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(619, 331);
            this.listView2.TabIndex = 93;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Author ID";
            // 
            // name
            // 
            this.name.Text = "Author Full name";
            this.name.Width = 200;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 200;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_author);
            this.groupBox5.Controls.Add(this.btn_author_search);
            this.groupBox5.Controls.Add(this.rad_author_name);
            this.groupBox5.Controls.Add(this.rad_author_id);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(19, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(129, 342);
            this.groupBox5.TabIndex = 91;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search By";
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(9, 231);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(109, 24);
            this.txt_author.TabIndex = 92;
            // 
            // btn_author_search
            // 
            this.btn_author_search.Location = new System.Drawing.Point(7, 273);
            this.btn_author_search.Name = "btn_author_search";
            this.btn_author_search.Size = new System.Drawing.Size(111, 49);
            this.btn_author_search.TabIndex = 90;
            this.btn_author_search.Text = "Search For &Author";
            this.btn_author_search.UseVisualStyleBackColor = true;
            this.btn_author_search.Click += new System.EventHandler(this.btn_author_search_Click);
            // 
            // rad_author_name
            // 
            this.rad_author_name.AutoSize = true;
            this.rad_author_name.Location = new System.Drawing.Point(25, 171);
            this.rad_author_name.Name = "rad_author_name";
            this.rad_author_name.Size = new System.Drawing.Size(69, 22);
            this.rad_author_name.TabIndex = 87;
            this.rad_author_name.TabStop = true;
            this.rad_author_name.Text = "Name";
            this.rad_author_name.UseVisualStyleBackColor = true;
            // 
            // rad_author_id
            // 
            this.rad_author_id.AutoSize = true;
            this.rad_author_id.Location = new System.Drawing.Point(25, 88);
            this.rad_author_id.Name = "rad_author_id";
            this.rad_author_id.Size = new System.Drawing.Size(43, 22);
            this.rad_author_id.TabIndex = 86;
            this.rad_author_id.TabStop = true;
            this.rad_author_id.Text = "ID";
            this.rad_author_id.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listView3);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(833, 387);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(659, 400);
            this.groupBox6.TabIndex = 92;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search For Publisher";
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(174, 42);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(467, 331);
            this.listView3.TabIndex = 93;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Publisher ID";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Publisher";
            this.columnHeader3.Width = 200;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txt_pub);
            this.groupBox7.Controls.Add(this.btn_pub_search);
            this.groupBox7.Controls.Add(this.rad_publisher_name);
            this.groupBox7.Controls.Add(this.rad_publisher_id);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(34, 31);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(125, 342);
            this.groupBox7.TabIndex = 92;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Search By";
            // 
            // txt_pub
            // 
            this.txt_pub.Location = new System.Drawing.Point(7, 243);
            this.txt_pub.Name = "txt_pub";
            this.txt_pub.Size = new System.Drawing.Size(105, 24);
            this.txt_pub.TabIndex = 93;
            // 
            // btn_pub_search
            // 
            this.btn_pub_search.Location = new System.Drawing.Point(7, 273);
            this.btn_pub_search.Name = "btn_pub_search";
            this.btn_pub_search.Size = new System.Drawing.Size(105, 49);
            this.btn_pub_search.TabIndex = 90;
            this.btn_pub_search.Text = "Search For &Publisher";
            this.btn_pub_search.UseVisualStyleBackColor = true;
            this.btn_pub_search.Click += new System.EventHandler(this.btn_pub_search_Click);
            // 
            // rad_publisher_name
            // 
            this.rad_publisher_name.AutoSize = true;
            this.rad_publisher_name.Location = new System.Drawing.Point(22, 171);
            this.rad_publisher_name.Name = "rad_publisher_name";
            this.rad_publisher_name.Size = new System.Drawing.Size(69, 22);
            this.rad_publisher_name.TabIndex = 87;
            this.rad_publisher_name.TabStop = true;
            this.rad_publisher_name.Text = "Name";
            this.rad_publisher_name.UseVisualStyleBackColor = true;
            // 
            // rad_publisher_id
            // 
            this.rad_publisher_id.AutoSize = true;
            this.rad_publisher_id.Location = new System.Drawing.Point(22, 88);
            this.rad_publisher_id.Name = "rad_publisher_id";
            this.rad_publisher_id.Size = new System.Drawing.Size(43, 22);
            this.rad_publisher_id.TabIndex = 86;
            this.rad_publisher_id.TabStop = true;
            this.rad_publisher_id.Text = "ID";
            this.rad_publisher_id.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1303, 807);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(189, 34);
            this.btn_exit.TabIndex = 91;
            this.btn_exit.Text = "&Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1533, 28);
            this.menuStrip1.TabIndex = 93;
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
            // Form_List_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 856);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_List_Search";
            this.Text = "List and Search";
            this.Load += new System.EventHandler(this.Form_List_Search_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_software;
        private System.Windows.Forms.RadioButton radio_book;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.Button btn_item_search;
        private System.Windows.Forms.RadioButton rad_aid;
        private System.Windows.Forms.RadioButton rad_pub_year;
        private System.Windows.Forms.RadioButton rad_item_title;
        private System.Windows.Forms.RadioButton rad_item_id;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_author_search;
        private System.Windows.Forms.RadioButton rad_author_name;
        private System.Windows.Forms.RadioButton rad_author_id;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_pub_search;
        private System.Windows.Forms.RadioButton rad_publisher_name;
        private System.Windows.Forms.RadioButton rad_publisher_id;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_pub;
        private System.Windows.Forms.ComboBox cbo_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem modifyPasswordToolStripMenuItem;
    }
}