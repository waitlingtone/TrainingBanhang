using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IChitietHoadonView : IView
    {
        List<ChitietHoadonModel> ChitietHoadonItems { get; set; }
        ChitietHoadonModel ChitietHoadonCurrent { get; }

        List<HanghoaModel> HanghoaItems { get; }
    }
}
