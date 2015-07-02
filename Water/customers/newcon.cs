using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Water.customers
{
    public partial class newcon : Form
    {
        public newcon()
        {
            InitializeComponent();
        }

        private void newcon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'waterDataSet.customer' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'waterDataSet.fees' table. You can move, or remove it, as needed.
            this.feesTableAdapter.Fill(this.waterDataSet.fees);

            string MyConnection2 = "datasource=localhost;port=3306;username=root";
            //This is my insert query in which i am taking input from the user through windows forms
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.
            MyConn2.Open();

            //get  account no
            string q2 = "select account from water.customer order by datejoined desc LIMIT 1;";
            MySqlCommand com4 = new MySqlCommand(q2, MyConn2);
            MySqlDataReader r2;
            r2 = com4.ExecuteReader();
            while (r2.Read())
            {
                acc.Text = r2["account"].ToString();
            }
            r2.Close();

             string a = fee.Text.ToString();


            //get amount
            string Query = "select * from water.fees where name='" + a + "';";
            MySqlCommand com3 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader r1;
            r1 = com3.ExecuteReader();
            while (r1.Read())
            {
                amnt.Text = r1["amount"].ToString();
            }
            r1.Close();



        }

        private void amnt_TextChanged(object sender, EventArgs e)
        {

        }

        private void fee_SelectedIndexChanged(object sender, EventArgs e)
        {

            string MyConnection2 = "datasource=localhost;port=3306;username=root";
            //This is my insert query in which i am taking input from the user through windows forms
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.
            MyConn2.Open();


            string a = fee.Text.ToString();


            //get amount
            string Query = "select * from water.fees where name='" + a + "';";
            MySqlCommand com3 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader r1;
            r1 = com3.ExecuteReader();
            while (r1.Read())
            {
                amnt.Text = r1["amount"].ToString();
            }
            r1.Close();



        }

        private void acc_TextChanged(object sender, EventArgs e)
        {


            

            string MyConnection2 = "datasource=localhost;port=3306;username=root";
            //This is my insert query in which i am taking input from the user through windows forms
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.
           MyConn2.Open();

           // //get  account no
           //string q2 = "select account from water.customer order by datejoined desc LIMIT 1;";
           //MySqlCommand com4 = new MySqlCommand(q2, MyConn2);
           //MySqlDataReader r2;
           //r2 = com4.ExecuteReader();
           //while (r2.Read())
           //{
           //    acc.Text = r2["account"].ToString();
           //}
           //r2.Close();

           string a = acc.Text.ToString();
            //get name
           string Query1 = "select name from water.customer where account='" + a + "';";
            MySqlCommand com3 = new MySqlCommand(Query1, MyConn2);
            MySqlDataReader r1;
            r1 = com3.ExecuteReader();
            while (r1.Read())
            {
                name.Text = r1["name"].ToString();
            }
            r1.Close();
        }

        private void apaid_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(apaid.Text)) && (!string.IsNullOrEmpty(amnt.Text)) )
            {

                int a = (Convert.ToInt32(amnt.Text) - Convert.ToInt32(apaid.Text));
                if (a > 0)
                {
                    bal.Text = a.ToString();
                }
                else
                    bal.Text = "0";
            }
        }
    }
}
