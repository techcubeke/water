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
// TODO: This line of code loads data into the 'waterDataSet.user' table. You can move, or remove it, as needed.
this.userTableAdapter.Fill(this.waterDataSet.user);
            // TODO: This line of code loads data into the 'waterDataSet.sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.waterDataSet.sale);
            // TODO: This line of code loads data into the 'waterDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.waterDataSet.products);
            // TODO: This line of code loads data into the 'waterDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.waterDataSet.products);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(rate.Text)) && (!string.IsNullOrEmpty(quan.Text)) )
            {

                int a = (Convert.ToInt32(quan.Text) * Convert.ToInt32(rate.Text));

                tot.Text = a.ToString();
            } 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                string a=prod.Text;
             string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "select amount from water.products where product='"+a+"';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();  
            
              while (MyReader2.Read())
                    {
                        rate.Text= MyReader2["amount"].ToString();
                  
                    }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into water.sale(product,rate,quantity,totalsale,recordedby) values('" + this.prod.Text  + "','" +this.rate.Text  + "','"+ this.quan.Text  + "','"+ this.tot.Text  + "','"  +  this.rec.Text  + "');";
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
                this.Hide();
                sale eadd = new sale();
            

                eadd.ShowDialog();
                //this.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into water.sale(product,rate,quantity,totalsale,recordedby) values('" + this.prod.Text  + "','" +this.rate.Text  + "','"+ this.quan.Text  + "','"+ this.tot.Text  + "','"  +  this.rec.Text  + "');";
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
                this.Hide();
                saledetails eadd = new saledetails();
            

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

