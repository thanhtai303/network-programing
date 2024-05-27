using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static RSAParameters publicKey;
        static byte[] encrypt;
        static byte[] decrypt;
        private void btnEncrypt_Click(object sender, EventArgs e)
        {

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                publicKey = RSA.ExportParameters(true);
                encrypt = RSA.Encrypt(Encoding.Unicode.GetBytes(txtOriginalText.Text), false);
                txtCipherText.Text = Encoding.Unicode.GetString(encrypt);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportParameters(publicKey);
                decrypt = RSA.Decrypt(encrypt, false);
                txtDecryptedText.Text = Encoding.Unicode.GetString(decrypt);
            }
        }
    }
}
