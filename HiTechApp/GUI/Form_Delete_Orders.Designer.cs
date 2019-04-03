namespace HiTechApp.GUI
{
    partial class Form_Delete_Orders
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_item_name = new System.Windows.Forms.TextBox();
            this.group_item = new System.Windows.Forms.GroupBox();
            this.lbl_item_name = new System.Windows.Forms.Label();
            this.txt_item_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_your_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.group_item.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(29, 306);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(283, 28);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_item_name
            // 
            this.txt_item_name.Location = new System.Drawing.Point(114, 60);
            this.txt_item_name.Name = "txt_item_name";
            this.txt_item_name.Size = new System.Drawing.Size(141, 22);
            this.txt_item_name.TabIndex = 9;
            // 
            // group_item
            // 
            this.group_item.Controls.Add(this.txt_item_name);
            this.group_item.Controls.Add(this.lbl_item_name);
            this.group_item.Controls.Add(this.txt_item_id);
            this.group_item.Controls.Add(this.lbl_id);
            this.group_item.Location = new System.Drawing.Point(29, 180);
            this.group_item.Name = "group_item";
            this.group_item.Size = new System.Drawing.Size(283, 102);
            this.group_item.TabIndex = 13;
            this.group_item.TabStop = false;
            this.group_item.Text = "Order Information";
            // 
            // lbl_item_name
            // 
            this.lbl_item_name.AutoSize = true;
            this.lbl_item_name.Location = new System.Drawing.Point(22, 63);
            this.lbl_item_name.Name = "lbl_item_name";
            this.lbl_item_name.Size = new System.Drawing.Size(68, 17);
            this.lbl_item_name.TabIndex = 2;
            this.lbl_item_name.Text = "Client ID :";
            // 
            // txt_item_id
            // 
            this.txt_item_id.Location = new System.Drawing.Point(114, 32);
            this.txt_item_id.Name = "txt_item_id";
            this.txt_item_id.Size = new System.Drawing.Size(141, 22);
            this.txt_item_id.TabIndex = 8;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(22, 32);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(33, 17);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID : ";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(114, 61);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(141, 22);
            this.txt_password.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.txt_your_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(29, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your ID and Password";
            // 
            // txt_your_id
            // 
            this.txt_your_id.Location = new System.Drawing.Point(114, 33);
            this.txt_your_id.Name = "txt_your_id";
            this.txt_your_id.Size = new System.Drawing.Size(141, 22);
            this.txt_your_id.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "ID : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "DELETE INFORMATION";
            // 
            // Form_Delete_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 359);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.group_item);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Delete_Orders";
            this.Text = "Delete Orders";
            this.group_item.ResumeLayout(false);
            this.group_item.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_item_name;
        private System.Windows.Forms.GroupBox group_item;
        private System.Windows.Forms.Label lbl_item_name;
        private System.Windows.Forms.TextBox txt_item_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_your_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}