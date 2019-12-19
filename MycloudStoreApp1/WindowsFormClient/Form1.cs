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

namespace WindowsFormClient
{
    public partial class Form1 : Form
    {

       public ServiceReference1.Service1Client proxy;
        UserForm userfrm;
       public User tmpuser;
        int userId;
        public Form1()
        {
            //tmpuser = new User();
            proxy = new ServiceReference1.Service1Client();
          
            InitializeComponent();

        }

       
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (proxy.CheckUser(Convert.ToString(txtIme.Text), Convert.ToString(txtLozinka.Text)))
            {
                tmpuser = new User(txtIme.Text, txtLozinka.Text);
                //tmpuser.Ime = txtIme.Text;
                //tmpuser.Pass = txtLozinka.Text;
                int userId=proxy.GetIdUser(txtIme.Text, txtLozinka.Text);
                userfrm = new UserForm(tmpuser,userId);
                userfrm.ShowDialog();
                
                

            }
            else
            {
                MessageBox.Show("Nema Vas u bazi!");
            }
        }
    }
}
