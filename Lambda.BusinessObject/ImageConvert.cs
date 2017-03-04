using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.BusinessObject
{
    public class ImageConvert
    {
        public static Byte[] ConvertToBytes(Image image)
        {
            if (image == null)
                return null;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                var result = ms.ToArray();
                ms.Close();
                return result;
            }
        }
        public static Image ConvertToImage(Byte[] bytes)
        {
            if (bytes == null)
                return null;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                var result = Image.FromStream(ms);
                ms.Close();
                return result;
            }
        }
    }
}
