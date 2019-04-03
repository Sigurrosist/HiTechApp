namespace HiTechApp.GUI
{
    partial class Form_Update_Password
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
            this.modify_Pwd1 = new Update_password.Modify_Pwd();
            this.SuspendLayout();
            // 
            // modify_Pwd1
            // 
            this.modify_Pwd1.Location = new System.Drawing.Point(12, 12);
            this.modify_Pwd1.Name = "modify_Pwd1";
            this.modify_Pwd1.Size = new System.Drawing.Size(382, 271);
            this.modify_Pwd1.TabIndex = 0;
            // 
            // Form_Update_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 295);
            this.Controls.Add(this.modify_Pwd1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Update_Password";
            this.Text = "Change your Password";
            this.ResumeLayout(false);

        }

        #endregion

        private Update_password.Modify_Pwd modify_Pwd1;
    }
}