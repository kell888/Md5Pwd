using System;
using System.Text;
using System.Security.Cryptography;

namespace MD5Pwd
{
    public class MD5Util
    {
        public static string GetMD5Hash(string input)
        {
            input = input ?? "";
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] res = md5.ComputeHash(Encoding.Unicode.GetBytes(input), 0, input.Length);
            char[] temp = new char[res.Length];
            System.Array.Copy(res, temp, res.Length);
            return new String(temp);
        }
    }
}
