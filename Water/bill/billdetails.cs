using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water.bill
{
    public partial class billdetails : Form
    {
        public billdetails()
        {
            InitializeComponent();
        }

        private void billBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.billBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.waterDataSet);

        }

        private void billdetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'waterDataSet.bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.waterDataSet.bill);

        }
    }
}
