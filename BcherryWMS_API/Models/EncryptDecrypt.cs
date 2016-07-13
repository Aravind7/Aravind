using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WebApplication5.Models
{
    public class EncryptDecrypt
    {
        CryptoUtil Crypto = new CryptoUtil();
        public string GetDecryptedPassword(string strPassword)
        {
            // Gets the Public Key to Encrypt
            string strPrivateKey = GetPrvtKey();
            return Crypto.DecryptData(strPassword, strPrivateKey);
        }

        private string GetPrvtKey()
        {
            //var db = logservice.GetPrivateKey();

            //var query = (from a in db
            //             select a.PrivateKey
            //).ToList();

            //return query[0].ToString();
            return "<RSAKeyValue><Modulus>nNNUqI1hOncUAJ/yybk+HpdQohRmRfWFNz8P+76qwtrrWzmljdGFQasAIl6xorTSq8JYksqctnfSFfNMt9lxGD29HlxSzn29Vju6OgVkl3+wHdVfUSKtr/QosNGpanKV+5TXOy35XohpV7bLO9MCTvTvzSUwxCbQHDX+mP0AFk0=</Modulus><Exponent>AQAB</Exponent><P>0BrkxqgabVCPf9et5qYFqHrbFb43zk2YtYcSMfmf4psZIlRGgNdOJywkmgpYms5f+kAbrlYUZCErwhuhLqhn3w==</P><Q>wOsn19VvGsSvmjAto9KC1dXl0ai97gachpSPr3W8gC5NVg0sJfgl+vXT801We7Enwo1Y20mCKOaAsEnpwpq3Uw==</Q><DP>h913DWfE0SeueFW0mIg923BSRtDImG06zREhRPVneEewUiRZX1ayFIsSXmtwy6j/Kl/ecqSKbZDmg7UMN20FWw==</DP><DQ>hKuzlNz1MYV99h2X5YfJ7mDRUeQn6d+mGW9leRcQ8V3mVX1tlRcYl4QjpLjU9u+YFlW6e+QLnTEX4ySRnAFmfQ==</DQ><InverseQ>FsgydGlGqef/pWdMVDXswM5B/VgtAmFfqhYLUjXPhYEyUeIYhPK3XjRvAYpsrfPDYlnZIZYQd0svJqbuqCVb+Q==</InverseQ><D>JpwlAKZmJKXCh/DZLm7r604nrO/GyjyLQrHE9p7XnceWIEyOBN9rpmI6UzvrEfrgzya29dTqRkYzs/HFlpHzNLjrDXQmOKcebit+paIv0fXti4yPE7mcGAmONXpRYLrlDGUIXolgeXQa6EPlTeXvcKrSUexjDs4IufN3EC01pcU=</D></RSAKeyValue>";
        }

        public string GetEncryptedPassword(string strPassword)
        {
            // Gets the Public Key to Encrypt
            string strPrivateKey = GetPrvtKey();
            return Crypto.EncryptData(strPassword, strPrivateKey);
        }


        public string GetDefaultPassword(string loginId)
        {
            string strPwd = string.Empty;

            strPwd = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(loginId.Replace(" ", "")) + "@" + DateTime.Now.ToString("mmss");

            //Reverse password
            string decryptedPwd = GetEncryptedPassword(strPwd);

            return decryptedPwd;
        }

        public static string Encrypt(string pstrText)
        {
            string pstrEncrKey = "1239;[pewGKG)NisarFidesTech";
            byte[] byKey = { };
            byte[] IV = { 18, 52, 86, 120, 144, 171, 205, 239 };
            byKey = System.Text.Encoding.UTF8.GetBytes(pstrEncrKey.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.UTF8.GetBytes(pstrText);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Convert.ToBase64String(ms.ToArray());
        }

        public static string Decrypt(string pstrText)
        {
            pstrText = pstrText.Replace(" ", "+");
            string pstrDecrKey = "1239;[pewGKG)NisarFidesTech";
            byte[] byKey = { };
            byte[] IV = { 18, 52, 86, 120, 144, 171, 205, 239 };
            byte[] inputByteArray = new byte[pstrText.Length];

            byKey = System.Text.Encoding.UTF8.GetBytes(pstrDecrKey.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            inputByteArray = Convert.FromBase64String(pstrText);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            return encoding.GetString(ms.ToArray());
        }
    }
}