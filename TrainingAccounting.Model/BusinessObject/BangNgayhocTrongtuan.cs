using Lambda.BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAccounting.Model.BusinessObject
{
    public class BangNgayhocTrongtuan:Bus
    {
        public bool Thu2 { get; set; }
        public bool Thu3 { get; set; }
        public bool Thu4 { get; set; }
        public bool Thu5 { get; set; }
        public bool Thu6 { get; set; }
        public bool Thu7 { get; set; }
        public bool Thu8 { get; set; }
        public Guid? CahocId { get; set; }
        public String TenCa { get; set;}
        public String GioBatdau { get; set; }
        public String GioKetthuc { get; set; }
        public BangNgayhocTrongtuan(AutoObject value)
        {
            DataFromAutoObject(value);
        }

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();
            Items.Add(new AutoItem { Name = "Thu2", Value = Thu2, SqlType = SqlDbType.Bit });
            Items.Add(new AutoItem { Name = "Thu3", Value = Thu3, SqlType = SqlDbType.Bit });
            Items.Add(new AutoItem { Name = "Thu4", Value = Thu4, SqlType = SqlDbType.Bit });
            Items.Add(new AutoItem { Name = "Thu5", Value = Thu5, SqlType = SqlDbType.Bit });
            Items.Add(new AutoItem { Name = "Thu6", Value = Thu6, SqlType = SqlDbType.Bit });
            Items.Add(new AutoItem { Name = "Thu7", Value = Thu7, SqlType = SqlDbType.Bit });
            Items.Add(new AutoItem { Name = "Thu8", Value = Thu8, SqlType = SqlDbType.Bit });
            Items.Add(new AutoItem { Name = "CahocId", Value = CahocId, SqlType = SqlDbType.UniqueIdentifier });
            Items.Add(new AutoItem { Name = "TenCa", Value = TenCa, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "GioBatdau", Value = GioBatdau, SqlType = SqlDbType.VarChar });
            Items.Add(new AutoItem { Name = "GioKetthuc", Value = GioKetthuc, SqlType = SqlDbType.VarChar });
            return DataToAutoObject(Items.ToArray());
        }
    }
}
