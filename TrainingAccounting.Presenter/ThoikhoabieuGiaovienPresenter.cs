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
    public class ThoikhoabieuGiaovienPresenter:Presenter<IThoikhoabieuGiaovienView>
    {
        public ThoikhoabieuGiaovienPresenter(IThoikhoabieuGiaovienView view) : base(view) { }
        public void LoadData()
        {
            View.ThangItems = Model.Get<ThangModel>("sys_ThangSelect");
        }
        public void GetNhanvien()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            View.NhanvienItems = Model.Get<NhanvienModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetNhanvienIsGiaovienConday" });
        }

        public void GetLichday()
        {
            if (View.NhanvienCurrent == null)
                return;
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "NhanvienId", Value = View.NhanvienCurrent.NhanvienId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            View.LichhocDayhocItems = Model.Get<LichhocDayhocModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetThoikhoabieuNhanvienV2" });
            View.RefreshData();
        }
    }
}
