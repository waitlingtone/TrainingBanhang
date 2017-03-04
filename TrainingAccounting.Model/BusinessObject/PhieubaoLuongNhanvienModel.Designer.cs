using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAccounting.Model.BusinessObject
{
    public partial class PhieubaoLuongNhanvienModel
    {
        public int STT { get; set; }
        public Guid? NhanvienId2 { get; set; }
        public String TenNhanvien { get; set; }
        public String Trangthai
        {
            get
            {
                if (Step == null || Step == 0) return "Chưa tính Lương";
                else if (Step == 1) return "Đã tính Lương, Chưa thanh toán";
                else return "Đã Thanh toán";
            }
        }
        public Guid? NganhangId { get; set; }
        public Guid? ChinhanhNganhangId { get; set; }
        public String SoTaikhoan { get; set; }
    }
}
