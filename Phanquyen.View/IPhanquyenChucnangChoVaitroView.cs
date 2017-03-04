using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phanquyen.Model.BusinessObject;

namespace Phanquyen.View
{
    public interface IPhanquyenChucnangChoVaitroView:IView
    {
        List<RoleModel> VaitroItems { set; }
        RoleModel VaitroCurrent { get; }
        List<Item> ChucnangItems { get; set; }
        List<Guid?> ItemIds { get; }
        List<RoleRightModel> VaitroChucnangItems { get; set; }
        List<GroupItemModel> NhomChucnangItems { set; }
        Guid? NhomChucnangId { get; }
    }
}
