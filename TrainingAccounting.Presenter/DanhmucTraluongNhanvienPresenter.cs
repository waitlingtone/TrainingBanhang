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
    public class DanhmucTraluongNhanvienPresenter:Presenter<IDanhmucTraluongNhanvienView>
    {
        public DanhmucTraluongNhanvienPresenter(IDanhmucTraluongNhanvienView view) : base(view) { }
        public void LoadData()
        {
            View.DanhmucTraluongItems = Model.Get<DanhmucTraluongNhanvienModel>("sys_DanhmucTraluongNhanvienSelect");
        }
        public void Add()
        {
            View.DanhmucTraluongItems.Add(new DanhmucTraluongNhanvienModel());
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.DanhmucTraluongCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.DanhmucTraluongItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void Save()
        {
            Model.Set(View.DanhmucTraluongItems);
            View.RefreshData();
        }
    }
}
