using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Collections;

namespace CryptoLib
{
    public class CryptoClass
    {
        
        public string MD5Hash(byte[] bajtovi)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(bajtovi);
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
        public byte[] KnapsackCrypt(byte[] pomBajtovi, string txtim, string txtn, string txtJ, string txtP, string imeFajla)
        {
            List<byte> listabajtova = new List<byte>();
            List<int> listaIntidzera = new List<int>();
            string[] publickeys = txtJ.Split(',');
            int rezultat = 0;
            foreach (byte b in pomBajtovi)
            {
                int integerVrednostbajta = Convert.ToInt32(b);
                string binarystring = Convert.ToString(integerVrednostbajta, 2);
                string nule = "";
                if (binarystring.Length < 8)
                {
                    for (int i = 0; i < 8 - binarystring.Length; i++)
                    {
                        nule += "0";
                    }
                }
                string newBinarystring = nule + binarystring;
                for (int i = 0; i < publickeys.Length; i++)
                {
                    if (newBinarystring[i] == '1')
                    {
                        rezultat += Convert.ToInt32(publickeys[i]);
                    }
                }
                byte[] bajtoviRezultata = BitConverter.GetBytes(rezultat);
                Array.Reverse(bajtoviRezultata);
                byte ba = bajtoviRezultata[3];

                listabajtova.Add(ba);

                listaIntidzera.Add(rezultat);
                rezultat = 0;


            }
            byte[] enkriptovaniBajtovi = new byte[listabajtova.Count];
            int j = 0;
            foreach (byte b in listabajtova)
            {
                enkriptovaniBajtovi[j] = b;
                j++;
            }
            //char [] charToTrim = {'C',''}
            //string trimovanoimefajla=
            imeFajla = imeFajla.Replace(@"\", string.Empty);
            char[] charToTrim = { ':', '.' };
            string trimovanoimefajla = imeFajla.Trim(charToTrim);
            string fileName = @"D:\Fakukltet\Zastita inforamcija\EnkripcijaProjekat\" + "Knapsack" + trimovanoimefajla;

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            string tekstFajla = "";
            tekstFajla += txtim + "," + txtn + ",";
            tekstFajla += txtP + ",";
            foreach (int broj in listaIntidzera)
            {
                tekstFajla += broj + ",";
            }
            tekstFajla = tekstFajla.TrimEnd(',');

            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine(tekstFajla);
            }






            return enkriptovaniBajtovi;
        }

        public byte[] DecryptKnapsack(string data)
        {
            string[] nizPodataka = data.Split(',');

            int[] nizP = new int[8];
            List<byte> listaDekriptovanihBajtova = new List<byte>();
            int im = Convert.ToInt32(nizPodataka[0]);
            int N = Convert.ToInt32(nizPodataka[1]);
            List<int> kriptoCLista = new List<int>();
            List<int> TCList = new List<int>();
            int j;
            for (int i = 2; i < 10; i++)
            {
                j = i - 2;
                nizP[j] = Convert.ToInt32(nizPodataka[i]);
            }
            for (int i = 10; i < nizPodataka.Length; i++)
            {
                kriptoCLista.Add(Convert.ToInt32(nizPodataka[i]));

            }
            foreach (int c in kriptoCLista)
            {
                int tc = (c * im) % N;
                TCList.Add(tc);
            }

            foreach (int tc in TCList)
            {
                int deljenik = tc;
                string stringBitova = "";
                for (int i = nizP.Length - 1; i >= 0; i--)
                {
                    int tmpInt = deljenik / nizP[i];
                    stringBitova = Convert.ToString(tmpInt) + stringBitova;
                    deljenik = deljenik % nizP[i];
                }
                int decimalnavrednost = Convert.ToInt32(stringBitova, 2);
                byte[] bajtoviDecimalneVrednosti = BitConverter.GetBytes(decimalnavrednost);
                Array.Reverse(bajtoviDecimalneVrednosti);
                byte ba = bajtoviDecimalneVrednosti[3];

                listaDekriptovanihBajtova.Add(ba);



            }
            byte[] nizDekriptovanihbajtova = new byte[listaDekriptovanihBajtova.Count];
            int k = 0;
            foreach (byte b in listaDekriptovanihBajtova)
            {
                nizDekriptovanihbajtova[k] = b;
                k++;
            }

            return nizDekriptovanihbajtova;


        }
        public string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();


