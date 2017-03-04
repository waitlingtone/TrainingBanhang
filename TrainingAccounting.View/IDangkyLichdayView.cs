using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IDangkyLichdayView:IView
    {
        List<NhanvienModel> NhanvienItems { set; }
        NhanvienModel NhanvienCurrent { get; }
        List<BangNgayhocTrongtuan> NgayhocTrongtuanItems { get; set; }
        List<DangkyLichdayModel> CakhacItems { get; set; }
        DangkyLichdayModel CakhacCurrent { get; }
        List<ThuModel> ThuItems { set; }
    }
}
