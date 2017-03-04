using Lambda.BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAccounting.Model.BusinessObject
{
    public partial class ChitietPhieubaoHocphi : Bus
    {
        public int STT { get; set; }
        public int thu { get; set; }
        public DateTime Ngay { get; set; }
        public String Thoigian { get; set; }
        public float Sogio { get; set; }
        public bool Vang { get; set; }
        public bool VangHople { get; set; }
        public double Dongia { get; set; }
        public double Tongtien { get; set; }
        public String Mota { get; set; }

        public ChitietPhieubaoHocphi(AutoObject value)
        {
            DataFromAutoObject(value);
        }

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();
            Items.Add(new AutoItem { Name = "STT", Value = STT, SqlType = SqlDbType.Int });
            Items.Add(new AutoItem { Name = "thu", Value = thu, SqlType = SqlDbType.Int });
            Items.Add(new AutoItem { Name = "Ngay", Value = Ngay, SqlType = SqlDbType.DateTime });
            Items.Add(new AutoItem { Name = "Thoigian", Value = Thoigian, SqlType = SqlDbType.VarChar });
            Items.Add(new AutoItem { Name = "Sogio", Value = Sogio, SqlType = SqlDbType.Float });
            Items.Add(new AutoItem { Name = "Vang", Value = Vang, SqlType = SqlDbType.Bit });
            Items.Add(new AutoItem { Name = "VangHople", Value = VangHople, SqlType = SqlDbType.Bit });
            Items.Add(new AutoItem { Name = "Dongia", Value = Dongia, SqlType = SqlDbType.Float });
            Items.Add(new AutoItem { Name = "Tongtien", Value = Tongtien, SqlType = SqlDbType.Float });
            Items.Add(new AutoItem { Name = "Mota", Value = Mota, SqlType = SqlDbType.VarChar });

            return DataToAutoObject(Items.ToArray());
        }
    }
}
