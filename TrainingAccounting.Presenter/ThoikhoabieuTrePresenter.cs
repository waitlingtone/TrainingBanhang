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
    public class ThoikhoabieuTrePresenter:Presenter<IThoikhoabieuTreView>
    {
        public ThoikhoabieuTrePresenter(IThoikhoabieuTreView view) : base(view) { }
        public void LoadData()
        {
            View.ThangItems = Model.Get<ThangModel>("sys_ThangSelect");
            List<NhomTreModel> tmp = Model.Get<NhomTreModel>("sys_NhomTreSelect");
            tmp.Insert(0, new NhomTreModel { TenNhom = "[Tất cả]" });
            View.NhomtreItems = tmp;
        }
        public void GetTreByNhomtre()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Conhoc", Value = true, SqlType = System.Data.SqlDbType.Bit });
            items.Add(new AutoItem { Name = "NhomtreId", Value = View.NhomtreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            View.TreItems = Model.Get<TreModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetTreByConhocNhomtreIdThangNam" });
            View.RefreshData();
        }
        public void GetAllTre()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Conhoc", Value = true, SqlType = System.Data.SqlDbType.Bit });
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            View.TreItems = Model.Get<TreModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetTreByConhocThangNam" });
            View.RefreshData();
        }


        public void GetLichhocByTre()
        {
            if (View.TreCurrent == null)
                return;
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.TreCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            View.LichhocDayhocItems = Model.Get<LichhocDayhocModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetLichhocDayhocByTreId" });
            View.RefreshData();
        }

        public void UpdateLich()
        {
            if (View.TreCurrent == null)
                return;
            if (View.PhieubaoHocphi == null)
                return;

            float Dongia = 0;
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.TreCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            var rs = Model.GetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetDongiaHocphiNyTreId" }).FirstOrDefault();
            if (rs != null && rs.Items[0].Value != null)
                Dongia = float.Parse(rs.Items[0].Value.ToString());

            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            Model.SetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_DeleteAllLichhocDayhocByTreId" });

            List<DangkyLichhocModel> _lichhoc = Model.Get<DangkyLichhocModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetAllDangkyLichhocByTreId" });
            View.LichhocDayhocItems = new List<LichhocDayhocModel>();
            for (var day = View.StartTime.Date; day.Date <= View.EndTime.Date; day = day.AddDays(1))
            {
                DayOfWeek dow = day.DayOfWeek;
                int _thu = (int)day.DayOfWeek + 1;
   
                foreach (var i in _lichhoc)
                {
                    TimeSpan timeStart = TimeSpan.Parse(i.GioBatdau);
                    TimeSpan timeEnd = TimeSpan.Parse(i.GioKetthuc);
                    if (_thu == i.Thu)
                        View.LichhocDayhocItems.Add(new LichhocDayhocModel
                        {
                            DangkyHoc = true,
                            PhieubaoHocphiId = View.PhieubaoHocphi.PhieubaoHocphiId,
                            GioBatdau = new DateTime(day.Year, day.Month, day.Day, timeStart.Hours, timeStart.Minutes, timeStart.Seconds),
                            GioKetthuc = new DateTime(day.Year, day.Month, day.Day, timeEnd.Hours, timeEnd.Minutes, timeEnd.Seconds),
                            DiemdanhTre = false,
                            VangHople = false,
                            DaTinhtien = false,
                            DiemdanhNhanvien = false,
                            Dongia = Dongia
                        });
                }
            }


            this.Transaction.Add(View.PhieubaoHocphi);
            this.Transaction.Add(View.LichhocDayhocItems);
            Model.SetTransaction(this.Transaction);
            View.RefreshData();
        }

        public void LaplichNew()
        {
            if (View.TreCurrent == null)
                return;

            float Dongia = 0;
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.TreCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            var rs = Model.GetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetDongiaHocphiNyTreId" }).FirstOrDefault();
            if (rs != null && rs.Items[0].Value != null)
                Dongia = float.Parse(rs.Items[0].Value.ToString());

            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            Model.SetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_DeleteAllLichhocDayhocByTreId" });
            List<DangkyLichhocModel> _lichhoc = Model.Get<DangkyLichhocModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetAllDangkyLichhocByTreId" });

            View.PhieubaoHocphi = new PhieubaoHocphiModel { TreId = View.TreCurrent.TreId, Thang = View.Thang, Nam = View.Nam };
            View.LichhocDayhocItems = new List<LichhocDayhocModel>();
            for (var day = View.StartTime.Date; day.Date <= View.EndTime.Date; day = day.AddDays(1))
            {
                DayOfWeek dow = day.DayOfWeek;
                int _thu = (int)day.DayOfWeek + 1;
                foreach (var i in _lichhoc)
                {
                    TimeSpan timeStart = TimeSpan.Parse(i.GioBatdau);
                    TimeSpan timeEnd = TimeSpan.Parse(i.GioKetthuc);
                    if (_thu == i.Thu)
                        View.LichhocDayhocItems.Add(new LichhocDayhocModel
                        {
                            DangkyHoc = true,
                            PhieubaoHocphiId = View.PhieubaoHocphi.PhieubaoHocphiId,
                            GioBatdau = new DateTime(day.Year, day.Month, day.Day, timeStart.Hours, timeStart.Minutes, timeStart.Seconds),
                            GioKetthuc = new DateTime(day.Year, day.Month, day.Day, timeEnd.Hours, timeEnd.Minutes, timeEnd.Seconds),
                            DiemdanhTre = false,
                            VangHople = false,
                            DaTinhtien = false,
                            DiemdanhNhanvien = false,
                            Dongia = Dongia
                        });
                }
            }

            this.Transaction.Add(View.PhieubaoHocphi);
            this.Transaction.Add(View.LichhocDayhocItems);
            Model.SetTransaction(this.Transaction);
            View.RefreshData();
        }
        public bool KiemtraTontaiPhieubaoHocphi()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.TreCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            View.PhieubaoHocphi = Model.Get<PhieubaoHocphiModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_KiemtraTontaiPhieubaoHocphiByTreId" }).FirstOrDefault();
            if (View.PhieubaoHocphi == null)
                return false;
            else
                return true;
        }

        public void DeleteBuoihoc()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "LichhocDayhocId", Value = View.BuoihocDeleted, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            Model.SetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_DeleteBuoihocByLichhocDayhocId" });
        }

        public bool DaDongtien()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "LichhocDayhocId", Value = View.BuoihocDeleted, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            var re = Model.Get<LichhocDayhocModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetLichDatinhtienByLichhocDayhocId" }).FirstOrDefault();
            if (re == null)
                return false;
            return true;
        }

        public bool KiemtraDadongHocphi()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.TreCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            LichhocDayhocModel lh = Model.Get<LichhocDayhocModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_KiemtraDakhoaHocphiByTreThangNam" }).FirstOrDefault();
            if (lh == null)
                return false;
            else
                return true;
        }

        public bool TontaiNghihoc()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.TreCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            items.Add(new AutoItem { Name = "Tungay", Value = View.StartTime, SqlType = System.Data.SqlDbType.DateTime });
            items.Add(new AutoItem { Name = "Denngay", Value = View.EndTime, SqlType = System.Data.SqlDbType.DateTime });
            LichsuHocModel ls = Model.Get<LichsuHocModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_KiemtraNghihocByTre" }).FirstOrDefault();
            if (ls != null)
                return true;
            return false;
        }

        public bool TontaiDangkyLich()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.TreCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            DangkyLichhocModel lh = Model.Get<DangkyLichhocModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetDangkyLichhocByTreId" }).FirstOrDefault();
            if (lh != null)
                return true;
            return false;
        }
    }
}
