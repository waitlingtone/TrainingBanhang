using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phanquyen.Model.BusinessObject;

namespace Phanquyen.View
{
    public interface IPhanquyenNguoidungView:IView
    {
        List<_UserModel> UserItems { get; set; }
        _UserModel UserCurrent { get; }
        List<NguoidungModel> NguoidungItems { set; }
        List<RoleModel> RoleItems { get; set; }

        List<UserRoleModel> UserRoleItems { get; set; }
    }
}
