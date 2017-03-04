using Lambda.BusinessObject;
using Lambda.ClientModel;
using Phanquyen.Model.BusinessObject;
using Phanquyen.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phanquyen.Presenter
{
    public class ChucnangPresenter : Presenter<IChucnangView>
    {
        public ChucnangPresenter(IChucnangView View)
            : base(View)
        {
        }
        public void LoadData()
        {
           
            View.NhomChucnangItems = Model.Get<GroupItemModel>("sys_GroupItemSelect");
            View.RefreshData();
        }
        public void Save()
        {
            Model.Set(View.Items);
            View.RefreshData();
        }

        public void AddNew()
        {
            if (View.NhomChucnangId == null)
                return;
            View.Items.Add(new Item { GroupItemId = View.NhomChucnangId });
            View.RefreshData();
        }

        public void Delete()
        {
            var cur = View.CurrentItem;
            if (cur == null)
                return;
            if (cur.State == RowState.Insert)
            {
                View.Items.Remove(cur);
                View.RefreshData();
                return;
            }
            cur.MakeDelete();
        }

        public void AddChild()
        {
            if (View.CurrentItem == null)
                return;
            View.Items.Add(new Item { ItemChaId = View.CurrentItem.ItemId, GroupItemId = View.NhomChucnangId });
            View.RefreshData();
        }

        public void GetChucnangByNhomChucnang()
        {
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "GroupItemId", Value = View.NhomChucnangId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            View.Items = Model.Get<Item>(new AutoObject { Items = item, SpName = "Phanquyen_Danh_GetItemByGroupItemId" });
        }
    }
}
