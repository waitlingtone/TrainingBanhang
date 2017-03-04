using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.ClientModel
{
    public interface ILoginView:IView
    {
        string stringUsername { get; }
        string stringPassword { get; }
    }
}
