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
    public class PhieuThuSachPresenter:Presenter<IPhieuThuSachView>
    {
        public PhieuThuSachPresenter(IPhieuThuSachView view) : base(view) { }


        public void LoadData()
        {
            View.PhieuThuSachItems = Model.Get<PhieuXuatThuSachModel>("TraAcc_Danh_GetPhieuThuSach");
            View.SachItems = Model.Get<SachModel>("TrAcc_GetSachWithGiasach");
        }
        public void LoadChitiet()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "PhieuXuatThuSachId", Value = View.PhieuThuSachCurrent.PhieuXuatThuSachId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.ChitietItems = Model.Get<ChitietPhieuXuatThuSachModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetChitietPhieuxuatByPhieuxuatId" });
            View.RefreshData();
        }

        public void AddPhieu()
        {
            View.PhieuThuSachItems.Add(new PhieuXuatThuSachModel { IsXuat = false, Ngay = DateTime.Now, Tongtien= 0, Trangthai = false });
            View.RefreshData();
        }

        public void DeletePhieu()
        {
            var cur = View.PhieuThuSachCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.PhieuThuSachItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void SavePhieu()
        {
            Model.Set(View.PhieuThuSachItems);
            View.RefreshData();
        }
        public void AddChitietSach()
        {
            if (View.PhieuThuSachCurrent == null)
                return;
            View.ChitietItems.Add(new ChitietPhieuXuatThuSachModel { PhieuXuatThuSachId = View.PhieuThuSachCurrent.PhieuXuatThuSachId, STT = View.ChitietItems.Count + 1 });
            View.RefreshData();
        }

        public void DeleteChitietSach()
        {
            var cur = View.ChitietCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.ChitietItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void SaveChitietSach()
        {
            Model.Set(View.PhieuThuSachItems);
            Model.Set(View.ChitietItems);
            View.RefreshData();
        }

        public void UpdateTien()
        {
            Model.Set(View.ChitietItems);
            double tong = 0;
            foreach (var i in View.ChitietItems)
                tong += i.Thanhtien.Value;
            View.PhieuThuSachCurrent.Tongtien = tong;
            Model.Set(View.PhieuThuSachCurrent);
        }

        public void Chotphieu()
        {
            if (View.PhieuThuSachCurrent == null)
                return;
            View.PhieuThuSachCurrent.Trangthai = true;
            Model.Set(View.PhieuThuSachCurrent);
        }
    }
}