            md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(text));


            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
        public string DTCrypt(char[,] transpozicionaMatrica, string permX, string permY, int x, int y, string fileName)
        {
            string[] permutacijeX = permX.Split(',');
            string[] permutacijeY = permY.Split(',');

            char[,] transpozicionaPoX = new char[x, y];
            for (int i = 0; i < permutacijeX.Length; i++)
            {
                int vrednostPermX = Convert.ToInt32(permutacijeX[i]);
                for (int j = 0; j < y; j++)
                {
                    transpozicionaPoX[i, j] = transpozicionaMatrica[vrednostPermX, j];
                }
            }
            char[,] transpozicionaPoY = new char[x, y];
            for (int i = 0; i < permutacijeY.Length; i++)
            {
                int vrednostPermY = Convert.ToInt32(permutacijeY[i]);
                for (int j = 0; j < x; j++)
                {
                    transpozicionaPoY[j, i] = transpozicionaPoX[j, vrednostPermY];
                }
            }
            string krajnjiString = "";
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    krajnjiString += transpozicionaPoY[i, j];
                }
            }


            string imeFajla = fileName;
            imeFajla = imeFajla.Replace(@"\", string.Empty);
            char[] charToTrim = { 'C', ':', '.' };
            string trimovanoimefajla = imeFajla.Trim(charToTrim);
            string ime = @"D:\Fakukltet\Zastita inforamcija\EnkripcijaProjekat\" + "DT" + trimovanoimefajla;

            if (File.Exists(ime))
                File.Delete(ime);
            string tekstFajla = "";
            tekstFajla += Convert.ToString(x) + "," + Convert.ToString(y) + "," + permX + "," + permY;

            using (StreamWriter sw = File.CreateText(ime))
            {
                sw.WriteLine(tekstFajla);
            }



            return krajnjiString;

        }
        public string DTDecrypt(string kriptovaniStr, string podaci)
        {
            string[] splitPodaci = podaci.Split(',');
            int x = Convert.ToInt32(splitPodaci[0]);
            int y = Convert.ToInt32(splitPodaci[1]);
            string permutacijeX = "";
            string permutacijeY = "";
            int faktor;
            for (int i = 2; i < x + 2; i++)
            {
                permutacijeX += splitPodaci[i];
            }
            for (int i = x + 2; i < x + 2 + y; i++)
            {
                permutacijeY += splitPodaci[i];
            }
            if (x > y)
                faktor = x;
            else
                faktor = y;
            int k = 0;
            char[,] transpozicionaMatrica = new char[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    transpozicionaMatrica[i, j] = kriptovaniStr[k];
                    k++;
                }
            }

            char[,] transpozicionaPoY = new char[x, y];
            for (int i = 0; i < permutacijeY.Length; i++)
            {
                int vrednostPerY = Convert.ToInt32(permutacijeY[i].ToString());
                for (int j = 0; j < x; j++)
                {
                    transpozicionaPoY[j, vrednostPerY] = transpozicionaMatrica[j, i];
                }
            }
            char[,] transpozicionaPoX = new char[x, y];
            for (int i = 0; i < permutacijeX.Length; i++)
            {
                int vrednostPerX = System.Convert.ToInt32(permutacijeX[i].ToString());
                for (int j = 0; j < y; j++)
                {
                    transpozicionaPoX[vrednostPerX, j] = transpozicionaPoY[i, j];
                }
            }

            string dekriptovaniString = "";

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    dekriptovaniString += transpozicionaPoX[i, j];
                }
            }

            return dekriptovaniString;




        }

        public  string XTEAEncrypt(string data, string key)
        {
            byte[] bajtoviPodatka = Encoding.Unicode.GetBytes(data);
            byte[] bajtoviKljuca = Encoding.Unicode.GetBytes(key);
            var result = Encrypt(bajtoviPodatka, bajtoviKljuca);
            return Convert.ToBase64String(result);
        }

        
        public  string XTEADecrypt(string data, string key)
        {
            byte[] bajtoviPodatka = Convert.FromBase64String(data);
            byte[] bajtoviKljuca = Encoding.Unicode.GetBytes(key);
            var result = Decrypt(bajtoviPodatka, bajtoviKljuca);
            return Encoding.Unicode.GetString(result);
        }
        
        public  byte[] Encrypt(byte[] data, byte[] key)
        {
            var kljucbafer = CreateKey(key);
            var blockBuffer = new uint[2];
            byte[] result = new byte[NormalizujVelicinu(data.Length + 4)];
            byte[] lengthBuffer = BitConverter.GetBytes(data.Length);
            Array.Copy(lengthBuffer, result, lengthBuffer.Length);
            Array.Copy(data, 0, result, lengthBuffer.Length, data.Length);
            using (var stream = new MemoryStream(result))
            {
                using (var writer = new BinaryWriter(stream))
                {
                    for (int i = 0; i < result.Length; i += 8)
                    {
                        blockBuffer[0] = BitConverter.ToUInt32(result, i);
                        blockBuffer[1] = BitConverter.ToUInt32(result, i + 4);
                        Encrypt( blockBuffer, kljucbafer);
                        writer.Write(blockBuffer[0]);
                        writer.Write(blockBuffer[1]);
                    }
                }
            }
            return result;
        }

        
        public  byte[] Decrypt(byte[] data, byte[] key)
        {
           
            var kljucBafer = CreateKey(key);
            var blockBuffer = new uint[2];
            var buffer = new byte[data.Length];
            Array.Copy(data, buffer, data.Length);
            using (var stream = new MemoryStream(buffer))
            {
                using (var writer = new BinaryWriter(stream))
                {
                    for (int i = 0; i < buffer.Length; i += 8)
                    {
                        blockBuffer[0] = BitConverter.ToUInt32(buffer, i);
                        blockBuffer[1] = BitConverter.ToUInt32(buffer, i + 4);
                        Decrypt( blockBuffer, kljucBafer);
                        writer.Write(blockBuffer[0]);
                        writer.Write(blockBuffer[1]);
                    }
                }
            }
            
            var length = BitConverter.ToUInt32(buffer, 0);
            
            var result = new byte[length];
            Array.Copy(buffer, 4, result, 0, length);
            return result;
        }

        public  int NormalizujVelicinu(int length)
        {
            
            return (length + 7) / 8 * 8; 
        }

        
       public uint[] CreateKey(byte[] key)
        {
           
            var hash = new byte[16];
            for (int i = 0; i < key.Length; i++)
            {
                hash[i % 16] = (byte)((31 * hash[i % 16]) ^ key[i]);
            }
            for (int i = key.Length; i < hash.Length; i++)
            { 
                hash[i] = (byte)(17 * i ^ key[i % key.Length]);
            }
            return new[] {
                BitConverter.ToUInt32(hash, 0), BitConverter.ToUInt32(hash, 4),
                BitConverter.ToUInt32(hash, 8), BitConverter.ToUInt32(hash, 12)
            };
            

        }
       public void Encrypt( uint[] v, uint[] key)
        {
            uint v0 = v[0], v1 = v[1], sum = 0, delta = 0x9E3779B9;
            for (uint i = 0; i < 32; i++)
            {
                v0 += (((v1 << 4) ^ (v1 >> 5)) + v1) ^ (sum + key[sum & 3]);
                sum += delta;
                v1 += (((v0 << 4) ^ (v0 >> 5)) + v0) ^ (sum + key[(sum >> 11) & 3]);
            }
            v[0] = v0;
            v[1] = v1;
        }
        public void Decrypt( uint[] v, uint[] key)
        {
            uint v0 = v[0], v1 = v[1], delta = 0x9E3779B9, sum = delta * 32;
            for (uint i = 0; i < 32; i++)
            {
                v1 -= (((v0 << 4) ^ (v0 >> 5)) + v0) ^ (sum + key[(sum >> 11) & 3]);
                sum -= delta;
                v0 -= (((v1 << 4) ^ (v1 >> 5)) + v1) ^ (sum + key[sum & 3]);
            }
            v[0] = v0;
            v[1] = v1;
        }


    }
}
