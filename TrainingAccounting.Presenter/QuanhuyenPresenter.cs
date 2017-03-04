using Lambda.ClientModel;
using Lambda.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.View;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.Presenter
{
    public class QuanhuyenPresenter:Presenter<IQuanhuyenView>
    {
        public QuanhuyenPresenter(IQuanhuyenView view) : base(view) { }
        public void LoadData()
        {
            View.TinhthanhItems = Model.Get<TinhthanhModel>("sys_TinhthanhSelect");
        }

        public void GetQuanhuyenByTinh()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TinhthanhId", Value = View.TinhthanhId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.QuanhuyenItems = Model.Get<QuanhuyenModel>(new AutoObject { SpName = "TrAcc_Danh_GetQuanhuyenByTinhthanhId", Items = items });
            View.RefreshData();
        }

        public void Add()
        {
            if (View.TinhthanhId == null)
                return;
            View.QuanhuyenItems.Add(new QuanhuyenModel { TinhthanhId = View.TinhthanhId });
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.QuanhuyenCurrent;
            if (cur == null)
                return;
            if (cur.State ==Lambda.BusinessObject.RowState.Insert)
            {
                View.QuanhuyenItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void Save()
        {
            Model.Set(View.QuanhuyenItems);
            View.RefreshData();
        }
    }
}
