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
    public class DongiaHocphiPresenter:Presenter<IDongiaHocphiView>
    {
        public DongiaHocphiPresenter(IDongiaHocphiView view) : base(view) { }
        public void LoadData()
        {
            View.DongiaHocphiItems = Model.Get<DongiaHocphiModel>("TrAcc_Danh_GetDongiaHocphiMacding");
        }
        public void AddDongiaHocphi()
        {
            //foreach (var dg in View.DongiaHocphiItems)
            //    dg.CoSudung = false;
            //View.RefreshData();
            //var items = new List<AutoItem>();
            //items.Add(new AutoItem { Name = "tmp", Value = 1, SqlType = System.Data.SqlDbType.Int });//?
            //Model.SetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_UpdateDongiaHocphiMacding_SudungFalse" }); //set CoSudung = false
            View.DongiaHocphiItems.Add(new DongiaHocphiModel { NgayApdung = DateTime.Now });
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
            Model.Set(View.DongiaHocphiItems);
            View.RefreshData();
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
