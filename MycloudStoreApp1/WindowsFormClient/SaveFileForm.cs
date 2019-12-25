using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using CryptoLib;

namespace WindowsFormClient
{
    public partial class SaveFileForm : Form
    {
        int idUser;
        ServiceReference1.Service1Client proxy;
        public SaveFileForm()
        {
            InitializeComponent();
        }
        public SaveFileForm(int idKorisnika)
        {
            idUser = idKorisnika;
            proxy = new ServiceReference1.Service1Client();
            InitializeComponent();
           


        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            // byte[] pom = new byte[proxy.getUserFile(idUser, txtIme.Text).Length];
            // pomString= proxy.getUserFile(idUser, txtIme.Text);
            /* MessageBox.Show(pomString);
             StringBuilder strbil2 = new StringBuilder();
             byte[] pombajtovi = System.Text.Encoding.UTF8.GetBytes(pomString);
             for (int p = 0; p < pombajtovi.Length; p++)
             {
                 strbil2.Append(pombajtovi[p].ToString("x2"));
             }
             MessageBox.Show(strbil2.ToString());*/

            CryptoLib.CryptoClass obj = new CryptoLib.CryptoClass();
            string pomString = proxy.GetMethod(idUser, txtIme.Text);
            string hashDekriptovanih;

            if (pomString == "Knapsack")
            {

                //MessageBox.Show(pomString);
                string path = txtIme.Text.Replace(@"\", string.Empty);
                char[] chartoTrim = { 'C', ':', '.' };
                string trimedpath = path.Trim(chartoTrim);
                string fileName = @"D:\Fakukltet\Zastita inforamcija\EnkripcijaProjekat\" + "Knapsack" + trimedpath;

                StreamReader sr = new StreamReader(fileName);
                string podaciStr = sr.ReadLine();

                byte[] dekriptovaniBajtovi = obj.DecryptKnapsack(podaciStr);
               
                hashDekriptovanih = obj.MD5Hash(dekriptovaniBajtovi);
                listHashKod.Items.Add(hashDekriptovanih);


              

                SaveFileDialog saveDialog = new SaveFileDialog();
                //Stream stream;
                // saveDialog.Filter = "*.txt";
                saveDialog.FileName = txtIme.Text;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string pom = proxy.GetFileText(idUser, txtIme.Text);

                    string tekstFajla = System.Text.Encoding.UTF8.GetString(dekriptovaniBajtovi);

                    File.WriteAllText(saveDialog.FileName, tekstFajla);
                }
            }
            if(pomString=="DT")
            {
                string path = txtIme.Text.Replace(@"\", string.Empty);
                char[] chartoTrim = { 'C', ':', '.' };
                string trimedpath = path.Trim(chartoTrim);
                string fileName = @"D:\Fakukltet\Zastita inforamcija\EnkripcijaProjekat\" + "DT" + trimedpath;

                string kriptovaniBajtovi = proxy.getUserFile(idUser, txtIme.Text);
                StreamReader sr = new StreamReader(fileName);
                string podaciStr = sr.ReadLine();
                string heshString = obj.DTDecrypt(kriptovaniBajtovi, podaciStr);
                hashDekriptovanih = obj.MD5Hash(heshString);
                listHashKod.Items.Add(hashDekriptovanih);


            }





        }
    }
}
