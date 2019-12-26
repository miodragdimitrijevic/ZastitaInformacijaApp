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
        bool flag;
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
             flag = false;
            proxy = new ServiceReference1.Service1Client();
            

        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            if(flag==false)
            {
                MessageBox.Show("Niste generisali kljuceve!");

            }
            else
            {
            

            CryptoLib.CryptoClass obj = new CryptoLib.CryptoClass();
            
            
            DialogResult dr = openFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string putanja= openFileDialog1.FileName;
                    fajl.Naziv = Path.GetFileName(putanja);
                    
                    // fajl.Naziv = fajl.Naziv.Replace(@"\", string.Empty);
                    // MessageBox.Show(fajl.Naziv);
                    if (proxy.CheckFile(userID, fajl.Naziv))
                    {
                        MessageBox.Show("Ovaj vec postoji u bazi!");
                    }
                    else
                    {


                        byte[] pomBajtovi = new byte[File.ReadAllBytes(putanja).Length];
                        List<int> lista = new List<int>();
                        List<byte> pomlistabajtova = new List<byte>();
                        pomBajtovi = File.ReadAllBytes(putanja);


                       /*StringBuilder strbil1 = new StringBuilder();
                        StringBuilder strbil2 = new StringBuilder();
                        for (int k = 0; k < pomBajtovi.Length; k++)
                        {
                            strbil1.Append(pomBajtovi[k].ToString("x2"));

                        }
                        MessageBox.Show(strbil1.ToString());*/

                        



                        byte[] bajtovizaSlanje = obj.KnapsackCrypt(pomBajtovi, txtPrivateim.Text, txtPrivateN.Text, txtPublicJ.Text, txtPrivateP.Text, fajl.Naziv);
                       /*for (int p = 0; p < bajtovizaSlanje.Length; p++)
                        {
                            strbil2.Append(bajtovizaSlanje[p].ToString("x2"));
                        }
                        MessageBox.Show(strbil2.ToString());*/
                        string pom = obj.MD5Hash(pomBajtovi);

                        fajl.Hashkod = pom;
                        hashKnap.Items.Add(pom);
                        fajl.Textfajla = File.ReadAllText(putanja);
                        fajl.Metoda = "Knapsack";
                        string stringZaslanje = BitConverter.ToString(bajtovizaSlanje);



                        proxy.insertInFiles(stringZaslanje, fajl.Metoda, fajl.Hashkod, userID, fajl.Naziv, System.Text.Encoding.UTF8.GetString(pomBajtovi));
                    }
                }
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
            flag = true;
            GenerateKeys();
        }
    }
}
