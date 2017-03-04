using Lambda.BusinessObject;
using Lambda.ClientModel;
using Phanquyen.Model.BusinessObject;
using Phanquyen.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phanquyen.Presenter
{
    public class PhanquyenChucnangChoVaitroPresenter:Presenter<IPhanquyenChucnangChoVaitroView>
    {
        public PhanquyenChucnangChoVaitroPresenter(IPhanquyenChucnangChoVaitroView view) : base(view) { }
        public void LoadData()
        {
            View.VaitroItems = Model.Get<RoleModel>("sys_RoleSelect");
            //View.ChucnangItems = Model.Get<Item>("sys_ItemSelect");
            View.NhomChucnangItems = Model.Get<GroupItemModel>("sys_GroupItemSelect");
        }

        public void GetChucnangByVaitro()
        {
            if (View.VaitroCurrent == null)
                View.VaitroChucnangItems = new List<RoleRightModel>();
            else
            {
                var item = new List<AutoItem>();
                item.Add(new AutoItem { Name = "RoleId", Value = View.VaitroCurrent.RoleId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
                View.VaitroChucnangItems = Model.Get<RoleRightModel>(new AutoObject { Items = item, SpName = "Phanquyen_Danh_GetRoleRightByRoleId" });
            }
        }

        public void Save()
        {
            if (View.VaitroCurrent == null)
                return;

            String ItemIds = "'" + new Guid() + "',";
            foreach (var i in View.ItemIds)
                ItemIds += "'" + i.Value.ToString() + "',";
            ItemIds = ItemIds.Substring(0, ItemIds.Length - 1);

            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "RoleId", Value = View.VaitroCurrent.RoleId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            item.Add(new AutoItem { Name = "GroupItemId", Value = View.NhomChucnangId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            item.Add(new AutoItem { Name = "ItemIds", Value = ItemIds, SqlType = System.Data.SqlDbType.NVarChar });
            Model.SetAutoObject(new AutoObject { Items = item, SpName = "Phanquyen_Danh_SaveRoleRight" });
        }

        public void GetVaitro()
        {
            View.VaitroItems = Model.Get<RoleModel>("sys_RoleSelect");
        }

        public void GetChucnangByNhomChucnang()
        {
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "GroupItemId", Value = View.NhomChucnangId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.ChucnangItems = Model.Get<Item>(new AutoObject { Items = item, SpName = "Phanquyen_Danh_GetItemByGroupItemId" });
        }
    }
}
