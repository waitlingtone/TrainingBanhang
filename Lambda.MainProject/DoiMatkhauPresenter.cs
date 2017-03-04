using Lambda.BusinessObject;
using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.MainProject
{
    public class DoiMatkhauPresenter:Presenter<IDoiMatkhauView>
    {
        public DoiMatkhauPresenter(IDoiMatkhauView view) : base(view) { }
        public void Save()
        {
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "_UserId", Value = Lambda.ClientModel.ModelCore.UserId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            item.Add(new AutoItem { Name = "Pass", Value = ConvertToMd5(View.OldPass) , SqlType = System.Data.SqlDbType.NVarChar });
            _UserModel user = Model.Get<_UserModel>(new AutoObject { Items = item, SpName = "MainProject_KiemtraTontaiUser" }).FirstOrDefault();
            if (user == null)
                throw new Exception();
            else
            {
                item = new List<AutoItem>();
                item.Add(new AutoItem { Name = "_UserId", Value = Lambda.ClientModel.ModelCore.UserId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
                item.Add(new AutoItem { Name = "NewPass", Value = ConvertToMd5(View.NewPass), SqlType = System.Data.SqlDbType.NVarChar });
                Model.SetAutoObject(new AutoObject { Items = item, SpName = "MainProject_UpdateMatkhau" });
            }
        }
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
