using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phanquyen.Model.BusinessObject;

namespace Phanquyen.View
{
    public interface INhomChucnangView:IView
    {
        List<GroupItemModel> NhomChucnangItems { get; set; }
        GroupItemModel NhomchucnangCurrent { get; }
    }
}
