using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.View;
using TrainingAccounting.Model.BusinessObject;
using Lambda.BusinessObject;

namespace TrainingAccounting.Presenter
{
    public class BangluongChuyenKhoanPresenter:Presenter<IBangluongChuyenKhoanView>
    {
        public BangluongChuyenKhoanPresenter(IBangluongChuyenKhoanView view) : base(view) { }
        public void LoadData()
        {
            View.ThangItems = Model.Get<ThangModel>("sys_ThangSelect");
            View.NhanvienItems = Model.Get<NhanvienModel>("sys_NhanvienSelect");

        }
        public void GetBangChuyenkhoan()
        {
             var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            View.BangchuyenKhoanItems = Model.Get<BangluongChuyenkhoanModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetBangluongChuyenkhoanByThangNam" });
        }

        public void AddNew()
        {
            if (View.BangchuyenKhoanItems.Where(o => o.NhanvienId == View.PhieubaoLuong.NhanvienId && o.Thang == View.Thang && o.Nam == View.Nam).ToList().Count != 0)
                return;
            String Nganhang = "";
            String Chinhanh = "";
            String Diachi = "";
            float Sotien = 0;
            var item1 = new List<AutoItem>();
            item1.Add(new AutoItem { Name = "NganhangId", Value = View.PhieubaoLuong.NganhangId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            NganhangModel nh = Model.Get<NganhangModel>(new AutoObject { Items = item1, SpName = "TrAcc_Danh_GetNganhangByNganhangId" }).FirstOrDefault();
            if (nh != null)
                Nganhang = nh.TenNganhang;

            var item2 = new List<AutoItem>();
            item2.Add(new AutoItem { Name = "ChinhanhNganhangId", Value = View.PhieubaoLuong.ChinhanhNganhangId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            ChinhanhNganhangModel cn = Model.Get<ChinhanhNganhangModel>(new AutoObject { Items = item2, SpName = "TrAcc_Danh_GetChinhanhNganhangByChinhanhNganhangId" }).FirstOrDefault();
            if (cn != null)
            {
                Chinhanh = cn.TenChinhanh;
                Diachi = cn.Diachi;
            }
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "NhanvienId", Value = View.PhieubaoLuong.NhanvienId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            item.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            item.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            var f = Model.GetAutoObject(new AutoObject { Items = item, SpName = "TrAcc_Danh_SotienLuongNhanvien" });
            if (f != null && f[0].Items[0].Value != null)
                Sotien = float.Parse(f[0].Items[0].Value.ToString());
            View.BangchuyenKhoanItems.Add( new BangluongChuyenkhoanModel
            {
                NhanvienId = View.PhieubaoLuong.NhanvienId,
                ChinhanhNganhang = Chinhanh,
                TenNganhang = Nganhang,
                Diachi = Diachi,
                Nam = View.Nam,
                Thang = View.Thang,
                SoTaikhoan = View.PhieubaoLuong.SoTaikhoan,
                Sotien = Sotien
            });
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.BangchuyenKhoanCurrent;
            if (cur == null)
                return;
            if (cur.State == RowState.Insert)
            {
                View.BangchuyenKhoanItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void Save()
        {
            Model.Set(View.BangchuyenKhoanItems);
            View.RefreshData();
        }

        public void AddNewList()
        {
            foreach (var i in View.PhieubaoLuongItems)
            {
                if (View.BangchuyenKhoanItems.Where(o => o.NhanvienId == i.NhanvienId && o.Thang == View.Thang && o.Nam == View.Nam).ToList().Count != 0)
                    break;
                String Nganhang = "";
                String Chinhanh = "";
                String Diachi = "";
                float Sotien = 0;
                var item1 = new List<AutoItem>();
                item1.Add(new AutoItem { Name = "NganhangId", Value = i.NganhangId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
                NganhangModel nh = Model.Get<NganhangModel>(new AutoObject { Items = item1, SpName = "TrAcc_Danh_GetNganhangByNganhangId" }).FirstOrDefault();
                if (nh != null)
                    Nganhang = nh.TenNganhang;

                var item2 = new List<AutoItem>();
                item2.Add(new AutoItem { Name = "ChinhanhNganhangId", Value = i.ChinhanhNganhangId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
                ChinhanhNganhangModel cn = Model.Get<ChinhanhNganhangModel>(new AutoObject { Items = item2, SpName = "TrAcc_Danh_GetChinhanhNganhangByChinhanhNganhangId" }).FirstOrDefault();
                if (cn != null)
                {
                    Chinhanh = cn.TenChinhanh;
                    Diachi = cn.Diachi;
                }
                var item = new List<AutoItem>();
                item.Add(new AutoItem { Name = "NhanvienId", Value = i.NhanvienId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
                item.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
                item.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
                var f = Model.GetAutoObject(new AutoObject { Items = item, SpName = "TrAcc_Danh_SotienLuongNhanvien" });
                if (f != null && f[0].Items[0].Value != null)
                    Sotien = float.Parse(f[0].Items[0].Value.ToString());
                View.BangchuyenKhoanItems.Add(new BangluongChuyenkhoanModel
                {
                    NhanvienId = i.NhanvienId,
                    ChinhanhNganhang = Chinhanh,
                    TenNganhang = Nganhang,
                    Diachi = Diachi,
                    Nam = View.Nam,
                    Thang = View.Thang,
                    SoTaikhoan = i.SoTaikhoan,
                    Sotien = Sotien
                });
            }
            View.RefreshData();
        }
    }
}
