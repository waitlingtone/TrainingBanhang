using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;
using TrainingAccounting.View;

namespace TrainingAccounting.Presenter
{
    public class NhomtrePresenter:Presenter<INhomtreView>
    {
        public NhomtrePresenter(INhomtreView view) : base(view) { }
        public void LoadData()
        {
            View.NhomtreItems = Model.Get<NhomTreModel>("sys_NhomTreSelect");
            View.RefreshData();
        }

        public void Add()
        {
            View.NhomtreItems.Add(new NhomTreModel());
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.NhomtreCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.NhomtreItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void Save()
        {
            Model.Set(View.NhomtreItems);
            View.RefreshData();
        }
    }
}
