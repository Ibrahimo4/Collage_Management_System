﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace College_Management_System
{
    public partial class frmPrintOptions : Form
    {
        public frmPrintOptions()
        {
            InitializeComponent();
        }
         public frmPrintOptions(List<string> availableFields)
        {
            InitializeComponent();

            foreach (string field in availableFields)
                     chklst.Items.Add(field, true);
        }
        public List<string> GetSelectedColumns()
        {
            List<string> lst = new List<string>();
            foreach (object item in chklst.CheckedItems)
                lst.Add(item.ToString());
            return lst;
        }

        public string PrintTitle
        {
            get { return txtTitle.Text; }
        }

        public bool PrintAllRows
        {
            get { return rdoAllRows.Checked; }
        }

        public bool FitToPageWidth
        {
            get { return chkFitToPageWidth.Checked; }
        }
        private void PrintOptions_Load(object sender, EventArgs e)
        {
            // Initialize some controls
            rdoAllRows.Checked = true;
            chkFitToPageWidth.Checked = true; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

      
    }
}
