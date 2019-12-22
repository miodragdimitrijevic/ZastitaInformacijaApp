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
using System.Security.Cryptography;
using CryptoLib;
namespace WindowsFormClient
{
    public partial class KnapsackForm : Form
    {
        Fajl fajl;
        ServiceReference1.Service1Client proxy;
        int userID;
        public KnapsackForm()
        {
            InitializeComponent();
        }
        public KnapsackForm(int userId)
        {
            InitializeComponent();
            userID = userId;
            fajl = new Fajl();
            proxy = new ServiceReference1.Service1Client();

        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            CryptoLib.CryptoClass obj = new CryptoLib.CryptoClass();
            
            
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //StringBuilder builder = new StringBuilder();
                //SHA1Managed sha1 = new SHA1Managed();
                
                fajl.Naziv = openFileDialog1.FileName;
                byte[] pomBajtovi = new byte[File.ReadAllBytes(fajl.Naziv).Length];
                List<int> lista = new List<int>();
                pomBajtovi = File.ReadAllBytes(fajl.Naziv);

                string result = "";
                string[] publicJkey = txtPublicJ.Text.Split(',');
                int rezultat = 0;
                foreach(byte b in pomBajtovi)
                {
                    int integerVrednostbajta = Convert.ToInt32(b);
                    string binarystring = Convert.ToString(integerVrednostbajta, 2);
                    string nule = "";
                    if(binarystring.Length<8)
                    {
                        for(int i=0;i<8-binarystring.Length;i++)
                        {
                            nule += "0";

                        }
                    }
                    string newBinarystring = nule + binarystring;

                    for(int i=0;i<publicJkey.Length;i++)
                    {
                        if(newBinarystring[i]=='1')
                        {
                            rezultat += Convert.ToInt32(publicJkey[i]);
                            
                        }

                    }
                    lista.Add(rezultat);
                    rezultat = 0;
                    
                }
                foreach (int el in lista)
                {
                    result += el + " ";
                }
                MessageBox.Show(result);
                string pom = obj.MD5Hash(pomBajtovi);
                fajl.Hashkod = pom;
                hashKnap.Text = pom;
                fajl.Textfajla = File.ReadAllText(fajl.Naziv);
                fajl.Metoda = "Knapsack";

                proxy.insertInFiles(pomBajtovi, fajl.Metoda, fajl.Hashkod, userID, fajl.Naziv,fajl.Textfajla);


            }
        }
        public void GenerateKeys()
        {

            string[] privatePkey = txtPrivateP.Text.Split(',');

            string publicJkey = "";
            int m = Convert.ToInt32(txtPrivatem.Text);
            int n = Convert.ToInt32(txtPrivateN.Text);
            

            int rezultat;
            foreach(string str in privatePkey)
            {
                rezultat = (Convert.ToInt32(str) * m) % n;
                publicJkey += Convert.ToString(rezultat) + ",";
            }
            publicJkey = publicJkey.TrimEnd(',');
            txtPublicJ.Text = publicJkey;

            int im = (n + 1) / m;

            txtPrivateim.Text = Convert.ToString(im);
            
            

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateKeys();
        }
    }
}
