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
    public class DaumucThuchiPresenter:Presenter<IDanhmucThuchiView>
    {
        public DaumucThuchiPresenter(IDanhmucThuchiView view) : base(view) { }
        public void LoadData()
        {
            View.DaumucThuchiItems = Model.Get<DaumucThuchiModel>("sys_DaumucThuchiSelect");
        }
        public void Add()
        {
            View.DaumucThuchiItems.Add(new DaumucThuchiModel());
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.DaumucThuchiCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.DaumucThuchiItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void Save()
        {
            Model.Set(View.DaumucThuchiItems);
            View.RefreshData();
        }
    }
}
