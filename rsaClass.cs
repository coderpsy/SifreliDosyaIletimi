using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace bitirme1
{
    public class rsaClass
    {
        public rsaClass()
        {

        }


        #region keygen
        public void generateKey(int keyBit)
        {

            int currentBitStrength = keyBit;
            string filename = keyBit.ToString() + "bit";

            RSACryptoServiceProvider RSAProvider = new RSACryptoServiceProvider(currentBitStrength);

            string pubKey = "<BitStrength>" + keyBit.ToString() + "</BitStrength>" + RSAProvider.ToXmlString(false);
            string privKey = "<BitStrength>" + keyBit.ToString() + "</BitStrength>" + RSAProvider.ToXmlString(true);

            publicKey(currentBitStrength, pubKey);
            privateKey(currentBitStrength, privKey);

        }

        public void publicKey(int keyBit, string pubKey)
        {
            try
            {
                Directory.CreateDirectory(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\keys\\rsa\\publics\\");
                string path = Path.Combine(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\keys\\rsa\\publics\\");

                path += DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + "_rsa_" + keyBit.ToString() + "bit.pb";// +DateTime.Today.ToString();

                // dosyaya yazma işlemi burada yapıldı
                File.WriteAllText(path, pubKey);
                
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        public void privateKey(int keyBit, string privKey)
        {
            try
            {
                Directory.CreateDirectory(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\keys\\rsa\\privates\\");
                string path = Path.Combine(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\keys\\rsa\\privates\\");

                path += DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + "_rsa_" + keyBit.ToString() + "bit.pr";// +DateTime.Today.ToString();

                File.WriteAllText(path, privKey);

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        #endregion

        #region encryption

        public string Encrypt(object inputObject)
        {

            object[] inputObjects = (object[])inputObject;

            try
            {
                return (EncryptString((string)inputObjects[0], (int)inputObjects[1], (string)inputObjects[2]));

            }

            catch (CryptographicException CEx)
            { MessageBox.Show("hata: \n" + CEx.Message); }


            catch (Exception Ex)
            { MessageBox.Show("hata: \n" + Ex.Message); }

            return null;
        }

        public string EncryptString(string inputString, int dwKeySize, string xmlString)
        {

            // TODO: Add Proper Exception Handlers
            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize);
            rsaCryptoServiceProvider.FromXmlString(xmlString);
            
            int keySize = dwKeySize / 8;
            byte[]  sifre= Encoding.UTF32.GetBytes(inputString);

            // The hash function in use by the .NET RSACryptoServiceProvider here is SHA1
            // int maxLength = ( keySize ) - 2 - ( 2 * SHA1.Create().ComputeHash( rawBytes ).Length );
            
            int maxLength = keySize - 42;
            int dataLength = sifre.Length;
            int iterations = dataLength / maxLength;
            StringBuilder stringBuilder = new StringBuilder();
            
            for (int i = 0; i <= iterations; i++)
            {
                byte[] tempBytes = new byte[(dataLength - maxLength * i > maxLength) ? maxLength : dataLength - maxLength * i];
                Buffer.BlockCopy(sifre, maxLength * i, tempBytes, 0, tempBytes.Length);
                byte[] encryptedBytes = rsaCryptoServiceProvider.Encrypt(tempBytes, true);
                // Be aware the RSACryptoServiceProvider reverses the order of encrypted bytes after encryption and before decryption.
                // If you do not require compatibility with Microsoft Cryptographic API (CAPI) and/or other vendors.
                // Comment out the next line and the corresponding one in the DecryptString function.
                Array.Reverse(encryptedBytes);
                // Why convert to base 64?
                // Because it is the largest power-of-two base printable using only ASCII characters
                stringBuilder.Append(Convert.ToBase64String(encryptedBytes));

            }
            return stringBuilder.ToString();

        }
        #endregion

        #region decryption

        public string Decrypt(object inputObject)
        {
            object[] inputObjects = (object[])inputObject;

            try
            {
                return (DecryptString((string)inputObjects[0], (int)inputObjects[1], (string)inputObjects[2]));
            }

            catch (CryptographicException CEx)
            { MessageBox.Show("hata: \n" + CEx.Message); }

            catch (Exception Ex)
            { MessageBox.Show("hata: \n" + Ex.Message); }

            return null;
        }

        public string DecryptString(string inputString, int dwKeySize, string xmlString)
        {
            // TODO: Add Proper Exception Handlers
            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize);
            rsaCryptoServiceProvider.FromXmlString(xmlString);
            
            int base64BlockSize = ((dwKeySize / 8) % 3 != 0) ? (((dwKeySize / 8) / 3) * 4) + 4 : ((dwKeySize / 8) / 3) * 4;
            int iterations = inputString.Length / base64BlockSize;
            
            ArrayList arrayList = new ArrayList();
            
            for (int i = 0; i < iterations; i++)
            {
                byte[] encryptedBytes = Convert.FromBase64String(inputString.Substring(base64BlockSize * i, base64BlockSize));
                // Be aware the RSACryptoServiceProvider reverses the order of encrypted bytes after encryption and before decryption.
                // If you do not require compatibility with Microsoft Cryptographic API (CAPI) and/or other vendors.
                // Comment out the next line and the corresponding one in the EncryptString function.
                Array.Reverse(encryptedBytes);
                arrayList.AddRange(rsaCryptoServiceProvider.Decrypt(encryptedBytes, true));
            }
            
            return Encoding.UTF32.GetString(arrayList.ToArray(Type.GetType("System.Byte")) as byte[]);
        }
        #endregion

    }
}
