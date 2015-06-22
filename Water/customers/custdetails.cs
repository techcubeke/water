using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water.customers
{
    public partial class custdetails : Form
    {
        public custdetails()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.waterDataSet);

        }

        private void custdetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'waterDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.waterDataSet.customer);

        }
    }
}
