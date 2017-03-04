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
    public class DiemdanhTrongngayPresenter:Presenter<IDiemdanhTrongngayView>
    {
        public DiemdanhTrongngayPresenter(IDiemdanhTrongngayView view) : base(view) { }
        public void GetLichDangky()
        {
            //var item = new List<AutoItem>();
            //item.Add(new AutoItem { Name = "dateTime", Value = View.dateTime, SqlType = System.Data.SqlDbType.DateTime });
            //View.LichhocDayhocItems = Model.Get<LichhocDayhocModel>(new AutoObject { Items = item, SpName = "TrAcc_Danh_GetLichhocDayhocForDiemdanhByNgay" });
            //View.RefreshData();
        }

        public void Save()
        {
            Model.Set(View.LichhocDayhocItems);
            View.RefreshData();
        }

        public void LoadData()
        {
            View.ThangItems = Model.Get<ThangModel>("sys_ThangSelect");
        }
    }
}
