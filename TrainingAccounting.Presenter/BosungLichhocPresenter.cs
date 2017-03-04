using Lambda.BusinessObject;
using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;
using TrainingAccounting.View;

namespace TrainingAccounting.Presenter
{
    public class BosungLichhocPresenter:Presenter<IBosungLichhocView>
    {
        public BosungLichhocPresenter(IBosungLichhocView view) : base(view) { }
        public void LoadData()
        {
            View.CahocItems = Model.Get<CahocModel>("sys_CahocSelect");
            View.ThuItems = Model.Get<ThuModel>("sys_ThuSelect");
        }

        public void Save()
        {
            if (View.TreId == null)
                return;
            float Dongia = 0;

            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = View.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });

            var rs = Model.GetAutoObject(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetDongiaHocphiNyTreId" }).FirstOrDefault();
            if (rs != null && rs.Items[0].Value != null)
                Dongia = float.Parse(rs.Items[0].Value.ToString());

            items.Add(new AutoItem { Name = "Thang", Value = View.Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = View.Nam, SqlType = System.Data.SqlDbType.Int });
            PhieubaoHocphiModel phieubao = Model.Get<PhieubaoHocphiModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_KiemtraTontaiPhieubaoHocphiByTreId" }).FirstOrDefault();
            if (phieubao == null)
                return;
            bool bosung = false;
            if (phieubao.Step != null && (phieubao.Step.Value == 2 || phieubao.Step.Value == 1)) //đã chốt học phí (đã đóng/ ghi nợ)
                bosung = true;
            List<LichhocDayhocModel> LichhocDayhocItems = new List<LichhocDayhocModel>();
            if(View.Laplai)
                for (var day = View.StartDate.Date; day.Date <= View.EndDate.Date; day = day.AddDays(1))
                {
                    DayOfWeek dow = day.DayOfWeek;
                    int _thu = (int)day.DayOfWeek + 1;

                    if (_thu == View.Thu)
                        LichhocDayhocItems.Add(new LichhocDayhocModel
                        {
                            DangkyHoc = true,
                            PhieubaoHocphiId = phieubao.PhieubaoHocphiId,
                            GioBatdau = new DateTime(day.Year, day.Month, day.Day, View.StartTime.Hours, View.StartTime.Minutes, 0),
                            GioKetthuc = new DateTime(day.Year, day.Month, day.Day, View.EndTime.Hours, View.EndTime.Minutes, 0),
                            DiemdanhTre = false,
                            VangHople = false,
                            DaTinhtien = false,
                            DiemdanhNhanvien = false,
                            Bosung = bosung,
                            Dongia = Dongia
                        });
                
                }
            else
                LichhocDayhocItems.Add(new LichhocDayhocModel
                {
                    DangkyHoc = true,
                    PhieubaoHocphiId = phieubao.PhieubaoHocphiId,
                    GioBatdau = new DateTime(View.Ngaychon.Year, View.Ngaychon.Month, View.Ngaychon.Day, View.StartTime.Hours, View.StartTime.Minutes, 0),
                    GioKetthuc = new DateTime(View.Ngaychon.Year, View.Ngaychon.Month, View.Ngaychon.Day, View.EndTime.Hours, View.EndTime.Minutes, 0),
                    DiemdanhTre = false,
                    VangHople = false,
                    DaTinhtien = false,
                    DiemdanhNhanvien = false,
                    Bosung = bosung,
                    Dongia = Dongia
                });
            Model.Set(LichhocDayhocItems);
        }
    }
}
