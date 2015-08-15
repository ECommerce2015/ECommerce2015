using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Capstone.Models
{
    public class HashKey
    {
        public static string GetHashKey(string hashkey) 
        {
            MD5 md5Service = new MD5CryptoServiceProvider();
            md5Service.ComputeHash(ASCIIEncoding.ASCII.GetBytes(hashkey));
            byte[] result = md5Service.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++) 
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
    }
}