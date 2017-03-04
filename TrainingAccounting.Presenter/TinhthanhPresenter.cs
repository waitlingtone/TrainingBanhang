using Lambda.ClientModel;
using Lambda.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.View;
using TrainingAccounting.Model.BusinessObject;


namespace TrainingAccounting.Presenter
{
    public class TinhthanhPresenter:Presenter<ITinhthanhView>
    {
        public TinhthanhPresenter(ITinhthanhView view) : base(view) { }
        public void LoadData()
        {
            View.TinhthanhItems = Model.Get<TinhthanhModel>("sys_TinhthanhSelect");
        }


        public void Add()
        {
            View.TinhthanhItems.Add(new TinhthanhModel());
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.TinhthanhCurrent;
            if (cur == null)
                return;
            if (cur.State ==Lambda.BusinessObject.RowState.Insert)
            {
                View.TinhthanhItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void Save()
        {
            Model.Set(View.TinhthanhItems);
            View.RefreshData();
        }
    }
}
