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
            byte[] pom = new byte[proxy.getUserFile(idUser, txtIme.Text).Length];
            string pomString;
            
            
            proxy.getUserFile(idUser, txtIme.Text).CopyTo(pom, 0);


         
            SaveFileDialog saveDialog = new SaveFileDialog();
            //Stream stream;
            saveDialog.FileName = txtIme.Text;
            if(saveDialog.ShowDialog()==DialogResult.OK)
            {
                pomString = proxy.GetFileText(idUser, txtIme.Text);
                StringBuilder strBuilder = new StringBuilder();
               for(int i =0; i<pom.Length;i++)
                {
                    strBuilder.Append(pom[i].ToString("x2"));

                }

                
                File.WriteAllText(saveDialog.FileName, pomString);
            }
            
            


        }
    }
}
