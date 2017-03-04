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
    public class NhomChucnangPresenter:Presenter<INhomChucnangView>
    {
        public NhomChucnangPresenter(INhomChucnangView view) : base(view) { }
        public void LoadData()
        {
            View.NhomChucnangItems = Model.Get<GroupItemModel>("sys_GroupItemSelect");
        }
        public void Add()
        {
            View.NhomChucnangItems.Add(new GroupItemModel());
            View.RefreshData();
        }
        public void Delete()
        {
            var cur = View.NhomchucnangCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.NhomChucnangItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }
        public void Save()
        {
            Model.Set(View.NhomChucnangItems);
            View.RefreshData();
        }
    }
}
