using Lambda.BusinessObject;
using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.MainProject
{
    public class ItemPresenter:Presenter<ItemView>
    {
        public ItemPresenter(ItemView View)
            : base(View)
        {
        }
        public void Display()
        {
            Guid? Id = Lambda.ClientModel.ModelCore.UserId as Guid?;
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "UserId", Value = Id, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.Items = Model.Get<Item>(new AutoObject { Items = item, SpName = "Phanquyen_Danh_GetItemsByUserId" });

            View.RefreshData();
        }
    }
}
