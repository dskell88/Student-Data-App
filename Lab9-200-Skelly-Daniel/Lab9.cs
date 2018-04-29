using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_200_Skelly_Daniel
{
    public partial class Lab9 : Form
    {
        public Lab9()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            email = email.Trim();
            int domainIndex = email.IndexOf("@");

            if (domainIndex > 0)                                //shows the username and domain name of the email
            {
                string username = email.Substring(0, domainIndex);
                string domain = email.Substring(domainIndex + 1);
                MessageBox.Show("User Name: " + username.ToString() + "\n\n" + "Domain Name: " + domain.ToString(), "Parsed String");

            }
            if (domainIndex < 0)                               //alerts an error when the "@" sign is not entered
            {
                MessageBox.Show("The email address must contain an @ sign", "Message Error");
            }
   
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text.Trim();              
            string state = txtState.Text.Trim();
            string zip = txtZip.Text.Trim();
            DateTime currentDate = DateTime.Now;                                                      //current date variable
            int cityLength = city.Length;
            string cityStateZip = city + state + zip;
            cityStateZip = cityStateZip.Insert(cityLength, ", ");
            cityStateZip = cityStateZip.Insert(cityLength + 4, " ");
            MessageBox.Show("City, State, Zip: " + cityStateZip.ToString() + "\n\n" + "Date: " +        //messagebox showing location and time
                currentDate.ToString(), "Formatted String");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
