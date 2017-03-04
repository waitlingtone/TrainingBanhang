using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface ITinhthanhView:IView
    {
        List<TinhthanhModel> TinhthanhItems { get; set; }
        TinhthanhModel TinhthanhCurrent { get; }

    }
}
