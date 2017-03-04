using Lambda.ClientModel;
using Phanquyen.Model.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phanquyen.View
{
    public interface ITaikhoanView:IView
    {
        List<_UserModel> UserItems { get; set; }
        _UserModel UserCurrent { get; }
        List<NguoidungModel> NguoidungItems { get; set; }
        NguoidungModel NguoidungCurrent { get; }
    }
}
