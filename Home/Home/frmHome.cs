using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class frmHome : Form
    {
        Color customGold = Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));

        frmStocksView.frmStocksView sv = new frmStocksView.frmStocksView();
        CustomerView.frmCustomerView cv = new CustomerView.frmCustomerView();
        frmSalesView.frmSalesView sav = new frmSalesView.frmSalesView();
        int x = 1;
        public frmHome()
        { 
            InitializeComponent();
            lblSideBar.Height = btnCustomer.Height;
            lblSideBar.Top = btnCustomer.Top;
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            x = 2;
            lblSideBar.Height = btnStocks.Height;
            lblSideBar.Top = btnStocks.Top;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            lblSideBar.Height = btnReturn.Height;
            lblSideBar.Top = btnReturn.Top;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            x = 3;
            lblSideBar.Height = btnSales.Height;
            lblSideBar.Top = btnSales.Top;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            x = 1;
            lblSideBar.Height = btnCustomer.Height;
            lblSideBar.Top = btnCustomer.Top;
        }

        private void btnCustomer_MouseEnter(object sender, EventArgs e)
        {
            btnCustomer.ForeColor = customGold;
        }

        private void btnCustomer_MouseLeave(object sender, EventArgs e)
        {
            btnCustomer.ForeColor = Color.LightGray;
        }

        private void btnStocks_MouseEnter(object sender, EventArgs e)
        {
            btnStocks.ForeColor = customGold;
        }

        private void btnStocks_MouseLeave(object sender, EventArgs e)
        {
            btnStocks.ForeColor = Color.LightGray;
        }

        private void btnSales_MouseEnter(object sender, EventArgs e)
        {
            btnSales.ForeColor = customGold;
        }

        private void btnSales_MouseLeave(object sender, EventArgs e)
        {
            btnSales.ForeColor = Color.LightGray;
        }

        private void btnReturn_MouseEnter(object sender, EventArgs e)
        {
            btnReturn.ForeColor = customGold;
        }

        private void btnReturn_MouseLeave(object sender, EventArgs e)
        {
            btnReturn.ForeColor = Color.LightGray;
        }

        private void btnReports_MouseEnter(object sender, EventArgs e)
        {
            btnReports.ForeColor = customGold;
        }

        private void btnReports_MouseLeave(object sender, EventArgs e)
        {
            btnReports.ForeColor = Color.LightGray;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                cv.Show();
                this.Hide();
            }else if (x == 2)
            {
                sv.Show();
                this.Hide();
            }else if (x == 3)
            {
                sav.Show();
                this.Hide();
            }
        }
    }
}
