using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.MainProject
{
    public interface IDoiMatkhauView:IView
    {
        String OldPass { get; }
        String NewPass { get; }
        String CfNewPass { get; }
    }
}
