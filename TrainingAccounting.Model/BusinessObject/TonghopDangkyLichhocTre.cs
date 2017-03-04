using Lambda.BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAccounting.Model.BusinessObject
{
    public class TonghopDangkyLichhocTre :Bus
    {
        public String Thu2 { get; set; }
        public String Thu3 { get; set; }
        public String Thu4 { get; set; }
        public String Thu5 { get; set; }
        public String Thu6 { get; set; }
        public String Thu7 { get; set; }
        public String Thu1 { get; set; }
        public DateTime Ngay { get; set; }
        public String ShortDate
        {
            get
            {
                return Ngay.ToShortDateString();
            }
        }
        public String TenTre { get; set;}

        public TonghopDangkyLichhocTre(AutoObject value)
        {
            DataFromAutoObject(value);
        }

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();
            Items.Add(new AutoItem { Name = "Thu2", Value = Thu2, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "Thu3", Value = Thu3, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "Thu4", Value = Thu4, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "Thu5", Value = Thu5, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "Thu6", Value = Thu6, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "Thu7", Value = Thu7, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "Thu1", Value = Thu1, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "TenTre", Value = TenTre, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "Ngay", Value = TenTre, SqlType = SqlDbType.DateTime });
            return DataToAutoObject(Items.ToArray());
        }
    }
}
