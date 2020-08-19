using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    /// <summary>
    /// This is a class library
    /// </summary>
    public class CryptorDLL
    {
        /// <summary>
        /// This is an encryptor base on XOR algorithm
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Encrypt(string str)
        {
            //set encryption key
            string KEY = "CSE445Proj5";
            string encryptedStr = "";
            //for each character in the parameter string, XOR with a specified key character
            for (int i = 0; i < str.Length; i++)
            {
                encryptedStr += (char)(str[i] ^ KEY[i % KEY.Length]);
            }
            //fix a displaying error
            return encryptedStr.Replace("\0", "\\0");
        }

        /// <summary>
        /// This is an decryptor base on XOR algorithm
        /// </summary>
        /// <param name="encryptedStr"></param>
        /// <returns></returns>
        public static string Decrypt(string encryptedStr)
        {
            
            encryptedStr = encryptedStr.Replace("\r", "").Replace("\\0", "\0");
            string KEY = "CSE445Proj5";
            string normalStr = "";
            //decrypt the string using the same way as encrypt
            for (int i = 0; i < encryptedStr.Length; i++)
            {
                normalStr += (char)(encryptedStr[i] ^ KEY[i % KEY.Length]);
            }

            return normalStr;
        }
    }
}

