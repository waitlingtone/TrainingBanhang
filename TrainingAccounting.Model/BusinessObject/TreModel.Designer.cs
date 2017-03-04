using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAccounting.Model.BusinessObject
{
    public partial class TreModel
    {
        public int STT { get; set; }
        public String HoTen { get { return String.Format("{0} {1}", Hodem, Ten); } }
        public String Thannhan { get; set; }
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
        public String Trangthai { get; set; }
    }
}
