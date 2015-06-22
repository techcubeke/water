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
    public partial class applications : Form
    {
        public applications()
        {
            InitializeComponent();
        }

        private void applicationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.applicationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.waterDataSet);

        }

        private void applications_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'waterDataSet.applications' table. You can move, or remove it, as needed.
            this.applicationsTableAdapter.Fill(this.waterDataSet.applications);

        }
    }
}
