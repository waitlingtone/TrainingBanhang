using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IBangluongChuyenKhoanView:IView
    {
        List<ThangModel> ThangItems { set; }
        int Thang { get; set; }
        int Nam { get; set; }
        List<NhanvienModel> NhanvienItems { set; }
        PhieubaoLuongNhanvienModel PhieubaoLuong { get; set; }
        List<BangluongChuyenkhoanModel> BangchuyenKhoanItems { get; set; }
        BangluongChuyenkhoanModel BangchuyenKhoanCurrent { get; }
        List<PhieubaoLuongNhanvienModel> PhieubaoLuongItems { get; set; }
    }
}
