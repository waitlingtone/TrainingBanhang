using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IBosungLichhocView:IView
    {
        Guid? TreId { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        TimeSpan StartTime { get; }
        TimeSpan EndTime { get; }
        List<ThuModel> ThuItems { set; }
        int Thu { get; }
        int Thang { get; }
        int Nam { get; }
        List<CahocModel> CahocItems { get; set; }
        Guid? CahocId { get; }
        bool Tuychon { get; }
        bool Laplai { get; }
        DateTime Ngaychon { get; }
    }
}
