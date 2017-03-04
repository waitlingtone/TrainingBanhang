using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAccounting.Model.BusinessObject
{
    public partial class ChitietPhieubaoHocphi
    {
        public String SThu
        {
            get
            {
                if (thu == 1)
                    return "Chủ nhật";
                else
                    return String.Format("Thứ {0}", thu);
            }
        }
    }
}
