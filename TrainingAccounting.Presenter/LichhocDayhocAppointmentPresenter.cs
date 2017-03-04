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
    public class LichhocDayhocAppointmentPresenter:Presenter<ILichhocDayhocAppointmentView>
    {
        public LichhocDayhocAppointmentPresenter(ILichhocDayhocAppointmentView view) : base(view) { }

        public void LoadData()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "StartTime", Value = View.StartTine, SqlType = System.Data.SqlDbType.DateTime });
            items.Add(new AutoItem { Name = "EndTime", Value = View.EndTine, SqlType = System.Data.SqlDbType.DateTime });
            items.Add(new AutoItem { Name = "NhanvienId", Value = View.NhanvienId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.NhanvienItems = Model.Get<NhanvienModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetNhanvienCotheDayByGiohoc" });

            foreach(var i in View.NhanvienItems)
                if (i.NhanvienId == View.NhanvienId)
                {
                    i.Selected = true;
                    break;
                }
            var item2 = new List<AutoItem>();
            item2.Add(new AutoItem { Name = "LichhocDayhocId", Value = View.LichhocDayhocId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            LichhocDayhocModel lh = Model.Get<LichhocDayhocModel>(new AutoObject { Items = item2, SpName = "TrAcc_Danh_GetLichhocDayhocByLichhocDayhocId" }).FirstOrDefault();
            if (lh != null && lh.IsCaghep != null)
                View.isCaghep = lh.IsCaghep.Value;
            View.RefreshData();
        }
        public void GetNhanvien()
        {
            if (View.NhanvienId == null)
                return;
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "NhanvienId", Value = View.NhanvienId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.Nhanvien = Model.Get<NhanvienModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetNhanvienByNhanvienId" }).FirstOrDefault();
        }
        public void Check()
        {
            foreach (var i in View.NhanvienItems)
                if (i.Selected)
                    i.Selected = false;
            View.NhanvienCurrent.Selected = true;
            View.RefreshData();
        }

        public void SavePhanGiaovien()
        {
            bool check = false;
            foreach (var i in View.NhanvienItems)
                if (i.Selected)
                {
                    var items = new List<AutoItem>();
                    items.Add(new AutoItem { Name = "LichhocDayhocId", Value = View.LichhocDayhocId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
                    items.Add(new AutoItem { Name = "NhanvienId", Value = View.NhanvienCurrent.NhanvienId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
                    items.Add(new AutoItem { Name = "Laplai", Value = View.Laplai, SqlType = System.Data.SqlDbType.Bit });
                    items.Add(new AutoItem { Name = "IsCaghep", Value = View.isCaghep, SqlType = System.Data.SqlDbType.Bit });
                    Model.SetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_UpdateNhanvienThoikhoabieuTre" });
                    View.Nhanvien = i;
                    check = true;
                }
            if (!check)
            {
                var items = new List<AutoItem>();
                items.Add(new AutoItem { Name = "LichhocDayhocId", Value = View.LichhocDayhocId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
                items.Add(new AutoItem { Name = "Laplai", Value = View.Laplai, SqlType = System.Data.SqlDbType.Bit });
                Model.SetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_UpdateNullNhanvienThoikhoabieuTre" });
            }
            
        }

        public void GetOrderGiaovien()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "StartTime", Value = View.StartTine, SqlType = System.Data.SqlDbType.DateTime });
            items.Add(new AutoItem { Name = "EndTime", Value = View.EndTine, SqlType = System.Data.SqlDbType.DateTime });
            items.Add(new AutoItem { Name = "NhanvienId", Value = View.NhanvienId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.NhanvienItems = Model.Get<NhanvienModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetOrderNhanvienCotheDayByGiohoc" });
            foreach (var i in View.NhanvienItems)
                if (i.NhanvienId == View.NhanvienId)
                {
                    i.Selected = true;
                    break;
                }
            View.RefreshData();
        }

        public List<LichhocDayhocModel> GetTreCungCahoc()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "LichhocDayhocId", Value = View.LichhocDayhocId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            items.Add(new AutoItem { Name = "StartTime", Value = View.StartTine, SqlType = System.Data.SqlDbType.DateTime });
            items.Add(new AutoItem { Name = "EndTime", Value = View.EndTine, SqlType = System.Data.SqlDbType.DateTime });
            items.Add(new AutoItem { Name = "NhanvienId", Value = View.NhanvienCurrent.NhanvienId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            return Model.Get<LichhocDayhocModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetTreCaghep" });
        }
        public void UpdateGhichu()
        {
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "LichhocDayhocId", Value = View.LichhocDayhocId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            item.Add(new AutoItem { Name = "Ghichu", Value = View.Ghichu, SqlType = System.Data.SqlDbType.NVarChar });
            this.Transaction.Add(new AutoObject { Items = item, SpName = "TrAcc_Danh_DeleteLichhocNoidungByLichhocDayhocId" });
            //Model.SetAutoObject(new AutoObject { Items = item, SpName = "TrAcc_Danh_UpdateGhichuThoikhoabieuTre" });
            this.Transaction.Add(new AutoObject { Items = item, SpName = "TrAcc_Danh_UpdateGhichuThoikhoabieuTre" });
            List<LichhocNoidungModel> lichhocNoidung = new List<LichhocNoidungModel>();
            if (View.NDGiangdaySelected != null)
            {
                foreach (var i in View.NDGiangdaySelected)
                    lichhocNoidung.Add(new LichhocNoidungModel { LichhocDayhocId = View.LichhocDayhocId, NDGiangdayId = i.NDGiangdayId, Noidung = i.Noidung });
            }
            this.Transaction.Add(lichhocNoidung);
            Model.SetTransaction(this.Transaction);
        }
    }
}
