using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IQuanhuyenView:IView
    {
        List<QuanhuyenModel> QuanhuyenItems { get; set; }
        QuanhuyenModel QuanhuyenCurrent { get; }

        List<TinhthanhModel> TinhthanhItems { set; }
        Guid? TinhthanhId { get; }
    }
}
