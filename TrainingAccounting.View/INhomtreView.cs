using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface INhomtreView:IView
    {
        List<NhomTreModel> NhomtreItems { get; set; }
        NhomTreModel NhomtreCurrent { get; }
    }
}
