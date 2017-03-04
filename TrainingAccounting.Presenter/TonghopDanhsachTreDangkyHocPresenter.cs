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
    public class TonghopDanhsachTreDangkyHocPresenter:Presenter<ITonghopDanhsachTreDangkyHocView>
    {
        public TonghopDanhsachTreDangkyHocPresenter(ITonghopDanhsachTreDangkyHocView view) : base(view) { }
        public void LoadData()
        {
            View.ThangItems = Model.Get<ThangModel>("sys_ThangSelect");
        }

        public void TaiDanhsach()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "StartDate", Value = View.StartDate, SqlType = System.Data.SqlDbType.DateTime });
            items.Add(new AutoItem { Name = "EndDate", Value = View.EndDate.AddDays(1), SqlType = System.Data.SqlDbType.DateTime });
            View.LichhocDayhocItems = Model.Get<LichhocDayhocModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetTonghopLichhocDayhocByDate" });
            View.RefreshData();
        }
    }
}
