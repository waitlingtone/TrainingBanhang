﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Phanquyen.Model.BusinessObject
{
    public partial class _UserModel
    {
        public String TenDangnhap { get { return _Username; } set { _Username = ConvertToMd5(value); } }
        public String Matkhau { get { return _Password; } set { _Password = ConvertToMd5(value); } }

        private String ConvertToMd5(String source)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                if (source == null)
                    return null;
                string hash = GetMd5Hash(md5Hash, source);
                return hash;
            }
        }
        string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes 
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string. 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }
    }
}