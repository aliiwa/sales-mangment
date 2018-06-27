namespace sales_mangment.PL.report
{
    partial class uc_rpt_sales_point
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_rpt_sales_point));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_print = new System.Windows.Forms.GroupBox();
            this.btn_search = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_search = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dgv_date = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_rep_inv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_print_all = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.btn_print.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rep_inv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 111);
            this.panel1.TabIndex = 5;
            // 
            // btn_print
            // 
            this.btn_print.Controls.Add(this.btn_search);
            this.btn_print.Controls.Add(this.bunifuCustomLabel1);
            this.btn_print.Controls.Add(this.txt_search);
            this.btn_print.Location = new System.Drawing.Point(4, 6);
            this.btn_print.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_print.Name = "btn_print";
            this.btn_print.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_print.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_print.Size = new System.Drawing.Size(1230, 94);
            this.btn_print.TabIndex = 0;
            this.btn_print.TabStop = false;
            this.btn_print.Text = "جرد الارصدة";
            // 
            // btn_search
            // 
            this.btn_search.ActiveBorderThickness = 1;
            this.btn_search.ActiveCornerRadius = 20;
            this.btn_search.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btn_search.ActiveForecolor = System.Drawing.Color.White;
            this.btn_search.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.ButtonText = "بحث";
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_search.IdleBorderThickness = 1;
            this.btn_search.IdleCornerRadius = 20;
            this.btn_search.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btn_search.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_search.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btn_search.Location = new System.Drawing.Point(71, 30);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5, 14, 5, 14);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(156, 53);
            this.btn_search.TabIndex = 4;
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1117, 42);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(42, 28);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "بحث";
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_search.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_search.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(525, 39);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(563, 35);
            this.txt_search.TabIndex = 0;
            // 
            // dgv_date
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_date.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_date.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_date.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_date.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("JF Flat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_date.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_date.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_date.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11});
            this.dgv_date.DoubleBuffered = true;
            this.dgv_date.EnableHeadersVisualStyles = false;
            this.dgv_date.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.dgv_date.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_date.Location = new System.Drawing.Point(979, 123);
            this.dgv_date.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgv_date.Name = "dgv_date";
            this.dgv_date.ReadOnly = true;
            this.dgv_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_date.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_date.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_date.Size = new System.Drawing.Size(255, 368);
            this.dgv_date.TabIndex = 7;
            this.dgv_date.Click += new System.EventHandler(this.dgv_date_Click);
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "salesDate";
            this.Column11.HeaderText = "التاريخ";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // dgv_rep_inv
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_rep_inv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_rep_inv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rep_inv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_rep_inv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_rep_inv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("JF Flat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rep_inv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_rep_inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rep_inv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Column12,
            this.Column1,
            this.Column2});
            this.dgv_rep_inv.DoubleBuffered = true;
            this.dgv_rep_inv.EnableHeadersVisualStyles = false;
            this.dgv_rep_inv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.dgv_rep_inv.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_rep_inv.Location = new System.Drawing.Point(217, 123);
            this.dgv_rep_inv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgv_rep_inv.Name = "dgv_rep_inv";
            this.dgv_rep_inv.ReadOnly = true;
            this.dgv_rep_inv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_rep_inv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_rep_inv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_rep_inv.Size = new System.Drawing.Size(754, 368);
            this.dgv_rep_inv.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sales_code";
            this.dataGridViewTextBoxColumn3.HeaderText = "رقم الفاتورة";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "total_invoes";
            this.Column12.HeaderText = "القيمة";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sumTotal";
            this.Column1.HeaderText = "المجموع";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sDate";
            this.Column2.HeaderText = "التاريخ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "طباعة";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(5, 123);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5, 14, 5, 14);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(203, 53);
            this.bunifuThinButton21.TabIndex = 9;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btn_print_all
            // 
            this.btn_print_all.ActiveBorderThickness = 1;
            this.btn_print_all.ActiveCornerRadius = 20;
            this.btn_print_all.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btn_print_all.ActiveForecolor = System.Drawing.Color.White;
            this.btn_print_all.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btn_print_all.BackColor = System.Drawing.SystemColors.Control;
            this.btn_print_all.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_print_all.BackgroundImage")));
            this.btn_print_all.ButtonText = "طباعة التفاصيل";
            this.btn_print_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print_all.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_all.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_print_all.IdleBorderThickness = 1;
            this.btn_print_all.IdleCornerRadius = 20;
            this.btn_print_all.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btn_print_all.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_print_all.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btn_print_all.Location = new System.Drawing.Point(5, 180);
            this.btn_print_all.Margin = new System.Windows.Forms.Padding(5, 14, 5, 14);
            this.btn_print_all.Name = "btn_print_all";
            this.btn_print_all.Size = new System.Drawing.Size(203, 53);
            this.btn_print_all.TabIndex = 10;
            this.btn_print_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_print_all.Click += new System.EventHandler(this.btn_print_all_Click);
            // 
            // uc_rpt_sales_point
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_print_all);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.dgv_rep_inv);
            this.Controls.Add(this.dgv_date);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("JF Flat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "uc_rpt_sales_point";
            this.Size = new System.Drawing.Size(1251, 501);
            this.panel1.ResumeLayout(false);
            this.btn_print.ResumeLayout(false);
            this.btn_print.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rep_inv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox btn_print;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_search;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_search;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgv_date;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgv_rep_inv;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_print_all;
    }
}
