using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IThoikhoabieuTreView:IView
    {
        List<ThangModel> ThangItems { set; }
        List<NhomTreModel> NhomtreItems { set; }
        Guid? NhomtreId { get; }
        List<TreModel> TreItems { set; }
        TreModel TreCurrent { get; }
        List<LichhocDayhocModel> LichhocDayhocItems { get; set; }
        int Thang { get; }
        int Nam { get; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        PhieubaoHocphiModel PhieubaoHocphi { get; set; }
        Guid? BuoihocDeleted { get; }
    }
}
