namespace HiTechApp.GUI
{
    partial class Form_Add_new_author
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
            this.save_New_Author1 = new Save_new_Author.Save_New_Author();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // save_New_Author1
            // 
            this.save_New_Author1.Location = new System.Drawing.Point(13, 13);
            this.save_New_Author1.Name = "save_New_Author1";
            this.save_New_Author1.Size = new System.Drawing.Size(669, 576);
            this.save_New_Author1.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(412, 195);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(232, 30);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form_Add_new_author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 599);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.save_New_Author1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Add_new_author";
            this.Text = "Add New Author";
            this.ResumeLayout(false);

        }

        #endregion

        private Save_new_Author.Save_New_Author save_New_Author1;
        private System.Windows.Forms.Button btn_exit;
    }
}