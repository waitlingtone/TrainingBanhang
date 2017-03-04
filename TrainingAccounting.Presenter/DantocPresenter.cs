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
    public class DantocPresenter: Presenter<IDantocView>
    {
        public DantocPresenter(IDantocView view) : base(view) { }
        public void LoadData()
        {
            View.DantocItems = Model.Get<DantocModel>("sys_DantocSelect");
            View.RefreshData();
        }

        public void Add()
        {
            View.DantocItems.Add(new DantocModel());
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.DantocCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.DantocItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void Save()
        {
            Model.Set(View.DantocItems);
            View.RefreshData();
        }
    }
}
