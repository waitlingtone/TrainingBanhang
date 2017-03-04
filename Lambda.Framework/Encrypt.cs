using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.Framework
{
    public class AutoEncrypt
    {
        public static string MD5Hash(string text, int num = 1)
        {
            String result=text;
            for (int i = 0; i < num; i++)
            {
                result = MD5Hash(result);
            }
            return result;
        }
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.UTF8.GetBytes(text));
            //get hash result after compute it
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
        public static string MakeChecksum(string xml, bool IsEncrypt = false)
        {
            if (string.IsNullOrEmpty(xml))
                return "";
            long x = 0;

            for (int i = 0; i < xml.Length; i++)
            {
                x += System.Convert.ToInt64(xml[i]);
            }
            if (IsEncrypt == true)
                return SHA1Hash(x.ToString(), Encoding.BigEndianUnicode);
            return x.ToString();

        }
        public static string SHA1Hash(string text, Encoding enc)
        {
            byte[] buffer = enc.GetBytes(text);
            SHA1CryptoServiceProvider cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
            return BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
        }
        public static string RSAEncrypt(string data, string key)
        {
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(key);
                byte[] plainbytes = Encoding.Unicode.GetBytes(data);
                byte[] cipherbytes;
                cipherbytes = rsa.Encrypt(plainbytes, true);
                SoapHexBinary so = new SoapHexBinary(cipherbytes);
                return so.ToString();
            }
            catch { return null; }
        }
        public static string RSADecrypt(string data, string key)
        {
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                //public and privateRSA parameters for encrypt
                rsa.FromXmlString(key);
                SoapHexBinary so = SoapHexBinary.Parse(data);
                byte[] cipherbytes = so.Value;
                //read ciphertext, decrypt it to plaintext
                byte[] plainbytes =rsa.Decrypt(cipherbytes,true); //fOAEP needs high encryption pack
                //display recovered plaintext
                return Encoding.Unicode.GetString(plainbytes);
            }
            catch { return null; }
        }
    }
}
