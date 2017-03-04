using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IBackupInfoView:IView
    {
        List<BackupInfoModel> InfoItems { set; }
        string NameFile { get; }
        string Path { get; }
    }
}
