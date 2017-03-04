using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda.ClientModel
{
    /// <summary>
    /// Marker IView interface, without members.
    /// </summary>
    public interface IView
    {
        void RefreshData();
    }
}
