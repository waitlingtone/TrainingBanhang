using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface INDGiangdayView:IView
    {
        List<NDGiangdayModel> NDGiangdayItems { get; set; }
        NDGiangdayModel NDGiangdayCurrent { get; }
    }
}
