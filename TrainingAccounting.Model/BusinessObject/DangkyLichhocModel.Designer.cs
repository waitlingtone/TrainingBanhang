using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAccounting.Model.BusinessObject
{
    public partial class DangkyLichhocModel
    {
        partial void OnGioBatdauChanged()
        {
            DateTime tmp = Convert.ToDateTime(this._GioBatdau);
            this._GioBatdau = (new TimeSpan(tmp.Hour, tmp.Minute, 0)).ToString();
        }
        partial void OnGioKetthucChanged()
        {
            DateTime tmp = Convert.ToDateTime(this._GioKetthuc);
            this._GioKetthuc = (new TimeSpan(tmp.Hour, tmp.Minute, 0)).ToString();
        }
    }
}
