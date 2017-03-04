using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAccounting.Model.BusinessObject
{
    public partial class ChitietPhieubaoLuongNhanvienModel
    {
        public String MaGetOnly { get { return Ma; } }
        public String DanhmucTraluongNhanvienGetOnly { get { return DanhmucTraluongNhanvien; } }
        public int STT { get; set; }
    }
}
