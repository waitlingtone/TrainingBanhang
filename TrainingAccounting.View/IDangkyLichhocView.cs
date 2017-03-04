using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IDangkyLichhocView:IView
    {
        List<NhomTreModel> NhomtreItems { set; }
        List<TreModel> TreItems { set; }
        TreModel TreCurrent { get; }

        List<BangNgayhocTrongtuan> NgayhocTrongtuanItems { get; set; }

        Guid? NhomtreId { get; }
        List<ThuModel> ThuItems { set; }
        List<DangkyLichhocModel> CakhacItems { get; set; }
        DangkyLichhocModel CakhacCurrent { get; }
    }
}
