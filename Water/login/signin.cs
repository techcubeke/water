using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Water.users;
using Water.Base;
using Water.Dashboard;
namespace Water.login
{
    public partial class signin : Form
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        InputValidator validator = new InputValidator();
        connector database = new connector();

        public signin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            user usr = new user();
            usr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Password = validator.CalculateMD5Hash(pass.Text);
            
            
            if (database.logIn(UserName, Password))
            {
                database.UserName = UserName;
                dashboard ds = new dashboard();
                this.Hide();
                ds.ShowDialog();
                this.Close();

            }
            uname.Text = "";
            pass.Text = "";
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            if (validator.alphaNumericCheck(pass.Text))
            {
                Password = validator.CalculateMD5Hash(pass.Text);

            }
            return;
        }



        private void uname_TextChanged(object sender, EventArgs e)
        {
            if (validator.alphaNumericCheck(uname.Text))
            { UserName = uname.Text; }
            return;
        }

     

    }
}
