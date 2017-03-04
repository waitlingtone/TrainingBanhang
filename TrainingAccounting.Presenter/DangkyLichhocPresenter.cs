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
    public class DangkyLichhocPresenter:Presenter<IDangkyLichhocView>
    {
        public DangkyLichhocPresenter(IDangkyLichhocView view) : base(view) { }


        public void LoadData()
        {
            List<NhomTreModel> tmp = Model.Get<NhomTreModel>("sys_NhomTreSelect");
            tmp.Insert(0, new NhomTreModel { TenNhom = "[Tất cả]" });
            View.NhomtreItems = tmp;
            View.ThuItems = Model.Get<ThuModel>("sys_ThuSelect");
        }
        public void GetTreByNhomtre()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Conhoc", Value = true, SqlType = System.Data.SqlDbType.Bit });
            items.Add(new AutoItem { Name = "NhomtreId", Value = View.NhomtreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.TreItems = Model.Get<TreModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetTreByConhocNhomtreId" });
            View.RefreshData();
        }
        public void GetAllTre()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Conhoc", Value = true, SqlType = System.Data.SqlDbType.Bit });
            View.TreItems = Model.Get<TreModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetTreByConhoc" });
            View.RefreshData();
        }


        public void GetLichDangky()
        {
            if (View.TreCurrent == null)
                return;
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.TreCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.NgayhocTrongtuanItems = Model.Get<BangNgayhocTrongtuan>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetBangdangkyLichhocByTreId" });

            View.CakhacItems = Model.Get<DangkyLichhocModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetDangkyLichhocCakhacByTreId" });
            View.RefreshData();
        }

        public void SaveDangky()
        {
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "TreId", Value = View.TreCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            Model.SetAutoObject(new AutoObject { Items = item, SpName = "TrAcc_Danh_DeleteAllDangkyLichhocByTreId" });
            List<DangkyLichhocModel> dkLichhocItems = new List<DangkyLichhocModel>();
            foreach (var i in View.NgayhocTrongtuanItems)
            {
                if (i.Thu2)
                    dkLichhocItems.Add(new DangkyLichhocModel { CahocId = i.CahocId, TreId = View.TreCurrent.TreId, Thu = 2, GioBatdau = i.GioBatdau, GioKetthuc = i.GioKetthuc });
                if (i.Thu3)
                    dkLichhocItems.Add(new DangkyLichhocModel { CahocId = i.CahocId, TreId = View.TreCurrent.TreId, Thu = 3, GioBatdau = i.GioBatdau, GioKetthuc = i.GioKetthuc });
                if (i.Thu4)
                    dkLichhocItems.Add(new DangkyLichhocModel { CahocId = i.CahocId, TreId = View.TreCurrent.TreId, Thu = 4, GioBatdau = i.GioBatdau, GioKetthuc = i.GioKetthuc });
                if (i.Thu5)
                    dkLichhocItems.Add(new DangkyLichhocModel { CahocId = i.CahocId, TreId = View.TreCurrent.TreId, Thu = 5, GioBatdau = i.GioBatdau, GioKetthuc = i.GioKetthuc });
                if (i.Thu6)
                    dkLichhocItems.Add(new DangkyLichhocModel { CahocId = i.CahocId, TreId = View.TreCurrent.TreId, Thu = 6, GioBatdau = i.GioBatdau, GioKetthuc = i.GioKetthuc });
                if (i.Thu7)
                    dkLichhocItems.Add(new DangkyLichhocModel { CahocId = i.CahocId, TreId = View.TreCurrent.TreId, Thu = 7, GioBatdau = i.GioBatdau, GioKetthuc = i.GioKetthuc });
                if (i.Thu8)
                    dkLichhocItems.Add(new DangkyLichhocModel { CahocId = i.CahocId, TreId = View.TreCurrent.TreId, Thu = 1, GioBatdau = i.GioBatdau, GioKetthuc = i.GioKetthuc });
            }
            Model.Set(dkLichhocItems);
            Model.Set(View.CakhacItems);
            View.RefreshData();
        }

        public void AddCakhac()
        {
            if (View.TreCurrent == null)
                return;
            View.CakhacItems.Add(new DangkyLichhocModel { TreId = View.TreCurrent.TreId });
            View.RefreshData();
        }

        public void DeleteCakhac()
        {
            var cur = View.CakhacCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.CakhacItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }
    }
}
