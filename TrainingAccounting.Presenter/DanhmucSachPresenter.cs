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
    public class DanhmucSachPresenter:Presenter<IDanhmucSachView>
    {
        public DanhmucSachPresenter(IDanhmucSachView view) : base(view) { }
        public void LoadData()
        {
            View.SachItems = Model.Get<SachModel>("TrAcc_Danh_SachSelect");
            View.RefreshData();
        }

        public void LoadGiasach()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "SachId", Value = View.SachCurrent.SachId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.GiaSachItems = Model.Get<GiaSachModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetGiaSachBySachId" });
            View.RefreshData();
        }

        public void AddSach()
        {
            View.SachItems.Add(new SachModel());
            View.RefreshData();
        }

        public void DeleteSach()
        {
            var cur = View.SachCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.SachItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void SaveSach()
        {
            Model.Set(View.SachItems);
            View.RefreshData();
        }
        public void AddGiaSach()
        {
            if (View.SachCurrent == null)
                return;
            View.GiaSachItems.Add(new GiaSachModel { SachId = View.SachCurrent.SachId });
            View.RefreshData();
        }

        public void DeleteGiaSach()
        {
            var cur = View.GiaSachCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.GiaSachItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void SaveGiaSach()
        {
            Model.Set(View.SachItems);
            Model.Set(View.GiaSachItems);
            View.RefreshData();
        }
    }
}
