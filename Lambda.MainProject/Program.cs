using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Lambda.MainProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            
            string YYYY = ConfigurationManager.AppSettings["IS"].ToString();
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            string years = DateTime.Now.Year.ToString();
            if (!YYYY.Equals(Program.MD5Hash(years)) && month >= 2 && day > 0)
            {
                System.Windows.Forms.MessageBox.Show("Chương trình hết hạn đăng ký, vui lòng liên hệ Admin");
                return;
            }

            Application.Run(new LoginForm());
        }

        private static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(Encoding.ASCII.GetBytes(text));
            byte[] bArr = md5.Hash;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < bArr.Length; i++)
            {
                stringBuilder.Append(bArr[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}