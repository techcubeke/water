using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water.users
{
    public partial class userdetails : Form
    {
        public userdetails()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.waterDataSet);

        }

        private void userdetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'waterDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.waterDataSet.user);

        }
    }
}
