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
    public class ThongtinPresenter:Presenter<IThongtinView>
    {
        public ThongtinPresenter(IThongtinView view) : base(view) { }
        public void LoadData()
        {
            View.ThongtinItem = Model.Get<ThongtinModel>("sys_ThongtinSelect");
            if (View.ThongtinItem.Count == 0)
                View.ThongtinItem.Add(new ThongtinModel());
        }

        public void Save()
        {
            Model.Set(View.ThongtinItem);
        }
    }
}
