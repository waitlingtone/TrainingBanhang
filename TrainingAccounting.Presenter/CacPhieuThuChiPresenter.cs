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
    public class CacPhieuThuChiPresenter:Presenter<ICacPhieuThuChiView>
    {
        public CacPhieuThuChiPresenter(ICacPhieuThuChiView view) : base(view) { }
        public void LoadDataNgay()
        {
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "TuNgay", Value = View.TuNgay, SqlType = System.Data.SqlDbType.DateTime });
            item.Add(new AutoItem { Name = "DenNgay", Value = View.DenNgay, SqlType = System.Data.SqlDbType.DateTime });
            item.Add(new AutoItem { Name = "Type", Value = View.Type, SqlType = System.Data.SqlDbType.Int });
            View.ThuchiItems = Model.Get<ThuchiModel>(new AutoObject { Items = item, SpName = "TrAcc_Danh_GetThuchiByNgay" });
        }
    }
}
