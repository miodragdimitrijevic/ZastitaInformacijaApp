﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MycloudStoreApp1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract ]
        bool CheckUser(string ime, string pass);
        // TODO: Add your service operations here
        [OperationContract]
        int GetIdUser(string ime, string pass);
        [OperationContract]
        void insertInFiles(string bajtoviFajla, string metoda, string hashkod, int idKorisnik, string naziv,string textfajla);
        [OperationContract]
        List<string> getUserFiles(int userId);
        [OperationContract]
        string getUserFile(int userId, string name);
        [OperationContract]
        string GetFileText(int id, string imeFajla);
        [OperationContract]
        string GetMethod(int id, string imeFajla);
        [OperationContract]
        bool CheckFile(int id, string naziv);
        [OperationContract]
        string GetClientPassword(int id);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "MycloudStoreApp1.ContractType".
    

}
