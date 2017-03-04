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
    public class HanghoaPresenter : Presenter<IHanghoaView>
    {
        public HanghoaPresenter(IHanghoaView view) : base(view) { }
        public void LoadData()
        {
            View.HanghoaItems = Model.Get<HanghoaModel>("sys_HanghoaSelect");
            View.RefreshData();
        }

        public void AddHanghoa()
        {
            View.HanghoaItems.Add(new HanghoaModel());
            View.RefreshData();
        }

        public void DeleteHanghoa()
        {
            var cur = View.HanghoaCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.HanghoaItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void SaveHanghoa()
        {
            Model.Set(View.HanghoaItems);
            View.RefreshData();
        }
    }
}
