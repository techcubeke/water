using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water.pos
{
    public partial class saledetails : Form
    {
        public saledetails()
        {
            InitializeComponent();
        }

        private void saleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.saleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.waterDataSet);

        }

        private void saledetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'waterDataSet.sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.waterDataSet.sale);

        }
    }
}
