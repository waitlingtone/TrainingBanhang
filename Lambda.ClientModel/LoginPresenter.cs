using Lambda.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.ClientModel
{
    public class LoginPresenter:Presenter<ILoginView>
    {
        public LoginPresenter(ILoginView View)
            : base(View)
        {
        }
        public void Login()
        {
            Model.Login(View.stringUsername, View.stringPassword);
        }
        public void Logout()
        {
            Model.Logout();
        }
        public void LoginOneTimes()
        {
            Model.LoginOneTimes(View.stringUsername, View.stringPassword);
        }
        public void LogoutOneTimes()
        {
            Model.LogoutOneTimes();
        }
        public int SetNewPassword(string SpName,string stringOldPassword,string stringNewPassword,System.Data.SqlDbType SqlType = System.Data.SqlDbType.UniqueIdentifier)
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem
            {
                Name = "UserId",
                Value = ModelCore.UserId,
                SqlType = SqlType
            });
            items.Add(new AutoItem
            {
                Name = "stringOldPassword",
                Value = Lambda.Framework.AutoEncrypt.MD5Hash(stringOldPassword),
                SqlType = System.Data.SqlDbType.NVarChar
            });
            items.Add(new AutoItem
            {
                Name = "stringNewPassword",
                Value = Lambda.Framework.AutoEncrypt.MD5Hash(stringNewPassword),
                SqlType = System.Data.SqlDbType.NVarChar
            });
            return Model.SetAutoObject(new AutoObject {SpName = SpName,Items = items });
        }
    }
}
