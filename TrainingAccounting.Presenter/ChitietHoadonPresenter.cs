using Lambda.BusinessObject;
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
    public class ChitietHoadonPresenter : Presenter<IChitietHoadonView>
    {
        public ChitietHoadonPresenter(IChitietHoadonView view)
            : base(view)
        { }

        public void LoadData()
        {
            View.ChitietHoadonItems = Model.Get<ChitietHoadonModel>("sys_ChitietHoadonSelect");
            View.RefreshData();
        }

        public void Add()
        {
            if (View.ChitietHoadonCurrent == null)
                return;
            View.ChitietHoadonItems.Add(new ChitietHoadonModel { Soluong = 1 });
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.ChitietHoadonCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.ChitietHoadonItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void Save()
        {
            Model.Set(View.ChitietHoadonItems);
            View.RefreshData();
        }
    }
}
