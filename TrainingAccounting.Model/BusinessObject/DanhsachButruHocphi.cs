using Lambda.BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAccounting.Model.BusinessObject
{
    public class DanhsachButruHocphi:Bus
    {
        public Guid? TreId { get; set; }
        public String TenTre { get; set; }
        public float Tongtien { get; set; }
        public bool Select { get; set; }

        public DanhsachButruHocphi(AutoObject value)
        {
            DataFromAutoObject(value);
        }

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();
            Items.Add(new AutoItem { Name = "TreId", Value = TreId, SqlType = SqlDbType.UniqueIdentifier });
            Items.Add(new AutoItem { Name = "TenTre", Value = TenTre, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "Tongtien", Value = Tongtien, SqlType = SqlDbType.Float });

            return DataToAutoObject(Items.ToArray());
        }
    }
}
