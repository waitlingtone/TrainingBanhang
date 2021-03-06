﻿using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.View
{
    public interface IDanhmucSachView:IView
    {
        List<SachModel> SachItems { get; set; }
        SachModel SachCurrent { get; }
        List<GiaSachModel> GiaSachItems { get; set; }
        GiaSachModel GiaSachCurrent { get; }
    }
}
