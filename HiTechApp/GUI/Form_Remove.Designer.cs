namespace HiTechApp.GUI
{
    partial class Form_Remove
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
            this.delete_Info_InvenController1 = new Delete_Item_Author_Publisher_info.Delete_Info_InvenController();
            this.SuspendLayout();
            // 
            // delete_Info_InvenController1
            // 
            this.delete_Info_InvenController1.Location = new System.Drawing.Point(12, 12);
            this.delete_Info_InvenController1.Name = "delete_Info_InvenController1";
            this.delete_Info_InvenController1.Size = new System.Drawing.Size(340, 507);
            this.delete_Info_InvenController1.TabIndex = 0;
            // 
            // Form_Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 542);
            this.Controls.Add(this.delete_Info_InvenController1);
            this.Name = "Form_Remove";
            this.Text = "Delete Information";
            this.ResumeLayout(false);

        }

        #endregion

        private Delete_Item_Author_Publisher_info.Delete_Info_InvenController delete_Info_InvenController1;
    }
}