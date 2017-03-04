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
    public class TaikhoanPresenter:Presenter<ITaikhoanView>
    {
        public TaikhoanPresenter(ITaikhoanView view) : base(view) { }

        public void LoadData()
        {
            View.NguoidungItems = Model.Get<NguoidungModel>("sys_NguoidungSelect");
            View.UserItems = Model.Get<_UserModel>("sys__UserSelect");
        }

        public void AddUser()
        {
            if (View.NguoidungCurrent == null)
                return;
            View.UserItems.Add(new _UserModel { NguoidungId = View.NguoidungCurrent.NguoidungId });
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.UserCurrent;
            if (cur == null)
                return;
            if (cur.State == RowState.Insert)
            {
                View.UserItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void Save()
        {
            Model.Set(View.NguoidungItems);
            Model.Set(View.UserItems);
            View.RefreshData();
        }

        public void AddNguoidung()
        {
            View.NguoidungItems.Add(new NguoidungModel());
            View.RefreshData();
        }

        public void DeleteNguoidung()
        {
            var cur = View.NguoidungCurrent;
            if (cur == null)
                return;
            if (cur.State == RowState.Insert)
            {
                View.NguoidungItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void SaveNguoidung()
        {
            Model.Set(View.NguoidungItems);
            View.RefreshData();
        }
    }
}
