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
    public class PhieubaoHocphiPresenter:Presenter<IPhieubaoHocphiView>
    {
        public PhieubaoHocphiPresenter(IPhieubaoHocphiView view) : base(view) { }
        public void LoadData()
        {
            View.ThangItems = Model.Get<ThangModel>("sys_ThangSelect"); 
        }
        public void GetTre()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            View.DanhsachTreItems = Model.Get<PhieubaoHocphiModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetPhieubaoHocphiByThangNam" });
        }
        public void GetHocphiByTre()
        {
            if (View.PhieubaoHocphiCurrent == null)
            {
                View.PhieubaoHocphiItems = new List<PhieubaoHocphi>();
                View.RefreshData();
                return;
            }
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.PhieubaoHocphiCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            View.PhieubaoHocphiItems = Model.Get<PhieubaoHocphi>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetHocphiByTreId" });
            KiemtraThanhtoan();
            View.RefreshData();
        }

        private void KiemtraThanhtoan()
        {
            //var items = new List<AutoItem>();
            //items.Add(new AutoItem { Name = "TreId", Value = View.PhieubaoHocphiCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            //items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            //items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            //PhieubaoHocphiModel PhieubaoHocphi = Model.Get<PhieubaoHocphiModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_KiemtraTontaiPhieubaoHocphiByTreId" }).FirstOrDefault();
             if (View.PhieubaoHocphiCurrent.Step == null)
            {
                View.DaKhoa = false;
                View.DaDong = false;
                View.Msg = String.Format("Chưa tính");
                return;
            }
            
            if (View.PhieubaoHocphiCurrent.Step != null && View.PhieubaoHocphiCurrent.Step.Value == 2)
            {
                View.DaKhoa = true;
                View.DaDong = true;
                View.Msg = String.Format("Đã đóng học phí ngày {0}", View.PhieubaoHocphiCurrent.NgayGhino);
                return;
            }

            else if (View.PhieubaoHocphiCurrent.Step != null && View.PhieubaoHocphiCurrent.DaThanhtoan.Value == false)
            {
                View.DaKhoa = true;
                View.DaDong = false;
                View.Msg = String.Format("Đã khóa học phí ngày {0}", View.PhieubaoHocphiCurrent.NgayGhino);
            }
            
        }

        public void UpdateDaThanhtoan()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.PhieubaoHocphiCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "DaumucThuchiId", Value = View.DaumucThuchi.DaumucThuchiId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            items.Add(new AutoItem { Name = "TenDaumuc", Value = View.DaumucThuchi.TenDaumuc, SqlType = System.Data.SqlDbType.NVarChar });

            Model.SetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_ThanhtoanDadongHocphiByTreId" });
        }

        public void TinhHocphiCurrent()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.PhieubaoHocphiCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            Model.SetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_ThanhtoanDaGhinoHocphiByTreId" });
        }

        public void TinhAllHocphi()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            Model.SetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_TinhAllHocphi" });
        }

        public void UnblockCurent()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.PhieubaoHocphiCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            Model.SetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_UnblockHocphiByTreIdThangNam" });
        }

        public void UnblockAll()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            Model.SetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_UnblockAllHocphi" });
        }

        public void UpdateDongiaCurrent()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.PhieubaoHocphiCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            Model.SetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_UpdateDongiaHocphiByTreIdThangNam" });
        }

        public void UpdateDongiaAll()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            Model.SetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_UpdateDongiaAll" });
        }

        public float GetDongiaHocphi()
        {
            float Dongia = 0;
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.PhieubaoHocphiCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            var rs = Model.GetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetDongiaHocphiNyTreId" }).FirstOrDefault();
            if (rs != null && rs.Items[0].Value != null)
                Dongia = float.Parse(rs.Items[0].Value.ToString());
            return Dongia;
        }
    }
}
