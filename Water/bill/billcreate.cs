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
    public partial class billcreate : Form
    {
        public billcreate()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void billcreate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'waterDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.waterDataSet.user);

        }
    }
}
