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
    public class HesoNgaytinhluongPresenter:Presenter<IHesoNgaytinhluongView>
    {
        public HesoNgaytinhluongPresenter(IHesoNgaytinhluongView view) : base(view) {}
        public void LoadData()
        {
            View.HesoTinhluongItems = Model.Get<HesoTinhluongModel>("sys_HesoTinhluongSelect");
        }
        public void Add()
        {
            View.HesoTinhluongItems.Add(new HesoTinhluongModel());
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.HesoTinhluongCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.HesoTinhluongItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void Save()
        {
            Model.Set(View.HesoTinhluongItems);
            View.RefreshData();
        }

        public void CheckedChange()
        {
            foreach (var i in View.HesoTinhluongItems)
                i.Sudung = false;
            View.HesoTinhluongCurrent.Sudung = true;
            View.RefreshData();
        }
    }
}
