﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sales_mangment.PL.report
{
    public partial class uc_rep_product : UserControl

    {
        BL.CLS_Report rpt = new BL.CLS_Report();
        DataTable Dt = new DataTable();
        public uc_rep_product()
        {
            InitializeComponent();
            
        }
    }
}
