using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface ITreView:IView
    {
        List<NhomTreModel> NhomtreItems { set; }
        List<NhomTreModel> NhomtreInfoItems { set; }
        Guid? NhomtreId { get; }
        bool Conhoc { get; }
        List<TreModel> TreItems { get; set; }
        TreModel TreCurrent { get; }
        List<TinhthanhModel> TinhthanhItems { set; }
        Guid? TinhthanhId { get; }
        List<QuanhuyenModel> QuanhuyenItems { set; }
        List<DantocModel> DantocItems { set; }
        List<TongiaoModel> TongiaoItems { set; }

        List<DongiaHocphiModel> DongiaHocphiItems { get; set; }
        DongiaHocphiModel DongiaHocphiCurrent { get; }

        List<ThannhanModel> ThannhanItems { get; set; }
        ThannhanModel ThannhanCurrent { get; }
    }
}
