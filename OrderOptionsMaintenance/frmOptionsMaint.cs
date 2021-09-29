﻿using OrderOptionsMaintenance.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderOptionsMaintenance
{
    public partial class frmOptionsMaint : Form
    {
        private MMABooksContext _context;
        private OrderOption _OrderOption;
        public frmOptionsMaint()
        {
            InitializeComponent();
        }

        private void frmOptionsMaint_Load(object sender, EventArgs e)
        {
            _context = new MMABooksContext();
            _OrderOption = _context.OrderOptions.First();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    decimal SalesTaxRate = Convert.ToDecimal(txtSalesTax);
                    decimal FirstBookShipCharge = Convert.ToDecimal(txtShipFirstBook);
                    decimal AdditionalBookShipCharge = Convert.ToDecimal(txtShipAddlBook);
                    IsValidData();
                }
                catch(Exception)
                {
                    MessageBox.Show("Please enter a valid nuber", "Entry Error");

                }
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtSalesTax) &&
                   Validator.IsDecimal(txtSalesTax) &&
                   Validator.IsPresent(txtShipFirstBook) &&
                   Validator.IsDecimal(txtShipFirstBook) &&
                   Validator.IsPresent(txtShipAddlBook) &&
                   Validator.IsDecimal(txtShipAddlBook);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
