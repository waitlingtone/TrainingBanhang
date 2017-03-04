using Lambda.BusinessObject;
using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;
using TrainingAccounting.View;
using System.Configuration;
using System.Data.SqlClient;

namespace TrainingAccounting.Presenter
{
    public class BackupInfoPresenter:Presenter<IBackupInfoView>
    {
        public BackupInfoPresenter(IBackupInfoView view):base(view){}

        public void LoadData()
        {
            View.InfoItems = Model.Get<BackupInfoModel>("sys_BackupInfoSelect");
            View.RefreshData();
        }

        public void BackupData()
        {
            BackupInfoModel bak = new BackupInfoModel();
            bak.Time = DateTime.Now;
            bak.TenFile = View.NameFile;
            bak.Path = View.Path;
            string StringConn = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
            string query = "BACKUP DATABASE TrainingAccouting TO DISK = '"+ View.Path + "' " +
                "INSERT INTO [BackupInfo]([BackupInfoId], [NguoidungId], [Time], [TenFile], [Path]) VALUES ('" + bak.BackupInfoId + "', NULL, '" + bak.Time + "', '" + bak.TenFile + "', '" + bak.Path + "')";
            SqlConnection conn = new SqlConnection(StringConn);
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
