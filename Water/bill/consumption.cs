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
namespace Water.bill
{
    public partial class consumption : Form
    {
        public consumption()
        {
            InitializeComponent();
        }

        private void consumption_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'waterDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.waterDataSet.customer);
            // TODO: This line of code loads data into the 'waterDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.waterDataSet.user);

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
           

        }


        private void acc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void acc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = acc1.Text.ToString();
            
            string MyConnection2 = "datasource=localhost;port=3306;username=root";
            //This is my insert query in which i am taking input from the user through windows forms
            string Query = "select * from water.bill where status='unpaid' && accountno='" + a + "';";
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            MyReader2.Read();
            MyReader2.Close();

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


            //get prev reading most farthest unpaid
            string q2 = "select previousreading from water.bill where status='unpaid' AND accountno='" + a + "'" + " order by datemodified asc;";
            MySqlCommand com4 = new MySqlCommand(q2, MyConn2);
            MySqlDataReader r2;
            r2 = com4.ExecuteReader();
            while (r2.Read())
            {
                prev.Text = r2["previousreading"].ToString();
            }
            r2.Close();

            //get  latest reading
            string q4 = "select currentreading from water.bill where status='unpaid' AND accountno='" + a + "'" + "  order by datemodified desc;";
            MySqlCommand com5 = new MySqlCommand(q4, MyConn2);
            MySqlDataReader r3;
            r3 = com5.ExecuteReader();
            while (r3.Read())
            {
                curr.Text = r3["currentreading"].ToString();
            }
            r3.Close();
            //get consumption

            if ((!string.IsNullOrEmpty(prev.Text)) && (!string.IsNullOrEmpty(curr.Text)))
            {

                int b = (Convert.ToInt32(curr.Text) - Convert.ToInt32(prev.Text));

                cons.Text = b.ToString();
            }

            //get unpaid total


            if ((!string.IsNullOrEmpty(prev.Text)) && (!string.IsNullOrEmpty(curr.Text)))
            {

                int c = (Convert.ToInt32(curr.Text) - Convert.ToInt32(prev.Text));


                tot.Text = ((Convert.ToInt32(rate.Text) * c).ToString());


            }

            //get balance

            string q6 = "select SUM(balance) AS totbal from water.bill where status='unpaid' AND accountno='" + a + "';";
            MySqlCommand com6 = new MySqlCommand(q6, MyConn2);
            MySqlDataReader r5;
            r5 = com6.ExecuteReader();
            while (r5.Read())
            {
            

                bal.Text = r5["totbal"].ToString();
            }
            r5.Close();
        }

        private void paid_TextChanged(object sender, EventArgs e)
        {
     
            int j = Convert.ToInt32(bal.Text);
            int c=Convert.ToInt32(paid.Text);
            int d=Convert.ToInt32(tot.Text);
          int f = (d-c);
            if (f>=0)
            {
                
                bal.Text = (f).ToString();
                status.Text = "Partial";
            }
            else
                if (f < 0)
                {

                    bal.Text ="0";
                    status.Text = "Paid";
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into water.bill(accountno,name,previousreading,currentreading,rate,total,balance,billdate,recordedby,consumption) values('" + this.acc1.Text + "','" + this.name.Text + "','" + this.prev.Text + "','" + this.curr.Text + "','" + this.rate.Text + "','" + this.tot.Text + "','" + this.bal.Text + "','" + this.pdate.Text + "','" + this.rec.Text + "','" +this.cons.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
                billdetails eadd = new billdetails();
                this.Hide();

                eadd.ShowDialog();
                //this.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
