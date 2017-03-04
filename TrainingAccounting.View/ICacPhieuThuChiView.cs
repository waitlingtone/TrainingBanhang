using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface ICacPhieuThuChiView:IView
    {
        DateTime Ngay { get; }
        DateTime TuNgay { get; }
        DateTime DenNgay { get; }
        List<ThuchiModel> ThuchiItems { get; set; }
        ThuchiModel ThuchiCurrent { get; }
        int Type { get; }
    }
}
