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
    public class NhanvienPresenter:Presenter<INhanvienView>
    {
        public NhanvienPresenter(INhanvienView view) : base(view) { }
        public void LoadData()
        {
            LoadNhanvien();
            View.NganhangItems = Model.Get<NganhangModel>("sys_NganhangSelect");
            View.RefreshData();
        }
        public void LoadNhanvien()
        {
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "ConHoatdong", Value = View.ConHoatdong, SqlType = System.Data.SqlDbType.Bit });
            View.NhanvienItems = Model.Get<NhanvienModel>(new AutoObject { Items = item, SpName = "TrAcc_Danh_GetNhanvien" });
        }
        public void Add()
        {
            View.NhanvienItems.Add(new NhanvienModel());
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.NhanvienCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.NhanvienItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void Save()
        {
            Model.Set(View.NhanvienItems);
            View.RefreshData();
        }

        public void AddLuong()
        {
            if (View.NhanvienCurrent == null)
                return;
            View.LuongNhanvienItems.Add(new LuongNhanvienModel { NhanvienId = View.NhanvienCurrent.NhanvienId, NgayApdung = DateTime.Now });
            View.RefreshData();
        }

        public void DeleteLuong()
        {
            var cur = View.LuongNhanvienCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.LuongNhanvienItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void SaveLuong()
        {
            Model.Set(View.LuongNhanvienItems);
            View.RefreshData();
        }

        public void GetLuongByNhanvien()
        {
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "NhanvienId", Value = View.NhanvienCurrent.NhanvienId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.LuongNhanvienItems = Model.Get<LuongNhanvienModel>(new AutoObject { Items = item, SpName = "TrAcc_Danh_GetLuongByNhanvienId" });
            View.RefreshData();
        }

        public void CheckUnCheck()
        {
            //foreach (var i in View.LuongNhanvienItems)
            //    i.DangSudung = false;
            //View.LuongNhanvienCurrent.DangSudung = true;
            //View.RefreshData();
        }

        public void GetChinhanh()
        {
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "NganhangId", Value = View.NganhangId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.ChinhanhNganhangItems = Model.Get<ChinhanhNganhangModel>(new AutoObject { Items = item, SpName = "TrAcc_Danh_GetChinhanhNganhangByNganhangId" });
        }
    }
}
