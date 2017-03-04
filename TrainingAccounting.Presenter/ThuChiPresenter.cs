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
    public class ThuChiPresenter:Presenter<IThuChiView>
    {
        public ThuChiPresenter(IThuChiView view) : base(view) { }
        public void LoadData()
        {
            List<DaumucThuchiModel> tmp = Model.Get<DaumucThuchiModel>("sys_DaumucThuchiSelect");
            tmp.Insert(0, new DaumucThuchiModel{TenDaumuc = "[Thu chi khác]"});
            View.DaumucThuchiItems = tmp;
            View.ThuchiItem = new List<ThuchiModel>();
            View.ThuchiItem.Add(new ThuchiModel { IsThu = true, NgayThanhtoan = DateTime.Now, SoTien = 0 });
        }

        public void SaveThuchi()
        {
            View.ThuchiItem[0].IsThu = View.isThu;
            Model.Set(View.ThuchiItem);
            View.RefreshData();
        }
    }
}
