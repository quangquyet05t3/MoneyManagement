using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.IO.Compression;

namespace MoneyManagement
{
    public static class PublicFunction
    {
        public static List<Data> ReadData()
        {
            string[] files = Directory.GetFiles(Environment.CurrentDirectory, "*.mmd");
            List<Data> listobData = new List<Data>();
            Data obData = null;

            foreach (string file in files)
            {
                obData = (Data)ReadObjectFromXmlUpgraded(file);
                if (obData == null)
                {
                    obData = (Data)ReadObjectFromXml(file);
                }
                if (obData == null)
                {
                    obData = (Data)ReadObject(file);
                }
                if (obData != null)
                    listobData.Add(obData);
            }

            return listobData;
        }
        public static bool WriteData(int p_Year, Data p_Data)
        {
            return WriteObjectToXmlUpgraded(p_Year + ".mmd", p_Data);
        }

        private const string Salt = "KSP3P4V7";
        public static string EncryptPassword(string Password)
        {
            return Encrypt(Password, Salt, true);
        }
        public static string DecryptPassword(string encryptedPassword)
        {
            return Decrypt(encryptedPassword, Salt, true);
        }
        public static bool WriteObject(string path, object ob)
        {
            try
            {
                BinaryFormatter BinaryDataFormatter = new BinaryFormatter();
                MemoryStream MemStream = new MemoryStream();
                BinaryDataFormatter.Serialize(MemStream, ob);
                Byte[] toEncrypt = Encrypt(MemStream.ToArray(), Salt);
                Stream streamToFile = File.Open(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                streamToFile.Write(toEncrypt, 0, toEncrypt.Length);
                streamToFile.Flush();
                streamToFile.Close();
                streamToFile.Dispose();
                MemStream.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                string msgException = ex.Message;
                return false;
            }
        }
        public static object ReadObject(string path)
        {
            try
            {
                BinaryFormatter BinaryDataFormatter = new BinaryFormatter();
                Stream streamFromFile = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                Byte[] encrypedFromStream = new Byte[streamFromFile.Length];
                streamFromFile.Read(encrypedFromStream, 0, encrypedFromStream.Length);
                MemoryStream MemStream = new MemoryStream(Decrypt(encrypedFromStream, Salt));
                Object ob = BinaryDataFormatter.Deserialize(MemStream);
                streamFromFile.Dispose();
                MemStream.Dispose();
                return ob;
            }
            catch (Exception ex)
            {
                string msgException = ex.Message;
                return null;
            }
        }
        public static bool WriteObjectToXml(string path, object ob)
        {
            try
            {
                using (Stream fs = new FileStream(path, FileMode.Create))
                {
                    //RijndaelManaged RM = new RijndaelManaged();
                    //RM.BlockSize = RM.KeySize;
                    //PasswordDeriveBytes secretKey = new PasswordDeriveBytes(Encoding.Unicode.GetBytes(Salt), Encoding.ASCII.GetBytes(Salt));
                    //RM.Key = secretKey.GetBytes(RM.KeySize / 8);
                    //RM.IV = RM.Key;
                    //ICryptoTransform desEncrypt = RM.CreateEncryptor();

                    DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                    DES.Key = ASCIIEncoding.ASCII.GetBytes(Salt);
                    DES.IV = DES.Key;
                    ICryptoTransform desEncrypt = DES.CreateEncryptor();
                    using (CryptoStream cs = new CryptoStream(fs, desEncrypt, CryptoStreamMode.Write))
                    {
                        XmlSerializer xmlser = new XmlSerializer(typeof(Data));
                        xmlser.Serialize(cs, ob);
                    }
                    desEncrypt.Dispose();
                }
                return true;
            }
            catch (Exception ex)
            {
                string msgException = ex.Message;
                return false;
            }
        }        
        public static object ReadObjectFromXml(string path)
        {
            try
            {
                object ob = null;
                using (Stream fs = new FileStream(path, FileMode.Open))
                {
                    //RijndaelManaged RM = new RijndaelManaged();
                    //RM.BlockSize = RM.KeySize;
                    //PasswordDeriveBytes secretKey = new PasswordDeriveBytes(Encoding.Unicode.GetBytes(Salt), Encoding.ASCII.GetBytes(Salt));
                    //RM.Key = secretKey.GetBytes(RM.KeySize / 8);
                    //RM.IV = RM.Key;
                    //ICryptoTransform desEncrypt = RM.CreateDecryptor();

                    DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                    DES.Key = ASCIIEncoding.ASCII.GetBytes(Salt);
                    DES.IV = DES.Key;
                    ICryptoTransform desEncrypt = DES.CreateDecryptor();
                    using (CryptoStream cs = new CryptoStream(fs, desEncrypt, CryptoStreamMode.Read))
                    {
                        XmlSerializer xmlser = new XmlSerializer(typeof(Data));
                        ob = xmlser.Deserialize(cs);
                    }
                    desEncrypt.Dispose();
                }
                return ob;
            }
            catch (Exception ex)
            {
                string msgException = ex.Message;
                return null;
            }
        }
        public static bool WriteObjectToXmlUpgraded(string path, object ob)
        {
            try
            {
                using (Stream fs = new FileStream(path, FileMode.Create))
                {
                    RijndaelManaged RM = new RijndaelManaged();
                    RM.BlockSize = RM.KeySize;
                    //Rfc2898DeriveBytes secretKey = new Rfc2898DeriveBytes(Salt, Encoding.ASCII.GetBytes(Salt));
                    PasswordDeriveBytes secretKey = new PasswordDeriveBytes(Encoding.Unicode.GetBytes(Salt), Encoding.ASCII.GetBytes(Salt));
                    RM.Key = secretKey.GetBytes(RM.KeySize / 8);
                    RM.IV = RM.Key;
                    ICryptoTransform desEncrypt = RM.CreateEncryptor();

                    using (CryptoStream cs = new CryptoStream(fs, desEncrypt, CryptoStreamMode.Write))
                    {
                        XmlSerializer xmlser = new XmlSerializer(typeof(Data));
                        xmlser.Serialize(cs, ob);
                    }
                    desEncrypt.Dispose();
                }
                return true;
            }
            catch (Exception ex)
            {
                string msgException = ex.Message;
                return false;
            }
        }
        public static object ReadObjectFromXmlUpgraded(string path)
        {
            try
            {
                object ob = null;
                using (Stream fs = new FileStream(path, FileMode.Open))
                {
                    RijndaelManaged RM = new RijndaelManaged();
                    RM.BlockSize = RM.KeySize;
                    //Rfc2898DeriveBytes secretKey = new Rfc2898DeriveBytes(Salt, Encoding.ASCII.GetBytes(Salt));
                    PasswordDeriveBytes secretKey = new PasswordDeriveBytes(Encoding.Unicode.GetBytes(Salt), Encoding.ASCII.GetBytes(Salt));
                    RM.Key = secretKey.GetBytes(RM.KeySize / 8);
                    RM.IV = RM.Key;
                    ICryptoTransform desEncrypt = RM.CreateDecryptor();

                    using (CryptoStream cs = new CryptoStream(fs, desEncrypt, CryptoStreamMode.Read))
                    {
                        XmlSerializer xmlser = new XmlSerializer(typeof(Data));
                        ob = xmlser.Deserialize(cs);
                    }
                    RM.Clear();
                    desEncrypt.Dispose();
                }
                return ob;
            }
            catch (Exception ex)
            {
                string msgException = ex.Message;
                return null;
            }
        }

        public static byte[] Compress(byte[] bytData)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                Stream s = new GZipStream(ms, CompressionMode.Compress);
                s.Write(bytData, 0, bytData.Length);
                s.Close();
                byte[] compressedData = (byte[])ms.ToArray();
                return compressedData;
            }
            catch
            {
                return null;
            }
        }

