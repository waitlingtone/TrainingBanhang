using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace Info
{
    public static class Info
    {
        public static Image image;
        public static String Luuy;
        public static bool PrintLuuy;
        public static void CreateImage()
        {
            Lambda.ClientModel.ModelCore model = new Lambda.ClientModel.ModelCore();
            ThongtinModel info = model.Get<ThongtinModel>("sys_ThongtinSelect").FirstOrDefault();
            if (info == null)
                image = null;
            else
            {
                Luuy = info.TextPhieubao;
                PrintLuuy = info.PrintText.Value;

                TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
                ImageConverter ic = new ImageConverter();

                Image img = (Image)ic.ConvertFrom(info.Logo);
                Bitmap flag = new Bitmap(500, 60);
                Graphics flagGraphics = Graphics.FromImage(flag);
                //flagGraphics.SmoothingMode = SmoothingMode.HighQuality;
                flagGraphics.Clear(Color.White);
                flagGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                flagGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                flagGraphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                //flagGraphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
                if (info.PrintLogo.Value)
                {
                    flagGraphics.DrawImage(img, new Rectangle(0, 0, 70, 60), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
                    if (info.PrintName.Value)
                        flagGraphics.DrawString(info.TenDonvi, new Font("Arial", 10, FontStyle.Italic), new SolidBrush(Color.Gray), new PointF(80F, 5F));
                    if (info.PrintAddress.Value)
                        flagGraphics.DrawString("Địa chỉ: " + info.Diachi, new Font("Arial", 9, FontStyle.Italic), new SolidBrush(Color.Gray), new PointF(80F, 23F));
                    if (info.PrintPhone.Value)
                        flagGraphics.DrawString("Số điện thoại: " + info.SoDienthoai, new Font("Arial", 9, FontStyle.Italic), new SolidBrush(Color.Gray), new PointF(80F, 40F));
                }
                else
                {
                    if (info.PrintName.Value)
                        flagGraphics.DrawString(info.TenDonvi, new Font("Arial", 10, FontStyle.Italic), new SolidBrush(Color.Gray), new PointF(0F, 5F));
                    if (info.PrintAddress.Value)
                        flagGraphics.DrawString("Địa chỉ: " + info.Diachi, new Font("Arial", 9, FontStyle.Italic), new SolidBrush(Color.Gray), new PointF(0F, 23F));
                    if (info.PrintPhone.Value)
                        flagGraphics.DrawString("Số điện thoại: " + info.SoDienthoai, new Font("Arial", 9, FontStyle.Italic), new SolidBrush(Color.Gray), new PointF(0F, 40F));
                }
                image = (Image)flag;
            }
        }
    }
}
