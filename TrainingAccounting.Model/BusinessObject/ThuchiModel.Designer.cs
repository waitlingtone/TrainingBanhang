using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAccounting.Model.BusinessObject
{
    public partial class ThuchiModel
    {
        public int STT { get; set; }
        public String TenTre { get; set; }
        public String TenNhanvien { get; set; }
        public double? TienThucte
        {
            get
            {
                if (IsThu != null && IsThu.Value == true)
                    return SoTien;
                else
                    return SoTien * (-1);
            }
        }
    }
}
