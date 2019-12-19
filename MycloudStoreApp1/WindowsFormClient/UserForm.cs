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
        DTForm dtform;
        KnapsackForm ksForm;
        MD5Form md5Form;
        XTEAForm xteaForm;
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
            List<string> pomNiz = new List<string>();
            pomNiz = proxy.getUserFiles(userId).ToList();
            
            foreach(string el in pomNiz)
            {
                fajloviList.Items.Add(el);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*DialogResult dr = openFileDialog1.ShowDialog();
            if(dr==DialogResult.OK)
            {
                //StringBuilder builder = new StringBuilder();
                //SHA1Managed sha1 = new SHA1Managed();
                string pom = openFileDialog1.FileName;
                fajl.Naziv = System.IO.Path.GetFileName(pom);
                fajl.Nizbajtova = File.ReadAllBytes(fajl.Naziv);
                fajl.Hashkod = "Hash";
                fajl.Metoda = "Metoda";

                proxy.insertInFiles(fajl.Nizbajtova, fajl.Metoda, fajl.Hashkod, userId, fajl.Naziv);

                
                //imeFajlalbl.Text = Convert.ToBase64String(fajl.Nizbajtova);

            }*/
            if (rbtnDoubleT.Checked == true)
            {
                dtform = new DTForm();
                dtform.ShowDialog();
            }
            if(rbtnKnapsack.Checked==true)
            {
                ksForm = new KnapsackForm();
                ksForm.ShowDialog();
            }
            if(rbtnMD5.Checked==true)
            {
                md5Form = new MD5Form();
                md5Form.ShowDialog();
            }
            if(rbtnXTEA.Checked==true)
            {
                xteaForm = new XTEAForm();
                xteaForm.ShowDialog();
            }
        }


      
    }
}