        public static byte[] DeCompress(byte[] bytInput)
        {
            string strResult = "";
            int totalLength = 0;
            byte[] writeData = new byte[4096];
            Stream s2 = new GZipStream(new MemoryStream(bytInput), CompressionMode.Decompress);
            while (true)
            {
                int size = s2.Read(writeData, 0, writeData.Length);
                if (size > 0)
                {
                    totalLength += size;
                    strResult += System.Text.Encoding.Unicode.GetString(writeData, 0, size);
                }
                else
                {
                    break;
                }
            }
            s2.Close();
            return Encoding.Unicode.GetBytes(strResult);
        } 

        ////////////////////Encrypt Function////////////////////
        private static byte[] Encrypt(byte[] plainData, string sKey)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = DES.Key;
            ICryptoTransform desEncrypt = DES.CreateEncryptor();
            Byte[] encryptedData = desEncrypt.TransformFinalBlock(plainData, 0, plainData.Length);
            DES.Clear();
            desEncrypt.Dispose();
            return encryptedData;
        }
        private static string Encrypt(string toEncrypt, string key, bool useHashing)
        {
            Byte[] keyArray;
            Byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.Zeros;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        ////////////////////Decrypt Function////////////////////
        private static byte[] Decrypt(byte[] encryptedData, string sKey)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = DES.Key;
            ICryptoTransform desDecrypt = DES.CreateDecryptor();
            Byte[] decryptedData = desDecrypt.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            DES.Clear();
            desDecrypt.Dispose();
            return decryptedData;
        }
        private static string Decrypt(string toDecrypt, string key, bool useHashing)
        {
            Byte[] keyArray;
            Byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = System.Security.Cryptography.PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        public static void WriteLog(string p_Message)
        {
            string pathFile = DateTime.Now.ToString("yyyyMMdd_") + "ErrorLog.txt";
            StreamWriter log;
            if (File.Exists(pathFile))
            {
                log = File.AppendText(pathFile);
            }
            else
            {
                log = new StreamWriter(pathFile);
            }

            // Write to the file:
            log.WriteLine("Time: " + DateTime.Now);
            log.WriteLine(p_Message);
            log.WriteLine("=====================================================================");

            // Close the stream:
            log.Close();
            log.Dispose();
        }
    }
}
