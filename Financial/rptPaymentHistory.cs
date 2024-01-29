﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial
{
    public partial class rptPaymentHistory : Form
    {
        int userID;
        public rptPaymentHistory(int id)
        {
            InitializeComponent();
            userID = id;
        }

        private void rptPaymentHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AccSummery1.AccountData' table. You can move, or remove it, as needed.
            //this.AccountDataTableAdapter.Fill(this.AccSummery1.AccountData, userID);
            // TODO: This line of code loads data into the 'PaymentHistory1.PaymentHistory' table. You can move, or remove it, as needed.
            this.PaymentHistoryTableAdapter.Fill(this.PaymentHistory1.PaymentHistory, userID);

            this.reportViewer1.RefreshReport();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
