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
    public class DangkyLichdayPresenter:Presenter<IDangkyLichdayView>
    {
        public DangkyLichdayPresenter(IDangkyLichdayView view) : base(view) { }
        public void LoadData()
        {
            View.NhanvienItems = Model.Get<NhanvienModel>("sys_NhanvienSelect");
            View.ThuItems = Model.Get<ThuModel>("sys_ThuSelect");
        }

        public void GetLichDangky()
        {
            if (View.NhanvienCurrent == null)
                return;
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "NhanvienId", Value = View.NhanvienCurrent.NhanvienId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.NgayhocTrongtuanItems = Model.Get<BangNgayhocTrongtuan>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetBangdangkyLichdayByNhanvienId" });
            View.CakhacItems = Model.Get<DangkyLichdayModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetDangkyLichdayCakhacByNhanvienId" });
            View.RefreshData();
        }

        public void SaveDangky()
        {
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "NhanvienId", Value = View.NhanvienCurrent.NhanvienId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            Model.SetAutoObject(new AutoObject { Items = item, SpName = "TrAcc_Danh_DeleteAllDangkyLichdayByNhanvienId" });
            List<DangkyLichdayModel> dkLichhocItems = new List<DangkyLichdayModel>();
            foreach (var i in View.NgayhocTrongtuanItems)
            {
                if (i.Thu2)
                    dkLichhocItems.Add(new DangkyLichdayModel { CahocId = i.CahocId, NhanvienId = View.NhanvienCurrent.NhanvienId, Thu = 2, GioBatdau = i.GioBatdau, GioKetthuc = i.GioKetthuc });
                if (i.Thu3)
                    dkLichhocItems.Add(new DangkyLichdayModel { CahocId = i.CahocId, NhanvienId = View.NhanvienCurrent.NhanvienId, Thu = 3, GioBatdau = i.GioBatdau, GioKetthuc = i.GioKetthuc });
                if (i.Thu4)
                    dkLichhocItems.Add(new DangkyLichdayModel { CahocId = i.CahocId, NhanvienId = View.NhanvienCurrent.NhanvienId, Thu = 4, GioBatdau = i.GioBatdau, GioKetthuc = i.GioKetthuc });
                if (i.Thu5)
                    dkLichhocItems.Add(new DangkyLichdayModel { CahocId = i.CahocId, NhanvienId = View.NhanvienCurrent.NhanvienId, Thu = 5, GioBatdau = i.GioBatdau, GioKetthuc = i.GioKetthuc });
                if (i.Thu6)
                    dkLichhocItems.Add(new DangkyLichdayModel { CahocId = i.CahocId, NhanvienId = View.NhanvienCurrent.NhanvienId, Thu = 6, GioBatdau = i.GioBatdau, GioKetthuc = i.GioKetthuc });
                if (i.Thu7)
                    dkLichhocItems.Add(new DangkyLichdayModel { CahocId = i.CahocId, NhanvienId = View.NhanvienCurrent.NhanvienId, Thu = 7, GioBatdau = i.GioBatdau, GioKetthuc = i.GioKetthuc });
                if (i.Thu8)
                    dkLichhocItems.Add(new DangkyLichdayModel { CahocId = i.CahocId, NhanvienId = View.NhanvienCurrent.NhanvienId, Thu = 1, GioBatdau = i.GioBatdau, GioKetthuc = i.GioKetthuc });
            }
            Model.Set(dkLichhocItems);
            Model.Set(View.CakhacItems);
        }

        public void AddCakhac()
        {
            if (View.NhanvienCurrent == null)
                return;
            View.CakhacItems.Add(new DangkyLichdayModel { NhanvienId = View.NhanvienCurrent.NhanvienId });
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
