using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phanquyen.Model.BusinessObject
{
    public partial class CanboModel
    {
        public String HoTen { get { return String.Format("{0} {1}", HoDem, TenCanbo); } }
        //public bool Selected { get; set; }
    }
}
