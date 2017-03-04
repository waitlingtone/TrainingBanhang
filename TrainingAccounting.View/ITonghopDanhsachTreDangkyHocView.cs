using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface ITonghopDanhsachTreDangkyHocView:IView
    {
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        List<LichhocDayhocModel> LichhocDayhocItems { set; }
        List<ThangModel> ThangItems { set; }
        int Thang { get; }
        int Nam { get; }
    }
}
