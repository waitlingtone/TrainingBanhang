using Lambda.ClientModel;
using Phanquyen.Model.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phanquyen.View
{
    public interface IChucnangView:IView
    {
        List<Item> Items { get; set; }
        Item CurrentItem { get; }

        List<GroupItemModel> NhomChucnangItems { set; }
        Guid? NhomChucnangId { get; }
    }
}
