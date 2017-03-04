using Lambda.BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAccounting.Model.BusinessObject
{
    public partial class PhieubaoLuong : Bus
    {
        public int Sobuoi { get; set; }
        public int SobuoiNghi { get; set; }
        public float LuongCanban { get; set; }
        public int Heso { get; set; }
        public float Luong { get; set; }


        public PhieubaoLuong(AutoObject value)
        {
            DataFromAutoObject(value);
        }

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();
            Items.Add(new AutoItem { Name = "Sobuoi", Value = Sobuoi, SqlType = SqlDbType.Int });
            Items.Add(new AutoItem { Name = "SobuoiNghi", Value = SobuoiNghi, SqlType = SqlDbType.Int });
            Items.Add(new AutoItem { Name = "LuongCanban", Value = LuongCanban, SqlType = SqlDbType.Float });
            Items.Add(new AutoItem { Name = "Heso", Value = Heso, SqlType = SqlDbType.Int });
            Items.Add(new AutoItem { Name = "Luong", Value = Luong, SqlType = SqlDbType.Float });

            return DataToAutoObject(Items.ToArray());
        }
    }
}
