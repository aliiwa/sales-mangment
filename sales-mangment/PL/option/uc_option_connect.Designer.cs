namespace sales_mangment.PL.option
{
    partial class uc_option_connect
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_db_name = new System.Windows.Forms.TextBox();
            this.txt_server_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.GroupBox();
            this.rdo_sql = new System.Windows.Forms.RadioButton();
            this.rdo_authentication = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.btn_save.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 336);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1194, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اعدادات الاتصال بالسيرفر";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txt_password);
            this.groupBox4.Controls.Add(this.txt_username);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(6, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(890, 119);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "بيانات الدخول";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "اسم الدخول ";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(105, 74);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(497, 35);
            this.txt_password.TabIndex = 8;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(105, 25);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(497, 35);
            this.txt_username.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "كلمة المرور";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_db_name);
            this.groupBox3.Controls.Add(this.txt_server_name);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(890, 122);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات السيرفر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "اسم قاعدة البيانات";
            // 
            // txt_db_name
            // 
            this.txt_db_name.Location = new System.Drawing.Point(105, 75);
            this.txt_db_name.Name = "txt_db_name";
            this.txt_db_name.Size = new System.Drawing.Size(497, 35);
            this.txt_db_name.TabIndex = 5;
            // 
            // txt_server_name
            // 
            this.txt_server_name.Location = new System.Drawing.Point(105, 26);
            this.txt_server_name.Name = "txt_server_name";
            this.txt_server_name.Size = new System.Drawing.Size(497, 35);
            this.txt_server_name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "اسم السيرفر";
            // 
            // btn_save
            // 
            this.btn_save.Controls.Add(this.rdo_sql);
            this.btn_save.Controls.Add(this.rdo_authentication);
            this.btn_save.Location = new System.Drawing.Point(902, 34);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(277, 247);
            this.btn_save.TabIndex = 2;
            this.btn_save.TabStop = false;
            this.btn_save.Text = "طريقة الاتصال";
            // 
            // rdo_sql
            // 
            this.rdo_sql.AutoSize = true;
            this.rdo_sql.Location = new System.Drawing.Point(7, 152);
            this.rdo_sql.Name = "rdo_sql";
            this.rdo_sql.Size = new System.Drawing.Size(264, 32);
            this.rdo_sql.TabIndex = 1;
            this.rdo_sql.TabStop = true;
            this.rdo_sql.Text = "SQL ServerAuthentication mode";
            this.rdo_sql.UseVisualStyleBackColor = true;
            this.rdo_sql.CheckedChanged += new System.EventHandler(this.rdo_sql_CheckedChanged);
            // 
            // rdo_authentication
            // 
            this.rdo_authentication.AutoSize = true;
            this.rdo_authentication.Location = new System.Drawing.Point(17, 74);
            this.rdo_authentication.Name = "rdo_authentication";
            this.rdo_authentication.Size = new System.Drawing.Size(251, 32);
            this.rdo_authentication.TabIndex = 0;
            this.rdo_authentication.TabStop = true;
            this.rdo_authentication.Text = "Windows Authentication mode";
            this.rdo_authentication.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "تفريغ البيانات";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "حفظ الاعدادات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uc_option_connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "uc_option_connect";
            this.Size = new System.Drawing.Size(1223, 534);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.btn_save.ResumeLayout(false);
            this.btn_save.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_db_name;
        private System.Windows.Forms.TextBox txt_server_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox btn_save;
        private System.Windows.Forms.RadioButton rdo_sql;
        private System.Windows.Forms.RadioButton rdo_authentication;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
