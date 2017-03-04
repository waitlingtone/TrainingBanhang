using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface ILichhocDayhocAppointmentView:IView
    {
        List<NhanvienModel> NhanvienItems { get; set; }
        NhanvienModel NhanvienCurrent { get; }
        TreModel TreItem { get; }
        DateTime StartTine { get; }
        DateTime EndTine { get; }
        Guid? LichhocDayhocId { get; }
        Guid? NhanvienId { get; }
        NhanvienModel Nhanvien { get; set; }
        bool Laplai { get; }
        String Ghichu { get; }
        List<NDGiangdayModel> NDGiangdaySelected { get; }
        bool isCaghep { get; set; }
    }
}
