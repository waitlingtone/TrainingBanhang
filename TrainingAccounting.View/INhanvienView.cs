using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface INhanvienView:IView
    {
        List<NhanvienModel> NhanvienItems { get; set; }
        NhanvienModel NhanvienCurrent { get; }

        List<LuongNhanvienModel> LuongNhanvienItems { get; set; }
        LuongNhanvienModel LuongNhanvienCurrent { get; }

        List<NganhangModel> NganhangItems { set; }
        Guid? NganhangId { get; }
        List<ChinhanhNganhangModel> ChinhanhNganhangItems { set; }

        bool ConHoatdong { get; }
    }
}
