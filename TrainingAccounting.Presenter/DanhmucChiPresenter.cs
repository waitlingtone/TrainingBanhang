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
    public class DanhmucChiPresenter:Presenter<IDanhmucChiView>
    {
        public DanhmucChiPresenter(IDanhmucChiView view) : base(view) { }
        public void LoadData()
        {
            View.DanhmucChiItems = Model.Get<DaumucThuchiModel>("TrAcc_Danh_GetDaumucChi");
        }
    }
}
