using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace WindowsFormClient
{
    public partial class UserForm : Form
    {
        //Form1 frm1 =new Form1();
       Fajl fajl;
        int userId;
        ServiceReference1.Service1Client proxy;
        public UserForm()
        {
            
            
            InitializeComponent();
        }
        public UserForm(User user,int id)
        {
            InitializeComponent();
            proxy = new ServiceReference1.Service1Client();
            fajl = new Fajl();

            userId = id;
            //MessageBox.Show(Convert.ToString(userId));
            label2.Text = user.Ime;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if(dr==DialogResult.OK)
            {
                //StringBuilder builder = new StringBuilder();
                //SHA1Managed sha1 = new SHA1Managed();
                fajl.Naziv = openFileDialog1.FileName;
                fajl.Nizbajtova = File.ReadAllBytes(fajl.Naziv);
                fajl.Hashkod = "Hash";
                fajl.Metoda = "Metoda";

                proxy.insertInFiles(fajl.Nizbajtova, fajl.Metoda, fajl.Hashkod, userId, fajl.Naziv);

                
                //imeFajlalbl.Text = Convert.ToBase64String(fajl.Nizbajtova);

            }
        }
    }
}
