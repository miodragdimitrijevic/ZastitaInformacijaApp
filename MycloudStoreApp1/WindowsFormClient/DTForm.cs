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
    public partial class DTForm : Form
    {
        Fajl fajl;
        int userId;
        ServiceReference1.Service1Client proxy;
        public DTForm()
        {
            InitializeComponent();
        }
        public DTForm(int userID)
        {
            InitializeComponent();
            userId = userID;
            fajl = new Fajl();
            proxy = new ServiceReference1.Service1Client();

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            CryptoLib.CryptoClass obj = new CryptoLib.CryptoClass();
            DialogResult dr = openFileDialog1.ShowDialog();
            if(dr==DialogResult.OK)
            {
                fajl.Naziv = openFileDialog1.FileName;
                byte[] bajtoviFajla = new byte[File.ReadAllBytes(fajl.Naziv).Length];
                bajtoviFajla = File.ReadAllBytes(fajl.Naziv);
                string permutacijaX = perX.Text;
                string permutacijaY = perY.Text;
                int dimenzijaX = Convert.ToInt32(dimX.Text);
                int dimenzijaY = Convert.ToInt32(dimY.Text);
                string bajtoviString = System.Text.Encoding.UTF8.GetString(bajtoviFajla);
                int faktor;
                if (dimenzijaX > dimenzijaY)
                    faktor = dimenzijaX;
                else
                    faktor = dimenzijaY;
                if(bajtoviString.Length<dimenzijaX-dimenzijaY)
                {
                    MessageBox.Show("Potrebno je uneti veci fajl");
                }
                else
                {
                    char[,] transponozicionaMatrica = new char[dimenzijaX, dimenzijaY];
                    for(int i =0;i<dimenzijaX;i++)
                    {
                        for(int j=0;j<dimenzijaY;j++)
                        {
                            transponozicionaMatrica[i, j] = bajtoviString[dimenzijaY* i + j];
                        }
                    }
                    string stringToHash = "";
                    for (int i = 0; i < dimenzijaX; i++)
                    {
                        for (int j = 0; j < dimenzijaY; j++)
                        {
                            stringToHash += transponozicionaMatrica[i, j];
                        }
                   }
                    string hesovanString = obj.MD5Hash(stringToHash);
                    string zaslanjeString = obj.DTCrypt(transponozicionaMatrica, permutacijaX, permutacijaY, dimenzijaX, dimenzijaY,fajl.Naziv);
                    hashList.Items.Add(hesovanString);
                    fajl.Hashkod = hesovanString;
                    fajl.Textfajla = File.ReadAllText(fajl.Naziv);
                    fajl.Metoda = "DT";
                    proxy.insertInFiles(zaslanjeString, fajl.Metoda, fajl.Hashkod, userId, fajl.Naziv, fajl.Textfajla);
                }
            }
        }
    }
}
