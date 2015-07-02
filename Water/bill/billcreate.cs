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
            // TODO: This line of code loads data into the 'waterDataSet.bill' table. You can move, or remove it, as needed.
          //  this.billTableAdapter.Fill(this.waterDataSet.bill);
            // TODO: This line of code loads data into the 'waterDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.waterDataSet.user);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                int a = (Convert.ToInt32(curr.Text) - Convert.ToInt32(prev.Text));

                String cons = a.ToString();

            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into water.bill(accountno,name,previousreading,currentreading,rate,total,balance,billdate,recordedby,consumption) values('" + this.acc.Text + "','" + this.name.Text + "','" + this.prev.Text + "','" + this.curr.Text + "','" + this.rate.Text + "','" + this.tot.Text + "','" + this.bal.Text + "','" + this.bdate.Text + "','" + this.rec.Text + "','" + a + "');";
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
                billcreate eadd = new billcreate();
                this.Hide();

                eadd.ShowDialog();
                //this.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tot_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void prev_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(prev.Text)) && (!string.IsNullOrEmpty(curr.Text)) && (!string.IsNullOrEmpty(rate.Text)))
            {

                int a=(Convert.ToInt32(curr.Text) - Convert.ToInt32(prev.Text));
                
                tot.Text = (Convert.ToInt32(rate.Text) * a).ToString();
            } 
        }

        private void curr_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(prev.Text)) && (!string.IsNullOrEmpty(curr.Text)) && (!string.IsNullOrEmpty(rate.Text)))
            {

                int a = (Convert.ToInt32(curr.Text) - Convert.ToInt32(prev.Text));

                tot.Text = (Convert.ToInt32(rate.Text) * a).ToString();
            } 
        }

        private void rate_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(prev.Text)) && (!string.IsNullOrEmpty(curr.Text)) && (!string.IsNullOrEmpty(rate.Text)))
            {

                int a = (Convert.ToInt32(curr.Text) - Convert.ToInt32(prev.Text));

                tot.Text = (Convert.ToInt32(rate.Text) * a).ToString();
            } 
        }

        private void bal_TextChanged(object sender, EventArgs e)
        {
            bal.Text = tot.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = (Convert.ToInt32(curr.Text) - Convert.ToInt32(prev.Text));

            String cons = a.ToString();

            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into water.bill(accountno,name,previousreading,currentreading,rate,total,balance,billdate,recordedby,consumption) values('" + this.acc.Text + "','" + this.name.Text + "','" + this.prev.Text + "','" + this.curr.Text + "','" + this.rate.Text + "','" + this.tot.Text + "','" + this.bal.Text + "','" + this.bdate.Text + "','" + this.rec.Text + "','" + a + "');";
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
