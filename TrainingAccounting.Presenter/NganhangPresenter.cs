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
    public class NganhangPresenter:Presenter<INganhangView>
    {
        public NganhangPresenter(INganhangView view) : base(view) { }
        public void LoadData()
        {
            View.NganhangItems = Model.Get<NganhangModel>("sys_NganhangSelect");
        }
        public void GetChinhanh()
        {
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "NganhangId", Value = View.NganhangCurrent.NganhangId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.ChinhanhItems = Model.Get<ChinhanhNganhangModel>(new AutoObject { Items = item, SpName = "TrAcc_Danh_GetChinhanhNganhangByNganhangId" });
            View.RefreshData();
        }
        public void AddNganhang()
        {
            View.NganhangItems.Add(new NganhangModel());
            View.RefreshData();
        }

        public void DeleteNganhang()
        {
            var cur = View.NganhangCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.NganhangItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void SaveNganhang()
        {
            Model.Set(View.NganhangItems);
            View.RefreshData();
        }

        public void AddCNNganhang()
        {
            if (View.NganhangCurrent == null)
                return;
            if (View.ChinhanhItems == null)
                View.ChinhanhItems = new List<ChinhanhNganhangModel>();
            View.ChinhanhItems.Add(new ChinhanhNganhangModel { NganhangId = View.NganhangCurrent.NganhangId });
            View.RefreshData();
        }

        public void DeleteCNNganhang()
        {
            var cur = View.ChinhanhCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.ChinhanhItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void SaveCNNganhang()
        {
            //this.Transaction.Add(View.NganhangItems);
            //this.Transaction.Add(View.ChinhanhItems);
            //Model.SetTransaction(this.Transaction);
            Model.Set(View.NganhangCurrent);
            Model.Set(View.ChinhanhItems);
            View.RefreshData();
        }
    }
}
