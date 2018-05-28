namespace sales_mangment.PL
{
    partial class frm_main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.Label1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.indicator = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_report = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_bills = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_product = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_point_selas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_coutomer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_supplyer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.uc_point_sales11 = new sales_mangment.PL.uc_point_sales1();
            this.uc_supplyer11 = new sales_mangment.PL.uc_supplyer1();
            this.uc_coustomer11 = new sales_mangment.PL.uc_coustomer1();
            this.uc_procduct11 = new sales_mangment.PL.uc_procduct1();
            this.bills11 = new sales_mangment.PL.bills1();
            this.uc_report1 = new sales_mangment.PL.report.uc_report();
            this.uc_option1 = new sales_mangment.PL.uc_option();
            this.uc_users1 = new sales_mangment.PL.uc_users();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 70);
            this.panel1.TabIndex = 0;
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
            this.btn_close.TabIndex = 2;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("JF Flat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label1.Location = new System.Drawing.Point(1040, 15);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(175, 37);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "نظام ادارة مبيعات";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1221, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(42, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.indicator);
            this.panel2.Controls.Add(this.bunifuFlatButton8);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.bunifuFlatButton7);
            this.panel2.Controls.Add(this.btn_report);
            this.panel2.Controls.Add(this.btn_bills);
            this.panel2.Controls.Add(this.btn_product);
            this.panel2.Controls.Add(this.btn_point_selas);
            this.panel2.Controls.Add(this.btn_coutomer);
            this.panel2.Controls.Add(this.btn_supplyer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1275, 70);
            this.panel2.TabIndex = 1;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.Transparent;
            this.indicator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.indicator.LineThickness = 10;
            this.indicator.Location = new System.Drawing.Point(1125, 53);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(136, 10);
            this.indicator.TabIndex = 3;
            this.indicator.Transparency = 255;
            this.indicator.Vertical = false;
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 5;
            this.bunifuFlatButton8.ButtonText = "الاعدادات";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.ForeColor = System.Drawing.Color.Black;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = null;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 90D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(71, 6);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(136, 43);
            this.bunifuFlatButton8.TabIndex = 10;
            this.bunifuFlatButton8.Text = "الاعدادات";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Click += new System.EventHandler(this.bunifuFlatButton8_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 58);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1283, 10);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 5;
            this.bunifuFlatButton7.ButtonText = "المستخدمين";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.ForeColor = System.Drawing.Color.Black;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = null;
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 90D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(215, 6);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(136, 43);
            this.bunifuFlatButton7.TabIndex = 9;
            this.bunifuFlatButton7.Text = "المستخدمين";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton7.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // btn_report
            // 
            this.btn_report.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btn_report.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_report.BorderRadius = 5;
            this.btn_report.ButtonText = "تقارير";
            this.btn_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_report.DisabledColor = System.Drawing.Color.Gray;
            this.btn_report.ForeColor = System.Drawing.Color.Black;
            this.btn_report.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_report.Iconimage = null;
            this.btn_report.Iconimage_right = null;
            this.btn_report.Iconimage_right_Selected = null;
            this.btn_report.Iconimage_Selected = null;
            this.btn_report.IconMarginLeft = 0;
            this.btn_report.IconMarginRight = 0;
            this.btn_report.IconRightVisible = true;
            this.btn_report.IconRightZoom = 0D;
            this.btn_report.IconVisible = true;
            this.btn_report.IconZoom = 90D;
            this.btn_report.IsTab = false;
            this.btn_report.Location = new System.Drawing.Point(359, 6);
            this.btn_report.Name = "btn_report";
            this.btn_report.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_report.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btn_report.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btn_report.selected = false;
            this.btn_report.Size = new System.Drawing.Size(136, 43);
            this.btn_report.TabIndex = 8;
            this.btn_report.Text = "تقارير";
            this.btn_report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_report.Textcolor = System.Drawing.Color.Gray;
            this.btn_report.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_bills
            // 
            this.btn_bills.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btn_bills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_bills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bills.BorderRadius = 5;
            this.btn_bills.ButtonText = "ايصالات";
            this.btn_bills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bills.DisabledColor = System.Drawing.Color.Gray;
            this.btn_bills.ForeColor = System.Drawing.Color.Black;
            this.btn_bills.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_bills.Iconimage = null;
            this.btn_bills.Iconimage_right = null;
            this.btn_bills.Iconimage_right_Selected = null;
            this.btn_bills.Iconimage_Selected = null;
            this.btn_bills.IconMarginLeft = 0;
            this.btn_bills.IconMarginRight = 0;
            this.btn_bills.IconRightVisible = true;
            this.btn_bills.IconRightZoom = 0D;
            this.btn_bills.IconVisible = true;
            this.btn_bills.IconZoom = 90D;
            this.btn_bills.IsTab = false;
            this.btn_bills.Location = new System.Drawing.Point(503, 6);
            this.btn_bills.Name = "btn_bills";
            this.btn_bills.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_bills.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btn_bills.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btn_bills.selected = false;
            this.btn_bills.Size = new System.Drawing.Size(136, 43);
            this.btn_bills.TabIndex = 7;
            this.btn_bills.Text = "ايصالات";
            this.btn_bills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_bills.Textcolor = System.Drawing.Color.Gray;
            this.btn_bills.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bills.Click += new System.EventHandler(this.btn_bills_Click);
            // 
            // btn_product
            // 
            this.btn_product.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btn_product.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_product.BorderRadius = 5;
            this.btn_product.ButtonText = "الاصناف";
            this.btn_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_product.DisabledColor = System.Drawing.Color.Gray;
            this.btn_product.ForeColor = System.Drawing.Color.Black;
            this.btn_product.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_product.Iconimage = null;
            this.btn_product.Iconimage_right = null;
            this.btn_product.Iconimage_right_Selected = null;
            this.btn_product.Iconimage_Selected = null;
            this.btn_product.IconMarginLeft = 0;
            this.btn_product.IconMarginRight = 0;
            this.btn_product.IconRightVisible = true;
            this.btn_product.IconRightZoom = 0D;
            this.btn_product.IconVisible = true;
            this.btn_product.IconZoom = 90D;
            this.btn_product.IsTab = false;
            this.btn_product.Location = new System.Drawing.Point(647, 6);
            this.btn_product.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btn_product.Name = "btn_product";
            this.btn_product.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_product.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btn_product.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btn_product.selected = false;
            this.btn_product.Size = new System.Drawing.Size(159, 43);
            this.btn_product.TabIndex = 6;
            this.btn_product.Text = "الاصناف";
            this.btn_product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_product.Textcolor = System.Drawing.Color.Gray;
            this.btn_product.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_point_selas
            // 
            this.btn_point_selas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btn_point_selas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_point_selas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_point_selas.BorderRadius = 5;
            this.btn_point_selas.ButtonText = "نقطة البيع";
            this.btn_point_selas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_point_selas.DisabledColor = System.Drawing.Color.Gray;
            this.btn_point_selas.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btn_point_selas.ForeColor = System.Drawing.Color.Black;
            this.btn_point_selas.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_point_selas.Iconimage = null;
            this.btn_point_selas.Iconimage_right = null;
            this.btn_point_selas.Iconimage_right_Selected = null;
            this.btn_point_selas.Iconimage_Selected = null;
            this.btn_point_selas.IconMarginLeft = 0;
            this.btn_point_selas.IconMarginRight = 0;
            this.btn_point_selas.IconRightVisible = false;
            this.btn_point_selas.IconRightZoom = 0D;
            this.btn_point_selas.IconVisible = false;
            this.btn_point_selas.IconZoom = 90D;
            this.btn_point_selas.IsTab = false;
            this.btn_point_selas.Location = new System.Drawing.Point(1125, 6);
            this.btn_point_selas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_point_selas.Name = "btn_point_selas";
            this.btn_point_selas.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_point_selas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btn_point_selas.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btn_point_selas.selected = false;
            this.btn_point_selas.Size = new System.Drawing.Size(136, 43);
            this.btn_point_selas.TabIndex = 0;
            this.btn_point_selas.Text = "نقطة البيع";
            this.btn_point_selas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_point_selas.Textcolor = System.Drawing.Color.Gray;
            this.btn_point_selas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_point_selas.Click += new System.EventHandler(this.btn_point_selas_Click);
            // 
            // btn_coutomer
            // 
            this.btn_coutomer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btn_coutomer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_coutomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_coutomer.BorderRadius = 5;
            this.btn_coutomer.ButtonText = "عملاء";
            this.btn_coutomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_coutomer.DisabledColor = System.Drawing.Color.Gray;
            this.btn_coutomer.ForeColor = System.Drawing.Color.Black;
            this.btn_coutomer.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_coutomer.Iconimage = null;
            this.btn_coutomer.Iconimage_right = null;
            this.btn_coutomer.Iconimage_right_Selected = null;
            this.btn_coutomer.Iconimage_Selected = null;
            this.btn_coutomer.IconMarginLeft = 0;
            this.btn_coutomer.IconMarginRight = 0;
            this.btn_coutomer.IconRightVisible = true;
            this.btn_coutomer.IconRightZoom = 0D;
            this.btn_coutomer.IconVisible = true;
            this.btn_coutomer.IconZoom = 90D;
            this.btn_coutomer.IsTab = false;
            this.btn_coutomer.Location = new System.Drawing.Point(814, 6);
            this.btn_coutomer.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btn_coutomer.Name = "btn_coutomer";
            this.btn_coutomer.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_coutomer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btn_coutomer.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btn_coutomer.selected = false;
            this.btn_coutomer.Size = new System.Drawing.Size(159, 43);
            this.btn_coutomer.TabIndex = 5;
            this.btn_coutomer.Text = "عملاء";
            this.btn_coutomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_coutomer.Textcolor = System.Drawing.Color.Gray;
            this.btn_coutomer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_coutomer.Click += new System.EventHandler(this.btn_coutomer_Click);
            // 
            // btn_supplyer
            // 
            this.btn_supplyer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btn_supplyer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_supplyer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_supplyer.BorderRadius = 5;
            this.btn_supplyer.ButtonText = "موردين";
            this.btn_supplyer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_supplyer.DisabledColor = System.Drawing.Color.Gray;
            this.btn_supplyer.ForeColor = System.Drawing.Color.Black;
            this.btn_supplyer.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_supplyer.Iconimage = null;
            this.btn_supplyer.Iconimage_right = null;
            this.btn_supplyer.Iconimage_right_Selected = null;
            this.btn_supplyer.Iconimage_Selected = null;
            this.btn_supplyer.IconMarginLeft = 0;
            this.btn_supplyer.IconMarginRight = 0;
            this.btn_supplyer.IconRightVisible = true;
            this.btn_supplyer.IconRightZoom = 0D;
            this.btn_supplyer.IconVisible = true;
            this.btn_supplyer.IconZoom = 90D;
            this.btn_supplyer.IsTab = false;
            this.btn_supplyer.Location = new System.Drawing.Point(981, 6);
            this.btn_supplyer.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btn_supplyer.Name = "btn_supplyer";
            this.btn_supplyer.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_supplyer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btn_supplyer.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btn_supplyer.selected = false;
            this.btn_supplyer.Size = new System.Drawing.Size(136, 43);
            this.btn_supplyer.TabIndex = 4;
            this.btn_supplyer.Text = "موردين";
            this.btn_supplyer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_supplyer.Textcolor = System.Drawing.Color.Gray;
            this.btn_supplyer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplyer.Click += new System.EventHandler(this.btn_supplyer_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // uc_point_sales11
            // 
            this.uc_point_sales11.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_point_sales11.Location = new System.Drawing.Point(13, 141);
            this.uc_point_sales11.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.uc_point_sales11.Name = "uc_point_sales11";
            this.uc_point_sales11.Size = new System.Drawing.Size(1251, 573);
            this.uc_point_sales11.TabIndex = 2;
            // 
            // uc_supplyer11
            // 
            this.uc_supplyer11.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_supplyer11.Location = new System.Drawing.Point(13, 141);
            this.uc_supplyer11.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.uc_supplyer11.Name = "uc_supplyer11";
            this.uc_supplyer11.Size = new System.Drawing.Size(1251, 613);
            this.uc_supplyer11.TabIndex = 3;
            // 
            // uc_coustomer11
            // 
            this.uc_coustomer11.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_coustomer11.Location = new System.Drawing.Point(13, 141);
            this.uc_coustomer11.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.uc_coustomer11.Name = "uc_coustomer11";
            this.uc_coustomer11.Size = new System.Drawing.Size(1251, 613);
            this.uc_coustomer11.TabIndex = 4;
            // 
            // uc_procduct11
            // 
            this.uc_procduct11.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_procduct11.Location = new System.Drawing.Point(13, 141);
            this.uc_procduct11.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uc_procduct11.Name = "uc_procduct11";
            this.uc_procduct11.Size = new System.Drawing.Size(1251, 613);
            this.uc_procduct11.TabIndex = 5;
            // 
            // bills11
            // 
            this.bills11.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bills11.Location = new System.Drawing.Point(13, 141);
            this.bills11.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bills11.Name = "bills11";
            this.bills11.Size = new System.Drawing.Size(1251, 613);
            this.bills11.TabIndex = 6;
            // 
            // uc_report1
            // 
            this.uc_report1.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_report1.Location = new System.Drawing.Point(13, 141);
            this.uc_report1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.uc_report1.Name = "uc_report1";
            this.uc_report1.Size = new System.Drawing.Size(1251, 573);
            this.uc_report1.TabIndex = 7;
            // 
            // uc_option1
            // 
            this.uc_option1.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_option1.Location = new System.Drawing.Point(13, 141);
            this.uc_option1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.uc_option1.Name = "uc_option1";
            this.uc_option1.Size = new System.Drawing.Size(1251, 613);
            this.uc_option1.TabIndex = 8;
            // 
            // uc_users1
            // 
            this.uc_users1.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_users1.Location = new System.Drawing.Point(13, 141);
            this.uc_users1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.uc_users1.Name = "uc_users1";
            this.uc_users1.Size = new System.Drawing.Size(1251, 573);
            this.uc_users1.TabIndex = 9;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1275, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uc_point_sales11);
            this.Controls.Add(this.uc_supplyer11);
            this.Controls.Add(this.uc_coustomer11);
            this.Controls.Add(this.uc_procduct11);
            this.Controls.Add(this.bills11);
            this.Controls.Add(this.uc_report1);
            this.Controls.Add(this.uc_option1);
            this.Controls.Add(this.uc_users1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel Label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Bunifu.Framework.UI.BunifuFlatButton btn_report;
        private Bunifu.Framework.UI.BunifuFlatButton btn_bills;
        private Bunifu.Framework.UI.BunifuFlatButton btn_product;
        private Bunifu.Framework.UI.BunifuFlatButton btn_coutomer;
        private Bunifu.Framework.UI.BunifuFlatButton btn_supplyer;
        private Bunifu.Framework.UI.BunifuSeparator indicator;
        private Bunifu.Framework.UI.BunifuFlatButton btn_point_selas;
        private uc_point_sales1 uc_point_sales11;
        private uc_supplyer1 uc_supplyer11;
        private uc_coustomer1 uc_coustomer11;
        private uc_procduct1 uc_procduct11;
        private bills1 bills11;
        private report.uc_report uc_report1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private uc_option uc_option1;
        private uc_users uc_users1;
    }
}