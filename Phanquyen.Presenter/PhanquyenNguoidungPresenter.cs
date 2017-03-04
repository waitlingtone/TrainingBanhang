using Lambda.ClientModel;
using Phanquyen.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phanquyen.Model.BusinessObject;
using Lambda.BusinessObject;

namespace Phanquyen.Presenter
{
    public class PhanquyenNguoidungPresenter:Presenter<IPhanquyenNguoidungView>
    {
        public PhanquyenNguoidungPresenter(IPhanquyenNguoidungView view) : base(view) { }
        public void LoadData()
        {
            View.NguoidungItems = Model.Get<NguoidungModel>("sys_NguoidungSelect");
            View.UserItems = Model.Get<_UserModel>("Phanquyen_Danh_UserSelect");
            View.RoleItems = Model.Get<RoleModel>("sys_RoleSelect");
        }

        public void GetVaitroCanbo()
        {
            if (View.UserCurrent == null)
                return;
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "UserId", Value = View.UserCurrent._UserId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.UserRoleItems = Model.Get<UserRoleModel>(new AutoObject { Items = item, SpName = "Phanquyen_Danh_GetUserRoleByUserId" });

            if (View.RoleItems == null)
                return;
            foreach (var i in View.RoleItems)
                i.Selected = false;
            foreach (var i in View.RoleItems)
                foreach (var j in View.UserRoleItems)
                    if (i.RoleId == j.RoleId)
                        i.Selected = true;
            View.RefreshData();
        }

        public void Save()
        {
            String RoleIds = "'" + new Guid() + "',";
            foreach (var i in View.RoleItems)
                if (i.Selected)
                    RoleIds += "'" + i.RoleId + "',";
            RoleIds = RoleIds.Substring(0, RoleIds.Length - 1);

            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "UserId", Value = View.UserCurrent._UserId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            item.Add(new AutoItem { Name = "RoleIds", Value = RoleIds, SqlType = System.Data.SqlDbType.NVarChar });
            Model.SetAutoObject(new AutoObject { Items = item, SpName = "Phanquyen_Danh_SaveUserRole" });
        }
    }
}
