using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//Add MySql Library
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;

namespace Water.Base
{
    class connector
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private static string userName;
        private MySqlDataAdapter mySqlDataAdapter;


        //Constructor
        public connector()
        {
            Initialize();
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "water";
            uid = "root";
            password ="";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "Allow User Variables=True;" + "allow zero datetime=yes";

            connection = new MySqlConnection(connectionString);
        }


        //open connection to database
        private bool OpenConnection()
        {


            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public bool Insert(string query)
        {
            bool success = false;
            string cs = @"server=localhost;userid=root;
            password=;database='water'";
            MySqlConnection conn = null;
            MySqlTransaction tr = null;

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                tr = conn.BeginTransaction();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = tr;

                cmd.CommandText = query;
                cmd.ExecuteNonQuery();


                tr.Commit();
                //MessageBox.Show("Success!");
                success = true;
            }
            catch (MySqlException ex)
            {
                try
                {
                    tr.Rollback();

                }
                catch (MySqlException ex1)
                {
                    MessageBox.Show("Error: {0}", ex1.ToString());
                }

                MessageBox.Show("Error: {0}", ex.ToString());

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return success;
        }
    
        
        //Update statement
        public bool Update(string query)
        {
            bool status = false;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
                status = true;

            }
            return status;
        }

        //Delete statement
        public bool Delete(string query)
        {
            bool status = false;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                status = true;
            }
            return status;
        }
        public bool logIn(string user, string password)
        {
            UserName = user;
            string query = "select userName, password from user where userName=(@Name) and password=(@Password)";
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = query;
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Name", user);
                cmd.Parameters.AddWithValue("@Password", password);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader == null)
                {
                    dataReader.Close();
                    this.CloseConnection();
                    MessageBox.Show("Incorrect username or passowrd");
                    return false;

                }
                else
                {
                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["userName"] + "");
                        list[1].Add(dataReader["password"] + "");



                    }

                }
                dataReader.Close();
                this.CloseConnection();
                for (int i = 0; i < list[0].Count; i++)
                {
                    if (list[0][i].Equals(user) && list[1][i].Equals(password))
                    { return true; }
                }

                MessageBox.Show("Incorrect username or password");

                return false;

                //close Data Reader

                //int answer=cmd.ExecuteNonQuery();
                //this.CloseConnection();
                //if (answer == 0)
                //{
                //    MessageBox.Show("Invalid user or password");
                //    return false;
                //}
                //else if (answer == 1)
                //{ return true; }

            }
            else
            {
                MessageBox.Show("Cannot connect to the database");
            }
            return false;
        }
        public bool Check(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = query;
                cmd.Prepare();
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (!dataReader.Read())
                {
                    dataReader.Close();
                    this.CloseConnection();
                    return false;

                }
                else
                {
                    dataReader.Close();
                    this.CloseConnection();
                    return true;

                }

            }
            else
            {
                MessageBox.Show("Cannot connect to the database");
            }
            return false;
        }
        //Backup
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }
       

        //Restore
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }
       

    }
}
