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
    public class CahocPresenter:Presenter<ICahocView>
    {
        public CahocPresenter(ICahocView view) : base(view) { }
        public void LoadData()
        {
            View.CahocItems = Model.Get<CahocModel>("sys_CahocSelect");
            View.RefreshData();
        }

        public void Add()
        {
            View.CahocItems.Add(new CahocModel());
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.CahocCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.CahocItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void Save()
        {
            Model.Set(View.CahocItems);
            View.RefreshData();
        }
    }
}
