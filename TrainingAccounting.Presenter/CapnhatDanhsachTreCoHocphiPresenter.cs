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
    public class CapnhatDanhsachTreCoHocphiPresenter:Presenter<ICapnhatDanhsachTreCoHocphiView>
    {
        public CapnhatDanhsachTreCoHocphiPresenter(ICapnhatDanhsachTreCoHocphiView view) : base(view) { }
        public void LoadData()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            View.DanhsachItems = Model.Get<DanhsachButruHocphi>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetDanhsachTreCoButruHocphi" });
            View.RefreshData();
        }

        public void Save()
        {
            List<PhieubaoHocphiModel> pbList = new List<PhieubaoHocphiModel>();
            foreach (var i in View.DanhsachItems)
            {
                if (i.Select)
                {
                    PhieubaoHocphiModel pb = new PhieubaoHocphiModel { TreId = i.TreId, Thang = View.Thang, Nam = View.Nam };
                    pbList.Add(pb);
                }
            }
            Model.Set(pbList);
        }
    }
}
