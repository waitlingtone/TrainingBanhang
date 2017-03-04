using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IDiemdanhTrongngayView:IView
    {
        List<LichhocDayhocModel> LichhocDayhocItems { get; set; }
        DateTime Tungay { get; }
        DateTime Denngay { get; }
        List<ThangModel> ThangItems { set; }
        int Thang { get; }
        int Nam { get; }
        List<NhanvienModel> NhanvienItems { set; }
        NhanvienModel NhanvienCurrent { get; }
    }
}
