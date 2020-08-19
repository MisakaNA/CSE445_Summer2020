using System;

namespace Encryptor
{
    class CryptDLL
    {
        public string Enrypt(string str)
        {
            string KEY = "CSE445Proj5";
            string encryptedStr = "";
            for(int i = 0; i < str.Length; i++)
            {
                encryptedStr += (char)(str[i] ^ KEY[i % KEY.Length]);
            }

            return encryptedStr;
        }

        public string Decrypt(string encryptedStr)
        {
            string KEY = "CSE445Proj5";
            string normalStr = "";
            for (int i = 0; i < encryptedStr.Length; i++)
            {
                normalStr += (char)(encryptedStr[i] ^ KEY[i % KEY.Length]);
            }

            return normalStr;
        }
    }
}
