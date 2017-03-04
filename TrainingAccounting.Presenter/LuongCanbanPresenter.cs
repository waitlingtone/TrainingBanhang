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
    public class LuongCanbanPresenter:Presenter<ILuongCanbanView>
    {
        public LuongCanbanPresenter(ILuongCanbanView view) : base(view) { }
        public void LoadData()
        {
            View.LuongCanbanItems = Model.Get<LuongNhanvienModel>("TrAcc_Danh_GetLuongMacdingNhanvien");
        }
        public void AddLuong()
        {
            
            View.LuongCanbanItems.Add(new LuongNhanvienModel { NgayApdung = DateTime.Now });
            View.RefreshData();
        }

        public void DeleteLuong()
        {
            var cur = View.LuongCanbanCurrent;
            if (cur == null)
                return;
            if (cur.State == Lambda.BusinessObject.RowState.Insert)
            {
                View.LuongCanbanItems.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void SaveLuong()
        {
            Model.Set(View.LuongCanbanItems);
            View.RefreshData();
        }
    }
}
