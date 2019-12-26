using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CryptoLib;

namespace WindowsFormClient
{
    public partial class XTEAForm : Form
    {
        int usId;
        ServiceReference1.Service1Client proxy;
        Fajl fajl;
        public XTEAForm()
        {
            InitializeComponent();
        }
        public XTEAForm(int id)
        {
            InitializeComponent();
            usId = id;
            fajl = new Fajl();
            proxy = new ServiceReference1.Service1Client();
          //  MessageBox.Show(proxy.GetClientPassword(usId));

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = proxy.GetClientPassword(usId);
            CryptoLib.CryptoClass obj = new CryptoLib.CryptoClass();
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr==DialogResult.OK)
            {

                string putanja = openFileDialog1.FileName;
                fajl.Naziv= Path.GetFileName(putanja);
                if (proxy.CheckFile(usId, fajl.Naziv))
                {
                    MessageBox.Show("Ovaj vec postoji u bazi!");
                }
                else
                {
                    byte[] bajtoviFajla = new byte[File.ReadAllBytes(putanja).Length];
                    //bajtoviFajla = File.ReadAllBytes(putanja);
                    bajtoviFajla = File.ReadAllBytes(putanja);
                    string stringBajtova = System.Text.Encoding.UTF8.GetString(bajtoviFajla);
                    string HashBajtovi = obj.MD5Hash(stringBajtova);
                    listHashXTEA.Items.Add(HashBajtovi);
                    string kriptovaniBajtovi = obj.XTEAEncrypt(stringBajtova, pass);
                    fajl.Hashkod = HashBajtovi;
                    fajl.Textfajla = File.ReadAllText(putanja);
                    fajl.Metoda = "XTEA";
                    proxy.insertInFiles(kriptovaniBajtovi, fajl.Metoda, fajl.Hashkod, usId, fajl.Naziv, System.Text.Encoding.UTF8.GetString(bajtoviFajla));

                }

            }
        }
    }
}
