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
    public class VaitroPresenter:Presenter<IVaitroView>
    {
        public VaitroPresenter(IVaitroView view) : base(view) { }

        public void LoadData()
        {
            View.VaitroItems = Model.Get<RoleModel>("sys_RoleSelect");
        }
        public void Add()
        {
            View.VaitroItems.Add(new RoleModel());
            View.RefreshData();
        }
        public void Delete()
        {
            var cur = View.VaitroCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.VaitroItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }
        public void Save()
        {
            Model.Set(View.VaitroItems);
            View.RefreshData();
        }
    }
}
