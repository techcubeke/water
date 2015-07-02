using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Water.pos;
using Water.customers;
using Water.bill;
using Water.fee;
using Water.users;


namespace Water.Dashboard
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            products prod = new products();
            prod.ShowDialog();

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recordSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sale sal = new sale();
            sal.ShowDialog();
        }

        private void newApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customercreate appl = new customercreate();
            appl.ShowDialog();
        }

        private void viewApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applications appl = new applications();
            appl.ShowDialog();
        }

        private void generateByUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recordConsumptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billcreate sal = new billcreate();
            sal.ShowDialog();
        }

        private void viewConsumptionRecorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billdetails sal = new billdetails();
            sal.ShowDialog();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customercreate sal = new customercreate();
            sal.ShowDialog();
        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custdetails sal = new custdetails();
            sal.ShowDialog();
        }

        private void actvicateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addFeeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fees fe = new fees();
            fe.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user usr = new user();
            usr.ShowDialog();
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userdetails usr = new userdetails();
            usr.ShowDialog();
        }

        private void recordBillPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consumption cs = new consumption();
            cs.ShowDialog();

        }

        private void newConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newcon nc = new newcon();
            nc.ShowDialog();
        }
    }
}
