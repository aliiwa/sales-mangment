namespace sales_mangment.PL
{
    partial class uc_users
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chk_bills = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chk_point_sales = new Bunifu.Framework.UI.BunifuCheckbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uc_user_control1 = new sales_mangment.PL.users.uc_user_control();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.chk_bills);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.chk_point_sales);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 56);
            this.panel1.TabIndex = 2;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.bunifuSeparator1.LineThickness = 129;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 49);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1251, 10);
            this.bunifuSeparator1.TabIndex = 8;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(922, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(112, 28);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "ادارة الصلاحيات";
            // 
            // chk_bills
            // 
            this.chk_bills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chk_bills.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_bills.Checked = false;
            this.chk_bills.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chk_bills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_bills.ForeColor = System.Drawing.Color.White;
            this.chk_bills.Location = new System.Drawing.Point(1041, 13);
            this.chk_bills.Margin = new System.Windows.Forms.Padding(9, 28, 9, 28);
            this.chk_bills.Name = "chk_bills";
            this.chk_bills.Size = new System.Drawing.Size(20, 20);
            this.chk_bills.TabIndex = 6;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1073, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(118, 28);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "اضافة مستخدم";
            // 
            // chk_point_sales
            // 
            this.chk_point_sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chk_point_sales.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_point_sales.Checked = true;
            this.chk_point_sales.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chk_point_sales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_point_sales.ForeColor = System.Drawing.Color.White;
            this.chk_point_sales.Location = new System.Drawing.Point(1194, 13);
            this.chk_point_sales.Margin = new System.Windows.Forms.Padding(6, 13, 6, 13);
            this.chk_point_sales.Name = "chk_point_sales";
            this.chk_point_sales.Size = new System.Drawing.Size(20, 20);
            this.chk_point_sales.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uc_user_control1);
            this.panel2.Location = new System.Drawing.Point(43, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1171, 513);
            this.panel2.TabIndex = 3;
            // 
            // uc_user_control1
            // 
            this.uc_user_control1.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_user_control1.Location = new System.Drawing.Point(0, 0);
            this.uc_user_control1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.uc_user_control1.Name = "uc_user_control1";
            this.uc_user_control1.Size = new System.Drawing.Size(1171, 513);
            this.uc_user_control1.TabIndex = 0;
            // 
            // uc_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "uc_users";
            this.Size = new System.Drawing.Size(1251, 573);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCheckbox chk_bills;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCheckbox chk_point_sales;
        private System.Windows.Forms.Panel panel2;
        private users.uc_user_control uc_user_control1;
    }
}
