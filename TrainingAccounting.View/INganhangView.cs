using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface INganhangView:IView
    {
        List<NganhangModel> NganhangItems { get; set; }
        NganhangModel NganhangCurrent { get; }
        List<ChinhanhNganhangModel> ChinhanhItems { get; set; }
        ChinhanhNganhangModel ChinhanhCurrent { get; }
    }
}
