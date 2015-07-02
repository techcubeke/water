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

namespace Water.fee
{
    public partial class fees : Form
    {
        public fees()
        {
            InitializeComponent();
        }

        private void feesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.feesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.waterDataSet);

        }

        private void fees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'waterDataSet.fees' table. You can move, or remove it, as needed.
            this.feesTableAdapter.Fill(this.waterDataSet.fees);
            // TODO: This line of code loads data into the 'waterDataSet.fees' table. You can move, or remove it, as needed.
            this.feesTableAdapter.Fill(this.waterDataSet.fees);

        }

       

        private void feesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.feesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.waterDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into water.fees(name,amount) values('" + this.fname.Text  + "','" + this.amnt.Text  + "');";
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
                fees eadd = new fees();
            

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
