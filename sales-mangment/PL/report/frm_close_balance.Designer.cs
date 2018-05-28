namespace sales_mangment.PL.report
{
    partial class frm_close_balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_close_balance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_add_balance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dt_balance = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 70);
            this.panel1.TabIndex = 30;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("JF Flat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label1.Location = new System.Drawing.Point(308, 12);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(81, 37);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "الارصدة";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageActive = null;
            this.btn_close.Location = new System.Drawing.Point(12, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(29, 33);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 3;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dt_balance);
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 103);
            this.panel2.TabIndex = 31;
            // 
            // btn_add_balance
            // 
            this.btn_add_balance.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btn_add_balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btn_add_balance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_balance.BorderRadius = 0;
            this.btn_add_balance.ButtonText = "اغلاق الارصدة";
            this.btn_add_balance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_balance.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_balance.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_balance.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add_balance.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_add_balance.Iconimage")));
            this.btn_add_balance.Iconimage_right = null;
            this.btn_add_balance.Iconimage_right_Selected = null;
            this.btn_add_balance.Iconimage_Selected = null;
            this.btn_add_balance.IconMarginLeft = 0;
            this.btn_add_balance.IconMarginRight = 0;
            this.btn_add_balance.IconRightVisible = false;
            this.btn_add_balance.IconRightZoom = 0D;
            this.btn_add_balance.IconVisible = true;
            this.btn_add_balance.IconZoom = 70D;
            this.btn_add_balance.IsTab = false;
            this.btn_add_balance.Location = new System.Drawing.Point(12, 178);
            this.btn_add_balance.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_balance.Name = "btn_add_balance";
            this.btn_add_balance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btn_add_balance.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btn_add_balance.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_balance.selected = false;
            this.btn_add_balance.Size = new System.Drawing.Size(373, 48);
            this.btn_add_balance.TabIndex = 36;
            this.btn_add_balance.Text = "اغلاق الارصدة";
            this.btn_add_balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_balance.Textcolor = System.Drawing.Color.White;
            this.btn_add_balance.TextFont = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_balance.Click += new System.EventHandler(this.btn_add_balance_Click);
            // 
            // dt_balance
            // 
            this.dt_balance.Location = new System.Drawing.Point(102, 34);
            this.dt_balance.Name = "dt_balance";
            this.dt_balance.Size = new System.Drawing.Size(200, 20);
            this.dt_balance.TabIndex = 0;
            // 
            // frm_close_balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 233);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_add_balance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_close_balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_close_balance";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel Label1;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dt_balance;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_balance;
    }
}