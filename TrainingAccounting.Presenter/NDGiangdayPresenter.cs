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
    public class NDGiangdayPresenter:Presenter<INDGiangdayView>
    {
        public NDGiangdayPresenter(INDGiangdayView view) : base(view) { }
        public void LoadData()
        {
            View.NDGiangdayItems = Model.Get<NDGiangdayModel>("sys_NDGiangdaySelect");
        }
        public void Add()
        {
            View.NDGiangdayItems.Add(new NDGiangdayModel());
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.NDGiangdayCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.NDGiangdayItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void Save()
        {
            Model.Set(View.NDGiangdayItems);
            View.RefreshData();
        }
    }
}
