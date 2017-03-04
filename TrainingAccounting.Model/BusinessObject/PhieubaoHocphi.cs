using Lambda.BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAccounting.Model.BusinessObject
{
    public partial class PhieubaoHocphi:Bus
    {
        public int STT { get; set; }
        public int Thang { get; set; }
        public int thu { get; set; }
        public String Ngay { get; set; }
        public String Thoigian { get; set; }
        public float Sogio { get; set; }
        public int Sobuoi { get; set; }
        public float Tonggio { get; set; }
        public double Dongia { get; set; }
        public double Tongtien { get; set; }


        public PhieubaoHocphi(AutoObject value)
        {
            DataFromAutoObject(value);
        }

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();
            Items.Add(new AutoItem { Name = "STT", Value = STT, SqlType = SqlDbType.Int });
            Items.Add(new AutoItem { Name = "Thang", Value = Thang, SqlType = SqlDbType.Int });
            Items.Add(new AutoItem { Name = "thu", Value = thu, SqlType = SqlDbType.Int });
            Items.Add(new AutoItem { Name = "Ngay", Value = Ngay, SqlType = SqlDbType.VarChar });
            Items.Add(new AutoItem { Name = "Thoigian", Value = Thoigian, SqlType = SqlDbType.VarChar });
            Items.Add(new AutoItem { Name = "Sogio", Value = Sogio, SqlType = SqlDbType.Float });
            Items.Add(new AutoItem { Name = "Sobuoi", Value = Sobuoi, SqlType = SqlDbType.Int });
            Items.Add(new AutoItem { Name = "Tonggio", Value = Tonggio, SqlType = SqlDbType.Float });
            Items.Add(new AutoItem { Name = "Dongia", Value = Dongia, SqlType = SqlDbType.Float });
            Items.Add(new AutoItem { Name = "Tongtien", Value = Tongtien, SqlType = SqlDbType.Float });

            return DataToAutoObject(Items.ToArray());
        }
    }
}
