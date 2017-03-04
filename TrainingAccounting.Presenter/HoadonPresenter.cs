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
    public class HoadonPresenter : Presenter<IHoadonView>
    {
        public HoadonPresenter(IHoadonView view) : base(view) { }


        public void LoadData()
        {
            View.HoadonItems = Model.Get<HoadonModel>("sys_HoadonSelect");
            View.HanghoaItems = Model.Get<HanghoaModel>("sys_HanghoaSelect");
        }
        public void LoadChitietHoadon()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "HoadonId", Value = View.HoadonCurrent.HoadonId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.ChitietHoadonItems = Model.Get<ChitietHoadonModel>(new AutoObject { Items = items, SpName = "sys_ChitietHoadonSelect" });
            View.RefreshData();
        }

        public void AddHD()
        {
            View.HoadonItems.Add(new HoadonModel { Ngaylap = DateTime.Now, Trigia = 0 });
            View.RefreshData();
        }

        public void DeleteHD()
        {
            var cur = View.HoadonCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.HoadonItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void SaveHD()
        {
            Model.Set(View.HoadonItems);
            View.RefreshData();
        }
        public void AddChitietHoadon()
        {
            if (View.HoadonCurrent == null)
                return;
            View.ChitietHoadonItems.Add(new ChitietHoadonModel {HoadonId = View.HoadonCurrent.HoadonId, Soluong = 1});
            View.RefreshData();
        }

        public void DeleteChitietHoadon()
        {
            var cur = View.ChitietHoadonCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.ChitietHoadonItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void SaveChitietHoadon()
        {
            Model.Set(View.HoadonItems);
            Model.Set(View.ChitietHoadonItems);
            View.RefreshData();
        }

        public void TongtienHD()
        {
            Model.Set(View.ChitietHoadonItems);
            Decimal tong = 0;
            foreach (var i in View.ChitietHoadonItems)
                tong += i.Thanhtien.Value;
            View.HoadonCurrent.Trigia = tong;
            Model.Set(View.HoadonCurrent);
        }
    }
}
