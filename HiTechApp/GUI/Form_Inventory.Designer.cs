namespace HiTechApp.GUI
{
    partial class Form_Inventory
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
            this.rad_updateitem = new System.Windows.Forms.RadioButton();
            this.rad_newauthor = new System.Windows.Forms.RadioButton();
            this.rad_newpublisher = new System.Windows.Forms.RadioButton();
            this.rad_list_search = new System.Windows.Forms.RadioButton();
            this.rad_delete = new System.Windows.Forms.RadioButton();
            this.rad_newitem = new System.Windows.Forms.RadioButton();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_updateitem);
            this.groupBox1.Controls.Add(this.rad_newauthor);
            this.groupBox1.Controls.Add(this.rad_newpublisher);
            this.groupBox1.Controls.Add(this.rad_list_search);
            this.groupBox1.Controls.Add(this.rad_delete);
            this.groupBox1.Controls.Add(this.rad_newitem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose the task to start";
            // 
            // rad_updateitem
            // 
            this.rad_updateitem.AutoSize = true;
            this.rad_updateitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_updateitem.Location = new System.Drawing.Point(6, 71);
            this.rad_updateitem.Name = "rad_updateitem";
            this.rad_updateitem.Size = new System.Drawing.Size(186, 22);
            this.rad_updateitem.TabIndex = 5;
            this.rad_updateitem.TabStop = true;
            this.rad_updateitem.Text = "Update Item Information";
            this.rad_updateitem.UseVisualStyleBackColor = true;
            // 
            // rad_newauthor
            // 
            this.rad_newauthor.AutoSize = true;
            this.rad_newauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_newauthor.Location = new System.Drawing.Point(6, 110);
            this.rad_newauthor.Name = "rad_newauthor";
            this.rad_newauthor.Size = new System.Drawing.Size(151, 22);
            this.rad_newauthor.TabIndex = 4;
            this.rad_newauthor.TabStop = true;
            this.rad_newauthor.Text = "Save New Authors";
            this.rad_newauthor.UseVisualStyleBackColor = true;
            // 
            // rad_newpublisher
            // 
            this.rad_newpublisher.AutoSize = true;
            this.rad_newpublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_newpublisher.Location = new System.Drawing.Point(6, 150);
            this.rad_newpublisher.Name = "rad_newpublisher";
            this.rad_newpublisher.Size = new System.Drawing.Size(169, 22);
            this.rad_newpublisher.TabIndex = 3;
            this.rad_newpublisher.TabStop = true;
            this.rad_newpublisher.Text = "Save New Publishers";
            this.rad_newpublisher.UseVisualStyleBackColor = true;
            // 
            // rad_list_search
            // 
            this.rad_list_search.AutoSize = true;
            this.rad_list_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_list_search.Location = new System.Drawing.Point(6, 189);
            this.rad_list_search.Name = "rad_list_search";
            this.rad_list_search.Size = new System.Drawing.Size(131, 22);
            this.rad_list_search.TabIndex = 2;
            this.rad_list_search.TabStop = true;
            this.rad_list_search.Text = "List and Search";
            this.rad_list_search.UseVisualStyleBackColor = true;
            // 
            // rad_delete
            // 
            this.rad_delete.AutoSize = true;
            this.rad_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_delete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rad_delete.Location = new System.Drawing.Point(6, 228);
            this.rad_delete.Name = "rad_delete";
            this.rad_delete.Size = new System.Drawing.Size(106, 22);
            this.rad_delete.TabIndex = 1;
            this.rad_delete.TabStop = true;
            this.rad_delete.Text = "Delete Data";
            this.rad_delete.UseVisualStyleBackColor = true;
            // 
            // rad_newitem
            // 
            this.rad_newitem.AutoSize = true;
            this.rad_newitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_newitem.Location = new System.Drawing.Point(6, 33);
            this.rad_newitem.Name = "rad_newitem";
            this.rad_newitem.Size = new System.Drawing.Size(128, 22);
            this.rad_newitem.TabIndex = 0;
            this.rad_newitem.TabStop = true;
            this.rad_newitem.Text = "Save New Item";
            this.rad_newitem.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(14, 366);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(112, 36);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "&Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(228, 366);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(112, 36);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "E&xit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(360, 26);
            this.menuStrip3.TabIndex = 3;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "<< Manage Inventory >>";
            // 
            // Form_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 424);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Inventory";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.Form_Inventory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_newitem;
        private System.Windows.Forms.RadioButton rad_updateitem;
        private System.Windows.Forms.RadioButton rad_newauthor;
        private System.Windows.Forms.RadioButton rad_newpublisher;
        private System.Windows.Forms.RadioButton rad_list_search;
        private System.Windows.Forms.RadioButton rad_delete;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}