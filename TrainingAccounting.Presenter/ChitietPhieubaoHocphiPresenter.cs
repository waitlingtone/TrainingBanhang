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
    public class ChitietPhieubaoHocphiPresenter:Presenter<IChitietPhieubaoHocphiView>
    {
        public ChitietPhieubaoHocphiPresenter(IChitietPhieubaoHocphiView view) : base(view) { }

        public void LoadData()
        {
            if (View.TreCurrent == null)
                return;
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.TreCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            View.ChitietPhieubaoItems = Model.Get<ChitietPhieubaoHocphi>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetChitietHocphiByTreId" });
            View.RefreshData();
        }
    }
}
