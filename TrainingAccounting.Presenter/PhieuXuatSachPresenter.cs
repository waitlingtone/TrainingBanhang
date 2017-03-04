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
    public class PhieuXuatSachPresenter:Presenter<IPhieuXuatSachView>
    {
        public PhieuXuatSachPresenter(IPhieuXuatSachView view) : base(view) { }


        public void LoadData()
        {
            View.PhieuXuatSachItems = Model.Get<PhieuXuatThuSachModel>("TraAcc_Danh_GetPhieuXuatSach");
            View.SachItems = Model.Get<SachModel>("TrAcc_GetSachWithGiasach");
        }
        public void LoadChitiet()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "PhieuXuatThuSachId", Value = View.PhieuXuatSachCurrent.PhieuXuatThuSachId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.ChitietItems = Model.Get<ChitietPhieuXuatThuSachModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetChitietPhieuxuatByPhieuxuatId" });
            View.RefreshData();
        }

        public void AddPhieu()
        {
            View.PhieuXuatSachItems.Add(new PhieuXuatThuSachModel { IsXuat = true, Ngay = DateTime.Now, Tongtien= 0, Trangthai = false });
            View.RefreshData();
        }

        public void DeletePhieu()
        {
            var cur = View.PhieuXuatSachCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.PhieuXuatSachItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void SavePhieu()
        {
            Model.Set(View.PhieuXuatSachItems);
            View.RefreshData();
        }
        public void AddChitietSach()
        {
            if (View.PhieuXuatSachCurrent == null)
                return;
            View.ChitietItems.Add(new ChitietPhieuXuatThuSachModel { PhieuXuatThuSachId = View.PhieuXuatSachCurrent.PhieuXuatThuSachId, STT = View.ChitietItems.Count + 1 });
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
            
            Model.Set(View.PhieuXuatSachItems);
            Model.Set(View.ChitietItems);
            View.RefreshData();
        }

        public void UpdateTien()
        {
            Model.Set(View.ChitietItems);
            double tong = 0;
            foreach (var i in View.ChitietItems)
                tong += i.Thanhtien.Value;
            View.PhieuXuatSachCurrent.Tongtien = tong;
            Model.Set(View.PhieuXuatSachCurrent);
        }

        public void Xuatphieu()
        {
            if (View.PhieuXuatSachCurrent == null)
                return;
            View.PhieuXuatSachCurrent.Trangthai = true;
            Model.Set(View.PhieuXuatSachCurrent);
        }
    }
}
