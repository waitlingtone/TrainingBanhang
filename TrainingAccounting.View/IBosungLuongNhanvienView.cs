using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IBosungLuongNhanvienView:IView
    {
        List<NhanvienModel> NhanvienItems { get; set; }
        int Thang { get; }
        int Nam { get; }
        bool ConLamviec { get; }
    }
}
