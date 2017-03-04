using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IThuChiView:IView
    {
        List<DaumucThuchiModel> DaumucThuchiItems { set; }
        Guid? DaumucThuchiId { get; }
        List<ThuchiModel> ThuchiItem { get; set; }
        bool isThu { get; }
    }
}
