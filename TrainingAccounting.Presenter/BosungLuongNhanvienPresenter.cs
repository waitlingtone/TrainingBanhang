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
    public class BosungLuongNhanvienPresenter:Presenter<IBosungLuongNhanvienView>
    {
        public BosungLuongNhanvienPresenter(IBosungLuongNhanvienView view) : base(view) { }
        public void LoadData()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "ConLamviec", Value = View.ConLamviec, SqlType = System.Data.SqlDbType.Bit });
            View.NhanvienItems = Model.Get<NhanvienModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetNhanvienBosungTinhluong" });
        }

        public void Add()
        {
            List<PhieubaoLuongNhanvienModel> lst = new List<PhieubaoLuongNhanvienModel>();
            foreach (var i in View.NhanvienItems)
                if (i.Selected)
                    lst.Add(new PhieubaoLuongNhanvienModel { NhanvienId = i.NhanvienId, Thang = View.Thang, Nam = View.Nam });
            Model.Set(lst);
        }
    }
}
