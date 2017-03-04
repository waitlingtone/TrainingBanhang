using Lambda.ClientModel;
using Phanquyen.Model.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phanquyen.View
{
    public interface IVaitroView:IView
    {
        List<RoleModel> VaitroItems { get; set; }
        RoleModel VaitroCurrent { get; }
    }
}
