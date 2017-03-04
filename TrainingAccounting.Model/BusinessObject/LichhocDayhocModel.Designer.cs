using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TrainingAccounting.Model.BusinessObject
{
    public partial class LichhocDayhocModel
    {
        public String TenTre { get; set; }
        public DateTime NgaysinhTre { get; set; }
        public String TenNhanvien { get; set; }
        public String StartEnd
        {
            get { return String.Format("{0}-> {1}", GioBatdau.Value.TimeOfDay, GioKetthuc.Value.TimeOfDay); }
        }
        public int STT { get; set; }
        public String Text
        {
            get
            {
                return String.Format("{0}-{1}\r\nGV: {2}\r\nNội dung: {3}", GioBatdau.Value.ToShortTimeString(), GioKetthuc.Value.ToShortTimeString(), TenNhanvien, Ghichu);
            }
        }
        public String Text2
        {
            //get;
            //set;
            get
            {
                string[] rs = new string[20];
                XmlDocument xmlDoc = new XmlDocument();
                string xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" +
                    "<myDataz xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Text3 + "</myDataz>";
                xmlDoc.LoadXml(xml);
                XmlNodeList parentNode = xmlDoc.GetElementsByTagName("ROOT");
                int i = 0;
                foreach (XmlNode childrenNode in parentNode)
                {
                    if (i == 20)
                        break;
                    rs[i++] = childrenNode.LastChild.InnerText;
                }
                return String.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n{6}\r\n{7}\r\n{8}\r\n{9}\r\n{10}\r\n{11}\r\n{12}\r\n{13}\r\n{14}\r\n{15}\r\n{16}\r\n{17}\r\n{18}\r\n{19}", rs);
            }
        }
        public String Text3 { get; set; }

        public String StringNgaysinh { get { return NgaysinhTre.ToShortDateString(); } }
    }
}
