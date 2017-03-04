using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IPhieubaoHocphiView:IView
    {
        List<PhieubaoHocphiModel> DanhsachTreItems { set; }
        PhieubaoHocphiModel PhieubaoHocphiCurrent { get; }
        List<ThangModel> ThangItems { set; }
        int Thang { get; }
        int Nam { get; }
        List<PhieubaoHocphi> PhieubaoHocphiItems { get; set; }
        DaumucThuchiModel DaumucThuchi { get; }

        bool DaKhoa { set; }
        bool DaDong { set; }
        string Msg { set; }
    }
}
