using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAccounting.Model.BusinessObject
{
    public partial class NhanvienModel
    {
        public bool Selected { get; set; }
        public String HoTenNhanvien { get { return String.Format("{0} {1}", Hodem, Ten); } }
        public int STT { get; set; }
        public String TenNganhang { get; set; }
        public String TenGioitinh
        {
            get
            {
                if (Gioitinh.Value)
                    return "Nữ";
                else
                    return "Nam";
            }
        }
        public String Loai
        {
            get
            {
                if (LaGiaovien.Value)
                    return "Giáo viên";
                else
                    return "Nhân viên";
            }
        }
    }
}
