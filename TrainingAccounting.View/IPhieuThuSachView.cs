using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IPhieuThuSachView:IView
    {
        List<SachModel> SachItems { set; }
        List<PhieuXuatThuSachModel> PhieuThuSachItems { get; set; }
        PhieuXuatThuSachModel PhieuThuSachCurrent { get; }
        List<ChitietPhieuXuatThuSachModel> ChitietItems { get; set; }
        ChitietPhieuXuatThuSachModel ChitietCurrent { get; }
    }
}
