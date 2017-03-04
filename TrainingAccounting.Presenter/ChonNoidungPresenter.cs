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
    public class ChonNoidungPresenter:Presenter<IChonNoidungView>
    {
        public ChonNoidungPresenter(IChonNoidungView view) : base(view) { }
        public void LoadData()
        {
            View.NDGiangdayItems = Model.Get<NDGiangdayModel>("sys_NDGiangdaySelect");
            if (View.LichhocDayhocId == null)
                return;
            var item = new List<AutoItem>();
            item.Add(new AutoItem{Name = "LichhocDayhocId", Value = View.LichhocDayhocId, SqlType = System.Data.SqlDbType.UniqueIdentifier});
            List<LichhocNoidungModel> lichhocNoidungItems = Model.Get<LichhocNoidungModel>(new AutoObject { Items = item, SpName = "TrAcc_Danh_GetNoidungByLichhocDayhocId" });
            foreach (var i in View.NDGiangdayItems)
                foreach (var j in lichhocNoidungItems)
                    if (i.NDGiangdayId == j.NDGiangdayId)
                        i.Selected = true;
        }
    }
}
