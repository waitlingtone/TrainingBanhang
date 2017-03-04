using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IThoikhoabieuGiaovienView:IView
    {
        List<ThangModel> ThangItems { set; }
        List<NhanvienModel> NhanvienItems { set; }
        NhanvienModel NhanvienCurrent { get; }
        List<LichhocDayhocModel> LichhocDayhocItems { set; }

        int Thang { get;}

        int Nam { get;}
    }
}
