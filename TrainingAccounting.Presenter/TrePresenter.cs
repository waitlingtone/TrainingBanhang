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
    public class TrePresenter:Presenter<ITreView>
    {
        public TrePresenter(ITreView view) : base(view) { }
        public void LoadData()
        {
            View.TinhthanhItems = Model.Get<TinhthanhModel>("sys_TinhthanhSelect");
            View.DantocItems = Model.Get<DantocModel>("sys_DantocSelect");
            View.TongiaoItems = Model.Get<TongiaoModel>("sys_TongiaoSelect");

            View.NhomtreInfoItems = Model.Get<NhomTreModel>("sys_NhomTreSelect");
            List<NhomTreModel> tmp  = Model.Get<NhomTreModel>("sys_NhomTreSelect");
            tmp.Insert(0, new NhomTreModel{TenNhom = "[Tất cả]"});
            View.NhomtreItems = tmp;
            View.RefreshData();
        }

        public void Add()
        {
            if (View.NhomtreId == null)
                return;
            View.TreItems.Add(new TreModel { NhomTreId = View.NhomtreId, STT = View.TreItems.Count + 1 });
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.TreCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.TreItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void Save()
        {
            Model.Set(View.TreItems);
            View.RefreshData();
        }

        public void GetAllTre()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Conhoc", Value = View.Conhoc, SqlType = System.Data.SqlDbType.Bit });
            View.TreItems = Model.Get<TreModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetTreByConhoc" });
            View.RefreshData();
        }

        public void GetTreByNhomtre()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Conhoc", Value = View.Conhoc, SqlType = System.Data.SqlDbType.Bit });
            items.Add(new AutoItem { Name = "NhomtreId", Value = View.NhomtreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.TreItems = Model.Get<TreModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetTreByConhocNhomtreId" });
            View.RefreshData();
        }

        public void GetDongiaHocphi()
        {
            if (View.TreCurrent == null)
                return;
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.TreCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.DongiaHocphiItems = Model.Get<DongiaHocphiModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetDongiaHocphiByTreId" });
            View.RefreshData();
        }

        public void AddDongiaHocphi()
        {
            if (View.TreCurrent == null)
                return;
            //foreach (var dg in View.DongiaHocphiItems)
            //    dg.CoSudung = false;
            //View.RefreshData();
            //var items = new List<AutoItem>();
            //items.Add(new AutoItem { Name = "TreId", Value = View.TreCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            //Model.SetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_UpdateDongiaHocphiByTreId" }); //set CoSudung = false
            View.DongiaHocphiItems.Add(new DongiaHocphiModel { TreId = View.TreCurrent.TreId, NgayApdung = DateTime.Now });
            View.RefreshData();
        }

        public void DeleteDongiaHocphi()
        {
            var cur = View.DongiaHocphiCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.DongiaHocphiItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void SaveDongiaHocphi()
        {
            if (View.TreCurrent != null)
                Model.Set(View.TreCurrent);
            Model.Set(View.DongiaHocphiItems);
            View.RefreshData();
        }

        public void GetThannhan()
        {
            if (View.TreCurrent == null)
                return;
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.TreCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.ThannhanItems = Model.Get<ThannhanModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetThannhanByTreId" });
            View.RefreshData();
        }

        public void AddThannhan()
        {
            if (View.TreCurrent == null)
                return;

            View.ThannhanItems.Add(new ThannhanModel { TreId = View.TreCurrent.TreId });
            View.RefreshData();
        }

        public void DeleteThannhan()
        {
            var cur = View.ThannhanCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.ThannhanItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void SaveThannhan()
        {
            if (View.TreCurrent != null)
                Model.Set(View.TreCurrent);
            Model.Set(View.ThannhanItems);
            View.RefreshData();
        }

        public void GetQuanhuyen()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TinhthanhId", Value = View.TinhthanhId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.QuanhuyenItems = Model.Get<QuanhuyenModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetQuanhuyenByTinhthanhId" });
        }

        public void CheckUnCheck()
        {
            foreach (var i in View.ThannhanItems)
                i.LaDaidienChinh = false;
            View.ThannhanCurrent.LaDaidienChinh = true;
            View.RefreshData();
        }

        public List<Model.BusinessObjectReport.TrAcc_Danh_GetDanhsachTreReportModel> GetDataExcel()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Conhoc", Value = View.Conhoc, SqlType = System.Data.SqlDbType.Bit });
            items.Add(new AutoItem { Name = "NhomtreId", Value = View.NhomtreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            return Model.Get<Model.BusinessObjectReport.TrAcc_Danh_GetDanhsachTreReportModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetDanhsachTreReport" });
        }

        public void CheckChanged()
        {
            foreach (var i in View.DongiaHocphiItems)
                i.Sudung = false;
            View.DongiaHocphiCurrent.Sudung = true;
            View.RefreshData();
        }
    }
}
