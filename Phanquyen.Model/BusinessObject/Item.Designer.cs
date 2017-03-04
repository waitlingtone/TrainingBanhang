using Lambda.BusinessObject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phanquyen.Model.BusinessObject
{
    public partial class Item
    {
        Image _ImageWin;
        public Image ImageWin
        {
            get 
            {
                if (Image == null)
                {
                    return null;
                }
                if (_ImageWin == null)
                {
                    _ImageWin = ImageConvert.ConvertToImage(Image);
                }
                return _ImageWin;
            }
            set 
            {
                if (value == null)
                {
                    Image = null;
                    return;
                }
                Image = ConvertToBytes(value);
            }
        }
        private Byte[] ConvertToBytes(Image image)
        {
            if (image == null)
                return null;
            Byte[] result;
            using (MemoryStream ms = new MemoryStream())
            {
                try
                {
                    image.Save(ms, image.RawFormat);
                    result = ms.ToArray();
                }
                catch {
                    image.Save(ms, ImageFormat.Png);
                    result = ms.ToArray();
                }
                ms.Close();
                return result;
            }
        }
        partial void OnImageChanged()
        {
            _ImageWin = null;
            OnPropertyChanged("ImageWin");
        }

        Image _LargeImageWin;
        public Image LargeImageWin
        {
            get
            {
                if (LargeImage == null)
                {
                    return null;
                }
                if (_LargeImageWin == null)
                {
                    _LargeImageWin = ImageConvert.ConvertToImage(LargeImage);
                }
                return _LargeImageWin;
            }
            set
            {
                if (value == null)
                {
                    LargeImage = null;
                    return;
                }
                LargeImage = ImageConvert.ConvertToBytes(value);
            }
        }
        partial void OnLargeImageChanged()
        {
            _LargeImageWin = null;
            OnPropertyChanged("LargeImageWin");
        }

    }
}
