using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Water.Base;

using MySql.Data.MySqlClient;

namespace Water.pos
{
    public partial class sale : Form
    {
        public sale()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void sale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'waterDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.waterDataSet.products);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox1 = (ComboBox)sender;

           // ComboboxItem comboBox1 = (ComboboxItem)cmb.SelectedItem;
            String a = (String)comboBox1.ValueMember;
            string MyConnection2 = "datasource=localhost;port=3306;username=root";
            //This is my insert query in which i am taking input from the user through windows forms
            string Query = "select * from water.products where product="+a;
            MySqlConnection con = new MySqlConnection(MyConnection2);

            MySqlCommand com = new MySqlCommand(Query, con);

            try
            {
                con.Open();

                using (MySqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {
                        textBox2.Text = (read["amount"].ToString());

                    }
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
