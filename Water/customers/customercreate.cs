﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Water.customers;

namespace Water.customers
{
    public partial class customercreate : Form
    {
        public customercreate()
        {
            InitializeComponent();
        }

        private void customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'waterDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.waterDataSet.products);

        }

        private void appplot_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void area_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void savebtn1_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into water.customer(name,area,producttype,address,pin,plot,email,phone,nationalid,account) values('" + this.appname.Text + "','" + this.area.Text + "','" + this.prod.Text + "','" + this.addr.Text + "','" + this.apppin.Text + "','" + this.appplot.Text + "','" + this.email.Text + "','" + this.tel.Text + "','" + this.nat.Text + "','" + this.acc.Text + "');";
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
                newcon eadd = new newcon();
                this.Hide();

                eadd.ShowDialog();
                //this.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void savebtn2_Click(object sender, EventArgs e)
        {
             try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into water.customer(name,area,producttype,address,pin,plot,email,phone,nationalid,account) values('" + this.appname.Text + "','" + this.area.Text + "','" + this.prod.Text + "','" + this.addr.Text + "','" + this.apppin.Text + "','" + this.appplot.Text + "','" + this.email.Text + "','" + this.tel.Text + "','" + this.nat.Text + "','" + this.acc.Text + "');";
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
                newcon eadd = new newcon();
                this.Hide();

                eadd.ShowDialog();
               // this.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
    }
}
