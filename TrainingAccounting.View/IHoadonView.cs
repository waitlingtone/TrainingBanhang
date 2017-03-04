using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IHoadonView : IView
    {
        List<HoadonModel> HoadonItems { get; set; }
        HoadonModel HoadonCurrent { get; }

        List<HanghoaModel> HanghoaItems { set;}

        List<ChitietHoadonModel> ChitietHoadonItems { get; set; }
        ChitietHoadonModel ChitietHoadonCurrent { get; }
    }
}
