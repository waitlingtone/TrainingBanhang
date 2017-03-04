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
    public class TongiaoPresenter:Presenter<ITongiaoView>
    {
        public TongiaoPresenter(ITongiaoView view) : base(view) { }
        public void LoadData()
        {
            View.TongiaoItems = Model.Get<TongiaoModel>("sys_TongiaoSelect");
            View.RefreshData();
        }
        public void Add()
        {
            View.TongiaoItems.Add(new TongiaoModel());
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.TongiaoCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.TongiaoItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void Save()
        {
            Model.Set(View.TongiaoItems);
            View.RefreshData();
        }
    }
}
