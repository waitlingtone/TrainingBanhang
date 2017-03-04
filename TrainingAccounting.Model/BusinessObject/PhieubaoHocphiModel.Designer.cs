using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAccounting.Model.BusinessObject
{
    public partial class PhieubaoHocphiModel
    {
        public int STT { get; set; }
        public String Hodem { get; set; }
        public String Ten { get; set; }
        public DateTime Ngaysinh { get; set; }
        public String Phuhuynh { get; set; }
        public String Trangthai
        {
            get
            {
                if (Step != null)
                {
                    if (DaThanhtoan.Value)
                        return "Đã khóa - Đã đóng";
                    else
                        return "Đã khóa - Chưa đóng";
                }
                else
                    return "Chưa tính";
            }
        }
        public String Hoten { get { return String.Format("{0} {1}", Hodem, Ten); } }
    }
}
