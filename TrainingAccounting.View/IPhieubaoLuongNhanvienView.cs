using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IPhieubaoLuongNhanvienView:IView
    {
        //List<NhanvienModel> NhanvienItems { set; }
        //NhanvienModel NhanvienCurrent { get; }
        List<PhieubaoLuongNhanvienModel> PhieubaoLuongItems { get; set; }
        List<ThangModel> ThangItems { set; }
        int Thang { get; }
        int Nam { get; }

        PhieubaoLuongNhanvienModel PhieubaoLuongCurrent { get; }
        List<ChitietPhieubaoLuongNhanvienModel> ChitietPhieubaoLuongItems { get; set; }
        ChitietPhieubaoLuongNhanvienModel ChitietPhieubaoLuongCurrent { get; }
        List<DanhmucTraluongNhanvienModel> DanhmucTraluongItems { set; }
        List<PhieubaoLuong> PhieubaoLuong { set; }
        List<DanhmucTraluongNhanvienModel> DanhmucLuongSelectedItems { get; }

        DaumucThuchiModel DaumucThuchi { get; }
        bool DaThanhtoan { set; }
        String Msg { set; }
    }
}
