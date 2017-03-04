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
    public class PhieubaoLuongNhanvienPresenter:Presenter<IPhieubaoLuongNhanvienView>
    {
        public PhieubaoLuongNhanvienPresenter(IPhieubaoLuongNhanvienView view) : base(view) { }
        public void LoadData()
        {
            View.ThangItems = Model.Get<ThangModel>("sys_ThangSelect");
            View.DanhmucTraluongItems = Model.Get<DanhmucTraluongNhanvienModel>("sys_DanhmucTraluongNhanvienSelect");
        }
        public void GetNhanvien()
        {
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            item.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            View.PhieubaoLuongItems = Model.Get<PhieubaoLuongNhanvienModel>(new AutoObject { Items = item, SpName = "TrAcc_Danh_GetPhieubaoLuongByThangNam" });
        }

        public void GetPhieubaoLuong()
        {
            if (View.PhieubaoLuongCurrent == null)
            {
                View.ChitietPhieubaoLuongItems = new List<ChitietPhieubaoLuongNhanvienModel>();
                View.RefreshData();
                return;
            }
            var item2 = new List<AutoItem>();
            item2.Add(new AutoItem { Name = "PhieubaoLuongNhanvienId", Value = View.PhieubaoLuongCurrent.PhieubaoLuongNhanvienId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.ChitietPhieubaoLuongItems = Model.Get<ChitietPhieubaoLuongNhanvienModel>(new AutoObject { Items = item2, SpName = "TrAcc_Danh_GetChitietPhieubaoLuongNhanvien" });
            KiemtraThanhtoan();
            View.RefreshData();
        }

        private void KiemtraThanhtoan()
        {
            if (View.PhieubaoLuongCurrent.DaThanhtoan == false || View.PhieubaoLuongCurrent.DaThanhtoan == null)
            {
                View.DaThanhtoan = false;
                View.Msg = "Chưa thanh toán";
            }
            else
            {
                View.DaThanhtoan = true;
                View.Msg = "Đã thanh toán ngày " + View.PhieubaoLuongCurrent.NgayThanhtoan.ToString();
            }
        }

        public void AddDanhmuc()
        {
            if (View.PhieubaoLuongCurrent == null)
                return;
            foreach (var i in View.DanhmucLuongSelectedItems)
            {
                if(View.ChitietPhieubaoLuongItems.Where(o=>o.Ma == i.Ma).ToList().Count == 0)
                    View.ChitietPhieubaoLuongItems.Add(new ChitietPhieubaoLuongNhanvienModel { Ma = i.Ma, DanhmucTraluongNhanvien = i.Ten, PhieubaoLuongNhanvienId = View.PhieubaoLuongCurrent.PhieubaoLuongNhanvienId });
            }
            View.RefreshData();
        }

        public void DeleteDanhmuc()
        {
            var cur = View.ChitietPhieubaoLuongCurrent;
            if (cur == null)
                return;
            if (cur.State == RowState.Insert)
            {
                View.ChitietPhieubaoLuongItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void SaveDanhmuc()
        {
            if (View.PhieubaoLuongCurrent == null)
                return;
            Model.Set(View.ChitietPhieubaoLuongItems);
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "NhanvienId", Value = View.PhieubaoLuongCurrent.NhanvienId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            item.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            item.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            Model.SetAutoObject(new AutoObject { Items = item, SpName = "TrAcc_Danh_UpdateLuongNhanvien" });
            View.RefreshData();
        }

        public void TinhLuong()
        {
            if (View.PhieubaoLuongCurrent == null)
            {
                View.PhieubaoLuong = new List<PhieubaoLuong>();
                View.RefreshData();
                return;
            }
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "NhanvienId", Value = View.PhieubaoLuongCurrent.NhanvienId2, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            item.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            item.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            View.PhieubaoLuong = Model.Get<PhieubaoLuong>(new AutoObject { Items = item, SpName = "TrAcc_Danh_GetPhieutinhluongNhanvien" });
            View.RefreshData();
        }

        public void Thanhtoan()
        {
            if (View.PhieubaoLuongCurrent == null)
                return;
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "NhanvienId", Value = View.PhieubaoLuongCurrent.NhanvienId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            item.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            item.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            item.Add(new AutoItem { Name = "DaumucThuchiId", Value = View.DaumucThuchi.DaumucThuchiId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            item.Add(new AutoItem { Name = "TenDaumuc", Value = View.DaumucThuchi.TenDaumuc, SqlType = System.Data.SqlDbType.NVarChar });

            Model.SetAutoObject(new AutoObject { Items = item, SpName = "TrAcc_Danh_ThanhtoanLuongNhanvien" });
        }

        public void TinhAllLuong()
        {
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            item.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            Model.SetAutoObject(new AutoObject { Items = item, SpName = "TrAcc_Danh_AddTinhAllLuongNhanvienByThangNam" });
        
        }
    }
}
