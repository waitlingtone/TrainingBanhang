using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IChonNoidungView:IView
    {
        List<NDGiangdayModel> NDGiangdayItems { get; set; }
        Guid LichhocDayhocId { get; }
    }
}
