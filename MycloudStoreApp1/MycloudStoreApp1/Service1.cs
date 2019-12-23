using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;

namespace MycloudStoreApp1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {

        DBConnection dbCon;

        Service1()
        {
            dbCon = new DBConnection();

        }

        public bool CheckUser(string ime, string lozinka)
        {
            string query = "SELECT * FROM korisnik WHERE (ime='" + ime + "' AND lozinka='" + lozinka + "');";
            if (dbCon.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbCon.connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    reader.Close();
                    dbCon.CloseConnection();
                    return true;
                }
                else
                {
                    reader.Close();
                    dbCon.CloseConnection();
                    return false;
                }

            }
            else
            {
                //reader.Close();
                dbCon.CloseConnection();
                return false;
            }
        }

       public int GetIdUser(string name,string pass)
        {
            int id;
           string query= "SELECT id FROM korisnik WHERE (ime='" + name + "' AND lozinka='" + pass + "');";
            if(dbCon.OpenConnection()==true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbCon.connection);
                id = int.Parse(cmd.ExecuteScalar() + "");
                dbCon.CloseConnection();
                return id;
            }
            else
            {
                return 0;
            }
        }
        public string GetFileText(int id ,string imeFajla)
        {
            string text;
            string query= "SELECT textfajla FROM fajl WHERE (id_korisnika='" + id + "'AND naziv='" + imeFajla + "');";
            if(dbCon.OpenConnection()==true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbCon.connection);
                text = cmd.ExecuteScalar().ToString();
                dbCon.CloseConnection();
                return text;

            }
            else
            {
                return "";
            }
        }
        public string GetMethod(int id,string imeFajla)
        {

            string text;
            string query = "SELECT metoda FROM fajl WHERE (id_korisnika='" + id + "'AND naziv='" + imeFajla + "');";
            if (dbCon.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbCon.connection);
                text = cmd.ExecuteScalar().ToString();
                dbCon.CloseConnection();
                return text;

            }
            else
            {
                return "";
            }

        }

        public void insertInFiles(string bajtoviFajla, string metoda, string hashkod, int idKorisnik, string naziv,string textfajla)
        {
            string query="INSERT INTO fajl (bajtoviFajla,metoda,hashkod,id_korisnika,naziv,textfajla) VALUES ('"+bajtoviFajla+"','"+metoda +"','" + hashkod+ "','"
                + idKorisnik + "','" + naziv+ "','"+ textfajla+ "');";
            if(dbCon.OpenConnection()==true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbCon.connection);
                cmd.ExecuteNonQuery();
                dbCon.CloseConnection();
            }
        }

        public string getUserFile(int userId,string name)
        {
            //byte[] entitet = new byte[1000];
            //List<byte> entitet = new List<byte>();
           // byte[] prazno = new byte[0];
            string query = "SELECT bajtoviFajla FROM fajl WHERE (id_korisnika='" + userId + "'AND naziv='" + name + "');";
            if(dbCon.OpenConnection()==true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbCon.connection);
                
                string bajtovi = cmd.ExecuteScalar().ToString();

                dbCon.CloseConnection();

                return bajtovi;
                

               

            }
            else
            {
                return null;
            }
            
        }
        public List<string> getUserFiles(int userId)
        {
            List<string> fajlovi = new List<string>();

            string query = "SELECT* FROM fajl WHERE id_korisnika='" + userId + "';";

            if(dbCon.OpenConnection()==true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbCon.connection);
                
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while(dataReader.Read())
                {
                    fajlovi.Add(Convert.ToString(dataReader["naziv" + ""]));
                   
                }
                dataReader.Close();
                dbCon.CloseConnection();
                return fajlovi;
            }
            else
            {
                return fajlovi;
            }

        }
    }
}
