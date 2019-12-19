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
        public void insertInFiles(byte[] bajtoviFajla, string metoda, string hashkod, int idKorisnik, string naziv)
        {
            string query="INSERT INTO fajl (bajtoviFajla,metoda,hashkod,id_korisnika,naziv) VALUES ('"+bajtoviFajla+"','"+metoda +"','" + hashkod+ "','"
                + idKorisnik + "','" + naziv+ "');";
            if(dbCon.OpenConnection()==true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbCon.connection);
                cmd.ExecuteNonQuery();
                dbCon.CloseConnection();
            }
        }
    }
}
