using System.Text;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static byte[] mykey;
        static byte[] myvector;
        static byte[] encrypt;
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            using (Aes aes = Aes.Create())
            {
                mykey = aes.Key;
                myvector = aes.IV;
                encrypt = EncryptStringToBytes_Aes(txtOrigin.Text, aes.Key, aes.IV);
                txtCipher.Text = Encoding.Unicode.GetString(encrypt);
            }
        }
        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            using (Aes myAes = Aes.Create())
            {
                
                myAes.Key = mykey;
                myAes.IV = myvector;
              
                string roundtrip = DecryptStringFromBytes_Aes(encrypt, myAes.Key, myAes.IV);

                txtDecrypt.Text= roundtrip;
            }
        }
        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }
}
