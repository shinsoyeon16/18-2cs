﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YICMS.BL;

namespace YonginCMS.Win
{
    public partial class Form1 : Form
    {
        CustomerRepository cr = new CustomerRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void GetCustomerListButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var customerList = cr.Retrieve();
            CustomerGrid.DataSource = 
        }
    }
}
