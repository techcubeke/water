using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Water.Base
{
    class inputvalidator
    {
        public bool alphaCheck(String text)
        {
            if (string.IsNullOrEmpty(text) || text.Length > 35)
            {
                MessageBox.Show("Invalid length");
                return false;
            }
            else if (String.IsNullOrWhiteSpace(text))
                MessageBox.Show("Please enter a value");
            else if (text.Any(c => char.IsDigit(c)))
                MessageBox.Show("Text cannot contain numbers");
            else return true;
            return false;
        }
        public bool numericCheck(String text)
        {
            if (String.IsNullOrWhiteSpace(text))
                MessageBox.Show("Please enter a value");
            else if (!text.Any(c => char.IsDigit(c)))
                MessageBox.Show("Only numbers are allowed");
            else return true;
            return false;
        }
        public string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }
        public bool alphaNumericCheck(String text)
        {
            Regex r = new Regex("^[a-z A-Z0-9]*$");
            if (r.IsMatch(text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Input can only contain alphanumeric characters");
                return false;
            }

        }
    }
}
