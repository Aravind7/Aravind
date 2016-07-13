using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WebApplication5.Models
{
    public class CryptoUtil
    {
        public string DecryptData(string data2Decrypt, string strPrivateKey)
        {
            //CspParameters parameters = new CspParameters();        
            //parameters.Flags = CspProviderFlags.UseMachineKeyStore;
            //RSACryptoServiceProvider provider = new RSACryptoServiceProvider(1024, parameters);
            RSACryptoServiceProvider provider = new RSACryptoServiceProvider();
            byte[] rgb = Convert.FromBase64String(data2Decrypt);
            provider.FromXmlString(strPrivateKey);
            byte[] bytes = provider.Decrypt(rgb, false);
            return Encoding.UTF8.GetString(bytes);
        }

        public string EncryptData(string data2Encrypt, string strPublicKey)
        {
            RSACryptoServiceProvider provider = new RSACryptoServiceProvider();
            provider.FromXmlString(strPublicKey);
            byte[] bytes = Encoding.UTF8.GetBytes(data2Encrypt);
            return Convert.ToBase64String(provider.Encrypt(bytes, false));
        }

        public object rsaCreateKeys(ref string iPublicKey, ref string iPrivateKey)
        {
            object obj2;
            try
            {
                CspParameters parameters = new CspParameters();
                parameters.Flags = CspProviderFlags.UseMachineKeyStore;
                RSACryptoServiceProvider provider = new RSACryptoServiceProvider(parameters);
                iPrivateKey = provider.ToXmlString(true);
                iPublicKey = provider.ToXmlString(false);
                obj2 = true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return obj2;
        }
    }
}